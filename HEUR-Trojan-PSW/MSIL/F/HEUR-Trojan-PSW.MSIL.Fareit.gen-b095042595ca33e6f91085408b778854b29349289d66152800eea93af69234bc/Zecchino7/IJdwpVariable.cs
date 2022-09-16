namespace Zecchino7;

public interface IJdwpVariable
{
	long CodeIndex { get; set; }

	string Name { get; set; }

	string Signature { get; set; }

	string GenericSignature { get; set; }

	int Length { get; set; }

	int Slot { get; set; }

	string DisplaySignature { get; }
}
