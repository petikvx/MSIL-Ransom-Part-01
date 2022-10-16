using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class OrderOrderAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static OrderOrderAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		SelectLiteralSystem();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SelectLiteralSystem()
	{
	}
}
