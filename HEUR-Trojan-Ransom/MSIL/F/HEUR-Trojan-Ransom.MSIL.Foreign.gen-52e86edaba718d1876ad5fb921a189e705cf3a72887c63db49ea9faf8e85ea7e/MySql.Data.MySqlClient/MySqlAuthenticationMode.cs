namespace MySql.Data.MySqlClient;

public enum MySqlAuthenticationMode
{
	Default = 0,
	AUTO = 0,
	PLAIN = 1,
	MYSQL41 = 2,
	EXTERNAL = 3,
	SHA256_MEMORY = 4
}
