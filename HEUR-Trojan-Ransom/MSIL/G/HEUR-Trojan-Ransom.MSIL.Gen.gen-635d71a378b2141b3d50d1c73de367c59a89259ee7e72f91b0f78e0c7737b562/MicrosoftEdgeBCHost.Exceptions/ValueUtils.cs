using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ValueUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ValueUtils()
	{
		WriterPropertyProducer.ResolveStub();
		InsertInterfaceMapper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InsertInterfaceMapper()
	{
	}
}
