using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operadores__logicos
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string curso;

                if (string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    MessageBox.Show("Por favor, insira o nome do curso.");
                    return;
                }
                else
                {
                    curso = textBox1.Text.ToUpper();
                }
                    if (curso == "DS" || curso == "ADM")
                    {
                        textBox3.AppendText("Curso escolhido! "+Environment.NewLine + curso + " Curso válido"+ Environment.NewLine);
                }
                else
                {
                    textBox3.AppendText("Curso escolhido! "+    Environment.NewLine + curso + " Curso inválido"+Environment.NewLine);
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Tente Novamente");
            }
        }
    }
}
