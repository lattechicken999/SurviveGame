using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{
    private Vector2 _moving;
    private Vector2 _cameraMove;
    [SerializeField] float _speed;
    [SerializeField] float _cameraSense;
    public void OnMove(InputAction.CallbackContext ctx)
    {
        _moving = ctx.ReadValue<Vector2>();
    }

    private void Update()
    {
        if (_moving != Vector2.zero)
        {
            //transform.Translate(new Vector3(_moving.x, 0, _moving.y).normalized * Time.deltaTime * _speed);
            transform.Rotate(new Vector3(0, _moving.x, 0), Time.deltaTime * _cameraSense);
            transform.Translate(new Vector3(0,0,_moving.y)*Time.deltaTime*_speed);
        }
    }
}
