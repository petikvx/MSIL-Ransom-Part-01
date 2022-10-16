using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class AdvisorBridgeAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AdvisorBridgeAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		ResolveDic();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResolveDic()
	{
	}
}
