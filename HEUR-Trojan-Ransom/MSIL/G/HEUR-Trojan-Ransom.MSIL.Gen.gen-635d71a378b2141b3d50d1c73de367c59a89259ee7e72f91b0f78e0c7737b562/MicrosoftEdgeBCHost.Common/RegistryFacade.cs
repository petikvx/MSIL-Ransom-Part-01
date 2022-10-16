using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class RegistryFacade
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RegistryFacade()
	{
		WriterPropertyProducer.ResolveStub();
		RestartLiteralRule();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RestartLiteralRule()
	{
	}
}
