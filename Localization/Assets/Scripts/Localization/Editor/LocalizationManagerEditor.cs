﻿using System.Collections;
using UnityEngine;

using UnityEditor;

[CustomEditor(typeof(LocalizationManager))]
public class LocalizationManagerEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        LocalizationManager script = (LocalizationManager)target;
        if (GUILayout.Button("Next Language"))
        {
            script.NextLanguage();
        }

        if (GUILayout.Button("Previous Language"))
        {
            script.PreviousLanguage();
        }
    }
}
