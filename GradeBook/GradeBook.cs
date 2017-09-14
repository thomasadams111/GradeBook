using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
    public class GradeBook
    {
        public GradeBook()
        {
            _name = "Empty";
            grades = new List<float>();
        }

        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        public GradeStatistics ComputeStatistics()
        {
            GradeStatistics stats = new GradeStatistics();

            float sum = 0;

            foreach (float grade in grades)
            {
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
                sum += grade;
            }

            stats.AverageGrade = sum / grades.Count;
            return stats;
        }

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                if(!string.IsNullOrEmpty(value))
                {
                    if(Name != value)
                    {
                        NameChangedEventArgs args = new NameChangedEventArgs();
                        args.exisitingName = _name;
                        args.newName = value;

                        NameChanged(this, args); // publish event
                    }

                    _name = value;
                }
            }
        }

        public event NameChangedDelegate NameChanged; // define event

        private string _name;

        private List<float> grades;
    }
}
