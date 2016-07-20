using System.Drawing;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace MaterialSkinExample
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_remover = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pnl_cadastro = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_A = new MaterialSkin.Controls.MaterialRadioButton();
            this.rb_C = new MaterialSkin.Controls.MaterialRadioButton();
            this.rb_B = new MaterialSkin.Controls.MaterialRadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_C = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_B = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_A = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_editar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_salvar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txt_dica = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.materialDivider3 = new MaterialSkin.Controls.MaterialDivider();
            this.rb_dificil = new MaterialSkin.Controls.MaterialRadioButton();
            this.rb_medio = new MaterialSkin.Controls.MaterialRadioButton();
            this.rb_facil = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.txt_pergunta = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_novaPergunta = new MaterialSkin.Controls.MaterialRaisedButton();
            this.list_palavras = new MaterialSkin.Controls.MaterialListView();
            this.Cod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Palavra = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rb_NivelFundamental = new System.Windows.Forms.RadioButton();
            this.rb_nivelMedio = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnl_cadastro.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.0608F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.9392F));
            this.tableLayoutPanel1.Controls.Add(this.btn_remover, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pnl_cadastro, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 63);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.51724F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.482759F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(954, 580);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btn_remover
            // 
            this.btn_remover.Depth = 0;
            this.btn_remover.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_remover.Location = new System.Drawing.Point(7, 532);
            this.btn_remover.Margin = new System.Windows.Forms.Padding(7);
            this.btn_remover.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.Primary = true;
            this.btn_remover.Size = new System.Drawing.Size(206, 41);
            this.btn_remover.TabIndex = 1;
            this.btn_remover.Text = "Remover";
            this.btn_remover.UseVisualStyleBackColor = true;
            this.btn_remover.Click += new System.EventHandler(this.btn_remover_Click);
            // 
            // pnl_cadastro
            // 
            this.pnl_cadastro.BackColor = System.Drawing.Color.White;
            this.pnl_cadastro.Controls.Add(this.groupBox1);
            this.pnl_cadastro.Controls.Add(this.label8);
            this.pnl_cadastro.Controls.Add(this.txt_C);
            this.pnl_cadastro.Controls.Add(this.txt_B);
            this.pnl_cadastro.Controls.Add(this.txt_A);
            this.pnl_cadastro.Controls.Add(this.label7);
            this.pnl_cadastro.Controls.Add(this.label6);
            this.pnl_cadastro.Controls.Add(this.label5);
            this.pnl_cadastro.Controls.Add(this.label4);
            this.pnl_cadastro.Controls.Add(this.btn_editar);
            this.pnl_cadastro.Controls.Add(this.btn_salvar);
            this.pnl_cadastro.Controls.Add(this.txt_dica);
            this.pnl_cadastro.Controls.Add(this.label3);
            this.pnl_cadastro.Controls.Add(this.label2);
            this.pnl_cadastro.Controls.Add(this.label1);
            this.pnl_cadastro.Controls.Add(this.materialDivider3);
            this.pnl_cadastro.Controls.Add(this.rb_dificil);
            this.pnl_cadastro.Controls.Add(this.rb_medio);
            this.pnl_cadastro.Controls.Add(this.rb_facil);
            this.pnl_cadastro.Controls.Add(this.materialDivider2);
            this.pnl_cadastro.Controls.Add(this.materialDivider1);
            this.pnl_cadastro.Controls.Add(this.txt_pergunta);
            this.pnl_cadastro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_cadastro.Location = new System.Drawing.Point(220, 3);
            this.pnl_cadastro.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.pnl_cadastro.Name = "pnl_cadastro";
            this.pnl_cadastro.Size = new System.Drawing.Size(734, 522);
            this.pnl_cadastro.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_A);
            this.groupBox1.Controls.Add(this.rb_C);
            this.groupBox1.Controls.Add(this.rb_B);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(577, 154);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(51, 135);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            // 
            // rb_A
            // 
            this.rb_A.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rb_A.AutoSize = true;
            this.rb_A.Checked = true;
            this.rb_A.Depth = 0;
            this.rb_A.Font = new System.Drawing.Font("Roboto", 10F);
            this.rb_A.Location = new System.Drawing.Point(3, 14);
            this.rb_A.Margin = new System.Windows.Forms.Padding(0);
            this.rb_A.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rb_A.MouseState = MaterialSkin.MouseState.HOVER;
            this.rb_A.Name = "rb_A";
            this.rb_A.Ripple = true;
            this.rb_A.Size = new System.Drawing.Size(38, 30);
            this.rb_A.TabIndex = 23;
            this.rb_A.TabStop = true;
            this.rb_A.Tag = "Item";
            this.rb_A.Text = "A";
            this.rb_A.UseVisualStyleBackColor = true;
            // 
            // rb_C
            // 
            this.rb_C.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rb_C.AutoSize = true;
            this.rb_C.Depth = 0;
            this.rb_C.Font = new System.Drawing.Font("Roboto", 10F);
            this.rb_C.Location = new System.Drawing.Point(3, 98);
            this.rb_C.Margin = new System.Windows.Forms.Padding(0);
            this.rb_C.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rb_C.MouseState = MaterialSkin.MouseState.HOVER;
            this.rb_C.Name = "rb_C";
            this.rb_C.Ripple = true;
            this.rb_C.Size = new System.Drawing.Size(38, 30);
            this.rb_C.TabIndex = 25;
            this.rb_C.Tag = "Item";
            this.rb_C.Text = "C";
            this.rb_C.UseVisualStyleBackColor = true;
            // 
            // rb_B
            // 
            this.rb_B.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rb_B.AutoSize = true;
            this.rb_B.Depth = 0;
            this.rb_B.Font = new System.Drawing.Font("Roboto", 10F);
            this.rb_B.Location = new System.Drawing.Point(3, 58);
            this.rb_B.Margin = new System.Windows.Forms.Padding(0);
            this.rb_B.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rb_B.MouseState = MaterialSkin.MouseState.HOVER;
            this.rb_B.Name = "rb_B";
            this.rb_B.Ripple = true;
            this.rb_B.Size = new System.Drawing.Size(38, 30);
            this.rb_B.TabIndex = 24;
            this.rb_B.Tag = "Item";
            this.rb_B.Text = "B";
            this.rb_B.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(559, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 28);
            this.label8.TabIndex = 22;
            this.label8.Text = "Item Correto";
            // 
            // txt_C
            // 
            this.txt_C.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_C.Depth = 0;
            this.txt_C.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_C.Hint = "Deixe em branco caso não utilize";
            this.txt_C.Location = new System.Drawing.Point(54, 266);
            this.txt_C.MaxLength = 50;
            this.txt_C.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_C.Name = "txt_C";
            this.txt_C.PasswordChar = '\0';
            this.txt_C.SelectedText = "";
            this.txt_C.SelectionLength = 0;
            this.txt_C.SelectionStart = 0;
            this.txt_C.Size = new System.Drawing.Size(517, 23);
            this.txt_C.TabIndex = 21;
            this.txt_C.TabStop = false;
            this.txt_C.UseSystemPasswordChar = false;
            // 
            // txt_B
            // 
            this.txt_B.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_B.Depth = 0;
            this.txt_B.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_B.Hint = "Grafia B";
            this.txt_B.Location = new System.Drawing.Point(54, 216);
            this.txt_B.MaxLength = 50;
            this.txt_B.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_B.Name = "txt_B";
            this.txt_B.PasswordChar = '\0';
            this.txt_B.SelectedText = "";
            this.txt_B.SelectionLength = 0;
            this.txt_B.SelectionStart = 0;
            this.txt_B.Size = new System.Drawing.Size(517, 23);
            this.txt_B.TabIndex = 20;
            this.txt_B.TabStop = false;
            this.txt_B.UseSystemPasswordChar = false;
            // 
            // txt_A
            // 
            this.txt_A.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_A.Depth = 0;
            this.txt_A.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_A.Hint = "Grafia A";
            this.txt_A.Location = new System.Drawing.Point(54, 168);
            this.txt_A.MaxLength = 50;
            this.txt_A.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_A.Name = "txt_A";
            this.txt_A.PasswordChar = '\0';
            this.txt_A.SelectedText = "";
            this.txt_A.SelectionLength = 0;
            this.txt_A.SelectionStart = 0;
            this.txt_A.Size = new System.Drawing.Size(517, 23);
            this.txt_A.TabIndex = 19;
            this.txt_A.TabStop = false;
            this.txt_A.UseSystemPasswordChar = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semilight", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 37);
            this.label7.TabIndex = 18;
            this.label7.Text = "C:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semilight", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 37);
            this.label6.TabIndex = 17;
            this.label6.Text = "B:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semilight", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 37);
            this.label5.TabIndex = 16;
            this.label5.Text = "A:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 37);
            this.label4.TabIndex = 15;
            this.label4.Text = "Opções";
            // 
            // btn_editar
            // 
            this.btn_editar.Depth = 0;
            this.btn_editar.Location = new System.Drawing.Point(632, 485);
            this.btn_editar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Primary = true;
            this.btn_editar.Size = new System.Drawing.Size(90, 30);
            this.btn_editar.TabIndex = 14;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.Depth = 0;
            this.btn_salvar.Location = new System.Drawing.Point(632, 485);
            this.btn_salvar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Primary = true;
            this.btn_salvar.Size = new System.Drawing.Size(90, 30);
            this.btn_salvar.TabIndex = 13;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // txt_dica
            // 
            this.txt_dica.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_dica.Depth = 0;
            this.txt_dica.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dica.Hint = "Dica";
            this.txt_dica.Location = new System.Drawing.Point(72, 341);
            this.txt_dica.MaxLength = 200;
            this.txt_dica.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_dica.Name = "txt_dica";
            this.txt_dica.PasswordChar = '\0';
            this.txt_dica.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_dica.SelectedText = "";
            this.txt_dica.SelectionLength = 0;
            this.txt_dica.SelectionStart = 0;
            this.txt_dica.Size = new System.Drawing.Size(556, 23);
            this.txt_dica.TabIndex = 12;
            this.txt_dica.TabStop = false;
            this.txt_dica.UseSystemPasswordChar = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(312, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 37);
            this.label3.TabIndex = 11;
            this.label3.Text = "Dica";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(266, 394);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 37);
            this.label2.TabIndex = 10;
            this.label2.Text = "Dificuldade";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(293, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 37);
            this.label1.TabIndex = 9;
            this.label1.Text = "Pergunta";
            // 
            // materialDivider3
            // 
            this.materialDivider3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.materialDivider3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider3.Depth = 0;
            this.materialDivider3.Location = new System.Drawing.Point(0, 0);
            this.materialDivider3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider3.Name = "materialDivider3";
            this.materialDivider3.Size = new System.Drawing.Size(3, 522);
            this.materialDivider3.TabIndex = 8;
            this.materialDivider3.Text = "materialDivider3";
            // 
            // rb_dificil
            // 
            this.rb_dificil.AutoSize = true;
            this.rb_dificil.Depth = 0;
            this.rb_dificil.Font = new System.Drawing.Font("Roboto", 10F);
            this.rb_dificil.Location = new System.Drawing.Point(381, 431);
            this.rb_dificil.Margin = new System.Windows.Forms.Padding(0);
            this.rb_dificil.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rb_dificil.MouseState = MaterialSkin.MouseState.HOVER;
            this.rb_dificil.Name = "rb_dificil";
            this.rb_dificil.Ripple = true;
            this.rb_dificil.Size = new System.Drawing.Size(64, 30);
            this.rb_dificil.TabIndex = 7;
            this.rb_dificil.Tag = "Dificuldade";
            this.rb_dificil.Text = "Difícil";
            this.rb_dificil.UseVisualStyleBackColor = true;
            // 
            // rb_medio
            // 
            this.rb_medio.AutoSize = true;
            this.rb_medio.Depth = 0;
            this.rb_medio.Font = new System.Drawing.Font("Roboto", 10F);
            this.rb_medio.Location = new System.Drawing.Point(300, 431);
            this.rb_medio.Margin = new System.Windows.Forms.Padding(0);
            this.rb_medio.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rb_medio.MouseState = MaterialSkin.MouseState.HOVER;
            this.rb_medio.Name = "rb_medio";
            this.rb_medio.Ripple = true;
            this.rb_medio.Size = new System.Drawing.Size(67, 30);
            this.rb_medio.TabIndex = 6;
            this.rb_medio.Tag = "Dificuldade";
            this.rb_medio.Text = "Médio";
            this.rb_medio.UseVisualStyleBackColor = true;
            // 
            // rb_facil
            // 
            this.rb_facil.AutoSize = true;
            this.rb_facil.Checked = true;
            this.rb_facil.Depth = 0;
            this.rb_facil.Font = new System.Drawing.Font("Roboto", 10F);
            this.rb_facil.Location = new System.Drawing.Point(219, 431);
            this.rb_facil.Margin = new System.Windows.Forms.Padding(0);
            this.rb_facil.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rb_facil.MouseState = MaterialSkin.MouseState.HOVER;
            this.rb_facil.Name = "rb_facil";
            this.rb_facil.Ripple = true;
            this.rb_facil.Size = new System.Drawing.Size(58, 30);
            this.rb_facil.TabIndex = 5;
            this.rb_facil.TabStop = true;
            this.rb_facil.Tag = "Dificuldade";
            this.rb_facil.Text = "Fácil";
            this.rb_facil.UseVisualStyleBackColor = true;
            // 
            // materialDivider2
            // 
            this.materialDivider2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Location = new System.Drawing.Point(25, 379);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(662, 3);
            this.materialDivider2.TabIndex = 4;
            this.materialDivider2.Text = "materialDivider2";
            // 
            // materialDivider1
            // 
            this.materialDivider1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(25, 99);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(662, 3);
            this.materialDivider1.TabIndex = 2;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // txt_pergunta
            // 
            this.txt_pergunta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_pergunta.Depth = 0;
            this.txt_pergunta.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pergunta.Hint = "";
            this.txt_pergunta.Location = new System.Drawing.Point(143, 58);
            this.txt_pergunta.MaxLength = 50;
            this.txt_pergunta.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_pergunta.Name = "txt_pergunta";
            this.txt_pergunta.PasswordChar = '\0';
            this.txt_pergunta.SelectedText = "";
            this.txt_pergunta.SelectionLength = 0;
            this.txt_pergunta.SelectionStart = 0;
            this.txt_pergunta.Size = new System.Drawing.Size(465, 23);
            this.txt_pergunta.TabIndex = 0;
            this.txt_pergunta.TabStop = false;
            this.txt_pergunta.Text = "Qual a grafia correta?";
            this.txt_pergunta.UseSystemPasswordChar = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_novaPergunta);
            this.panel1.Controls.Add(this.list_palavras);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 525);
            this.panel1.TabIndex = 3;
            // 
            // btn_novaPergunta
            // 
            this.btn_novaPergunta.Depth = 0;
            this.btn_novaPergunta.Location = new System.Drawing.Point(7, 5);
            this.btn_novaPergunta.Margin = new System.Windows.Forms.Padding(10);
            this.btn_novaPergunta.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_novaPergunta.Name = "btn_novaPergunta";
            this.btn_novaPergunta.Primary = true;
            this.btn_novaPergunta.Size = new System.Drawing.Size(206, 41);
            this.btn_novaPergunta.TabIndex = 2;
            this.btn_novaPergunta.Text = "Nova Pergunta";
            this.btn_novaPergunta.UseVisualStyleBackColor = true;
            this.btn_novaPergunta.Click += new System.EventHandler(this.btn_novaPergunta_Click);
            // 
            // list_palavras
            // 
            this.list_palavras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.list_palavras.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Cod,
            this.Palavra});
            this.list_palavras.Depth = 0;
            this.list_palavras.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.list_palavras.Font = new System.Drawing.Font("Roboto", 24F);
            this.list_palavras.ForeColor = System.Drawing.SystemColors.Menu;
            this.list_palavras.FullRowSelect = true;
            this.list_palavras.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.list_palavras.Location = new System.Drawing.Point(0, 54);
            this.list_palavras.MouseLocation = new System.Drawing.Point(-1, -1);
            this.list_palavras.MouseState = MaterialSkin.MouseState.OUT;
            this.list_palavras.Name = "list_palavras";
            this.list_palavras.OwnerDraw = true;
            this.list_palavras.Size = new System.Drawing.Size(220, 471);
            this.list_palavras.TabIndex = 0;
            this.list_palavras.UseCompatibleStateImageBehavior = false;
            this.list_palavras.View = System.Windows.Forms.View.Details;
            this.list_palavras.SelectedIndexChanged += new System.EventHandler(this.list_palavras_SelectedIndexChanged);
            // 
            // Cod
            // 
            this.Cod.Text = "Nº";
            this.Cod.Width = 54;
            // 
            // Palavra
            // 
            this.Palavra.Text = "Palavras";
            this.Palavra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Palavra.Width = 200;
            // 
            // rb_NivelFundamental
            // 
            this.rb_NivelFundamental.AutoSize = true;
            this.rb_NivelFundamental.BackColor = System.Drawing.Color.Transparent;
            this.rb_NivelFundamental.Checked = true;
            this.rb_NivelFundamental.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_NivelFundamental.ForeColor = System.Drawing.Color.White;
            this.rb_NivelFundamental.Location = new System.Drawing.Point(292, 27);
            this.rb_NivelFundamental.Name = "rb_NivelFundamental";
            this.rb_NivelFundamental.Size = new System.Drawing.Size(222, 33);
            this.rb_NivelFundamental.TabIndex = 1;
            this.rb_NivelFundamental.TabStop = true;
            this.rb_NivelFundamental.Text = "Nível Fundamental";
            this.rb_NivelFundamental.UseVisualStyleBackColor = false;
            this.rb_NivelFundamental.CheckedChanged += new System.EventHandler(this.rb_NivelFundamental_CheckedChanged);
            // 
            // rb_nivelMedio
            // 
            this.rb_nivelMedio.AutoSize = true;
            this.rb_nivelMedio.BackColor = System.Drawing.Color.Transparent;
            this.rb_nivelMedio.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_nivelMedio.ForeColor = System.Drawing.Color.White;
            this.rb_nivelMedio.Location = new System.Drawing.Point(652, 27);
            this.rb_nivelMedio.Name = "rb_nivelMedio";
            this.rb_nivelMedio.Size = new System.Drawing.Size(150, 33);
            this.rb_nivelMedio.TabIndex = 2;
            this.rb_nivelMedio.Text = "Nível Médio";
            this.rb_nivelMedio.UseVisualStyleBackColor = false;
            this.rb_nivelMedio.CheckedChanged += new System.EventHandler(this.rb_nivelMedio_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(954, 643);
            this.Controls.Add(this.rb_nivelMedio);
            this.Controls.Add(this.rb_NivelFundamental);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Ortoquiz";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnl_cadastro.ResumeLayout(false);
            this.pnl_cadastro.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private MaterialListView list_palavras;
        private ColumnHeader Palavra;
        private MaterialRaisedButton btn_remover;
        private Panel pnl_cadastro;
        private MaterialSingleLineTextField txt_pergunta;
        private MaterialDivider materialDivider1;
        private MaterialDivider materialDivider3;
        private MaterialRadioButton rb_dificil;
        private MaterialRadioButton rb_medio;
        private MaterialRadioButton rb_facil;
        private MaterialDivider materialDivider2;
        private Label label1;
        private Label label2;
        private MaterialSingleLineTextField txt_dica;
        private Label label3;
        private MaterialRaisedButton btn_salvar;
        private MaterialRaisedButton btn_editar;
        private Panel panel1;
        private MaterialRaisedButton btn_novaPergunta;
        private GroupBox groupBox1;
        private MaterialRadioButton rb_A;
        private MaterialRadioButton rb_C;
        private MaterialRadioButton rb_B;
        private Label label8;
        private MaterialSingleLineTextField txt_C;
        private MaterialSingleLineTextField txt_B;
        private MaterialSingleLineTextField txt_A;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private ColumnHeader Cod;
        private RadioButton rb_NivelFundamental;
        private RadioButton rb_nivelMedio;

    }
}