using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class FilterValAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FilterValAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		LoginInterfaceMock();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LoginInterfaceMock()
	{
	}
}
