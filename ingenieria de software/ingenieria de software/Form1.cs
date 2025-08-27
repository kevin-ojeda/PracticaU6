using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ingenieria_de_software
{
    public partial class Form1 : Form
    {
        private Carrito CarritoDeCompras = new Carrito();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Caramelo caramelo = new Caramelo
            (
                0,
                textBox1.Text,
                textBox2.Text,
                double.Parse(textBox3.Text),
                int.Parse(textBox4.Text)
            );
            CarritoDeCompras.agregarCaramelo(caramelo);
            MessageBox.Show("Añadido al carrito");

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }
        
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double total = CarritoDeCompras.CalcularTotal();
            MessageBox.Show("El total de la compra es: " + total.ToString());
        }
    }
}
