using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ComposerAdapter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ComposerAdapter()
	{
		WriterPropertyProducer.ResolveStub();
		PostInterfaceIdentifier();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PostInterfaceIdentifier()
	{
	}
}
