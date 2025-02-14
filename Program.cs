using Jokenpo.Enums;
using Jokenpo.Shapes;

class Program
{
    private static readonly IReadOnlyDictionary<string, Shape> Choices = new Dictionary<string, Shape>(StringComparer.OrdinalIgnoreCase)
    {
        { nameof(Rock), Rock.Instance },
        { nameof(Paper), Paper.Instance },
        { nameof(Scissors), Scissors.Instance },
        { nameof(Spock), Spock.Instance },
        { nameof(Lizard), Lizard.Instance }
    };
    
    private static Shape Input()
    {
        while (true)
        {
            Console.WriteLine($"Choose: {string.Join(", ", Choices.Keys)}");
            var input = Console.ReadLine()?.Trim();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Input cannot be empty, please try again.");
                continue;
            }

            if (Choices.TryGetValue(input, out Shape? shape))
            {
                return shape;
            }

            Console.WriteLine("Invalid choice, please try again.");
        }
    }
    
    private static string FormatResult(Condition result)
    {
        return result switch
        {
            Condition.Victory => "Player 1 Wins!",
            Condition.Defeat => "Player 2 Wins!",
            _ => "Draw!"
        };
    }
    
    static void Main()
    {
        var playerOneShape = Input();
        var playerTwoShape = Input();

        Condition result = playerOneShape.Verify(playerTwoShape);
        Console.WriteLine($"Result: {FormatResult(result)}");
    }
}