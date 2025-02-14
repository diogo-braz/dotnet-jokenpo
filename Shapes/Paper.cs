namespace Jokenpo.Shapes;

sealed class Paper : Shape
{
    public static readonly Paper Instance = new ();
    private Paper() { }
    public override string Name => nameof(Paper);
    protected override IReadOnlySet<Shape> Beats => new HashSet<Shape> { Rock.Instance, Spock.Instance };
}
