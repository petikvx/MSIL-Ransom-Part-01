using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class OrderPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static OrderPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		InvokeInterfaceInfo();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InvokeInterfaceInfo()
	{
	}
}
