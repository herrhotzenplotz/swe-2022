using System;

namespace Program
{
	public class Archive
	{
		public uint   ID      { private set; get; }
		public string Label   { private set; get; }
		public string Content { private set; get; }

		private static uint ID_Counter = 0;

		public Archive(string Label, string Content)
		{
			this.Label = Label;
			this.Content = Content;
			this.ID = ID_Counter++;
		}
	}
}
