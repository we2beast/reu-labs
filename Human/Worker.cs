using System;
using System.Security.Cryptography;
using System.Text;

namespace Human
{
    public class Worker: Man
    {
        private int age;
        private string name;

        public override int Age
        {
            get { return age; }
            set {
                if (value >= 16 && value <= 70) age = value;
                else throw new Exception("Age error");
            }
        }

        public override string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Worker(Worker previous) : base(previous)
        {
        }

        public Worker(string Name, int Age) : base(Name, Age)
        {
        }

        public Worker()
        {
            name = "Неизвестно"; age = 18;
        }

        public override string ToString()
        {
            return $"Worker {name} {age}";
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Worker);
        }

        public override int GetHashCode()
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(Name));

            return hash.Length;
        }

    }
}
