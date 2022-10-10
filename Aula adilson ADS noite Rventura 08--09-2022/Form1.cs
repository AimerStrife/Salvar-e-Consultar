using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_adilson_ADS_noite_Rventura_08__09_2022
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        Produto prod = new Produto();
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Produto prod = new Produto(550, "HD SSD", 200, 350.75f);
            prod.id = int.Parse(textBox1.Text);
            prod.nome = (textBox2.Text);
            prod.qtd_estoque = int.Parse(textBox3.Text);
            prod.preco = float.Parse(textBox4.Text);

            MessageBox.Show("EI SKATE!! TA SALVO. ", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dados do produto:\n" +
                            "\n Identificação..: " + prod.id +
                            "\n Nome do Produto: " + prod.nome +
                            "\n Quantidade.....: " + prod.qtd_estoque +
                            "\n Preço..........: " + prod.preco,
                            "Consultar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
