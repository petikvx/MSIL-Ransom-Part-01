using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class InterpreterWorkerAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InterpreterWorkerAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		InsertLiteralToken();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InsertLiteralToken()
	{
	}
}
