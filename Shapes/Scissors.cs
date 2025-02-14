namespace Jokenpo.Shapes;

sealed class Scissors : Shape
{
    public static readonly Scissors Instance = new ();
    
    private static readonly IReadOnlySet<Shape> _beats = new HashSet<Shape> { Paper.Instance, Lizard.Instance };
    
    private Scissors() { }
    
    public override string Name => nameof(Scissors);
    protected override IReadOnlySet<Shape> Beats => _beats;
}
