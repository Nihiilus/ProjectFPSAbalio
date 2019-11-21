using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ReadingNotes : MonoBehaviour
{
    public GameObject IconReading;
    public GameObject PageReading;
    public TMP_Text TMPText;
    [TextArea(2,9)]
    public string textPage1;
    [TextArea(2, 9)]
    public string textPage2;
    [TextArea(2, 9)]
    public string textPage3;

    bool toggleBool = false;
    bool canOpen; 
    public AudioSource audioSource;

    private string triggerName;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Notes"))
        {
            IconReading.SetActive(true);
            canOpen = true;
            triggerName = other.gameObject.name;
        }
    }

    private void Update()
    {
        if (canOpen && Input.GetKeyUp("e"))
        {
            toggleBool = !toggleBool;
            audioSource.Play();
            PageReading.SetActive(toggleBool);

            switch (triggerName)
            {
                case "page1":
                    {
                        TMPText.text = textPage1;
                        break;
                    }
                case "page2":
                    {
                        TMPText.text = textPage2;
                        break;
                    }
                case "page3":
                    {
                        TMPText.text = textPage3;
                        break;
                    }
            }

        }
            
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Notes"))
        {
            IconReading.SetActive(false);
            canOpen = false;
            PageReading.SetActive(false);
        }
        

    }
}



