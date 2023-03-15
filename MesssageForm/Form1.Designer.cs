namespace MesssageForm
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fontnamebox = new System.Windows.Forms.ComboBox();
            this.fontsizebox = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.koyucheck = new System.Windows.Forms.CheckBox();
            this.italiccheck = new System.Windows.Forms.CheckBox();
            this.writelbl = new System.Windows.Forms.TextBox();
            this.viewlbl = new System.Windows.Forms.Label();
            this.colorlabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fontsizebox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bebas Neue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(27, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Font Style";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(49, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "COLOR";
            // 
            // fontnamebox
            // 
            this.fontnamebox.FormattingEnabled = true;
            this.fontnamebox.Location = new System.Drawing.Point(107, 38);
            this.fontnamebox.Name = "fontnamebox";
            this.fontnamebox.Size = new System.Drawing.Size(185, 21);
            this.fontnamebox.TabIndex = 3;
            this.fontnamebox.SelectedIndexChanged += new System.EventHandler(this.fontnamebox_SelectedIndexChanged);
            // 
            // fontsizebox
            // 
            this.fontsizebox.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fontsizebox.Location = new System.Drawing.Point(298, 36);
            this.fontsizebox.Maximum = new decimal(new int[] {
            36,
            0,
            0,
            0});
            this.fontsizebox.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.fontsizebox.Name = "fontsizebox";
            this.fontsizebox.Size = new System.Drawing.Size(57, 26);
            this.fontsizebox.TabIndex = 4;
            this.fontsizebox.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Font = new System.Drawing.Font("Bahnschrift Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(107, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 27);
            this.button1.TabIndex = 5;
            this.button1.Text = "Choose";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 6;
            // 
            // koyucheck
            // 
            this.koyucheck.AutoSize = true;
            this.koyucheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.koyucheck.Location = new System.Drawing.Point(361, 37);
            this.koyucheck.Name = "koyucheck";
            this.koyucheck.Size = new System.Drawing.Size(61, 22);
            this.koyucheck.TabIndex = 7;
            this.koyucheck.Text = "Bold";
            this.koyucheck.UseVisualStyleBackColor = true;
            this.koyucheck.CheckedChanged += new System.EventHandler(this.koyucheck_CheckedChanged);
            // 
            // italiccheck
            // 
            this.italiccheck.AutoSize = true;
            this.italiccheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.italiccheck.Location = new System.Drawing.Point(428, 37);
            this.italiccheck.Name = "italiccheck";
            this.italiccheck.Size = new System.Drawing.Size(56, 22);
            this.italiccheck.TabIndex = 8;
            this.italiccheck.Text = "Italic";
            this.italiccheck.UseVisualStyleBackColor = true;
            this.italiccheck.CheckedChanged += new System.EventHandler(this.italiccheck_CheckedChanged);
            // 
            // writelbl
            // 
            this.writelbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.writelbl.Location = new System.Drawing.Point(30, 116);
            this.writelbl.Multiline = true;
            this.writelbl.Name = "writelbl";
            this.writelbl.Size = new System.Drawing.Size(465, 144);
            this.writelbl.TabIndex = 9;
            this.writelbl.TextChanged += new System.EventHandler(this.writelbl_TextChanged);
            // 
            // viewlbl
            // 
            this.viewlbl.Location = new System.Drawing.Point(30, 282);
            this.viewlbl.Name = "viewlbl";
            this.viewlbl.Size = new System.Drawing.Size(465, 91);
            this.viewlbl.TabIndex = 10;
            this.viewlbl.Text = "label4";
            // 
            // colorlabel
            // 
            this.colorlabel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.colorlabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorlabel.Location = new System.Drawing.Point(181, 74);
            this.colorlabel.Name = "colorlabel";
            this.colorlabel.Size = new System.Drawing.Size(42, 26);
            this.colorlabel.TabIndex = 11;
            this.colorlabel.Text = "label4";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Bahnschrift Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(510, 34);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Top left";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Bahnschrift Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(587, 34);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Top center";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Bahnschrift Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(680, 34);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 14;
            this.button4.Text = "Top right";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Bahnschrift Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.Location = new System.Drawing.Point(510, 65);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(71, 23);
            this.button5.TabIndex = 15;
            this.button5.Text = "Middle left";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Bahnschrift Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.Location = new System.Drawing.Point(587, 65);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(87, 23);
            this.button6.TabIndex = 16;
            this.button6.Text = "Middle Center";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Bahnschrift Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button7.Location = new System.Drawing.Point(680, 65);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 17;
            this.button7.Text = "Middle right";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Bahnschrift Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button8.Location = new System.Drawing.Point(510, 94);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(71, 23);
            this.button8.TabIndex = 18;
            this.button8.Text = "Bottom left";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Bahnschrift Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button9.Location = new System.Drawing.Point(587, 94);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(87, 23);
            this.button9.TabIndex = 19;
            this.button9.Text = "Bottom center";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Bahnschrift Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button10.Location = new System.Drawing.Point(680, 94);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 20;
            this.button10.Text = "Bottom right";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(768, 396);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.colorlabel);
            this.Controls.Add(this.viewlbl);
            this.Controls.Add(this.writelbl);
            this.Controls.Add(this.italiccheck);
            this.Controls.Add(this.koyucheck);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fontsizebox);
            this.Controls.Add(this.fontnamebox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fontsizebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox fontnamebox;
        private System.Windows.Forms.NumericUpDown fontsizebox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox koyucheck;
        private System.Windows.Forms.CheckBox italiccheck;
        private System.Windows.Forms.TextBox writelbl;
        private System.Windows.Forms.Label viewlbl;
        private System.Windows.Forms.Label colorlabel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
    }
}

