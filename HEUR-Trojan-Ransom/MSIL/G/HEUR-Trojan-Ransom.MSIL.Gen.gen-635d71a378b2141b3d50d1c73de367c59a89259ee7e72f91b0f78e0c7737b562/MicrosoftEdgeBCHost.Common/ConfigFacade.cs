using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ConfigFacade
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConfigFacade()
	{
		WriterPropertyProducer.ResolveStub();
		RegisterLiteralRule();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RegisterLiteralRule()
	{
	}
}
