using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class DatabaseValPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DatabaseValPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ForgotInterfaceAlgo();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ForgotInterfaceAlgo()
	{
	}
}
