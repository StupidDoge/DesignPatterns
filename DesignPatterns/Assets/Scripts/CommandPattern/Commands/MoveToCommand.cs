using UnityEngine;

public class MoveToCommand : Command
{
    private Vector3 _originalPosition;
    private Vector3 _destination;

    public MoveToCommand(IEntity entity, Vector3 destination) : base(entity)
    {
        _destination = destination;
    }

    public override void Execute()
    {
        _originalPosition = _entity.transform.position;
        _entity.MoveFromTo(_originalPosition, _destination);
    }

    public override void Undo()
    {
        _entity.MoveFromTo(_entity.transform.position, _originalPosition);
    }
}
