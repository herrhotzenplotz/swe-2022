using System;
using System.IO;
using System.Threading;

namespace Program
{
	class Computer
	{
		public Computer()
		{
			this.UserName = "Administrator";
			this.Random = new Random();
			this.HasCrashed = false;
		}

		public void SaveFile(string filePath, string fileName)
		{
			int randomNumber = this.Random.Next();
			if (this.HasCrashed || (randomNumber % 4 == 0)) {
				this.HasCrashed = true;
				throw new InvalidOperationException("Failed to save file");
			}

			string path = Path.Combine(filePath, fileName);
			Console.WriteLine("Saving file: {0}", path);
		}

		public void SaveFile(string fileName)
		{
			SaveFile("C:\\Users\\Desktop", fileName);
		}

		public void SwitchUser(string newUserName)
		{
			Console.WriteLine("Logging out...");
			Thread.Sleep(100);
			Console.WriteLine("Logging in as {0}", newUserName);
			this.UserName = newUserName;
		}

		public void Reboot()
		{
			Console.WriteLine("Rebooting...");
			this.HasCrashed = false;
		}

		public void Archive(string Label, string Content, out Archive it)
		{
			it = new Archive(Label, Content);
			Console.WriteLine("*Archiving data ...*");
		}

		public void Print()
		{
			Console.WriteLine("Computer: User = {0}, HasCrashed = {1}, IP Addr = {2}", UserName, HasCrashed, IPAddress);
		}

		public string UserName   {get; private set;}
		public bool   HasCrashed {get; private set;}

		public string IPAddress
		{
			get
			{
				return IPTools.InAddrToString(this.InAddr);
			}

			set
			{
				this.InAddr = IPTools.ToInAddr(value);
			}
		}

		private Random Random;
		private byte[] InAddr = IPTools.LocalHost;
	}
}
