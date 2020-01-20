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



            str = Convert.ToString(Input_Text.Text);
            Numerat_Input = (int)Numeration.Value;
            Numerat_Conclusion = (int)Numeration_Con.Value;

            tmp.Scheme_transfer(Numerat_Input, Numerat_Conclusion, str);

            Conclusion_label.Text = Convert.ToString(tmp.Conclusion);
            tmp.Conclusion = 0;
        }
    }
}
