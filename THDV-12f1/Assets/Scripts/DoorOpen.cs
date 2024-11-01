using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DoorOpen : MonoBehaviour
{
    private Animator anim;

    private bool IsAtDoor = false;

    [SerializeField] private TextMeshProUGUI CodeText;
    string codeTextValue = "";
    public string safeCode;
    public GameObject codePanel;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();    
    }

    // Update is called once per frame
    void Update()
    {
        CodeText.text = codeTextValue;

        if(codeTextValue == safeCode)
        {
            anim.SetTrigger("Open_Door");
            codePanel.SetActive(false);
        }
        if(codeTextValue.Length >= 4)
        {
            codeTextValue = "";
        }

        if(Input.GetKey(KeyCode.E) && IsAtDoor == true)
        {
            codePanel.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            IsAtDoor = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        IsAtDoor = false;
        codePanel.SetActive(false);
    }

    public void AddDigit(string digit)
    {
        codeTextValue += digit;
    }
}
