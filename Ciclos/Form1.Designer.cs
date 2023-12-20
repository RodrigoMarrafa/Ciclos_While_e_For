namespace Ciclos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnComeçarCiclo = new Button();
            Lista = new ListBox();
            btnPróximo = new Button();
            btnSair = new Button();
            SuspendLayout();
            // 
            // btnComeçarCiclo
            // 
            btnComeçarCiclo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnComeçarCiclo.Location = new Point(535, 268);
            btnComeçarCiclo.Name = "btnComeçarCiclo";
            btnComeçarCiclo.Size = new Size(140, 48);
            btnComeçarCiclo.TabIndex = 0;
            btnComeçarCiclo.Text = "Começar Ciclo";
            btnComeçarCiclo.UseVisualStyleBackColor = true;
            btnComeçarCiclo.Click += btnComeçarCiclo_Click;
            // 
            // Lista
            // 
            Lista.BorderStyle = BorderStyle.FixedSingle;
            Lista.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Lista.FormattingEnabled = true;
            Lista.ItemHeight = 21;
            Lista.Location = new Point(274, 74);
            Lista.Name = "Lista";
            Lista.Size = new Size(255, 296);
            Lista.TabIndex = 1;
            // 
            // btnPróximo
            // 
            btnPróximo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnPróximo.Location = new Point(680, 12);
            btnPróximo.Name = "btnPróximo";
            btnPróximo.Size = new Size(108, 50);
            btnPróximo.TabIndex = 2;
            btnPróximo.Text = "Próximo";
            btnPróximo.UseVisualStyleBackColor = true;
            btnPróximo.Click += btnPróximo_Click;
            // 
            // btnSair
            // 
            btnSair.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSair.Location = new Point(12, 12);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(108, 50);
            btnSair.TabIndex = 3;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSair);
            Controls.Add(btnPróximo);
            Controls.Add(Lista);
            Controls.Add(btnComeçarCiclo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnComeçarCiclo;
        private ListBox Lista;
        private Button btnPróximo;
        private Button btnSair;
    }
}