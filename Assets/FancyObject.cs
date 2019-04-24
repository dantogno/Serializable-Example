using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FancyObject : MonoBehaviour
{
    [SerializeField]
    private FancyObjectData fancyObjectData;

    private int number1, number2;
    private string string1, string2;

    // Start is called before the first frame update
    void Start()
    {
        number1 = fancyObjectData.number1;
        number2 = fancyObjectData.number2;
        string1 = fancyObjectData.string1;
        string2 = fancyObjectData.string2;

        Debug.Log($"{number1}, {number2}, {string1}, {string2}");
    }
}
