using TaskAPI.Models;

namespace TaskAPI.Services.Todos
{
    public class TodoService : ITodoRepository
    {
        //Get Todos
        public List<Todo> AllTodos(int authorId)
        {
            var todos = new List<Todo>();

            var todo1 = new Todo
            {
                Id = 1,
                Title = "Test Title 01",
                Description = "Test Description 01",
                CreatedDate = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                Status = TodoStatus.New

            };
            todos.Add(todo1);

            var todo2 = new Todo
            {
                Id = 2,
                Title = "Test Title 01",
                Description = "Test Description 01",
                CreatedDate = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                Status = TodoStatus.New

            };

            todos.Add(todo2);

            var todo3 = new Todo
            {
                Id = 3,
                Title = "Test Title 01",
                Description = "Test Description 01",
                CreatedDate = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                Status = TodoStatus.New

            };
            todos.Add(todo3);

            return todos;
        }

  
        public Todo GetTodo(int authorId, int id)
        {
            throw new NotImplementedException();
        }
    }
}