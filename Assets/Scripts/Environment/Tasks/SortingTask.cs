using Environment.Tasks;
using System;
using UnityEngine;

namespace Enviroment.Tasks
{
    [CreateAssetMenu(fileName = "SortDataTask", menuName = "Sort Data Task")]
    public class SortingTask : Task
    {
        [SerializeField] DataReader ReadData;
        Data[] ListOfEmployees;
        float PivotPoint;
        public override void Execute()  
        {
            ListOfEmployees = ReadData.PLEASEWORK.employees;
            QuickSort();
        }

        public void QuickSort()
        {
            return;
        }

        public void Partition()
        {
            return;
        }
    }
}
