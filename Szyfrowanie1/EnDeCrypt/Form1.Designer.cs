namespace EnDeCrypt
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
            this.labelKey = new System.Windows.Forms.Label();
            this.inputKey = new System.Windows.Forms.TextBox();
            this.inputIV = new System.Windows.Forms.TextBox();
            this.labelIV = new System.Windows.Forms.Label();
            this.inputDecryptedHEX = new System.Windows.Forms.TextBox();
            this.labelDecryptedHEX = new System.Windows.Forms.Label();
            this.inputDecryptedASCII = new System.Windows.Forms.TextBox();
            this.labelDecryptedASCII = new System.Windows.Forms.Label();
            this.inputEncryptedHEX = new System.Windows.Forms.TextBox();
            this.labelEncryptedHEX = new System.Windows.Forms.Label();
            this.inputEncryptedASCII = new System.Windows.Forms.TextBox();
            this.labelEncryptedASCII = new System.Windows.Forms.Label();
            this.labelPlainText = new System.Windows.Forms.Label();
            this.labelCipherText = new System.Windows.Forms.Label();
            this.comboCipherAlgorithm = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboKeySize = new System.Windows.Forms.ComboBox();
            this.btnGenerateKey = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.labelEncryptionTime = new System.Windows.Forms.Label();
            this.labelDecryptionTime = new System.Windows.Forms.Label();
            this.labelEncryptionTimeValue = new System.Windows.Forms.Label();
            this.labelDecryptionTimeValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelKey
            // 
            this.labelKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelKey.AutoSize = true;
            this.labelKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelKey.Location = new System.Drawing.Point(282, 27);
            this.labelKey.Name = "labelKey";
            this.labelKey.Size = new System.Drawing.Size(35, 20);
            this.labelKey.TabIndex = 0;
            this.labelKey.Text = "Key";
            // 
            // inputKey
            // 
            this.inputKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inputKey.Font = new System.Drawing.Font("Arial", 10F);
            this.inputKey.Location = new System.Drawing.Point(328, 25);
            this.inputKey.MaxLength = 64;
            this.inputKey.Name = "inputKey";
            this.inputKey.Size = new System.Drawing.Size(492, 23);
            this.inputKey.TabIndex = 1;
            // 
            // inputIV
            // 
            this.inputIV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inputIV.Font = new System.Drawing.Font("Arial", 10F);
            this.inputIV.Location = new System.Drawing.Point(328, 70);
            this.inputIV.MaxLength = 64;
            this.inputIV.Name = "inputIV";
            this.inputIV.Size = new System.Drawing.Size(492, 23);
            this.inputIV.TabIndex = 3;
            // 
            // labelIV
            // 
            this.labelIV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelIV.AutoSize = true;
            this.labelIV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelIV.Location = new System.Drawing.Point(292, 69);
            this.labelIV.Name = "labelIV";
            this.labelIV.Size = new System.Drawing.Size(25, 20);
            this.labelIV.TabIndex = 2;
            this.labelIV.Text = "IV";
            // 
            // inputDecryptedHEX
            // 
            this.inputDecryptedHEX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inputDecryptedHEX.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.inputDecryptedHEX.Location = new System.Drawing.Point(328, 188);
            this.inputDecryptedHEX.Name = "inputDecryptedHEX";
            this.inputDecryptedHEX.ReadOnly = true;
            this.inputDecryptedHEX.Size = new System.Drawing.Size(492, 26);
            this.inputDecryptedHEX.TabIndex = 7;
            // 
            // labelDecryptedHEX
            // 
            this.labelDecryptedHEX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDecryptedHEX.AutoSize = true;
            this.labelDecryptedHEX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDecryptedHEX.Location = new System.Drawing.Point(274, 188);
            this.labelDecryptedHEX.Name = "labelDecryptedHEX";
            this.labelDecryptedHEX.Size = new System.Drawing.Size(43, 20);
            this.labelDecryptedHEX.TabIndex = 6;
            this.labelDecryptedHEX.Text = "HEX";
            // 
            // inputDecryptedASCII
            // 
            this.inputDecryptedASCII.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inputDecryptedASCII.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.inputDecryptedASCII.Location = new System.Drawing.Point(328, 143);
            this.inputDecryptedASCII.Name = "inputDecryptedASCII";
            this.inputDecryptedASCII.Size = new System.Drawing.Size(492, 26);
            this.inputDecryptedASCII.TabIndex = 5;
            this.inputDecryptedASCII.TextChanged += new System.EventHandler(this.inputDecryptedASCII_TextChanged);
            // 
            // labelDecryptedASCII
            // 
            this.labelDecryptedASCII.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDecryptedASCII.AutoSize = true;
            this.labelDecryptedASCII.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDecryptedASCII.Location = new System.Drawing.Point(270, 143);
            this.labelDecryptedASCII.Name = "labelDecryptedASCII";
            this.labelDecryptedASCII.Size = new System.Drawing.Size(52, 20);
            this.labelDecryptedASCII.TabIndex = 4;
            this.labelDecryptedASCII.Text = "ASCII";
            // 
            // inputEncryptedHEX
            // 
            this.inputEncryptedHEX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inputEncryptedHEX.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.inputEncryptedHEX.Location = new System.Drawing.Point(328, 291);
            this.inputEncryptedHEX.Name = "inputEncryptedHEX";
            this.inputEncryptedHEX.ReadOnly = true;
            this.inputEncryptedHEX.Size = new System.Drawing.Size(492, 26);
            this.inputEncryptedHEX.TabIndex = 11;
            // 
            // labelEncryptedHEX
            // 
            this.labelEncryptedHEX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelEncryptedHEX.AutoSize = true;
            this.labelEncryptedHEX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEncryptedHEX.Location = new System.Drawing.Point(274, 291);
            this.labelEncryptedHEX.Name = "labelEncryptedHEX";
            this.labelEncryptedHEX.Size = new System.Drawing.Size(43, 20);
            this.labelEncryptedHEX.TabIndex = 10;
            this.labelEncryptedHEX.Text = "HEX";
            // 
            // inputEncryptedASCII
            // 
            this.inputEncryptedASCII.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inputEncryptedASCII.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.inputEncryptedASCII.Location = new System.Drawing.Point(328, 246);
            this.inputEncryptedASCII.Name = "inputEncryptedASCII";
            this.inputEncryptedASCII.Size = new System.Drawing.Size(492, 26);
            this.inputEncryptedASCII.TabIndex = 9;
            this.inputEncryptedASCII.TextChanged += new System.EventHandler(this.inputEncryptedASCII_TextChanged);
            // 
            // labelEncryptedASCII
            // 
            this.labelEncryptedASCII.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelEncryptedASCII.AutoSize = true;
            this.labelEncryptedASCII.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEncryptedASCII.Location = new System.Drawing.Point(270, 246);
            this.labelEncryptedASCII.Name = "labelEncryptedASCII";
            this.labelEncryptedASCII.Size = new System.Drawing.Size(52, 20);
            this.labelEncryptedASCII.TabIndex = 8;
            this.labelEncryptedASCII.Text = "ASCII";
            // 
            // labelPlainText
            // 
            this.labelPlainText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPlainText.AutoSize = true;
            this.labelPlainText.Location = new System.Drawing.Point(328, 127);
            this.labelPlainText.Name = "labelPlainText";
            this.labelPlainText.Size = new System.Drawing.Size(50, 13);
            this.labelPlainText.TabIndex = 12;
            this.labelPlainText.Text = "Plain text";
            // 
            // labelCipherText
            // 
            this.labelCipherText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCipherText.AutoSize = true;
            this.labelCipherText.Location = new System.Drawing.Point(328, 230);
            this.labelCipherText.Name = "labelCipherText";
            this.labelCipherText.Size = new System.Drawing.Size(57, 13);
            this.labelCipherText.TabIndex = 13;
            this.labelCipherText.Text = "Cipher text";
            // 
            // comboCipherAlgorithm
            // 
            this.comboCipherAlgorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCipherAlgorithm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.comboCipherAlgorithm.FormattingEnabled = true;
            this.comboCipherAlgorithm.Items.AddRange(new object[] {
            "Aes",
            "Aes Managed",
            "DES",
            "TripleDES",
            "Rijndael Managed"});
            this.comboCipherAlgorithm.Location = new System.Drawing.Point(7, 25);
            this.comboCipherAlgorithm.Name = "comboCipherAlgorithm";
            this.comboCipherAlgorithm.Size = new System.Drawing.Size(116, 26);
            this.comboCipherAlgorithm.TabIndex = 14;
            this.comboCipherAlgorithm.SelectedIndexChanged += new System.EventHandler(this.comboCipherAlgorithm_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Encryption algorithm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(126, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Key length";
            // 
            // comboKeySize
            // 
            this.comboKeySize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboKeySize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.comboKeySize.FormattingEnabled = true;
            this.comboKeySize.Location = new System.Drawing.Point(129, 25);
            this.comboKeySize.Name = "comboKeySize";
            this.comboKeySize.Size = new System.Drawing.Size(104, 26);
            this.comboKeySize.TabIndex = 18;
            this.comboKeySize.SelectedIndexChanged += new System.EventHandler(this.comboKeySize_SelectedIndexChanged);
            // 
            // btnGenerateKey
            // 
            this.btnGenerateKey.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateKey.Location = new System.Drawing.Point(7, 63);
            this.btnGenerateKey.Name = "btnGenerateKey";
            this.btnGenerateKey.Size = new System.Drawing.Size(226, 33);
            this.btnGenerateKey.TabIndex = 19;
            this.btnGenerateKey.Text = "Generate new Key and IV";
            this.btnGenerateKey.UseVisualStyleBackColor = true;
            this.btnGenerateKey.Click += new System.EventHandler(this.btnGenerateKey_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncrypt.Location = new System.Drawing.Point(7, 136);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(226, 33);
            this.btnEncrypt.TabIndex = 20;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecrypt.Location = new System.Drawing.Point(7, 239);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(226, 33);
            this.btnDecrypt.TabIndex = 21;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // labelEncryptionTime
            // 
            this.labelEncryptionTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelEncryptionTime.AutoSize = true;
            this.labelEncryptionTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelEncryptionTime.Location = new System.Drawing.Point(4, 188);
            this.labelEncryptionTime.Name = "labelEncryptionTime";
            this.labelEncryptionTime.Size = new System.Drawing.Size(109, 17);
            this.labelEncryptionTime.TabIndex = 22;
            this.labelEncryptionTime.Text = "Encryption time:";
            // 
            // labelDecryptionTime
            // 
            this.labelDecryptionTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDecryptionTime.AutoSize = true;
            this.labelDecryptionTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelDecryptionTime.Location = new System.Drawing.Point(4, 291);
            this.labelDecryptionTime.Name = "labelDecryptionTime";
            this.labelDecryptionTime.Size = new System.Drawing.Size(110, 17);
            this.labelDecryptionTime.TabIndex = 23;
            this.labelDecryptionTime.Text = "Decryption time:";
            // 
            // labelEncryptionTimeValue
            // 
            this.labelEncryptionTimeValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelEncryptionTimeValue.AutoSize = true;
            this.labelEncryptionTimeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelEncryptionTimeValue.Location = new System.Drawing.Point(115, 188);
            this.labelEncryptionTimeValue.Name = "labelEncryptionTimeValue";
            this.labelEncryptionTimeValue.Size = new System.Drawing.Size(35, 17);
            this.labelEncryptionTimeValue.TabIndex = 24;
            this.labelEncryptionTimeValue.Text = "0.0s";
            // 
            // labelDecryptionTimeValue
            // 
            this.labelDecryptionTimeValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDecryptionTimeValue.AutoSize = true;
            this.labelDecryptionTimeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelDecryptionTimeValue.Location = new System.Drawing.Point(115, 294);
            this.labelDecryptionTimeValue.Name = "labelDecryptionTimeValue";
            this.labelDecryptionTimeValue.Size = new System.Drawing.Size(35, 17);
            this.labelDecryptionTimeValue.TabIndex = 25;
            this.labelDecryptionTimeValue.Text = "0.0s";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(832, 328);
            this.Controls.Add(this.labelDecryptionTimeValue);
            this.Controls.Add(this.labelEncryptionTimeValue);
            this.Controls.Add(this.labelDecryptionTime);
            this.Controls.Add(this.labelEncryptionTime);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.btnGenerateKey);
            this.Controls.Add(this.comboKeySize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboCipherAlgorithm);
            this.Controls.Add(this.labelCipherText);
            this.Controls.Add(this.labelPlainText);
            this.Controls.Add(this.inputEncryptedHEX);
            this.Controls.Add(this.labelEncryptedHEX);
            this.Controls.Add(this.inputEncryptedASCII);
            this.Controls.Add(this.labelEncryptedASCII);
            this.Controls.Add(this.inputDecryptedHEX);
            this.Controls.Add(this.labelDecryptedHEX);
            this.Controls.Add(this.inputDecryptedASCII);
            this.Controls.Add(this.labelDecryptedASCII);
            this.Controls.Add(this.inputIV);
            this.Controls.Add(this.labelIV);
            this.Controls.Add(this.inputKey);
            this.Controls.Add(this.labelKey);
            this.MaximumSize = new System.Drawing.Size(848, 367);
            this.MinimumSize = new System.Drawing.Size(848, 367);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelKey;
        private System.Windows.Forms.TextBox inputKey;
        private System.Windows.Forms.TextBox inputIV;
        private System.Windows.Forms.Label labelIV;
        private System.Windows.Forms.TextBox inputDecryptedHEX;
        private System.Windows.Forms.Label labelDecryptedHEX;
        private System.Windows.Forms.TextBox inputDecryptedASCII;
        private System.Windows.Forms.Label labelDecryptedASCII;
        private System.Windows.Forms.TextBox inputEncryptedHEX;
        private System.Windows.Forms.Label labelEncryptedHEX;
        private System.Windows.Forms.TextBox inputEncryptedASCII;
        private System.Windows.Forms.Label labelEncryptedASCII;
        private System.Windows.Forms.Label labelPlainText;
        private System.Windows.Forms.Label labelCipherText;
        private System.Windows.Forms.ComboBox comboCipherAlgorithm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboKeySize;
        private System.Windows.Forms.Button btnGenerateKey;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Label labelEncryptionTime;
        private System.Windows.Forms.Label labelDecryptionTime;
        private System.Windows.Forms.Label labelEncryptionTimeValue;
        private System.Windows.Forms.Label labelDecryptionTimeValue;
    }
}

