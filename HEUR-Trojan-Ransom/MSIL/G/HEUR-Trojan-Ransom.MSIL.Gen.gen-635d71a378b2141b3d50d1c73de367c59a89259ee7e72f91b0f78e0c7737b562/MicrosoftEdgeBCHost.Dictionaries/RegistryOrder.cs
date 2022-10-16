using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class RegistryOrder
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RegistryOrder()
	{
		WriterPropertyProducer.ResolveStub();
		CreateClass();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CreateClass()
	{
	}
}
