﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    public class Course
    {
        public Course()
        {
            Enrollments = new List<Enrollment>();
            CourseTutor = new Tutor();
            CourseSubject = new Subject();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public double Duration { get; set; }
        public string Description { get; set; }
        public Tutor CourseTutor { get; set; }
        public Subject CourseSubject { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
