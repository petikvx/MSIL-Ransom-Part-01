using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ComposerClass
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ComposerClass()
	{
		WriterPropertyProducer.ResolveStub();
		SetInterfaceStruct();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetInterfaceStruct()
	{
	}
}
