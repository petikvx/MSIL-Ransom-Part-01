using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class MethodFilterAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MethodFilterAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		DisableInterfaceParameter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DisableInterfaceParameter()
	{
	}
}
