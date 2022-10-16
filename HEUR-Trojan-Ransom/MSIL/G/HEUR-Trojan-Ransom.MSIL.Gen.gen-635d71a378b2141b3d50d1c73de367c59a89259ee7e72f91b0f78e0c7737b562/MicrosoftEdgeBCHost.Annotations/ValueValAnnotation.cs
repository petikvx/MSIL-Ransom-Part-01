using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ValueValAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ValueValAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		DestroyInterfaceCallback();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DestroyInterfaceCallback()
	{
	}
}
