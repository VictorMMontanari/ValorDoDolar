namespace ValorDoDolar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double dolar1 = Convert.ToDouble(textBox1.Text);
            double dolar2 = Convert.ToDouble(textBox2.Text);
            double diferenca = (dolar2 - dolar1) / dolar1 * 100;
            double resultado = (diferenca / 1000 * 100) * 100;

            string verdadeiro = "Dolar compensa Comprar", falso = "Dolar Não compensa";
            string verificar = dolar1 > dolar2 ? verdadeiro : falso;

            label2.Text = resultado.ToString() + "%";

            label1.Text = verificar;
        }
    }
}