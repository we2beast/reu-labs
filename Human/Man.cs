using System;
using System.Security.Cryptography;
using System.Text;

namespace Human
{
    public class Man
    {
        private int age;
        private string name;

        public virtual int Age
        {
            get { return age; }
            set { age = value; }
        }

        public virtual string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Man(Man previous)
        {
            name = previous.Name;
            age = previous.Age;
        }

        public Man(string Name, int Age)
        {
            age = Age;
            name = Name;
        }

        public Man()
        {
            name = "Неизвестно"; age = 18;
        }

        public override string ToString()
        {
            return $"Human {name} {age}";
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Man);
        }

        public override int GetHashCode()
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(Name));

            return hash.Length;
        }
    }
}
