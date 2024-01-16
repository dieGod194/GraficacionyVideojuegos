namespace HolaMundo3D
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
            components = new System.ComponentModel.Container();
            boton = new Button();
            Canvas = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)Canvas).BeginInit();
            SuspendLayout();
            // 
            // boton
            // 
            boton.Location = new Point(53, 192);
            boton.Name = "boton";
            boton.Size = new Size(112, 34);
            boton.TabIndex = 0;
            boton.Text = "button1";
            boton.UseVisualStyleBackColor = true;
            // 
            // Canvas
            // 
            Canvas.Location = new Point(254, 46);
            Canvas.Name = "Canvas";
            Canvas.Size = new Size(491, 328);
            Canvas.TabIndex = 1;
            Canvas.TabStop = false;
            // 
            // timer1
            // 
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 32);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InfoText;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(Canvas);
            Controls.Add(boton);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)Canvas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button boton;
        private PictureBox Canvas;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
    }
}
