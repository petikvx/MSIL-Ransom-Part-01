using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class IdentifierObject
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IdentifierObject()
	{
		WriterPropertyProducer.ResolveStub();
		CountLiteralSchema();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CountLiteralSchema()
	{
	}
}
