using System;
using System.Windows.Forms;

namespace encryptor_hc_128
{
    public partial class CryptoMain : Form
    {
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
                //AQUI DEBERIAMOS ENCRIPTAR LA IMAGEN
            } else
            {
                MessageBox.Show("Debe seleccionar una imagen primero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
