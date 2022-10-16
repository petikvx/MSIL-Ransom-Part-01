using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ParamsGlobal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParamsGlobal()
	{
		WriterPropertyProducer.ResolveStub();
		SetupInterfaceComposer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetupInterfaceComposer()
	{
	}
}
