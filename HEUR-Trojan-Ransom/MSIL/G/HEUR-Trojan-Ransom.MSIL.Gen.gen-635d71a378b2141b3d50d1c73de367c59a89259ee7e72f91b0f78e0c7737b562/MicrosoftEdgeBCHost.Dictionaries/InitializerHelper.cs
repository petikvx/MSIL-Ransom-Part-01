using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class InitializerHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InitializerHelper()
	{
		WriterPropertyProducer.ResolveStub();
		AwakeLiteralThread();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AwakeLiteralThread()
	{
	}
}
