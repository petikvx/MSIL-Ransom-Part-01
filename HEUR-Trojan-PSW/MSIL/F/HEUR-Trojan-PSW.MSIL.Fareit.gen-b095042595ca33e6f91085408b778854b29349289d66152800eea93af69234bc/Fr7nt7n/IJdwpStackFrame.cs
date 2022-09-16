using G3amma3ians;
using Premedie6al;
using Zecchino7;

namespace Fr7nt7n;

public interface IJdwpStackFrame
{
	long Id { get; set; }

	IJdwpCodeLocation Location { get; set; }

	IJdwpValue[] GetValues(IJdwpVariable[] variables);

	IJdwpValue GetValue(IJdwpVariable v);
}
