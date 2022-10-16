using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ConnectionRulesAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConnectionRulesAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		StopParams();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StopParams()
	{
	}
}
