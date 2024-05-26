namespace Szyfrowanie4
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnOpneFile = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.labelEncryptedKey = new System.Windows.Forms.Label();
            this.inputEncryptedAesKey = new System.Windows.Forms.TextBox();
            this.inputPrivateRSAKey = new System.Windows.Forms.TextBox();
            this.labelPrivateRSAKey = new System.Windows.Forms.Label();
            this.labelFileName = new System.Windows.Forms.Label();
            this.inputPublicRSAKey = new System.Windows.Forms.TextBox();
            this.labelPublicRSA = new System.Windows.Forms.Label();
            this.inputEncryptedIV = new System.Windows.Forms.TextBox();
            this.labelEncryptedIV = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fileDialog
            // 
            this.fileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // btnOpneFile
            // 
            this.btnOpneFile.Location = new System.Drawing.Point(12, 28);
            this.btnOpneFile.Name = "btnOpneFile";
            this.btnOpneFile.Size = new System.Drawing.Size(75, 23);
            this.btnOpneFile.TabIndex = 0;
            this.btnOpneFile.Text = "Otwórz plik";
            this.btnOpneFile.UseVisualStyleBackColor = true;
            this.btnOpneFile.Click += new System.EventHandler(this.btnOpneFile_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Enabled = false;
            this.btnEncrypt.Location = new System.Drawing.Point(12, 84);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(75, 23);
            this.btnEncrypt.TabIndex = 1;
            this.btnEncrypt.Text = "Zaszyfruj";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Enabled = false;
            this.btnDecrypt.Location = new System.Drawing.Point(12, 113);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(75, 23);
            this.btnDecrypt.TabIndex = 2;
            this.btnDecrypt.Text = "Odszyfruj";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // labelEncryptedKey
            // 
            this.labelEncryptedKey.AutoSize = true;
            this.labelEncryptedKey.Location = new System.Drawing.Point(191, 28);
            this.labelEncryptedKey.Name = "labelEncryptedKey";
            this.labelEncryptedKey.Size = new System.Drawing.Size(121, 13);
            this.labelEncryptedKey.TabIndex = 3;
            this.labelEncryptedKey.Text = "Zaszyfrowany klucz Aes";
            // 
            // inputEncryptedAesKey
            // 
            this.inputEncryptedAesKey.Location = new System.Drawing.Point(194, 44);
            this.inputEncryptedAesKey.Name = "inputEncryptedAesKey";
            this.inputEncryptedAesKey.Size = new System.Drawing.Size(205, 20);
            this.inputEncryptedAesKey.TabIndex = 4;
            // 
            // inputPrivateRSAKey
            // 
            this.inputPrivateRSAKey.Location = new System.Drawing.Point(194, 128);
            this.inputPrivateRSAKey.Name = "inputPrivateRSAKey";
            this.inputPrivateRSAKey.Size = new System.Drawing.Size(205, 20);
            this.inputPrivateRSAKey.TabIndex = 6;
            // 
            // labelPrivateRSAKey
            // 
            this.labelPrivateRSAKey.AutoSize = true;
            this.labelPrivateRSAKey.Location = new System.Drawing.Point(191, 112);
            this.labelPrivateRSAKey.Name = "labelPrivateRSAKey";
            this.labelPrivateRSAKey.Size = new System.Drawing.Size(103, 13);
            this.labelPrivateRSAKey.TabIndex = 5;
            this.labelPrivateRSAKey.Text = "Klucz prywatny RSA";
            // 
            // labelFileName
            // 
            this.labelFileName.AutoSize = true;
            this.labelFileName.Location = new System.Drawing.Point(12, 9);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(0, 13);
            this.labelFileName.TabIndex = 7;
            // 
            // inputPublicRSAKey
            // 
            this.inputPublicRSAKey.Location = new System.Drawing.Point(194, 170);
            this.inputPublicRSAKey.Name = "inputPublicRSAKey";
            this.inputPublicRSAKey.Size = new System.Drawing.Size(205, 20);
            this.inputPublicRSAKey.TabIndex = 9;
            // 
            // labelPublicRSA
            // 
            this.labelPublicRSA.AutoSize = true;
            this.labelPublicRSA.Location = new System.Drawing.Point(191, 154);
            this.labelPublicRSA.Name = "labelPublicRSA";
            this.labelPublicRSA.Size = new System.Drawing.Size(105, 13);
            this.labelPublicRSA.TabIndex = 8;
            this.labelPublicRSA.Text = "Klucz publiczny RSA";
            // 
            // inputEncryptedIV
            // 
            this.inputEncryptedIV.Location = new System.Drawing.Point(194, 84);
            this.inputEncryptedIV.Name = "inputEncryptedIV";
            this.inputEncryptedIV.Size = new System.Drawing.Size(205, 20);
            this.inputEncryptedIV.TabIndex = 11;
            // 
            // labelEncryptedIV
            // 
            this.labelEncryptedIV.AutoSize = true;
            this.labelEncryptedIV.Location = new System.Drawing.Point(191, 68);
            this.labelEncryptedIV.Name = "labelEncryptedIV";
            this.labelEncryptedIV.Size = new System.Drawing.Size(85, 13);
            this.labelEncryptedIV.TabIndex = 10;
            this.labelEncryptedIV.Text = "Zaszyfrowany IV";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 331);
            this.Controls.Add(this.inputEncryptedIV);
            this.Controls.Add(this.labelEncryptedIV);
            this.Controls.Add(this.inputPublicRSAKey);
            this.Controls.Add(this.labelPublicRSA);
            this.Controls.Add(this.labelFileName);
            this.Controls.Add(this.inputPrivateRSAKey);
            this.Controls.Add(this.labelPrivateRSAKey);
            this.Controls.Add(this.inputEncryptedAesKey);
            this.Controls.Add(this.labelEncryptedKey);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.btnOpneFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog fileDialog;
        private System.Windows.Forms.Button btnOpneFile;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Label labelEncryptedKey;
        private System.Windows.Forms.TextBox inputEncryptedAesKey;
        private System.Windows.Forms.TextBox inputPrivateRSAKey;
        private System.Windows.Forms.Label labelPrivateRSAKey;
        private System.Windows.Forms.Label labelFileName;
        private System.Windows.Forms.TextBox inputPublicRSAKey;
        private System.Windows.Forms.Label labelPublicRSA;
        private System.Windows.Forms.TextBox inputEncryptedIV;
        private System.Windows.Forms.Label labelEncryptedIV;
    }
}

