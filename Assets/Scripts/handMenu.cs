using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class handMenu : MonoBehaviour
{
    public Camera camera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void moveToHall1()
    {
        camera.transform.position = new Vector3(0f, 0f, 0f);
    }

    public void moveToHall2()
    {
        camera.transform.position = new Vector3(10f, 0f, 2f);
    }

    public void moveToHall3()
    {
        camera.transform.position = new Vector3(20f, 0f, -7f);
    }
}
