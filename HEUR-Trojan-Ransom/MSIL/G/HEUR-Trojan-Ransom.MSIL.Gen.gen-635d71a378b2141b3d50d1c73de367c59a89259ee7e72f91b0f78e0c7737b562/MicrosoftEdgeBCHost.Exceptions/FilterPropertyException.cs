using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class FilterPropertyException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FilterPropertyException()
	{
		WriterPropertyProducer.ResolveStub();
		DeleteLiteralRef();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DeleteLiteralRef()
	{
	}
}
