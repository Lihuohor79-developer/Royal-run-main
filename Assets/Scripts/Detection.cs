using UnityEngine;

public class Detection : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("name" +  collision.gameObject.name);
    }
}
