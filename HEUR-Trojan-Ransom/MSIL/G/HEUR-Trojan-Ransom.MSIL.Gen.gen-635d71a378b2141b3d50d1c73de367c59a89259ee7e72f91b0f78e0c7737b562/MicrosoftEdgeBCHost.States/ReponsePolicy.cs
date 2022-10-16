using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ReponsePolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ReponsePolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ManageInterfaceRepository();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ManageInterfaceRepository()
	{
	}
}
