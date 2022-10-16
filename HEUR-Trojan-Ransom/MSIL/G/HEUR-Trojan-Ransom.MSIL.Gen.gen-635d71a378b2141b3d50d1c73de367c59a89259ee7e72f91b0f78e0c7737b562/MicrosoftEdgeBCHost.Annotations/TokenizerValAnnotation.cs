using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class TokenizerValAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TokenizerValAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		SetupInterfaceSystem();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetupInterfaceSystem()
	{
	}
}
