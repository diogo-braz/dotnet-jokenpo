namespace Jokenpo.Shapes;

sealed class Lizard : Shape
{
    public static readonly Lizard Instance = new ();
    
    private static readonly IReadOnlySet<Shape> _beats = new HashSet<Shape>() { Spock.Instance, Paper.Instance };
    
    private Lizard() { }
    
    public override string Name => nameof(Lizard);
    protected override IReadOnlySet<Shape> Beats => _beats;
}
