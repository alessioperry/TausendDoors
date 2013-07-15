namespace TausendDoors
{
    public class Person
    {
        private int steps;

        public void StepOver(Door door)
        {
            if (door.Status() == Status.Closed)
                door.Open();
            else
                door.Close();

            steps++;
        }

        public int Steps()
        {
            return steps;
        }
    }
}