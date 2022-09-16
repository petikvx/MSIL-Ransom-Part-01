using ns4;

namespace Premedie6al;

public interface IJdwpValue
{
	Sta8dardise Tag { get; }

	string DisplayType();

	long AsArray();

	sbyte AsByte();

	char AsChar();

	long AsObject();

	float AsFloat();

	double AsDouble();

	int AsInt();

	long AsLong();

	short AsShort();

	bool AsBoolean();

	long AsString();

	long AsThread();

	long AsThreadGroup();

	long AsClassLoader();

	long AsClassObject();
}
