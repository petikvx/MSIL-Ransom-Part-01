using System;

namespace MySql.Data.MySqlClient;

public class MySqlInfoMessageEventArgs : EventArgs
{
	public MySqlError[] errors { get; set; }
}
