using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class IssuerFilterAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IssuerFilterAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		FindInterfaceInitializer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FindInterfaceInitializer()
	{
	}
}
