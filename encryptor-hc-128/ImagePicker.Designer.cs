namespace encryptor_hc_128
{
    partial class CryptoMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.lbCrypto = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbMessage = new System.Windows.Forms.Label();
            this.btImageUpload = new System.Windows.Forms.Button();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.btCrypto = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btDecrypt = new System.Windows.Forms.Button();
            this.lblTextFile = new System.Windows.Forms.Label();
            this.SidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.Maroon;
            this.SidePanel.Controls.Add(this.lbCrypto);
            this.SidePanel.Location = new System.Drawing.Point(0, 0);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(200, 451);
            this.SidePanel.TabIndex = 0;
            // 
            // lbCrypto
            // 
            this.lbCrypto.AutoSize = true;
            this.lbCrypto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCrypto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbCrypto.Location = new System.Drawing.Point(25, 22);
            this.lbCrypto.Name = "lbCrypto";
            this.lbCrypto.Size = new System.Drawing.Size(133, 50);
            this.lbCrypto.TabIndex = 0;
            this.lbCrypto.Text = "Encriptador\r\nHC-128\r\n";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(211, 69);
            this.panel1.TabIndex = 1;
            // 
            // lbMessage
            // 
            this.lbMessage.AutoSize = true;
            this.lbMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMessage.ForeColor = System.Drawing.Color.White;
            this.lbMessage.Location = new System.Drawing.Point(226, 27);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(352, 18);
            this.lbMessage.TabIndex = 1;
            this.lbMessage.Text = "Seleccione una imagen para encriptar / desencriptar.";
            // btImageUpload
            // 
            this.btImageUpload.BackColor = System.Drawing.Color.Maroon;
            this.btImageUpload.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btImageUpload.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btImageUpload.ForeColor = System.Drawing.Color.Transparent;
            this.btImageUpload.Location = new System.Drawing.Point(229, 73);
            this.btImageUpload.Name = "btImageUpload";
            this.btImageUpload.Size = new System.Drawing.Size(104, 44);
            this.btImageUpload.TabIndex = 2;
            this.btImageUpload.Text = "Cargar Imagen";
            this.btImageUpload.UseVisualStyleBackColor = false;
            this.btImageUpload.Click += new System.EventHandler(this.BtImageUpload_Click);
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(387, 73);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(297, 176);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 3;
            this.pbImage.TabStop = false;
            // 
            // btCrypto
            // 
            this.btCrypto.BackColor = System.Drawing.Color.Maroon;
            this.btCrypto.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btCrypto.Enabled = false;
            this.btCrypto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btCrypto.ForeColor = System.Drawing.Color.Transparent;
            this.btCrypto.Location = new System.Drawing.Point(229, 138);
            this.btCrypto.Name = "btCrypto";
            this.btCrypto.Size = new System.Drawing.Size(104, 44);
            this.btCrypto.TabIndex = 4;
            this.btCrypto.Text = "Encriptar";
            this.btCrypto.UseVisualStyleBackColor = false;
            this.btCrypto.Click += new System.EventHandler(this.BtCrypto_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btDecrypt
            // 
            this.btDecrypt.AllowDrop = true;
            this.btCrypto.Enabled = false;
            this.btDecrypt.BackColor = System.Drawing.Color.Maroon;
            this.btDecrypt.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btDecrypt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btDecrypt.ForeColor = System.Drawing.Color.Transparent;
            this.btDecrypt.Location = new System.Drawing.Point(229, 205);
            this.btDecrypt.Name = "btDecrypt";
            this.btDecrypt.Size = new System.Drawing.Size(104, 44);
            this.btDecrypt.TabIndex = 6;
            this.btDecrypt.Text = "Desencriptar";
            this.btDecrypt.UseVisualStyleBackColor = false;
            this.btDecrypt.Click += new System.EventHandler(this.BtDecrypt_Click);
            // 
            // lblTextFile
            // 
            this.lblTextFile.AutoSize = true;
            this.lblTextFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextFile.ForeColor = System.Drawing.Color.White;
            this.lblTextFile.Location = new System.Drawing.Point(384, 308);
            this.lblTextFile.Name = "lblTextFile";
            this.lblTextFile.Size = new System.Drawing.Size(0, 18);
            this.lblTextFile.TabIndex = 9;
            // 
            // CryptoMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTextFile);
            this.Controls.Add(this.btDecrypt);
            this.Controls.Add(this.btCrypto);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.btImageUpload);
            this.Controls.Add(this.lbMessage);
            this.Controls.Add(this.SidePanel);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Name = "CryptoMain";
            this.Text = "ImagePicker";
            this.SidePanel.ResumeLayout(false);
            this.SidePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbCrypto;
        private System.Windows.Forms.Label lbMessage;
        private System.Windows.Forms.Button btImageUpload;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Button btCrypto;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btDecrypt;
        private System.Windows.Forms.Label lblTextFile;
    }
}