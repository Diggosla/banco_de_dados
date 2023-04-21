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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;user=root;database=pokeagenda;password=");
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM t_pokemon", conn);

            DataTable dt = new DataTable();
            conn.Open();
             
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            conn.Close();
            
            dataGridView1.DataSource= dt;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string pesquisa = txtpesquisa.Text;
            MySqlConnection conn = new MySqlConnection("server=localhost;user=root;database=pokeagenda;password=");
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM t_pokemon where nome like '%" + pesquisa+"%'", conn);
            
            DataTable dt = new DataTable();
            conn.Open();

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            conn.Close();

            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form fcadastro = new Form2();
            fcadastro.Show();
        }
    }
}
