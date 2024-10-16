using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PhotoDisplay : MonoBehaviour
{
    [SerializeField] private PhotoScriptableObject photo;
    public Text descText;
    public Image image;
    // Start is called before the first frame update
    void Start()
    {
        descText.text = photo.description;
        image.sprite = photo.artwork;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
