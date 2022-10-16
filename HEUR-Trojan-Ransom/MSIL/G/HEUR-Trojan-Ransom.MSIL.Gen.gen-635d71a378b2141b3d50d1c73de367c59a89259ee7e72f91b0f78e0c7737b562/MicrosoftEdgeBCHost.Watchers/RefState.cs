using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class RefState
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RefState()
	{
		WriterPropertyProducer.ResolveStub();
		LoginInterfaceModel();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LoginInterfaceModel()
	{
	}
}
