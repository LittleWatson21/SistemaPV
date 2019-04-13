using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPV
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

        private void Form1_Load(object sender, EventArgs e)
        {
            Ticket ticket = new Ticket();
        }
        
        Producto producto = new Producto();
        private void añadirProducto_Click(object sender, EventArgs e)
        {
            producto.introducirNombre(nombreProducto.Text);
            //Esto siempre me pasa, manda el valor, no la caja de texto :P
            //xD
            producto.introducirCosto(Convert.ToInt16(costoProducto.Text));
            producto.introducirCantidad(Convert.ToInt16(cantidadProducto.Value));
            double value;
            try
            {
                value = Convert.ToDouble(txtSubtotal.Text);
                Console.WriteLine("TRY");
            }
            catch (Exception)
            {
                Console.WriteLine("CATCH");
                value = 0;
            }

            double subtotal =123.1;
            Console.WriteLine(value);
            Console.WriteLine(subtotal);
            txtSubtotal.Text = (value + subtotal).ToString();
            txtimporteProducto.Text = (value + subtotal).ToString();
            
        }

        private void nombreProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void cantidadProducto_ValueChanged(object sender, EventArgs e)
        {

        }

        //string nombreP, conjunto;
        //int cantidadP;
        //float costoP, importeP,subtotal,iva, total;
        ////La P es de producto
        //nombreP = nombreProducto.Text;
        //cantidadP = Convert.ToInt16(cantidadProducto.Value);
        //costoP = float.Parse(costoProducto.Text);
        //importeP = float.Parse(importeProducto.Text);
        //subtotal = float.Parse(subtotalCompra.Text);
        //iva = float.Parse(porcentajeIVA.Text);
        //total = float.Parse(totalCompra.Text);

        //conjunto += nombreP " " + cantidadP + " " + costoP;
        //listaCompra.Items.Add(conjunto);
    }
}
