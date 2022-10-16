using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class InterpreterValAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InterpreterValAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		PushLiteralIssuer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PushLiteralIssuer()
	{
	}
}
