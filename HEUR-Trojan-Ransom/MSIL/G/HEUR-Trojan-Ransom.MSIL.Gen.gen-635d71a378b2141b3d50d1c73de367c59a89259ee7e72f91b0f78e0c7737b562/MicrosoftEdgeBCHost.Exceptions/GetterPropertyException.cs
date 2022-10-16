using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class GetterPropertyException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static GetterPropertyException()
	{
		WriterPropertyProducer.ResolveStub();
		CallLiteralWriter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CallLiteralWriter()
	{
	}
}
