namespace PDV
{
    partial class GZNPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GZNPrincipal));
            this.MenuPrincipal = new System.Windows.Forms.MenuStrip();
            this.Menucadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.Menufuncionários = new System.Windows.Forms.ToolStripMenuItem();
            this.Menuclientes = new System.Windows.Forms.ToolStripMenuItem();
            this.Menuusuários = new System.Windows.Forms.ToolStripMenuItem();
            this.Menucargos = new System.Windows.Forms.ToolStripMenuItem();
            this.Menufornecedores = new System.Windows.Forms.ToolStripMenuItem();
            this.Menuproduto = new System.Windows.Forms.ToolStripMenuItem();
            this.Menuprodutos = new System.Windows.Forms.ToolStripMenuItem();
            this.Menuestoque = new System.Windows.Forms.ToolStripMenuItem();
            this.movimentaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenufluxoCaixas = new System.Windows.Forms.ToolStripMenuItem();
            this.MenulançarVendas = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuentradasSaídas = new System.Windows.Forms.ToolStripMenuItem();
            this.Menudespesas = new System.Windows.Forms.ToolStripMenuItem();
            this.relatoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuprodutosRel = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuvendasRel = new System.Windows.Forms.ToolStripMenuItem();
            this.MenumovimentosRel = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuentradasSaídasRel = new System.Windows.Forms.ToolStripMenuItem();
            this.MenudespesasRel = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.img04 = new System.Windows.Forms.PictureBox();
            this.img02 = new System.Windows.Forms.PictureBox();
            this.img03 = new System.Windows.Forms.PictureBox();
            this.img01 = new System.Windows.Forms.PictureBox();
            this.MenuPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img04)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img03)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img01)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuPrincipal
            // 
            this.MenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menucadastro,
            this.Menuproduto,
            this.movimentaçõesToolStripMenuItem,
            this.relatoriosToolStripMenuItem,
            this.MenuSair});
            this.MenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.MenuPrincipal.Name = "MenuPrincipal";
            this.MenuPrincipal.Size = new System.Drawing.Size(800, 24);
            this.MenuPrincipal.TabIndex = 0;
            this.MenuPrincipal.Text = "MenuPrincipal";
            this.MenuPrincipal.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuPrincipal_ItemClicked);
            // 
            // Menucadastro
            // 
            this.Menucadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menufuncionários,
            this.Menuclientes,
            this.Menuusuários,
            this.Menucargos,
            this.Menufornecedores});
            this.Menucadastro.Name = "Menucadastro";
            this.Menucadastro.Size = new System.Drawing.Size(71, 20);
            this.Menucadastro.Text = "Cadastros";
            // 
            // Menufuncionários
            // 
            this.Menufuncionários.Name = "Menufuncionários";
            this.Menufuncionários.Size = new System.Drawing.Size(180, 22);
            this.Menufuncionários.Text = "Funcionários";
            this.Menufuncionários.Click += new System.EventHandler(this.Menufuncionários_Click);
            // 
            // Menuclientes
            // 
            this.Menuclientes.Name = "Menuclientes";
            this.Menuclientes.Size = new System.Drawing.Size(180, 22);
            this.Menuclientes.Text = "Clientes";
            this.Menuclientes.Click += new System.EventHandler(this.Menuclientes_Click);
            // 
            // Menuusuários
            // 
            this.Menuusuários.Name = "Menuusuários";
            this.Menuusuários.Size = new System.Drawing.Size(180, 22);
            this.Menuusuários.Text = "Usuários";
            // 
            // Menucargos
            // 
            this.Menucargos.Name = "Menucargos";
            this.Menucargos.Size = new System.Drawing.Size(180, 22);
            this.Menucargos.Text = "Cargos";
            this.Menucargos.Click += new System.EventHandler(this.Menucargos_Click);
            // 
            // Menufornecedores
            // 
            this.Menufornecedores.Name = "Menufornecedores";
            this.Menufornecedores.Size = new System.Drawing.Size(180, 22);
            this.Menufornecedores.Text = "Fornecedores";
            // 
            // Menuproduto
            // 
            this.Menuproduto.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menuprodutos,
            this.Menuestoque});
            this.Menuproduto.Name = "Menuproduto";
            this.Menuproduto.Size = new System.Drawing.Size(67, 20);
            this.Menuproduto.Text = "Produtos";
            // 
            // Menuprodutos
            // 
            this.Menuprodutos.Name = "Menuprodutos";
            this.Menuprodutos.Size = new System.Drawing.Size(122, 22);
            this.Menuprodutos.Text = "Produtos";
            // 
            // Menuestoque
            // 
            this.Menuestoque.Name = "Menuestoque";
            this.Menuestoque.Size = new System.Drawing.Size(122, 22);
            this.Menuestoque.Text = "Estoque";
            // 
            // movimentaçõesToolStripMenuItem
            // 
            this.movimentaçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenufluxoCaixas,
            this.MenulançarVendas,
            this.MenuentradasSaídas,
            this.Menudespesas});
            this.movimentaçõesToolStripMenuItem.Name = "movimentaçõesToolStripMenuItem";
            this.movimentaçõesToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.movimentaçõesToolStripMenuItem.Text = "Movimentações";
            // 
            // MenufluxoCaixas
            // 
            this.MenufluxoCaixas.Name = "MenufluxoCaixas";
            this.MenufluxoCaixas.Size = new System.Drawing.Size(163, 22);
            this.MenufluxoCaixas.Text = "Fluxo caixas";
            // 
            // MenulançarVendas
            // 
            this.MenulançarVendas.Name = "MenulançarVendas";
            this.MenulançarVendas.Size = new System.Drawing.Size(163, 22);
            this.MenulançarVendas.Text = "Lançar vendas";
            // 
            // MenuentradasSaídas
            // 
            this.MenuentradasSaídas.Name = "MenuentradasSaídas";
            this.MenuentradasSaídas.Size = new System.Drawing.Size(163, 22);
            this.MenuentradasSaídas.Text = "Entradas / Saídas";
            // 
            // Menudespesas
            // 
            this.Menudespesas.Name = "Menudespesas";
            this.Menudespesas.Size = new System.Drawing.Size(163, 22);
            this.Menudespesas.Text = "Despesas";
            // 
            // relatoriosToolStripMenuItem
            // 
            this.relatoriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuprodutosRel,
            this.MenuvendasRel,
            this.MenumovimentosRel,
            this.MenuentradasSaídasRel,
            this.MenudespesasRel});
            this.relatoriosToolStripMenuItem.Name = "relatoriosToolStripMenuItem";
            this.relatoriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatoriosToolStripMenuItem.Text = "Relatorios";
            // 
            // MenuprodutosRel
            // 
            this.MenuprodutosRel.Name = "MenuprodutosRel";
            this.MenuprodutosRel.Size = new System.Drawing.Size(163, 22);
            this.MenuprodutosRel.Text = "Produtos";
            // 
            // MenuvendasRel
            // 
            this.MenuvendasRel.Name = "MenuvendasRel";
            this.MenuvendasRel.Size = new System.Drawing.Size(163, 22);
            this.MenuvendasRel.Text = "Vendas";
            // 
            // MenumovimentosRel
            // 
            this.MenumovimentosRel.Name = "MenumovimentosRel";
            this.MenumovimentosRel.Size = new System.Drawing.Size(163, 22);
            this.MenumovimentosRel.Text = "Movimentos";
            // 
            // MenuentradasSaídasRel
            // 
            this.MenuentradasSaídasRel.Name = "MenuentradasSaídasRel";
            this.MenuentradasSaídasRel.Size = new System.Drawing.Size(163, 22);
            this.MenuentradasSaídasRel.Text = "Entradas / Saídas";
            // 
            // MenudespesasRel
            // 
            this.MenudespesasRel.Name = "MenudespesasRel";
            this.MenudespesasRel.Size = new System.Drawing.Size(163, 22);
            this.MenudespesasRel.Text = "Despesas";
            // 
            // MenuSair
            // 
            this.MenuSair.Name = "MenuSair";
            this.MenuSair.Size = new System.Drawing.Size(38, 20);
            this.MenuSair.Text = "Sair";
            this.MenuSair.Click += new System.EventHandler(this.MenuSair_Click);
            // 
            // img04
            // 
            this.img04.BackgroundImage = global::PDV.Properties.Resources.background;
            this.img04.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.img04.Image = global::PDV.Properties.Resources.carrinho_de_compras;
            this.img04.Location = new System.Drawing.Point(166, 255);
            this.img04.Name = "img04";
            this.img04.Size = new System.Drawing.Size(237, 163);
            this.img04.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img04.TabIndex = 4;
            this.img04.TabStop = false;
            // 
            // img02
            // 
            this.img02.BackgroundImage = global::PDV.Properties.Resources.background;
            this.img02.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.img02.Image = global::PDV.Properties.Resources.atualizar;
            this.img02.Location = new System.Drawing.Point(465, 255);
            this.img02.Name = "img02";
            this.img02.Size = new System.Drawing.Size(237, 163);
            this.img02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img02.TabIndex = 3;
            this.img02.TabStop = false;
            // 
            // img03
            // 
            this.img03.BackgroundImage = global::PDV.Properties.Resources.background;
            this.img03.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.img03.Image = global::PDV.Properties.Resources.dolar;
            this.img03.Location = new System.Drawing.Point(384, 59);
            this.img03.Name = "img03";
            this.img03.Size = new System.Drawing.Size(237, 163);
            this.img03.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img03.TabIndex = 2;
            this.img03.TabStop = false;
            // 
            // img01
            // 
            this.img01.BackgroundImage = global::PDV.Properties.Resources.background;
            this.img01.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.img01.Image = global::PDV.Properties.Resources.carteira;
            this.img01.Location = new System.Drawing.Point(97, 59);
            this.img01.Name = "img01";
            this.img01.Size = new System.Drawing.Size(237, 163);
            this.img01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img01.TabIndex = 1;
            this.img01.TabStop = false;
            // 
            // GZNPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.img04);
            this.Controls.Add(this.img02);
            this.Controls.Add(this.img03);
            this.Controls.Add(this.img01);
            this.Controls.Add(this.MenuPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuPrincipal;
            this.Name = "GZNPrincipal";
            this.Text = "GZNPrincipal";
            this.MenuPrincipal.ResumeLayout(false);
            this.MenuPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img04)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img03)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img01)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem Menucadastro;
        private System.Windows.Forms.ToolStripMenuItem Menuproduto;
        private System.Windows.Forms.ToolStripMenuItem movimentaçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatoriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuSair;
        private System.Windows.Forms.PictureBox img01;
        private System.Windows.Forms.PictureBox img03;
        private System.Windows.Forms.PictureBox img02;
        private System.Windows.Forms.PictureBox img04;
        private System.Windows.Forms.ToolStripMenuItem Menufuncionários;
        private System.Windows.Forms.ToolStripMenuItem Menuclientes;
        private System.Windows.Forms.ToolStripMenuItem Menuusuários;
        private System.Windows.Forms.ToolStripMenuItem Menucargos;
        private System.Windows.Forms.ToolStripMenuItem Menufornecedores;
        private System.Windows.Forms.ToolStripMenuItem Menuprodutos;
        private System.Windows.Forms.ToolStripMenuItem Menuestoque;
        private System.Windows.Forms.ToolStripMenuItem MenufluxoCaixas;
        private System.Windows.Forms.ToolStripMenuItem MenulançarVendas;
        private System.Windows.Forms.ToolStripMenuItem MenuentradasSaídas;
        private System.Windows.Forms.ToolStripMenuItem Menudespesas;
        private System.Windows.Forms.ToolStripMenuItem MenuprodutosRel;
        private System.Windows.Forms.ToolStripMenuItem MenuvendasRel;
        private System.Windows.Forms.ToolStripMenuItem MenumovimentosRel;
        private System.Windows.Forms.ToolStripMenuItem MenuentradasSaídasRel;
        private System.Windows.Forms.ToolStripMenuItem MenudespesasRel;
    }
}

