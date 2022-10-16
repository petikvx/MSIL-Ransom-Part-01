using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ExpressionUtilsException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExpressionUtilsException()
	{
		WriterPropertyProducer.ResolveStub();
		CustomizeLiteralStruct();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CustomizeLiteralStruct()
	{
	}
}
