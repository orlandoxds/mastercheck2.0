﻿namespace MasterCheck2._0
{
    partial class Check
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
            this.components = new System.ComponentModel.Container();
            this.btnEx = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblEntrada = new System.Windows.Forms.Label();
            this.lblSalida = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblEnt = new System.Windows.Forms.Label();
            this.lblSal = new System.Windows.Forms.Label();
            this.mensaje = new System.Windows.Forms.Timer(this.components);
            this.lbldept = new System.Windows.Forms.Label();
            this.btnhistorial = new System.Windows.Forms.Button();
            this.lbldepartamento = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEx
            // 
            this.btnEx.Location = new System.Drawing.Point(380, 376);
            this.btnEx.Name = "btnEx";
            this.btnEx.Size = new System.Drawing.Size(75, 44);
            this.btnEx.TabIndex = 0;
            this.btnEx.Text = "Insertar";
            this.btnEx.UseVisualStyleBackColor = true;
            this.btnEx.Click += new System.EventHandler(this.btnEx_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(484, 385);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 1;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Enabled = false;
            this.lblID.Location = new System.Drawing.Point(342, 258);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(65, 20);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "Nombre";
            // 
            // lblEntrada
            // 
            this.lblEntrada.AutoSize = true;
            this.lblEntrada.Enabled = false;
            this.lblEntrada.Location = new System.Drawing.Point(341, 325);
            this.lblEntrada.Name = "lblEntrada";
            this.lblEntrada.Size = new System.Drawing.Size(66, 20);
            this.lblEntrada.TabIndex = 3;
            this.lblEntrada.Text = "Entrada";
            // 
            // lblSalida
            // 
            this.lblSalida.AutoSize = true;
            this.lblSalida.Enabled = false;
            this.lblSalida.Location = new System.Drawing.Point(608, 325);
            this.lblSalida.Name = "lblSalida";
            this.lblSalida.Size = new System.Drawing.Size(53, 20);
            this.lblSalida.TabIndex = 4;
            this.lblSalida.Text = "Salida";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(413, 245);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(13, 20);
            this.lblNom.TabIndex = 5;
            this.lblNom.Text = " ";
            // 
            // lblEnt
            // 
            this.lblEnt.AutoSize = true;
            this.lblEnt.Location = new System.Drawing.Point(412, 325);
            this.lblEnt.Name = "lblEnt";
            this.lblEnt.Size = new System.Drawing.Size(13, 20);
            this.lblEnt.TabIndex = 6;
            this.lblEnt.Text = " ";
            // 
            // lblSal
            // 
            this.lblSal.AutoSize = true;
            this.lblSal.Location = new System.Drawing.Point(679, 325);
            this.lblSal.Name = "lblSal";
            this.lblSal.Size = new System.Drawing.Size(13, 20);
            this.lblSal.TabIndex = 7;
            this.lblSal.Text = " ";
            // 
            // mensaje
            // 
            this.mensaje.Interval = 5000;
            this.mensaje.Tick += new System.EventHandler(this.mensaje_Tick);
            // 
            // lbldept
            // 
            this.lbldept.AutoSize = true;
            this.lbldept.Location = new System.Drawing.Point(342, 289);
            this.lbldept.Name = "lbldept";
            this.lbldept.Size = new System.Drawing.Size(112, 20);
            this.lbldept.TabIndex = 8;
            this.lbldept.Text = "Departamento";
            // 
            // btnhistorial
            // 
            this.btnhistorial.Location = new System.Drawing.Point(612, 385);
            this.btnhistorial.Name = "btnhistorial";
            this.btnhistorial.Size = new System.Drawing.Size(79, 44);
            this.btnhistorial.TabIndex = 9;
            this.btnhistorial.Text = "Historial";
            this.btnhistorial.UseVisualStyleBackColor = true;
            this.btnhistorial.Click += new System.EventHandler(this.btnhistorial_Click);
            // 
            // lbldepartamento
            // 
            this.lbldepartamento.AutoSize = true;
            this.lbldepartamento.Location = new System.Drawing.Point(460, 289);
            this.lbldepartamento.Name = "lbldepartamento";
            this.lbldepartamento.Size = new System.Drawing.Size(13, 20);
            this.lbldepartamento.TabIndex = 10;
            this.lbldepartamento.Text = " ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(67, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(696, 211);
            this.dataGridView1.TabIndex = 11;
            // 
            // Check
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbldepartamento);
            this.Controls.Add(this.btnhistorial);
            this.Controls.Add(this.lbldept);
            this.Controls.Add(this.lblSal);
            this.Controls.Add(this.lblEnt);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblSalida);
            this.Controls.Add(this.lblEntrada);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnEx);
            this.Name = "Check";
            this.Text = "Check";
            this.Load += new System.EventHandler(this.Check_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEx;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblEntrada;
        private System.Windows.Forms.Label lblSalida;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblEnt;
        private System.Windows.Forms.Label lblSal;
        private System.Windows.Forms.Timer mensaje;
        private System.Windows.Forms.Label lbldept;
        private System.Windows.Forms.Button btnhistorial;
        private System.Windows.Forms.Label lbldepartamento;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}