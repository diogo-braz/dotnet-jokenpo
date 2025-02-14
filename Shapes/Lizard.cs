namespace Jokenpo.Shapes;

sealed class Lizard : Shape
{
    private static readonly IReadOnlySet<Shape> _beats = new HashSet<Shape>() { Spock.Instance, Paper.Instance };
    public static readonly Lizard Instance = new ();
    private Lizard() { }
    public override string Name => nameof(Lizard);
    protected override IReadOnlySet<Shape> Beats => _beats;
}
