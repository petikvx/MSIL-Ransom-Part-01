using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class SystemValAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SystemValAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		ComputeInterfaceHelper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ComputeInterfaceHelper()
	{
	}
}
