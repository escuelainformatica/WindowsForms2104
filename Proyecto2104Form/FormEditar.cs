using Proyecto2104Form.modelo;
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
    public partial class FormEditar : Form
    {
        public Producto prod { set; get; }
        public FormEditar(Producto prod)
        {
            InitializeComponent();

            numericUpDown1.Value = prod.Id;
            textBox1.Text = prod.Nombre;
            numericUpDown2.Value = prod.Precio;
            textBox2.Text = prod.Categoria;

        }
    }
}
