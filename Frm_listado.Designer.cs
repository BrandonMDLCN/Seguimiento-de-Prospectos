namespace Seguimiento_De_Prospectos
{
    partial class Frm_Listado
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtB_apellidom = new System.Windows.Forms.TextBox();
            this.txtB_nombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtB_apellidop = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnB_editar = new System.Windows.Forms.Button();
            this.btnB_Buscar = new System.Windows.Forms.Button();
            this.dgvB_listado = new System.Windows.Forms.DataGridView();
            this.btnB_eliminar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvB_listado)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtB_apellidom);
            this.groupBox1.Controls.Add(this.txtB_nombre);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtB_apellidop);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(930, 197);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscador";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtB_apellidom
            // 
            this.txtB_apellidom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.txtB_apellidom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB_apellidom.ForeColor = System.Drawing.Color.White;
            this.txtB_apellidom.Location = new System.Drawing.Point(255, 135);
            this.txtB_apellidom.Name = "txtB_apellidom";
            this.txtB_apellidom.Size = new System.Drawing.Size(656, 35);
            this.txtB_apellidom.TabIndex = 38;
            this.txtB_apellidom.TextChanged += new System.EventHandler(this.txtB_apellidom_TextChanged);
            // 
            // txtB_nombre
            // 
            this.txtB_nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.txtB_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB_nombre.ForeColor = System.Drawing.Color.White;
            this.txtB_nombre.Location = new System.Drawing.Point(140, 34);
            this.txtB_nombre.Name = "txtB_nombre";
            this.txtB_nombre.Size = new System.Drawing.Size(771, 35);
            this.txtB_nombre.TabIndex = 34;
            this.txtB_nombre.Click += new System.EventHandler(this.txtB_nombre_Click);
            this.txtB_nombre.TextChanged += new System.EventHandler(this.txtB_nombre_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 29);
            this.label4.TabIndex = 37;
            this.label4.Text = "Segundo Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 29);
            this.label1.TabIndex = 33;
            this.label1.Text = "Nombre";
            // 
            // txtB_apellidop
            // 
            this.txtB_apellidop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.txtB_apellidop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB_apellidop.ForeColor = System.Drawing.Color.White;
            this.txtB_apellidop.Location = new System.Drawing.Point(225, 84);
            this.txtB_apellidop.Name = "txtB_apellidop";
            this.txtB_apellidop.Size = new System.Drawing.Size(686, 35);
            this.txtB_apellidop.TabIndex = 36;
            this.txtB_apellidop.TextChanged += new System.EventHandler(this.txtB_apellidop_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 29);
            this.label3.TabIndex = 35;
            this.label3.Text = "Primer Apellido ";
            // 
            // btnB_editar
            // 
            this.btnB_editar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(208)))), ((int)(((byte)(225)))));
            this.btnB_editar.FlatAppearance.BorderSize = 4;
            this.btnB_editar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(208)))), ((int)(((byte)(225)))));
            this.btnB_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnB_editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnB_editar.Location = new System.Drawing.Point(606, 215);
            this.btnB_editar.Name = "btnB_editar";
            this.btnB_editar.Size = new System.Drawing.Size(135, 66);
            this.btnB_editar.TabIndex = 1;
            this.btnB_editar.Text = "Editar";
            this.btnB_editar.UseVisualStyleBackColor = true;
            this.btnB_editar.Click += new System.EventHandler(this.btnB_editar_Click);
            // 
            // btnB_Buscar
            // 
            this.btnB_Buscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(208)))), ((int)(((byte)(225)))));
            this.btnB_Buscar.FlatAppearance.BorderSize = 4;
            this.btnB_Buscar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(208)))), ((int)(((byte)(225)))));
            this.btnB_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnB_Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnB_Buscar.Location = new System.Drawing.Point(194, 215);
            this.btnB_Buscar.Name = "btnB_Buscar";
            this.btnB_Buscar.Size = new System.Drawing.Size(140, 66);
            this.btnB_Buscar.TabIndex = 3;
            this.btnB_Buscar.Text = "Buscar";
            this.btnB_Buscar.UseVisualStyleBackColor = true;
            this.btnB_Buscar.Click += new System.EventHandler(this.btnB_Buscar_Click);
            // 
            // dgvB_listado
            // 
            this.dgvB_listado.AllowUserToAddRows = false;
            this.dgvB_listado.AllowUserToDeleteRows = false;
            this.dgvB_listado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvB_listado.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(91)))), ((int)(((byte)(98)))));
            this.dgvB_listado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvB_listado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(54)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvB_listado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvB_listado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(91)))), ((int)(((byte)(98)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(208)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvB_listado.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvB_listado.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(54)))), ((int)(((byte)(59)))));
            this.dgvB_listado.Location = new System.Drawing.Point(12, 287);
            this.dgvB_listado.MultiSelect = false;
            this.dgvB_listado.Name = "dgvB_listado";
            this.dgvB_listado.ReadOnly = true;
            this.dgvB_listado.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvB_listado.RowHeadersWidth = 10;
            this.dgvB_listado.RowTemplate.Height = 28;
            this.dgvB_listado.RowTemplate.ReadOnly = true;
            this.dgvB_listado.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvB_listado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvB_listado.Size = new System.Drawing.Size(930, 276);
            this.dgvB_listado.TabIndex = 4;
            this.dgvB_listado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvB_listado_CellContentClick);
            this.dgvB_listado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvB_listado_CellDoubleClick);
            // 
            // btnB_eliminar
            // 
            this.btnB_eliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(208)))), ((int)(((byte)(225)))));
            this.btnB_eliminar.FlatAppearance.BorderSize = 4;
            this.btnB_eliminar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(208)))), ((int)(((byte)(225)))));
            this.btnB_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnB_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnB_eliminar.Location = new System.Drawing.Point(12, 575);
            this.btnB_eliminar.Name = "btnB_eliminar";
            this.btnB_eliminar.Size = new System.Drawing.Size(930, 53);
            this.btnB_eliminar.TabIndex = 5;
            this.btnB_eliminar.Text = "Eliminar";
            this.btnB_eliminar.UseVisualStyleBackColor = true;
            this.btnB_eliminar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Frm_Listado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(54)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(953, 640);
            this.Controls.Add(this.btnB_eliminar);
            this.Controls.Add(this.dgvB_listado);
            this.Controls.Add(this.btnB_Buscar);
            this.Controls.Add(this.btnB_editar);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Frm_Listado";
            this.Text = "Frm_listado";
            this.Load += new System.EventHandler(this.Frm_Listado_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvB_listado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtB_apellidom;
        private System.Windows.Forms.TextBox txtB_nombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtB_apellidop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnB_editar;
        private System.Windows.Forms.Button btnB_Buscar;
        private System.Windows.Forms.DataGridView dgvB_listado;
        private System.Windows.Forms.Button btnB_eliminar;
    }
}