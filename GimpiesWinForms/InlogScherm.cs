using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GimpiesWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int loginCounter = 3;
            string[] userCredential = {"Manager", "Verkoper"};
            string[] passwordCredential = {"Manager01", "Verkoper01"};
            

            if (txtGebruikersnaam.Text == userCredential[0] && txtWachtwoord.Text == passwordCredential[0])
            {
                MessageBox.Show("Succesvol ingelogd");
                ManagerMainMenu managerMain = new ManagerMainMenu();
                this.Hide();
                managerMain.ShowDialog();
                this.Show();
            } 
            else if (txtGebruikersnaam.Text == userCredential[1] && txtWachtwoord.Text == passwordCredential[1])
            {
                MessageBox.Show("Succesvol ingelogd");
                VerkoperMainMenu verkoperMain = new VerkoperMainMenu();
                this.Hide();
                verkoperMain.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Probeer het opnieuw!");
            }
        }
    }
}