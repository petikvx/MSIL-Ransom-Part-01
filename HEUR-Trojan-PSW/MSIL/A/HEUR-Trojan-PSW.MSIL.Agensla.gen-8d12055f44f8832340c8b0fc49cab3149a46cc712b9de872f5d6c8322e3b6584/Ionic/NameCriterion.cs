using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using Ionic.Zip;

namespace Ionic;

internal class NameCriterion : SelectionCriterion
{
	private Regex _re;

	private string _regexString;

	internal ComparisonOperator Operator;

	private string _MatchingFileSpec;

	internal virtual string MatchingFileSpec
	{
		set
		{
			if (Directory.Exists(value))
			{
				string[] obj = new string[5] { ".", null, null, null, null };
				char directorySeparatorChar = Path.DirectorySeparatorChar;
				obj[1] = directorySeparatorChar.ToString();
				obj[2] = value;
				directorySeparatorChar = Path.DirectorySeparatorChar;
				obj[3] = directorySeparatorChar.ToString();
				obj[4] = "*.*";
				_MatchingFileSpec = string.Concat(obj);
			}
			else
			{
				_MatchingFileSpec = value;
			}
			_regexString = "^" + Regex.Escape(_MatchingFileSpec).Replace("\\\\\\*\\.\\*", "\\\\([^\\.]+|.*\\.[^\\\\\\.]*)").Replace("\\.\\*", "\\.[^\\\\\\.]*")
				.Replace("\\*", ".*")
				.Replace("\\?", "[^\\\\\\.]") + "$";
			_re = new Regex(_regexString, RegexOptions.IgnoreCase);
		}
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("name ").Append(EnumUtil.GetDescription(Operator)).Append(" '")
			.Append(_MatchingFileSpec)
			.Append("'");
		return stringBuilder.ToString();
	}

	internal override bool Evaluate(string filename)
	{
		return _Evaluate(filename);
	}

	private bool _Evaluate(string fullpath)
	{
		string input = ((_MatchingFileSpec.IndexOf(Path.DirectorySeparatorChar) == -1) ? Path.GetFileName(fullpath) : fullpath);
		bool flag = _re.IsMatch(input);
		if (Operator != ComparisonOperator.EqualTo)
		{
			flag = !flag;
		}
		return flag;
	}

	internal override bool Evaluate(ZipEntry entry)
	{
		string fullpath = entry.FileName.Replace((Path.DirectorySeparatorChar == '/') ? '\\' : '/', Path.DirectorySeparatorChar);
		return _Evaluate(fullpath);
	}
}
