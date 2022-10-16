using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ValValPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ValValPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		UpdateRequest();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UpdateRequest()
	{
	}
}
