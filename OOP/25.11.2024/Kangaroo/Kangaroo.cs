using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KangarooNamespace
{
    internal class Kangaroo
    {
        public Kangaroo()
        {
            name = "";
        }
        public Kangaroo(string name, double height, double jumpDistance, int hunger, int age, bool isMale)
        {
            this.name = "GREAT NAME";
            SetName(name);
            SetHeight(height);
            SetJumpDistance(jumpDistance);
            SetHunger(hunger);
            SetAge(age);
            SetIsMale(isMale);
            pocketContents = null;
        }
        public Kangaroo(Kangaroo kangaroo)
        {
            name = kangaroo.name;
            height = kangaroo.height;
            jumpDistance = kangaroo.jumpDistance;
            hunger = kangaroo.hunger;
            age = kangaroo.age;
            isMale = kangaroo.isMale;
        }

        string name;
        double height, jumpDistance;
        int hunger, age;
        bool isMale;
        Kangaroo? pocketContents;

        public string GetName()
        {
            return name;
        }
        public void SetName(string name)
        {
            if (name != string.Empty)
            {
                this.name = name;
            }
        }

        public double GetHeight()
        {
            return height;
        }
        public void SetHeight(double height)
        {
            if (height > 0 && height <= 600)
            {
                this.height = height;
            }
        }
        public bool IsMale()
        {
            return isMale;
        }
        public void SetIsMale(bool isMale)
        {
            if (pocketContents == null || isMale == false)
            {
                this.isMale = isMale;
            }
        }

        public Kangaroo? GetPocketContents()
        {
            if (pocketContents == null)
            {
                return null;
            }
            return new Kangaroo(pocketContents);
        }
        public void SetPocketContents(Kangaroo pocketContents)
        {
            if (age > 8 && pocketContents.age <= 8 && height > 4 * pocketContents.height)
            {
                this.pocketContents = new Kangaroo(pocketContents);
            }
        }
        public double GetJumpDistance()
        {
            return jumpDistance;
        }
        public void SetJumpDistance(double jumpDistance)
        {
            if (jumpDistance > 0 && jumpDistance <= 600)
            {
                this.jumpDistance = jumpDistance;
            }
        }

        public int GetAge()
        {
            return age;
        }

        public void SetAge(int age)
        {
            if (age > 0 && age <= 600) this.age = age;
        }

        public int GetHunger() { return hunger; }
        public void SetHunger(int hunger)
        {
            if (hunger >= 0 && hunger <= 10) this.hunger = hunger;
        }

        public bool isHungry()
        {
            return hunger < 2;
        }
        public override string ToString()
        {
            return $"Name:{name}\n\tage: {age}, height: {height}, jumpDistance: {jumpDistance}\n\thunger: {hunger}\n\n\tchild: {pocketContents}";
        }
    }
}
