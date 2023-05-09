namespace declVariaveis
{
    public partial class frmSoma : Form
    {
        public frmSoma()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, soma;

            /*Entrada de dados */
            a = Int32.Parse(txtA.Text);
            b = Int32.Parse(txtB.Text);

            /*Processamento*/
            soma = a + b;

            /*Saída de dados*/
            txtResultado.Text = soma.ToString();

        }

        private void btnReais_Click(object sender, EventArgs e)
        {
            double a, b, soma;

            /*Entrada de dados */
            a = Convert.ToDouble(txtA.Text);
            b = Convert.ToDouble(txtB.Text);

            /*Processamento*/
            soma = a + b;

            /*Saída de dados*/
            txtResultado.Text = soma.ToString();
        }
    }
}