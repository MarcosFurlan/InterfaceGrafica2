using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FilmesAssistidos
{
    
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            Dictionary<string, List<FilmeA>> dic = new Dictionary<string, List<FilmeA>>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dictionary<string, List<FilmeA>> dic = new Dictionary<string, List<FilmeA>>();
            string data = dateTimePicker1.Value.ToShortDateString();

            FilmeA pegar = new FilmeA(txtFilme.Text, comboBox1.Text, data, txtLocal.Text);
            

            ListViewItem Item = new ListViewItem(txtFilme.Text);
            Item.SubItems.Add(comboBox1.Text);
            Item.SubItems.Add(data);
            Item.SubItems.Add(txtLocal.Text);

            txtFilme.Focus();
            txtFilme.Text = "";
            comboBox1.Text = "";
            txtLocal.Text = "";


            MessageBox.Show("Cadastro Realizado com Sucesso", "Parabéns");

            listView1.Items.AddRange(new ListViewItem[] { Item });
            

        }
    }
}
