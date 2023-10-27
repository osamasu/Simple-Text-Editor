namespace Word___Text_Editor
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.RichTextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.Btn_ColorDialog = new FontAwesome.Sharp.IconButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.RD_BackColor = new System.Windows.Forms.RadioButton();
            this.RD_TextColour = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.CK_Bold = new System.Windows.Forms.CheckBox();
            this.CB_Italic = new System.Windows.Forms.CheckBox();
            this.CB_Underlined = new System.Windows.Forms.CheckBox();
            this.CB_Strikeout = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.CB_FONTS = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Poppins Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(3, 124);
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.textBox1.Size = new System.Drawing.Size(895, 403);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "";
            // 
            // Btn_ColorDialog
            // 
            this.Btn_ColorDialog.BackColor = System.Drawing.Color.PapayaWhip;
            this.Btn_ColorDialog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ColorDialog.Font = new System.Drawing.Font("Dungeon", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ColorDialog.IconChar = FontAwesome.Sharp.IconChar.PiedPiper;
            this.Btn_ColorDialog.IconColor = System.Drawing.Color.Black;
            this.Btn_ColorDialog.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_ColorDialog.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Btn_ColorDialog.Location = new System.Drawing.Point(713, 26);
            this.Btn_ColorDialog.Name = "Btn_ColorDialog";
            this.Btn_ColorDialog.Size = new System.Drawing.Size(176, 83);
            this.Btn_ColorDialog.TabIndex = 1;
            this.Btn_ColorDialog.Text = "More Colours";
            this.Btn_ColorDialog.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_ColorDialog.UseVisualStyleBackColor = false;
            this.Btn_ColorDialog.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(653, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 54);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkBlue;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(653, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(54, 54);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Green;
            this.button3.FlatAppearance.BorderSize = 2;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(593, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(54, 54);
            this.button3.TabIndex = 5;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Magenta;
            this.button4.FlatAppearance.BorderSize = 2;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(593, 67);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(54, 54);
            this.button4.TabIndex = 4;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Yellow;
            this.button5.FlatAppearance.BorderSize = 2;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(533, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(54, 54);
            this.button5.TabIndex = 7;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Orange;
            this.button6.FlatAppearance.BorderSize = 2;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(533, 67);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(54, 54);
            this.button6.TabIndex = 6;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // RD_BackColor
            // 
            this.RD_BackColor.AutoSize = true;
            this.RD_BackColor.FlatAppearance.BorderSize = 5;
            this.RD_BackColor.Font = new System.Drawing.Font("Poppins", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RD_BackColor.Location = new System.Drawing.Point(27, 8);
            this.RD_BackColor.Name = "RD_BackColor";
            this.RD_BackColor.Size = new System.Drawing.Size(91, 35);
            this.RD_BackColor.TabIndex = 8;
            this.RD_BackColor.Text = "Back";
            this.RD_BackColor.UseVisualStyleBackColor = true;
            // 
            // RD_TextColour
            // 
            this.RD_TextColour.AutoSize = true;
            this.RD_TextColour.Checked = true;
            this.RD_TextColour.FlatAppearance.BorderSize = 5;
            this.RD_TextColour.Font = new System.Drawing.Font("Poppins", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RD_TextColour.Location = new System.Drawing.Point(27, 57);
            this.RD_TextColour.Name = "RD_TextColour";
            this.RD_TextColour.Size = new System.Drawing.Size(82, 35);
            this.RD_TextColour.TabIndex = 9;
            this.RD_TextColour.TabStop = true;
            this.RD_TextColour.Text = "Text";
            this.RD_TextColour.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RD_TextColour);
            this.panel1.Controls.Add(this.RD_BackColor);
            this.panel1.Location = new System.Drawing.Point(397, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(128, 101);
            this.panel1.TabIndex = 10;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.AllowDrop = true;
            this.numericUpDown1.Location = new System.Drawing.Point(298, 17);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(80, 24);
            this.numericUpDown1.TabIndex = 11;
            this.numericUpDown1.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tribes", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(234, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Size";
            // 
            // CK_Bold
            // 
            this.CK_Bold.AutoSize = true;
            this.CK_Bold.Font = new System.Drawing.Font("Tribes", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CK_Bold.Location = new System.Drawing.Point(12, 62);
            this.CK_Bold.Name = "CK_Bold";
            this.CK_Bold.Size = new System.Drawing.Size(76, 21);
            this.CK_Bold.TabIndex = 13;
            this.CK_Bold.Text = "Bold";
            this.CK_Bold.UseVisualStyleBackColor = true;
            this.CK_Bold.CheckedChanged += new System.EventHandler(this.CK_Bold_CheckedChanged);
            // 
            // CB_Italic
            // 
            this.CB_Italic.AutoSize = true;
            this.CB_Italic.Font = new System.Drawing.Font("Tribes", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Italic.Location = new System.Drawing.Point(12, 87);
            this.CB_Italic.Name = "CB_Italic";
            this.CB_Italic.Size = new System.Drawing.Size(82, 21);
            this.CB_Italic.TabIndex = 14;
            this.CB_Italic.Text = "Italic";
            this.CB_Italic.UseVisualStyleBackColor = true;
            this.CB_Italic.CheckedChanged += new System.EventHandler(this.CB_Italic_CheckedChanged);
            // 
            // CB_Underlined
            // 
            this.CB_Underlined.AutoSize = true;
            this.CB_Underlined.Font = new System.Drawing.Font("Tribes", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Underlined.Location = new System.Drawing.Point(12, 12);
            this.CB_Underlined.Name = "CB_Underlined";
            this.CB_Underlined.Size = new System.Drawing.Size(134, 21);
            this.CB_Underlined.TabIndex = 15;
            this.CB_Underlined.Text = "Underline";
            this.CB_Underlined.UseVisualStyleBackColor = true;
            this.CB_Underlined.CheckedChanged += new System.EventHandler(this.CB_Underlined_CheckedChanged);
            // 
            // CB_Strikeout
            // 
            this.CB_Strikeout.AutoSize = true;
            this.CB_Strikeout.Font = new System.Drawing.Font("Tribes", 10.2F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Strikeout.Location = new System.Drawing.Point(12, 37);
            this.CB_Strikeout.Name = "CB_Strikeout";
            this.CB_Strikeout.Size = new System.Drawing.Size(128, 21);
            this.CB_Strikeout.TabIndex = 16;
            this.CB_Strikeout.Text = "StrikeOut";
            this.CB_Strikeout.UseVisualStyleBackColor = true;
            this.CB_Strikeout.CheckedChanged += new System.EventHandler(this.CB_Strikeout_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(148, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 112);
            this.panel2.TabIndex = 17;
            // 
            // CB_FONTS
            // 
            this.CB_FONTS.DisplayMember = "5";
            this.CB_FONTS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_FONTS.Font = new System.Drawing.Font("Farsi Simple Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.CB_FONTS.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CB_FONTS.FormattingEnabled = true;
            this.CB_FONTS.Location = new System.Drawing.Point(164, 74);
            this.CB_FONTS.Name = "CB_FONTS";
            this.CB_FONTS.Size = new System.Drawing.Size(227, 37);
            this.CB_FONTS.Sorted = true;
            this.CB_FONTS.TabIndex = 18;
            this.CB_FONTS.ValueMember = "5";
            this.CB_FONTS.SelectedIndexChanged += new System.EventHandler(this.CB_FONTS_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tribes", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(164, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Font";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(901, 529);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CB_FONTS);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.CB_Strikeout);
            this.Controls.Add(this.CB_Underlined);
            this.Controls.Add(this.CB_Italic);
            this.Controls.Add(this.CK_Bold);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Btn_ColorDialog);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox textBox1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private FontAwesome.Sharp.IconButton Btn_ColorDialog;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.RadioButton RD_BackColor;
        private System.Windows.Forms.RadioButton RD_TextColour;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox CK_Bold;
        private System.Windows.Forms.CheckBox CB_Italic;
        private System.Windows.Forms.CheckBox CB_Underlined;
        private System.Windows.Forms.CheckBox CB_Strikeout;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ComboBox CB_FONTS;
        private System.Windows.Forms.Label label2;
    }
}

