using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PesquisaInfAdicionaisRetHP
{
    public partial class Form1 : Form
    {
        // campo global para guardar o diretório e o nome do arquivo XML a ser explorado
        public String fileXML = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            btnProcessFile.Enabled = false;
            btnSalveResult.Enabled = false;

            #region configurando componente OpenFolderDialog
            ofdMain.Filter = "(*.xml)|*.xml";
            ofdMain.Title = "Arquivo de Retorno Hermes Pardini";
            ofdMain.Multiselect = false;
            #endregion

            if (ofdMain.ShowDialog() == DialogResult.OK)
            {
                // atribuindo valor para campo global de diretório e nome do arquivo XML
                fileXML = ofdMain.FileName;
                // imprimindo conteúdo de campo global a barra de título do form
                this.Text = fileXML;
                btnProcessFile.Enabled = true;
            }

            // atribuindo conteúdo de campo global ao componente textBox
            txtFolderFile.Text = fileXML;
        }

        private void btnProcessFile_Click(object sender, EventArgs e)
        {
            try
            {
                // limpando componente textBox
                txtDados.Clear();

                // testando se existe um arquivo que corresponde com o campo global
                if (System.IO.File.Exists(fileXML))
                {
                    // variável que receberá uma estrutura genérica a partir de uma consulta LinqXML
                    var xyz =
                        from p in XElement.Load(fileXML)
                        .Elements("SuperExame")
                        .Elements("Exame")
                        .Elements("InfAdicional")
                        select new
                        {
                            // estrutura genérica de dados
                            CodExmApoio = p.Parent.Parent.Element("CodExmApoio").Value,
                            InfAdicional = p.Attribute("idInfAdicional").Value,
                            Descricao = p.Element("Descricao")?.Value,
                            Valor = p.Element("Valor")?.Value,
                            flag = 0
                        };

                    #region configurando progressBar
                    pbMain.Minimum = 0;
                    pbMain.Maximum = xyz.Count();
                    #endregion

                    #region configurando labels
                    int i = xyz.Count();
                    lblNrCorrente.Text = (0).ToString();
                    lblTotal.Text = i.ToString();
                    lblPercCorrente.Text = (0).ToString();
                    #endregion

                    #region instanciando e atribuindo valor inicial para uma variável local 
                    string cabecalho = "if exists(select * from tempdb.dbo.sysobjects o where o.name like '#teste%') drop table #teste;\r\n";
                    cabecalho += "create table #teste (CodExmApoio varchar(32), InfAdicional int, Descricao varchar(2048), Valor varchar(1024));\r\n\r\n";
                    #endregion

                    // começando a preencher o textBox de resultado
                    txtDados.AppendText(cabecalho);

                    // iteração para preencher parte do textBox
                    foreach (var abc in xyz)
                    {
                        // preenchendo textBox
                        txtDados.AppendText(formataLinha(abc.CodExmApoio, abc.InfAdicional, abc.Descricao, abc.Valor));
                        // incrementando valor do progressBar
                        pbMain.Value++;

                        #region mudando dinamicamente conteúdo dos labels
                        lblNrCorrente.Text = pbMain.Value.ToString();
                        lblPercCorrente.Text = ((pbMain.Value * 100) / i).ToString();
                        #endregion
                    }
                    // populando textBox (rodapé de conteúdo)
                    txtDados.AppendText("\r\n\r\nselect COUNT(*) Quantidade, Descricao, Valor from #teste group by Descricao, Valor order by COUNT(*) desc;\n");
                    btnSalveResult.Enabled = true;
                }
                // caso não for encontrado algum arquivo, dispara esta mensagem
                else
                {
                    MessageBox.Show("Não foi escolhido algum arquivo!");
                }
            }
            // caso algum erro for acionado, dispara esta mensagem
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // método que retorna uma string formada/customizada
        private string formataLinha(string CodExmApoio, string InfAdicional, string Descricao, string Valor)
        {
            return string.Format("insert into #teste select '{0}', {1}, '{2}', '{3}';\n", CodExmApoio, InfAdicional, Descricao, Valor);
        }

        private void btnSalveResult_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Title = "Save result in ...";
                sfd.Filter = "SQL File|*.sql";
                sfd.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
                sfd.FileName = "resultado-consulta";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show(sfd.FileName);
                    System.IO.File.WriteAllText(sfd.FileName, txtDados.Text);
                    if (System.IO.File.Exists(sfd.FileName))
                    {
                        MessageBox.Show(string.Format("Arquivo ({0}) criado com sucesso", sfd.FileName), "Status ação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        OpenAndSelectPath(sfd.FileName);
                    }
                }
            }
        }

        private void OpenAndSelectPath(string path)
        {
            bool isfile = System.IO.File.Exists(path);
            if (isfile)
            {
                string argument = @"/select, " + path;
                System.Diagnostics.Process.Start("explorer.exe", argument);
            }
            else
            {
                bool isfolder = System.IO.Directory.Exists(path);
                if (isfolder)
                {
                    string argument = @"/select, " + path;
                    System.Diagnostics.Process.Start("explorer.exe", argument);
                }
            }
        }
    }
}
