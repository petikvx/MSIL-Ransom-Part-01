using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class QueueValAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static QueueValAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		PopInterfaceProducer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PopInterfaceProducer()
	{
	}
}
