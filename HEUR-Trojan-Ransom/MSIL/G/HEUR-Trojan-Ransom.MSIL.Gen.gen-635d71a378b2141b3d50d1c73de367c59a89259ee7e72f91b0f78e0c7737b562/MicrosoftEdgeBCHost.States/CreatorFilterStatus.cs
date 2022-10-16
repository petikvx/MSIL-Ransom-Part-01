using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class CreatorFilterStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CreatorFilterStatus()
	{
		WriterPropertyProducer.ResolveStub();
		ManageInterfaceClient();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ManageInterfaceClient()
	{
	}
}
