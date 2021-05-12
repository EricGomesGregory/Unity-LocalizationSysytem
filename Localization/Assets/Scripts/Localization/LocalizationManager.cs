using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;

public enum Languages
{
    English,
    Portuguese,
    Japanese
}

[CreateAssetMenu(fileName = "Localization Manager", menuName = "Localization/Manager")]
public class LocalizationManager : ScriptableObject
{
    public Languages activeLanguage;

    public delegate void LanguageSwitch();
    public event LanguageSwitch OnLanguageSwitch;

    public void NextLanguage()
    {
        var language = activeLanguage + 1;
        if ((int)language == Enum.GetValues(typeof(Languages)).Length) { language = 0; }
        activeLanguage = language;

        if (OnLanguageSwitch != null) OnLanguageSwitch();
    }

    public void PreviousLanguage()
    {
        var language = activeLanguage - 1;
        if ((int)language == -1) { language = (Languages)Enum.GetValues(typeof(Languages)).Length - 1; }
        activeLanguage = language;

        if (OnLanguageSwitch != null) OnLanguageSwitch.Invoke();
    }
}

