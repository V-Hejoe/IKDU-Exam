using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnumerationCode : MonoBehaviour
{
    enum Element {Fire = 1, Water = 3, Earth = 4, Air = 2};
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Element.Fire + " : " + (int) Element.Fire);
        Debug.Log(Element.Water + " : " + (int) Element.Water);
        Debug.Log(Element.Earth + " : " + (int) Element.Earth);
        Debug.Log(Element.Air + " : " + (int) Element.Air);
    }
}
