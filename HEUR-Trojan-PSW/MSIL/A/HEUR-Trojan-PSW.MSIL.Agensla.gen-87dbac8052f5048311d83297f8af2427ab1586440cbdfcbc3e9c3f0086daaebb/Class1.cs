using System;
using System.Reflection;
using System.Threading;

internal sealed class Class1 : IDisposable
{
	public void Dispose()
	{
	}

	internal Assembly method_0()
	{
		return Thread.GetDomain().Load(Class3.smethod_1());
	}

	internal object method_1()
	{
		return method_0().GetType("Kvcpzekhectmqmw.Ismrlg")!.GetMethod("Iqtrzwkvv");
	}
}
