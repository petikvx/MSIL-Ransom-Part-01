using System;
using System.Diagnostics;
using System.Reflection;

namespace KlrDfEF0epkBMtcTTY;

internal sealed class mjMQGA8NpkMERML6a5
{
	private static Assembly x3eY2tTqwy = null;

	private static string[] FglY9VwDDE = new string[0];

	internal static void GMpYFcDT6l()
	{
		try
		{
			AppDomain.CurrentDomain.ResourceResolve += TWGYgDFC8i;
		}
		catch (Exception)
		{
		}
	}

	private static Assembly TWGYgDFC8i(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		if ((object)x3eY2tTqwy == null)
		{
			lock (FglY9VwDDE)
			{
				x3eY2tTqwy = Assembly.Load("{bf73c612-b577-4ac0-88ec-5807fae8c300}, PublicKeyToken=3e56350693f7355e");
				int num = 2;
				if (EqJBNc5ATedXfpikIg())
				{
					while (true)
					{
						switch (num)
						{
						default:
							num = 3;
							if (!TyQasN2cCyQouTdjBs())
							{
							}
							continue;
						case 0:
						case 2:
							break;
						case 1:
						case 3:
							goto IL_005b;
						}
						break;
					}
				}
				if ((object)x3eY2tTqwy != null)
				{
					goto IL_005b;
				}
				goto end_IL_0013;
				IL_005b:
				FglY9VwDDE = x3eY2tTqwy.GetManifestResourceNames();
				end_IL_0013:;
			}
		}
		string name = resolveEventArgs_0.Name;
		int num2 = 0;
		while (true)
		{
			if (num2 < FglY9VwDDE.Length)
			{
				if (FglY9VwDDE[num2] == name)
				{
					break;
				}
				num2++;
				continue;
			}
			return null;
		}
		if (!XPwYs8pyPB())
		{
			return null;
		}
		return x3eY2tTqwy;
	}

	private static bool XPwYs8pyPB()
	{
		try
		{
			StackFrame[] frames = new StackTrace().GetFrames();
			int num = 2;
			while (true)
			{
				if (num < frames.Length)
				{
					StackFrame stackFrame = frames[num];
					if ((object)stackFrame.GetMethod()!.Module.Assembly == Assembly.GetExecutingAssembly())
					{
						break;
					}
					num++;
					continue;
				}
				return false;
			}
			return true;
		}
		catch
		{
			return true;
		}
	}

	internal static bool EqJBNc5ATedXfpikIg()
	{
		return true;
	}

	internal static bool TyQasN2cCyQouTdjBs()
	{
		return false;
	}
}
