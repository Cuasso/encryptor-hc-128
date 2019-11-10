using application;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace encryptor_hc_128
{
    public partial class CryptoMain : Form
    {
        private string _textFilePath;

        public CryptoMain()
        {
            InitializeComponent();
        }

        private void BtImageUpload_Click(object sender, System.EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog
                {
                    Filter = "jpg files(*.lpg)|*.jpg| PNG files(*.png)|*.png"
                };
                if( dialog.ShowDialog() == DialogResult.OK)
                {
                    var imageLocation = dialog.FileName;
                    pbImage.ImageLocation = imageLocation;
                    btCrypto.Enabled = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtCrypto_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(pbImage.ImageLocation))
            {
                var bitmap = new Bitmap(pbImage.ImageLocation);
                var textImage = ImageToString(bitmap);
                var data = EncryptDecrypt(Encoding.ASCII.GetBytes(textImage));
                var text = Convert.ToBase64String(data);
                try
                {
                    
                    File.WriteAllText($"{GetPath(pbImage.ImageLocation)}.txt", text);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            } else
            {
                MessageBox.Show("Debe seleccionar una imagen primero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtTextFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                Filter = "Text|*.txt|All|*.*"
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                _textFilePath = dialog.FileName;
                lblTextFile.Text = $"El archivo a desencriptar es: {Path.GetFileName(dialog.FileName)}";
            }
        }

        private void BtDecrypt_Click(object sender, EventArgs e)
        {
            var text = File.ReadAllText(_textFilePath);
            var textImage = Encoding.ASCII.GetString(EncryptDecrypt(Convert.FromBase64String(text)));
            var image = StringToImage(textImage);
            image.Save($"{GetPath(_textFilePath)}.png", ImageFormat.Png);
        }



        #region Helpers functions
        private byte[] EncryptDecrypt(byte[] imageByteArray)
        {
            var key = Encoding.ASCII.GetBytes("pomarputo1111111");
            var iv = Encoding.ASCII.GetBytes("1234123412341234");
            var encryptor = new EncriptorHC128(key,iv);
            return encryptor.EncryptDecrypt(imageByteArray);
        }

        public string ImageToString(Image image)
        {
            using (MemoryStream m = new MemoryStream())
            {
                image.Save(m, image.RawFormat);
                byte[] imageBytes = m.ToArray();

                // Convert byte[] to Base64 String
                string base64String = Convert.ToBase64String(imageBytes);
                return base64String;
            }
        }

        public Image StringToImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0,
              imageBytes.Length);

            // Convert byte[] to Image
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }

        public string GetPath(string path) =>$"{Path.GetDirectoryName(path)}\\{Path.GetFileNameWithoutExtension(pbImage.ImageLocation)}";
        #endregion
    }
}
