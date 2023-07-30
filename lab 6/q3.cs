using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Reflection.Emit;

namespace PoundToKilogramConverterApp
{
    public class MainForm : Form
    {
        private TextBox textBoxPounds;
        private Label labelKilograms;
        private Button buttonConvert;

        public MainForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.textBoxPounds = new TextBox();
            this.labelKilograms = new Label();
            this.buttonConvert = new Button();
            this.SuspendLayout();

            
            this.textBoxPounds.Location = new System.Drawing.Point(30, 30);
            this.textBoxPounds.Name = "textBoxPounds";
            this.textBoxPounds.Size = new System.Drawing.Size(100, 20);
            this.textBoxPounds.TabIndex = 0;

            
            this.labelKilograms.AutoSize = true;
            this.labelKilograms.Location = new System.Drawing.Point(30, 60);
            this.labelKilograms.Name = "labelKilograms";
            this.labelKilograms.Size = new System.Drawing.Size(0, 13);
            this.labelKilograms.TabIndex = 1;

            
            this.buttonConvert.Location = new System.Drawing.Point(30, 90);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(100, 23);
            this.buttonConvert.TabIndex = 2;
            this.buttonConvert.Text = "Convert";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);

            
            this.ClientSize = new System.Drawing.Size(200, 150);
            this.Controls.Add(this.buttonConvert);
            this.Controls.Add(this.labelKilograms);
            this.Controls.Add(this.textBoxPounds);
            this.Name = "MainForm";
            this.Text = "Pound to Kilogram Converter";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            try
            {
                double pounds = double.Parse(textBoxPounds.Text);
                double kilograms = pounds * 0.453592;
                labelKilograms.Text = "Kilograms: " + kilograms.ToString("F2");
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input. Please enter a valid number.");
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
