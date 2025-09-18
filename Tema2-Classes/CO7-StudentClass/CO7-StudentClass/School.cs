using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CO7_StudentClass
{
    internal class School
    {
        private readonly List<Student> _students = new();

        public IReadOnlyList<Student> Students => _students.AsReadOnly();

        public void AddStudent(Student s)
        {
            if (s is null) throw new ArgumentNullException(nameof(s), "Student cannot be null.");
            _students.Add(s);
        }

        public void RemoveStudent(string fullName)
        {
            if (string.IsNullOrWhiteSpace(fullName)) return;
            _students.RemoveAll(s => string.Equals(s.FullName, fullName, StringComparison.OrdinalIgnoreCase));
        }

        public IEnumerable<Student> FindStudent(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword)) return Enumerable.Empty<Student>();
            return _students
                .Where(s => s.FullName.Contains(keyword, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        public List<Student> GetTopStudents(int count)
        {
            if (count <= 0) return new List<Student>();
            return _students
                .OrderByDescending(s => s.Grade)
                .Take(Math.Min(count, _students.Count))
                .ToList();
        }

        public double GetAverageGrade()
        {
            return _students.Count == 0 ? 0.0 : _students.Average(s => s.Grade);
        }

        public override string ToString()
            => $"School has {_students.Count} students. Average grade: {GetAverageGrade():F2}";
    }
}

