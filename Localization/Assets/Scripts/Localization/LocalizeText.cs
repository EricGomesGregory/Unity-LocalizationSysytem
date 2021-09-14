using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;

public class LocalizeText : MonoBehaviour
{
    [SerializeField]
    LocalizationManager manager;
    [SerializeField]
    TextLocalizationData data;

    TextMeshProUGUI textMesh;

    private void Start()
    {
        textMesh = GetComponent<TextMeshProUGUI>();

        UpdateText();
    }

    private void OnEnable()
    {
        manager.OnLanguageSwitch += UpdateText;
    }

    private void OnDisable()
    {
        manager.OnLanguageSwitch -= UpdateText;
    }

    private void UpdateText()
    {
        switch (manager.activeLanguage)
        {
            case Languages.English:
                textMesh.text = data.english.text;
                if (data.english.font != null) textMesh.font = data.english.font;
                break;

            case Languages.Portuguese:
                textMesh.text = data.portuguese.text;
                if (data.english.font != null) textMesh.font = data.english.font;
                break;

            case Languages.Japanese:
                textMesh.text = data.japanese.text;
                if (data.english.font != null) textMesh.font = data.japanese.font;
                break;
        }
    }
}