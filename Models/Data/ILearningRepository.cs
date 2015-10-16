using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Data
{
    public interface ILearningRepository
    {
        IQueryable<Subject> GetAllSubjects();
        Subject GetSubject(int subjectId);

        IQueryable<Course> GetCoursesBySubject(int subjectId);
        IQueryable<Course> GetCourses();
        Course GetCourse(int courseId);
        bool CourseExists(int courseId);

        IQueryable<Student> GetAllStudentsWithEnrollments();
        IQueryable<Student> GetAllStudentsSummary();

        IQueryable<Student> GetEnrolledStudentsInCourse(int courseId);
        Student GetStudentEnrollments(string userName);
        Student GetStudentEnrollments(int studentId);
        Student GetStudent(string userName);

        Tutor GetTutor(int tutorId);
        
        bool LoginStudent(string userName, string password);

        bool Insert(Student student);
        bool Update(Student originalStudent, Student updatedStudent);
        bool Delete(int studentId);

        int EnrollStudentInCourse(int studentId, int courseId, Enrollment enrollment);

        bool Insert(Course course);
        bool Update(Course originalCourse, Course updatedCourse);
        bool DeleteCourse(int courseId);

        bool SaveAll();

    }
}
