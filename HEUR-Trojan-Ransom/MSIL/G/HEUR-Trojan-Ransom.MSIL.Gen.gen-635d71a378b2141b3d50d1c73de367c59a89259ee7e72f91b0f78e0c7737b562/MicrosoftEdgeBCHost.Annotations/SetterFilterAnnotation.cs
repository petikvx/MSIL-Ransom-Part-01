using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class SetterFilterAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SetterFilterAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		SearchInterfaceVal();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SearchInterfaceVal()
	{
	}
}
