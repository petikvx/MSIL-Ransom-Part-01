using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ConfigurationRulesAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConfigurationRulesAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		CreateThread();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CreateThread()
	{
	}
}
