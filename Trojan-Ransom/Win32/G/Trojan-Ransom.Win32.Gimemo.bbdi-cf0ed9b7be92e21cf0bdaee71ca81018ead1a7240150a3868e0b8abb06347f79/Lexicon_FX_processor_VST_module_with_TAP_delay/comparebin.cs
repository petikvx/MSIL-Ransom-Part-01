using System;
using System.Text;

namespace Lexicon_FX_processor_VST_module_with_TAP_delay;

internal class comparebin
{
	public string firereplacer(string input, string val, string dt)
	{
		byte[] bytes = Convert.FromBase64String(input);
		string @string = Encoding.UTF8.GetString(bytes);
		string text = @string.Replace("purse", "U" + val);
		return text.Replace("date", dt);
	}
}
