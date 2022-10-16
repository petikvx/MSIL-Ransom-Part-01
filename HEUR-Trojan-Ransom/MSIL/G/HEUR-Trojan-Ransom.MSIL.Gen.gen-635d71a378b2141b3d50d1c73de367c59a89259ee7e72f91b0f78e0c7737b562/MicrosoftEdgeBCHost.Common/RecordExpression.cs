using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class RecordExpression
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RecordExpression()
	{
		WriterPropertyProducer.ResolveStub();
		ResolveLiteralMap();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResolveLiteralMap()
	{
	}
}
