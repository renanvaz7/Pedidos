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
        double qtd, preço;
        double total = 0, totalGeral = 0;
        double pro_Total = 0;
        string desconto;
        ListViewItem listitem;       
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox_ID.Text = Convert.ToString("00" + j);
            textBox_ID.Enabled = false;
            textBox_Desconto.Enabled = false;
            textBox_Total.Enabled = false;

        }        
        private void button_Salvar_Click(object sender, EventArgs e)
        {
            if (textBox_Preço.Text != "")
            {
                if (textBox_QTD.Text == "")
                {
                    textBox_QTD.Text = Convert.ToString(1);
                }
                qtd = Convert.ToDouble(textBox_QTD.Text);
                preço = Convert.ToDouble(textBox_Preço.Text);

                total = qtd * preço;


                if (total < 100)
                {
                    textBox_Desconto.Text = "5%";
                    totalGeral= total - ((total * 5) / 100);
                }
                else if (total >= 100 && total < 500)
                {
                    textBox_Desconto.Text = "10%";
                    totalGeral = total - ((total * 10) / 100);
                }
                else if (total >= 500 && total < 1000)
                {
                    textBox_Desconto.Text = "20%";
                    totalGeral = total - ((total * 20) / 100);
                }
                else if (total >= 1000)
                {
                    textBox_Desconto.Text = "50%";
                    totalGeral = total - ((total * 50) / 100);
                }

                desconto = textBox_Desconto.Text;
                textBox_Total.Text = Convert.ToString(totalGeral);

                /*Adicionando valores no ListView*/

                listitem = listView_Pedidos.Items.Add(textBox_ID.Text);
                listitem.SubItems.Add(dateTimePicker1.Text);
                listitem.SubItems.Add(textBox_QTD.Text);
                listitem.SubItems.Add(textBox_Preço.Text);
                listitem.SubItems.Add(desconto);
                listitem.SubItems.Add(Convert.ToString(totalGeral));
                pro_Total += pro_Total + totalGeral;
                textBox_AllTotal.Text = Convert.ToString(pro_Total);
                j++;
                textBox_ID.Text = Convert.ToString("00" + j);

            }
            else
            {
                MessageBox.Show("O campo preço precisa ser inserido");
            }

        }

        private void button_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
