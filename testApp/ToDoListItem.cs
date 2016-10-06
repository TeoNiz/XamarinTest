﻿using System;
using SQLite;

namespace testApp
{
	public class ToDoListItem
	{
		[PrimaryKey,AutoIncrement]
		public int ID { get; set; }
		public string title { get; set; }
		public string content { get; set; }
		public string alpha { get; set; }
	}
}
