namespace ConsoleApp5.Importers;

internal sealed class SerializerPolicyImporter
{
	private bool _Proccesor;

	internal bool ValidateInitializer()
	{
		return _Proccesor;
	}

	internal void StartInitializer(bool outputasset)
	{
		_Proccesor = outputasset;
	}
}
