using System;
using System.Collections.Generic;

namespace data_structures_2
{
    class Stack
    {
        private List<int> elements = new List<int>();

        //Push
        public void Push(int elementToPush)
        {
            elements.Add(elementToPush);
        }

        //Pop
        public int Pop()
        {
            int lastIndex = elements.Count - 1;

            int lastElement = elements[lastIndex];

            //Destroy last element
            elements.RemoveAt(lastIndex);

            return lastElement;
        }

        //Top
        public int Top()
        {
            int lastIndex = elements.Count - 1;

            int lastElement = elements[lastIndex];
            
             return lastElement;
        }

        //Bottom
        public int Bottom()
        {
            return elements[0];
        }

        public override string ToString()
        {
            string stackAsString = "";

            for (int i = 0; i < elements.Count; i++)
            {
                int inverseIndex = elements.Count - i - 1;
                stackAsString += elements[inverseIndex];
                stackAsString += "\n";
            }

            return stackAsString;
        }
    }
}
