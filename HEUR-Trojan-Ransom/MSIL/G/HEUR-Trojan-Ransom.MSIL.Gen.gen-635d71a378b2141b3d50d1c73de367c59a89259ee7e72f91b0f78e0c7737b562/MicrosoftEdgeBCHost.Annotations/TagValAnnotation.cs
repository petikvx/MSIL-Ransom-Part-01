using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class TagValAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TagValAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		RemoveInterfacePolicy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RemoveInterfacePolicy()
	{
	}
}
