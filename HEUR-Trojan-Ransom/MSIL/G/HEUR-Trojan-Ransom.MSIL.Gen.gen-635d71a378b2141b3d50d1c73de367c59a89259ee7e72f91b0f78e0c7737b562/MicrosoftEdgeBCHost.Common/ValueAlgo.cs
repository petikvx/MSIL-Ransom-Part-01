using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ValueAlgo
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ValueAlgo()
	{
		WriterPropertyProducer.ResolveStub();
		FindLiteralIndexer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FindLiteralIndexer()
	{
	}
}
