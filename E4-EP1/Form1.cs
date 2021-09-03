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
        ///Clases 
        Empleado emp1 = new Empleado();
        Empleado emp2 = new Empleado();
        Empleado emp3 = new Empleado();

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
                emp1.Nombre = txtNombre.Text;
                emp1.Apellido = txtApellido.Text;
                emp1.Cargo = cboxCargo.SelectedItem.ToString();
                emp1.Horas = Convert.ToInt32(txtHoras.Text);
            }
            if (contador == 2)
            {
                emp2.Nombre = txtNombre.Text;
                emp2.Apellido = txtApellido.Text;
                emp2.Cargo = cboxCargo.SelectedItem.ToString();
                emp2.Horas = Convert.ToInt32(txtHoras.Text);
            }
            if (contador == 3)
            {
                emp3.Nombre = txtNombre.Text;
                emp3.Apellido = txtApellido.Text;
                emp3.Cargo = cboxCargo.SelectedItem.ToString();
                emp3.Horas = Convert.ToInt32(txtHoras.Text);
            }
            if (contador == 3) {
                if (emp1.Cargo == "Gerente" && emp2.Cargo == "Asistente" && emp3.Cargo == "Secretaria")
                {
                    MessageBox.Show("NO HAY BONOS");
                }
                else
                {
                    ////Sueldos 
                    if (emp1.Horas < 160) { emp1.Sueldo = emp1.Horas * 9.75; }
                    else {
                        if(emp1.Horas >= 160){
                            emp1.Sueldo = (160)* 9.75+(emp1.Horas-160)*11.50;
                        }
                    }

                    if (emp2.Horas < 160) { emp2.Sueldo = emp2.Horas * 9.75; }
                    else
                    {
                        if (emp2.Horas >= 160)
                        {
                            emp2.Sueldo = (160) * 9.75 + (emp2.Horas - 160) * 11.50;
                        }
                    }
                    if (emp3.Horas < 160) { emp3.Sueldo = emp3.Horas * 9.75; }
                    else
                    {
                        if (emp3.Horas >= 160)
                        {
                            emp3.Sueldo = (160) * 9.75 + (emp3.Horas - 160) * 11.50;
                        }
                    }

                    ///Bonos 
                    if (emp1.Cargo == "Gerente")
                    {
                        emp1.Sueldo = emp1.Sueldo + emp1.Sueldo * 0.10;
                    }
                    else {
                        if (emp1.Cargo == "Asistente")
                        {
                            emp1.Sueldo = emp1.Sueldo + emp1.Sueldo * 0.03;
                        }
                        else
                        {
                            emp1.Sueldo = emp1.Sueldo + emp1.Sueldo * 0.02;
                        }
                    }
                    if (emp2.Cargo == "Gerente")
                    {
                        emp2.Sueldo = emp2.Sueldo + emp2.Sueldo * 0.10;
                    }
                    else
                    {
                        if (emp2.Cargo == "Asistente")
                        {
                            emp2.Sueldo = emp2.Sueldo + emp2.Sueldo * 0.03;
                        }
                        else
                        {
                            emp2.Sueldo = emp2.Sueldo + emp2.Sueldo * 0.02;
                        }
                    }
                    if (emp3.Cargo == "Gerente")
                    {
                        emp3.Sueldo = emp3.Sueldo + emp3.Sueldo * 0.10;
                    }
                    else
                    {
                        if (emp3.Cargo == "Asistente")
                        {
                            emp3.Sueldo = emp3.Sueldo + emp3.Sueldo * 0.03;
                        }
                        else
                        {
                            emp3.Sueldo = emp3.Sueldo + emp3.Sueldo * 0.02;
                        }
                    }
                }
                ///Descuentos ISS
                emp1.Iss = emp1.Sueldo * 0.525;
                emp2.Iss = emp2.Sueldo * 0.525;
                emp3.Iss = emp3.Sueldo * 0.525;
                ///Descuentos AFP
                emp1.Afp = emp1.Sueldo * 0.688;
                emp2.Afp = emp2.Sueldo * 0.688;
                emp3.Afp = emp3.Sueldo * 0.688;
                ///Descuentos RENTA
                emp1.Renta = emp1.Sueldo * 0.10;
                emp2.Renta = emp2.Sueldo * 0.10;
                emp3.Renta = emp3.Sueldo * 0.10;
                ///Sueldos liquidos
                emp1.Sueldoliquido = emp1.Sueldo - emp1.Iss - emp1.Afp - emp1.Renta;
                emp2.Sueldoliquido = emp2.Sueldo - emp2.Iss - emp1.Afp - emp2.Renta;
                emp3.Sueldoliquido = emp3.Sueldo - emp3.Iss - emp1.Afp - emp3.Renta;
            }
        }
    }
}
