using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;

[CreateAssetMenu]
public class DialogData : ScriptableObject
{
    public List<string> listCharacterNames = new List<string>();
    public List<string> listDialogTexts = new List<string>();
    public List<Sprite> listCharacterImgs = new List<Sprite>();
}
