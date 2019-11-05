﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.cadastros;
using View.financeiro;

namespace View
{
    public partial class FrmPainelPrincipal : Form
    {
        public FrmPainelPrincipal()
        {
            InitializeComponent();
            
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        Point Origem = new Point(12,12);
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (pnlMenuVertical.Width == 200)
            {
                pnlMenuVertical.Width = 85;
            }
            else
            {
                pnlMenuVertical.Width = 200;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //FrmLogin chamarlogin = new FrmLogin();
            //chamarlogin.Show();
            //Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }



        //=====================================================================
        //ABERTURA DOS SUB-MENUS COM REDIMENSIONAMENTO DA LOCATION

        private void AbrirFromulario<MainForm>() where MainForm : Form, new()
        {
            Form formulario;
            formulario = pnlView.Controls.OfType<MainForm>().FirstOrDefault();
            if(formulario == null)
            {
                formulario = new MainForm();
                formulario.TopLevel = false;
                formulario.Dock = DockStyle.Fill;
                pnlView.Controls.Add(formulario);
                pnlView.Tag = formulario;
                formulario.Show(); ;
                formulario.BringToFront();
            }
            else
            {
                formulario.BringToFront();
                formulario.FormBorderStyle = FormBorderStyle.None;
            }
        }
        private void btnCadastroCarro_Click(object sender, EventArgs e)
        {
            AbrirFromulario<FrmCarros>();
        }

        private void btnFinContasPagar_Click(object sender, EventArgs e)
        {
            AbrirFromulario<FrmContasPagar>();
        }
    }
}