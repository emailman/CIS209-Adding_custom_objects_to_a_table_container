using System;
using System.Drawing;
using System.Windows.Forms;

namespace Adding_table_container
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            RoundButton bulb = (RoundButton)sender;
            bulb.BackColor = Color.Red;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            RoundButton[] buttons = { btn1, btn2, btn3, btn4 };
            foreach (var button in buttons)
                button.BackColor = Color.AntiqueWhite;
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            RoundButton[] buttons = { btn1, btn2, btn3, btn4 };
            foreach (var button in buttons)
                button.BackColor = Color.Red;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RoundButton[] buttons = { btn1, btn2, btn3, btn4 };
            foreach (var button in buttons)
                button.BackColor = Color.AntiqueWhite;
        }
    }
}
