using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class StructFilter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StructFilter()
	{
		WriterPropertyProducer.ResolveStub();
		DisableExpression();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DisableExpression()
	{
	}
}
