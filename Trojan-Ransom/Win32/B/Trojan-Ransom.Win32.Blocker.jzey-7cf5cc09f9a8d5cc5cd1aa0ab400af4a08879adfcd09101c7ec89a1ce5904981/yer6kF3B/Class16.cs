using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Text;
using System.Xml;

namespace yer6kF3B;

internal class Class16
{
	internal static int pjIk8vHc(XmlTextReader xmlTextReader_0, int int_0)
	{
		return (int_0 ^ 0x8C2F) switch
		{
			_ => xmlTextReader_0.Depth, 
		};
	}

	internal static string xRdCrvAc(XmlTextReader xmlTextReader_0, int int_0)
	{
		return (int_0 ^ 0xCDEE) switch
		{
			1 => xmlTextReader_0.Name, 
			_ => xmlTextReader_0.Value, 
		};
	}

	internal static bool smethod_0(XmlTextReader xmlTextReader_0, int int_0)
	{
		return (int_0 ^ 0x6CCD) switch
		{
			_ => xmlTextReader_0.Read(), 
		};
	}

	internal static bool sORddYuc(XmlTextReader xmlTextReader_0, string string_0, int int_0)
	{
		return (int_0 ^ 0x4E88) switch
		{
			_ => xmlTextReader_0.MoveToAttribute(string_0), 
		};
	}

	internal static void ufTFzFyL(ArrayList arrayList_0, int int_0)
	{
		switch (int_0 ^ 0xF567)
		{
		}
		arrayList_0.Clear();
	}

	internal static int MnIpuB8b(BinaryReader binaryReader_0, int int_0)
	{
		return (int_0 ^ 0xC4D9) switch
		{
			_ => binaryReader_0.ReadInt32(), 
		};
	}

	internal static void kyNq7GLZ(ArrayList arrayList_0, ICollection icollection_0, int int_0)
	{
		switch (int_0 ^ 0x36CD)
		{
		}
		arrayList_0.AddRange(icollection_0);
	}

	internal static string neRkDuZz(string string_0, char[] char_0, int int_0)
	{
		return (int_0 ^ 0x29FC) switch
		{
			_ => string_0.TrimEnd(char_0), 
		};
	}

	internal static void n18cBVCn(ArrayList arrayList_0, object object_0, int int_0)
	{
		switch (int_0 ^ 0xA905)
		{
		}
		arrayList_0.Remove(object_0);
	}

	internal static void m8yFGwZR(AppDomain appDomain_0, ResolveEventHandler resolveEventHandler_0, int int_0)
	{
		switch (int_0 ^ 0x939D)
		{
		default:
			appDomain_0.AssemblyResolve += resolveEventHandler_0;
			break;
		case 1:
			appDomain_0.ResourceResolve += resolveEventHandler_0;
			break;
		}
	}

	internal static Assembly FFTEa34N(byte[] byte_0, int int_0)
	{
		return (int_0 ^ 0xBC3E) switch
		{
			_ => Assembly.Load(byte_0), 
		};
	}

	internal static string tThlOe8i(ResolveEventArgs resolveEventArgs_0, int int_0)
	{
		return (int_0 ^ 0x898C) switch
		{
			_ => resolveEventArgs_0.Name, 
		};
	}

	internal static byte[] n92tsWAo(Encoding encoding_0, string string_0, int int_0)
	{
		return (int_0 ^ 0xF63B) switch
		{
			_ => encoding_0.GetBytes(string_0), 
		};
	}

	internal static string Wq3Y85iR(byte[] byte_0, int int_0)
	{
		return (int_0 ^ 0x9410) switch
		{
			_ => Convert.ToBase64String(byte_0), 
		};
	}

	internal static Assembly f0EYAloj(int int_0)
	{
		return (int_0 ^ 0xEACB) switch
		{
			_ => Assembly.GetExecutingAssembly(), 
		};
	}

	internal static Stream WlJHEhz8(Assembly assembly_0, string string_0, int int_0)
	{
		return (int_0 ^ 0xA4CA) switch
		{
			_ => assembly_0.GetManifestResourceStream(string_0), 
		};
	}

	internal static long smethod_1(Stream stream_0, int int_0)
	{
		return (int_0 ^ 0xE327) switch
		{
			_ => stream_0.Length, 
		};
	}

	internal static int smethod_2(BinaryReader binaryReader_0, byte[] byte_0, int int_0, int int_1, int int_2)
	{
		return (int_2 ^ 0xF96) switch
		{
			_ => binaryReader_0.Read(byte_0, int_0, int_1), 
		};
	}

	internal static void Ap5NzaH2(Array array_0, int int_0, Array array_1, int int_1, int int_2, int int_3)
	{
		switch (int_3 ^ 0xD3C7)
		{
		}
		Array.Copy(array_0, int_0, array_1, int_1, int_2);
	}

	internal static Stream KJw7dSJF(BinaryReader binaryReader_0, int int_0)
	{
		return (int_0 ^ 0x6972) switch
		{
			_ => binaryReader_0.BaseStream, 
		};
	}
}
