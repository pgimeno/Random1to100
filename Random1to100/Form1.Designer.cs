namespace Random1to100
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_generate = new System.Windows.Forms.Button();
            this.result_txt = new System.Windows.Forms.Label();
            this.et_min = new System.Windows.Forms.TextBox();
            this.et_max = new System.Windows.Forms.TextBox();
            this.lbl_previous = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Min:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Max:";
            // 
            // bt_generate
            // 
            this.bt_generate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_generate.Font = new System.Drawing.Font("Gadugi", 11.25F);
            this.bt_generate.Location = new System.Drawing.Point(57, 67);
            this.bt_generate.Name = "bt_generate";
            this.bt_generate.Size = new System.Drawing.Size(84, 29);
            this.bt_generate.TabIndex = 1;
            this.bt_generate.Text = "Generate";
            this.bt_generate.UseVisualStyleBackColor = true;
            this.bt_generate.Click += new System.EventHandler(this.bt_generate_Click);
            // 
            // result_txt
            // 
            this.result_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.result_txt.AutoSize = true;
            this.result_txt.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result_txt.Location = new System.Drawing.Point(109, 110);
            this.result_txt.Name = "result_txt";
            this.result_txt.Size = new System.Drawing.Size(0, 25);
            this.result_txt.TabIndex = 2;
            // 
            // et_min
            // 
            this.et_min.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.et_min.Location = new System.Drawing.Point(96, 12);
            this.et_min.Name = "et_min";
            this.et_min.Size = new System.Drawing.Size(45, 20);
            this.et_min.TabIndex = 3;
            this.et_min.Text = "1";
            // 
            // et_max
            // 
            this.et_max.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.et_max.Location = new System.Drawing.Point(96, 41);
            this.et_max.Name = "et_max";
            this.et_max.Size = new System.Drawing.Size(45, 20);
            this.et_max.TabIndex = 3;
            this.et_max.Text = "100";
            // 
            // lbl_previous
            // 
            this.lbl_previous.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_previous.AutoSize = true;
            this.lbl_previous.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_previous.Location = new System.Drawing.Point(143, 180);
            this.lbl_previous.Name = "lbl_previous";
            this.lbl_previous.Size = new System.Drawing.Size(37, 16);
            this.lbl_previous.TabIndex = 2;
            this.lbl_previous.Text = "Last: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(202, 205);
            this.Controls.Add(this.et_max);
            this.Controls.Add(this.et_min);
            this.Controls.Add(this.lbl_previous);
            this.Controls.Add(this.result_txt);
            this.Controls.Add(this.bt_generate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(218, 244);
            this.Name = "Form1";
            this.Text = "1to100";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button bt_generate;
        public System.Windows.Forms.Label result_txt;
        public System.Windows.Forms.TextBox et_min;
        public System.Windows.Forms.TextBox et_max;
        public System.Windows.Forms.Label lbl_previous;
    }
}

