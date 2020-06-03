using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Button _moveRandomToPointButton;
    [SerializeField] private Button _moveForwardButton;
    [SerializeField] private Button _mouseForwardButton;

    private IMovable _movableType;          

    private void Awake()
    {
        _movableType = GetComponent<MoverToRandomPoint>();

        _moveRandomToPointButton.onClick.AddListener(OnMoveRandomToPointButtonClick);
        _moveForwardButton.onClick.AddListener(OnMoveForwardButtonClick);
        _mouseForwardButton.onClick.AddListener(OnMoveMouseForwardButtonClick);
    }

    private void Update()
    {
        Move();
    }   

    private void Move()
    {
        _movableType.Move(_speed);
    }

    private void OnMoveRandomToPointButtonClick()
    {
        _movableType = GetComponent<MoverToRandomPoint>();
    }

    private void OnMoveForwardButtonClick()
    {
        _movableType = GetComponent<MoverForward>();
    }

    private void OnMoveMouseForwardButtonClick()
    {
        _movableType = GetComponent<MoverToMouse>();
    }
}
