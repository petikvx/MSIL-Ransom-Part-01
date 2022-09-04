using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace ns4;

internal class Class18
{
	internal static void smethod_0(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2)
	{
		switch (int_2 ^ 0x485D)
		{
		}
		stream_0.Write(byte_0, int_0, int_1);
	}

	internal static long smethod_1(Stream stream_0, int int_0)
	{
		return (int_0 ^ 0x4852) switch
		{
			1 => stream_0.Length, 
			_ => stream_0.Position, 
		};
	}

	internal static void smethod_2(Stream stream_0, int int_0)
	{
		switch (int_0 ^ 0x89CB)
		{
		default:
			stream_0.Flush();
			break;
		case 1:
			stream_0.Close();
			break;
		}
	}

	internal static void smethod_3(Stream stream_0, byte byte_0, int int_0)
	{
		switch (int_0 ^ 0x47E)
		{
		}
		stream_0.WriteByte(byte_0);
	}

	internal static bool smethod_4(string string_0, string string_1, int int_0)
	{
		return (int_0 ^ 0x9769) switch
		{
			_ => string_0.StartsWith(string_1), 
		};
	}

	internal static bool smethod_5(string string_0, string string_1, int int_0)
	{
		return (int_0 ^ 0x60D6) switch
		{
			1 => string_0 == string_1, 
			_ => string_0 != string_1, 
		};
	}

	internal static Encoding smethod_6(int int_0)
	{
		return (int_0 ^ 0xE825) switch
		{
			1 => Encoding.ASCII, 
			_ => Encoding.UTF8, 
		};
	}

	internal static byte[] smethod_7(BinaryReader binaryReader_0, int int_0, int int_1)
	{
		return (int_1 ^ 0x6C4) switch
		{
			_ => binaryReader_0.ReadBytes(int_0), 
		};
	}

	internal static string smethod_8(Encoding encoding_0, byte[] byte_0, int int_0)
	{
		return (int_0 ^ 0x269E) switch
		{
			_ => encoding_0.GetString(byte_0), 
		};
	}

	internal static string smethod_9(int int_0)
	{
		return (int_0 ^ 0x6836) switch
		{
			_ => Application.get_ExecutablePath(), 
		};
	}

	internal static string smethod_10(string string_0, string string_1, string string_2, int int_0)
	{
		return (int_0 ^ 0x8549) switch
		{
			_ => string_0 + string_1 + string_2, 
		};
	}

	internal static Process smethod_11(string string_0, string string_1, int int_0)
	{
		return (int_0 ^ 0xD017) switch
		{
			_ => Process.Start(string_0, string_1), 
		};
	}

	internal static DialogResult smethod_12(Form form_0, int int_0)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		return (DialogResult)((int_0 ^ 0x136A) switch
		{
			_ => form_0.ShowDialog(), 
		});
	}

	internal static string smethod_13(string string_0, int int_0, int int_1)
	{
		return (int_1 ^ 0x5199) switch
		{
			_ => string_0.Substring(int_0), 
		};
	}

	internal static Assembly smethod_14(int int_0)
	{
		return (int_0 ^ 0x4047) switch
		{
			_ => Assembly.GetExecutingAssembly(), 
		};
	}

	internal static Stream smethod_15(Assembly assembly_0, string string_0, int int_0)
	{
		return (int_0 ^ 0x52D2) switch
		{
			_ => assembly_0.GetManifestResourceStream(string_0), 
		};
	}

	internal static bool smethod_16(BinaryReader binaryReader_0, int int_0)
	{
		return (int_0 ^ 0x99C9) switch
		{
			_ => binaryReader_0.ReadBoolean(), 
		};
	}

	internal static MD5 smethod_17(int int_0)
	{
		return (int_0 ^ 0xB9F8) switch
		{
			_ => MD5.Create(), 
		};
	}

	internal static MethodInfo smethod_18(Assembly assembly_0, int int_0)
	{
		return (int_0 ^ 0xC41E) switch
		{
			_ => assembly_0.EntryPoint, 
		};
	}

	internal static object smethod_19(MethodBase methodBase_0, object object_0, object[] object_1, int int_0)
	{
		return (int_0 ^ 0xAFE8) switch
		{
			_ => methodBase_0.Invoke(object_0, object_1), 
		};
	}
}
