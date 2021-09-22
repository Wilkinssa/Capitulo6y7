using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidad5
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Ejercicio1_Click(object sender, EventArgs e)
        {
            Capitulo6 ejercicio1 = new Capitulo6();
            ejercicio1.Show();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }
    }
}
