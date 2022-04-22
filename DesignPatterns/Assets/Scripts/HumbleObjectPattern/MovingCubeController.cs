using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingCubeController
{
    private IMovingCube _cube;

    public MovingCubeController(IMovingCube cube)
    {
        _cube = cube;
    }

    public void Move(float vertical, float horizontal)
    {
        _cube.Position += Vector3.up * vertical;
        _cube.Position += Vector3.right * horizontal;

        if (_cube.Position.y > _cube.MaxHeight)
            _cube.Position = new Vector3(_cube.Position.x, _cube.MaxHeight, _cube.Position.z);
        if (_cube.Position.y < _cube.MinHeight)
            _cube.Position = new Vector3(_cube.Position.x, _cube.MinHeight, _cube.Position.z);

        if (_cube.Position.x > _cube.MaxWidth)
            _cube.Position = new Vector3(_cube.MaxWidth, _cube.Position.y, _cube.Position.z);
        if (_cube.Position.x < _cube.MinWidth)
            _cube.Position = new Vector3(_cube.MinWidth, _cube.Position.y, _cube.Position.z);
    }
}
