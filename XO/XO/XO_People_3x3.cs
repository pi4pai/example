namespace XO
{
    public partial class XO_People_3x3 : Form
    {
        Boolean checker;
        int plusone;
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
        }
        void score()
        {
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                button1.BackColor = Color.Silver;
                button2.BackColor = Color.Silver;
                button3.BackColor = Color.Silver;

                MessageBox.Show("Переможець Гравець X", "Гра Хрестики - Нулики", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayerX.Text);
                lblPlayerX.Text = Convert.ToString(plusone + 1);

                Enable_False();

            }
            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                button1.BackColor = Color.Silver;
                button4.BackColor = Color.Silver;
                button7.BackColor = Color.Silver;

                MessageBox.Show("Переможець Гравець X", "Гра Хрестики - Нулики", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayerX.Text);
                lblPlayerX.Text = Convert.ToString(plusone + 1);

                Enable_False();
            }
            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                button1.BackColor = Color.Silver;
                button5.BackColor = Color.Silver;
                button9.BackColor = Color.Silver;

                MessageBox.Show("Переможець Гравець X", "Гра Хрестики - Нулики", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayerX.Text);
                lblPlayerX.Text = Convert.ToString(plusone + 1);

                Enable_False();
            }
            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                button4.BackColor = Color.Silver;
                button5.BackColor = Color.Silver;
                button6.BackColor = Color.Silver;

                MessageBox.Show("Переможець Гравець X", "Гра Хрестики - Нулики", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayerX.Text);
                lblPlayerX.Text = Convert.ToString(plusone + 1);

                Enable_False();
            }
            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                button7.BackColor = Color.Silver;
                button8.BackColor = Color.Silver;
                button9.BackColor = Color.Silver;

                MessageBox.Show("Переможець Гравець X", "Гра Хрестики - Нулики", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayerX.Text);
                lblPlayerX.Text = Convert.ToString(plusone + 1);

                Enable_False();
            }
            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                button2.BackColor = Color.Silver;
                button5.BackColor = Color.Silver;
                button8.BackColor = Color.Silver;

                MessageBox.Show("Переможець Гравець X", "Гра Хрестики - Нулики", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayerX.Text);
                lblPlayerX.Text = Convert.ToString(plusone + 1);

                Enable_False();
            }
            if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                button3.BackColor = Color.Silver;
                button6.BackColor = Color.Silver;
                button9.BackColor = Color.Silver;

                MessageBox.Show("Переможець Гравець X", "Гра Хрестики - Нулики", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayerX.Text);
                lblPlayerX.Text = Convert.ToString(plusone + 1);

                Enable_False();
            }
            if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                button3.BackColor = Color.Silver;
                button5.BackColor = Color.Silver;
                button7.BackColor = Color.Silver;

                MessageBox.Show("Переможець Гравець X", "Гра Хрестики - Нулики", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayerX.Text);
                lblPlayerX.Text = Convert.ToString(plusone + 1);

                Enable_False();
            }
            //==================================================================================================================================================
            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                button1.BackColor = Color.Silver;
                button2.BackColor = Color.Silver;
                button3.BackColor = Color.Silver;

                MessageBox.Show("Переможець Гравець O", "Гра Хрестики - Нулики", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayerO.Text);
                lblPlayerO.Text = Convert.ToString(plusone + 1);

                Enable_False();
            }
            if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                button1.BackColor = Color.Silver;
                button4.BackColor = Color.Silver;
                button7.BackColor = Color.Silver;

                MessageBox.Show("Переможець Гравець O", "Гра Хрестики - Нулики", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayerO.Text);
                lblPlayerO.Text = Convert.ToString(plusone + 1);

                Enable_False();
            }
            if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                button1.BackColor = Color.Silver;
                button5.BackColor = Color.Silver;
                button9.BackColor = Color.Silver;

                MessageBox.Show("Переможець Гравець O", "Гра Хрестики - Нулики", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayerO.Text);
                lblPlayerO.Text = Convert.ToString(plusone + 1);

                Enable_False();
            }
            if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                button4.BackColor = Color.Silver;
                button5.BackColor = Color.Silver;
                button6.BackColor = Color.Silver;

                MessageBox.Show("Переможець Гравець O", "Гра Хрестики - Нулики", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayerO.Text);
                lblPlayerO.Text = Convert.ToString(plusone + 1);

                Enable_False();
            }
            if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                button7.BackColor = Color.Silver;
                button8.BackColor = Color.Silver;
                button9.BackColor = Color.Silver;

                MessageBox.Show("Переможець Гравець O", "Гра Хрестики - Нулики", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayerO.Text);
                lblPlayerO.Text = Convert.ToString(plusone + 1);

                Enable_False();
            }
            if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                button2.BackColor = Color.Silver;
                button5.BackColor = Color.Silver;
                button8.BackColor = Color.Silver;

                MessageBox.Show("Переможець Гравець O", "Гра Хрестики - Нулики", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayerO.Text);
                lblPlayerO.Text = Convert.ToString(plusone + 1);

                Enable_False();
            }
            if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                button3.BackColor = Color.Silver;
                button6.BackColor = Color.Silver;
                button9.BackColor = Color.Silver;

                MessageBox.Show("Переможець Гравець O", "Гра Хрестики - Нулики", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayerO.Text);
                lblPlayerO.Text = Convert.ToString(plusone + 1);

                Enable_False();
            }
            if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                button3.BackColor = Color.Silver;
                button5.BackColor = Color.Silver;
                button7.BackColor = Color.Silver;

                MessageBox.Show("Переможець Гравець O", "Гра Хрестики - Нулики", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayerO.Text);
                lblPlayerO.Text = Convert.ToString(plusone + 1);

                Enable_False();
            }
            if (IsBoardFull())
            {
                MessageBox.Show("Гра закінчилася нічиєю!", "Гра Хрестики - Нулики", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Enable_False();
            }

        }
        private bool IsBoardFull()
        {
            foreach (Button button in buttons)
            {
                if (button.Text == "")
                    return false;
            }
            return true;
        }
        public XO_People_3x3()
        {
            InitializeComponent();
            label7.Text = "Хід Гравця : X";
            buttons = new List<Button> { button1, button2, button3, button4, button5, button6, button7, button8, button9 };
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void XO_People_3x3_Load(object sender, EventArgs e)
        {

        }



        private void size_4x4_Click(object sender, EventArgs e)
        {
            XO_People_4x4 form3 = new XO_People_4x4();
            form3.Show();
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
                label7.ForeColor = selectedColor;
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

            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

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

            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

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
        }

        private void AIgame_3x3_Click(object sender, EventArgs e)
        {
            XO_AI_3x3 form2 = new XO_AI_3x3();
            form2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button1.Text = "X";
                checker = true;
                label7.Text = "Хід Гравця : O";
            }
            else
            {
                button1.Text = "O";
                checker = false;
                label7.Text = "Хід Гравця : X";
            }
            score();
            button1.Enabled = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (checker == false)
            {
                button2.Text = "X";
                checker = true;
                label7.Text = "Хід Гравця : O";
            }
            else
            {
                button2.Text = "O";
                checker = false;
                label7.Text = "Хід Гравця : X";
            }
            score();
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (checker == false)
            {
                button3.Text = "X";
                checker = true;
                label7.Text = "Хід Гравця : O";
            }
            else
            {
                button3.Text = "O";
                checker = false;
                label7.Text = "Хід Гравця : X";
            }
            score();
            button3.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (checker == false)
            {
                button4.Text = "X";
                checker = true;
                label7.Text = "Хід Гравця : O";
            }
            else
            {
                button4.Text = "O";
                checker = false;
                label7.Text = "Хід Гравця : X";
            }
            score();
            button4.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (checker == false)
            {
                button5.Text = "X";
                checker = true;
                label7.Text = "Хід Гравця : O";
            }
            else
            {
                button5.Text = "O";
                checker = false;
                label7.Text = "Хід Гравця : X";
            }
            score();
            button5.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (checker == false)
            {
                button6.Text = "X";
                checker = true;
                label7.Text = "Хід Гравця : O";
            }
            else
            {
                button6.Text = "O";
                checker = false;
                label7.Text = "Хід Гравця : X";
            }
            score();
            button6.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {

            if (checker == false)
            {
                button7.Text = "X";
                checker = true;
                label7.Text = "Хід Гравця : O";
            }
            else
            {
                button7.Text = "O";
                checker = false;
                label7.Text = "Хід Гравця : X";
            }
            score();
            button7.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {

            if (checker == false)
            {
                button8.Text = "X";
                checker = true;
                label7.Text = "Хід Гравця : O";
            }
            else
            {
                button8.Text = "O";
                checker = false;
                label7.Text = "Хід Гравця : X";
            }
            score();
            button8.Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {

            if (checker == false)
            {
                button9.Text = "X";
                checker = true;
                label7.Text = "Хід Гравця : O";
            }
            else
            {
                button9.Text = "O";
                checker = false;
                label7.Text = "Хід Гравця : X";
            }
            score();
            button9.Enabled = false;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}