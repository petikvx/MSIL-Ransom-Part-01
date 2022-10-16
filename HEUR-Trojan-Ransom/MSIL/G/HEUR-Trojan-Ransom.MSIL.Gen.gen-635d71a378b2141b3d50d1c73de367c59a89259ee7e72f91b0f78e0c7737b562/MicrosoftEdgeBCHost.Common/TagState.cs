using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class TagState
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TagState()
	{
		WriterPropertyProducer.ResolveStub();
		PrintInterfaceProxy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrintInterfaceProxy()
	{
	}
}
