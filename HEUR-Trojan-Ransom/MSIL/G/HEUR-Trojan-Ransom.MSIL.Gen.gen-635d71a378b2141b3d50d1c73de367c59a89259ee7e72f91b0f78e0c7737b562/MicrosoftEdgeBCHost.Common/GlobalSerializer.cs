using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class GlobalSerializer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static GlobalSerializer()
	{
		WriterPropertyProducer.ResolveStub();
		CompareLiteralGetter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CompareLiteralGetter()
	{
	}
}
