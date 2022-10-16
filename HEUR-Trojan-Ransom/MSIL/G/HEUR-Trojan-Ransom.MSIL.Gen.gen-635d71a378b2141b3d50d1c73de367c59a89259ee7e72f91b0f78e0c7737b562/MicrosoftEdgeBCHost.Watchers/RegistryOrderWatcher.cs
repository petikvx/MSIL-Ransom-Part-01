using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class RegistryOrderWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RegistryOrderWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		IncludeLiteralParams();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IncludeLiteralParams()
	{
	}
}
