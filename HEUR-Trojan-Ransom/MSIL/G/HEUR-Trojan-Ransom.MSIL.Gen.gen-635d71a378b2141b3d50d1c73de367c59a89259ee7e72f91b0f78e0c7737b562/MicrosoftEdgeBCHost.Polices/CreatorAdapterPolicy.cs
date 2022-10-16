using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class CreatorAdapterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CreatorAdapterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		UpdateLiteralListener();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UpdateLiteralListener()
	{
	}
}
