using System;
using System.Collections.Generic;
using System.Linq;

namespace CO8_UniversityClass
{
    internal class University
    {
        private readonly List<Student> _students = new();
        private readonly List<Faculty> _faculties = new();

        public string Name { get; }

      
        public IReadOnlyList<Student> Students => _students.AsReadOnly();
        public IReadOnlyList<Faculty> Faculties => _faculties.AsReadOnly();

        public University(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("University name cannot be empty.");
            Name = name.Trim();
        }

        
        public void AddStudent(Student s)
        {
            if (s == null) throw new ArgumentNullException(nameof(s));
            if (_students.Any(st => st.Id == s.Id))
                throw new InvalidOperationException($"Student with Id {s.Id} already exists.");
            _students.Add(s);
        }

      
        public void AddFaculty(Faculty f)
        {
            if (f == null) throw new ArgumentNullException(nameof(f));
            if (_faculties.Any(fac => fac.Name.Equals(f.Name, StringComparison.OrdinalIgnoreCase)))
                throw new InvalidOperationException($"Faculty {f.Name} already exists.");
            _faculties.Add(f);
        }

        public IEnumerable<Student> FindStudents(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
                return Enumerable.Empty<Student>();

            return _students
                .Where(s => s.FullName.Contains(keyword, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

       
        public Faculty FindFaculty(string name)
        {
            return _faculties
                .FirstOrDefault(f => f.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

        public override string ToString()
        {
            return $"University: {Name} | Students: {_students.Count}, Faculties: {_faculties.Count}";
        }
    }
}
