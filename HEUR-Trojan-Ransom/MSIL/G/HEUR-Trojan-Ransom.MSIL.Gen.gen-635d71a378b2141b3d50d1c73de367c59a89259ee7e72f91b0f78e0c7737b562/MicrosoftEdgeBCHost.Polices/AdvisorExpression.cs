using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class AdvisorExpression
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AdvisorExpression()
	{
		WriterPropertyProducer.ResolveStub();
		CallLiteralGlobal();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CallLiteralGlobal()
	{
	}
}
