using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class BroadcasterRulesAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BroadcasterRulesAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		CreateVisitor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CreateVisitor()
	{
	}
}
