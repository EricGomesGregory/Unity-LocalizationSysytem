using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;
using TMPro;

[Serializable]
public class LanguageData
{
    [TextArea(10, 15)]
    public string text;
    public TMP_FontAsset font;

    public LanguageData(string defaultText)
    {
        text = defaultText;
        font = null;
    }
}

[CreateAssetMenu(fileName = "Loclized Text", menuName = "Localization/Text Data")]
public class TextLocalizationData : ScriptableObject
{
    public LanguageData english = new LanguageData("Default");
    public LanguageData portuguese = new LanguageData("Padrão");
    public LanguageData japanese = new LanguageData("デフォルト");
}
