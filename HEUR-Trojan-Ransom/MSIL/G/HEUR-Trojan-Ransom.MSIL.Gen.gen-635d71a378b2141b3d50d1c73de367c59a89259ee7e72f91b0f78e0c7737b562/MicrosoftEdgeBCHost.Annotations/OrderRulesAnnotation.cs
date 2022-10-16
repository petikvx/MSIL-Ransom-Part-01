using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class OrderRulesAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static OrderRulesAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		GetConfiguration();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GetConfiguration()
	{
	}
}
