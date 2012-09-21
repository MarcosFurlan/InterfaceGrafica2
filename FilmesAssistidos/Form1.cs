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
        Dictionary<string, List<FilmeA>> dic = new Dictionary<string, List<FilmeA>>();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string data = dateTimePicker1.Value.ToShortDateString();

            FilmeA pegar = new FilmeA(txtFilme.Text, comboBox1.Text, data, txtLocal.Text);
            

            ListViewItem Item = new ListViewItem(txtFilme.Text);
            Item.SubItems.Add(comboBox1.Text);
            Item.SubItems.Add(data);
            Item.SubItems.Add(txtLocal.Text);
            Item.Group = listView1.Groups[comboBox1.SelectedIndex - 1];

            if (dic.ContainsKey(comboBox1.Text))
            {
                List<FilmeA> ListaIndice = dic[comboBox1.Text];
                ListaIndice.Add(pegar);
                
            }
            else
            {
                List<FilmeA> passagem = new List<FilmeA>();
                passagem.Add(pegar);
                dic.Add(comboBox1.Text, passagem);
            }

            txtFilme.Focus();
            txtFilme.Text = "";
            comboBox1.Text = "";
            txtLocal.Text = "";


            MessageBox.Show("Cadastro Realizado com Sucesso", "Parabéns");

            listView1.Items.AddRange(new ListViewItem[] { Item });
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            listView1.Items[0].Remove();
        }
    }
}
