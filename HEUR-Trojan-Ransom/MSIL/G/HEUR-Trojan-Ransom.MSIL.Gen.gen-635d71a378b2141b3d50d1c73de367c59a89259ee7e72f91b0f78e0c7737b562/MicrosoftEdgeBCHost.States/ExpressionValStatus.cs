using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ExpressionValStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExpressionValStatus()
	{
		WriterPropertyProducer.ResolveStub();
		FindLiteralCustomer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FindLiteralCustomer()
	{
	}
}
