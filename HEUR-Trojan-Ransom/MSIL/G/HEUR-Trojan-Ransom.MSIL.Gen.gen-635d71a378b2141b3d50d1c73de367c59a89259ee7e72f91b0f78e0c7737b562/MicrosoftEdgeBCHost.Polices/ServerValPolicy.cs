using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ServerValPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ServerValPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		NewDatabase();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NewDatabase()
	{
	}
}
