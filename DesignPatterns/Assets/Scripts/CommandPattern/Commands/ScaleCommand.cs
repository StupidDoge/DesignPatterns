public class ScaleCommand : Command
{
    private readonly float _scaleFactor;

    private float _scaleUpValue = 1.1f;
    private float _scaleDownValue = 0.9f;

    public ScaleCommand(Entity entity, float scaleDirection) : base(entity)
    {
        _scaleFactor = scaleDirection == 1f ? _scaleUpValue : _scaleDownValue;
    }

    public override void Execute()
    {
        _entity.transform.localScale *= _scaleFactor;
    }

    public override void Undo()
    {
        _entity.transform.localScale /= _scaleFactor;
    }
}