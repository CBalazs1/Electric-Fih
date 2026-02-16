using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electro_Fih
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            SetupUI();
            this.DoubleBuffered = true;


            //rjTextBox1.GotFocus += RemovePlaceholder;
            //rjTextBox1.LostFocus += AddPlaceholder;
        }

        private void SetupUI()
        {
            this.Text = "Electro-Fih";
            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            Color primaryPurple = Color.FromArgb(55, 0, 90);
            Color accentPurple = Color.FromArgb(120, 0, 200);

            // Top panel
            Panel topPanel = new Panel
            {
                Dock = DockStyle.Top,
                Height = 60,
                BackColor = primaryPurple
            };

            Label title = new Label
            {
                Text = "Electro-Fih",
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 16, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(20, 15)
            };

            topPanel.Controls.Add(title);

            // Side panel
            Panel sidePanel = new Panel
            {
                Dock = DockStyle.Left,
                Width = 220,
                BackColor = Color.FromArgb(45, 0, 75)
            };
            Button btnHome = CreateNavButton("Home");
            Button btnSettings = CreateNavButton("Beállítasok");

            btnSettings.Top = 60;

            sidePanel.Controls.Add(btnHome);
            sidePanel.Controls.Add(btnSettings);

            // Content panel
            Panel contentPanel = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.Transparent
            };

            this.Controls.Add(contentPanel);
            this.Controls.Add(sidePanel);
            this.Controls.Add(topPanel);
        }

        private Button CreateNavButton(string text)
        {
            return new Button
            {
                Text = text,
                Width = 200,
                Height = 45,
                Left = 10,
                Top = 10,
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.FromArgb(90, 0, 160),
                ForeColor = Color.White,
                FlatAppearance = { BorderSize = 0 }
            };
        }
        

        //private void RemovePlaceholder(object sender, EventArgs e)
        //{
        //    if (rjTextBox1.Text == "House name")
        //    {
        //        rjTextBox1.PlaceholderText = "";
        //        rjTextBox1.PlaceholderColor = Color.Black;
        //    }
        //}

        //private void AddPlaceholder(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrWhiteSpace(rjTextBox1.Text))
        //    {
        //        rjTextBox1.PlaceholderText = "House name";
        //        rjTextBox1.PlaceholderColor = Color.Gray;
        //    }
        //}

        private void rjButton1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateHouse_Click(object sender, EventArgs e)
        {

        }

        private void txtHouseName_TextChanged(object sender, EventArgs e)
        {

        }

        private void rjTextBox1__TextChanged(object sender, EventArgs e)
        {

        }

        private void rjTextBox1__TextChanged_1(object sender, EventArgs e)
        {

        }

        private void rjTextBox1__TextChanged_2(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
