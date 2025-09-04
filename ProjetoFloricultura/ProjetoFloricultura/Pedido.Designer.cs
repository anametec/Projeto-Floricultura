namespace ProjetoFloricultura
{
    partial class Pedido
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbEscolheBuque = new System.Windows.Forms.ComboBox();
            this.grpOpcionais = new System.Windows.Forms.GroupBox();
            this.chkCartao = new System.Windows.Forms.CheckBox();
            this.chkPelucia = new System.Windows.Forms.CheckBox();
            this.chkBombons = new System.Windows.Forms.CheckBox();
            this.lblValorBuque = new System.Windows.Forms.Label();
            this.txtValorBuque = new System.Windows.Forms.TextBox();
            this.txtValorOpcionais = new System.Windows.Forms.TextBox();
            this.lblValorOpcionais = new System.Windows.Forms.Label();
            this.txtValorPagar = new System.Windows.Forms.TextBox();
            this.lblValorPagar = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.dgvPedido = new System.Windows.Forms.DataGridView();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.grpOpcionais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbEscolheBuque
            // 
            this.cmbEscolheBuque.FormattingEnabled = true;
            this.cmbEscolheBuque.Location = new System.Drawing.Point(27, 101);
            this.cmbEscolheBuque.Name = "cmbEscolheBuque";
            this.cmbEscolheBuque.Size = new System.Drawing.Size(200, 21);
            this.cmbEscolheBuque.TabIndex = 0;
            this.cmbEscolheBuque.Text = "Escolher Buquê";
            // 
            // grpOpcionais
            // 
            this.grpOpcionais.Controls.Add(this.chkBombons);
            this.grpOpcionais.Controls.Add(this.chkPelucia);
            this.grpOpcionais.Controls.Add(this.chkCartao);
            this.grpOpcionais.Location = new System.Drawing.Point(27, 153);
            this.grpOpcionais.Name = "grpOpcionais";
            this.grpOpcionais.Size = new System.Drawing.Size(200, 100);
            this.grpOpcionais.TabIndex = 1;
            this.grpOpcionais.TabStop = false;
            this.grpOpcionais.Text = "Escolhas Opcionais";
            // 
            // chkCartao
            // 
            this.chkCartao.AutoSize = true;
            this.chkCartao.Location = new System.Drawing.Point(6, 19);
            this.chkCartao.Name = "chkCartao";
            this.chkCartao.Size = new System.Drawing.Size(101, 17);
            this.chkCartao.TabIndex = 0;
            this.chkCartao.Text = "Cartão R$10,00";
            this.chkCartao.UseVisualStyleBackColor = true;
            // 
            // chkPelucia
            // 
            this.chkPelucia.AutoSize = true;
            this.chkPelucia.Location = new System.Drawing.Point(6, 42);
            this.chkPelucia.Name = "chkPelucia";
            this.chkPelucia.Size = new System.Drawing.Size(105, 17);
            this.chkPelucia.TabIndex = 1;
            this.chkPelucia.Text = "Pelúcia R$30,00";
            this.chkPelucia.UseVisualStyleBackColor = true;
            // 
            // chkBombons
            // 
            this.chkBombons.AutoSize = true;
            this.chkBombons.Location = new System.Drawing.Point(6, 65);
            this.chkBombons.Name = "chkBombons";
            this.chkBombons.Size = new System.Drawing.Size(114, 17);
            this.chkBombons.TabIndex = 2;
            this.chkBombons.Text = "Bombons R$40,00";
            this.chkBombons.UseVisualStyleBackColor = true;
            // 
            // lblValorBuque
            // 
            this.lblValorBuque.AutoSize = true;
            this.lblValorBuque.Location = new System.Drawing.Point(327, 75);
            this.lblValorBuque.Name = "lblValorBuque";
            this.lblValorBuque.Size = new System.Drawing.Size(80, 13);
            this.lblValorBuque.TabIndex = 2;
            this.lblValorBuque.Text = "Valor do Buquê";
            // 
            // txtValorBuque
            // 
            this.txtValorBuque.Location = new System.Drawing.Point(318, 102);
            this.txtValorBuque.Name = "txtValorBuque";
            this.txtValorBuque.Size = new System.Drawing.Size(100, 20);
            this.txtValorBuque.TabIndex = 3;
            // 
            // txtValorOpcionais
            // 
            this.txtValorOpcionais.Location = new System.Drawing.Point(465, 101);
            this.txtValorOpcionais.Name = "txtValorOpcionais";
            this.txtValorOpcionais.Size = new System.Drawing.Size(100, 20);
            this.txtValorOpcionais.TabIndex = 4;
            // 
            // lblValorOpcionais
            // 
            this.lblValorOpcionais.AutoSize = true;
            this.lblValorOpcionais.Location = new System.Drawing.Point(464, 75);
            this.lblValorOpcionais.Name = "lblValorOpcionais";
            this.lblValorOpcionais.Size = new System.Drawing.Size(101, 13);
            this.lblValorOpcionais.TabIndex = 5;
            this.lblValorOpcionais.Text = "Valor dos Opcionais";
            // 
            // txtValorPagar
            // 
            this.txtValorPagar.Location = new System.Drawing.Point(607, 102);
            this.txtValorPagar.Name = "txtValorPagar";
            this.txtValorPagar.Size = new System.Drawing.Size(100, 20);
            this.txtValorPagar.TabIndex = 6;
            // 
            // lblValorPagar
            // 
            this.lblValorPagar.AutoSize = true;
            this.lblValorPagar.Location = new System.Drawing.Point(621, 75);
            this.lblValorPagar.Name = "lblValorPagar";
            this.lblValorPagar.Size = new System.Drawing.Size(71, 13);
            this.lblValorPagar.TabIndex = 7;
            this.lblValorPagar.Text = "Valor a Pagar";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(315, 153);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 8;
            this.lblCodigo.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(361, 150);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 9;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(556, 150);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(100, 20);
            this.txtPesquisar.TabIndex = 10;
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Location = new System.Drawing.Point(494, 153);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(56, 13);
            this.lblPesquisar.TabIndex = 11;
            this.lblPesquisar.Text = "Pesquisar:";
            // 
            // dgvPedido
            // 
            this.dgvPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedido.Location = new System.Drawing.Point(318, 205);
            this.dgvPedido.Name = "dgvPedido";
            this.dgvPedido.Size = new System.Drawing.Size(389, 150);
            this.dgvPedido.TabIndex = 12;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(318, 381);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 13;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(423, 381);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 14;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(534, 381);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 15;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(632, 381);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 16;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // Floricultura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.dgvPedido);
            this.Controls.Add(this.lblPesquisar);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblValorPagar);
            this.Controls.Add(this.txtValorPagar);
            this.Controls.Add(this.lblValorOpcionais);
            this.Controls.Add(this.txtValorOpcionais);
            this.Controls.Add(this.txtValorBuque);
            this.Controls.Add(this.lblValorBuque);
            this.Controls.Add(this.grpOpcionais);
            this.Controls.Add(this.cmbEscolheBuque);
            this.Name = "Floricultura";
            this.Text = "Pedido";
            this.grpOpcionais.ResumeLayout(false);
            this.grpOpcionais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbEscolheBuque;
        private System.Windows.Forms.GroupBox grpOpcionais;
        private System.Windows.Forms.CheckBox chkBombons;
        private System.Windows.Forms.CheckBox chkPelucia;
        private System.Windows.Forms.CheckBox chkCartao;
        private System.Windows.Forms.Label lblValorBuque;
        private System.Windows.Forms.TextBox txtValorBuque;
        private System.Windows.Forms.TextBox txtValorOpcionais;
        private System.Windows.Forms.Label lblValorOpcionais;
        private System.Windows.Forms.TextBox txtValorPagar;
        private System.Windows.Forms.Label lblValorPagar;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.DataGridView dgvPedido;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnSair;
    }
}

