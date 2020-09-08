using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveLoadManager 
{
    public static void Save(player player)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/saveOyun.dat";
        FileStream fs = new FileStream(path, FileMode.Create);
        PlayerData data = new PlayerData(player);
        formatter.Serialize(fs, data);
        fs.Close();
    }
    public static PlayerData Load()
    {
        string path = Application.persistentDataPath + "/saveOyun.dat";
        if(File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream fs = new FileStream(path, FileMode.Open);
            PlayerData data = formatter.Deserialize(fs) as PlayerData;
            fs.Close();
            return data;

        }
        else
        {
            Debug.LogError("Dosya Acilamadi");
            return null;
        }
    }
}
