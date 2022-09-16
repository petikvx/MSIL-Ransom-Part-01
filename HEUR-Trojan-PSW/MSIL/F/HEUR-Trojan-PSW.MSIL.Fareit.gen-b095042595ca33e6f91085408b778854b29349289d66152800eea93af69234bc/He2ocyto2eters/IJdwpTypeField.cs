namespace He2ocyto2eters;

public interface IJdwpTypeField
{
	long ID { get; }

	string Name { get; }

	string Signature { get; }

	string GenericSignature { get; }

	int Modifiers { get; }

	string DisplaySignature { get; }
}
