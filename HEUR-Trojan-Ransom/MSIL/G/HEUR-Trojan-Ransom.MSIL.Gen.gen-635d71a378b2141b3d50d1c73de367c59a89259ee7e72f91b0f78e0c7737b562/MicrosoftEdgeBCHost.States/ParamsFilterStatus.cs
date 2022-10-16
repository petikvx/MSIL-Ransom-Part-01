using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ParamsFilterStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParamsFilterStatus()
	{
		WriterPropertyProducer.ResolveStub();
		RunInterfaceToken();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RunInterfaceToken()
	{
	}
}
