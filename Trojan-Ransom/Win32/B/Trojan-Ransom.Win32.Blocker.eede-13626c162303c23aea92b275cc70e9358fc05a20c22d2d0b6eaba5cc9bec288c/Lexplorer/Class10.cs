using System.Collections.Generic;
using System.Text;

namespace Lexplorer;

internal class Class10 : Dictionary<string, string>
{
	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		Enumerator enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			stringBuilder.Append("{");
			stringBuilder.Append(enumerator.Current.Key.ToString());
			stringBuilder.Append("=");
			stringBuilder.Append(enumerator.Current.Value.ToString());
			stringBuilder.Append("}");
		}
		return stringBuilder.ToString();
	}
}
