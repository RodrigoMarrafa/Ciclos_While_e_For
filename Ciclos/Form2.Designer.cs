namespace Ciclos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            Lista = new ListBox();
            btnComeçarCiclo = new Button();
            btnAnterior = new Button();
            btnSair = new Button();
            SuspendLayout();
            // 
            // Lista
            // 
            Lista.BorderStyle = BorderStyle.FixedSingle;
            Lista.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Lista.FormattingEnabled = true;
            Lista.ItemHeight = 21;
            Lista.Location = new Point(12, 12);
            Lista.Name = "Lista";
            Lista.Size = new Size(268, 296);
            Lista.TabIndex = 0;
            // 
            // btnComeçarCiclo
            // 
            btnComeçarCiclo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnComeçarCiclo.Location = new Point(560, 124);
            btnComeçarCiclo.Name = "btnComeçarCiclo";
            btnComeçarCiclo.Size = new Size(140, 48);
            btnComeçarCiclo.TabIndex = 1;
            btnComeçarCiclo.Text = "Começar Ciclo";
            btnComeçarCiclo.UseVisualStyleBackColor = true;
            btnComeçarCiclo.Click += btnComeçarCiclo_Click;
            // 
            // btnAnterior
            // 
            btnAnterior.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAnterior.Location = new Point(592, 12);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(108, 50);
            btnAnterior.TabIndex = 3;
            btnAnterior.Text = "Anterior";
            btnAnterior.UseVisualStyleBackColor = true;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // btnSair
            // 
            btnSair.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSair.Location = new Point(592, 68);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(108, 50);
            btnSair.TabIndex = 4;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(712, 601);
            Controls.Add(btnSair);
            Controls.Add(btnAnterior);
            Controls.Add(btnComeçarCiclo);
            Controls.Add(Lista);
            DoubleBuffered = true;
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion

        private ListBox Lista;
        private Button btnComeçarCiclo;
        private Button btnAnterior;
        private Button btnSair;
    }
}