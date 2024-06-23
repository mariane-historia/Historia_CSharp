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
            num7.Click += ButtonClick;
            num8.Click += ButtonClick;
            num9.Click += ButtonClick;
            plus.Click += ButtonClick;
            num4.Click += ButtonClick;
            num5.Click += ButtonClick;
            num6.Click += ButtonClick;
            minus.Click += ButtonClick;
            num1.Click += ButtonClick;
            num2.Click += ButtonClick;
            num3.Click += ButtonClick;
            multiply.Click += ButtonClick;
            period.Click += ButtonClick;
            num0.Click += ButtonClick;
            equals.Click += ButtonClick;
            divide.Click += ButtonClick;
            c.Click += ButtonClick;
            del.Click += ButtonClick;
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
