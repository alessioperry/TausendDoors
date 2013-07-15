namespace TausendDoors
{
    public class Door
    {
        private Status status;

        public Door()
        {
            status = TausendDoors.Status.Closed;
        }

        public void Close()
        {
            this.status = TausendDoors.Status.Closed;
        }

        public void Open()
        {
            this.status = TausendDoors.Status.Open;
        }


        public Status Status()
        {
            return status;
        }

    }
}