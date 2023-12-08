namespace Seguimiento_De_Prospectos
{
    partial class Frm_Inicio
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
            this.btn_anadir = new System.Windows.Forms.Button();
            this.btn_listado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_anadir
            // 
            this.btn_anadir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(208)))), ((int)(((byte)(225)))));
            this.btn_anadir.FlatAppearance.BorderSize = 4;
            this.btn_anadir.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(208)))), ((int)(((byte)(225)))));
            this.btn_anadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_anadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_anadir.Location = new System.Drawing.Point(38, 51);
            this.btn_anadir.Name = "btn_anadir";
            this.btn_anadir.Size = new System.Drawing.Size(180, 76);
            this.btn_anadir.TabIndex = 0;
            this.btn_anadir.Text = "Añadir";
            this.btn_anadir.UseVisualStyleBackColor = true;
            this.btn_anadir.Click += new System.EventHandler(this.btn_anadir_Click);
            // 
            // btn_listado
            // 
            this.btn_listado.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(208)))), ((int)(((byte)(225)))));
            this.btn_listado.FlatAppearance.BorderSize = 4;
            this.btn_listado.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(208)))), ((int)(((byte)(225)))));
            this.btn_listado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_listado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_listado.Location = new System.Drawing.Point(256, 51);
            this.btn_listado.Name = "btn_listado";
            this.btn_listado.Size = new System.Drawing.Size(180, 76);
            this.btn_listado.TabIndex = 1;
            this.btn_listado.Text = "Listado";
            this.btn_listado.UseVisualStyleBackColor = true;
            this.btn_listado.Click += new System.EventHandler(this.btn_listado_Click);
            // 
            // Frm_Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(54)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(479, 175);
            this.Controls.Add(this.btn_listado);
            this.Controls.Add(this.btn_anadir);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Frm_Inicio";
            this.Text = "Frm_Inicio";
            this.Load += new System.EventHandler(this.Frm_Inicio_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_anadir;
        private System.Windows.Forms.Button btn_listado;
    }
}