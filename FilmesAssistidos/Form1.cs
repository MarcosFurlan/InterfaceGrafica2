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
        // Método para excluir Item do Dicionário e do ListView
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
            errorProvider1.Clear();
            if (txtFilme.Text.Trim().Equals(""))
            {
                errorProvider1.SetError(txtFilme, "O Nome é obrigatório!");
                txtFilme.Focus();
                return;
                
            }
            errorProvider1.Clear();
            if (comboBox1.Text.Trim().Equals(""))
            {
                errorProvider1.SetError(comboBox1, "O Gênero é obrigatório!");
                txtFilme.Focus();
                return;

            }

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

            listView1.Items.AddRange(new ListViewItem[] { Item });

            foreach (ListViewItem item in listView1.Items)
            {
                if ((item.Index % 2) == 0)
                {
                    item.BackColor = Color.Beige;
                }
                else
                {
                    item.BackColor = Color.White;
                }
            }
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


                            PercorreObjeto.Nome = txtFilme.Text;
                            PercorreObjeto.Genero = comboBox1.Text;
                            PercorreObjeto.Data = dateTimePicker1.Text;
                            PercorreObjeto.Local = txtLocal.Text;

                            Excluir();


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
                            listView1.Items.AddRange(new ListViewItem[] { Item });

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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtFilme.Focus();
            labelHora.Text = DateTime.Now.ToShortTimeString();
            labelData.Text = DateTime.Now.ToShortDateString();
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

    }
}
