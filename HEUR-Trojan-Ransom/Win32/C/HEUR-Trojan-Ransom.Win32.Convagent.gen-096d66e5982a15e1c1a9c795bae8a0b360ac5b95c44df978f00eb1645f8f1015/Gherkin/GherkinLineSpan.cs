using System.Runtime.InteropServices;

namespace Gherkin;

[StructLayout(LayoutKind.Sequential, Size = 1)]
public struct GherkinLineSpan
{
	public int Column { get; private set; }

	public string Text { get; private set; }

	public GherkinLineSpan(int column, string text)
	{
		this = default(GherkinLineSpan);
		Column = column;
		Text = text;
	}
}
