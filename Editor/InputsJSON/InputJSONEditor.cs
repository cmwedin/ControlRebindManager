using System.IO;
using System.Threading.Tasks;
using UnityEngine;

namespace SadSapphicGames.ControlRebindManager.Editor
{
    /// <summary>
    /// Static class for reading and writing data from an input json
    /// </summary>
    public static class InputJSONEditor {
        public static InputCollection ReadInputJSON(string path) {
            using StreamReader reader = new StreamReader(path);
            string jsonString = reader.ReadToEnd();
            reader.Close();
            return JsonUtility.FromJson<InputCollection>(jsonString);
        }
        public static async Task<InputCollection> ReadInputJSONAsync(string path)
        {
            using StreamReader reader = new StreamReader(path);
            Task<string> readTask = reader.ReadToEndAsync();
            await readTask;
            reader.Close();
            Task<InputCollection> parseJSONTask = new Task<InputCollection>((() => JsonUtility.FromJson<InputCollection>(readTask.Result)));
            await parseJSONTask;
            return parseJSONTask.Result;
        }
    }
}