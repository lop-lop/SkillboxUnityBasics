using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChoice : MonoBehaviour
{
    public List<GameObject> cam = new List<GameObject>();
    private int num;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            cam[num].SetActive (false);
            num ++;
            if (num == cam.Count) num = 0;
            cam[num].SetActive (true);
        }
    }
}
