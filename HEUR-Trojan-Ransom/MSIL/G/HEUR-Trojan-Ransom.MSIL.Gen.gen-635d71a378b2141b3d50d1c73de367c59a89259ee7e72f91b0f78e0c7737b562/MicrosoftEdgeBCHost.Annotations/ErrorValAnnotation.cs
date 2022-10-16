using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ErrorValAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ErrorValAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		ConnectInterfaceSpecification();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConnectInterfaceSpecification()
	{
	}
}
