using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class DatabaseState
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DatabaseState()
	{
		WriterPropertyProducer.ResolveStub();
		CloneInterfaceModel();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CloneInterfaceModel()
	{
	}
}
