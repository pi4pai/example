using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XO
{
    public partial class XO_AI_4x4 : Form
    {

        Boolean checker;
        int plusone;
        Random random = new Random();
        private List<Button> buttons;

        void Enable_False()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
            button16.Enabled = false;
            button17.Enabled = false;
        }
        bool score()
        {
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X" && button4.Text == "X" ||
                button5.Text == "X" && button6.Text == "X" && button7.Text == "X" && button8.Text == "X" ||
                button9.Text == "X" && button11.Text == "X" && button12.Text == "X" && button13.Text == "X" ||
                button14.Text == "X" && button15.Text == "X" && button16.Text == "X" && button17.Text == "X" ||
                button1.Text == "X" && button6.Text == "X" && button12.Text == "X" && button17.Text == "X" ||
                button4.Text == "X" && button7.Text == "X" && button11.Text == "X" && button14.Text == "X" ||
                button1.Text == "X" && button5.Text == "X" && button9.Text == "X" && button14.Text == "X" ||
                button2.Text == "X" && button6.Text == "X" && button11.Text == "X" && button13.Text == "X" ||
                button3.Text == "X" && button7.Text == "X" && button12.Text == "X" && button16.Text == "X" ||
                button4.Text == "X" && button8.Text == "X" && button13.Text == "X" && button17.Text == "X")
            {
                MessageBox.Show("Переможець Гравець X", "Гра Хрестики - Нулики", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayerX.Text);
                lblPlayerX.Text = Convert.ToString(plusone + 1);

                Enable_False();

                return true;
            }
            else if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O" && button4.Text == "O" ||
                button5.Text == "O" && button6.Text == "O" && button7.Text == "O" && button8.Text == "O" ||
                button9.Text == "O" && button11.Text == "O" && button12.Text == "O" && button13.Text == "O" ||
                button14.Text == "O" && button15.Text == "O" && button16.Text == "O" && button17.Text == "O" ||
                button1.Text == "O" && button6.Text == "O" && button12.Text == "O" && button17.Text == "O" ||
                button4.Text == "O" && button7.Text == "O" && button11.Text == "O" && button14.Text == "O" ||
                button1.Text == "O" && button5.Text == "O" && button9.Text == "O" && button14.Text == "O" ||
                button2.Text == "O" && button6.Text == "O" && button11.Text == "O" && button13.Text == "O" ||
                button3.Text == "O" && button7.Text == "O" && button12.Text == "O" && button16.Text == "O" ||
                button4.Text == "O" && button8.Text == "O" && button13.Text == "O" && button17.Text == "O")
            {
                MessageBox.Show("Переможець Гравець O", "Гра Хрестики - Нулики", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayerO.Text);
                lblPlayerO.Text = Convert.ToString(plusone + 1);

                Enable_False();

                return true;
            }
            else
            {
                if (!buttons.Any(btn => btn.Enabled))
                {
                    MessageBox.Show("Гра закінчилася нічиєю!", "Гра Хрестики - Нулики", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Enable_False();
                }

                return false;
            }
        }
        public XO_AI_4x4()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            buttons = new List<Button> { button1, button2, button3, button4, button5, button6, button7, button8, button9, button11, button12, button13, button14, button15, button16, button17 };
        }

        private void Computer()
        {

            List<Button> availableButtons = buttons.Where(btn => btn.Enabled).ToList();

            if (availableButtons.Count > 0)
            {
                int randomIndex = random.Next(0, availableButtons.Count);
                Button computerButton = availableButtons[randomIndex];
                computerButton.Text = "O";
                computerButton.Enabled = false;
                score();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Enabled)
            {
                button1.Text = "X";
                button1.Enabled = false;
                score();
                Computer();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Enabled)
            {
                button2.Text = "X";
                button2.Enabled = false;
                score();
                Computer();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Enabled)
            {
                button3.Text = "X";
                button3.Enabled = false;
                score();
                Computer();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Enabled)
            {
                button4.Text = "X";
                button4.Enabled = false;
                score();
                Computer();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Enabled)
            {
                button5.Text = "X";
                button5.Enabled = false;
                score();
                Computer();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.Enabled)
            {
                button6.Text = "X";
                button6.Enabled = false;
                score();
                Computer();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.Enabled)
            {
                button7.Text = "X";
                button7.Enabled = false;
                score();
                Computer();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.Enabled)
            {
                button8.Text = "X";
                button8.Enabled = false;
                score();
                Computer();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.Enabled)
            {
                button9.Text = "X";
                button9.Enabled = false;
                score();
                Computer();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (button11.Enabled)
            {
                button11.Text = "X";
                button11.Enabled = false;
                score();
                Computer();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (button12.Enabled)
            {
                button12.Text = "X";
                button12.Enabled = false;
                score();
                Computer();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (button13.Enabled)
            {
                button13.Text = "X";
                button13.Enabled = false;
                score();
                Computer();
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (button14.Enabled)
            {
                button14.Text = "X";
                button14.Enabled = false;
                score();
                Computer();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (button15.Enabled)
            {
                button15.Text = "X";
                button15.Enabled = false;
                score();
                Computer();
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (button16.Enabled)
            {
                button16.Text = "X";
                button16.Enabled = false;
                score();
                Computer();
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (button17.Enabled)
            {
                button17.Text = "X";
                button17.Enabled = false;
                score();
                Computer();
            }
        }
        private void size_3x3_Click(object sender, EventArgs e)
        {
            XO_AI_3x3 form2 = new XO_AI_3x3();
            form2.Show();
            this.Hide();
        }
        private void ChangeInterfaceColor(Color color)
        {
            BackColor = color;
        }
        private void background_color_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Color selectedColor = colorDialog.Color;
                ChangeInterfaceColor(selectedColor);
            }
        }

        private void Text_style_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Color selectedColor = colorDialog.Color;
                title_name.ForeColor = selectedColor;
                label2.ForeColor = selectedColor;
                pl1.ForeColor = selectedColor;
                pl2.ForeColor = selectedColor;
                label5.ForeColor = selectedColor;
                label6.ForeColor = selectedColor;
                label9.ForeColor = selectedColor;
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви точно хочите вийти з гри ?", "Увага!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
            button16.Enabled = true;
            button17.Enabled = true;


            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            button11.Text = "";
            button12.Text = "";
            button13.Text = "";
            button14.Text = "";
            button15.Text = "";
            button16.Text = "";
            button17.Text = "";

            reset.Enabled = true;

            button1.BackColor = Color.WhiteSmoke;
            button2.BackColor = Color.WhiteSmoke;
            button3.BackColor = Color.WhiteSmoke;
            button4.BackColor = Color.WhiteSmoke;
            button5.BackColor = Color.WhiteSmoke;
            button6.BackColor = Color.WhiteSmoke;
            button7.BackColor = Color.WhiteSmoke;
            button8.BackColor = Color.WhiteSmoke;
            button9.BackColor = Color.WhiteSmoke;
            button11.BackColor = Color.WhiteSmoke;
            button12.BackColor = Color.WhiteSmoke;
            button13.BackColor = Color.WhiteSmoke;
            button14.BackColor = Color.WhiteSmoke;
            button15.BackColor = Color.WhiteSmoke;
            button16.BackColor = Color.WhiteSmoke;
            button17.BackColor = Color.WhiteSmoke;
        }

        private void newgame_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
            button16.Enabled = true;
            button17.Enabled = true;


            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            button11.Text = "";
            button12.Text = "";
            button13.Text = "";
            button14.Text = "";
            button15.Text = "";
            button16.Text = "";
            button17.Text = "";

            lblPlayerX.Text = "0";
            lblPlayerO.Text = "0";

            button1.BackColor = Color.WhiteSmoke;
            button2.BackColor = Color.WhiteSmoke;
            button3.BackColor = Color.WhiteSmoke;
            button4.BackColor = Color.WhiteSmoke;
            button5.BackColor = Color.WhiteSmoke;
            button6.BackColor = Color.WhiteSmoke;
            button7.BackColor = Color.WhiteSmoke;
            button8.BackColor = Color.WhiteSmoke;
            button9.BackColor = Color.WhiteSmoke;
            button11.BackColor = Color.WhiteSmoke;
            button12.BackColor = Color.WhiteSmoke;
            button13.BackColor = Color.WhiteSmoke;
            button14.BackColor = Color.WhiteSmoke;
            button15.BackColor = Color.WhiteSmoke;
            button16.BackColor = Color.WhiteSmoke;
            button17.BackColor = Color.WhiteSmoke;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            XO_People_4x4 form3 = new XO_People_4x4();
            form3.Show();
            this.Hide();
        }
    }
}
