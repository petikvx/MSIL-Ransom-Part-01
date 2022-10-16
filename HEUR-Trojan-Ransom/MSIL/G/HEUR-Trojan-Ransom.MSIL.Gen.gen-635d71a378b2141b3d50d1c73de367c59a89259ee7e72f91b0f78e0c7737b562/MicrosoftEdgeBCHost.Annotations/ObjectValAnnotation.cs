using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ObjectValAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ObjectValAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		FindInterfacePublisher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FindInterfacePublisher()
	{
	}
}
