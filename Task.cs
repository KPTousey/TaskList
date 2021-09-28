namespace Choose_Your_Class
{
	class Task : TaskList
	{
		private int urgency;
		private int importance;

		public string Description { get; set; }
		public string DueDate { get; set; }
		public int Importance
		{
			get
			{
				return importance;
			}

			set
			{
				if (value > 5)
				{
					importance = 5;
				}
				else if (importance < 0)
				{
					importance = 0;
				}
			}
		}
		public int Urgency
		{
			get
			{
				return urgency;
			}

			set
			{
				if (value > 5)
				{
					urgency = 5;
				}
				else if (urgency < 0)
				{
					urgency = 0;
				}
			}
		}
		public bool IsComplete { get; set; }

		public Task(string description, string dueDate, int importance, int urgency)
		{
			this.Description = description;
			this.DueDate = dueDate;
			this.Importance = importance;
			this.Urgency = urgency;
			this.IsComplete = false;
		}

		public void MarkComplete(Task task)
		{
			task.IsComplete = true;
		}

		public void ChangeUrgency(int value)
		{
			if (value > 0 && value < 6)
			{
				this.Urgency = value;
			}
		}
		public void ChangeImportance(int value)
		{
			if (value > 0 && value < 6)
			{
				this.Importance = value;
			}
		}
	}
}
