using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CO8_UniversityClass
{
    internal class Course
    {
        private string _code;
        private string _title;
        private int _credit;

        public string Code
        {
            get => _code;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Code cannot be null or empty");
                _code = value.Trim();
            }
        }

        public string Title
        {
            get => _title;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Title cannot be null or empty");
                _title = value.Trim();
            }
        }

        public int Credit
        {
            get => _credit;
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException(nameof(Credit), "Credit must be greater than 0");
                _credit = value;
            }
        }

        public Course(string code, string title, int credit)
        {
            Code = code;
            Title = title;
            Credit = credit;
        }

        public override string ToString() => $"{Code} - {Title} ({Credit} credits)";
    }
}
