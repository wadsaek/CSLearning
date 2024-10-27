namespace _30._09_2024.Classes;

    class Malben
    {
        private double length;
        private double width;

        public Malben()
        {
            length = 0;
            width = 0;
        }
        public Malben(double length, double width)
        {
            this.SetLen(length);
            // this.length = length;
            this.width = width;
        }

        public void SetLen(double length)
        {
            if (length >= 0)
            {
                this.length = length;
            }
        }

        public double GetLen()
        { return length; }
        public double Area()
        {
            return width * length;
        }
        public double Perimeter()
        {
            return 2 * (width + length);
        }

        public override string ToString()
        {
            string s = string.Format(" w={0} l={1}", this.width, length);
           // string s2  = "w=" + this.width + " l=" + this.length;
            return s;
        }
    }

