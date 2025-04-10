using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.InputSystem;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public static Player Instance { get; private set; }

    [SerializeField]
    private float speed;

    PlayerInputActions actions;

    private void Awake()
    {
        Instance = this;
        actions = new PlayerInputActions();
        actions.Player.Enable();
    }
    public void Move()
    {
        Vector2 inputVector = actions.Player.Move.ReadValue<Vector2>();

        inputVector = inputVector.normalized;

        Vector3 moveDir = new Vector3(inputVector.x, transform.position.y, inputVector.y);

        float moveDistance = Time.deltaTime * speed;

        transform.position +=  moveDir * moveDistance;

        transform.forward = Vector3.Slerp(transform.forward, moveDir, moveDistance);
    }

    private void Update()
    {
        Move();
    }
}
