using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ThreadValAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ThreadValAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		CustomizeInterfaceHelper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CustomizeInterfaceHelper()
	{
	}
}
