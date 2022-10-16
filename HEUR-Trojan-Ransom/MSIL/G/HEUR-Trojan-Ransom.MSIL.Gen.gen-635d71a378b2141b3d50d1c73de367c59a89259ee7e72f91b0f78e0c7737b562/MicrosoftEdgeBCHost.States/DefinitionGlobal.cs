using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class DefinitionGlobal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DefinitionGlobal()
	{
		WriterPropertyProducer.ResolveStub();
		InvokeInterfaceComposer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InvokeInterfaceComposer()
	{
	}
}
