using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class RegFilter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RegFilter()
	{
		WriterPropertyProducer.ResolveStub();
		AwakeMock();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AwakeMock()
	{
	}
}
