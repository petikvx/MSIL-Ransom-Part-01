using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class TokenValAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TokenValAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		EnableInterfaceCallback();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EnableInterfaceCallback()
	{
	}
}
