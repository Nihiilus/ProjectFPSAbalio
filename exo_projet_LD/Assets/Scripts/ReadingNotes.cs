using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReadingNotes : MonoBehaviour
{
    public GameObject IconReading;
    public GameObject PageReading;
    bool toggleBool = false;
    public AudioSource audioSource;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
           
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Notes"))
            IconReading.SetActive(true);

    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyUp("e"))
        {
            toggleBool = !toggleBool;
            PageReading.SetActive(toggleBool);
            audioSource.Play();
        }
            
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Notes"))
            IconReading.SetActive(false);
        PageReading.SetActive(false);

    }
}



