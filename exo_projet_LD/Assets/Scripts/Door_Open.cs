using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_Open : MonoBehaviour
{
    [SerializeField]

    GameObject Door_Dank_A_snaps010;
    public Vector3 DoorRotation = new Vector3(0, -105, 0);

    bool isOpened = false;
    private void OnTriggerEnter(Collider col)
    {
        if (!isOpened)
        {
            isOpened = true;
            Door_Dank_A_snaps010.transform.Rotate ( DoorRotation );
        }
        
    }
}
