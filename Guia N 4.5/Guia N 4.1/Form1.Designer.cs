namespace Guia_N_4._1
{
    partial class Form1
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
            this.lstMensajes = new System.Windows.Forms.ListBox();
            this.chkHabilitar = new System.Windows.Forms.CheckBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtNuevoMensaje = new System.Windows.Forms.TextBox();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstMensajes
            // 
            this.lstMensajes.FormattingEnabled = true;
            this.lstMensajes.Items.AddRange(new object[] {
            "Este es el primer mensaje",
            "Este es el segundo mensaje",
            "Este es el tercer mensaje"});
            this.lstMensajes.Location = new System.Drawing.Point(12, 12);
            this.lstMensajes.Name = "lstMensajes";
            this.lstMensajes.Size = new System.Drawing.Size(120, 95);
            this.lstMensajes.TabIndex = 1;
            this.lstMensajes.SelectedIndexChanged += new System.EventHandler(this.lstMensajes_SelectedIndexChanged);
            // 
            // chkHabilitar
            // 
            this.chkHabilitar.AutoSize = true;
            this.chkHabilitar.Location = new System.Drawing.Point(169, 12);
            this.chkHabilitar.Name = "chkHabilitar";
            this.chkHabilitar.Size = new System.Drawing.Size(148, 17);
            this.chkHabilitar.TabIndex = 2;
            this.chkHabilitar.Text = "Agregar nuevos mensajes";
            this.chkHabilitar.UseVisualStyleBackColor = true;
            this.chkHabilitar.CheckedChanged += new System.EventHandler(this.chkHabilitar_CheckedChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(169, 73);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(148, 34);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "&Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Visible = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtNuevoMensaje
            // 
            this.txtNuevoMensaje.Location = new System.Drawing.Point(169, 35);
            this.txtNuevoMensaje.Name = "txtNuevoMensaje";
            this.txtNuevoMensaje.Size = new System.Drawing.Size(148, 20);
            this.txtNuevoMensaje.TabIndex = 4;
            this.txtNuevoMensaje.Visible = false;
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMensaje.Location = new System.Drawing.Point(169, 123);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(83, 15);
            this.lblMensaje.TabIndex = 5;
            this.lblMensaje.Text = "Nuevo mensaje";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 391);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.txtNuevoMensaje);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.chkHabilitar);
            this.Controls.Add(this.lstMensajes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstMensajes;
        private System.Windows.Forms.CheckBox chkHabilitar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtNuevoMensaje;
        private System.Windows.Forms.Label lblMensaje;
    }
}

