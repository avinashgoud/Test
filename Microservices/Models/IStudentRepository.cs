using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using MongoDB.Driver;

namespace Microservices.Model
{
    public interface IStudentRepository
    {
        Task<IEnumerable<Student>> GetAll();
        Task<Student> Get(string id);
        Task Add(Student student);
        Task<string> Update(string id , Student student);
        Task<DeleteResult> Remove(string id);
        Task<DeleteResult> RemoveAll();
    }
}
