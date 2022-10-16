using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class TokenizerClass
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TokenizerClass()
	{
		WriterPropertyProducer.ResolveStub();
		FindInterfaceObserver();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FindInterfaceObserver()
	{
	}
}
