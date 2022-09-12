namespace MySql.Data.MySqlClient;

public enum MySqlConnectionProtocol
{
	Sockets = 1,
	Socket = 1,
	Tcp = 1,
	Pipe = 2,
	NamedPipe = 2,
	UnixSocket = 3,
	Unix = 3,
	SharedMemory = 4,
	Memory = 4
}
