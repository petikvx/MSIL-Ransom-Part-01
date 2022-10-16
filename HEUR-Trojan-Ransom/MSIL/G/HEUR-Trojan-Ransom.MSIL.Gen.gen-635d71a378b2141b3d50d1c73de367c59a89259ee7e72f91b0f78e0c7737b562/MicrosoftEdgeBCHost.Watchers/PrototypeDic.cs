using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class PrototypeDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PrototypeDic()
	{
		WriterPropertyProducer.ResolveStub();
		QueryLiteralRepository();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QueryLiteralRepository()
	{
	}
}
