using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ConfigurationValAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConfigurationValAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		CustomizeInterfacePolicy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CustomizeInterfacePolicy()
	{
	}
}
