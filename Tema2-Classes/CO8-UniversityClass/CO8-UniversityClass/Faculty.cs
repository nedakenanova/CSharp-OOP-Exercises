using System;
using System.Collections.Generic;
using System.Linq;

namespace CO8_UniversityClass
{
    internal class Faculty
    {
        private readonly List<Course> _courses = new();     
        public IReadOnlyList<Course> Courses => _courses.AsReadOnly(); 

        private string _name = "";
        public string Name
        {
            get => _name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Name cannot be null or empty.");
                _name = value.Trim();
            }
        }

        public Faculty(string name)
        {
            Name = name; 
        }

        public void AddCourse(Course course)
        {
            if (course is null) throw new ArgumentNullException(nameof(course));

           
            bool exists = _courses.Any(c =>
                string.Equals(c.Code, course.Code, StringComparison.OrdinalIgnoreCase));

            if (exists)
                throw new InvalidOperationException($"Course with code '{course.Code}' already exists in {Name}.");

            _courses.Add(course);
        }

        public override string ToString() => $"Faculty: {Name} (Courses: {_courses.Count})";
    }
}
