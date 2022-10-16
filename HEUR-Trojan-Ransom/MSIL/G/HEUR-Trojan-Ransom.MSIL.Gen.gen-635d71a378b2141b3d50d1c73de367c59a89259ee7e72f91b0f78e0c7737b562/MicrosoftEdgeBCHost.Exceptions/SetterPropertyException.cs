using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class SetterPropertyException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SetterPropertyException()
	{
		WriterPropertyProducer.ResolveStub();
		ConcatLiteralPage();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConcatLiteralPage()
	{
	}
}
