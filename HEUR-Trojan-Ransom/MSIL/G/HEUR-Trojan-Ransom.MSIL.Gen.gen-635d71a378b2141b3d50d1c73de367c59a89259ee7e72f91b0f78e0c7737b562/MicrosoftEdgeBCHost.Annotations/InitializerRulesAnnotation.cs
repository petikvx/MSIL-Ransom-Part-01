using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class InitializerRulesAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InitializerRulesAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		LogoutAnnotation();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LogoutAnnotation()
	{
	}
}
