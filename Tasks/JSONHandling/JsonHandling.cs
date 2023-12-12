using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using Tasks.Model;

namespace Tasks.JSONHandling {
    public static class JsonHandling {
        static string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),"base.json");
        public static void WriteToFile(List<TaskModel> list) {
            if (!File.Exists(path))
                File.WriteAllText(path,"");
            string json= JsonSerializer.Serialize(list);
            File.WriteAllText(path, json);
        }
        public static List<TaskModel> GetFromFile() {
            if (!File.Exists(path)) {
                File.WriteAllText(path, "");
                return new List<TaskModel>();
            }
            string text = File.ReadAllText(path);
            return JsonSerializer.Deserialize<List<TaskModel>>(text);
        }
    }
}
