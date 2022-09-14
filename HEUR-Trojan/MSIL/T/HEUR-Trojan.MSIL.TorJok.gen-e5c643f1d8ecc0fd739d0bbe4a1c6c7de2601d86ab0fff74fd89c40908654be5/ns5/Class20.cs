using System.Text;
using System.Text.RegularExpressions;

namespace ns5;

internal static class Class20
{
	internal static Regex regex_0 = new Regex("^(.*/)?([^/\\\\.]+/\\\\.\\\\./)(.+)$");

	internal static Encoding encoding_0 = Encoding.GetEncoding("IBM437");

	internal static Encoding encoding_1 = Encoding.GetEncoding("UTF-8");
}
