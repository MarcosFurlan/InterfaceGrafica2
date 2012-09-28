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
        ListViewItem Item = new ListViewItem();
        string EditarFilme;
        int EditarGenero;
        DateTime EditarData;
        string EditarLocal;
        
        
        public Form1()
        {
            InitializeComponent();
            
        }
        
        
        private void button1_Click(object sender, EventArgs e)
        {
            

           // DateTime DT = DateTime.ParseExact(dateTimePicker1.Text, "dd / MM / aaaa", null);
           // DateTime data = dateTimePicker1.Value;
            FilmeA pegar = new FilmeA(txtFilme.Text, comboBox1.Text ,  dateTimePicker1.Text , txtLocal.Text);

             
            ListViewItem Item = new ListViewItem(txtFilme.Text);
            Item.SubItems.Add(comboBox1.Text);
            Item.SubItems.Add(dateTimePicker1.Value.ToShortDateString());
            Item.SubItems.Add(txtLocal.Text);
            Item.Group = listView1.Groups[comboBox1.SelectedIndex -1];

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
            foreach (ListViewItem listItem in listView1.SelectedItems)
            {
                foreach (KeyValuePair<string, List<FilmeA>> ChaveValor in dic)
                {


                    //if (ChaveValor.Value == )
                    //{
                    //}


                }
                listView1.Items.Remove(listItem);

            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {


            foreach (List<FilmeA> ValoresDicionario in dic.Values)
            {

                foreach (FilmeA PercorreObjeto in ValoresDicionario)
                {
                    if (PercorreObjeto.Nome == EditarFilme && PercorreObjeto.Genero == EditarGenero && PercorreObjeto.Local == EditarLocal && PercorreObjeto.Data == EditarData.ToShortDateString())
                    {
                        PercorreObjeto.Nome = txtFilme.Text;
                        PercorreObjeto.Genero = comboBox1.Text;
                        PercorreObjeto.Data = dateTimePicker1.Text;
                        PercorreObjeto.Local = txtLocal.Text;
                    }
                }
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {

            foreach (ListViewItem SelecionaFilme in listView1.SelectedItems)
            {
                txtFilme.Text = SelecionaFilme.Text;
                comboBox1.Text = SelecionaFilme.Group.Header;
               // dateTimePicker1 = SelecionaFilme.SubItems[1].Text;
                txtLocal.Text = SelecionaFilme.SubItems[2].Text;
                EditarFilme = SelecionaFilme.Text;
               // EditarData = Convert.ToDateTime(SelecionaFilme.SubItems[1].Text);
                EditarGenero = listView1.Groups.IndexOf(SelecionaFilme.Group);
                EditarLocal = SelecionaFilme.SubItems[2].Text;
            }

            
                
        }
    }
}
