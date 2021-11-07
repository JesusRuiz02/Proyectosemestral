using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using JetBrains.Annotations;

public static class DataConsts
{
    public static string PLAYER_SETTINGS = Application.persistentDataPath + "/player_settings.dat";
}

public static class LoadSaveManager
{
    public static void SavedPlayerSettings(PlayerSettings playerSettings)
    {
        var path = DataConsts.PLAYER_SETTINGS;
        BinaryFormatter formatter = new BinaryFormatter();
        FileStream stream = new FileStream(path, FileMode.Create);
        formatter.Serialize(stream,playerSettings);
        stream.Close();
    }

    public static PlayerSettings LoadPlayerSettings()
    {
        PlayerSettings playerSettings = null;
        string path = DataConsts.PLAYER_SETTINGS;
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);
            playerSettings=(PlayerSettings)formatter.Deserialize(stream);
            stream.Close();

        }
        else
        {
            TextAsset file=Resources.Load("player_settings") as TextAsset;
            if (file== null)
            {
                Debug.LogError("File doesn´t exist");
            }
            else
            {
                playerSettings = JsonUtility.FromJson<PlayerSettings>(file.ToString());
            }
        }

        return playerSettings;
    }
}
