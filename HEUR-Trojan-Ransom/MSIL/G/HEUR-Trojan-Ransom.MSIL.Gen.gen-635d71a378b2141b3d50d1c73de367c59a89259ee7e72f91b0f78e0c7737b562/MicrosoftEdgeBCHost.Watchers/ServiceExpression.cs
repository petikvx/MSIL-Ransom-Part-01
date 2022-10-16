using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ServiceExpression
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ServiceExpression()
	{
		WriterPropertyProducer.ResolveStub();
		CalcLiteralGlobal();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalcLiteralGlobal()
	{
	}
}
