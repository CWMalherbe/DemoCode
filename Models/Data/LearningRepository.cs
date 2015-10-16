using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Data
{
    public class LearningRepository:ILearningRepository
    {
        private LearningContext _context;
        public LearningRepository(LearningContext context)
        {
            _context = context;
        }

        public IQueryable<Subject> GetAllSubjects()
        {
            return _context.Subjects.AsQueryable();
        }

        public Subject GetSubject(int subjectId)
        {
            return _context.Subjects.Find(subjectId);
        }

        public IQueryable<Course> GetCoursesBySubject(int subjectId)
        {
            return _context.Courses
                .Include("CourseSubject")
                .Include("CourseTutor")
                .Where(c => c.Id == subjectId)
                .AsQueryable();
        }

        public IQueryable<Course> GetCourses()
        {
            return _context.Courses
                .Include("CourseSubject")
                .Include("CourseTutor")
                .AsQueryable();
        }

        public Course GetCourse(int courseId)
        {
            throw new NotImplementedException();
        }

        public bool CourseExists(int courseId)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Student> GetAllStudentsWithEnrollments()
        {
            throw new NotImplementedException();
        }

        public IQueryable<Student> GetAllStudentsSummary()
        {
            throw new NotImplementedException();
        }

        public IQueryable<Student> GetEnrolledStudentsInCourse(int courseId)
        {
            throw new NotImplementedException();
        }

        public Student GetStudentEnrollments(string userName)
        {
            throw new NotImplementedException();
        }

        public Student GetStudentEnrollments(int studentId)
        {
            throw new NotImplementedException();
        }

        public Student GetStudent(string userName)
        {
            throw new NotImplementedException();
        }

        public Tutor GetTutor(int tutorId)
        {
            throw new NotImplementedException();
        }

        public bool LoginStudent(string userName, string password)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Student student)
        {
            throw new NotImplementedException();
        }

        public bool Update(Student originalStudent, Student updatedStudent)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int studentId)
        {
            throw new NotImplementedException();
        }

        public int EnrollStudentInCourse(int studentId, int courseId, Enrollment enrollment)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Course course)
        {
            throw new NotImplementedException();
        }

        public bool Update(Course originalCourse, Course updatedCourse)
        {
            throw new NotImplementedException();
        }

        public bool DeleteCourse(int courseId)
        {
            throw new NotImplementedException();
        }

        public bool SaveAll()
        {
            throw new NotImplementedException();
        }
    }
}
