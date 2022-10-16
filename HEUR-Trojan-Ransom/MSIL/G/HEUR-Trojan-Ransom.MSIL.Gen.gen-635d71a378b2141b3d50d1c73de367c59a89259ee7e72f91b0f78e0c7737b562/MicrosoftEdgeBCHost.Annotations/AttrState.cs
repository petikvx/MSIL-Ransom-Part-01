using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class AttrState
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AttrState()
	{
		WriterPropertyProducer.ResolveStub();
		SelectInterfaceDefinition();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SelectInterfaceDefinition()
	{
	}
}
