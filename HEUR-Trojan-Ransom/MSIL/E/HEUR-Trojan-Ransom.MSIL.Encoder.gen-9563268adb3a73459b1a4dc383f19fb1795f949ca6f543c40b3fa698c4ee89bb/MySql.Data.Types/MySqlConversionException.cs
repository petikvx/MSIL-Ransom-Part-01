using System;

namespace MySql.Data.Types;

[Serializable]
public class MySqlConversionException : Exception
{
	public MySqlConversionException(string msg)
		: base(msg)
	{
	}
}
