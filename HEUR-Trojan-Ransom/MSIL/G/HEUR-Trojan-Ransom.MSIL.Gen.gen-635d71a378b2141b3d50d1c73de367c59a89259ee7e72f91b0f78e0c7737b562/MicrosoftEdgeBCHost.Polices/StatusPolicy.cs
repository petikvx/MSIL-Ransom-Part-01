using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class StatusPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StatusPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		CalcInterfaceDatabase();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalcInterfaceDatabase()
	{
	}
}
