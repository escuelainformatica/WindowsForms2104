using Proyecto2104Form.modelo;
using Proyecto2104Form.servicio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto2104Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //var ps = new ProductoServicio();
            //sfDataGrid1.DataSource = ps.ObtenerDatos();
            sfDataPager1.DataSource = ProductoServicio.ObtenerDatos();
            sfDataGrid1.DataSource= sfDataPager1.PagedSource;
        }

        private void sfDataGrid1_CellButtonClick(object sender, Syncfusion.WinForms.DataGrid.Events.CellButtonClickEventArgs e)
        {
            // haciendo un cast.
            Producto fila = (Producto)((Syncfusion.WinForms.DataGrid.DataRow)e.Record).RowData;

            if (e.ColumnIndex == 4)
            {
                var formEditar = new FormEditar(fila);
                formEditar.ShowDialog();
            } else
            {
                var msg = MessageBox.Show("Quiere borrar este elemento?", "titulo", MessageBoxButtons.YesNo);
                if(msg==DialogResult.Yes)
                {
                    //todo: aqui hay que borrar el valor
                }

            }
        }
    }
}
