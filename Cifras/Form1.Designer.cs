namespace Cifras
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
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_converter = new System.Windows.Forms.Button();
            this.btn_treinar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_input = new System.Windows.Forms.TextBox();
            this.pic_output = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_encriptar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_encriptado_alfabeto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_normal = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.rtxt_encriptado = new System.Windows.Forms.RichTextBox();
            this.btn_encriptar_cc = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_texto_encriptar_cifra_chinesa = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.pic_braille = new System.Windows.Forms.PictureBox();
            this.txt_aEncriptar_Braille = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_encriptar_braille = new System.Windows.Forms.Button();
            this.line1 = new Cifras.Line();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.txt_data = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_texto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_encriptar_data = new System.Windows.Forms.Button();
            this.txt_encriptado_data = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.txt_encriptar_invertido = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_encriptado_invertido = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_encriptar_invertido = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_output)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_braille)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cifras";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(16, 54);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(600, 400);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Controls.Add(this.btn_converter);
            this.tabPage1.Controls.Add(this.btn_treinar);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txt_input);
            this.tabPage1.Controls.Add(this.pic_output);
            this.tabPage1.ForeColor = System.Drawing.Color.Black;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(592, 374);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Homografo";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_converter
            // 
            this.btn_converter.Location = new System.Drawing.Point(372, 98);
            this.btn_converter.Name = "btn_converter";
            this.btn_converter.Size = new System.Drawing.Size(75, 23);
            this.btn_converter.TabIndex = 5;
            this.btn_converter.Text = "Converter";
            this.btn_converter.UseVisualStyleBackColor = true;
            this.btn_converter.Click += new System.EventHandler(this.btn_converter_Click);
            // 
            // btn_treinar
            // 
            this.btn_treinar.Location = new System.Drawing.Point(163, 98);
            this.btn_treinar.Name = "btn_treinar";
            this.btn_treinar.Size = new System.Drawing.Size(75, 23);
            this.btn_treinar.TabIndex = 4;
            this.btn_treinar.Text = "Treinar";
            this.btn_treinar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(160, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(357, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Digite a frase para converter para o homografo";
            // 
            // txt_input
            // 
            this.txt_input.Location = new System.Drawing.Point(163, 61);
            this.txt_input.Name = "txt_input";
            this.txt_input.Size = new System.Drawing.Size(284, 20);
            this.txt_input.TabIndex = 1;
            // 
            // pic_output
            // 
            this.pic_output.Location = new System.Drawing.Point(7, 7);
            this.pic_output.Name = "pic_output";
            this.pic_output.Size = new System.Drawing.Size(110, 252);
            this.pic_output.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_output.TabIndex = 0;
            this.pic_output.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_encriptar);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txt_encriptado_alfabeto);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.txt_normal);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(592, 374);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Alfabeto fonetico";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_encriptar
            // 
            this.btn_encriptar.Location = new System.Drawing.Point(496, 225);
            this.btn_encriptar.Name = "btn_encriptar";
            this.btn_encriptar.Size = new System.Drawing.Size(75, 23);
            this.btn_encriptar.TabIndex = 4;
            this.btn_encriptar.Text = "Encriptar";
            this.btn_encriptar.UseVisualStyleBackColor = true;
            this.btn_encriptar.Click += new System.EventHandler(this.btn_encriptar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(346, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Encriptado";
            // 
            // txt_encriptado_alfabeto
            // 
            this.txt_encriptado_alfabeto.Location = new System.Drawing.Point(6, 84);
            this.txt_encriptado_alfabeto.Multiline = true;
            this.txt_encriptado_alfabeto.Name = "txt_encriptado_alfabeto";
            this.txt_encriptado_alfabeto.ReadOnly = true;
            this.txt_encriptado_alfabeto.Size = new System.Drawing.Size(334, 165);
            this.txt_encriptado_alfabeto.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(346, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Texto a encriptar";
            // 
            // txt_normal
            // 
            this.txt_normal.Location = new System.Drawing.Point(6, 47);
            this.txt_normal.Name = "txt_normal";
            this.txt_normal.Size = new System.Drawing.Size(334, 20);
            this.txt_normal.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.rtxt_encriptado);
            this.tabPage3.Controls.Add(this.btn_encriptar_cc);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.txt_texto_encriptar_cifra_chinesa);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(592, 374);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Cifra chinesa";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // rtxt_encriptado
            // 
            this.rtxt_encriptado.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxt_encriptado.Location = new System.Drawing.Point(7, 139);
            this.rtxt_encriptado.Name = "rtxt_encriptado";
            this.rtxt_encriptado.ReadOnly = true;
            this.rtxt_encriptado.Size = new System.Drawing.Size(388, 45);
            this.rtxt_encriptado.TabIndex = 5;
            this.rtxt_encriptado.Text = "";
            this.rtxt_encriptado.TextChanged += new System.EventHandler(this.rtxt_encriptado_TextChanged);
            // 
            // btn_encriptar_cc
            // 
            this.btn_encriptar_cc.Location = new System.Drawing.Point(320, 190);
            this.btn_encriptar_cc.Name = "btn_encriptar_cc";
            this.btn_encriptar_cc.Size = new System.Drawing.Size(75, 23);
            this.btn_encriptar_cc.TabIndex = 4;
            this.btn_encriptar_cc.Text = "Encriptar";
            this.btn_encriptar_cc.UseVisualStyleBackColor = true;
            this.btn_encriptar_cc.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(401, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 19);
            this.label6.TabIndex = 3;
            this.label6.Text = "Encriptado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(401, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "Texto a encriptar";
            // 
            // txt_texto_encriptar_cifra_chinesa
            // 
            this.txt_texto_encriptar_cifra_chinesa.Location = new System.Drawing.Point(7, 91);
            this.txt_texto_encriptar_cifra_chinesa.Name = "txt_texto_encriptar_cifra_chinesa";
            this.txt_texto_encriptar_cifra_chinesa.Size = new System.Drawing.Size(388, 20);
            this.txt_texto_encriptar_cifra_chinesa.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Cifras.Properties.Resources.minimize;
            this.pictureBox3.Location = new System.Drawing.Point(566, 8);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 24);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Cifras.Properties.Resources.error;
            this.pictureBox1.Location = new System.Drawing.Point(592, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btn_encriptar_braille);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.txt_aEncriptar_Braille);
            this.tabPage4.Controls.Add(this.pic_braille);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(592, 374);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Braille Falso";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // pic_braille
            // 
            this.pic_braille.Location = new System.Drawing.Point(6, 151);
            this.pic_braille.Name = "pic_braille";
            this.pic_braille.Size = new System.Drawing.Size(580, 167);
            this.pic_braille.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_braille.TabIndex = 0;
            this.pic_braille.TabStop = false;
            // 
            // txt_aEncriptar_Braille
            // 
            this.txt_aEncriptar_Braille.Location = new System.Drawing.Point(6, 95);
            this.txt_aEncriptar_Braille.Name = "txt_aEncriptar_Braille";
            this.txt_aEncriptar_Braille.Size = new System.Drawing.Size(405, 20);
            this.txt_aEncriptar_Braille.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 22);
            this.label7.TabIndex = 2;
            this.label7.Text = "A encriptar";
            // 
            // btn_encriptar_braille
            // 
            this.btn_encriptar_braille.Location = new System.Drawing.Point(336, 121);
            this.btn_encriptar_braille.Name = "btn_encriptar_braille";
            this.btn_encriptar_braille.Size = new System.Drawing.Size(75, 24);
            this.btn_encriptar_braille.TabIndex = 3;
            this.btn_encriptar_braille.Text = "Encriptar";
            this.btn_encriptar_braille.UseVisualStyleBackColor = true;
            this.btn_encriptar_braille.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.Red;
            this.line1.Location = new System.Drawing.Point(16, 38);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(608, 10);
            this.line1.TabIndex = 1;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label10);
            this.tabPage5.Controls.Add(this.txt_encriptado_data);
            this.tabPage5.Controls.Add(this.btn_encriptar_data);
            this.tabPage5.Controls.Add(this.label9);
            this.tabPage5.Controls.Add(this.txt_texto);
            this.tabPage5.Controls.Add(this.label8);
            this.tabPage5.Controls.Add(this.txt_data);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(592, 374);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "DATA";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // txt_data
            // 
            this.txt_data.Location = new System.Drawing.Point(6, 50);
            this.txt_data.Name = "txt_data";
            this.txt_data.Size = new System.Drawing.Size(332, 20);
            this.txt_data.TabIndex = 0;
            this.txt_data.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txt_data.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Data";
            // 
            // txt_texto
            // 
            this.txt_texto.Location = new System.Drawing.Point(6, 97);
            this.txt_texto.Name = "txt_texto";
            this.txt_texto.Size = new System.Drawing.Size(332, 20);
            this.txt_texto.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Texto";
            // 
            // btn_encriptar_data
            // 
            this.btn_encriptar_data.Location = new System.Drawing.Point(263, 147);
            this.btn_encriptar_data.Name = "btn_encriptar_data";
            this.btn_encriptar_data.Size = new System.Drawing.Size(75, 23);
            this.btn_encriptar_data.TabIndex = 4;
            this.btn_encriptar_data.Text = "Encriptar";
            this.btn_encriptar_data.UseVisualStyleBackColor = true;
            this.btn_encriptar_data.Click += new System.EventHandler(this.btn_encriptar_data_Click);
            // 
            // txt_encriptado_data
            // 
            this.txt_encriptado_data.Location = new System.Drawing.Point(4, 245);
            this.txt_encriptado_data.Name = "txt_encriptado_data";
            this.txt_encriptado_data.ReadOnly = true;
            this.txt_encriptado_data.Size = new System.Drawing.Size(334, 20);
            this.txt_encriptado_data.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(344, 248);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Encriptado";
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.btn_encriptar_invertido);
            this.tabPage6.Controls.Add(this.label12);
            this.tabPage6.Controls.Add(this.txt_encriptado_invertido);
            this.tabPage6.Controls.Add(this.label11);
            this.tabPage6.Controls.Add(this.txt_encriptar_invertido);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(592, 374);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Alfabeto Invertido";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // txt_encriptar_invertido
            // 
            this.txt_encriptar_invertido.Location = new System.Drawing.Point(4, 57);
            this.txt_encriptar_invertido.Name = "txt_encriptar_invertido";
            this.txt_encriptar_invertido.Size = new System.Drawing.Size(309, 20);
            this.txt_encriptar_invertido.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(319, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "A encriptar";
            // 
            // txt_encriptado_invertido
            // 
            this.txt_encriptado_invertido.Location = new System.Drawing.Point(4, 101);
            this.txt_encriptado_invertido.Name = "txt_encriptado_invertido";
            this.txt_encriptado_invertido.ReadOnly = true;
            this.txt_encriptado_invertido.Size = new System.Drawing.Size(306, 20);
            this.txt_encriptado_invertido.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(322, 108);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Encriptado";
            // 
            // btn_encriptar_invertido
            // 
            this.btn_encriptar_invertido.Location = new System.Drawing.Point(7, 148);
            this.btn_encriptar_invertido.Name = "btn_encriptar_invertido";
            this.btn_encriptar_invertido.Size = new System.Drawing.Size(75, 23);
            this.btn_encriptar_invertido.TabIndex = 4;
            this.btn_encriptar_invertido.Text = "Encriptar";
            this.btn_encriptar_invertido.UseVisualStyleBackColor = true;
            this.btn_encriptar_invertido.Click += new System.EventHandler(this.btn_encriptar_invertido_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 406);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cifras";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_output)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_braille)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Line line1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_converter;
        private System.Windows.Forms.Button btn_treinar;
        private System.Windows.Forms.Button btn_falar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_input;
        private System.Windows.Forms.PictureBox pic_output;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_encriptar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_encriptado_alfabeto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_normal;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btn_encriptar_cc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_texto_encriptar_cifra_chinesa;
        private System.Windows.Forms.RichTextBox rtxt_encriptado;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btn_encriptar_braille;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_aEncriptar_Braille;
        private System.Windows.Forms.PictureBox pic_braille;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_data;
        private System.Windows.Forms.Button btn_encriptar_data;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_texto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_encriptado_data;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Button btn_encriptar_invertido;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_encriptado_invertido;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_encriptar_invertido;
    }
}

