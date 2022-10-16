using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class SingletonWorkerAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SingletonWorkerAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		PrintLiteralExpression();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrintLiteralExpression()
	{
	}
}
