
using UnityEngine;

public class CollectibleCount : MonoBehaviour
{
   public int count = 0;
   TMPro.TMP_Text text;

   void Awake()
   {
    text = GetComponent<TMPro.TMP_Text>();
   }

    void Start() => UpDateCount();

   void OnEnable() => Collectible.OnCollected += OnCollectibleCollected;
   void OnDisable() => Collectible.OnCollected -= OnCollectibleCollected;

   void OnCollectibleCollected()
   {
    count++;
    UpDateCount();
   }

   void UpDateCount()
   {
    text.text = $"{count} / {Collectible.total}";
   }
}
