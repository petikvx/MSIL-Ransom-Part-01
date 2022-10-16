using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class BaseOrder
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BaseOrder()
	{
		WriterPropertyProducer.ResolveStub();
		LogoutRegistry();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LogoutRegistry()
	{
	}
}
