using System;
using System.Data;

namespace Historia_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AttachEventHandlers();
            textBox1.ReadOnly = true;
            textBox1.TextAlign = HorizontalAlignment.Right;
        }

        private void AttachEventHandlers()
        {
            button1.Click += ButtonClick;
            button2.Click += ButtonClick;
            button3.Click += ButtonClick;
            button4.Click += ButtonClick;
            button5.Click += ButtonClick;
            button6.Click += ButtonClick;
            button7.Click += ButtonClick;
            button8.Click += ButtonClick;
            button9.Click += ButtonClick;
            button10.Click += ButtonClick;
            button11.Click += ButtonClick;
            button12.Click += ButtonClick;
            button13.Click += ButtonClick;
            button14.Click += ButtonClick;
            button15.Click += ButtonClick;
            button16.Click += ButtonClick;
            button17.Click += ButtonClick;
            button18.Click += ButtonClick;
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string buttonText = btn.Text;

            if (buttonText == "C")
            {
                textBox1.Text = "";
            }
            else if (buttonText == "DEL")
            {
                if (textBox1.Text.Length > 0)
                {
                    textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                }
            }
            else if (buttonText == "=")
            {
                try
                {
                    DataTable dt = new DataTable();
                    var result = dt.Compute(textBox1.Text, "");
                    textBox1.Text = result.ToString();
                }
                catch
                {
                    textBox1.Text = "Error";
                }
            }
            else
            {
                textBox1.Text += buttonText;
            }
        }

      
    }
}
