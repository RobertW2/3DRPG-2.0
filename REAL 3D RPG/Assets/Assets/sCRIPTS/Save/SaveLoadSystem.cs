
using UnityEngine;

using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Serialization
{
    public class SaveLoadSystem : MonoBehaviour
    {
        // Streaming assets is a folder that unity creates that we can use 
        // to load/save data in, in the editor it is in the project folder,
        // in a build, itis in the .exe's build folder
        private string FilePath => Application.streamingAssetsPath + "/gameData";

        [SerializeField] private GameData gameData = new GameData();
        [SerializeField] private bool useBinary = false;

        private void Start()
        {
            if (!Directory.Exists(Application.streamingAssetsPath))
                Directory.CreateDirectory(Application.streamingAssetsPath);
        }

        public void Save()
        {
            if (useBinary)
            {
                SaveBinary();
            }
            else
            {
                SaveJson();
            }
        }

        private void SaveBinary()
        {
            // This opens 'River' between the RAM and the file
            using (FileStream stream = new FileStream(FilePath + ".save", FileMode.OpenOrCreate))
            {

                // Like creating the boat that will carry the data from one point to another
                BinaryFormatter formatter = new BinaryFormatter();
                // Transports the data from the RAM to the specified file, like freezing water
                // into ice.
                formatter.Serialize(stream, gameData);
            }
        }

        private void SaveJson()
        {
            // Converts the object to a JSON string that we can read/write
            // to and from a file
            string json = JsonUtility.ToJson(gameData);
            // This will write all the contents of the string (param 2) to the file
            // at the path (param 1), the standard is to use .json as the file
            // extrention for json files.

            File.WriteAllText(FilePath + ".json", json);
        }


        public void Load()
        {
            if (useBinary)
                LoadBinary();
            else
                LoadJson();
        }

        private void LoadBinary()
        {
            // If there is no save data, we shouldnt attempt to load it
            if (!File.Exists(FilePath + ".save"))
                return;

            // This opens 'River' between the RAM and the file
            using (FileStream stream = new FileStream(FilePath + ".save", FileMode.Open))
            {

                // Like creating the boat that will carry the data from one point to another
                BinaryFormatter formatter = new BinaryFormatter();
                // Transports the data from the RAM to the specified file, like freezing water
                // into ice.
                gameData = formatter.Deserialize(stream) as GameData;
            }
        }

        private void LoadJson()
        {
            // This is how we read the string data for a file
            string json = File.ReadAllText(FilePath + ".json");
            // This is how you convert the json back to a data type.
            // This generic is required for making sure the returned data 
            // is the same as passed in
            gameData = JsonUtility.FromJson<GameData>(json);

        }

        private void OnGUI()
        {
            if (GUILayout.Button("Save"))
            {
                // Saves the game.
                Save();
            }


            if (GUILayout.Button("Load"))
            {
                // Loads the game.
                Load();
            }
        }
    }
}
