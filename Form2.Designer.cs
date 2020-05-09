namespace Proyecto_Archivos
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.ComboB_EntidadFK = new System.Windows.Forms.ComboBox();
            this.LB_Atributo = new System.Windows.Forms.Label();
            this.ComboB_AtributosFK = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ENTIDAD";
            // 
            // ComboB_EntidadFK
            // 
            this.ComboB_EntidadFK.FormattingEnabled = true;
            this.ComboB_EntidadFK.Location = new System.Drawing.Point(12, 47);
            this.ComboB_EntidadFK.Name = "ComboB_EntidadFK";
            this.ComboB_EntidadFK.Size = new System.Drawing.Size(121, 21);
            this.ComboB_EntidadFK.TabIndex = 2;
            this.ComboB_EntidadFK.SelectedIndexChanged += new System.EventHandler(this.ComboB_EntidadFK_SelectedIndexChanged);
            // 
            // LB_Atributo
            // 
            this.LB_Atributo.AutoSize = true;
            this.LB_Atributo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Atributo.Location = new System.Drawing.Point(185, 24);
            this.LB_Atributo.Name = "LB_Atributo";
            this.LB_Atributo.Size = new System.Drawing.Size(65, 20);
            this.LB_Atributo.TabIndex = 3;
            this.LB_Atributo.Text = "Atributo";
            // 
            // ComboB_AtributosFK
            // 
            this.ComboB_AtributosFK.FormattingEnabled = true;
            this.ComboB_AtributosFK.Location = new System.Drawing.Point(163, 47);
            this.ComboB_AtributosFK.Name = "ComboB_AtributosFK";
            this.ComboB_AtributosFK.Size = new System.Drawing.Size(121, 21);
            this.ComboB_AtributosFK.TabIndex = 4;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 148);
            this.Controls.Add(this.ComboB_AtributosFK);
            this.Controls.Add(this.LB_Atributo);
            this.Controls.Add(this.ComboB_EntidadFK);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Selecciona Atributo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox ComboB_EntidadFK;
        private System.Windows.Forms.Label LB_Atributo;
        public System.Windows.Forms.ComboBox ComboB_AtributosFK;
    }
}