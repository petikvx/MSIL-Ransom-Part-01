using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ConfigurationBridgeAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConfigurationBridgeAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		PrepareAttribute();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrepareAttribute()
	{
	}
}
