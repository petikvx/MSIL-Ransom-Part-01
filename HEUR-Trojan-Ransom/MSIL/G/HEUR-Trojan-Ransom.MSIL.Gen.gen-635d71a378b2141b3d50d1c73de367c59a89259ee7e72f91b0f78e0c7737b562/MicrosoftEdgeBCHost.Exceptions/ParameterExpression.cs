using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ParameterExpression
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParameterExpression()
	{
		WriterPropertyProducer.ResolveStub();
		SortLiteralCollection();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SortLiteralCollection()
	{
	}
}
