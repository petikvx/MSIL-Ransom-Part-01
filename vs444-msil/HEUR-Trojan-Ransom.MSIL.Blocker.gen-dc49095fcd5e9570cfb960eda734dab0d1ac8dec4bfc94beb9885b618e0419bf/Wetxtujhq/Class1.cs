using System;
using System.IO;
using System.Reflection;
using ClassLibrary.Strategies;

namespace Wetxtujhq;

internal static class Class1
{
	[STAThread]
	private static void Main()
	{
		double double_ = 5.0;
		AppDomain.CurrentDomain.AssemblyResolve += smethod_3;
		double num = new Delegate0(smethod_0)(double_);
		double num2 = new Delegate0(smethod_1)(double_);
		double num3 = new Delegate0(smethod_2)(double_);
		Console.WriteLine(num.ToString());
		Console.WriteLine(num2.ToString());
		Console.WriteLine(num3.ToString());
	}

	public static double smethod_0(double double_0)
	{
		return 6.283 * double_0;
	}

	public static double smethod_1(double double_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		new StubStatusStrategy().NewVisitor(Class3.smethod_3(), Class3.smethod_4(), "AssetPredicate");
		return 3.1415 * double_0 * double_0;
	}

	public static double smethod_2(double double_0)
	{
		return 3.1415 * double_0 * double_0 * double_0 * 4.0 / 3.0;
	}

	private static Assembly smethod_3(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		using Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("Wetxtujhq.ClassLibrary1.dll");
		MemoryStream memoryStream = new MemoryStream();
		stream.CopyTo(memoryStream);
		return Assembly.Load(memoryStream.ToArray());
	}
}
