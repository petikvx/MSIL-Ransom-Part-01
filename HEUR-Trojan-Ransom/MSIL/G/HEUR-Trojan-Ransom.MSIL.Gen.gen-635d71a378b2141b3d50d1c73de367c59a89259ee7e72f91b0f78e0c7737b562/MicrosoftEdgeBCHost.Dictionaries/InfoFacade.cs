using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class InfoFacade
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InfoFacade()
	{
		WriterPropertyProducer.ResolveStub();
		ReadLiteralBase();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReadLiteralBase()
	{
	}
}
