using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class FieldFilter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FieldFilter()
	{
		WriterPropertyProducer.ResolveStub();
		MoveExpression();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MoveExpression()
	{
	}
}
