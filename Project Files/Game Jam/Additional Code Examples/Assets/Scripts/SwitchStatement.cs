using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchStatement : MonoBehaviour
{
   private void Start()
    {
        for (int i = 0; i < 11; i++)
        {
            switch (i)
            {
                case 0:
                    Debug.Log("The number is zero.");
                    break;
                case 1:
                    Debug.Log("The number is one.");
                    break;
                case 2:
                    Debug.Log("The number is two.");
                    break;
                case 3:
                    Debug.Log("The number is three.");
                    break;
                case 4:
                    Debug.Log("The number is four.");
                    break;
                case 5:
                    Debug.Log("The number is five.");
                    break;
                case 6:
                    Debug.Log("The number is six.");
                    break;
                case 7:
                    Debug.Log("The number is seven.");
                    break;
                case 8:
                    Debug.Log("The number is eight.");
                    break;
                case 9:
                    Debug.Log("The number is nine.");
                    break;
                default:
                    Debug.Log("The number is not between zero and nine.");
                    break;
            }
        }
    }
}
