using UnityEngine;

public class GhostTrigger : MonoBehaviour
{
    public BurgerGame manager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.name.Contains("bottombun"))
        {
            manager.BottomBunPlaced();
        }
    }
}

