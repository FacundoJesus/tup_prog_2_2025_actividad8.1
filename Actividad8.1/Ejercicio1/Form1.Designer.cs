namespace Ejercicio1
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
            label1 = new Label();
            lsbResultado = new Label();
            label3 = new Label();
            btnConfirmar = new Button();
            tbNombre = new TextBox();
            tbDNI = new TextBox();
            tbImporte = new TextBox();
            lsbResult = new ListBox();
            btnActualizar = new Button();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            btnImportar = new Button();
            btnExportar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // lsbResultado
            // 
            lsbResultado.AutoSize = true;
            lsbResultado.Location = new Point(12, 57);
            lsbResultado.Name = "lsbResultado";
            lsbResultado.Size = new Size(30, 15);
            lsbResultado.TabIndex = 1;
            lsbResultado.Text = "DNI:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 97);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 2;
            label3.Text = "Importe:";
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(273, 50);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(75, 36);
            btnConfirmar.TabIndex = 3;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(90, 12);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(100, 23);
            tbNombre.TabIndex = 4;
            // 
            // tbDNI
            // 
            tbDNI.Location = new Point(90, 50);
            tbDNI.Name = "tbDNI";
            tbDNI.Size = new Size(100, 23);
            tbDNI.TabIndex = 5;
            // 
            // tbImporte
            // 
            tbImporte.Location = new Point(90, 94);
            tbImporte.Name = "tbImporte";
            tbImporte.Size = new Size(100, 23);
            tbImporte.TabIndex = 6;
            // 
            // lsbResult
            // 
            lsbResult.FormattingEnabled = true;
            lsbResult.ItemHeight = 15;
            lsbResult.Location = new Point(12, 146);
            lsbResult.Name = "lsbResult";
            lsbResult.Size = new Size(255, 169);
            lsbResult.TabIndex = 7;
            lsbResult.SelectedIndexChanged += lsbResult_SelectedIndexChanged;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(273, 146);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 36);
            btnActualizar.TabIndex = 8;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnImportar
            // 
            btnImportar.Location = new Point(273, 252);
            btnImportar.Name = "btnImportar";
            btnImportar.Size = new Size(75, 23);
            btnImportar.TabIndex = 9;
            btnImportar.Text = "Importar";
            btnImportar.UseVisualStyleBackColor = true;
            btnImportar.Click += btnImportar_Click;
            // 
            // btnExportar
            // 
            btnExportar.Location = new Point(273, 292);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(75, 23);
            btnExportar.TabIndex = 10;
            btnExportar.Text = "Exportar";
            btnExportar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 327);
            Controls.Add(btnExportar);
            Controls.Add(btnImportar);
            Controls.Add(btnActualizar);
            Controls.Add(lsbResult);
            Controls.Add(tbImporte);
            Controls.Add(tbDNI);
            Controls.Add(tbNombre);
            Controls.Add(btnConfirmar);
            Controls.Add(label3);
            Controls.Add(lsbResultado);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ejercicio 1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lsbResultado;
        private Label label3;
        private Button btnConfirmar;
        private TextBox tbNombre;
        private TextBox tbDNI;
        private TextBox tbImporte;
        private ListBox lsbResult;
        private Button btnActualizar;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private Button btnImportar;
        private Button btnExportar;
    }
}
