using UnityEngine;
using UnityEngine.UI;


[AddComponentMenu("RPG/Player/Movement")]
[RequireComponent(typeof(CharacterController))]
public class Movement : MonoBehaviour 
{
    [Header("Speed Vars")]
    public float moveSpeed;
    public float walkSpeed, runSpeed, crouchSpeed, jumpSpeed;
    private float _gravity = 20.0f;
    private Vector3 _moveDir;
    public CharacterController _charC;

    public KeyCode upKeyCode;
    public KeyCode downKeyCode;
    public KeyCode leftKeyCode;
    public KeyCode rightKeyCode;

    private object Transform;

    private void Start()
    {
        _charC = GetComponent<CharacterController>();

        upKeyCode = (KeyCode)PlayerPrefs.GetInt(KeyAction.up.ToString());
        downKeyCode = (KeyCode)PlayerPrefs.GetInt(KeyAction.down.ToString());
        leftKeyCode = (KeyCode)PlayerPrefs.GetInt(KeyAction.left.ToString());
        rightKeyCode = (KeyCode)PlayerPrefs.GetInt(KeyAction.right.ToString());


    }
    private void Update()
    {
        Move();

    }
    private void Move()
    {
        if (_charC.isGrounded)
        {
            if (Input.GetButton("Sprint"))
            {
                moveSpeed = runSpeed;
            }
            else if (Input.GetButton("Crouch"))
            {
                moveSpeed = crouchSpeed;
            }
            else
            {
                moveSpeed = walkSpeed;
            }

            float horizontalSpeed = 0;
            float verticalSpeed = 0;

            if(Input.GetKey(upKeyCode))
            {
                horizontalSpeed = 1;
            }

            if (Input.GetKey(downKeyCode))
            {
                horizontalSpeed = -1;
            }

            if (Input.GetKey(rightKeyCode))
            {
                verticalSpeed = 1;
            }

            if (Input.GetKey(leftKeyCode))
            {
                verticalSpeed = -1;
            }


            _moveDir = transform.TransformDirection(new Vector3(verticalSpeed, 0, horizontalSpeed ) * moveSpeed);
            if (Input.GetButton("Jump"))
            {
                _moveDir.y = jumpSpeed;
            }
        }
        _moveDir.y -= _gravity * Time.deltaTime;
        _charC.Move(_moveDir * Time.deltaTime);
    }


    
      
    
}

