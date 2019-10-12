using System;
namespace Human
{
    public class ListOfHumans
    {
        private Man[] mans;

        public ListOfHumans(int N)
        {
            mans = new Man[N];
        }

        public Man this[int index]
        {
            get
            {
                return mans[index];
            }

            set
            {
                mans[index] = value;
            }
        }

        public override string ToString()
        {
            var str = "";
            foreach (Man man in mans)
            {
                if (man is Man)
                {
                    str += ((Man)man).ToString() + " ";
                }
            }

            return str;
        }
    }
}
