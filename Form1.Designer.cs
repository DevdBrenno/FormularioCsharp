namespace PrimeiroSistema
{
    partial class FormTelaSistema
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTelaSistema));
            this.FormBtn1 = new System.Windows.Forms.Button();
            this.FormBtn2 = new System.Windows.Forms.Button();
            this.FormNome = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.LabelNome = new System.Windows.Forms.Label();
            this.LabelEmail = new System.Windows.Forms.Label();
            this.FormEmail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // FormBtn1
            // 
            this.FormBtn1.Location = new System.Drawing.Point(459, 27);
            this.FormBtn1.Name = "FormBtn1";
            this.FormBtn1.Size = new System.Drawing.Size(114, 37);
            this.FormBtn1.TabIndex = 0;
            this.FormBtn1.Text = "Validar";
            this.FormBtn1.UseVisualStyleBackColor = true;
            this.FormBtn1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormBtn2
            // 
            this.FormBtn2.Location = new System.Drawing.Point(459, 72);
            this.FormBtn2.Name = "FormBtn2";
            this.FormBtn2.Size = new System.Drawing.Size(114, 37);
            this.FormBtn2.TabIndex = 1;
            this.FormBtn2.Text = "Cancelar";
            this.FormBtn2.UseVisualStyleBackColor = true;
            this.FormBtn2.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // FormNome
            // 
            this.FormNome.ForeColor = System.Drawing.SystemColors.Desktop;
            this.FormNome.Location = new System.Drawing.Point(15, 27);
            this.FormNome.Name = "FormNome";
            this.FormNome.Size = new System.Drawing.Size(416, 21);
            this.FormNome.TabIndex = 2;
            this.FormNome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // LabelNome
            // 
            this.LabelNome.AutoSize = true;
            this.LabelNome.ForeColor = System.Drawing.Color.Black;
            this.LabelNome.Location = new System.Drawing.Point(12, 10);
            this.LabelNome.Name = "LabelNome";
            this.LabelNome.Size = new System.Drawing.Size(99, 14);
            this.LabelNome.TabIndex = 4;
            this.LabelNome.Text = "Nome do usuário:";
            this.LabelNome.Click += new System.EventHandler(this.label1_Click);
            // 
            // LabelEmail
            // 
            this.LabelEmail.AutoSize = true;
            this.LabelEmail.Location = new System.Drawing.Point(12, 70);
            this.LabelEmail.Name = "LabelEmail";
            this.LabelEmail.Size = new System.Drawing.Size(41, 14);
            this.LabelEmail.TabIndex = 5;
            this.LabelEmail.Text = "E-mail:";
            this.LabelEmail.Click += new System.EventHandler(this.label2_Click);
            // 
            // FormEmail
            // 
            this.FormEmail.ForeColor = System.Drawing.SystemColors.Desktop;
            this.FormEmail.Location = new System.Drawing.Point(15, 87);
            this.FormEmail.Name = "FormEmail";
            this.FormEmail.Size = new System.Drawing.Size(416, 21);
            this.FormEmail.TabIndex = 6;
            this.FormEmail.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // FormTelaSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(585, 258);
            this.Controls.Add(this.FormEmail);
            this.Controls.Add(this.LabelEmail);
            this.Controls.Add(this.LabelNome);
            this.Controls.Add(this.FormNome);
            this.Controls.Add(this.FormBtn2);
            this.Controls.Add(this.FormBtn1);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTelaSistema";
            this.Text = "Formulário ";
            this.Load += new System.EventHandler(this.FormTelaSistema_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FormBtn1;
        private System.Windows.Forms.Button FormBtn2;
        private System.Windows.Forms.TextBox FormNome;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label LabelNome;
        private System.Windows.Forms.Label LabelEmail;
        private System.Windows.Forms.TextBox FormEmail;
    }
}

