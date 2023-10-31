namespace HMP_Methods_Task3
{
    public class Program
    {
        public enum ParenthesesCheckResults { Correct, MoreOpening, MoreClosing };

        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var result = IsCorrectParentheses(input);

            Console.WriteLine(ParenthesesCheckResultsToString(result.result, result.info));
        }
        public static (ParenthesesCheckResults result, int info) IsCorrectParentheses(string text)
        {
            int countBrackets = 0;
            int indexOfFirstExtraClosing = -1;
            for(int i = 0; i < text.Length; i++)
            {
                if (text[i] == '(')
                    countBrackets++;
                else if (text[i] == ')')
                    countBrackets--;
                if (countBrackets < 0)
                {
                    indexOfFirstExtraClosing = i;
                    break;
                }
            }
            if (countBrackets > 0)
                return (ParenthesesCheckResults.MoreOpening, countBrackets);
            else if(countBrackets < 0)
                return (ParenthesesCheckResults.MoreClosing, indexOfFirstExtraClosing);
            else
                return (ParenthesesCheckResults.Correct,0);
        }


        static string ParenthesesCheckResultsToString(ParenthesesCheckResults result, int info)
        {
            if (result == ParenthesesCheckResults.MoreClosing)
                return $"Некорректная расстановка скобок. Больше закрывающих.\nИндекс первой лишней закрывающей: {info}";
            else if (result == ParenthesesCheckResults.MoreOpening)
                return "$ расстановка скобок. Больше открывающих.\nКоличество лишних открывающих: {info}";
            else if (result == ParenthesesCheckResults.Correct)
                return "Корректная расстановка скобок.";

            return "";
        }
    }
}