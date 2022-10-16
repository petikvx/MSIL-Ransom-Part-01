using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class OrderUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static OrderUtils()
	{
		WriterPropertyProducer.ResolveStub();
		VerifyInterfaceMap();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VerifyInterfaceMap()
	{
	}
}
