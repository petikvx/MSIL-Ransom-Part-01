using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ExporterRulesAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExporterRulesAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		LogoutBase();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LogoutBase()
	{
	}
}
