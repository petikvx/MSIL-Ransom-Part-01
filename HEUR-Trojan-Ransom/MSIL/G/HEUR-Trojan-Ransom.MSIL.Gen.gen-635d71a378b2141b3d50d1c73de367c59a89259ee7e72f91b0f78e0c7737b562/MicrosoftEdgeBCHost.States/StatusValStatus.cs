using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class StatusValStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StatusValStatus()
	{
		WriterPropertyProducer.ResolveStub();
		ViewLiteralRole();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ViewLiteralRole()
	{
	}
}
