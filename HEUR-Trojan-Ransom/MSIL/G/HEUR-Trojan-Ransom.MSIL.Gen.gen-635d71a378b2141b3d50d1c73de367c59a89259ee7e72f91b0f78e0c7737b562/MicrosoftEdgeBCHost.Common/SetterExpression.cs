using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class SetterExpression
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SetterExpression()
	{
		WriterPropertyProducer.ResolveStub();
		CollectLiteralAdapter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CollectLiteralAdapter()
	{
	}
}
