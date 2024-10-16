using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Photo", menuName = "Photo")]
public class PhotoScriptableObject : ScriptableObject
{
    public new string description;
    public Sprite artwork;
}
