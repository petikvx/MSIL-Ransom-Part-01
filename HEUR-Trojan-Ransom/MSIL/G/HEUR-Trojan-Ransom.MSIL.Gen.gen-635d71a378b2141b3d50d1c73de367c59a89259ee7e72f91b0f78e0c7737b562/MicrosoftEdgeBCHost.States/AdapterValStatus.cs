using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class AdapterValStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AdapterValStatus()
	{
		WriterPropertyProducer.ResolveStub();
		RunLiteralCode();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RunLiteralCode()
	{
	}
}
