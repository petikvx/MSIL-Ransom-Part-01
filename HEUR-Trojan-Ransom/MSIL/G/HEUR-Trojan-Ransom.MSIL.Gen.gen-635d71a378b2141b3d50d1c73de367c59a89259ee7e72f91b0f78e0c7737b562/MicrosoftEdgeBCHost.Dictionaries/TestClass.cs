using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class TestClass
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TestClass()
	{
		WriterPropertyProducer.ResolveStub();
		FlushInterfacePool();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FlushInterfacePool()
	{
	}
}
