using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Reflection.Emit;

namespace SummationApp
{
    public class MainForm : Form
    {
        private TextBox textBoxNum1;
        private TextBox textBoxNum2;
        private Label labelResult;
        private Button buttonCalculate;

        public MainForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.textBoxNum1 = new TextBox();
            this.textBoxNum2 = new TextBox();
            this.labelResult = new Label();
            this.buttonCalculate = new Button();
            this.SuspendLayout();

            
            this.textBoxNum1.Location = new System.Drawing.Point(30, 30);
            this.textBoxNum1.Name = "textBoxNum1";
            this.textBoxNum1.Size = new System.Drawing.Size(100, 20);
            this.textBoxNum1.TabIndex = 0;

            
            this.textBoxNum2.Location = new System.Drawing.Point(30, 60);
            this.textBoxNum2.Name = "textBoxNum2";
            this.textBoxNum2.Size = new System.Drawing.Size(100, 20);
            this.textBoxNum2.TabIndex = 1;

            
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(30, 90);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 13);
            this.labelResult.TabIndex = 2;

            
            this.buttonCalculate.Location = new System.Drawing.Point(30, 120);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(100, 23);
            this.buttonCalculate.TabIndex = 3;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);

           
            this.ClientSize = new System.Drawing.Size(200, 170);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.textBoxNum2);
            this.Controls.Add(this.textBoxNum1);
            this.Name = "MainForm";
            this.Text = "Summation App";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = int.Parse(textBoxNum1.Text);
                int num2 = int.Parse(textBoxNum2.Text);
                int sum = num1 + num2;
                labelResult.Text = "Sum: " + sum;
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input. Please enter valid numbers.");
            }
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new MainForm());
        }
    }
}
