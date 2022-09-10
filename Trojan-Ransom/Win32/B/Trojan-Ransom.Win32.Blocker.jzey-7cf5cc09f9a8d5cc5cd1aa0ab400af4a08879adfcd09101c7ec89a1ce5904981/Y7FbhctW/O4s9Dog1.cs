using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.MyServices;

namespace Y7FbhctW;

internal class O4s9Dog1
{
	internal static FileSystemProxy jghAQYJA(ServerComputer serverComputer_0, int int_0)
	{
		return (FileSystemProxy)((int_0 ^ 0x4985) switch
		{
			_ => serverComputer_0.get_FileSystem(), 
		});
	}

	internal static void kPowsRxh(FileSystemProxy fileSystemProxy_0, string string_0, string string_1, bool bool_0, int int_0)
	{
		switch (int_0 ^ 0xC5CB)
		{
		}
		fileSystemProxy_0.WriteAllText(string_0, string_1, bool_0);
	}

	internal static string cI1h7tEI(int int_0, int int_1)
	{
		return (int_1 ^ 0x6574) switch
		{
			_ => Conversions.ToString(int_0), 
		};
	}

	internal static bool OXfQUqdH(string string_0, int int_0)
	{
		return (int_0 ^ 0x358B) switch
		{
			_ => bool.Parse(string_0), 
		};
	}

	internal static int omw1O9f7(string string_0, int int_0)
	{
		return (int_0 ^ 0x56E7) switch
		{
			_ => int.Parse(string_0), 
		};
	}

	internal static double Q8v2k7IN(double double_0, double double_1, int int_0)
	{
		return (int_0 ^ 0xD31) switch
		{
			_ => Math.Pow(double_0, double_1), 
		};
	}

	internal static double zxrdwZWP(double double_0, int int_0)
	{
		return (int_0 ^ 0x9E6A) switch
		{
			_ => Math.Round(double_0), 
		};
	}

	internal static void CzLTISFT(FileSystemProxy fileSystemProxy_0, string string_0, int int_0)
	{
		switch (int_0 ^ 0xBCDE)
		{
		}
		fileSystemProxy_0.CreateDirectory(string_0);
	}

	internal static string BG85lvs2(int int_0)
	{
		return (int_0 ^ 0xA6F8) switch
		{
			_ => Application.get_StartupPath(), 
		};
	}

	internal static StreamWriter sTrZYBnH(Process process_0, int int_0)
	{
		return (int_0 ^ 0xF809) switch
		{
			_ => process_0.StandardInput, 
		};
	}

	internal static void erhmZZbp(TextWriter textWriter_0, string string_0, int int_0)
	{
		switch (int_0 ^ 0xE717)
		{
		}
		textWriter_0.WriteLine(string_0);
	}

	internal static ProcessStartInfo qGpfompX(Process process_0, int int_0)
	{
		return (int_0 ^ 0x1688) switch
		{
			_ => process_0.StartInfo, 
		};
	}

	internal static void sBrEZDs4(ProcessStartInfo processStartInfo_0, bool bool_0, int int_0)
	{
		switch (int_0 ^ 0xFD78)
		{
		default:
			processStartInfo_0.RedirectStandardOutput = bool_0;
			break;
		case 1:
			processStartInfo_0.RedirectStandardInput = bool_0;
			break;
		case 2:
			processStartInfo_0.UseShellExecute = bool_0;
			break;
		case 3:
			processStartInfo_0.CreateNoWindow = bool_0;
			break;
		}
	}

	internal static bool smethod_0(Process process_0, int int_0)
	{
		return (int_0 ^ 0xB1D8) switch
		{
			_ => process_0.Start(), 
		};
	}

	internal static void c4EhBjUB(Process process_0, int int_0)
	{
		switch (int_0 ^ 0xA0C7)
		{
		}
		process_0.WaitForExit();
	}

	internal static void vJEE6dE6(ProcessStartInfo processStartInfo_0, string string_0, int int_0)
	{
		switch (int_0 ^ 0xADA9)
		{
		}
		processStartInfo_0.FileName = string_0;
	}

	internal static StreamReader utxmaIHB(Process process_0, int int_0)
	{
		return (int_0 ^ 0x2EFA) switch
		{
			_ => process_0.StandardOutput, 
		};
	}

	internal static string YciAeyRu(StreamReader streamReader_0, int int_0)
	{
		return (int_0 ^ 0xB0F7) switch
		{
			1 => streamReader_0.ReadLine(), 
			_ => streamReader_0.ReadToEnd(), 
		};
	}

	internal static void On3jH8m9(IDisposable idisposable_0, int int_0)
	{
		switch (int_0 ^ 0xF9E5)
		{
		}
		idisposable_0.Dispose();
	}

	internal static double HP9gYOXQ(string string_0, int int_0)
	{
		return (int_0 ^ 0x11BE) switch
		{
			_ => Conversions.ToDouble(string_0), 
		};
	}
}
