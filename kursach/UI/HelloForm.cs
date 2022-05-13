using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Confectionery.UI
{
    public partial class HelloForm : Form
    {
        public HelloForm()
        {
            InitializeComponent();
            var now = DateTime.Now;
            if (now.Hour >= 4 && now.Hour <= 10)
            {
                helloLabel.Text = "Доброе утро";
            }
            else if (now.Hour >= 11 && now.Hour <= 16)
            {
                helloLabel.Text = "Добрый день!";
            }
            else if (now.Hour >= 17 && now.Hour <= 21)
            {
                helloLabel.Text = "Добрый вечер!";
            }
            else
            {
                helloLabel.Text = "Доброй ночи!";
            }
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            var form = new Form1();
            Program.Context.MainForm = form;
            Close();
            form.Show();
        }
    }
}
