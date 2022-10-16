using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class StateFilterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StateFilterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		PublishValue();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PublishValue()
	{
	}
}
