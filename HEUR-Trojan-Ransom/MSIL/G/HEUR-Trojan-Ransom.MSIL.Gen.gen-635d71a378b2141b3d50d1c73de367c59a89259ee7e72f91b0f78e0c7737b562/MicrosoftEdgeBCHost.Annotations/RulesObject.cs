using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class RulesObject
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RulesObject()
	{
		WriterPropertyProducer.ResolveStub();
		QueryLiteralContext();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QueryLiteralContext()
	{
	}
}
