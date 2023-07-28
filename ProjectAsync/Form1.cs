namespace ProjectAsync
{
    public partial class Form1 : Form
    {
        public static ListBox lstRes;

        public Form1()
        {
            InitializeComponent();
            lstRes = listBoxResultado;
        }

        private void buttonExecutar_Click(object sender, EventArgs e)
        {
            listBoxResultado.Items.Add("1 - Evento do bot�o foi iniciado : cliquei aqui");

            Exemplo obj = new Exemplo();
            obj.Task_LongaDuracao();

            listBoxResultado.Items.Add("4 - Evento do bot�o foi conclu�do");
        }

        private void buttonExecutarAssync_Click(object sender, EventArgs e)
        {
            listBoxResultado.Items.Add("1 - Evento do bot�o foi iniciado : cliquei aqui");

            ExemploAsync obj = new ExemploAsync();
            _ = obj.Task_LongaDuracao();

            listBoxResultado.Items.Add("4 - Evento do bot�o foi conclu�do");
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            listBoxResultado.Items.Clear();
        }
    }
}