using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class SingletonHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SingletonHelper()
	{
		WriterPropertyProducer.ResolveStub();
		ForgotLiteralSerializer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ForgotLiteralSerializer()
	{
	}
}
