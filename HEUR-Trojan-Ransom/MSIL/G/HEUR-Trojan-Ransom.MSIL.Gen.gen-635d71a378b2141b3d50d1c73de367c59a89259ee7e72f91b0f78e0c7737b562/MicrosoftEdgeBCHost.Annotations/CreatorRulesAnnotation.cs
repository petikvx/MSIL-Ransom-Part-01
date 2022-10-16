using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class CreatorRulesAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CreatorRulesAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		LogoutParams();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LogoutParams()
	{
	}
}
