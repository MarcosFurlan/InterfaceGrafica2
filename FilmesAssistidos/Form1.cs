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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dictionary<string, List<FilmeA>> dic = new Dictionary<string, List<FilmeA>>();
            string data = dateTimePicker1.Value.ToShortDateString();
            List<FilmeA> Entrada = new List<FilmeA>();
            
         

            ListViewItem Item = new ListViewItem(txtFilme.Text);
            Item.SubItems.Add(comboBox1.Text);
            Item.SubItems.Add(data);
            Item.SubItems.Add(txtLocal.Text);

            MessageBox.Show("Cadastro Realizado com Sucesso", "Parabéns");
            listView1.Items.AddRange(new ListViewItem[] { Item });
            dic.Add(comboBox1.Text, Entrada);

        }
    }
}
