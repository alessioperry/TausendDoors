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


        public void StepHundred(Person p)
        {
            for (var i = 1; i <= 100; i ++)
            {
                StepN(i, p);
            }
        }

        public void StepN(int step, Person p)
        {
            for (var i = 0; i < Count; i ++)
            {
                if (Count > i * step)
                    p.StepOver(this[i * step]);
            }
        }
    }
}