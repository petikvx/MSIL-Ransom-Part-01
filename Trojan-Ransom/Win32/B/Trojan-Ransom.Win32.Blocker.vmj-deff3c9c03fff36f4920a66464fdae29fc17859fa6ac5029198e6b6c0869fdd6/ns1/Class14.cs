using System;
using System.Diagnostics;
using System.Threading;
using ns2;

namespace ns1;

internal class Class14
{
	public bool method_0()
	{
		if (Class20.class24_0.bool_2)
		{
			try
			{
				if (Debugger.IsAttached)
				{
					return false;
				}
			}
			catch
			{
			}
		}
		if (Class20.class24_0.bool_3)
		{
			try
			{
				long ticks = DateTime.Now.Ticks;
				Thread.Sleep(10);
				if (DateTime.Now.Ticks - ticks < 10L)
				{
					return false;
				}
			}
			catch
			{
			}
		}
		if (Class20.class24_0.bool_5)
		{
			try
			{
				if (Class20.class15_0.method_0("NETSTAT"))
				{
					return false;
				}
			}
			catch
			{
			}
		}
		if (Class20.class24_0.bool_4)
		{
			try
			{
				if (Class20.class15_0.method_0("FILEMON"))
				{
					return false;
				}
			}
			catch
			{
			}
		}
		if (Class20.class24_0.bool_8)
		{
			try
			{
				if (Class20.class15_0.method_0("PROCMON"))
				{
					return false;
				}
			}
			catch
			{
			}
		}
		if (Class20.class24_0.bool_9)
		{
			try
			{
				if (Class20.class15_0.method_0("REGMON"))
				{
					return false;
				}
			}
			catch
			{
			}
		}
		if (Class20.class24_0.bool_1)
		{
			try
			{
				if (Class20.class15_0.method_0("CAIN"))
				{
					return false;
				}
			}
			catch
			{
			}
		}
		if (Class20.class24_0.bool_6)
		{
			try
			{
				if (Class20.class15_0.method_0("NETMON"))
				{
					return false;
				}
			}
			catch
			{
			}
		}
		if (Class20.class24_0.bool_10)
		{
			try
			{
				if (Class20.class15_0.method_0("TCPVIEW"))
				{
					return false;
				}
			}
			catch
			{
			}
		}
		if (Class20.class24_0.bool_14)
		{
			try
			{
				if (Class20.class15_0.method_0("WIRESHARK"))
				{
					return false;
				}
			}
			catch
			{
			}
		}
		if (Class20.class24_0.bool_7)
		{
			try
			{
				if (Class20.class23_0.method_6() == "Parallels Video Adapter")
				{
					return false;
				}
			}
			catch
			{
			}
		}
		if (Class20.class24_0.bool_13)
		{
			try
			{
				if (Class20.class23_0.method_6() == "VMware SVGA II")
				{
					return false;
				}
			}
			catch
			{
			}
		}
		if (Class20.class24_0.bool_11)
		{
			try
			{
				if (Class20.class23_0.method_6() == "VirtualBox Graphics Adapter")
				{
					return false;
				}
			}
			catch
			{
			}
		}
		if (Class20.class24_0.bool_12)
		{
			try
			{
				string[] array = new string[2] { "VM Additions S3 Trio32/64", "S3 Trio32/64" };
				for (int i = 0; i < array.Length; i++)
				{
					if (Class20.class23_0.method_6() == array[i])
					{
						return false;
					}
				}
			}
			catch
			{
			}
		}
		return true;
	}
}
