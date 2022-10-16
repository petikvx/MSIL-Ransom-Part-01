using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class SchemaRules
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SchemaRules()
	{
		WriterPropertyProducer.ResolveStub();
		LoginModel();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LoginModel()
	{
	}
}
