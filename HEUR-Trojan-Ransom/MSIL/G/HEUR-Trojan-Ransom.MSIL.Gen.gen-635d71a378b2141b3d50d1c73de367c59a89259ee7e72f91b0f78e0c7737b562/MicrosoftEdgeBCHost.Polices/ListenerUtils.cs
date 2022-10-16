using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ListenerUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ListenerUtils()
	{
		WriterPropertyProducer.ResolveStub();
		CompareInterfaceAttr();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CompareInterfaceAttr()
	{
	}
}
