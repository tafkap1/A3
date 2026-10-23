using UnityEngine;

public class BurgerGame : MonoBehaviour
{
    public GameObject bottomBunGhost;
    public GameObject pepperGhost;

    public void BottomBunPlaced()
    {
        bottomBunGhost.SetActive(false);
        pepperGhost.SetActive(true);
    }
}