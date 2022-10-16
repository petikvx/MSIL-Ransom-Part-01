using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ExpressionObject
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExpressionObject()
	{
		WriterPropertyProducer.ResolveStub();
		CompareLiteralOrder();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CompareLiteralOrder()
	{
	}
}
