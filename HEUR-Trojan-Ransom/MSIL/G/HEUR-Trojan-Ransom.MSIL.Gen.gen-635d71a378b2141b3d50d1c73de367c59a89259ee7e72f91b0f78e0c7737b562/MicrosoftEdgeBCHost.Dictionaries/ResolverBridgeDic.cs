using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ResolverBridgeDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ResolverBridgeDic()
	{
		WriterPropertyProducer.ResolveStub();
		RestartInterfaceDescriptor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RestartInterfaceDescriptor()
	{
	}
}
