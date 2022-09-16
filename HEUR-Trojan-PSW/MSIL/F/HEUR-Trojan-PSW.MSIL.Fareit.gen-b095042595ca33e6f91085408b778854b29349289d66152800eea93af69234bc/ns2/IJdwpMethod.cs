using Di0ette;
using Es2oppel;
using G3amma3ians;
using Zecchino7;

namespace ns2;

public interface IJdwpMethod
{
	Go2ge2 ClassTypeTag { get; set; }

	long ClassId { get; set; }

	long MethodId { get; set; }

	string Name { get; set; }

	string Signature { get; set; }

	string FriendlySignature { get; set; }

	string GenericSignature { get; set; }

	int ModBits { get; set; }

	long StartIndex { get; set; }

	long EndIndex { get; set; }

	int LineNumber(ulong index);

	IJdwpCodeLine LineForIndex(ulong index);

	IJdwpCodeLocation GetStartLocation();

	IJdwpCodeLine[] GetLines();

	IJdwpVariable[] GetVariables();

	string GetDisplayName();
}
