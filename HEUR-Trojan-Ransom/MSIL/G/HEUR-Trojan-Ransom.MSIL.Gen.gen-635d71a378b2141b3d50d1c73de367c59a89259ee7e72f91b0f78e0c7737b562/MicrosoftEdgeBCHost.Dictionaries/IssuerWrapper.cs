using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class IssuerWrapper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IssuerWrapper()
	{
		WriterPropertyProducer.ResolveStub();
		CustomizeTest();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CustomizeTest()
	{
	}
}
