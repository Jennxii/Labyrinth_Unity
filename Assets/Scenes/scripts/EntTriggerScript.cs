using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntTriggerScript : MonoBehaviour
{
    public TMPro.TMP_Text text;
    public GameObject ui;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collider)
    {
        int count = ui.GetComponent<CollectibleCount>().count;
        if (count == Collectible.total)
        {
             text.text = $"You did it! All diamonds are free";
        }
        else
        {
            text.text = $"You must collect all diamonds!";
        }
    }
   
}
