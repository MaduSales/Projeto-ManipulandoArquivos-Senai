﻿namespace ProjetoArquivo
{
    partial class Atividade01
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOrigem = new System.Windows.Forms.TextBox();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.btnSelecionar01 = new System.Windows.Forms.Button();
            this.btnSelecionar02 = new System.Windows.Forms.Button();
            this.btnExecutar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(187, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Backup de Arquivos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Origem:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Destino:";
            // 
            // txtOrigem
            // 
            this.txtOrigem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrigem.Location = new System.Drawing.Point(148, 162);
            this.txtOrigem.Name = "txtOrigem";
            this.txtOrigem.Size = new System.Drawing.Size(339, 24);
            this.txtOrigem.TabIndex = 3;
            // 
            // txtDestino
            // 
            this.txtDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDestino.Location = new System.Drawing.Point(148, 213);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(339, 24);
            this.txtDestino.TabIndex = 4;
            // 
            // btnSelecionar01
            // 
            this.btnSelecionar01.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionar01.Location = new System.Drawing.Point(520, 158);
            this.btnSelecionar01.Name = "btnSelecionar01";
            this.btnSelecionar01.Size = new System.Drawing.Size(115, 30);
            this.btnSelecionar01.TabIndex = 5;
            this.btnSelecionar01.Text = "Selecionar";
            this.btnSelecionar01.UseVisualStyleBackColor = true;
            this.btnSelecionar01.Click += new System.EventHandler(this.btnSelecionar01_Click);
            // 
            // btnSelecionar02
            // 
            this.btnSelecionar02.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionar02.Location = new System.Drawing.Point(520, 206);
            this.btnSelecionar02.Name = "btnSelecionar02";
            this.btnSelecionar02.Size = new System.Drawing.Size(115, 30);
            this.btnSelecionar02.TabIndex = 6;
            this.btnSelecionar02.Text = "Selecionar";
            this.btnSelecionar02.UseVisualStyleBackColor = true;
            this.btnSelecionar02.Click += new System.EventHandler(this.btnSelecionar02_Click);
            // 
            // btnExecutar
            // 
            this.btnExecutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExecutar.Location = new System.Drawing.Point(247, 289);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(147, 48);
            this.btnExecutar.TabIndex = 7;
            this.btnExecutar.Text = "Executar";
            this.btnExecutar.UseVisualStyleBackColor = true;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // Atividade01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 366);
            this.Controls.Add(this.btnExecutar);
            this.Controls.Add(this.btnSelecionar02);
            this.Controls.Add(this.btnSelecionar01);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.txtOrigem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Atividade01";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOrigem;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.Button btnSelecionar01;
        private System.Windows.Forms.Button btnSelecionar02;
        private System.Windows.Forms.Button btnExecutar;
    }
}

