namespace ProvaExperimentalForms
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
            txtNome = new TextBox();
            textDescricao = new TextBox();
            textPreco = new TextBox();
            button1 = new Button();
            lstProducts = new ListView();
            groupBox1 = new GroupBox();
            chekAvailable = new CheckBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 41);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 85);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 1;
            label2.Text = "Descrição";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 129);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 2;
            label3.Text = "Preço";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(24, 59);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(196, 23);
            txtNome.TabIndex = 3;
            // 
            // textDescricao
            // 
            textDescricao.Location = new Point(24, 103);
            textDescricao.Name = "textDescricao";
            textDescricao.Size = new Size(196, 23);
            textDescricao.TabIndex = 4;
            // 
            // textPreco
            // 
            textPreco.Location = new Point(24, 147);
            textPreco.Name = "textPreco";
            textPreco.Size = new Size(196, 23);
            textPreco.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(145, 192);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Salvar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lstProducts
            // 
            lstProducts.FullRowSelect = true;
            lstProducts.GridLines = true;
            lstProducts.Location = new Point(286, 21);
            lstProducts.Name = "lstProducts";
            lstProducts.Size = new Size(250, 361);
            lstProducts.TabIndex = 7;
            lstProducts.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chekAvailable);
            groupBox1.Location = new Point(12, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(219, 206);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Adicionar Produto";
            // 
            // chekAvailable
            // 
            chekAvailable.AutoSize = true;
            chekAvailable.Location = new Point(12, 155);
            chekAvailable.Name = "chekAvailable";
            chekAvailable.Size = new Size(147, 19);
            chekAvailable.TabIndex = 9;
            chekAvailable.Text = "Disponível para venda?";
            chekAvailable.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 450);
            Controls.Add(txtNome);
            Controls.Add(lstProducts);
            Controls.Add(button1);
            Controls.Add(textPreco);
            Controls.Add(textDescricao);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro e Listagem de Produtos";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNome;
        private TextBox textDescricao;
        private TextBox textPreco;
        private Button button1;
        private ListView lstProducts;
        private GroupBox groupBox1;
        private CheckBox chekAvailable;
    }
}
