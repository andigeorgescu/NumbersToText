using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Humanizer;

namespace NumbersToText
{
    public partial class Form1 : Form
    {
        public Form1()
        {
                
            InitializeComponent();

            LangListBox.DataSource = CultureInfo.GetCultures(CultureTypes.InstalledWin32Cultures);
        }


        private void SubmitConvert(object sender, EventArgs e)
        {
            int txtBox;

            bool isNumber = Int32.TryParse(NoInput.Text, out txtBox);
            String intToText = txtBox.ToWords(new CultureInfo(LangListBox.GetItemText(LangListBox.SelectedItem)));
            if (isNumber == true)
            {
                if (intToText.Contains(NoInput.Text)) MessageBox.Show("Language not supported yet!");
                else MessageBox.Show(intToText);
            }
            else MessageBox.Show("Please insert a number");

        }


    }
}
