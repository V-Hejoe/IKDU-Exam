using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MethodOverload : MonoBehaviour
{
    private void Start()
    {
        CharacterCreation("Ben");
        CharacterCreation(10);
        CharacterCreation("Ben", 10);
    }

    public void CharacterCreation(string name)
    {
        Debug.Log("Character: " + name + ".");
    }
    public void CharacterCreation(int age)
    {
        Debug.Log("Character: " + age + " years old.");
    }
    public void CharacterCreation(string name, int age)
    {
        Debug.Log("Character: " + name + ", " + age + " years old.");
    }
}