using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class FacadeAdapterException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FacadeAdapterException()
	{
		WriterPropertyProducer.ResolveStub();
		TestInterfacePredicate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TestInterfacePredicate()
	{
	}
}
