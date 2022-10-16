using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class CreatorOrderPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CreatorOrderPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		FindInterfaceReg();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FindInterfaceReg()
	{
	}
}
