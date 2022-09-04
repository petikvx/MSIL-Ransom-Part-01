using System;
using System.Diagnostics;
using System.Threading;

namespace ___codefort;

internal sealed class Class12
{
	public bool method_0()
	{
		if (Class8.class16_0.bool_6)
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
		if (Class8.class16_0.bool_7)
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
		if (Class8.class16_0.bool_9)
		{
			try
			{
				if (Class8.class21_0.method_0(Class22.smethod_0(737972498)))
				{
					return false;
				}
			}
			catch
			{
			}
		}
		if (Class8.class16_0.bool_8)
		{
			try
			{
				if (Class8.class21_0.method_0(Class22.smethod_0(737972512)))
				{
					return false;
				}
			}
			catch
			{
			}
		}
		if (Class8.class16_0.bool_12)
		{
			try
			{
				if (Class8.class21_0.method_0(Class22.smethod_0(737972534)))
				{
					return false;
				}
			}
			catch
			{
			}
		}
		if (Class8.class16_0.bool_13)
		{
			try
			{
				if (Class8.class21_0.method_0(Class22.smethod_0(737976004)))
				{
					return false;
				}
			}
			catch
			{
			}
		}
		if (Class8.class16_0.bool_5)
		{
			try
			{
				if (Class8.class21_0.method_0(Class22.smethod_0(737976011)))
				{
					return false;
				}
			}
			catch
			{
			}
		}
		if (Class8.class16_0.bool_10)
		{
			try
			{
				if (Class8.class21_0.method_0(Class22.smethod_0(737976028)))
				{
					return false;
				}
			}
			catch
			{
			}
		}
		if (Class8.class16_0.bool_14)
		{
			try
			{
				if (Class8.class21_0.method_0(Class22.smethod_0(737976035)))
				{
					return false;
				}
			}
			catch
			{
			}
		}
		if (Class8.class16_0.bool_18)
		{
			try
			{
				if (Class8.class21_0.method_0(Class22.smethod_0(737976049)))
				{
					return false;
				}
			}
			catch
			{
			}
		}
		if (Class8.class16_0.bool_11)
		{
			try
			{
				if (Class8.class6_0.method_7() == Class22.smethod_0(737975937))
				{
					return false;
				}
			}
			catch
			{
			}
		}
		if (Class8.class16_0.bool_17)
		{
			try
			{
				if (Class8.class6_0.method_7() == Class22.smethod_0(737975975))
				{
					return false;
				}
			}
			catch
			{
			}
		}
		if (Class8.class16_0.bool_15)
		{
			try
			{
				if (Class8.class6_0.method_7() == Class22.smethod_0(737975986))
				{
					return false;
				}
			}
			catch
			{
			}
		}
		if (Class8.class16_0.bool_16)
		{
			try
			{
				string[] array = new string[2]
				{
					Class22.smethod_0(737975900),
					Class22.smethod_0(737975932)
				};
				for (int i = 0; i < array.Length; i++)
				{
					if (Class8.class6_0.method_7() == array[i])
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
