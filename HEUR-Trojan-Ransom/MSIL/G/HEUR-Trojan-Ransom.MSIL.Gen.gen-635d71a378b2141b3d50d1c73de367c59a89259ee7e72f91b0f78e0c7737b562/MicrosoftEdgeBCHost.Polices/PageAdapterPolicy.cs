using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class PageAdapterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PageAdapterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		StopLiteralHelper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StopLiteralHelper()
	{
	}
}
