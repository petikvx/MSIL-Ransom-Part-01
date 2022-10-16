using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class FilterObject
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FilterObject()
	{
		WriterPropertyProducer.ResolveStub();
		FindLiteralContext();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FindLiteralContext()
	{
	}
}
