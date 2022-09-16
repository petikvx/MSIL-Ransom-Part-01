using Di0ette;
using G3amma3ians;
using Schi7ophrenias;
using ns2;

namespace ns1;

public interface IJdwpClass : IJdwpReferenceType
{
	object Client { get; set; }

	string Name { get; set; }

	Go2ge2 RefTypeTag { get; set; }

	ulong BaseAddress { get; set; }

	uint Size { get; set; }

	string AbsolutePath { get; set; }

	int GetLoadOrder();

	IJdwpCodeLocation GetLocation(uint lineNumber);

	IJdwpMethod GetMethod(long methodId);

	IJdwpMethod[] GetMethods(string name);

	IJdwpClass GetSuperclass();
}
