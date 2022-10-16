using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ContextValPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ContextValPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ReadToken();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReadToken()
	{
	}
}
