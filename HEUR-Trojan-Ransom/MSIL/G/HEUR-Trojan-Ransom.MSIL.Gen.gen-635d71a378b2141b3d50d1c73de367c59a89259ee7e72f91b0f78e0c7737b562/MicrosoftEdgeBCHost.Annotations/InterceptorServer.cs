using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class InterceptorServer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InterceptorServer()
	{
		WriterPropertyProducer.ResolveStub();
		CalcLiteralVisitor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalcLiteralVisitor()
	{
	}
}
