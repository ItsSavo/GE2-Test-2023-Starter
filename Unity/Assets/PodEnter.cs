using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PodEnter: MonoBehaviour
   
{
    // Start is called before the first frame update

    public GameObject FollowCamera;
    public GameObject MainCamera;
    void Start()
    {
        
    }


    public void OnTriggerEnter(Collider other)
    {
        FollowCamera.SetActive(true);
        MainCamera.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            FollowCamera.SetActive(true);
            MainCamera.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            FollowCamera.SetActive(false);
            MainCamera.SetActive(true);
        }
    }
}
