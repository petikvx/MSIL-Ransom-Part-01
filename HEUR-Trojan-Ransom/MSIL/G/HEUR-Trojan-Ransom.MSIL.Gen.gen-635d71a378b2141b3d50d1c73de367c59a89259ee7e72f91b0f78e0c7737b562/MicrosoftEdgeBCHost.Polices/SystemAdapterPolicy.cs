using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class SystemAdapterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SystemAdapterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		CloneLiteralInterpreter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CloneLiteralInterpreter()
	{
	}
}
