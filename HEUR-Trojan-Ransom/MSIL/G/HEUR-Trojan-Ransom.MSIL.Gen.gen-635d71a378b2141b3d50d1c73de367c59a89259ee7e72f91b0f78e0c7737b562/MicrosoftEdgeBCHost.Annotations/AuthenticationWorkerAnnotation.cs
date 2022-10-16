using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class AuthenticationWorkerAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AuthenticationWorkerAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		CalcLiteralTest();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalcLiteralTest()
	{
	}
}
