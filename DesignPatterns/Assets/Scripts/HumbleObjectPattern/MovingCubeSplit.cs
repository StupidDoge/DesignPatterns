using UnityEngine;

public class MovingCubeSplit : MonoBehaviour, IMovingCube
{
    private MovingCubeController _movingCubeController;

    [SerializeField] private float _maxHeight = 3;
    [SerializeField] private float _minHeight = -3;
    [SerializeField] private float _maxWidth = 5;
    [SerializeField] private float _minWidth = -5;

    public float MaxHeight => _maxHeight;
    public float MinHeight => _minHeight;
    public float MaxWidth => _maxWidth;
    public float MinWidth => _minWidth;

    public Vector3 Position { get { return transform.position; } set { transform.position = value; } }

    private void Awake()
    {
        _movingCubeController = new MovingCubeController(this);
    }
    
    private void Update()
    {
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");
        _movingCubeController.Move(vertical, horizontal);
    }
}
