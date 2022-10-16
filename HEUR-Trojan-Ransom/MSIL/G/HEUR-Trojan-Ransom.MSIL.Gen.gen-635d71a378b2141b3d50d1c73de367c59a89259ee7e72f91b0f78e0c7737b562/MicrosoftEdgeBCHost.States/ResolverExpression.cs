using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ResolverExpression
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ResolverExpression()
	{
		WriterPropertyProducer.ResolveStub();
		PublishLiteralCollection();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PublishLiteralCollection()
	{
	}
}
