using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class InitializerFacade
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InitializerFacade()
	{
		WriterPropertyProducer.ResolveStub();
		FindLiteralBase();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FindLiteralBase()
	{
	}
}
