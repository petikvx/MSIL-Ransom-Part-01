using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ExpressionRules
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExpressionRules()
	{
		WriterPropertyProducer.ResolveStub();
		DefineTag();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DefineTag()
	{
	}
}
