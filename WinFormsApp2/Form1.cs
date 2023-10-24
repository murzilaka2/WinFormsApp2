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
            return $"���������� ����: {e.X.ToString()}: {e.Y.ToString()}";
        }
        private void Form1_MouseClick(object? sender, MouseEventArgs e)
        {
            string message = String.Empty;
            if (e.Button == MouseButtons.Left)
            {
                message = "�� ������ ����� �������";
            }
            else if (e.Button == MouseButtons.Right)
            {
                message = "�� ������ ������ �������";
            }
            message += $"\n{CoordToString(e)}";
            MessageBox.Show(message, "���� ����", MessageBoxButtons.OK, MessageBoxIcon.Information);
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