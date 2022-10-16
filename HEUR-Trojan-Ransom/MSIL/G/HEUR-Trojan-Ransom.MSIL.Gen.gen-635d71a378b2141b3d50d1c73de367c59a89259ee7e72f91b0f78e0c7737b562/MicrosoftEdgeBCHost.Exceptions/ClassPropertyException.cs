using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ClassPropertyException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ClassPropertyException()
	{
		WriterPropertyProducer.ResolveStub();
		ConnectLiteralCollection();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConnectLiteralCollection()
	{
	}
}
