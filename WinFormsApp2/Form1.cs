namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += delegate (object? sender, EventArgs e)
            {
                MessageBox.Show("Hello!");
            };

            this.MouseMove += Form1_MouseMove;
            this.MouseClick += Form1_MouseClick;


        }
        private string CoordToString(MouseEventArgs e)
        {
            return $"Координаты мыши: {e.X.ToString()}: {e.Y.ToString()}";
        }
        private void Form1_MouseClick(object? sender, MouseEventArgs e)
        {
            string message = String.Empty;
            if (e.Button == MouseButtons.Left)
            {
                message = "Вы нажали левую клавишу";
            }
            else if (e.Button == MouseButtons.Right)
            {
                message = "Вы нажали правую клавишу";
            }
            message += $"\n{CoordToString(e)}";
            MessageBox.Show(message, "Клик мыши", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_MouseMove(object? sender, MouseEventArgs e)
        {
            Text = CoordToString(e);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
        }
    }
}