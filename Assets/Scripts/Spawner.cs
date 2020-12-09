using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject pinPrefab;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(pinPrefab, transform.position, transform.rotation);            
        }              
    }
}
