/*************************************************************************
 *  Copyright (C) 2024 Mogoson. All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  PathHelper.cs
 *  Description  :  Null.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  1.0.0
 *  Date         :  2024/7/21
 *  Description  :  Initial development version.
 *************************************************************************/

using System.IO;
using UnityEditor;
using UnityEngine;

public sealed class PathHelper
{
    [MenuItem("Tool/UnityHelper/Path/PersistentDataPath")]
    public static void PersistentDataPath()
    {
        Application.OpenURL(Application.persistentDataPath);
    }

    [MenuItem("Tool/UnityHelper/Path/StreamingAssetsPath")]
    public static void StreamingAssetsPath()
    {
        Application.OpenURL(Application.streamingAssetsPath);
    }

    [MenuItem("Tool/UnityHelper/Path/TemporaryCachePath")]
    public static void TemporaryCachePath()
    {
        Application.OpenURL(Application.temporaryCachePath);
    }

    [MenuItem("Tool/UnityHelper/Path/ConsoleLogPath")]
    public static void ConsoleLogPath()
    {
        var dir = Path.GetDirectoryName(Application.consoleLogPath);
        Application.OpenURL(dir);
    }

    [MenuItem("Tool/UnityHelper/Path/DataPath")]
    public static void DataPath()
    {
        Application.OpenURL(Application.dataPath);
    }
}