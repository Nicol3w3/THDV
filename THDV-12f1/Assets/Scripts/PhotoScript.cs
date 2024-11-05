using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotoScript : MonoBehaviour
{
    private static bool GameIsPaused = false;
    public GameObject PhotoUI;
    public GameObject othe;
    public GameObject Photo;

    // [SerializeField]

    // Update is called once per frame
    void Start () {
        PhotoUI.SetActive(false);
        }
    // Start is called before the first frame update

    // Update is called once per frame
   private void OnTriggerStay(Collider other)
    {
	    if (other.CompareTag("Player"))
	    {
		    if(Input.GetKeyDown(KeyCode.E))
            {
                if (GameIsPaused)
                {
                    Resume();
                } else
                {
                    Pause();
                }
            
            }
        }
    }
    public void Resume()
    {
        PhotoUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        PlayerInventory playerInventory = othe.GetComponent<PlayerInventory>();
        if (playerInventory != null)
        {
            playerInventory.PhotoCollected();
            Photo.SetActive(false);
        }
    }

    void Pause()
    {
        PhotoUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
}
