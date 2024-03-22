using System;
using System.Drawing;
using System.Windows.Forms;
namespace RunningStaticApp
{
    public partial class Form1 : Form
    {
        private Label label;
        public Form1()
        {
            InitializeComponent();
            label = new Label();
            label.Text = "—“¿“» ";
            label.AutoSize = true;
            label.Location = new Point(100, 100);
            label.MouseEnter += Label_MouseEnter;

            Controls.Add(label);
        }
        private void Label_MouseEnter(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int newX = rnd.Next(0, ClientSize.Width - label.Width);
            int newY = rnd.Next(0, ClientSize.Height - label.Height);

            label.Location = new Point(newX, newY);
        }
    }
}
