namespace LarryClassLibrary
{
    public class TaskList
    {
        private string name;
        private List<Task> tasks;

        public TaskList(string name)
        {
            this.name = name;
            tasks = new List<Task>();
        }

        public string GetName()
        {
            return name;
        }

        public Task[] GetTasks()
        {
            return tasks.ToArray();
        }

        /// <summary>
        /// Добавляет задачу в список
        /// </summary>
        /// <param name="task">задача</param>
        public void AddTask(Task task)
        {
            tasks.Add(task);
        }

        public void Remove(Task task)
        {
            if (tasks.Contains(task))
            {
                tasks.Remove(task);
            }
        }

        public Task[] GetTasksByToday()
        {
            var result = new List<Task>();

            foreach (Task task in tasks)
            {
                if (task.Due == DateTime.Today)
                {
                    result.Add(task);
                }
            }

            return result.ToArray();
        }

        public Task[] GetTasksByFuture()
        {
            var result = new List<Task>();

            foreach (Task task in tasks)
            {
                if (task.Due > DateTime.Today)
                {
                    result.Add(task);
                }
            }

            return result.ToArray();
        }
    }
}
