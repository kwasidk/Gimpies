using System;
using System.Windows.Forms;

namespace GimpiesWinForms
{
    public partial class ManagerMainMenu : Form
    {
        public ManagerMainMenu()
        {
            InitializeComponent();
        }

       
        private void schoenenToevoegen_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void schoenenAanpassen_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void schoenenVerwijderen_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
        
        // Manager Uitloggen
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        // Verlaat het hele programma
        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fijne dag verder!");
            Environment.Exit(0);
        }

    }
}