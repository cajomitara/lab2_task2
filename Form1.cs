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
                string input_A;
                string input_B;
                string input_C;

                string output;

                do
                {
                    Console.Write("¬ведите сумму денег на счЄте A: ");
                    input_A = Console.ReadLine();

                    Console.Write("¬ведите необходимую величину ежемес€чного увеличени€ B: ");
                    input_B = Console.ReadLine();

                    Console.Write("¬ведите сумму C, которую нужно превысить вкладу: ");
                    input_C = Console.ReadLine();
                    Console.WriteLine();
                } while (!isInputValid(input_A) || !isInputValid(input_B) || !isInputValid(input_C));

                output = Logic.FindMonths(input_A, input_B, input_C);

                Console.WriteLine(output);
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
        public static string FindMonths(string input_A, string input_B, string input_C)
        {
            string output;

            double money_A = double.Parse(input_A);
            double money_B = double.Parse(input_B);
            double money_C = double.Parse(input_C);

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
