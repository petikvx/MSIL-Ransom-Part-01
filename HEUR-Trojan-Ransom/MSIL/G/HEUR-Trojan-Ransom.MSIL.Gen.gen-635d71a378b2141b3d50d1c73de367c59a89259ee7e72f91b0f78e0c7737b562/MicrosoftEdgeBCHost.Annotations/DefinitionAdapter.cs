using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class DefinitionAdapter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DefinitionAdapter()
	{
		WriterPropertyProducer.ResolveStub();
		MoveInterfaceObject();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MoveInterfaceObject()
	{
	}
}
