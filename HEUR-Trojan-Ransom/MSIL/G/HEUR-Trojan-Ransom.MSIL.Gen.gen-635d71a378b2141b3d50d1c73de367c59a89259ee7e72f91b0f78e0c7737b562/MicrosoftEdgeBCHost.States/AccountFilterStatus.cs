using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class AccountFilterStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AccountFilterStatus()
	{
		WriterPropertyProducer.ResolveStub();
		StartInterfaceHelper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StartInterfaceHelper()
	{
	}
}
