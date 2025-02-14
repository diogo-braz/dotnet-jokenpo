namespace Jokenpo.Shapes;

sealed class Rock : Shape
{
    public static readonly Rock Instance = new ();
    private Rock() { }
    public override string Name => nameof(Rock);
    protected override IReadOnlySet<Shape> Beats => new HashSet<Shape> { Scissors.Instance, Lizard.Instance };
}
