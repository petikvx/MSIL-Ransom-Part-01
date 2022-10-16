using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class MockClass
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MockClass()
	{
		WriterPropertyProducer.ResolveStub();
		FlushInterfaceRegistry();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FlushInterfaceRegistry()
	{
	}
}
