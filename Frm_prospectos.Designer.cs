namespace Seguimiento_De_Prospectos
{
    partial class Frm_prospectos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnA_enviar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtA_nombre = new System.Windows.Forms.TextBox();
            this.txtA_cp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtA_apellidop = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtA_apellidom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtA_calle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtA_telefono = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtA_numero = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtA_colonia = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnA_salir = new System.Windows.Forms.Button();
            this.txtA_rfc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnabrir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.RutaArchivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreArchivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnA_enviar
            // 
            this.btnA_enviar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(208)))), ((int)(((byte)(225)))));
            this.btnA_enviar.FlatAppearance.BorderSize = 4;
            this.btnA_enviar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(208)))), ((int)(((byte)(225)))));
            this.btnA_enviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnA_enviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnA_enviar.Location = new System.Drawing.Point(594, 84);
            this.btnA_enviar.Name = "btnA_enviar";
            this.btnA_enviar.Size = new System.Drawing.Size(119, 61);
            this.btnA_enviar.TabIndex = 9;
            this.btnA_enviar.Text = "Enviar";
            this.btnA_enviar.UseVisualStyleBackColor = true;
            this.btnA_enviar.Click += new System.EventHandler(this.btnA_enviar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtA_nombre
            // 
            this.txtA_nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.txtA_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA_nombre.ForeColor = System.Drawing.Color.White;
            this.txtA_nombre.Location = new System.Drawing.Point(144, 21);
            this.txtA_nombre.Name = "txtA_nombre";
            this.txtA_nombre.Size = new System.Drawing.Size(419, 35);
            this.txtA_nombre.TabIndex = 0;
            this.txtA_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtA_nombre_KeyPress);
            // 
            // txtA_cp
            // 
            this.txtA_cp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.txtA_cp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA_cp.ForeColor = System.Drawing.Color.White;
            this.txtA_cp.Location = new System.Drawing.Point(215, 313);
            this.txtA_cp.Name = "txtA_cp";
            this.txtA_cp.Size = new System.Drawing.Size(348, 35);
            this.txtA_cp.TabIndex = 6;
            this.txtA_cp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtA_cp_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Codigo Postal";
            // 
            // txtA_apellidop
            // 
            this.txtA_apellidop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.txtA_apellidop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA_apellidop.ForeColor = System.Drawing.Color.White;
            this.txtA_apellidop.Location = new System.Drawing.Point(231, 71);
            this.txtA_apellidop.Name = "txtA_apellidop";
            this.txtA_apellidop.Size = new System.Drawing.Size(332, 35);
            this.txtA_apellidop.TabIndex = 1;
            this.txtA_apellidop.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtA_apellidop_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Primer Apellido ";
            // 
            // txtA_apellidom
            // 
            this.txtA_apellidom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.txtA_apellidom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA_apellidom.ForeColor = System.Drawing.Color.White;
            this.txtA_apellidom.Location = new System.Drawing.Point(259, 122);
            this.txtA_apellidom.Name = "txtA_apellidom";
            this.txtA_apellidom.Size = new System.Drawing.Size(304, 35);
            this.txtA_apellidom.TabIndex = 2;
            this.txtA_apellidom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtA_apellidom_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Segundo Apellido";
            // 
            // txtA_calle
            // 
            this.txtA_calle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.txtA_calle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA_calle.ForeColor = System.Drawing.Color.White;
            this.txtA_calle.Location = new System.Drawing.Point(111, 171);
            this.txtA_calle.Name = "txtA_calle";
            this.txtA_calle.Size = new System.Drawing.Size(452, 35);
            this.txtA_calle.TabIndex = 3;
            this.txtA_calle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtA_calle_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "Calle";
            // 
            // txtA_telefono
            // 
            this.txtA_telefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.txtA_telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA_telefono.ForeColor = System.Drawing.Color.White;
            this.txtA_telefono.Location = new System.Drawing.Point(155, 363);
            this.txtA_telefono.Name = "txtA_telefono";
            this.txtA_telefono.Size = new System.Drawing.Size(408, 35);
            this.txtA_telefono.TabIndex = 7;
            this.txtA_telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtA_telefono_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 366);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 29);
            this.label6.TabIndex = 11;
            this.label6.Text = "Telefono";
            // 
            // txtA_numero
            // 
            this.txtA_numero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.txtA_numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA_numero.ForeColor = System.Drawing.Color.White;
            this.txtA_numero.Location = new System.Drawing.Point(143, 219);
            this.txtA_numero.Name = "txtA_numero";
            this.txtA_numero.Size = new System.Drawing.Size(420, 35);
            this.txtA_numero.TabIndex = 4;
            this.txtA_numero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtA_numero_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(31, 222);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 29);
            this.label10.TabIndex = 19;
            this.label10.Text = "Numero";
            // 
            // txtA_colonia
            // 
            this.txtA_colonia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.txtA_colonia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA_colonia.ForeColor = System.Drawing.Color.White;
            this.txtA_colonia.Location = new System.Drawing.Point(138, 264);
            this.txtA_colonia.Name = "txtA_colonia";
            this.txtA_colonia.Size = new System.Drawing.Size(425, 35);
            this.txtA_colonia.TabIndex = 5;
            this.txtA_colonia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtA_colonia_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(31, 267);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 29);
            this.label11.TabIndex = 21;
            this.label11.Text = "Colonia";
            // 
            // btnA_salir
            // 
            this.btnA_salir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(208)))), ((int)(((byte)(225)))));
            this.btnA_salir.FlatAppearance.BorderSize = 4;
            this.btnA_salir.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(208)))), ((int)(((byte)(225)))));
            this.btnA_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnA_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnA_salir.Location = new System.Drawing.Point(594, 313);
            this.btnA_salir.Name = "btnA_salir";
            this.btnA_salir.Size = new System.Drawing.Size(119, 65);
            this.btnA_salir.TabIndex = 10;
            this.btnA_salir.Text = "Salir";
            this.btnA_salir.UseVisualStyleBackColor = true;
            this.btnA_salir.Click += new System.EventHandler(this.btnA_salir_Click);
            // 
            // txtA_rfc
            // 
            this.txtA_rfc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.txtA_rfc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA_rfc.ForeColor = System.Drawing.Color.White;
            this.txtA_rfc.Location = new System.Drawing.Point(88, 410);
            this.txtA_rfc.Name = "txtA_rfc";
            this.txtA_rfc.Size = new System.Drawing.Size(475, 35);
            this.txtA_rfc.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(31, 413);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 29);
            this.label7.TabIndex = 24;
            this.label7.Text = "Rfc";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Archivos PDF(*.pdf)|*.pdf";
            // 
            // btnabrir
            // 
            this.btnabrir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(208)))), ((int)(((byte)(225)))));
            this.btnabrir.FlatAppearance.BorderSize = 4;
            this.btnabrir.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(208)))), ((int)(((byte)(225)))));
            this.btnabrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnabrir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnabrir.Location = new System.Drawing.Point(577, 526);
            this.btnabrir.Name = "btnabrir";
            this.btnabrir.Size = new System.Drawing.Size(149, 65);
            this.btnabrir.TabIndex = 25;
            this.btnabrir.Text = "Abrir";
            this.btnabrir.UseVisualStyleBackColor = true;
            this.btnabrir.Click += new System.EventHandler(this.btnabrir_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(91)))), ((int)(((byte)(98)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RutaArchivo,
            this.NombreArchivo});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(91)))), ((int)(((byte)(98)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(208)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(54)))), ((int)(((byte)(59)))));
            this.dataGridView1.Location = new System.Drawing.Point(6, 34);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(530, 262);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.Visible = false;
            // 
            // RutaArchivo
            // 
            this.RutaArchivo.HeaderText = "Ruta de Archivo";
            this.RutaArchivo.MinimumWidth = 8;
            this.RutaArchivo.Name = "RutaArchivo";
            this.RutaArchivo.ReadOnly = true;
            this.RutaArchivo.Width = 198;
            // 
            // NombreArchivo
            // 
            this.NombreArchivo.HeaderText = "Nombre de Archivo";
            this.NombreArchivo.MinimumWidth = 8;
            this.NombreArchivo.Name = "NombreArchivo";
            this.NombreArchivo.ReadOnly = true;
            this.NombreArchivo.Width = 149;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(54)))), ((int)(((byte)(59)))));
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(21, 461);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(542, 302);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Documentos";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(208)))), ((int)(((byte)(225)))));
            this.button1.FlatAppearance.BorderSize = 4;
            this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(208)))), ((int)(((byte)(225)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(577, 654);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 67);
            this.button1.TabIndex = 29;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Frm_prospectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(54)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(739, 793);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnabrir);
            this.Controls.Add(this.txtA_rfc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnA_salir);
            this.Controls.Add(this.txtA_colonia);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtA_numero);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtA_telefono);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtA_calle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtA_apellidom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtA_apellidop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtA_cp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtA_nombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnA_enviar);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Frm_prospectos";
            this.Text = "Frm_prospectos";
            this.Load += new System.EventHandler(this.Frm_prospectos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnA_enviar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtA_nombre;
        private System.Windows.Forms.TextBox txtA_cp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtA_apellidop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtA_apellidom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtA_calle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtA_telefono;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtA_numero;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtA_colonia;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnA_salir;
        private System.Windows.Forms.TextBox txtA_rfc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnabrir;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn RutaArchivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreArchivo;
    }
}