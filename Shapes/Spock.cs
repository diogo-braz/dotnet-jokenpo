namespace Jokenpo.Shapes;

sealed class Spock : Shape
{
    public static readonly Spock Instance = new ();
    private Spock() { }
    public override string Name => nameof(Spock);
    protected override IReadOnlySet<Shape> Beats => new HashSet<Shape> { Scissors.Instance, Rock.Instance };
}
