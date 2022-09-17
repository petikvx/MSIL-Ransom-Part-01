#define TRACE
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace CiscoAnyconnectControl.Utility;

public static class Util
{
	public static string AssemblyDirectory => Util.smethod_1(FullAssemblyPath);

	public static string FullAssemblyPath
	{
		get
		{
			string string_ = Util.smethod_3(Util.smethod_2());
			if (!Util.smethod_4(string_, "file:///"))
			{
				return Util.smethod_9(Util.smethod_8());
			}
			string string_2 = Util.smethod_6(string_, Util.smethod_5("file:///"));
			return Util.smethod_7(string_2, '/', '\\');
		}
	}

	public static string AssemblyName => Util.smethod_10(FullAssemblyPath);

	public static bool CheckForCiscoProcesses(bool close = false)
	{
		List<Process> list = Util.smethod_11().Where(delegate(Process p)
		{
			string text = Util.smethod_20(p);
			string string_ = text;
			return (Util.smethod_21(string_, "vpncli") || Util.smethod_21(string_, "vpnui")) ? true : false;
		}).ToList();
		if (close)
		{
			foreach (Process item in list)
			{
				try
				{
					Util.smethod_12(item);
					Util.smethod_13(item, 50);
					Util.smethod_14(item);
				}
				catch (Exception ex)
				{
					TraceException("Error closing cisco process:", ex);
					return false;
				}
			}
			list.Clear();
		}
		return list.Count == 0;
	}

	public static void TraceException(string line1, Exception ex)
	{
		Util.smethod_19(Util.smethod_18("{0}: {1}\nMessage: {2}\nStack Trace:\n{3}", new object[4]
		{
			line1,
			Util.smethod_15(ex),
			Util.smethod_16(ex),
			Util.smethod_17(ex)
		}));
	}

	[CompilerGenerated]
	internal static bool smethod_0(Process p)
	{
		string text = Util.smethod_20(p);
		string string_ = text;
		if (!Util.smethod_21(string_, "vpncli") && !Util.smethod_21(string_, "vpnui"))
		{
			return false;
		}
		return true;
	}

	static string smethod_1(string string_0)
	{
		return Path.GetDirectoryName(string_0);
	}

	static Assembly smethod_2()
	{
		return Assembly.GetEntryAssembly();
	}

	static string smethod_3(Assembly assembly_0)
	{
		return assembly_0.CodeBase;
	}

	static bool smethod_4(string string_0, string string_1)
	{
		return string_0.StartsWith(string_1);
	}

	static int smethod_5(string string_0)
	{
		return string_0.Length;
	}

	static string smethod_6(string string_0, int int_0)
	{
		return string_0.Substring(int_0);
	}

	static string smethod_7(string string_0, char char_0, char char_1)
	{
		return string_0.Replace(char_0, char_1);
	}

	static Assembly smethod_8()
	{
		return Assembly.GetExecutingAssembly();
	}

	static string smethod_9(Assembly assembly_0)
	{
		return assembly_0.Location;
	}

	static string smethod_10(string string_0)
	{
		return Path.GetFileName(string_0);
	}

	static Process[] smethod_11()
	{
		return Process.GetProcesses();
	}

	static bool smethod_12(Process process_0)
	{
		return process_0.CloseMainWindow();
	}

	static bool smethod_13(Process process_0, int int_0)
	{
		return process_0.WaitForExit(int_0);
	}

	static void smethod_14(Process process_0)
	{
		process_0.Kill();
	}

	static Type smethod_15(Exception exception_0)
	{
		return exception_0.GetType();
	}

	static string smethod_16(Exception exception_0)
	{
		return exception_0.Message;
	}

	static string smethod_17(Exception exception_0)
	{
		return exception_0.StackTrace;
	}

	static string smethod_18(string string_0, object[] object_0)
	{
		return string.Format(string_0, object_0);
	}

	static void smethod_19(string string_0)
	{
		Trace.TraceError(string_0);
	}

	static string smethod_20(Process process_0)
	{
		return process_0.ProcessName;
	}

	static bool smethod_21(string string_0, string string_1)
	{
		return string_0 == string_1;
	}
}
