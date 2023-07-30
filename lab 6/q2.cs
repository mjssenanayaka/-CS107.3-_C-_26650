using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Reflection.Emit;

namespace ArithmeticOperationsApp
{
    public class MainForm : Form
    {
        private TextBox textBoxNum1;
        private TextBox textBoxNum2;
        private Label labelResult;
        private Button buttonAdd;
        private Button buttonSubtract;
        private Button buttonMultiply;
        private Button buttonDivide;

        public MainForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.textBoxNum1 = new TextBox();
            this.textBoxNum2 = new TextBox();
            this.labelResult = new Label();
            this.buttonAdd = new Button();
            this.buttonSubtract = new Button();
            this.buttonMultiply = new Button();
            this.buttonDivide = new Button();
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

            
            this.buttonAdd.Location = new System.Drawing.Point(30, 120);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(50, 23);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);

           
            this.buttonSubtract.Location = new System.Drawing.Point(90, 120);
            this.buttonSubtract.Name = "buttonSubtract";
            this.buttonSubtract.Size = new System.Drawing.Size(50, 23);
            this.buttonSubtract.TabIndex = 4;
            this.buttonSubtract.Text = "Sub";
            this.buttonSubtract.UseVisualStyleBackColor = true;
            this.buttonSubtract.Click += new System.EventHandler(this.buttonSubtract_Click);

            
            this.buttonMultiply.Location = new System.Drawing.Point(150, 120);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(50, 23);
            this.buttonMultiply.TabIndex = 5;
            this.buttonMultiply.Text = "Mul";
            this.buttonMultiply.UseVisualStyleBackColor = true;
            this.buttonMultiply.Click += new System.EventHandler(this.buttonMultiply_Click);

            
            this.buttonDivide.Location = new System.Drawing.Point(210, 120);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new System.Drawing.Size(50, 23);
            this.buttonDivide.TabIndex = 6;
            this.buttonDivide.Text = "Div";
            this.buttonDivide.UseVisualStyleBackColor = true;
            this.buttonDivide.Click += new System.EventHandler(this.buttonDivide_Click);

            
            this.ClientSize = new System.Drawing.Size(300, 170);
            this.Controls.Add(this.buttonDivide);
            this.Controls.Add(this.buttonMultiply);
            this.Controls.Add(this.buttonSubtract);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.textBoxNum2);
            this.Controls.Add(this.textBoxNum1);
            this.Name = "MainForm";
            this.Text = "Arithmetic Operations App";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            CalculateResult((num1, num2) => num1 + num2, "Sum");
        }

        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            CalculateResult((num1, num2) => num1 - num2, "Difference");
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            CalculateResult((num1, num2) => num1 * num2, "Product");
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            CalculateResult((num1, num2) =>
            {
                if (num2 != 0)
                    return num1 / num2;
                else
                    throw new DivideByZeroException();
            }, "Division");
        }

        private void CalculateResult(Func<int, int, int> operation, string operationName)
        {
            try
            {
                int num1 = int.Parse(textBoxNum1.Text);
                int num2 = int.Parse(textBoxNum2.Text);
                int result = operation(num1, num2);
                labelResult.Text = operationName + ": " + result;
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input. Please enter valid numbers.");
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Cannot divide by zero.");
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
