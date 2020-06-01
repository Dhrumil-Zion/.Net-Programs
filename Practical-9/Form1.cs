using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practical_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonIncrease_Click(object sender, EventArgs e)
        {
            labelText.Font = new Font(labelText.Font.Name, labelText.Font.Size + 3);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonDecrease_Click(object sender, EventArgs e)
        {
            if (labelText.Font.Size - 3 <= 0)
            {
                MessageBox.Show("Anathi nanu nai thay", "Bas hve");
            }
            else
                labelText.Font = new Font(labelText.Font.Name, labelText.Font.Size - 3);

        }
    }
}
