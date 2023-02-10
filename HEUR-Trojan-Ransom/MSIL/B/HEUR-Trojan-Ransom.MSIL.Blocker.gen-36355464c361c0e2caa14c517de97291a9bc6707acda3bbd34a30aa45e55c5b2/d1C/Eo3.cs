using System;
using Sd9;
using Sn4;

namespace d1C;

public class Eo3
{
	public int ExecuteScalar { get; set; }

	public string CommandText { get; set; }

	public int ExecuteNonQuery { get; set; }

	internal Gg6 ExecuteReader
	{
		get
		{
			throw new NotImplementedException();
		}
	}

	internal r4M Connection { get; set; }
}
