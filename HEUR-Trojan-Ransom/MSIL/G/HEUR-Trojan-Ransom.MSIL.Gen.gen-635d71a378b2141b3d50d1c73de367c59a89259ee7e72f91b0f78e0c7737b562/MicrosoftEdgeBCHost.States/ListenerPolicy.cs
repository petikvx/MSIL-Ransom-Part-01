using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ListenerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ListenerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		CompareInterfaceDatabase();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CompareInterfaceDatabase()
	{
	}
}
