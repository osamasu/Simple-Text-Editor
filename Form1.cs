using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Word___Text_Editor
{
    public partial class Form1 : Form
    {
        private void _initializeFontsInFontsComboBox()
        {
            InstalledFontCollection fonts = new InstalledFontCollection();

            foreach (FontFamily font in fonts.Families)
            {
                CB_FONTS.Items.Add(font.Name);
            }

            CB_FONTS.SelectedIndex = 16;
        }
        public Form1()
        {
            InitializeComponent();

            MainStyle = FontStyle.Regular;

            _initializeFontsInFontsComboBox();
            numericUpDown1.Value = (Decimal)textBox1.Font.Size;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            colorDialog1.AnyColor = true;
            colorDialog1.FullOpen = true;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                _ChangeColour(colorDialog1.Color);
            }
        }

        private void _ChangeBackColour(System.Drawing.Color ColourToChange)
        {


            if (textBox1.SelectionLength == 0)
            {
                textBox1.BackColor = ColourToChange;
                return;
            }

            textBox1.SelectionBackColor = ColourToChange;
        }

        private void _ChangeForeColour(System.Drawing.Color ColourToChange)
        {
            if (textBox1.SelectionLength == 0)
            {
                textBox1.ForeColor = ColourToChange;
                return;
            }

            textBox1.SelectionColor = ColourToChange;
        }
        private void _ChangeColour(System.Drawing.Color ColourToChange)
        {

            if (RD_BackColor.Checked)
            {
                _ChangeBackColour(ColourToChange);
            }
            else
                _ChangeForeColour(ColourToChange);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

            CB_FONTS_SelectedIndexChanged(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _ChangeColour(System.Drawing.Color.Crimson);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            _ChangeColour(System.Drawing.Color.DarkBlue);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            _ChangeColour(System.Drawing.Color.Magenta);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            _ChangeColour(System.Drawing.Color.Orange);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            _ChangeColour(System.Drawing.Color.Yellow);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            _ChangeColour(System.Drawing.Color.Green);
        }








        public FontStyle MainStyle = new FontStyle();

        private void CB_FONTS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (textBox1.SelectionLength == 0)
            {
                textBox1.Font = new Font(CB_FONTS.Items[CB_FONTS.SelectedIndex].ToString(),
                    (float)numericUpDown1.Value, this.MainStyle);
            }
            else
            {
                textBox1.SelectionFont = new Font(CB_FONTS.Items[CB_FONTS.SelectedIndex].ToString(),
                    (float)numericUpDown1.Value, this.MainStyle);
            }
        }


        private void _FontStyleChanged(object sender, EventArgs e, FontStyle Stylee)
        {

            CheckBox MycheckBox = (CheckBox)sender;

            if (MycheckBox.Checked)
            {
                MainStyle = MainStyle | Stylee;
                CB_FONTS_SelectedIndexChanged(sender, e);
            }
            else
            {
                MainStyle = MainStyle ^ Stylee;
                CB_FONTS_SelectedIndexChanged(sender, e);

            }
        }

        private void CK_Bold_CheckedChanged(object sender, EventArgs e)
        {
            _FontStyleChanged(sender, e, FontStyle.Bold);
        }

        private void CB_Italic_CheckedChanged(object sender, EventArgs e)
        {
            _FontStyleChanged(sender, e, FontStyle.Italic);
        }

        private void CB_Strikeout_CheckedChanged(object sender, EventArgs e)
        {
            _FontStyleChanged(sender, e, FontStyle.Strikeout);
        }

        private void CB_Underlined_CheckedChanged(object sender, EventArgs e)
        {
            _FontStyleChanged(sender, e, FontStyle.Underline);
        }









        //private void pnl1_Click(object sender, EventArgs e)
        //{

        //    SetColor(((Panel)sender).BackColor);
        //}

        //private void btnMoreColor_Click(object sender, EventArgs e)
        //{
        //    ColorDialog dialog = new ColorDialog();
        //    if (dialog.ShowDialog() == DialogResult.OK)
        //    {
        //        SetColor(dialog.Color);
        //    }
        //}

    }
}
