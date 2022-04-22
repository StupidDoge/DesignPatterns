using UnityEngine;

public interface IMovingCube
{
    Vector3 Position { get; set; }
    float MaxHeight { get; }
    float MinHeight { get; }
    float MaxWidth { get; }
    float MinWidth { get; }
}
