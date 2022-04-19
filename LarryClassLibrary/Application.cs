namespace LarryClassLibrary
{
    public class Application
    {
        public static Application? application;
        private List<TaskList> taskList;

        public Application()
        {
            taskList = new List<TaskList>();
        }

        public string[] GetTaskListNames()
        {
            return new string[] { };
        }

        /**public Task[] GetTasksByToday()
        {
            var result = new List<Task[]>();

            foreach (var task in taskList)
            {
                result.Add(task.GetTasksByToday());
            }

        }**/

        public static Application GetApplication
        {
            get
            {
                if (application == null)
                    application = new Application();

                return application;
            }
        }
    }
}