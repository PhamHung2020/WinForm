using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View
{
    class Subject
    {
        private string name;
        private double score;

        public string Name { get => name; set => name = value; }
        public double Score { get => score; set => score = value; }

        public Subject(string name, double score)
        {
            this.Name = name;
            this.Score = score;
        }

        public string Rank()
        {
            if (score >= 9.5)
                return "A+";
            else if (score < 9.5 && score >= 8.5)
                return "A";
            else if (score < 8.5 && score >= 8)
                return "B+";
            else if (score < 8 && score >= 7)
                return "B";
            else if (score < 7 && score >= 6.5)
                return "C+";
            else if (score < 6.5 && score >= 5.5)
                return "C";
            else if (score < 5.5 && score >= 5)
                return "D+";
            else if (score < 5 && score >= 4.5)
                return "D";
            else
                return "F";
        }

        public override string ToString()
        {
            return name;
        }
    }
}
