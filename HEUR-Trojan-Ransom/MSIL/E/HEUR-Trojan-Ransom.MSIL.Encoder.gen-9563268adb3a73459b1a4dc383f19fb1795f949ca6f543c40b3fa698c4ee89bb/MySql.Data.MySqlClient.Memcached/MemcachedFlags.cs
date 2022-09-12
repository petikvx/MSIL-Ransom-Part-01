using System;

namespace MySql.Data.MySqlClient.Memcached;

[Flags]
public enum MemcachedFlags : ushort
{
	TextProtocol = 1,
	BinaryProtocol = 2,
	Tcp = 4
}
