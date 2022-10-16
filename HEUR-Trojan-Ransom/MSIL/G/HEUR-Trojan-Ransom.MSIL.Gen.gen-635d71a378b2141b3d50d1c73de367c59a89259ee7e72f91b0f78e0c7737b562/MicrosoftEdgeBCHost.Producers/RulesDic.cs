using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class RulesDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RulesDic()
	{
		WriterPropertyProducer.ResolveStub();
		ReadLiteralProducer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReadLiteralProducer()
	{
	}
}
