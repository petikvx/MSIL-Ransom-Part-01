using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class SpecificationBridgeDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SpecificationBridgeDic()
	{
		WriterPropertyProducer.ResolveStub();
		DefineInterfaceManager();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DefineInterfaceManager()
	{
	}
}
