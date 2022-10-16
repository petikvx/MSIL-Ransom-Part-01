using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class RegistryBridgeDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RegistryBridgeDic()
	{
		WriterPropertyProducer.ResolveStub();
		TestReg();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TestReg()
	{
	}
}
