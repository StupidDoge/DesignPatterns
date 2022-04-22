using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MockCube : IMovingCube
{
    public Vector3 Position { get; set; }
    public float MaxHeight { get; set; }
    public float MinHeight { get; set; }
    public float MaxWidth { get; set; }
    public float MinWidth { get; set; }
}
