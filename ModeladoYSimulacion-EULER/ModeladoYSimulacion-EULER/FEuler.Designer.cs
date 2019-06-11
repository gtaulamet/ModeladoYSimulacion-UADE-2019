namespace ModeladoYSimulacion_EULER
{
    partial class FEuler
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.tbA = new System.Windows.Forms.TextBox();
            this.lA = new System.Windows.Forms.Label();
            this.lB = new System.Windows.Forms.Label();
            this.tbB = new System.Windows.Forms.TextBox();
            this.lT0 = new System.Windows.Forms.Label();
            this.tbX0 = new System.Windows.Forms.TextBox();
            this.lFx = new System.Windows.Forms.Label();
            this.tbFx = new System.Windows.Forms.TextBox();
            this.lN = new System.Windows.Forms.Label();
            this.tbN = new System.Windows.Forms.TextBox();
            this.bResolver = new System.Windows.Forms.Button();
            this.chResultado = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cbMetodo = new System.Windows.Forms.ComboBox();
            this.bLimpiar = new System.Windows.Forms.Button();
            this.lT = new System.Windows.Forms.Label();
            this.tbT = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Elija Método";
            // 
            // tbA
            // 
            this.tbA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbA.Location = new System.Drawing.Point(82, 63);
            this.tbA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(111, 23);
            this.tbA.TabIndex = 1;
            this.tbA.Text = "0";
            // 
            // lA
            // 
            this.lA.AutoSize = true;
            this.lA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lA.Location = new System.Drawing.Point(39, 63);
            this.lA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lA.Name = "lA";
            this.lA.Size = new System.Drawing.Size(16, 17);
            this.lA.TabIndex = 2;
            this.lA.Text = "a";
            // 
            // lB
            // 
            this.lB.AutoSize = true;
            this.lB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lB.Location = new System.Drawing.Point(39, 98);
            this.lB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lB.Name = "lB";
            this.lB.Size = new System.Drawing.Size(16, 17);
            this.lB.TabIndex = 4;
            this.lB.Text = "b";
            // 
            // tbB
            // 
            this.tbB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbB.Location = new System.Drawing.Point(82, 98);
            this.tbB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(111, 23);
            this.tbB.TabIndex = 3;
            this.tbB.Text = "15";
            // 
            // lT0
            // 
            this.lT0.AutoSize = true;
            this.lT0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lT0.Location = new System.Drawing.Point(39, 133);
            this.lT0.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lT0.Name = "lT0";
            this.lT0.Size = new System.Drawing.Size(22, 17);
            this.lT0.TabIndex = 6;
            this.lT0.Text = "x0";
            // 
            // tbX0
            // 
            this.tbX0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbX0.Location = new System.Drawing.Point(82, 133);
            this.tbX0.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbX0.Name = "tbX0";
            this.tbX0.Size = new System.Drawing.Size(111, 23);
            this.tbX0.TabIndex = 5;
            this.tbX0.Text = "0";
            // 
            // lFx
            // 
            this.lFx.AutoSize = true;
            this.lFx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFx.Location = new System.Drawing.Point(8, 171);
            this.lFx.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lFx.Name = "lFx";
            this.lFx.Size = new System.Drawing.Size(66, 17);
            this.lFx.TabIndex = 8;
            this.lFx.Text = "dx/dt=f(x)";
            // 
            // tbFx
            // 
            this.tbFx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFx.Location = new System.Drawing.Point(82, 171);
            this.tbFx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbFx.Name = "tbFx";
            this.tbFx.Size = new System.Drawing.Size(111, 23);
            this.tbFx.TabIndex = 7;
            this.tbFx.Text = "x*cos(x) + k";
            // 
            // lN
            // 
            this.lN.AutoSize = true;
            this.lN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lN.Location = new System.Drawing.Point(39, 210);
            this.lN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lN.Name = "lN";
            this.lN.Size = new System.Drawing.Size(16, 17);
            this.lN.TabIndex = 10;
            this.lN.Text = "n";
            // 
            // tbN
            // 
            this.tbN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbN.Location = new System.Drawing.Point(82, 210);
            this.tbN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbN.Name = "tbN";
            this.tbN.Size = new System.Drawing.Size(111, 23);
            this.tbN.TabIndex = 9;
            this.tbN.Text = "10";
            // 
            // bResolver
            // 
            this.bResolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bResolver.Location = new System.Drawing.Point(44, 293);
            this.bResolver.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bResolver.Name = "bResolver";
            this.bResolver.Size = new System.Drawing.Size(124, 45);
            this.bResolver.TabIndex = 11;
            this.bResolver.Text = "Resolver";
            this.bResolver.UseVisualStyleBackColor = true;
            this.bResolver.Click += new System.EventHandler(this.bResolver_Click);
            // 
            // chResultado
            // 
            chartArea1.Name = "ChartArea1";
            this.chResultado.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chResultado.Legends.Add(legend1);
            this.chResultado.Location = new System.Drawing.Point(224, 59);
            this.chResultado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chResultado.Name = "chResultado";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chResultado.Series.Add(series1);
            this.chResultado.Size = new System.Drawing.Size(1187, 700);
            this.chResultado.TabIndex = 12;
            this.chResultado.Text = "chart1";
            // 
            // cbMetodo
            // 
            this.cbMetodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMetodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMetodo.FormattingEnabled = true;
            this.cbMetodo.Items.AddRange(new object[] {
            "Ambos",
            "Método de Euler",
            "Método de Euler Mejorado (Heun)"});
            this.cbMetodo.Location = new System.Drawing.Point(134, 21);
            this.cbMetodo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbMetodo.Name = "cbMetodo";
            this.cbMetodo.Size = new System.Drawing.Size(279, 25);
            this.cbMetodo.TabIndex = 13;
            // 
            // bLimpiar
            // 
            this.bLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bLimpiar.Location = new System.Drawing.Point(74, 343);
            this.bLimpiar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bLimpiar.Name = "bLimpiar";
            this.bLimpiar.Size = new System.Drawing.Size(58, 28);
            this.bLimpiar.TabIndex = 14;
            this.bLimpiar.Text = "Limpiar";
            this.bLimpiar.UseVisualStyleBackColor = true;
            this.bLimpiar.Click += new System.EventHandler(this.bLimpiar_Click);
            // 
            // lT
            // 
            this.lT.AutoSize = true;
            this.lT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lT.Location = new System.Drawing.Point(39, 248);
            this.lT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lT.Name = "lT";
            this.lT.Size = new System.Drawing.Size(15, 17);
            this.lT.TabIndex = 15;
            this.lT.Text = "k";
            // 
            // tbT
            // 
            this.tbT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbT.Location = new System.Drawing.Point(82, 248);
            this.tbT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbT.Name = "tbT";
            this.tbT.Size = new System.Drawing.Size(111, 23);
            this.tbT.TabIndex = 10;
            this.tbT.Text = "1";
            // 
            // FEuler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1426, 839);
            this.Controls.Add(this.tbT);
            this.Controls.Add(this.lT);
            this.Controls.Add(this.bLimpiar);
            this.Controls.Add(this.cbMetodo);
            this.Controls.Add(this.chResultado);
            this.Controls.Add(this.bResolver);
            this.Controls.Add(this.lN);
            this.Controls.Add(this.tbN);
            this.Controls.Add(this.lFx);
            this.Controls.Add(this.tbFx);
            this.Controls.Add(this.lT0);
            this.Controls.Add(this.tbX0);
            this.Controls.Add(this.lB);
            this.Controls.Add(this.tbB);
            this.Controls.Add(this.lA);
            this.Controls.Add(this.tbA);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FEuler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Método de EULER";
            ((System.ComponentModel.ISupportInitialize)(this.chResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbA;
        private System.Windows.Forms.Label lA;
        private System.Windows.Forms.Label lB;
        private System.Windows.Forms.TextBox tbB;
        private System.Windows.Forms.Label lT0;
        private System.Windows.Forms.TextBox tbX0;
        private System.Windows.Forms.Label lFx;
        private System.Windows.Forms.TextBox tbFx;
        private System.Windows.Forms.Label lN;
        private System.Windows.Forms.TextBox tbN;
        private System.Windows.Forms.Button bResolver;
        private System.Windows.Forms.DataVisualization.Charting.Chart chResultado;
        private System.Windows.Forms.ComboBox cbMetodo;
        private System.Windows.Forms.Button bLimpiar;
        private System.Windows.Forms.Label lT;
        private System.Windows.Forms.TextBox tbT;
    }
}

