using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Reflection.Emit;

namespace LoginApp
{
    public class LoginForm : Form
    {
        private Label labelUsername;
        private Label labelPassword;
        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
        private Button buttonLogin;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.labelUsername = new Label();
            this.labelPassword = new Label();
            this.textBoxUsername = new TextBox();
            this.textBoxPassword = new TextBox();
            this.buttonLogin = new Button();
            this.SuspendLayout();

            
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(30, 30);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(63, 13);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "Username:";

            
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(30, 60);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(59, 13);
            this.labelPassword.TabIndex = 1;
            this.labelPassword.Text = "Password:";

           
            this.textBoxUsername.Location = new System.Drawing.Point(100, 27);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(150, 20);
            this.textBoxUsername.TabIndex = 2;

            
            this.textBoxPassword.Location = new System.Drawing.Point(100, 57);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(150, 20);
            this.textBoxPassword.TabIndex = 3;
            this.textBoxPassword.PasswordChar = '*';

           
            this.buttonLogin.Location = new System.Drawing.Point(100, 90);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 23);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);

            
            this.ClientSize = new System.Drawing.Size(300, 150);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUsername);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            if (username == "Admin" && password == "admin123")
            {
                MessageBox.Show("Correct Username and Password");
            }
            else
            {
                MessageBox.Show("Incorrect Username and Password");
            }
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new LoginForm());
        }
    }
}
