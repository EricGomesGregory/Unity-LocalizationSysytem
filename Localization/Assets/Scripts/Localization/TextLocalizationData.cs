using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;
using TMPro;

[Serializable]
public class TextData
{
    [TextArea(10, 15)]
    public string text;
    public TMP_FontAsset font;

    public TextData(string defaultText)
    {
        text = defaultText;
        font = null;
    }
}

[CreateAssetMenu(fileName = "Loclized Text", menuName = "Localization/Data/Text")]
public class TextLocalizationData : ScriptableObject
{
    public TextData english = new TextData("Default");
    public TextData portuguese = new TextData("Padrão");
    public TextData japanese = new TextData("デフォルト");
}
