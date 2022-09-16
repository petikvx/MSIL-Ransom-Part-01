using Di0ette;

namespace G3amma3ians;

public interface IJdwpCodeLocation
{
	Go2ge2 TypeTag { get; set; }

	long ClassID { get; set; }

	long MethodID { get; set; }

	ulong Index { get; set; }

	IJdwpCodeLocation Add(ulong dwCount);

	IJdwpCodeLocation Subtract(ulong dwCount);

	bool IsNull();
}
