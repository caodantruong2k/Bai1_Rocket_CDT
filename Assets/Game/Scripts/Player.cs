using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public enum ColorType { Blu, Red, Green };

public class Player : Character
{

    [SerializeField] public Transform posStart;
    PlayerInput playerInput;
    InputAction moveAction;
     bool moving = false;

    // Start is called before the first frame update
    void Start()
    {
        playerInput = GetComponent<PlayerInput>();
        moveAction = playerInput.actions.FindAction("Move");

        RandomColor();
       
    }


    void Update()
    {

        if (GameManager.Ins.game)
        {
            MovePlayer();
        }
     

    }
    public void Init()
    {
        transform.position = posStart.position;
    }
   
    private void  MovePlayer( )
    {
        Vector2 direction;
        if (moveAction != null)
        {
            direction = moveAction.ReadValue<Vector2>();
            transform.position += new Vector3(direction.x, 0f, direction.y) * Time.deltaTime * speed;
            moving = true;
          
        }
        if (transform.position.x > 15f)
        {
            transform.position = new Vector3(-15f, 1.1f, transform.position.z);
            CameraFL.Ins.FlashMove(1);
        }
        if(transform.position.x < -15f)
        {
            transform.position = new Vector3(15f, 1.1f, transform.position.z);
            CameraFL.Ins.FlashMove(2);

        }
        if (transform.position.z > 15f)
        {
            transform.position = new Vector3(transform.position.x, 1.1f, -15f);
            CameraFL.Ins.FlashMove(3);

        }
        if (transform.position.z < -15f)
        {
            transform.position = new Vector3(transform.position.x, 1.1f,15f);
            CameraFL.Ins.FlashMove(4);

        }


    }


}
