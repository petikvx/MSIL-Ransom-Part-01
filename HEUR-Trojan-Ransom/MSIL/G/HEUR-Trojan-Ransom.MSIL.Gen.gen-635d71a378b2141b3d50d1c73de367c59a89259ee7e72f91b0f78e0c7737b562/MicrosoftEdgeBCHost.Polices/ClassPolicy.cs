using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ClassPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ClassPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		PostInterfaceInfo();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PostInterfaceInfo()
	{
	}
}
