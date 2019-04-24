using System;


/// <summary>
/// Data class used to provide raw data to a FancyObject.
/// This can make setting up objects in the editor easier,
/// and can be useful for saving data.
/// 
/// You can't serialize MonoBehaviours, so using these types of 
/// data classes associated with your MonoBehaviour classes can help
/// circumvent the problem.
/// 
/// Needs `using System;` to work!
/// </summary>
[Serializable]
public class FancyObjectData
{
    public int number1, number2;
    public string string1, string2;
}
