using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class InfoFilterAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InfoFilterAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		RunInterfaceResolver();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RunInterfaceResolver()
	{
	}
}
