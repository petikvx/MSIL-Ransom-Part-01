using System;
using System.Reflection;
using qBf2H0JjeUSPj67d.Properties;

namespace G;

internal sealed class m
{
	public static readonly byte[] l = o.m(K.h(Resources.C));

	public static void e()
	{
		//IL_0002: Expected O, but got I4
		//IL_000c: Expected O, but got I4
		//IL_0032: Expected O, but got I4
		string text = (string)0;
		do
		{
			if ((nint)text == 1)
			{
				AppDomain currentDomain = AppDomain.CurrentDomain;
				s.Y(currentDomain);
				currentDomain.AssemblyResolve += e;
				text = (string)2;
			}
			if (text == null)
			{
				text = (string)1;
			}
		}
		while ((nint)text != 2);
	}

	private static Assembly e(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		//IL_0002: Expected O, but got I4
		//IL_000e: Expected O, but got I4
		string text = (string)0;
		do
		{
			if (text == null)
			{
				text = (string)1;
			}
		}
		while ((nint)text != 1);
		return typeof(Type).Assembly;
	}
}
