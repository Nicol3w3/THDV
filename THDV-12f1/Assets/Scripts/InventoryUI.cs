using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class InventoryUI : MonoBehaviour
{
    private TextMeshProUGUI photoCounter;
    // Start is called before the first frame update
    void Start()
    {
        photoCounter = GetComponent<TextMeshProUGUI>();
    }

    public void UpdatePhotoCounter(PlayerInventory playerInventory)
    {
        photoCounter.text = playerInventory.NumberOfPhotos.ToString();
    }
}
