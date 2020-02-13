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
        string nome;
        ListViewItem listitem;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox_id.Text = Convert.ToString("00" + j);
            textBox_id.Enabled = false;
        }

        private void button_Salvar_Click(object sender, EventArgs e)
        {
            nome = textBox_nome.Text;
            listitem = listView_Data.Items.Add(textBox_id.Text);
            listitem.SubItems.Add(nome);
            textBox_nome.Text = "";
            j++;
            textBox_id.Text = Convert.ToString("00" + j);
        }

        private void button_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
