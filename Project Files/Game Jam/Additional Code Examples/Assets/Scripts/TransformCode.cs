using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformCode : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        //Change of position
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            this.gameObject.transform.position += new Vector3(0,1,0);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            this.gameObject.transform.position += new Vector3(0, -1, 0);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            this.gameObject.transform.position += new Vector3(1, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            this.gameObject.transform.position += new Vector3(-1, 0, 0);
        }

        //Change of rotation
        if (Input.GetKeyDown(KeyCode.F))
        {
            this.gameObject.transform.Rotate(10,0,0);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            this.gameObject.transform.Rotate(0, 10, 0);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            this.gameObject.transform.Rotate(0, 0, 10);
        }

        //Change of scale
        if (Input.GetKeyDown(KeyCode.O))
        {
            this.gameObject.transform.localScale += new Vector3(1,1,1);
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            this.gameObject.transform.localScale -= new Vector3(1,1,1);
        }
    }
}
