﻿namespace Teste_Conexao
{
    partial class estoqueAdm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(estoqueAdm));
            this.label1 = new System.Windows.Forms.Label();
            this.btnbuscarproduto = new System.Windows.Forms.Button();
            this.txtBuscarProduto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblBusca = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label17 = new System.Windows.Forms.Label();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, -13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 54;
            this.label1.Text = "Estoque";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnbuscarproduto
            // 
            this.btnbuscarproduto.AccessibleDescription = "bus";
            this.btnbuscarproduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnbuscarproduto.Location = new System.Drawing.Point(569, 291);
            this.btnbuscarproduto.Name = "btnbuscarproduto";
            this.btnbuscarproduto.Size = new System.Drawing.Size(226, 42);
            this.btnbuscarproduto.TabIndex = 82;
            this.btnbuscarproduto.Text = "Buscar";
            this.btnbuscarproduto.UseVisualStyleBackColor = false;
            this.btnbuscarproduto.Click += new System.EventHandler(this.btnbuscarproduto_Click);
            // 
            // txtBuscarProduto
            // 
            this.txtBuscarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarProduto.Location = new System.Drawing.Point(569, 262);
            this.txtBuscarProduto.Name = "txtBuscarProduto";
            this.txtBuscarProduto.Size = new System.Drawing.Size(226, 23);
            this.txtBuscarProduto.TabIndex = 81;
            this.txtBuscarProduto.TextChanged += new System.EventHandler(this.txtBuscarProduto_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Location = new System.Drawing.Point(636, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 80;
            this.label4.Text = "Código do Produto";
            // 
            // lblBusca
            // 
            this.lblBusca.AutoSize = true;
            this.lblBusca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusca.Location = new System.Drawing.Point(591, 193);
            this.lblBusca.Name = "lblBusca";
            this.lblBusca.Size = new System.Drawing.Size(175, 20);
            this.lblBusca.TabIndex = 79;
            this.lblBusca.Text = "Pesquisa de Produto";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(189, 353);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(989, 309);
            this.dataGridView1.TabIndex = 83;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.YellowGreen;
            this.panel1.Controls.Add(this.pictureBox10);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1386, 39);
            this.panel1.TabIndex = 84;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1320, 0);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(29, 18);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 58;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(1357, 0);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(29, 18);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 57;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Teste_Conexao.Properties.Resources.fechar;
            this.pictureBox7.Location = new System.Drawing.Point(912, -18);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(29, 18);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 61;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Teste_Conexao.Properties.Resources.Voltar;
            this.pictureBox6.Location = new System.Drawing.Point(879, -18);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(29, 18);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 60;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(281, 65);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(888, 83);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 56;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-14, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1397, 743);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.YellowGreen;
            this.label17.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(3, -2);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(186, 39);
            this.label17.TabIndex = 59;
            this.label17.Text = "Estoque";
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.YellowGreen;
            this.pictureBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(112, 3);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(46, 32);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 60;
            this.pictureBox10.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.YellowGreen;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 732);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1386, 56);
            this.panel2.TabIndex = 95;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.YellowGreen;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label2.Location = new System.Drawing.Point(605, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 32);
            this.label2.TabIndex = 82;
            this.label2.Text = "Raizes Urbana";
            // 
            // estoqueAdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnbuscarproduto);
            this.Controls.Add(this.txtBuscarProduto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblBusca);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "estoqueAdm";
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.estoqueadm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnbuscarproduto;
        private System.Windows.Forms.TextBox txtBuscarProduto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblBusca;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
    }
}