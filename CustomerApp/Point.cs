namespace CustomerApp
{
    public class Point
    {
        public int X;
        public int Y;


        public Point(
            int x,
            int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(int x, int y)
        {
            this.X = x;
            this.Y = y;

        }

        public void Move(Point newLocation)
        {

            if(newLocation == null)     //defensive programming IMPROVE ROBUSTNESS OF THE CODE
            {
                throw new ArgumentNullException("New Location exception");
            }

            Move(newLocation.X, newLocation.Y);
            //this.X = newLocation.X;
            //this.Y = newLocation.Y;
        }

    }
}