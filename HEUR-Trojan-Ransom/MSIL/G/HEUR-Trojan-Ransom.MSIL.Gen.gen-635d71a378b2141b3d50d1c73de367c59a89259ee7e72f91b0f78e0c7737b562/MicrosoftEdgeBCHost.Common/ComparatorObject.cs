using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ComparatorObject
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ComparatorObject()
	{
		WriterPropertyProducer.ResolveStub();
		ResolveLiteralParams();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResolveLiteralParams()
	{
	}
}
