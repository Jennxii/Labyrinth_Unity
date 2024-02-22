using System;
using UnityEngine;

public class Collectible : MonoBehaviour
{
   
    public static event Action OnCollected;
    public static int total = 5;


    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Euler(90f, 100f*Time.time ,0);
       
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            OnCollected?.Invoke();
            Destroy(gameObject);
        }
    }
}
