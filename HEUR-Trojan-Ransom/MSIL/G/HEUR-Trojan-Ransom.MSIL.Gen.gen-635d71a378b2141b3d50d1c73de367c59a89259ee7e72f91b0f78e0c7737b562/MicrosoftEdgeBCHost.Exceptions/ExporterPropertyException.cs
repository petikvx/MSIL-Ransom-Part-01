using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ExporterPropertyException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExporterPropertyException()
	{
		WriterPropertyProducer.ResolveStub();
		NewLiteralSerializer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NewLiteralSerializer()
	{
	}
}
