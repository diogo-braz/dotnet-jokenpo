namespace Jokenpo.Shapes;

sealed class Rock : Shape
{
    public static readonly Rock Instance = new ();
    
    private static readonly IReadOnlySet<Shape> _beats = new HashSet<Shape> { Scissors.Instance, Lizard.Instance };
    
    private Rock() { }
    
    public override string Name => nameof(Rock);
    protected override IReadOnlySet<Shape> Beats => _beats;
}
