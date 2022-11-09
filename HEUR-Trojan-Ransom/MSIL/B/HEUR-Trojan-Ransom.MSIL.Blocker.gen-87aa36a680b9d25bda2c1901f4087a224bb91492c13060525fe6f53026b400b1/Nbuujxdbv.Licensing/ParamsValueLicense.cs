namespace Nbuujxdbv.Licensing;

internal class ParamsValueLicense
{
	internal static ParamsValueLicense ResolveContext;

	internal void ManageProducer()
	{
	}

	internal void SetupProducer()
	{
	}

	internal void SortProducer()
	{
	}

	internal void AddProducer()
	{
	}

	internal void SelectProducer()
	{
	}

	internal static bool SetContext()
	{
		return ResolveContext == null;
	}

	internal static ParamsValueLicense VerifyContext()
	{
		return ResolveContext;
	}
}
