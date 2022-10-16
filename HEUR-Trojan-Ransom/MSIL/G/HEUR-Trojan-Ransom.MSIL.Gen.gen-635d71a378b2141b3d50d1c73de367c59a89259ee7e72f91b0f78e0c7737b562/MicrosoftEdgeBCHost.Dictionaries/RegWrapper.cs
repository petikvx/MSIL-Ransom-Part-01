using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class RegWrapper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RegWrapper()
	{
		WriterPropertyProducer.ResolveStub();
		NewService();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NewService()
	{
	}
}
