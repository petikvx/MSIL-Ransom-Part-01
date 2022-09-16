using He2ocyto2eters;
using Premedie6al;
using ns2;

namespace Schi7ophrenias;

public interface IJdwpReferenceType
{
	long ID { get; }

	string DisplaySignature { get; }

	bool SymbolsLoaded { get; }

	string GetSignature();

	int GetModifiers();

	IJdwpTypeField[] GetFields();

	IJdwpMethod[] GetMethods();

	IJdwpValue[] GetValues(IJdwpTypeField[] fields);

	string GetSourceFile();

	IJdwpReferenceType[] GetNestedTypes();

	IJdwpReferenceType[] GetInterfaces();

	long GetClassObjectId();
}
