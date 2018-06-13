using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ДЗформы4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Browse_Click(object sender, EventArgs e)
        {
            string path = "";
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                path = fbd.SelectedPath;
            }
            Main.Start(path);
            valueLOC.Text = Convert.ToString(Main.loc);
            valueNOC.Text = Convert.ToString(Main.noc);
            valueNOP.Text = Convert.ToString(Main.nop);
            valueNOM.Text = Convert.ToString(Main.nom);
            valueCYCLO.Text = Convert.ToString(Main.cyclo);
            valueBOvR.Text = Convert.ToString(Main.bovr);
            valueATFD.Text = Convert.ToString(Main.atfd);
            textBox2 = Convert.ToString(Main.call);
            
        }
    }
}
