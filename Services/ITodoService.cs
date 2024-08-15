using System.Collections.Generic;
using TodoWithAuth.Models;

namespace TodoWithAuth.Services
{
    public interface ITodoService
    {
        IEnumerable<TodoItem> GetAll();
        TodoItem GetById(int id);
        void Add(TodoItem item);
        void Update(TodoItem item);
        void Delete(int id);
        void Complete(int id);
        void Incomplete(int id);
    }
}
