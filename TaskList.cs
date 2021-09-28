using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Choose_Your_Class
{
	

	public class TaskList
	{
		public List<Task> MyList = new List<Task>();
		string divider = new string('-', 30);
		public void AddTask(Task newTask)
		{
			// adds task to the task list
			MyList.Add(newTask);
		}

		public void RemoveTask(Task chosenTask)
		{
			// removes task from the task list
			MyList.Remove(chosenTask);
		}

		public Task ChooseTask()
		{
			// chooses a task to be acted upon
			Console.WriteLine("Select a task:");
			for (int i = 0; i < MyList.Count; i++)
			{
				Console.WriteLine(i+1 + "." + MyList[i].Description);
			}

			int index = Convert.ToInt32(Console.ReadLine())-1;
			return MyList[index];
		}

		public void getStatusAll()
		{

			Console.WriteLine("Task Status List");
			Console.WriteLine(divider);
			Console.WriteLine("Due Date\tImportance\tUrgency\t\tComplete?");

			for (int i = 0; i < MyList.Count; i++)
			{
				Console.WriteLine($"Descr: {MyList[i].Description}");
				Console.WriteLine($"{MyList[i].DueDate}\t\t{MyList[i].Importance}\t\t{MyList[i].Urgency}\t\t{MyList[i].IsComplete}");
				Console.WriteLine();
			}
			Console.ReadLine();
		}
	}
}
