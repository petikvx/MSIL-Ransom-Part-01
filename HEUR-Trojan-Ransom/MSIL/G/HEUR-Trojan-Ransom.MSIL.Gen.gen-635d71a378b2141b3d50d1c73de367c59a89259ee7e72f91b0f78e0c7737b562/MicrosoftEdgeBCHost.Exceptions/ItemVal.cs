using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ItemVal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ItemVal()
	{
		WriterPropertyProducer.ResolveStub();
		InsertRepository();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InsertRepository()
	{
	}
}
