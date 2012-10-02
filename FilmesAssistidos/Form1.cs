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
        string EditarNome;
        string EditarGenero;
        string EditarLocal;


        public Form1()
        {
            InitializeComponent();

        }
        // Métoo para excluir Item do Dicionário e do ListView
        public void Excluir()
        {
            foreach (ListViewItem listItem in listView1.SelectedItems)
            {

                string Genero = listItem.SubItems[1].Text;
                List<FilmeA> LFilme = dic[Genero];
                for (int i = 0; i < LFilme.Count; i++)
                {
                    if (LFilme[i].Nome == listItem.Text)
                    {
                        LFilme.RemoveAt(i);
                        i--;
                    }

                    listView1.Items.Remove(listItem);
                }

            }
        }

        // Gravando Itens no dicionário e apresentando no ListView
        private void button1_Click(object sender, EventArgs e)
        {
            FilmeA pegar = new FilmeA(txtFilme.Text, comboBox1.Text, dateTimePicker1.Text, txtLocal.Text);


            ListViewItem Item = new ListViewItem(txtFilme.Text);
            Item.SubItems.Add(comboBox1.Text);
            Item.SubItems.Add(dateTimePicker1.Value.ToShortDateString());
            Item.SubItems.Add(txtLocal.Text);
            Item.Group = listView1.Groups[comboBox1.SelectedIndex];

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

        // Deletando do ListView e do Dicionário
        private void button2_Click(object sender, EventArgs e)
        {
            Excluir();
        }

        // Alterando o Item selecionado 
        private void button3_Click(object sender, EventArgs e)
        {


            foreach (List<FilmeA> ValoresDicionario in dic.Values)
            {

                foreach (FilmeA PercorreObjeto in ValoresDicionario)
                {
                    if (PercorreObjeto.Nome == EditarNome && PercorreObjeto.Genero == EditarGenero && PercorreObjeto.Local == EditarLocal)
                    {
                        Excluir();

                        PercorreObjeto.Nome = txtFilme.Text;
                        PercorreObjeto.Genero = comboBox1.Text;
                        PercorreObjeto.Data = dateTimePicker1.Text;
                        PercorreObjeto.Local = txtLocal.Text;

                        if (dic.ContainsKey(comboBox1.Text))
                        {
                            List<FilmeA> ListaIndice = dic[comboBox1.Text];
                            ListaIndice.Add(PercorreObjeto);

                        }
                        else
                        {
                            List<FilmeA> passagem = new List<FilmeA>();
                            passagem.Add(PercorreObjeto);
                            dic.Add(comboBox1.Text, passagem);
                        }

                        txtFilme.Focus();
                        txtFilme.Text = "";
                        comboBox1.Text = "";
                        txtLocal.Text = "";
                        MessageBox.Show("Alterado com Sucesso", "Parabéns");

                    }
                }
            }
        }

        // Ao Clicar duas vezes sobre o Item permite-se alteração
        private void listView1_DoubleClick(object sender, EventArgs e)
        {

            foreach (ListViewItem SelecionaFilme in listView1.SelectedItems)
            {
                txtFilme.Text = SelecionaFilme.Text;
                comboBox1.Text = SelecionaFilme.Group.Header;
                txtLocal.Text = SelecionaFilme.SubItems[3].Text;
                EditarNome = SelecionaFilme.Text;
                EditarGenero = SelecionaFilme.SubItems[1].Text; ;
                EditarLocal = SelecionaFilme.SubItems[3].Text;
            }



        }

    }
}
