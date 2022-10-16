using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class SingletonRulesAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SingletonRulesAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		EnableAdvisor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EnableAdvisor()
	{
	}
}
