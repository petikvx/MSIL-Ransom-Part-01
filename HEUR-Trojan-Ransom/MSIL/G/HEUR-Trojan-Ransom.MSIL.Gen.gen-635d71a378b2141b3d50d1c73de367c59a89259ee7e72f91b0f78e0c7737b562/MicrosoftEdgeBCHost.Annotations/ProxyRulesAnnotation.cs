using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ProxyRulesAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProxyRulesAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		InitParams();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InitParams()
	{
	}
}
