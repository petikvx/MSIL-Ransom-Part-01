using System;
using System.Diagnostics;
using System.Threading;

internal class Class14
{
	public void method_0()
	{
		if (Class1.class2_0.bool_2)
		{
			try
			{
				if (Debugger.IsAttached)
				{
					method_3();
					return;
				}
			}
			catch
			{
			}
		}
		if (Class1.class2_0.bool_1)
		{
			try
			{
				foreach (string module in Process.GetCurrentProcess().Modules)
				{
					if (module.Contains("sbiedll.dll"))
					{
						method_3();
						return;
					}
				}
			}
			catch
			{
			}
		}
		if (Class1.class2_0.bool_3)
		{
			try
			{
				long ticks = DateTime.Now.Ticks;
				Thread.Sleep(15);
				if (DateTime.Now.Ticks - ticks < 15L)
				{
					method_3();
					return;
				}
			}
			catch
			{
			}
		}
		if (Class1.class2_0.bool_8)
		{
			try
			{
				if (Class1.class4_0.method_1("PROCMON"))
				{
					method_3();
					return;
				}
			}
			catch
			{
			}
		}
		if (Class1.class2_0.bool_9)
		{
			try
			{
				if (Class1.class4_0.method_1("REGMON"))
				{
					method_3();
					return;
				}
			}
			catch
			{
			}
		}
		if (Class1.class2_0.bool_0)
		{
			try
			{
				if (Class1.class4_0.method_1("CAIN"))
				{
					method_3();
					return;
				}
			}
			catch
			{
			}
		}
		if (Class1.class2_0.bool_6)
		{
			try
			{
				if (Class1.class4_0.method_1("NETMON"))
				{
					method_3();
					return;
				}
			}
			catch
			{
			}
		}
		if (Class1.class2_0.bool_10)
		{
			try
			{
				if (Class1.class4_0.method_1("TCPVIEW"))
				{
					method_3();
					return;
				}
			}
			catch
			{
			}
		}
		if (Class1.class2_0.bool_14)
		{
			try
			{
				if (Class1.class4_0.method_1("WIRESHARK"))
				{
					method_3();
					return;
				}
			}
			catch
			{
			}
		}
		if (Class1.class2_0.bool_7)
		{
			try
			{
				if (Class1.class13_0.method_6() == "Parallels Video Adapter")
				{
					method_3();
					return;
				}
			}
			catch
			{
			}
		}
		if (Class1.class2_0.bool_13)
		{
			try
			{
				if (Class1.class13_0.method_6() == "VMware SVGA II")
				{
					method_3();
					return;
				}
			}
			catch
			{
			}
		}
		if (Class1.class2_0.bool_11)
		{
			try
			{
				if (Class1.class13_0.method_6() == "VirtualBox Graphics Adapter")
				{
					method_3();
					return;
				}
			}
			catch
			{
			}
		}
		if (Class1.class2_0.bool_12)
		{
			try
			{
				string[] array = new string[2] { "VM Additions S3 Trio32/64", "S3 Trio32/64" };
				for (int i = 0; i < array.Length; i++)
				{
					if (Class1.class13_0.method_6() == array[i])
					{
						method_3();
						return;
					}
				}
			}
			catch
			{
			}
		}
		try
		{
			method_2();
		}
		catch
		{
		}
	}

	private void method_1()
	{
		Process[] processes = Process.GetProcesses();
		int num = 0;
		num = 0;
		while (true)
		{
			if (num <= processes.Length - 1)
			{
				string text;
				if ((text = processes[num].ProcessName.ToLower()) != null && text == "wireshark")
				{
					break;
				}
				num++;
				continue;
			}
			return;
		}
		method_3();
	}

	private void method_2()
	{
		Process[] processes = Process.GetProcesses();
		int num = 0;
		num = 0;
		while (true)
		{
			if (num <= processes.Length - 1)
			{
				string text;
				if ((text = processes[num].ProcessName.ToLower()) != null && text == "ollydbg")
				{
					break;
				}
				num++;
				continue;
			}
			return;
		}
		method_3();
	}

	private void method_3()
	{
		Thread.Sleep(new Random().Next(5000, 30000));
		Environment.Exit(0);
	}

	public Class14()
	{
		Class51.smethod_0();
		base._002Ector();
	}
}
