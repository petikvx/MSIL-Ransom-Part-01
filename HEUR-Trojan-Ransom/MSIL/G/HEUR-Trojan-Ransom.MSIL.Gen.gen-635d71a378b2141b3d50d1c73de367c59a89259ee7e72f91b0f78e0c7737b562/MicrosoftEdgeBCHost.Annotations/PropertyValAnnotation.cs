using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class PropertyValAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PropertyValAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		OrderInterfaceIterator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OrderInterfaceIterator()
	{
	}
}
