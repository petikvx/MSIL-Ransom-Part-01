using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ResolverValStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ResolverValStatus()
	{
		WriterPropertyProducer.ResolveStub();
		CountLiteralTemplate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CountLiteralTemplate()
	{
	}
}
