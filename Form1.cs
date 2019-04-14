using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPV
{
    public partial class Form1 : Form
    {
        Ticket ticket;

        public Form1()
        {
            ticket = new Ticket();
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        
        private void añadirProducto_Click(object sender, EventArgs e)
        {

            string NombreProducto;
            float PrecioProducto;
            int CantidadProducto;

            //Me volvio a pasar
            //Variable = txtNombre.Text;
            NombreProducto = txtNombreProducto.Text;
            PrecioProducto = float.Parse(txtCostoProducto.Text);
            CantidadProducto = Convert.ToInt16(numericCantidadProducto.Value);
            Producto producto = new Producto(NombreProducto, CantidadProducto, PrecioProducto);
            txtImporteProducto.Text = producto.Importe.ToString();

            //Recuerda, enviarlo de esta manera
            //Esto es asignación
            //txtcaja.text = variable.ToString();

            ticket.AgregarProducto(producto);
            txtSubtotal.Text = ticket.Subtotal.ToString();
            txtPorcentajeIVA.Text = ticket.Impuesto.ToString();
            txtTotalCompra.Text = ticket.CostoTotal.ToString();

            lstProductos.Items.Add(producto.ToString());

            limpiarTxtProducto();
            txtNombreProducto.Focus();
            // ¡¡TEXT!!
            //Sí, se me volvio a olvidar.
          

        }

        private void nombreProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void cantidadProducto_ValueChanged(object sender, EventArgs e)
        {

        }


        

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ImprimirTicket_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            string rutaArchivo;
            rutaArchivo = saveFileDialog1.FileName;
            FileStream fs = new FileStream(rutaArchivo, FileMode.Create);
            StreamWriter escritor = new StreamWriter(fs);
            escritor.WriteLine("Listado de Productos");
            escritor.WriteLine("Producto Costo Importe");
            escritor.Write(ticket.ObtenerReporte());
            //escritor.Flush();
            //Lo abre, escribe en la variable y guarda.
            escritor.Close();
            fs.Close();
        }

        public void limpiarTxtProducto()
        {
            txtNombreProducto.Text = "";
            txtCostoProducto.Text = "";
            txtImporteProducto.Text = "";
            numericCantidadProducto.Value = 0;
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            ticket.Pago = float.Parse(txtPagoTicket.Text);
            txtCambio.Text = ticket.Cambio.ToString();
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
