using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Number_system.Properties;


namespace Number_system
{
    public partial class Main_window : Form
    {
        Translation_Numbers tmp = new Translation_Numbers();
        public Main_window()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            string str;
            int Numerat_Input;
            int Numerat_Conclusion;

            str = Input_Text.Text;
            Numerat_Input = (int)Numeration.Value;
            Numerat_Conclusion = (int)Numeration_Con.Value;


            Conclusion_texBox.Text = tmp.Scheme_transfer(Numerat_Input, Numerat_Conclusion, str);

        }

        private void Label_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Label_Close_MouseEnter(object sender, EventArgs e)
        {
            Label_Close.ForeColor = Color.Red;

        }

        private void Label_Close_MouseLeave(object sender, EventArgs e)
        {
            Label_Close.ForeColor = Color.White;
        }

        Point lastPoint;
        private void Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}
