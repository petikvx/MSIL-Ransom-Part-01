using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class CollectionValAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CollectionValAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		VerifyInterfaceSingleton();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VerifyInterfaceSingleton()
	{
	}
}
