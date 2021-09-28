using System;

namespace Choose_Your_Class
{
	public class Program
    {
        public static void Main(string[] args)
        {
            TaskList taskList = new TaskList();
            Task testTask = new Task("Rake the leaves", "092821", 5, 1);
            bool useList = true;

			Console.WriteLine("Building Maintenance List Manager");
			Console.WriteLine("Create your list of prioritized tasks...");
            string divider = new string('-', 30);
			Task task = null;
			int newValue;

			while (useList)
			{
				Console.WriteLine("OPTIONS:");
				Console.WriteLine(divider);
				Console.WriteLine("1. Create task");
				Console.WriteLine("2. View status of all tasks");
				Console.WriteLine("3. Mark task complete");
				Console.WriteLine("4. Change task difficulty(1-5)");
				Console.WriteLine("5. Change task urgency(1-5)");
				Console.WriteLine("6. Remove task");
				Console.WriteLine("q. Quit");
				Console.WriteLine(divider);

				Console.WriteLine("Enter choice:");
				char choice = Convert.ToChar(Console.ReadLine().ToLower());
				switch (choice)
				{
					case '1':
						// create task
						CreateTask(taskList);
						break;	
					case '2':
						taskList.getStatusAll();
						// view status of all tasks
						break;	
					case '3':
						// mark task complete
						testTask.MarkComplete(taskList.ChooseTask());
						break;	
					case '4':
						// change task importance
						Console.WriteLine("Enter a new importance value(1-5)");
						newValue = Convert.ToInt32(Console.ReadLine());
						task = taskList.ChooseTask();
						task.ChangeImportance(newValue);
						break;	
					case '5':
						// change task urgency
						Console.WriteLine("Enter a new urgency value(1-5)");
						newValue = Convert.ToInt32(Console.ReadLine());
						task = taskList.ChooseTask();
						task.ChangeUrgency(newValue);
						break;
					case '6':
						// remove task
						taskList.RemoveTask(taskList.ChooseTask());
						break;
					case 'q':
						// quit
						useList = false;
						break;
					default:
						Console.WriteLine("Sorry, that wasn't a valid choice.");
						break;
				}
			}
            
        }

		static void CreateTask(TaskList taskList)
		{
			Console.WriteLine("Enter description:");
			string description = Console.ReadLine();
			
			Console.WriteLine("Enter due date (mmddyy):");
			string dueDate = Console.ReadLine();

			Console.WriteLine("Enter estimated importance (1-5):");
			int importance = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Enter estimated urgency (1-5):");
			int urgency = Convert.ToInt32(Console.ReadLine());

			Task myTask = new Task(description, dueDate, importance, urgency);

			taskList.AddTask(myTask);
		}
	}
}