using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class SetterWorkerAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SetterWorkerAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		CompareLiteralInitializer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CompareLiteralInitializer()
	{
	}
}
