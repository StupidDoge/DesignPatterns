using NUnit.Framework;

public class MovingCubeTest
{
    [Test]
    public void CubeStopsAtMaxHeight()
    {
        IMovingCube cube = new MockCube() { MaxHeight = 3, MinHeight = -3};
        MovingCubeController cubeController = new MovingCubeController(cube);
        cubeController.Move(10f, -10f);
        Assert.AreEqual(3f, cube.Position.y);
    }

    [Test]
    public void CubeStopsAtMinHeight()
    {
        IMovingCube cube = new MockCube() { MaxHeight = 3, MinHeight = -3 };
        MovingCubeController cubeController = new MovingCubeController(cube);
        cubeController.Move(-10f, -10f);
        Assert.AreEqual(-3f, cube.Position.y);
    }

    [Test]
    public void CubeStopsAtMaxWidth()
    {
        IMovingCube cube = new MockCube() { MaxWidth = 3, MinWidth = -3 };
        MovingCubeController cubeController = new MovingCubeController(cube);
        cubeController.Move(10f, 10f);
        Assert.AreEqual(3f, cube.Position.x);
    }

    [Test]
    public void CubeStopsAtMinWidth()
    {
        IMovingCube cube = new MockCube() { MaxWidth = 3, MinWidth = -3 };
        MovingCubeController cubeController = new MovingCubeController(cube);
        cubeController.Move(-10f, -10f);
        Assert.AreEqual(-3f, cube.Position.x);
    }
}
