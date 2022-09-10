using System.Security;

namespace Caspol;

internal class ParserStackFrame
{
	internal SecurityElement element = null;

	internal bool intag = true;

	internal string strValue = null;

	internal int status = 0;

	internal bool sawEquals = false;

	internal SecurityElementType type = SecurityElementType.Regular;
}
