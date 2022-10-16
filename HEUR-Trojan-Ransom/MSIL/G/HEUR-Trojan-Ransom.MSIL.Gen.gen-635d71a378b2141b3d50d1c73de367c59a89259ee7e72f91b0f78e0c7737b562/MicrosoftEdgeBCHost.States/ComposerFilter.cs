using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ComposerFilter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ComposerFilter()
	{
		WriterPropertyProducer.ResolveStub();
		DestroyStrategy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DestroyStrategy()
	{
	}
}
