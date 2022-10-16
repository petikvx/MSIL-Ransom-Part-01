using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class FacadeServer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FacadeServer()
	{
		WriterPropertyProducer.ResolveStub();
		CloneLiteralIterator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CloneLiteralIterator()
	{
	}
}
