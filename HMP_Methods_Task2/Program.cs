namespace HMP_Methods_Task2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            string command = "";
            string result = "";
            while (result != "Bye")
            {
                command = Console.ReadLine();
                result = HandleInput(command, queue);
                Console.WriteLine(result);
            }
        }

        public static string HandleInput(string command, Queue queue)
        {
            var inp = command.Split(' ').ToArray();
            switch (inp[0])
            {
                case "push":
                    try
                    {
                        int value = Convert.ToInt32(inp[1]);
                        queue.Push(value);
                        return "ok";
                    }
                    catch (Exception ex) { return ex.Message; }
                case "pop":
                    try
                    {
                        return $"{queue.Pop()}";
                    }
                    catch (Exception ex) { return $"{ex.Message}"; }
                case "front":
                    return $"{queue.Front()}";
                case "size":
                    return $"{queue.Size()}";
                case "clear":
                    queue.Clear();
                    return $"ok";
                case "exit":
                    return "Bye";
                default:
                    return "No such command";
            }
        }
    }
}