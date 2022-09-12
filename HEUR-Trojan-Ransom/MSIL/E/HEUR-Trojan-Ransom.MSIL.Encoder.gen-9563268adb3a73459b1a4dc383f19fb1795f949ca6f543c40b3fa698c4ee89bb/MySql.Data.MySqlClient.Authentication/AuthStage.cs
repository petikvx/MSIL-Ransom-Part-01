namespace MySql.Data.MySqlClient.Authentication;

internal enum AuthStage
{
	GENERATE_SCRAMBLE,
	REQUEST_RSA_KEY,
	FAST_AUTH,
	FULL_AUTH
}
