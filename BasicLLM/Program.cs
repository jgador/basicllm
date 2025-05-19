namespace BasicLLM;

public class Program
{
    static void Main(string[] args)
    {
        // Word-to-next-word probabilities
        Dictionary<string, Dictionary<string, float>> probabilities = new()
        {
            { "hello", new() { { "world", 0.9f }, { "you", 0.1f } } },
            { "how", new()   { { "are", 0.8f }, { "you", 0.2f } } },
            { "are", new()   { { "you", 1.0f } } },
            { "thank", new() { { "you", 1.0f } } },
            { "good", new()  { { "morning", 1.0f } } }
        };

        while (true)
        {
            Console.Write("Enter a phrase (or type 'exit' to quit): ");
            var input = Console.ReadLine();

            if (string.Equals(input, "exit", StringComparison.OrdinalIgnoreCase))
                break;

            var prediction = PredictNext(input ?? "", probabilities);
            Console.WriteLine($"Next word might be: {prediction}");
        }
    }

    private static string PredictNext(string input, Dictionary<string, Dictionary<string, float>> probabilities)
    {
        var lastWord = input.ToLower().Split(' ').Last();

        if (!probabilities.TryGetValue(lastWord, out var options))
            return "[unknown]";

        return options.OrderByDescending(kvp => kvp.Value).First().Key;
    }
}
