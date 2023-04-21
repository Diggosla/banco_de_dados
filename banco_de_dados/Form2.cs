using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banco_de_dados
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;user=root;database=pokeagenda;password=;");
            MySqlCommand cmd = new MySqlCommand("INSERT INTO t_pokemon(nome,peso,altura,tipo,grau_evolucao,cidade) VALUES (@nome,@peso,@altura,@tipo,@grau_evolucao,@cidade)" , conn);

            
            cmd.Parameters.AddWithValue("@nome",txtnome.Text);
            cmd.Parameters.AddWithValue("@peso",txtpeso.Text);
            cmd.Parameters.AddWithValue("@altura", txtaltura.Text);
            cmd.Parameters.AddWithValue("@tipo",txtipo.Text);
            cmd.Parameters.AddWithValue("@grau_evolucao", txtgrau.Text);
            cmd.Parameters.AddWithValue("@cidade",txtcidade.Text);

           conn.Open();
           int rowsAffected = cmd.ExecuteNonQuery();
           conn.Close();

            if(rowsAffected > 0)
            {
                MessageBox.Show("Dados Inseridos com sucesso!");
            }
            else
            {
                MessageBox.Show("Falha ao inserir dados");
            }
            

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtgrau_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
