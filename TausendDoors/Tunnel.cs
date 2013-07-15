using System.Collections.Generic;

namespace TausendDoors
{
    public class Tunnel : List<Door>
    {
        public Tunnel(int capacity)
        {
            for (int i = 0; i < capacity; i++)
            {
                Add(new Door());
            }
        }

        public void StepN(int step, Person p)
        {
            foreach (var VARIABLE in this)
            {
                ForEach(p.StepOver);
            }
        }
    }
}