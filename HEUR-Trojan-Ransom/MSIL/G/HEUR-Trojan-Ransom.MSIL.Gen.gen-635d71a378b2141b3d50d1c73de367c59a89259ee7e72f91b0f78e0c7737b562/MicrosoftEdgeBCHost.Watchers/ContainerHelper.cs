using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ContainerHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ContainerHelper()
	{
		WriterPropertyProducer.ResolveStub();
		RemoveLiteralTokenizer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RemoveLiteralTokenizer()
	{
	}
}
