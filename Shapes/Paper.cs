namespace Jokenpo.Shapes;

sealed class Paper : Shape
{
    private static readonly IReadOnlySet<Shape> _beats = new HashSet<Shape> { Rock.Instance, Spock.Instance };
    public static readonly Paper Instance = new ();
    private Paper() { }
    public override string Name => nameof(Paper);
    protected override IReadOnlySet<Shape> Beats => _beats;
}
