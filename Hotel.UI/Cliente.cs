


using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.UI
{
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            OBJUSUARIO user = new()
            {
                USUARIO = TxtUser.Text,
                SENHA = TxtSenha.Text,

            };

            DAL.DAL dAL = new();
            dAL.CADASTRAUSER(user);
            MessageBox.Show("usuario cadastrado com sucesso");
        }

        private void BtnDelet_Click(object sender, EventArgs e)
        {
            OBJUSUARIO user = new();
            {
                user.IDUSUARIO = Convert.ToInt32(TxtBuscar.Text);
                DAL.DAL dAL = new();
                dAL.DELETEUSE(user);
                MessageBox.Show("usuario deletado com sucesso");


            }
        }

        private void BtnTos_Click(object sender, EventArgs e)
        {
            OBJUSUARIO user = new();
            user.IDUSUARIO = Convert.ToInt32(TxtBuscar.Text);
           
            DAL.DAL dAL = new();
            dAL.BUSCARUSER(user);
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            OBJUSUARIO user = new();
            {
                user.USUARIO = TxtUser.Text;
                user.SENHA = TxtSenha.Text;
                user.IDUSUARIO = Convert.ToInt32(TxtBuscar.Text);
                DAL.DAL dAL = new();   
                dAL.UPDATEUSER(user);
                MessageBox.Show("atualizador");
            }
        }
    }
}
