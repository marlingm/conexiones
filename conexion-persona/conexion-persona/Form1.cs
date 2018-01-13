﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace conexion_persona
{
    public partial class Form1 : Form
    {

        Conexion c = new Conexion();
        public Form1()
        {
            InitializeComponent();
        }

        private void RbInsertar_CheckedChanged(object sender, EventArgs e)
        {
            txtId.Enabled = true;
            txtNombre.Enabled = true;
            txtApellidos.Enabled = true;
            dtpFecha.Enabled = true;
            BtnAgregar.Enabled = true;
            BtnEliminar.Enabled = false;
            BtnModificar.Enabled = false;


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RbInsertar.Checked = true;
            Conexion c = new Conexion();

        }

        private void RbEliminar_CheckedChanged(object sender, EventArgs e)
        {
            txtId.Enabled = true;
            txtNombre.Enabled = false;
            txtApellidos.Enabled = false;
            dtpFecha.Enabled = false;
            BtnEliminar.Enabled = true;
            BtnAgregar.Enabled = false;
            BtnModificar.Enabled = false;
        }

        private void RbModificar_CheckedChanged(object sender, EventArgs e)
        {
            BtnModificar.Enabled = true;
            BtnEliminar.Enabled = false;
            BtnAgregar.Enabled = false;
            txtId.Enabled = true;
            txtNombre.Enabled = true;
            txtApellidos.Enabled = true;
            dtpFecha.Enabled = true;

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (c.personaRegistrada(Convert.ToInt32(txtId.Text)) == 0)
            {
                MessageBox.Show(c.insertar(Convert.ToInt32(txtId.Text), txtNombre.Text, txtApellidos.Text, dtpFecha.Text));
                txtId.Text = "";
                txtNombre.Text = "";
                txtApellidos.Text = "";


            }
            else
            {
                MessageBox.Show("Imposible de regitrar, El registro ya existe");
            }
        }

        private void GbOpcion_Enter(object sender, EventArgs e)
        {

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnModificar_Click_1(object sender, EventArgs e)
        {

        }
    }
}
