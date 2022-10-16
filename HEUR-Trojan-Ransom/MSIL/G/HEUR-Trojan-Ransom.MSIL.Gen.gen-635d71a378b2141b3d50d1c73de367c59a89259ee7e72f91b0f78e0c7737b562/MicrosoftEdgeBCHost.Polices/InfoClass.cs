using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class InfoClass
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InfoClass()
	{
		WriterPropertyProducer.ResolveStub();
		RegisterInterfaceReg();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RegisterInterfaceReg()
	{
	}
}
