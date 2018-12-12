using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("텍스트를 입력하세요.");
            }
            else
            {
                comboBox1.Items.Add(textBox1.Text);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 콤보박스의 선택된 텍스트값을 뿌려줍니다.
            lblText.Text = comboBox1.Text;

            // 콤보박스의 인덱스값을 뿌려줍니다.
            lblIndex.Text = comboBox1.SelectedIndex.ToString();
        }
    }
}
