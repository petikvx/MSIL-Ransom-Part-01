using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ErrorGlobal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ErrorGlobal()
	{
		WriterPropertyProducer.ResolveStub();
		InitInterfaceParameter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InitInterfaceParameter()
	{
	}
}
