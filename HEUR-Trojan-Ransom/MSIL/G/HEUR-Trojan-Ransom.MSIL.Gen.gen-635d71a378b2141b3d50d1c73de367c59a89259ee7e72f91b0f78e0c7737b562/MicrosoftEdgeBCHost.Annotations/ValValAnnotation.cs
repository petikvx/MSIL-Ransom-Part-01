using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ValValAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ValValAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		ManageInterfaceStrategy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ManageInterfaceStrategy()
	{
	}
}
