using SistemasComputadoras.BSS;
using SistemasComputadoras.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasComputadoras.VISTA.ComputadoraVistas
{
    public partial class ComputadoraInsertarVista : Form
    {
        public ComputadoraInsertarVista()
        {
            InitializeComponent();
        }

        ComputadoraBss bss = new ComputadoraBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Computadora computadora = new Computadora();
            computadora.Nombre = textBox1.Text;
            computadora.Descripcion = textBox2.Text;
            computadora.Precio = Convert.ToDecimal(textBox3.Text);
            computadora.FechaFabricacion =  Convert.ToDateTime( textBox4.Text);

            bss.InsertarComputadorasBss(computadora);
            MessageBox.Show("Se guardo correctamente la persona");
        }
    }
}
