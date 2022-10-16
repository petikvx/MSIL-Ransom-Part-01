using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class RoleWrapperStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RoleWrapperStatus()
	{
		WriterPropertyProducer.ResolveStub();
		PublishCode();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PublishCode()
	{
	}
}
