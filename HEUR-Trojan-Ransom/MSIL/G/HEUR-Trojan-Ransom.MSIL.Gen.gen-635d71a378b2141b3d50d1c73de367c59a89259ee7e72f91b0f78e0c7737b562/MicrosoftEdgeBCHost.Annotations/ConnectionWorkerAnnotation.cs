using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ConnectionWorkerAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConnectionWorkerAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		DeleteLiteralSetter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DeleteLiteralSetter()
	{
	}
}
