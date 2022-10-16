using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class SystemBridgeAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SystemBridgeAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		DeleteIdentifier();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DeleteIdentifier()
	{
	}
}
