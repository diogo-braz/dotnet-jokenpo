using Jokenpo.Enums;

namespace Jokenpo.Shapes;

abstract class Shape
{
    public abstract string Name { get; }
    protected abstract IReadOnlySet<Shape> Beats { get; }

    public Condition Verify(Shape enemyShape)
    {
        ArgumentNullException.ThrowIfNull(enemyShape);
        
        if (this == enemyShape) return Condition.Draw;
        return Beats.Contains(enemyShape) ? Condition.Victory : Condition.Defeat;
    }

    public override string ToString() => Name;
}
