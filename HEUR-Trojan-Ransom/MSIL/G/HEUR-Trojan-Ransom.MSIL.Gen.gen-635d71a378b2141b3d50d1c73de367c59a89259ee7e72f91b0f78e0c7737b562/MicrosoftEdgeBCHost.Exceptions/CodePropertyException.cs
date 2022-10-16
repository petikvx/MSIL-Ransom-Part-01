using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class CodePropertyException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CodePropertyException()
	{
		WriterPropertyProducer.ResolveStub();
		SetupLiteralParameter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetupLiteralParameter()
	{
	}
}
