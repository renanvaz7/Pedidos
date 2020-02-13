using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pedidos
{
    public partial class Form1 : Form
    {
        int[] id = new int[10];
        int j = 1;
        int qtd = 0;
        double preço = 0;
        int total;
        string nome;
        ListViewItem listitem;       
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox_ID.Text = Convert.ToString("00" + j);
            textBox_ID.Enabled = false;
        }        
        private void button_Salvar_Click(object sender, EventArgs e)
        {
            if (textBox_Nome.Text == "")
            {
                MessageBox.Show("Digite um nome!!");
            }
            else
            {                
                nome = textBox_Nome.Text;                
                preço = Convert.ToDouble(textBox_Preço.Text);
                listitem = listView_Pedidos.Items.Add(textBox_ID.Text);                
                listitem.SubItems.Add(nome);
                listitem.SubItems.Add(dateTimePicker1.ToString());                
                listitem.SubItems.Add(preço.ToString());
                textBox_Nome.Text = "";
                j++;
                textBox_ID.Text = Convert.ToString("00" + j);
            }
            if (textBox_QTD.Text == "")
            {
                MessageBox.Show("Digite uma quantidade!!");
            }
            else
            {
                qtd = Convert.ToInt32(textBox_QTD.Text);
                listitem = listView_Pedidos.Items.Add(textBox_QTD.Text);
                listitem.SubItems.Add(qtd.ToString());
            }
        }

        private void button_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
