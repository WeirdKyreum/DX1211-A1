using UnityEngine;
using UnityEngine.InputSystem;
public class CarMovement : MonoBehaviour
{
    // Allow the speed variable accessible from Inspector panel
    [SerializeField] float speed = 5;
    [SerializeField] Animator animator;
    // Update is called once per frame
    void Update()
    {
        // Read the Move action from the InputSystem        
        var moveAction = InputSystem.actions.FindAction("Move");
        var moveValue = moveAction.ReadValue<Vector2>();
        // Change the position of the object's transform position in the direction according to input with speed of 50 in real-time
        transform.position += new Vector3(moveValue.x, moveValue.y, 0) * speed * Time.deltaTime;
        // Read the Turbo action from the InputSystem
        var turboAction = InputSystem.actions.FindAction("Turbo");

        if (turboAction.IsPressed())
        {
            animator.speed = 15f;
        }
        else
        {
            animator.speed = 1;
        }
    }
}




