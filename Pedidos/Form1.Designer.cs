﻿namespace Pedidos
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listView_Pedidos = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Sair = new System.Windows.Forms.Button();
            this.button_Salvar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.textBox_QTD = new System.Windows.Forms.TextBox();
            this.textBox_Preço = new System.Windows.Forms.TextBox();
            this.textBox_Desconto = new System.Windows.Forms.TextBox();
            this.textBox_Total = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label_Titulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_Total2 = new System.Windows.Forms.Label();
            this.textBox_AllTotal = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PEDIDO ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "DATA PEDIDO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "QUANTIDADE:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "PREÇO:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "DESCONTO:";
            // 
            // listView_Pedidos
            // 
            this.listView_Pedidos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView_Pedidos.HideSelection = false;
            this.listView_Pedidos.Location = new System.Drawing.Point(18, 314);
            this.listView_Pedidos.Name = "listView_Pedidos";
            this.listView_Pedidos.Size = new System.Drawing.Size(631, 97);
            this.listView_Pedidos.TabIndex = 5;
            this.listView_Pedidos.UseCompatibleStateImageBehavior = false;
            this.listView_Pedidos.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Data Pedido";
            this.columnHeader2.Width = 220;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "QTD";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Preço";
            this.columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Desconto";
            this.columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Total";
            this.columnHeader6.Width = 80;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_Sair);
            this.groupBox1.Controls.Add(this.button_Salvar);
            this.groupBox1.Location = new System.Drawing.Point(397, 249);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 55);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ação";
            // 
            // button_Sair
            // 
            this.button_Sair.Location = new System.Drawing.Point(127, 21);
            this.button_Sair.Name = "button_Sair";
            this.button_Sair.Size = new System.Drawing.Size(75, 23);
            this.button_Sair.TabIndex = 1;
            this.button_Sair.Text = "Sair";
            this.button_Sair.UseVisualStyleBackColor = true;
            this.button_Sair.Click += new System.EventHandler(this.button_Sair_Click);
            // 
            // button_Salvar
            // 
            this.button_Salvar.Location = new System.Drawing.Point(26, 22);
            this.button_Salvar.Name = "button_Salvar";
            this.button_Salvar.Size = new System.Drawing.Size(75, 23);
            this.button_Salvar.TabIndex = 0;
            this.button_Salvar.Text = "Salvar";
            this.button_Salvar.UseVisualStyleBackColor = true;
            this.button_Salvar.Click += new System.EventHandler(this.button_Salvar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "TOTAL:";
            // 
            // textBox_ID
            // 
            this.textBox_ID.Location = new System.Drawing.Point(112, 124);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(264, 20);
            this.textBox_ID.TabIndex = 8;
            // 
            // textBox_QTD
            // 
            this.textBox_QTD.Location = new System.Drawing.Point(112, 184);
            this.textBox_QTD.Name = "textBox_QTD";
            this.textBox_QTD.Size = new System.Drawing.Size(264, 20);
            this.textBox_QTD.TabIndex = 9;
            // 
            // textBox_Preço
            // 
            this.textBox_Preço.Location = new System.Drawing.Point(112, 214);
            this.textBox_Preço.Name = "textBox_Preço";
            this.textBox_Preço.Size = new System.Drawing.Size(264, 20);
            this.textBox_Preço.TabIndex = 10;
            // 
            // textBox_Desconto
            // 
            this.textBox_Desconto.Location = new System.Drawing.Point(112, 244);
            this.textBox_Desconto.Name = "textBox_Desconto";
            this.textBox_Desconto.Size = new System.Drawing.Size(264, 20);
            this.textBox_Desconto.TabIndex = 11;
            // 
            // textBox_Total
            // 
            this.textBox_Total.Location = new System.Drawing.Point(112, 273);
            this.textBox_Total.Name = "textBox_Total";
            this.textBox_Total.Size = new System.Drawing.Size(264, 20);
            this.textBox_Total.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(112, 154);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(264, 20);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // label_Titulo
            // 
            this.label_Titulo.AutoSize = true;
            this.label_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Titulo.ForeColor = System.Drawing.Color.DarkOrange;
            this.label_Titulo.Location = new System.Drawing.Point(218, 23);
            this.label_Titulo.Name = "label_Titulo";
            this.label_Titulo.Size = new System.Drawing.Size(179, 39);
            this.label_Titulo.TabIndex = 14;
            this.label_Titulo.Text = "PEDIDOS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pedidos.Properties.Resources.pedidos_png_1;
            this.pictureBox1.Location = new System.Drawing.Point(456, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // label_Total2
            // 
            this.label_Total2.AutoSize = true;
            this.label_Total2.Location = new System.Drawing.Point(469, 463);
            this.label_Total2.Name = "label_Total2";
            this.label_Total2.Size = new System.Drawing.Size(45, 13);
            this.label_Total2.TabIndex = 18;
            this.label_Total2.Text = "TOTAL:";
            // 
            // textBox_AllTotal
            // 
            this.textBox_AllTotal.Location = new System.Drawing.Point(520, 460);
            this.textBox_AllTotal.Name = "textBox_AllTotal";
            this.textBox_AllTotal.Size = new System.Drawing.Size(129, 20);
            this.textBox_AllTotal.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(671, 488);
            this.Controls.Add(this.textBox_AllTotal);
            this.Controls.Add(this.label_Total2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_Titulo);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox_Total);
            this.Controls.Add(this.textBox_Desconto);
            this.Controls.Add(this.textBox_Preço);
            this.Controls.Add(this.textBox_QTD);
            this.Controls.Add(this.textBox_ID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listView_Pedidos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView listView_Pedidos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_Sair;
        private System.Windows.Forms.Button button_Salvar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.TextBox textBox_QTD;
        private System.Windows.Forms.TextBox textBox_Preço;
        private System.Windows.Forms.TextBox textBox_Desconto;
        private System.Windows.Forms.TextBox textBox_Total;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label_Titulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_Total2;
        private System.Windows.Forms.TextBox textBox_AllTotal;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}

