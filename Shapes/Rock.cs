namespace Jokenpo.Shapes;

sealed class Rock : Shape
{
    private static readonly IReadOnlySet<Shape> _beats = new HashSet<Shape> { Scissors.Instance, Lizard.Instance };
    public static readonly Rock Instance = new ();
    private Rock() { }
    public override string Name => nameof(Rock);
    protected override IReadOnlySet<Shape> Beats => _beats;
}
