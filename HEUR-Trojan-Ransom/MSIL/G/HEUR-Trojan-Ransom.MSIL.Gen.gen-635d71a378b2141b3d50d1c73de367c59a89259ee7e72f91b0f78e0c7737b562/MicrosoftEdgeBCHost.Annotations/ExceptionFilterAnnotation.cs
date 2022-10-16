using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ExceptionFilterAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExceptionFilterAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		InsertInterfaceDescriptor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InsertInterfaceDescriptor()
	{
	}
}
