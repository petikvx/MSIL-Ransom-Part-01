using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ValPropertyException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ValPropertyException()
	{
		WriterPropertyProducer.ResolveStub();
		ConnectLiteralRef();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConnectLiteralRef()
	{
	}
}
