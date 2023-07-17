namespace OOPConceptos.Interfaz
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
            label2 = new Label();
            label3 = new Label();
            txt_year = new TextBox();
            txt_month = new TextBox();
            txt_day = new TextBox();
            btn_validarFecha = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(118, 39);
            label1.Name = "label1";
            label1.Size = new Size(44, 25);
            label1.TabIndex = 0;
            label1.Text = "Year";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(118, 106);
            label2.Name = "label2";
            label2.Size = new Size(65, 25);
            label2.TabIndex = 1;
            label2.Text = "Month";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(118, 173);
            label3.Name = "label3";
            label3.Size = new Size(43, 25);
            label3.TabIndex = 2;
            label3.Text = "Day";
            // 
            // txt_year
            // 
            txt_year.Location = new Point(267, 38);
            txt_year.Name = "txt_year";
            txt_year.PlaceholderText = "Ingrese un Año";
            txt_year.Size = new Size(150, 31);
            txt_year.TabIndex = 3;
            txt_year.TextChanged += textBox1_TextChanged;
            // 
            // txt_month
            // 
            txt_month.Location = new Point(267, 100);
            txt_month.Name = "txt_month";
            txt_month.PlaceholderText = "Ingrese un Mes";
            txt_month.Size = new Size(150, 31);
            txt_month.TabIndex = 4;
            // 
            // txt_day
            // 
            txt_day.Location = new Point(267, 173);
            txt_day.Name = "txt_day";
            txt_day.PlaceholderText = "Ingrese un Dia";
            txt_day.Size = new Size(150, 31);
            txt_day.TabIndex = 5;
            // 
            // btn_validarFecha
            // 
            btn_validarFecha.Location = new Point(131, 237);
            btn_validarFecha.Name = "btn_validarFecha";
            btn_validarFecha.Size = new Size(257, 34);
            btn_validarFecha.TabIndex = 6;
            btn_validarFecha.Text = "Validar Fecha";
            btn_validarFecha.UseVisualStyleBackColor = true;
            btn_validarFecha.Click += btn_validarFecha_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_validarFecha);
            Controls.Add(txt_day);
            Controls.Add(txt_month);
            Controls.Add(txt_year);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_year;
        private TextBox txt_month;
        private TextBox txt_day;
        private Button btn_validarFecha;
    }
}