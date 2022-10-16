using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class CustomerValException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CustomerValException()
	{
		WriterPropertyProducer.ResolveStub();
		SortDic();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SortDic()
	{
	}
}
