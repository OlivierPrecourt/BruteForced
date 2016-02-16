namespace BruteForced
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHash = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkSpecials = new System.Windows.Forms.CheckBox();
            this.checkNumbers = new System.Windows.Forms.CheckBox();
            this.checkUppers = new System.Windows.Forms.CheckBox();
            this.checkLowers = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.check9 = new System.Windows.Forms.CheckBox();
            this.check10 = new System.Windows.Forms.CheckBox();
            this.check7 = new System.Windows.Forms.CheckBox();
            this.check8 = new System.Windows.Forms.CheckBox();
            this.check6 = new System.Windows.Forms.CheckBox();
            this.check5 = new System.Windows.Forms.CheckBox();
            this.check3 = new System.Windows.Forms.CheckBox();
            this.check4 = new System.Windows.Forms.CheckBox();
            this.check2 = new System.Windows.Forms.CheckBox();
            this.check1 = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioSHA256 = new System.Windows.Forms.RadioButton();
            this.radioSHA224 = new System.Windows.Forms.RadioButton();
            this.radioMD5 = new System.Windows.Forms.RadioButton();
            this.btnBruteForce = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.labelInfos = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtHash);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 72);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Brute force...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hash:";
            // 
            // txtHash
            // 
            this.txtHash.Location = new System.Drawing.Point(63, 32);
            this.txtHash.Name = "txtHash";
            this.txtHash.Size = new System.Drawing.Size(283, 20);
            this.txtHash.TabIndex = 2;
            this.txtHash.TextChanged += new System.EventHandler(this.txtHash_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkSpecials);
            this.groupBox2.Controls.Add(this.checkNumbers);
            this.groupBox2.Controls.Add(this.checkUppers);
            this.groupBox2.Controls.Add(this.checkLowers);
            this.groupBox2.Location = new System.Drawing.Point(13, 178);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(365, 74);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Containing...";
            // 
            // checkSpecials
            // 
            this.checkSpecials.AutoSize = true;
            this.checkSpecials.Location = new System.Drawing.Point(118, 21);
            this.checkSpecials.Name = "checkSpecials";
            this.checkSpecials.Size = new System.Drawing.Size(90, 17);
            this.checkSpecials.TabIndex = 3;
            this.checkSpecials.Text = "Special chars";
            this.checkSpecials.UseVisualStyleBackColor = true;
            // 
            // checkNumbers
            // 
            this.checkNumbers.AutoSize = true;
            this.checkNumbers.Location = new System.Drawing.Point(118, 44);
            this.checkNumbers.Name = "checkNumbers";
            this.checkNumbers.Size = new System.Drawing.Size(68, 17);
            this.checkNumbers.TabIndex = 2;
            this.checkNumbers.Text = "Numbers";
            this.checkNumbers.UseVisualStyleBackColor = true;
            // 
            // checkUppers
            // 
            this.checkUppers.AutoSize = true;
            this.checkUppers.Location = new System.Drawing.Point(14, 44);
            this.checkUppers.Name = "checkUppers";
            this.checkUppers.Size = new System.Drawing.Size(84, 17);
            this.checkUppers.TabIndex = 1;
            this.checkUppers.Text = "Upper chars";
            this.checkUppers.UseVisualStyleBackColor = true;
            // 
            // checkLowers
            // 
            this.checkLowers.AutoSize = true;
            this.checkLowers.Location = new System.Drawing.Point(14, 21);
            this.checkLowers.Name = "checkLowers";
            this.checkLowers.Size = new System.Drawing.Size(84, 17);
            this.checkLowers.TabIndex = 0;
            this.checkLowers.Text = "Lower chars";
            this.checkLowers.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.check9);
            this.groupBox3.Controls.Add(this.check10);
            this.groupBox3.Controls.Add(this.check7);
            this.groupBox3.Controls.Add(this.check8);
            this.groupBox3.Controls.Add(this.check6);
            this.groupBox3.Controls.Add(this.check5);
            this.groupBox3.Controls.Add(this.check3);
            this.groupBox3.Controls.Add(this.check4);
            this.groupBox3.Controls.Add(this.check2);
            this.groupBox3.Controls.Add(this.check1);
            this.groupBox3.Location = new System.Drawing.Point(13, 258);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(365, 74);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Of lenght...";
            // 
            // check9
            // 
            this.check9.AutoSize = true;
            this.check9.Location = new System.Drawing.Point(264, 21);
            this.check9.Name = "check9";
            this.check9.Size = new System.Drawing.Size(32, 17);
            this.check9.TabIndex = 9;
            this.check9.Text = "9";
            this.check9.UseVisualStyleBackColor = true;
            // 
            // check10
            // 
            this.check10.AutoSize = true;
            this.check10.Location = new System.Drawing.Point(264, 44);
            this.check10.Name = "check10";
            this.check10.Size = new System.Drawing.Size(38, 17);
            this.check10.TabIndex = 8;
            this.check10.Text = "10";
            this.check10.UseVisualStyleBackColor = true;
            // 
            // check7
            // 
            this.check7.AutoSize = true;
            this.check7.Location = new System.Drawing.Point(205, 21);
            this.check7.Name = "check7";
            this.check7.Size = new System.Drawing.Size(32, 17);
            this.check7.TabIndex = 7;
            this.check7.Text = "7";
            this.check7.UseVisualStyleBackColor = true;
            // 
            // check8
            // 
            this.check8.AutoSize = true;
            this.check8.Location = new System.Drawing.Point(205, 44);
            this.check8.Name = "check8";
            this.check8.Size = new System.Drawing.Size(32, 17);
            this.check8.TabIndex = 6;
            this.check8.Text = "8";
            this.check8.UseVisualStyleBackColor = true;
            // 
            // check6
            // 
            this.check6.AutoSize = true;
            this.check6.Location = new System.Drawing.Point(143, 44);
            this.check6.Name = "check6";
            this.check6.Size = new System.Drawing.Size(32, 17);
            this.check6.TabIndex = 5;
            this.check6.Text = "6";
            this.check6.UseVisualStyleBackColor = true;
            // 
            // check5
            // 
            this.check5.AutoSize = true;
            this.check5.Location = new System.Drawing.Point(143, 21);
            this.check5.Name = "check5";
            this.check5.Size = new System.Drawing.Size(32, 17);
            this.check5.TabIndex = 4;
            this.check5.Text = "5";
            this.check5.UseVisualStyleBackColor = true;
            // 
            // check3
            // 
            this.check3.AutoSize = true;
            this.check3.Location = new System.Drawing.Point(76, 21);
            this.check3.Name = "check3";
            this.check3.Size = new System.Drawing.Size(32, 17);
            this.check3.TabIndex = 3;
            this.check3.Text = "3";
            this.check3.UseVisualStyleBackColor = true;
            // 
            // check4
            // 
            this.check4.AutoSize = true;
            this.check4.Location = new System.Drawing.Point(76, 44);
            this.check4.Name = "check4";
            this.check4.Size = new System.Drawing.Size(32, 17);
            this.check4.TabIndex = 2;
            this.check4.Text = "4";
            this.check4.UseVisualStyleBackColor = true;
            // 
            // check2
            // 
            this.check2.AutoSize = true;
            this.check2.Location = new System.Drawing.Point(14, 44);
            this.check2.Name = "check2";
            this.check2.Size = new System.Drawing.Size(32, 17);
            this.check2.TabIndex = 1;
            this.check2.Text = "2";
            this.check2.UseVisualStyleBackColor = true;
            // 
            // check1
            // 
            this.check1.AutoSize = true;
            this.check1.Location = new System.Drawing.Point(14, 21);
            this.check1.Name = "check1";
            this.check1.Size = new System.Drawing.Size(32, 17);
            this.check1.TabIndex = 0;
            this.check1.Text = "1";
            this.check1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioSHA256);
            this.groupBox4.Controls.Add(this.radioSHA224);
            this.groupBox4.Controls.Add(this.radioMD5);
            this.groupBox4.Location = new System.Drawing.Point(13, 91);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(365, 52);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Using...";
            // 
            // radioSHA256
            // 
            this.radioSHA256.AutoSize = true;
            this.radioSHA256.Enabled = false;
            this.radioSHA256.Location = new System.Drawing.Point(282, 22);
            this.radioSHA256.Name = "radioSHA256";
            this.radioSHA256.Size = new System.Drawing.Size(65, 17);
            this.radioSHA256.TabIndex = 6;
            this.radioSHA256.TabStop = true;
            this.radioSHA256.Text = "SHA256";
            this.radioSHA256.UseVisualStyleBackColor = true;
            // 
            // radioSHA224
            // 
            this.radioSHA224.AutoSize = true;
            this.radioSHA224.Enabled = false;
            this.radioSHA224.Location = new System.Drawing.Point(147, 22);
            this.radioSHA224.Name = "radioSHA224";
            this.radioSHA224.Size = new System.Drawing.Size(65, 17);
            this.radioSHA224.TabIndex = 5;
            this.radioSHA224.TabStop = true;
            this.radioSHA224.Text = "SHA224";
            this.radioSHA224.UseVisualStyleBackColor = true;
            // 
            // radioMD5
            // 
            this.radioMD5.AutoSize = true;
            this.radioMD5.Enabled = false;
            this.radioMD5.Location = new System.Drawing.Point(18, 22);
            this.radioMD5.Name = "radioMD5";
            this.radioMD5.Size = new System.Drawing.Size(48, 17);
            this.radioMD5.TabIndex = 4;
            this.radioMD5.TabStop = true;
            this.radioMD5.Text = "MD5";
            this.radioMD5.UseVisualStyleBackColor = true;
            // 
            // btnBruteForce
            // 
            this.btnBruteForce.Location = new System.Drawing.Point(131, 348);
            this.btnBruteForce.Name = "btnBruteForce";
            this.btnBruteForce.Size = new System.Drawing.Size(119, 41);
            this.btnBruteForce.TabIndex = 5;
            this.btnBruteForce.Text = "Brute force";
            this.btnBruteForce.UseVisualStyleBackColor = true;
            this.btnBruteForce.Click += new System.EventHandler(this.BruteForcePressed);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.labelInfos);
            this.groupBox5.Location = new System.Drawing.Point(13, 406);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(366, 72);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            // 
            // labelInfos
            // 
            this.labelInfos.AutoSize = true;
            this.labelInfos.BackColor = System.Drawing.Color.Lime;
            this.labelInfos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfos.Location = new System.Drawing.Point(13, 29);
            this.labelInfos.Name = "labelInfos";
            this.labelInfos.Size = new System.Drawing.Size(0, 25);
            this.labelInfos.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 490);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.btnBruteForce);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "BruteForced";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHash;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkUppers;
        private System.Windows.Forms.CheckBox checkLowers;
        private System.Windows.Forms.CheckBox checkSpecials;
        private System.Windows.Forms.CheckBox checkNumbers;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox check3;
        private System.Windows.Forms.CheckBox check4;
        private System.Windows.Forms.CheckBox check2;
        private System.Windows.Forms.CheckBox check1;
        private System.Windows.Forms.CheckBox check9;
        private System.Windows.Forms.CheckBox check10;
        private System.Windows.Forms.CheckBox check7;
        private System.Windows.Forms.CheckBox check8;
        private System.Windows.Forms.CheckBox check6;
        private System.Windows.Forms.CheckBox check5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radioSHA256;
        private System.Windows.Forms.RadioButton radioSHA224;
        private System.Windows.Forms.RadioButton radioMD5;
        private System.Windows.Forms.Button btnBruteForce;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label labelInfos;

    }
}

