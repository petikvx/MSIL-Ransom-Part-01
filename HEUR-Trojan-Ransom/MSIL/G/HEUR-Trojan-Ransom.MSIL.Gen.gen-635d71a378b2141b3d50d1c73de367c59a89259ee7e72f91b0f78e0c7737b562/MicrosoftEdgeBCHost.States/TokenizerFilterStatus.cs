using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class TokenizerFilterStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TokenizerFilterStatus()
	{
		WriterPropertyProducer.ResolveStub();
		EnableInterfaceDatabase();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EnableInterfaceDatabase()
	{
	}
}
