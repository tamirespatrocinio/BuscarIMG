using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuscaIMG
{
    public partial class TelaIMG : Form
    {
        public TelaIMG()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            openFileDialogBusca.Filter = "Todos os arquivos(*.*) | *.*";
        
             if(openFileDialogBusca.ShowDialog() == DialogResult.OK)
            {
                pictureBoxImagem.ImageLocation = openFileDialogBusca.FileName;
            }
        }
    }
}
