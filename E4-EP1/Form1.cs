﻿using System;
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
        public Form1()
        {
            InitializeComponent();
            ///Definiendo Cargos
            cboxCargo.Items.Clear();
            cboxCargo.Items.Add("Gerente");
            cboxCargo.Items.Add("Asistente");
            cboxCargo.Items.Add("Secretaria");
        }
    }
}