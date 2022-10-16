using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ExpressionFacade
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExpressionFacade()
	{
		WriterPropertyProducer.ResolveStub();
		UpdateLiteralClass();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UpdateLiteralClass()
	{
	}
}
