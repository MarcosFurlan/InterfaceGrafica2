namespace FilmesAssistidos
{
    partial class Form1
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Ação", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("Aventura", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("Comédia", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup5 = new System.Windows.Forms.ListViewGroup("Terror", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup6 = new System.Windows.Forms.ListViewGroup("Suspense", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup7 = new System.Windows.Forms.ListViewGroup("Documentário", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup8 = new System.Windows.Forms.ListViewGroup("Infantil", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup9 = new System.Windows.Forms.ListViewGroup("LVRomance", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup10 = new System.Windows.Forms.ListViewGroup("Ficção Científica", System.Windows.Forms.HorizontalAlignment.Left);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFilme = new System.Windows.Forms.TextBox();
            this.txtLocal = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.colFilme = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGenero = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colData = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLocal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filme";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(335, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gênero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(511, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(633, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Local";
            // 
            // txtFilme
            // 
            this.txtFilme.Location = new System.Drawing.Point(55, 86);
            this.txtFilme.Name = "txtFilme";
            this.txtFilme.Size = new System.Drawing.Size(263, 20);
            this.txtFilme.TabIndex = 4;
            // 
            // txtLocal
            // 
            this.txtLocal.Location = new System.Drawing.Point(636, 86);
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.Size = new System.Drawing.Size(208, 20);
            this.txtLocal.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "",
            "Ação",
            "Aventura",
            "Comédia",
            "Terror",
            "Suspense",
            "Documentário",
            "Infantil",
            "Romance",
            "Ficção"});
            this.comboBox1.Location = new System.Drawing.Point(338, 85);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(155, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(514, 86);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(106, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(339, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(250, 57);
            this.label5.TabIndex = 8;
            this.label5.Text = "Meus Filmes";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 25);
            this.button1.TabIndex = 9;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(110, 132);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 25);
            this.button2.TabIndex = 10;
            this.button2.Text = "Excluir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(208, 132);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 25);
            this.button3.TabIndex = 11;
            this.button3.Text = "Gravar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(306, 132);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(92, 25);
            this.button4.TabIndex = 12;
            this.button4.Text = "Pesquisar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colFilme,
            this.colGenero,
            this.colData,
            this.colLocal});
            this.listView1.FullRowSelect = true;
            listViewGroup1.Header = "ListViewGroup";
            listViewGroup1.Name = "     ";
            listViewGroup2.Header = "Ação";
            listViewGroup2.Name = "Acao";
            listViewGroup3.Header = "Aventura";
            listViewGroup3.Name = "Aventura";
            listViewGroup4.Header = "Comédia";
            listViewGroup4.Name = "Comedia";
            listViewGroup5.Header = "Terror";
            listViewGroup5.Name = "Terror";
            listViewGroup6.Header = "Suspense";
            listViewGroup6.Name = "Suspense";
            listViewGroup7.Header = "Documentário";
            listViewGroup7.Name = "Documentario";
            listViewGroup8.Header = "Infantil";
            listViewGroup8.Name = "Infantil";
            listViewGroup9.Header = "LVRomance";
            listViewGroup9.Name = "Romance";
            listViewGroup10.Header = "Ficção Científica";
            listViewGroup10.Name = "FiccaoCientifica";
            this.listView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3,
            listViewGroup4,
            listViewGroup5,
            listViewGroup6,
            listViewGroup7,
            listViewGroup8,
            listViewGroup9,
            listViewGroup10});
            this.listView1.LabelEdit = true;
            this.listView1.Location = new System.Drawing.Point(12, 163);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(832, 208);
            this.listView1.TabIndex = 13;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // colFilme
            // 
            this.colFilme.Text = "Filme";
            this.colFilme.Width = 322;
            // 
            // colGenero
            // 
            this.colGenero.Text = "Gênero";
            this.colGenero.Width = 164;
            // 
            // colData
            // 
            this.colData.Text = "Data";
            this.colData.Width = 102;
            // 
            // colLocal
            // 
            this.colLocal.Text = "Local";
            this.colLocal.Width = 242;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 382);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtLocal);
            this.Controls.Add(this.txtFilme);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFilme;
        private System.Windows.Forms.TextBox txtLocal;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader colFilme;
        private System.Windows.Forms.ColumnHeader colGenero;
        private System.Windows.Forms.ColumnHeader colData;
        private System.Windows.Forms.ColumnHeader colLocal;
    }
}

