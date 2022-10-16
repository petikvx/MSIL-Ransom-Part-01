using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class AccountFilterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AccountFilterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		CreateField();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CreateField()
	{
	}
}
