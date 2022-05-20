using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EncapsulationActivity.Models
{

    public enum GRADE
    {
        A, B, C, D, E, F
    }

    public class Student
    {
        private string name;
        private GRADE grade;
        private int group;

        private string secretNickName = "SecretNickName";

        public Student(string name, GRADE grade, int group)
        {
            this.name = name;
            this.grade = grade;
            this.group = group;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public GRADE Grade
        {
            get { return grade; }
            set { grade = value; }
        }
        public int Group
        {

            get { return group; }

            set
            {
                if (group < 1 || group > 5)
                    throw new ArgumentException("group value should be between 1 to 5");
                group = value;
            }
        }

    }

}
