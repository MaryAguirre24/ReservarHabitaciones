using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace ReservarHabitaciones
{
    public partial class FormReservaciones : Form
    {
        public FormReservaciones()
        {
            InitializeComponent();

        }
        DataTable table = new DataTable();
        private void FormReservaciones_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Cliente", typeof(string));
            table.Columns.Add("Entrada", typeof(string));
            table.Columns.Add("Salida", typeof(string));
            table.Columns.Add("Tipo", typeof(string));

            dgvNuevasReservas.DataSource = table;
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            table.Rows.Add(txtCliente.Text,txtEntrada.Text,txtSalida.Text);
            dgvNuevasReservas.DataSource = table;

            Reserva NuevaReserva;
            NuevaReserva = new Reserva(txtCliente.Text, txtEntrada.Text, txtSalida.Text,cmbTipo.Text);
           
            MessageBox.Show("Reserva Completada");

            txtCliente.Clear();
            txtEntrada.Clear();
            txtSalida.Clear();
            txtCliente.Focus();
        }

   
    }
}
