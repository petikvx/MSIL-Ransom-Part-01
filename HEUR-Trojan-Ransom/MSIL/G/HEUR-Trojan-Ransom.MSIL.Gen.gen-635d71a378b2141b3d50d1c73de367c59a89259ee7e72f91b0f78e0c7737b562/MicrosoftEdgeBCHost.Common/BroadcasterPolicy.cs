using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class BroadcasterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BroadcasterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		InvokeInterfaceDatabase();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InvokeInterfaceDatabase()
	{
	}
}
