
namespace CalculoTriangulo
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
            this.BtCalcular = new System.Windows.Forms.Button();
            this.BtLimpar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BoxLadoA = new System.Windows.Forms.TextBox();
            this.BoxLadoB = new System.Windows.Forms.TextBox();
            this.BoxLadoC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtCalcular
            // 
            this.BtCalcular.BackColor = System.Drawing.Color.MediumOrchid;
            this.BtCalcular.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtCalcular.ForeColor = System.Drawing.SystemColors.Control;
            this.BtCalcular.Location = new System.Drawing.Point(83, 208);
            this.BtCalcular.Name = "BtCalcular";
            this.BtCalcular.Size = new System.Drawing.Size(104, 39);
            this.BtCalcular.TabIndex = 0;
            this.BtCalcular.Text = "Calcular";
            this.BtCalcular.UseVisualStyleBackColor = false;
            this.BtCalcular.Click += new System.EventHandler(this.BtCalcular_Click);
            // 
            // BtLimpar
            // 
            this.BtLimpar.BackColor = System.Drawing.Color.MediumOrchid;
            this.BtLimpar.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtLimpar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.BtLimpar.Location = new System.Drawing.Point(235, 208);
            this.BtLimpar.Name = "BtLimpar";
            this.BtLimpar.Size = new System.Drawing.Size(98, 39);
            this.BtLimpar.TabIndex = 1;
            this.BtLimpar.Text = "Limpar";
            this.BtLimpar.UseVisualStyleBackColor = false;
            this.BtLimpar.Click += new System.EventHandler(this.BtLimpar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "LadoA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "LadoB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "LadoC";
            // 
            // BoxLadoA
            // 
            this.BoxLadoA.Location = new System.Drawing.Point(146, 46);
            this.BoxLadoA.Name = "BoxLadoA";
            this.BoxLadoA.Size = new System.Drawing.Size(228, 20);
            this.BoxLadoA.TabIndex = 5;
            // 
            // BoxLadoB
            // 
            this.BoxLadoB.Location = new System.Drawing.Point(146, 95);
            this.BoxLadoB.Name = "BoxLadoB";
            this.BoxLadoB.Size = new System.Drawing.Size(228, 20);
            this.BoxLadoB.TabIndex = 6;
            // 
            // BoxLadoC
            // 
            this.BoxLadoC.Location = new System.Drawing.Point(146, 145);
            this.BoxLadoC.Name = "BoxLadoC";
            this.BoxLadoC.Size = new System.Drawing.Size(228, 20);
            this.BoxLadoC.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(79, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(283, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Digite os lados dos Triangulos";
            // 
            // BtFechar
            // 
            this.BtFechar.BackColor = System.Drawing.Color.MediumOrchid;
            this.BtFechar.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtFechar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.BtFechar.Location = new System.Drawing.Point(385, 208);
            this.BtFechar.Name = "BtFechar";
            this.BtFechar.Size = new System.Drawing.Size(98, 39);
            this.BtFechar.TabIndex = 9;
            this.BtFechar.Text = "FECHAR";
            this.BtFechar.UseVisualStyleBackColor = false;
            this.BtFechar.Click += new System.EventHandler(this.BtFechar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(602, 330);
            this.Controls.Add(this.BtFechar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BoxLadoC);
            this.Controls.Add(this.BoxLadoB);
            this.Controls.Add(this.BoxLadoA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtLimpar);
            this.Controls.Add(this.BtCalcular);
            this.Name = "Form1";
            this.Text = "CalculoDoTriangulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtCalcular;
        private System.Windows.Forms.Button BtLimpar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox BoxLadoA;
        private System.Windows.Forms.TextBox BoxLadoB;
        private System.Windows.Forms.TextBox BoxLadoC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtFechar;
    }
}

