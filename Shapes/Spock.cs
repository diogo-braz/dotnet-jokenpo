namespace Jokenpo.Shapes;

sealed class Spock : Shape
{
    public static readonly Spock Instance = new ();
    
    private static readonly IReadOnlySet<Shape> _beats = new HashSet<Shape> { Scissors.Instance, Rock.Instance };
    
    private Spock() { }
    
    public override string Name => nameof(Spock);
    protected override IReadOnlySet<Shape> Beats => _beats;
}
