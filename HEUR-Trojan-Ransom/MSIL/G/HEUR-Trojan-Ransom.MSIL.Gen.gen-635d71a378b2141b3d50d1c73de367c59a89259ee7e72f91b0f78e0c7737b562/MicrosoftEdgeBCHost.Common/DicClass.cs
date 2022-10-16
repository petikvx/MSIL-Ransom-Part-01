using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class DicClass
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DicClass()
	{
		WriterPropertyProducer.ResolveStub();
		SortInterfaceSerializer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SortInterfaceSerializer()
	{
	}
}
