namespace Visor
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
            canva = new PictureBox();
            buttonCuadrado = new Button();
            buttonTriangulo = new Button();
            ValorRotar = new NumericUpDown();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            buttonTras = new Button();
            textBox3 = new TextBox();
            buttonEsc = new Button();
            ((System.ComponentModel.ISupportInitialize)canva).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ValorRotar).BeginInit();
            SuspendLayout();
            // 
            // canva
            // 
            canva.BackColor = SystemColors.ControlText;
            canva.BorderStyle = BorderStyle.Fixed3D;
            canva.Location = new Point(12, 12);
            canva.Name = "canva";
            canva.Size = new Size(776, 328);
            canva.TabIndex = 0;
            canva.TabStop = false;
            // 
            // buttonCuadrado
            // 
            buttonCuadrado.Location = new Point(27, 360);
            buttonCuadrado.Name = "buttonCuadrado";
            buttonCuadrado.Size = new Size(112, 34);
            buttonCuadrado.TabIndex = 1;
            buttonCuadrado.Text = "Cuadrado";
            buttonCuadrado.UseVisualStyleBackColor = true;
            buttonCuadrado.Click += buttonCuadrado_Click;
            // 
            // buttonTriangulo
            // 
            buttonTriangulo.Location = new Point(27, 404);
            buttonTriangulo.Name = "buttonTriangulo";
            buttonTriangulo.Size = new Size(112, 34);
            buttonTriangulo.TabIndex = 2;
            buttonTriangulo.Text = "Triangulo";
            buttonTriangulo.UseVisualStyleBackColor = true;
            buttonTriangulo.Click += buttonTriangulo_Click;
            // 
            // ValorRotar
            // 
            ValorRotar.Location = new Point(190, 404);
            ValorRotar.Name = "ValorRotar";
            ValorRotar.Size = new Size(69, 31);
            ValorRotar.TabIndex = 3;
            ValorRotar.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(190, 376);
            label1.Name = "label1";
            label1.Size = new Size(54, 25);
            label1.TabIndex = 5;
            label1.Text = "Rotar";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(681, 360);
            label3.Name = "label3";
            label3.Size = new Size(23, 25);
            label3.TabIndex = 9;
            label3.Text = "X";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(682, 410);
            label4.Name = "label4";
            label4.Size = new Size(22, 25);
            label4.TabIndex = 10;
            label4.Text = "Y";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(722, 363);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(46, 31);
            textBox1.TabIndex = 12;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(722, 406);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(46, 31);
            textBox2.TabIndex = 13;
            // 
            // buttonTras
            // 
            buttonTras.Location = new Point(553, 385);
            buttonTras.Name = "buttonTras";
            buttonTras.Size = new Size(112, 34);
            buttonTras.TabIndex = 14;
            buttonTras.Text = "Trasladar";
            buttonTras.UseVisualStyleBackColor = true;
            buttonTras.Click += buttonTras_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(339, 404);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(138, 31);
            textBox3.TabIndex = 15;
            // 
            // buttonEsc
            // 
            buttonEsc.Location = new Point(351, 361);
            buttonEsc.Name = "buttonEsc";
            buttonEsc.Size = new Size(112, 34);
            buttonEsc.TabIndex = 16;
            buttonEsc.Text = "Escalar";
            buttonEsc.UseVisualStyleBackColor = true;
            buttonEsc.Click += buttonEsc_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GrayText;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonEsc);
            Controls.Add(textBox3);
            Controls.Add(buttonTras);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(ValorRotar);
            Controls.Add(buttonTriangulo);
            Controls.Add(buttonCuadrado);
            Controls.Add(canva);
            ForeColor = SystemColors.ControlDarkDark;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)canva).EndInit();
            ((System.ComponentModel.ISupportInitialize)ValorRotar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox canva;
        private Button buttonCuadrado;
        private Button buttonTriangulo;
        private NumericUpDown ValorRotar;
        private Label label1;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button buttonTras;
        private TextBox textBox3;
        private Button buttonEsc;
    }
}
