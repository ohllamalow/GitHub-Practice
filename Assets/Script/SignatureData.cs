using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SignatureData", menuName = "GameData/SignatureData")]
public class SignatureData : ScriptableObject
{
    public List<string> signatures = new();
}
