using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void modoAltoConstrasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
                textoAtv.BackColor = Color.Black;
                textoAtv.ForeColor = Color.White;
            textoAtv.Font = new Font("Microsoft Sans Serif",
           14.0F);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void configuraçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void modoAmpliadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textoAtv.BackColor = Color.White;
            textoAtv.ForeColor = Color.Black;
            textoAtv.Font = new Font("Microsoft Sans Serif",
            24.0F);
        }
    }
}
