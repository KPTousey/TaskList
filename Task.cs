namespace Choose_Your_Class
{
	public class Task
	{

		public string Description { get; set; }
		public string DueDate { get; set; }
		public int Importance { get; set; }
		public int Urgency { get; set; }
		public bool IsComplete { get; set; }

		public Task()
		{

		}

		public Task(string description, string dueDate)
		{
			this.Description = description;
			this.DueDate = dueDate;
			this.IsComplete = false;
		}

		public void MarkComplete(Task chosenTask)
		{
			chosenTask.IsComplete = true;
		}

		public void ChangeUrgency(int value)
		{
			if (value > 5)
			{
				this.Urgency = 5;
			} else if (value < 1)
			{
				this.Urgency = 1;
			}  else
			{
				this.Urgency = value;
			}
				
		}
		public void ChangeImportance(int value)
		{
			if (value > 5)
			{
				this.Importance = 5;
			}
			else if (value < 1)
			{
				this.Importance = 1;
			}
			else
			{
				this.Importance = value;
			}
		}

	}
}
