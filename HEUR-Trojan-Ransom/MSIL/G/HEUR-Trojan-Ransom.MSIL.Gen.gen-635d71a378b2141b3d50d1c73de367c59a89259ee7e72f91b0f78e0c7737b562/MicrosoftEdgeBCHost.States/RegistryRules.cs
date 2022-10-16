using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class RegistryRules
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RegistryRules()
	{
		WriterPropertyProducer.ResolveStub();
		QueryProxy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QueryProxy()
	{
	}
}
