using System;
using System.IO;
using UnityEngine;

namespace Environment.Tasks
{
    [CreateAssetMenu(fileName = "ReadDataTask", menuName = "Read Data Task")]
    public class DataReader : Task
    {
        [SerializeField] string FileName;
        string FilePath;
        string Json;

        public override void Execute()
        {
            FilePath = Path.Combine(Application.streamingAssetsPath, FileName);
            Debug.Log(FilePath);

            Json = File.ReadAllText(FilePath);
            Debug.Log(Json);
        }
    }
}
