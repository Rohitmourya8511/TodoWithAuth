using TodoWithAuth.Models;
using System.Collections.Generic;
using System.Linq;

namespace TodoWithAuth.Services
{
    public class TodoService : ITodoService
    {
        private static List<TodoItem> _todos = new List<TodoItem>();

        public IEnumerable<TodoItem> GetAll()
        {
            return _todos;
        }

        public void Add(TodoItem item)
        {
            item.Id = _todos.Any() ? _todos.Max(x => x.Id) + 1 : 1;
            _todos.Add(item);
        }

        public void Complete(int id)
        {
            var item = _todos.FirstOrDefault(x => x.Id == id);
            if (item != null)
            {
                item.Completed = true;
            }
        }

        public void Incomplete(int id)
        {
            var item = _todos.FirstOrDefault(x => x.Id == id);
            if (item != null)
            {
                item.Completed = false;
            }
        }

        public void Delete(int id)
        {
            var item = _todos.FirstOrDefault(x => x.Id == id);
            if (item != null)
            {
                _todos.Remove(item);
            }
        }

        public TodoItem GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(TodoItem item)
        {
            throw new NotImplementedException();
        }
    }
}
