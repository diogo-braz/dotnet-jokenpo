namespace Jokenpo.Shapes;

sealed class Scissors : Shape
{
    public static readonly Scissors Instance = new ();
    private Scissors() { }
    public override string Name => nameof(Scissors);
    protected override IReadOnlySet<Shape> Beats => new HashSet<Shape> { Paper.Instance, Lizard.Instance };
}
