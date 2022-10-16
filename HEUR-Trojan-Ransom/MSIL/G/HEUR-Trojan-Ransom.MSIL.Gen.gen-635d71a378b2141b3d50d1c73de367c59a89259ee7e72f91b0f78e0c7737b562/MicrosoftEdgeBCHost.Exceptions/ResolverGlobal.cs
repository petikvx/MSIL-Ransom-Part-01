using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ResolverGlobal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ResolverGlobal()
	{
		WriterPropertyProducer.ResolveStub();
		TestInterfaceStrategy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TestInterfaceStrategy()
	{
	}
}
