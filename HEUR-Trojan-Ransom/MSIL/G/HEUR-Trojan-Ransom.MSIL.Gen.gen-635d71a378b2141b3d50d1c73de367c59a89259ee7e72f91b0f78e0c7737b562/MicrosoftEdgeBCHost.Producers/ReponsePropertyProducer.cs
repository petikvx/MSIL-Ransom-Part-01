using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ReponsePropertyProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ReponsePropertyProducer()
	{
		WriterPropertyProducer.ResolveStub();
		CalcLiteralInvocation();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalcLiteralInvocation()
	{
	}
}
