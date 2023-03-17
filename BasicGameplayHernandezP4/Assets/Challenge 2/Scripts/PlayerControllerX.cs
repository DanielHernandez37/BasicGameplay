using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private bool shotAllowed = true;

    
    IEnumerator MakeWait() {
        shotAllowed = false;
        yield return new WaitForSeconds(.5f);
        shotAllowed = true;
    }

    void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.Space) && shotAllowed)
        {
           
            StartCoroutine(MakeWait());
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}