using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class AttributeExpression
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AttributeExpression()
	{
		WriterPropertyProducer.ResolveStub();
		ChangeLiteralQueue();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ChangeLiteralQueue()
	{
	}
}
