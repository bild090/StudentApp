using StudentApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentApp.EntityFrameworkCore.Contract
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetAll();
        Student GetById(int studentId);
        void Insert(Student student);
        void Update(Student student);
        void Delete(int studentId);
        void Save();
        bool IsExisit(int studentId);
        Student GetStudentLevelObj(int studentId);
    }
}
