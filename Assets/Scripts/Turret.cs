using UnityEngine;

public class Turret : MonoBehaviour
{
    public Animator animator;

    private void OnMouseUp()
    {
        animator.SetTrigger("Shoot");
    }


}