using UnityEngine;

public class SnapTarget : MonoBehaviour
{
    public Transform snapPosition;
    public string correctObjectName;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Contains(correctObjectName))
        {
            other.transform.position = snapPosition.position;
            other.transform.rotation = snapPosition.rotation;

            Rigidbody rb = other.GetComponent<Rigidbody>();

            if (rb != null)
            {
                rb.isKinematic = true;
            }
        }
    }
}
