
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
[System.Serializable]
public class CollisionTarget
{
    public Collider2D checkCollider;
    public UnityEvent onCollisionEnter;
    public UnityEvent onCollisionExit;
}

public class CheckCollision : MonoBehaviour
{
    public CollisionTarget[] targets;
    public void OnCollisionEnter2D(Collision2D other)
    {
        foreach (CollisionTarget target in targets)
        {
            if (other.collider == target.checkCollider)
            {
                target.onCollisionEnter.Invoke();
                return;
            }
        }

    }
    public void OnCollisionExit2D(Collision2D other)
    {
        foreach (CollisionTarget target in targets)
        {
            if (other.collider == target.checkCollider)
            {
                target.onCollisionEnter.Invoke();
                return;
            }
        }
    }

}
