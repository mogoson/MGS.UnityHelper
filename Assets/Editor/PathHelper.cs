/*************************************************************************
 *  Copyright © 2024 Mogoson. All rights reserved.
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

namespace MGS.UnityHelper
{
    public sealed class PathHelper
    {
        [MenuItem("Tool/Path Helper/PersistentDataPath")]
        public static void PersistentDataPath()
        {
            Application.OpenURL(Application.persistentDataPath);
        }

        [MenuItem("Tool/Path Helper/StreamingAssetsPath")]
        public static void StreamingAssetsPath()
        {
            Application.OpenURL(Application.streamingAssetsPath);
        }

        [MenuItem("Tool/Path Helper/TemporaryCachePath")]
        public static void TemporaryCachePath()
        {
            Application.OpenURL(Application.temporaryCachePath);
        }

        [MenuItem("Tool/Path Helper/ConsoleLogPath")]
        public static void ConsoleLogPath()
        {
            var dir = Path.GetDirectoryName(Application.consoleLogPath);
            Application.OpenURL(dir);
        }

        [MenuItem("Tool/Path Helper/DataPath")]
        public static void DataPath()
        {
            Application.OpenURL(Application.dataPath);
        }
    }
}