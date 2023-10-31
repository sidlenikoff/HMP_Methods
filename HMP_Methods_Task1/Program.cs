using System.Reflection.Metadata;

namespace HMP_Methods_Task1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            string command = "";
            string result = "";
            while (result != "Bye")
            {
                command = Console.ReadLine();
                result = HandleInput(command, stack);
                Console.WriteLine(result);
            }
        }

        public static string HandleInput(string command, Stack stack)
        {
            var inp = command.Split(' ').ToArray();
            switch (inp[0])
            {
                case "push":
                    try
                    {
                        int value = Convert.ToInt32(inp[1]);
                        stack.Push(value);
                        return "ok";
                    }
                    catch (Exception ex) { return ex.Message; }
                case "pop":
                    try
                    {
                        return $"{stack.Pop()}";
                    }
                    catch (Exception ex) { return $"{ex.Message}"; }
                case "back":
                    return $"{stack.Back()}";
                case "size":
                    return $"{stack.Size()}";
                case "clear":
                    stack.Clear();
                    return $"ok";
                case "exit":
                    return "Bye";
                default:
                    return "No such command";
            }
        }
    }
}