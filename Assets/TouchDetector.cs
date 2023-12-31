using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchDetector : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.touches[0].position);
            Debug.Log("TOUCHED");
            if(Physics.Raycast(ray, out RaycastHit hit))
            {
                Debug.Log("RAYCASTED");
                if(hit.collider != null && hit.collider.CompareTag("Chest"))
                {
                    Debug.Log("CHEST DETECTED");
                    hit.collider.GetComponent<RotateScript>().ChangeColor();
                }
            }
        }
    }
}
