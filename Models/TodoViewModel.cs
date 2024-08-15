using System.Collections.Generic;
using TodoWithAuth.Models;

namespace TodoWithAuth.Models
{
    public class TodoViewModel
    {
        public TodoItem NewTodo { get; set; }
        public IEnumerable<TodoItem> Todos { get; set; }

        public TodoViewModel()
        {
            NewTodo = new TodoItem("");
            Todos = new List<TodoItem>();
        }
    }
}
