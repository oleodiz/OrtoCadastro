using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace MaterialSkinExample
{
    public partial class MainForm : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        List<Pergunta> perguntasFundamental, perguntasMedio;
        int posicaoEditar = -1;
        public MainForm()
        {
            InitializeComponent();

            // Initialize MaterialSkinManager
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
			materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
			materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            perguntasFundamental = new List<Pergunta>();
            perguntasMedio = new List<Pergunta>();
            carregarArquivo();
            perguntasFundamental.Sort((x, y) => x.palavra.CompareTo(y.palavra));
            for (int i = 0; i < perguntasFundamental.Count; i++)
                perguntasFundamental[i].num = i + 1;

            perguntasMedio.Sort((x, y) => x.palavra.CompareTo(y.palavra));
            for (int i = 0; i < perguntasMedio.Count; i++)
                perguntasMedio[i].num = i + 1;

            carregaList();
            if (list_palavras.Items.Count > 0)
                list_palavras.Items[0].Selected = true;

        }

        private void carregaList()
        {
            list_palavras.Items.Clear();

            list_palavras.BeginUpdate();
            int i = 0;
            if (rb_NivelFundamental.Checked)
            {
                foreach (Pergunta p in perguntasFundamental)
                {
                    list_palavras.Items.Add(p.num + "");
                    list_palavras.Items[i].SubItems.Add(p.palavra);
                    i++;
                }
            }
            else
            {
                foreach (Pergunta p in perguntasMedio)
                {
                    list_palavras.Items.Add(p.num + "");
                    list_palavras.Items[i].SubItems.Add(p.palavra);
                    i++;
                }
            }
                list_palavras.EndUpdate();
        }

        private void carregarArquivo()
        {

            String text= leArquivo();
            if (text != "")
            {
                String decriptado = StringCipher.Decrypt(text);
                List <Pergunta>  perAux = StringCipher.ParseXML<List<Pergunta>>(decriptado);

                for (int i =0; i< perAux.Count; i++)
                {
                    if (perAux[i].nivel == 0)
                        perguntasFundamental.Add(perAux[i]);
                    else
                        perguntasMedio.Add(perAux[i]);
                }
            }
        }

        private void btn_novaPergunta_Click(object sender, EventArgs e)
        {
            btn_editar.Visible = false; btn_salvar.Visible = true;

            txt_pergunta.Text = "Qual a grafia correta?";
            txt_A.Text = "";
            txt_B.Text = "";
            txt_C.Text = "";
            txt_dica.Text = "";

            rb_A.Checked = true;
            rb_facil.Checked = true;
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            Pergunta p = new Pergunta();
            p.dica = txt_dica.Text;
            p.titulo = txt_pergunta.Text;
            p.opcaoA=  txt_A.Text;
            p.opcaoB = txt_B.Text;
            p.opcaoC = txt_C.Text;

            p.opcaoCorreta = rb_A.Checked ? 0 : (rb_B.Checked ? 1 : 2);
            p.dificuldade = rb_facil.Checked ? 0 : (rb_medio.Checked ? 1 : 2);
            p.nivel = rb_NivelFundamental.Checked ? 0 : 1;
            if (p.opcaoCorreta == 0)
                p.palavra = txt_A.Text;
            else
            if (p.opcaoCorreta == 1)
                p.palavra = txt_B.Text;
            else
                p.palavra = txt_C.Text;

            if (rb_NivelFundamental.Checked)
            {
                p.num = perguntasFundamental.Count + 1;

                perguntasFundamental.Add(p);
                list_palavras.BeginUpdate();
                list_palavras.Items.Add(p.num + "");
                list_palavras.Items[perguntasFundamental.Count - 1].SubItems.Add(p.palavra);
                list_palavras.EndUpdate();
            }
            else
            {
                p.num = perguntasMedio.Count + 1;

                perguntasMedio.Add(p);
                list_palavras.BeginUpdate();
                list_palavras.Items.Add(p.num + "");
                list_palavras.Items[perguntasMedio.Count - 1].SubItems.Add(p.palavra);
                list_palavras.EndUpdate();
            }
       
            salvarArquivo();
            MessageBox.Show("Pergunta Salva!");
            btn_salvar.Visible = false;
            btn_novaPergunta_Click(sender, e);
        }

	  private void salvarArquivo()
        {

            List<Pergunta> todasPerguntas = new List<Pergunta>();
            todasPerguntas.AddRange(perguntasFundamental);
            todasPerguntas.AddRange(perguntasMedio);
            String xml = StringCipher.Serialize<List<Pergunta>>(todasPerguntas);
            //xml = xml.Replace("ArrayOfPergunta", "Perguntas");
            String text = StringCipher.Encrypt(xml);

            string lines = text;

            // Write the string to a file.
            System.IO.StreamWriter file = new System.IO.StreamWriter("ortoquizDados.xml");
            file.WriteLine(lines);

            file.Close();
        }
      private String leArquivo()
      {
          int counter = 0;
          string line, text = "";

          // Read the file and display it line by line.
          try
          {
              System.IO.StreamReader file =
                 new System.IO.StreamReader("ortoquizDados.xml");
              while ((line = file.ReadLine()) != null)
              {
                  text += line;
                  counter++;
              }

              file.Close();
          }
          catch(Exception e)
          {
              MessageBox.Show("Arquivo não encontrado, um novo será criado!");
              return "";
          }
          return text;
      }

      private void list_palavras_SelectedIndexChanged(object sender, EventArgs e)
      {
          int posicao = -1;

            if (list_palavras.SelectedIndices.Count > 0)
                posicao = list_palavras.SelectedIndices[0];

            if (posicao != -1)
            {
                btn_remover.Visible = true;
                btn_editar.Visible = true;

                if (rb_NivelFundamental.Checked)
                {
                    txt_pergunta.Text = perguntasFundamental[posicao].titulo;
                    txt_A.Text = perguntasFundamental[posicao].opcaoA;
                    txt_B.Text = perguntasFundamental[posicao].opcaoB;
                    txt_C.Text = perguntasFundamental[posicao].opcaoC;
                    txt_dica.Text = perguntasFundamental[posicao].dica;
                    switch (perguntasFundamental[posicao].dificuldade)
                    {
                        case 0: { rb_facil.Checked = true; break; }
                        case 1: { rb_medio.Checked = true; break; }
                        case 2: { rb_dificil.Checked = true; break; }
                    }
                    switch (perguntasFundamental[posicao].opcaoCorreta)
                    {
                        case 0: { rb_A.Checked = true; break; }
                        case 1: { rb_B.Checked = true; break; }
                        case 2: { rb_C.Checked = true; break; }
                    }
                }
                else
                {
                    txt_pergunta.Text = perguntasMedio[posicao].titulo;
                    txt_A.Text = perguntasMedio[posicao].opcaoA;
                    txt_B.Text = perguntasMedio[posicao].opcaoB;
                    txt_C.Text = perguntasMedio[posicao].opcaoC;
                    txt_dica.Text = perguntasMedio[posicao].dica;
                    switch (perguntasMedio[posicao].dificuldade)
                    {
                        case 0: { rb_facil.Checked = true; break; }
                        case 1: { rb_medio.Checked = true; break; }
                        case 2: { rb_dificil.Checked = true; break; }
                    }
                    switch (perguntasMedio[posicao].opcaoCorreta)
                    {
                        case 0: { rb_A.Checked = true; break; }
                        case 1: { rb_B.Checked = true; break; }
                        case 2: { rb_C.Checked = true; break; }
                    }

                }
            }
            else
                btn_remover.Visible = false;

            posicaoEditar = posicao;

      }

      private void btn_remover_Click(object sender, EventArgs e)
      {
          int posicao = -1;

            if (list_palavras.SelectedIndices.Count > 0)
                posicao = list_palavras.SelectedIndices[0];

            if (posicao != -1)
            {
                DialogResult dr = MessageBox.Show("Deseja mesmo remover essa palavra do Quiz?","Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dr == DialogResult.Yes)
                {
                    if (rb_NivelFundamental.Checked)
                        perguntasFundamental.RemoveAt(posicao);
                    else
                        perguntasMedio.RemoveAt(posicao);
                    carregaList();
                    salvarArquivo();
                }
              
            
            }
            else
                MessageBox.Show("Nenhuma palavra selecionada");
      }

      private void btn_editar_Click(object sender, EventArgs e)
      {
          if (posicaoEditar != - 1)
          {
              if (rb_NivelFundamental.Checked)
              {
                  perguntasFundamental[posicaoEditar].dica = txt_dica.Text;
                  perguntasFundamental[posicaoEditar].titulo = txt_pergunta.Text;
                  perguntasFundamental[posicaoEditar].opcaoA = txt_A.Text;
                  perguntasFundamental[posicaoEditar].opcaoB = txt_B.Text;
                  perguntasFundamental[posicaoEditar].opcaoC = txt_C.Text;

                  perguntasFundamental[posicaoEditar].opcaoCorreta = rb_A.Checked ? 0 : (rb_B.Checked ? 1 : 2);
                  perguntasFundamental[posicaoEditar].dificuldade = rb_facil.Checked ? 0 : (rb_medio.Checked ? 1 : 2);

                  if (perguntasFundamental[posicaoEditar].opcaoCorreta == 0)
                      perguntasFundamental[posicaoEditar].palavra = txt_A.Text;
                  else
                      if (perguntasFundamental[posicaoEditar].opcaoCorreta == 1)
                          perguntasFundamental[posicaoEditar].palavra = txt_B.Text;
                      else
                          perguntasFundamental[posicaoEditar].palavra = txt_C.Text;

                  list_palavras.Items[posicaoEditar].SubItems[1].Text = perguntasFundamental[posicaoEditar].palavra;
              }
              else
              {
                  perguntasMedio[posicaoEditar].dica = txt_dica.Text;
                  perguntasMedio[posicaoEditar].titulo = txt_pergunta.Text;
                  perguntasMedio[posicaoEditar].opcaoA = txt_A.Text;
                  perguntasMedio[posicaoEditar].opcaoB = txt_B.Text;
                  perguntasMedio[posicaoEditar].opcaoC = txt_C.Text;

                  perguntasMedio[posicaoEditar].opcaoCorreta = rb_A.Checked ? 0 : (rb_B.Checked ? 1 : 2);
                  perguntasMedio[posicaoEditar].dificuldade = rb_facil.Checked ? 0 : (rb_medio.Checked ? 1 : 2);

                  if (perguntasMedio[posicaoEditar].opcaoCorreta == 0)
                      perguntasMedio[posicaoEditar].palavra = txt_A.Text;
                  else
                      if (perguntasMedio[posicaoEditar].opcaoCorreta == 1)
                          perguntasMedio[posicaoEditar].palavra = txt_B.Text;
                      else
                          perguntasMedio[posicaoEditar].palavra = txt_C.Text;

                  list_palavras.Items[posicaoEditar].SubItems[1].Text = perguntasMedio[posicaoEditar].palavra;
              }
              salvarArquivo();
              MessageBox.Show("Questão editada!");

          }
      }

      private void rb_NivelFundamental_CheckedChanged(object sender, EventArgs e)
      {
          if (rb_NivelFundamental.Checked)
              rb_nivelMedio.Checked = false;

          carregaList();
          btn_novaPergunta_Click(null, null);
      }

      private void rb_nivelMedio_CheckedChanged(object sender, EventArgs e)
      {
          if (rb_nivelMedio.Checked)
              rb_NivelFundamental.Checked = false;

          carregaList();
          btn_novaPergunta_Click(null, null);

      }

          
    }
}
