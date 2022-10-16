using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ListenerRulesAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ListenerRulesAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		ConnectVisitor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConnectVisitor()
	{
	}
}
