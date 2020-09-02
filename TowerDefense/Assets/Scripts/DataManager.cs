using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class DataManager {


    public static string savePath = "saves";

    public static void CreateSaveDirectory()
    {
        if(!Directory.Exists(savePath))
            Directory.CreateDirectory(savePath);
    }

	public static void Serialize<T>(T t, string filePath)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        FileStream stream = new FileStream(savePath + filePath, FileMode.Create);
        formatter.Serialize(stream, t);
        stream.Close();
    }

    public static T Deserialize<T>(string filePath)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        FileStream stream = new FileStream(savePath + filePath, FileMode.Open);
        T t = (T)formatter.Deserialize(stream);
        stream.Close();

        return t;
    }
}
