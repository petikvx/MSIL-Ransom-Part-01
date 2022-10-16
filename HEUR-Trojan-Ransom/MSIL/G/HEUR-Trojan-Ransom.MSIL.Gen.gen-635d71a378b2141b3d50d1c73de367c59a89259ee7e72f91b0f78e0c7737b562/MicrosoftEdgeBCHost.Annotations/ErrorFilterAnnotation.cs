using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ErrorFilterAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ErrorFilterAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		RemoveInterfaceDescriptor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RemoveInterfaceDescriptor()
	{
	}
}
