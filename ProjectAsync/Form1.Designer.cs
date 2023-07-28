namespace ProjectAsync
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
            listBoxResultado = new ListBox();
            buttonExecutar = new Button();
            buttonExecutarAssync = new Button();
            buttonLimpar = new Button();
            SuspendLayout();
            // 
            // listBoxResultado
            // 
            listBoxResultado.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            listBoxResultado.FormattingEnabled = true;
            listBoxResultado.ItemHeight = 25;
            listBoxResultado.Location = new Point(8, 12);
            listBoxResultado.Name = "listBoxResultado";
            listBoxResultado.Size = new Size(465, 479);
            listBoxResultado.TabIndex = 0;
            // 
            // buttonExecutar
            // 
            buttonExecutar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonExecutar.Location = new Point(479, 12);
            buttonExecutar.Name = "buttonExecutar";
            buttonExecutar.Size = new Size(149, 61);
            buttonExecutar.TabIndex = 1;
            buttonExecutar.Text = "Executar";
            buttonExecutar.UseVisualStyleBackColor = true;
            buttonExecutar.Click += buttonExecutar_Click;
            // 
            // buttonExecutarAssync
            // 
            buttonExecutarAssync.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonExecutarAssync.Location = new Point(479, 79);
            buttonExecutarAssync.Name = "buttonExecutarAssync";
            buttonExecutarAssync.Size = new Size(149, 61);
            buttonExecutarAssync.TabIndex = 2;
            buttonExecutarAssync.Text = "Executar Async";
            buttonExecutarAssync.UseVisualStyleBackColor = true;
            buttonExecutarAssync.Click += buttonExecutarAssync_Click;
            // 
            // buttonLimpar
            // 
            buttonLimpar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonLimpar.Location = new Point(479, 146);
            buttonLimpar.Name = "buttonLimpar";
            buttonLimpar.Size = new Size(149, 61);
            buttonLimpar.TabIndex = 3;
            buttonLimpar.Text = "Limpar";
            buttonLimpar.UseVisualStyleBackColor = true;
            buttonLimpar.Click += buttonLimpar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 525);
            Controls.Add(buttonLimpar);
            Controls.Add(buttonExecutarAssync);
            Controls.Add(buttonExecutar);
            Controls.Add(listBoxResultado);
            Name = "Form1";
            Text = "ProjectAssync";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxResultado;
        private Button buttonExecutar;
        private Button buttonExecutarAssync;
        private Button buttonLimpar;
    }
}