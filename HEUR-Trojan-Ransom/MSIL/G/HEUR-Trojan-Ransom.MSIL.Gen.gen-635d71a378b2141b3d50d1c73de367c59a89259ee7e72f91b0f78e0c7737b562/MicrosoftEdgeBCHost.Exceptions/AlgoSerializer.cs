using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class AlgoSerializer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AlgoSerializer()
	{
		WriterPropertyProducer.ResolveStub();
		SearchLiteralCode();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SearchLiteralCode()
	{
	}
}
