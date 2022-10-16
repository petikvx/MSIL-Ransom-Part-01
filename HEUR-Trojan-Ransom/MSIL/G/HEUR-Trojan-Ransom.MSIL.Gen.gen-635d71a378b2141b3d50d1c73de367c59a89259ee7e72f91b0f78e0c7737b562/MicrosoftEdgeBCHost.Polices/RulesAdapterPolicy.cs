using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class RulesAdapterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RulesAdapterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		QueryLiteralMessage();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QueryLiteralMessage()
	{
	}
}
