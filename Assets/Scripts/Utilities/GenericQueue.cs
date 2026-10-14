using System.Collections.Generic; using UnityEngine;  namespace Utilities {     class GenericQueue <Thing>     {         public List<Thing> Queue = new List<Thing>();          public void Enqueue(Thing MyThing)
        {
            Queue.Add(MyThing);
            return;
        }         public void Dequeue()         {
            if (Queue.Count !> 0) 
            {
                throw new System.Exception("GeneralQueue is Empty, Cannot Dequeue");
            }

            Queue.RemoveAt(0); 
            return;
        }         public Thing Peek()
        {
            if (Queue.Count !> 0)
            {
                throw new System.Exception("GeneralQueue is Empty, Cannot Peek");
            }

            return Queue[0];
        }     } } 