using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class VisitorValStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static VisitorValStatus()
	{
		WriterPropertyProducer.ResolveStub();
		ExcludeLiteralRole();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExcludeLiteralRole()
	{
	}
}
