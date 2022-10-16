using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class DatabaseVal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DatabaseVal()
	{
		WriterPropertyProducer.ResolveStub();
		NewInfo();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NewInfo()
	{
	}
}
