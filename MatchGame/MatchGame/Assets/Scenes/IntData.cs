using UnityEngine.UI;
using UnityEngine;

[CreateAssetMenu]
public class IntData : ScriptableObject
{
    public int value;
    public string nameTest;
    public Sprite picture;
    public int aNumber;

    public void UpdateValue(int number)
    {
        value += number;
    }
}
