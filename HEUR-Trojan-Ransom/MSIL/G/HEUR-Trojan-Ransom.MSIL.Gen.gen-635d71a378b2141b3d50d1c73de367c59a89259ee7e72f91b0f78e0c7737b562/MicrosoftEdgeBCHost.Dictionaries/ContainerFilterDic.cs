using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ContainerFilterDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ContainerFilterDic()
	{
		WriterPropertyProducer.ResolveStub();
		InsertLiteralMapper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InsertLiteralMapper()
	{
	}
}
