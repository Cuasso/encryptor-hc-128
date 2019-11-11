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
                    btDecrypt.Enabled = btCrypto.Enabled = true;
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
                var textImage = ImageToByteArray(bitmap);
                var data = EncryptDecrypt(textImage);
                
                try
                {
                    File.WriteAllBytes($"{GetPath(pbImage.ImageLocation)}encrypted.png", data);
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

            if (!string.IsNullOrEmpty(pbImage.ImageLocation))
            {
                var bytes = File.ReadAllBytes(pbImage.ImageLocation);
                var imageBytes = EncryptDecrypt(bytes);              
                try
                {
                    var image = ByteArrayToImage(imageBytes);
                    var path = GetPath(pbImage.ImageLocation).Replace("encrypted", "");
                    image.Save($"{path}.png", ImageFormat.Png);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Debe seleccionar una imagen primero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Helpers functions
        private byte[] EncryptDecrypt(byte[] imageByteArray)
        {
            var key = Encoding.ASCII.GetBytes("pomarputo1111111");
            var iv = Encoding.ASCII.GetBytes("1234123412341234");
            var encryptor = new EncriptorHC128(key,iv);
            return encryptor.EncryptDecrypt(imageByteArray);
        }

        public byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream m = new MemoryStream())
            {
                image.Save(m, image.RawFormat);
                byte[] imageBytes = m.ToArray();
                return imageBytes;
            }
        }

        public Image ByteArrayToImage(byte[] imageByte)
        {
            MemoryStream ms = new MemoryStream(imageByte, 0,
              imageByte.Length);

            // Convert byte[] to Image
            ms.Write(imageByte, 0, imageByte.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }

        public string GetPath(string path) =>$"{Path.GetDirectoryName(path)}\\{Path.GetFileNameWithoutExtension(pbImage.ImageLocation)}";
        #endregion
    }
}
