namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void moveButton(Button btn)
        {
            //zmieniamy tekst przycisku
            btn.Text = "Klikniêto mnie!";
            //szerokoœc i wysokoœæ formularza
            int formWidth = this.Width;
            int formHeight = this.Height;
            //maksymalne wartoœci dla lewego górnego rogu przycisku
            int maxLeft = formWidth - btn.Width;
            int maxTop = formHeight - btn.Height;

            //zainicjuj generator liczb losowych
            Random rnd = new Random();
            //spróbujmy stworzyc punkt
            Point p = new Point(rnd.Next(maxLeft), rnd.Next(maxTop));
            //przypiszmy punkt do przycisku
            btn.Location = p;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //tworzymy zmienn¹ typu Button i
            //przypisujemy do niej obiekt,
            //który wywo³a³ zdarzenie
            Button btn = (Button)sender;
            moveButton(btn);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Button btn = button1;
            moveButton(btn);
        }
    }
}
