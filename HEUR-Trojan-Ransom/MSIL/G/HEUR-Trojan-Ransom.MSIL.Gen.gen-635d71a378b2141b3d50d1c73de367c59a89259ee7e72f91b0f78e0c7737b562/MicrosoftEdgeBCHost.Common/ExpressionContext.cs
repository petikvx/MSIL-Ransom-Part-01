using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ExpressionContext
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExpressionContext()
	{
		WriterPropertyProducer.ResolveStub();
		UpdateInterfaceRules();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UpdateInterfaceRules()
	{
	}
}
