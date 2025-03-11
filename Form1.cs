namespace lab2_task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                double input_A;
                double input_B;
                double input_C;

                string output;

                try
                {
                    input_A = double.Parse(this.textA.Text);
                    input_B = double.Parse(this.textB.Text);
                    input_C = double.Parse(this.textC.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("¬ пол€ дл€ ввода могут быть поданы только числа!", "ќшибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!isInputValid(this.textA.Text) || !isInputValid(this.textB.Text) || !isInputValid(this.textC.Text))
                {
                    MessageBox.Show("¬се введЄнный числа должны быть больше 0!", "ќшибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                output = Logic.FindMonths(input_A, input_B, input_C);

                MessageBox.Show(output, "–езультат просчЄта");
        }
        public static bool isInputValid(string input)
        {
            if (double.TryParse(input, out double amount))
            {
                if (amount <= 0)
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

            return true;
        }
    }
    public class Logic
    {
        public static string FindMonths(double money_A, double money_B, double money_C)
        {
            string output;

            int month_B = 0;
            int month_C = 0;
            double currentBalance_B = money_A;
            double currentBalance_C = money_A;

            bool bFound = false;
            bool cFound = false;

            while (!bFound)
            {
                month_B++;

                double monthlyIncrease = currentBalance_B * 0.02;

                if (monthlyIncrease > money_B)
                {
                    bFound = true;
                }

                currentBalance_B += monthlyIncrease;
            }

            if (money_C > money_A)
            {
                while (!cFound)
                {
                    month_C++;

                    double monthlyIncrease = currentBalance_C * 0.02;
                    currentBalance_C += monthlyIncrease;

                    if (currentBalance_C > money_C)
                    {
                        cFound = true;
                    }
                }
            }

            string output_months_B = "мес€ц";

            string output_months_C = "мес€цев";
            if (month_C % 10 == 1)
            {
                output_months_C = "мес€ц";
            }
            if (month_C % 10 >= 2 && month_C % 10 <= 4)
            {
                output_months_C = "мес€ца";
            }
            if (month_C % 100 >= 11 && month_C % 100 <= 20)
            {
                output_months_C = "мес€цев";
            }

            output = $"”величение превысит {money_B} руб. за {month_B}-й {output_months_B}.\n" + $"¬клад превысит {money_C} руб. через {month_C} {output_months_C}.";

            return output;
        }
    }
}
