using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using projAtendimento.Models;
using projAtendimento.Controllers;

namespace projAtendimento
{
    public partial class Atendimento : Form
    {
        private Senhas senhas = new Senhas();
        private Guiches guiches = new Guiches();
        public Atendimento()
        {
            InitializeComponent();
        }
        private void btnGerar_Click(object sender, EventArgs e)
        {
            senhas.gerar();
        }
        private void btnListarSenhas_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            senhas.FilaSenhas.ToList().ForEach(i => listBox1.Items.Add(i.dadosParciais()));
        }
        
        private void btnListarAtend_Click(object sender, EventArgs e)
        {
            var index = Int32.Parse(textGuiche.Text) - 1;
            txtSenhasGuiche.Items.Clear();
            guiches.ListaGuiches[index].Atendimentos.ToList().ForEach(i => txtSenhasGuiche.Items.Add(i.dadosCompletos()));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            guiches.adicionar(new Guiche());
            lblNumGuiche.Text = guiches.ListaGuiches.Count.ToString();
        }       
        private void btnChamar_Click(object sender, EventArgs e)
        {
            var index = Int32.Parse(textGuiche.Text) - 1;
            guiches.ListaGuiches[index].chamar(senhas.FilaSenhas);
        }

        private void label1_Click(object sender, EventArgs e) { }

        private void textBox3_TextChanged(object sender, EventArgs e) { }

        private void Atendimento_Load(object sender, EventArgs e) { }
        
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) { }
       
    }
}
