using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class VisitorAdapterException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static VisitorAdapterException()
	{
		WriterPropertyProducer.ResolveStub();
		OrderInterfaceAnnotation();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OrderInterfaceAnnotation()
	{
	}
}
