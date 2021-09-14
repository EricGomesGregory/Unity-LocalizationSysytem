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

    public void ChangeLanguage(int i)
    {
        var language = activeLanguage + i;
        //language = (Languages)Mathf.Clamp((int)language, 0, Enum.GetValues(typeof(Languages)).Length - 1);
        language = (Languages)((int)language % Enum.GetValues(typeof(Languages)).Length);

        activeLanguage = language;

        if (OnLanguageSwitch != null) OnLanguageSwitch();
    }

    public void ChangeToLanguage(int language)
    {
        activeLanguage = (Languages)language;
        if (OnLanguageSwitch != null) OnLanguageSwitch();
    }
}

