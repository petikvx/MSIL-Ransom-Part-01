using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class PolicyPropertyException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PolicyPropertyException()
	{
		WriterPropertyProducer.ResolveStub();
		CreateLiteralCollection();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CreateLiteralCollection()
	{
	}
}
