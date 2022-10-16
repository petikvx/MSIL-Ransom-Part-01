using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class MapperState
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MapperState()
	{
		WriterPropertyProducer.ResolveStub();
		MoveInterfaceModel();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MoveInterfaceModel()
	{
	}
}
