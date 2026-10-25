namespace Projeto1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            textBox1.Text = MousePosition.X.ToString();
            textBox2.Text = MousePosition.Y.ToString();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("X=" + MousePosition.X + "| y= " + MousePosition.Y);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string message = "Pretende continuar?";
            string caption = "Decisão";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);
            int resposta;

            Application.EnableVisualStyles();



            // resposta = Convert.ToInt32(MessageBox.Show(message,caption,buttons, MessageBoxIcon.Information));

            if (result == DialogResult.Yes)
                MessageBox.Show("Carregou em Sim", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);



            else
                if (result == DialogResult.No)
                    this.Close();
            //MessageBox.Show("Carregou em Não", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);

            /*else
                if (resposta == 2)
                    MessageBox.Show("Carregou em Cancelar", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);*/

        }







    }
}
