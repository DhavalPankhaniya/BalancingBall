using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem
{
    public static void saveLevel() {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/BalancingBall.dat";
        FileStream stream = new FileStream(path, FileMode.Create);
        PlayerData data = new PlayerData();
        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static PlayerData loadLevel() {
        string path = Application.persistentDataPath + "/BalancingBall.dat";
        if(File.Exists(path)) {
            Debug.LogError(path);
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);
            PlayerData playerData = formatter.Deserialize(stream) as PlayerData;
            stream.Close();
            return playerData;
        } else {
            Debug.LogError("file not found");
            return null;
        }
    }
}
