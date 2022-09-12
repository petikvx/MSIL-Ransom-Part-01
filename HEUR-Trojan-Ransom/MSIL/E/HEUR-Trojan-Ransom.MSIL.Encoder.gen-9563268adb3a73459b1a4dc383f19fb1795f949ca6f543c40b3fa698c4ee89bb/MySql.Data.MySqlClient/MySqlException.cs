using System;
using System.Data.Common;
using System.Runtime.Serialization;

namespace MySql.Data.MySqlClient;

[Serializable]
public sealed class MySqlException : DbException
{
	public int Number { get; }

	internal bool IsFatal { get; }

	internal bool IsQueryAborted
	{
		get
		{
			if (Number != 1317)
			{
				return Number == 1028;
			}
			return true;
		}
	}

	public new string SqlState { get; private set; }

	public uint Code { get; private set; }

	internal MySqlException()
	{
	}

	internal MySqlException(string msg)
		: base(msg)
	{
	}

	internal MySqlException(string msg, Exception ex)
		: base(msg, ex)
	{
	}

	internal MySqlException(string msg, bool isFatal, Exception inner)
		: base(msg, inner)
	{
		IsFatal = isFatal;
	}

	internal MySqlException(string msg, int errno, Exception inner)
		: this(msg, inner)
	{
		Number = errno;
		Data.Add("Server Error Code", errno);
	}

	internal MySqlException(string msg, int errno)
		: this(msg, errno, null)
	{
	}

	internal MySqlException(uint code, string sqlState, string msg)
		: base(msg)
	{
		Code = code;
		SqlState = sqlState;
	}

	private MySqlException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
