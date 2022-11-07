namespace ÁreaTriangulo_Windows_Forms
{
    partial class Form1
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
            this.lbl_Base = new System.Windows.Forms.Label();
            this.lbl_Altura = new System.Windows.Forms.Label();
            this.lbl_Título = new System.Windows.Forms.Label();
            this.txb_Base = new System.Windows.Forms.NumericUpDown();
            this.txb_Altura = new System.Windows.Forms.NumericUpDown();
            this.btm_Calcular = new System.Windows.Forms.Button();
            this.picbox_Formula = new System.Windows.Forms.PictureBox();
            this.dt_Data = new System.Windows.Forms.DateTimePicker();
            this.txb_Resultado = new System.Windows.Forms.TextBox();
            this.lbl_Resultado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txb_Base)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txb_Altura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_Formula)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Base
            // 
            this.lbl_Base.AutoSize = true;
            this.lbl_Base.Location = new System.Drawing.Point(197, 105);
            this.lbl_Base.Name = "lbl_Base";
            this.lbl_Base.Size = new System.Drawing.Size(31, 13);
            this.lbl_Base.TabIndex = 0;
            this.lbl_Base.Text = "Base";
            // 
            // lbl_Altura
            // 
            this.lbl_Altura.AutoSize = true;
            this.lbl_Altura.Location = new System.Drawing.Point(197, 146);
            this.lbl_Altura.Name = "lbl_Altura";
            this.lbl_Altura.Size = new System.Drawing.Size(34, 13);
            this.lbl_Altura.TabIndex = 1;
            this.lbl_Altura.Text = "Altura";
            // 
            // lbl_Título
            // 
            this.lbl_Título.AutoSize = true;
            this.lbl_Título.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Título.Location = new System.Drawing.Point(229, 38);
            this.lbl_Título.Name = "lbl_Título";
            this.lbl_Título.Size = new System.Drawing.Size(217, 22);
            this.lbl_Título.TabIndex = 2;
            this.lbl_Título.Text = "ÁREA DO TRIÂNGULO";
            // 
            // txb_Base
            // 
            this.txb_Base.Location = new System.Drawing.Point(266, 103);
            this.txb_Base.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.txb_Base.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
            this.txb_Base.Name = "txb_Base";
            this.txb_Base.Size = new System.Drawing.Size(120, 20);
            this.txb_Base.TabIndex = 3;
            // 
            // txb_Altura
            // 
            this.txb_Altura.Location = new System.Drawing.Point(266, 146);
            this.txb_Altura.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.txb_Altura.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
            this.txb_Altura.Name = "txb_Altura";
            this.txb_Altura.Size = new System.Drawing.Size(120, 20);
            this.txb_Altura.TabIndex = 4;
            // 
            // btm_Calcular
            // 
            this.btm_Calcular.Location = new System.Drawing.Point(259, 233);
            this.btm_Calcular.Name = "btm_Calcular";
            this.btm_Calcular.Size = new System.Drawing.Size(125, 58);
            this.btm_Calcular.TabIndex = 6;
            this.btm_Calcular.Text = "Calcular";
            this.btm_Calcular.UseVisualStyleBackColor = true;
            this.btm_Calcular.Click += new System.EventHandler(this.btm_Calcular_Click);
            // 
            // picbox_Formula
            // 
            this.picbox_Formula.Image = global::ÁreaTriangulo_Windows_Forms.Properties.Resources.Sem_título1;
            this.picbox_Formula.Location = new System.Drawing.Point(443, 103);
            this.picbox_Formula.Name = "picbox_Formula";
            this.picbox_Formula.Size = new System.Drawing.Size(153, 126);
            this.picbox_Formula.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox_Formula.TabIndex = 7;
            this.picbox_Formula.TabStop = false;
            // 
            // dt_Data
            // 
            this.dt_Data.CalendarFont = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_Data.Enabled = false;
            this.dt_Data.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_Data.Location = new System.Drawing.Point(12, 12);
            this.dt_Data.Name = "dt_Data";
            this.dt_Data.Size = new System.Drawing.Size(238, 20);
            this.dt_Data.TabIndex = 8;
            // 
            // txb_Resultado
            // 
            this.txb_Resultado.Location = new System.Drawing.Point(266, 330);
            this.txb_Resultado.Name = "txb_Resultado";
            this.txb_Resultado.ReadOnly = true;
            this.txb_Resultado.Size = new System.Drawing.Size(100, 20);
            this.txb_Resultado.TabIndex = 9;
            this.txb_Resultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_Resultado
            // 
            this.lbl_Resultado.AutoSize = true;
            this.lbl_Resultado.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Resultado.Location = new System.Drawing.Point(266, 308);
            this.lbl_Resultado.Name = "lbl_Resultado";
            this.lbl_Resultado.Size = new System.Drawing.Size(104, 19);
            this.lbl_Resultado.TabIndex = 5;
            this.lbl_Resultado.Text = "RESULTADO";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 453);
            this.Controls.Add(this.txb_Resultado);
            this.Controls.Add(this.dt_Data);
            this.Controls.Add(this.picbox_Formula);
            this.Controls.Add(this.btm_Calcular);
            this.Controls.Add(this.lbl_Resultado);
            this.Controls.Add(this.txb_Altura);
            this.Controls.Add(this.txb_Base);
            this.Controls.Add(this.lbl_Título);
            this.Controls.Add(this.lbl_Altura);
            this.Controls.Add(this.lbl_Base);
            this.Name = "Form1";
            this.Text = "Área";
            ((System.ComponentModel.ISupportInitialize)(this.txb_Base)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txb_Altura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_Formula)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Base;
        private System.Windows.Forms.Label lbl_Altura;
        private System.Windows.Forms.Label lbl_Título;
        private System.Windows.Forms.NumericUpDown txb_Base;
        private System.Windows.Forms.NumericUpDown txb_Altura;
        private System.Windows.Forms.Button btm_Calcular;
        private System.Windows.Forms.PictureBox picbox_Formula;
        private System.Windows.Forms.DateTimePicker dt_Data;
        private System.Windows.Forms.TextBox txb_Resultado;
        private System.Windows.Forms.Label lbl_Resultado;
    }
}

