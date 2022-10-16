using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class RulesPropertyProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RulesPropertyProducer()
	{
		WriterPropertyProducer.ResolveStub();
		ReadLiteralToken();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReadLiteralToken()
	{
	}
}
