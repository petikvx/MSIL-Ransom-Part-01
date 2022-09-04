using System;
using System.Diagnostics;
using System.Reflection;
using System.Threading;

namespace _0001;

internal class _0001
{
	private static Assembly m__0001 = null;

	private static string[] m__0001 = new string[0];

	internal static void _0001()
	{
		try
		{
			AppDomain currentDomain = AppDomain.CurrentDomain;
			ResolveEventHandler value = _0001;
			if (4u != 0)
			{
				currentDomain.ResourceResolve += value;
			}
		}
		catch (Exception)
		{
		}
	}

	private static Assembly _0001(object P_0, ResolveEventArgs P_1)
	{
		string[] obj = default(string[]);
		string text = default(string);
		do
		{
			if ((object)global::_0001._0001.m__0001 == null)
			{
				string[] array = global::_0001._0001.m__0001;
				if (0 == 0)
				{
					obj = array;
				}
				if (3u != 0)
				{
					Monitor.Enter(array);
				}
				try
				{
					global::_0001._0001.m__0001 = Assembly.Load("{6c2dcaa1-060d-4206-942d-2669e65311b9}, PublicKeyToken=3e56350693f7355e");
					if ((object)global::_0001._0001.m__0001 != null)
					{
						global::_0001._0001.m__0001 = global::_0001._0001.m__0001.GetManifestResourceNames();
					}
				}
				finally
				{
					Monitor.Exit(obj);
				}
			}
			string name = P_1.Name;
			if (0 == 0)
			{
				text = name;
			}
			int num;
			if (6u != 0)
			{
				num = 0;
			}
			while (true)
			{
				int num2 = num;
				nint num3;
				if (true)
				{
					num3 = (nint)global::_0001._0001.m__0001.LongLength;
					if (8 == 0)
					{
						goto IL_007d;
					}
					if (num2 >= (int)num3)
					{
						break;
					}
					num2 = ((global::_0001._0001.m__0001[num] == text) ? 1 : 0);
				}
				if (0 == 0)
				{
					if (num2 != 0)
					{
						if (!global::_0001._0001._0001())
						{
							return null;
						}
						return global::_0001._0001.m__0001;
					}
					num2 = num;
				}
				num3 = 1;
				goto IL_007d;
				IL_007d:
				int num4 = num2 + 1;
				if (7u != 0)
				{
					num = num4;
				}
			}
		}
		while (5 == 0);
		return null;
	}

	private static bool _0001()
	{
		try
		{
			StackFrame[] frames = new StackTrace().GetFrames();
			StackFrame[] array = default(StackFrame[]);
			if (0 == 0)
			{
				array = frames;
			}
			int num = 2;
			int num2 = default(int);
			StackFrame stackFrame = default(StackFrame);
			bool result = default(bool);
			do
			{
				if (0 == 0)
				{
					num2 = num;
				}
				while (true)
				{
					int num3 = num2;
					if (0 == 0)
					{
						nint num4 = (nint)array.LongLength;
						if (0 == 0)
						{
							num4 = (int)num4;
						}
						int num5;
						if (num3 < num4)
						{
							StackFrame obj = array[num2];
							if (0 == 0)
							{
								stackFrame = obj;
							}
							if ((object)stackFrame.GetMethod()!.Module.Assembly == Assembly.GetExecutingAssembly())
							{
								break;
							}
							num5 = num2;
							if (3u != 0)
							{
								num3 = num5 + 1;
								goto IL_0043;
							}
						}
						else
						{
							num5 = 0;
						}
						if (0 == 0)
						{
							return (byte)num5 != 0;
						}
						return result;
					}
					goto IL_0043;
					IL_0043:
					if (6u != 0)
					{
						num2 = num3;
					}
				}
				num = 1;
			}
			while (num == 0);
			if (0 == 0)
			{
				return (byte)num != 0;
			}
			return result;
		}
		catch
		{
			return true;
		}
	}
}
