using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCommand : Command
{
    private Vector3 _direction;

    public MoveCommand(IEntity entity, Vector3 direction) : base(entity)
    {
        _direction = direction;
    }

    public override void Execute()
    {
        _entity.transform.position += 0.1f * _direction;
    }

    public override void Undo()
    {
        _entity.transform.position -= 0.1f * _direction;
    }
}
