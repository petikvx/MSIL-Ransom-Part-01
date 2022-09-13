using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace Ionic.Zip;

internal static class SharedUtilities
{
	private static Regex doubleDotRegex1;

	private static Encoding ibm437;

	private static Encoding utf8;

	public static extern long GetFileLength(string fileName);

	[Conditional("NETCF")]
	public static extern void Workaround_Ladybug318918(Stream s);

	private static string SimplifyFwdSlashPath(string path)
	{
		return (string)/*OpCode not supported: Nop*/;
	}

	public static string NormalizePathForUseInZipFile(string pathName)
	{
		//Discarded unreachable code: IL_000b
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		int num = checked((int)/*Error near IL_0002: Stack underflow*/);
		_ = /*Error near IL_0006: Stack underflow*/^ num;
		/*Error near IL_0006: Invalid metadata token*/;
	}

	internal static extern byte[] StringToByteArray(string value, Encoding encoding);

	internal unsafe static byte[] StringToByteArray(string value)
	{
		//IL_0003: Invalid comparison between Unknown and F8
		while (true)
		{
			double num = *(double*)null;
			if (!((double)/*Error near IL_0008: Stack underflow*/ <= num))
			{
				if (checked((ushort)/*Error near IL_0009: Stack underflow*/) != 0)
				{
					/*Error near IL_000f: Unknown opcode: 0xF9*/;
				}
				*(_003F*)(nint)/*Error near IL_0011: Stack underflow*/ = /*Error near IL_0011: Stack underflow*/;
				if (/*Error near IL_0016: Stack underflow*/ <= /*Error near IL_0016: Stack underflow*/)
				{
					break;
				}
			}
		}
		/*Error near IL_0018: ldarg 2 (out-of-bounds)*/;
		/*Error near IL_0019: Invalid metadata token*/;
	}

	internal static extern string Utf8StringFromBuffer(byte[] buf);

	internal static extern string StringFromBuffer(byte[] buf, Encoding encoding);

	internal static extern int ReadSignature(Stream s);

	internal static int ReadEntrySignature(Stream s)
	{
		//Discarded unreachable code: IL_000a, IL_0012, IL_001b
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		double num = (double)/*Error near IL_0001: Stack underflow*/;
		checked
		{
			_ = (nuint)(/*Error near IL_0003: Stack underflow*/ + num);
			/*Error near IL_0005: Invalid metadata token*/;
		}
	}

	internal static extern int ReadInt(Stream s);

	private static extern int _ReadFourBytes(Stream s, string message);

	internal static extern long FindSignature(Stream stream, int SignatureToFind);

	internal static extern DateTime AdjustTime_Reverse(DateTime time);

	internal static extern DateTime PackedToDateTime(int packedDateTime);

	internal static extern int DateTimeToPacked(DateTime time);

	public static extern void CreateAndOpenUniqueTempFile(string dir, out Stream fs, out string filename);

	public static string InternalGetTempFileName()
	{
		//Discarded unreachable code: IL_0006, IL_000c, IL_0016, IL_0017, IL_001c, IL_0021
		//IL_0007: Invalid comparison between Unknown and I4
		while (true)
		{
		}
	}

	internal static extern int ReadWithRetry(Stream s, byte[] buffer, int offset, int count, string FileName);

	private static extern uint _HRForException(Exception ex1);
}
