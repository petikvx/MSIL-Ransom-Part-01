using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ConfigServer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConfigServer()
	{
		WriterPropertyProducer.ResolveStub();
		UpdateLiteralRules();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UpdateLiteralRules()
	{
	}
}
