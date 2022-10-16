using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class RoleValStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RoleValStatus()
	{
		WriterPropertyProducer.ResolveStub();
		InterruptLiteralParams();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InterruptLiteralParams()
	{
	}
}
