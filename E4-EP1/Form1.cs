using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E4_EP1
{
    public partial class Form1 : Form
    {
        int contador;
        public Form1()
        {
            InitializeComponent();
            ///Definiendo Cargos
            cboxCargo.Items.Clear();
            cboxCargo.Items.Add("Gerente");
            cboxCargo.Items.Add("Asistente");
            cboxCargo.Items.Add("Secretaria");
        }

        private void txtHoras_KeyPress(object sender, KeyPressEventArgs e)
        {
            ///verificar que solo sea numero y  el numero no sea negativo 
            if (Char.IsDigit(e.KeyChar))
            {

                e.Handled = false;

            }
            else
            {
                e.Handled = true;

                MessageBox.Show("El dato ingresado no es un numero");
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            contador++;
            if (contador == 1)
            {
                Empleado emp1 = new Empleado();
                emp1.Nombre = txtNombre.Text;
                emp1.Apellido = txtApellido.Text;
                emp1.Cargo = cboxCargo.SelectedItem.ToString();
                emp1.Horas = Convert.ToInt32(txtHoras.Text);
            }
            if (contador == 2)
            {
                Empleado emp2 = new Empleado();
                emp2.Nombre = txtNombre.Text;
                emp2.Apellido = txtApellido.Text;
                emp2.Cargo = cboxCargo.SelectedItem.ToString();
                emp2.Horas = Convert.ToInt32(txtHoras.Text);
            }
            if (contador == 3)
            {
                Empleado emp3 = new Empleado();
                emp3.Nombre = txtNombre.Text;
                emp3.Apellido = txtApellido.Text;
                emp3.Cargo = cboxCargo.SelectedItem.ToString();
                emp3.Horas = Convert.ToInt32(txtHoras.Text);
            }
            if (contador == 3) {
                MessageBox.Show("Empelados ingresador");
            }
        }
    }
}
