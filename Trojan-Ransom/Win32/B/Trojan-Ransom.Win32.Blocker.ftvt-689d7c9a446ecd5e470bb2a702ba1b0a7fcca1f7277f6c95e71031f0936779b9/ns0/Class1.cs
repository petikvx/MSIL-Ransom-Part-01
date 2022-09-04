using System;
using System.Diagnostics;
using System.Reflection;
using System.Threading;
using SmartAssembly.SmartExceptionsCore;

namespace ns0;

internal sealed class Class1
{
	private static Assembly assembly_0;

	private static string[] string_0;

	internal static void smethod_0()
	{
		try
		{
			try
			{
				AppDomain.CurrentDomain.ResourceResolve += smethod_1;
			}
			catch (Exception)
			{
			}
		}
		catch (Exception exception_)
		{
			StackFrameHelper.CreateException0(exception_);
			throw;
		}
	}

	private static Assembly smethod_1(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		string[] array = default(string[]);
		string name = default(string);
		int num = default(int);
		try
		{
			if ((object)assembly_0 == null)
			{
				Monitor.Enter(array = string_0);
				try
				{
					assembly_0 = Assembly.Load("{642677f3-aefe-45c0-9f1f-45e3895ee24c}, PublicKeyToken=3e56350693f7355e");
					if ((object)assembly_0 != null)
					{
						string_0 = assembly_0.GetManifestResourceNames();
					}
				}
				finally
				{
					Monitor.Exit(array);
				}
			}
			name = resolveEventArgs_0.Name;
			num = 0;
			while (true)
			{
				if (num < string_0.Length)
				{
					if (string_0[num] == name)
					{
						break;
					}
					num++;
					continue;
				}
				return null;
			}
			if (!smethod_2())
			{
				return null;
			}
			return assembly_0;
		}
		catch (Exception exception_)
		{
			StackFrameHelper.CreateException5(exception_, name, num, array, object_0, resolveEventArgs_0);
			throw;
		}
	}

	private static bool smethod_2()
	{
		StackFrame[] frames = default(StackFrame[]);
		int num = default(int);
		StackFrame stackFrame = default(StackFrame);
		bool flag = default(bool);
		try
		{
			try
			{
				frames = new StackTrace().GetFrames();
				num = 2;
				while (true)
				{
					if (num < frames.Length)
					{
						stackFrame = frames[num];
						if ((object)stackFrame.GetMethod()!.Module.Assembly == Assembly.GetExecutingAssembly())
						{
							break;
						}
						num++;
						continue;
					}
					flag = false;
					return flag;
				}
				flag = true;
				return flag;
			}
			catch
			{
				flag = true;
				return flag;
			}
		}
		catch (Exception exception_)
		{
			StackFrameHelper.CreateException4(exception_, frames, num, stackFrame, flag);
			throw;
		}
	}

	public Class1()
	{
		try
		{
		}
		catch (Exception exception_)
		{
			StackFrameHelper.CreateException1(exception_, this);
			throw;
		}
	}

	static Class1()
	{
		try
		{
			assembly_0 = null;
			string_0 = new string[0];
		}
		catch (Exception exception_)
		{
			StackFrameHelper.CreateException0(exception_);
			throw;
		}
	}
}
