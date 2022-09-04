using System.Windows.Forms;

namespace Bytelocker.UI;

internal class ErrorDecryptMessageBox
{
	public static bool showMessageBoxDecryptError(string file_path)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Invalid comparison between Unknown and I4
		if ((int)MessageBox.Show("Failed to decrypt a previously encrypted file: \"" + file_path + "\".\n\nThe file may be damaged/removed/locked or used by another process", "Error", (MessageBoxButtons)5, (MessageBoxIcon)16) == 4)
		{
			return true;
		}
		return false;
	}
}
