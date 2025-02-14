namespace Jokenpo.Shapes;

sealed class Scissors : Shape
{
    private static readonly IReadOnlySet<Shape> _beats = new HashSet<Shape> { Paper.Instance, Lizard.Instance };
    public static readonly Scissors Instance = new ();
    private Scissors() { }
    public override string Name => nameof(Scissors);
    protected override IReadOnlySet<Shape> Beats => _beats;
}
