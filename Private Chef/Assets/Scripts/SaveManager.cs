using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


public static class SaveManager 
{

    public static void CashSave (Cash cash)
    {
        BinaryFormatter formatter = new BinaryFormatter();

        string path = Application.persistentDataPath + "/cash.data";
        FileStream stream = new FileStream(path, FileMode.Create);

            Cash Income = new Cash();
        formatter.Serialize(stream, Income);
        stream.Close();
    }

    public static Cash CashLoad()
    {
        string path = Application.persistentDataPath + "/cash.data";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();

            FileStream stream = new FileStream(path, FileMode.Open);

            Cash Income = formatter.Deserialize(stream) as Cash;
            stream.Close();

            return Income;

        }
        else
        {
            Debug.LogError("Save file not found" + path);
            return null;
        }
    } 
}
