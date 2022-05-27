﻿
using System;
using System.Linq;
using System.Windows.Forms;

namespace RestGest.GestaoClientes
{
    public partial class FormRegistoCliente : Form
    {
        private RestGestContainer databaseContainer;

        public FormRegistoCliente()
        {
            InitializeComponent();
            databaseContainer = new RestGestContainer();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            tb_Nome.Text = "";
            tb_telemovel.Text = "";
            tb_nif.Text = "";
            tb_rua.Text = "";
            tb_cidade.Text = "";
            tb_codPostal.Text = "";
            tb_pais.Text = "";
        }

        private void btnRegistar_Click(object sender, EventArgs e)
        {
            /* Verificação do campo nome */
            if (tb_Nome.Text.Trim() == "")
            {
                MessageBox.Show("Insira um Nome!");
                return;
            }

            /* Verificação do campo Telemovel */
            int telemovel;

            if (int.TryParse(tb_telemovel.Text.Trim(), out telemovel) == false)
            {

                MessageBox.Show("Insira o Número de Telemovel!");
                return;
            }

            /* Verificação do campo NIF */
            int number;

            if (int.TryParse(tb_nif.Text.Trim(), out number) == false)
            {

                MessageBox.Show("Insira o NIF!");
                return;
            }

            /* Verificação do campo Rua */
            if (tb_rua.Text.Trim() == "")
            {
                MessageBox.Show("Insira uma Rua!");
                return;
            }

            /* Verificação do campo Cidade */
            if (tb_cidade.Text.Trim() == "")
            {
                MessageBox.Show("Insira uma Cidade!");
                return;
            }

            /* Verificação do campo Código-Postal */
            if (tb_codPostal.Text.Trim() == "")
            {
                MessageBox.Show("Insira um Código-Postal!");
                return;
            }

            /* Verificação do campo Pais */
            if (tb_pais.Text.Trim() == "")
            {
                MessageBox.Show("Insira um Pais!");
                return;
            }

            /* Cria um novo Cliente com os respetivos dados presentes nos campos a baixo */
            /*Guarda na Tabela Morada*/
            Morada Moradas = new Morada();

            Moradas.Rua = tb_rua.Text;
            Moradas.Cidade = tb_cidade.Text;
            Moradas.Codigo_Postal = tb_codPostal.Text;
            Moradas.Pais = tb_pais.Text;

            databaseContainer.Moradas.Add(Moradas);
            databaseContainer.SaveChanges();

            /* Guarda na tabela Cliente */
            Cliente Clientes = new Cliente();

            Clientes.Nome = tb_Nome.Text;
            Clientes.Telemovel = tb_telemovel.Text;
            Clientes.NumContribuinte = tb_nif.Text;
            Clientes.Morada = Moradas; 

            databaseContainer.Pessoas.Add(Clientes);
            databaseContainer.SaveChanges();

            /* Limpa as texboxs */
            tb_Nome.Text = "";
            tb_Nome.Focus();// Foca no texbox quando se abre esta janela

            tb_telemovel.Text = "";
            tb_nif.Text = "";
            tb_rua.Text = "";
            tb_cidade.Text = "";
            tb_codPostal.Text = "";
            tb_pais.Text = "";

            Close();
        }
    }
}