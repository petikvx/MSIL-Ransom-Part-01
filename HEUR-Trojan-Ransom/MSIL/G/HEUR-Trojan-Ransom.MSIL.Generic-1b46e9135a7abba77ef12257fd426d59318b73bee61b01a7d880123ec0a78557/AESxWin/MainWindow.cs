using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using A6yJVNZuoAn9NC1LAS;
using AESxWin.Helpers;
using WKtExBGrT2f6h026To;

namespace AESxWin;

public class MainWindow : Form
{
	private IContainer components;

	private GroupBox gbPaths;

	private Button btnAddFolder;

	private Button btnAddFile;

	private ListBox lstPaths;

	private Button btnRemovePath;

	private GroupBox gbOptions;

	private CheckBox chkSubFolders;

	private CheckBox chkDeleteOrg;

	private GroupBox gbPassword;

	private TextBox txtPassword;

	private Button btnEncrypt;

	private Button btnDecrypt;

	private Label lblInfo;

	private ComboBox lstExts;

	private Label label1;

	private GroupBox gbLog;

	private TextBox txtLog;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MainWindow()
	{
		//Discarded unreachable code: IL_0005, IL_006b
		//IL_0006: Incompatible stack heights: 0 vs 1
		int num = 5;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int num3 = num2;
				while (true)
				{
					switch (num3)
					{
					case 5:
						components = null;
						num = 0;
						break;
					case 0:
						((Form)this)._002Ector();
						_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
						if (_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
						{
							num = 4;
							break;
						}
						goto end_IL_0078;
					default:
						goto IL_0047;
					case 1:
					case 2:
						InitializeComponent();
						goto IL_0047;
					case 6:
						return;
					}
					goto end_IL_0074;
					IL_0047:
					((Form)(object)this).SetLogViewer(txtLog);
					num3 = 6;
					continue;
					end_IL_0078:
					break;
				}
				num2 = 1;
				continue;
				end_IL_0074:
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MainWindow(string[] args)
	{
		//Discarded unreachable code: IL_0005, IL_0064
		//IL_0006: Incompatible stack heights: 0 vs 1
		int num = 0;
		if (false)
		{
			goto IL_0016;
		}
		goto IL_006d;
		IL_006d:
		int num3 = default(int);
		string text = default(string);
		string[] array = default(string[]);
		int num4;
		while (true)
		{
			IL_006d_2:
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 7:
					break;
				case 4:
					goto IL_004e;
				case 11:
					num3 = 0;
					goto IL_0125;
				default:
					goto IL_00b6;
				case 14:
					goto IL_00c4;
				case 13:
					goto IL_00db;
				case 3:
					goto IL_00f2;
				case 2:
				case 9:
					if (!Directory.Exists(text))
					{
						goto IL_004e;
					}
					goto IL_0117;
				case 1:
				case 5:
					goto IL_0125;
				case 0:
					if (S7EI44sMaZQ92MiG6X.EmWT1u1C4(88))
					{
						num2 = 3;
						continue;
					}
					return;
				case 12:
					lstPaths.get_Items().Add((object)text);
					num2 = 4;
					continue;
				case 6:
				case 8:
					if (!File.Exists(text))
					{
						goto case 2;
					}
					goto IL_0117;
				case 10:
					array = args;
					num = 11;
					goto IL_006d_2;
				case 15:
					return;
					IL_0117:
					num = 12;
					goto IL_006d_2;
				}
				break;
				IL_00db:
				InitializeComponent();
				num = 14;
				if (0 == 0)
				{
					goto IL_006d_2;
				}
				goto IL_00f2;
				IL_00f2:
				components = null;
				num4 = 7;
				goto IL_0069;
				IL_00c4:
				((Form)(object)this).SetLogViewer(txtLog);
				num4 = 10;
				goto IL_0069;
				IL_00b6:
				num = 5;
				goto IL_006d_2;
				IL_0125:
				if (num3 < array.Length)
				{
					text = array[num3];
					_ = 0;
					if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
					{
						num = 6;
						if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
						{
							goto IL_006d_2;
						}
						goto IL_004e;
					}
					num2 = 2;
					continue;
				}
				num = 15;
				goto IL_006d_2;
				IL_004e:
				num3++;
				num4 = 1;
				goto IL_0069;
			}
			break;
		}
		goto IL_0016;
		IL_0016:
		((Form)this)._002Ector();
		num4 = 13;
		goto IL_0069;
		IL_0069:
		num = num4;
		goto IL_006d;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void MainWindow_Load(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		((ListControl)lstExts).set_SelectedIndex(6);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void btnAddFile_Click(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0005, IL_004d, IL_01be
		//IL_0006: Incompatible stack heights: 0 vs 1
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Invalid comparison between Unknown and I4
		_ = 0;
		int num;
		if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
		{
			num = 2;
			goto IL_0052;
		}
		int num2 = 3;
		goto IL_005a;
		IL_005a:
		OpenFileDialog val = default(OpenFileDialog);
		switch (num2)
		{
		case 0:
		case 2:
			if (S7EI44sMaZQ92MiG6X.EmWT1u1C4(92))
			{
				return;
			}
			val = new OpenFileDialog();
			goto case 4;
		case 1:
			return;
		case 3:
			return;
		case 4:
			try
			{
				((FileDialog)val).set_Title(S7EI44sMaZQ92MiG6X.pA2PN5iOW(1992));
				int num3 = 10;
				string[] fileNames = default(string[]);
				string[] array = default(string[]);
				bool flag = default(bool);
				int num6 = default(int);
				string text = default(string);
				ObjectCollection items = default(ObjectCollection);
				bool flag2 = default(bool);
				while (true)
				{
					int num4 = num3;
					while (true)
					{
						int num5 = num4;
						while (true)
						{
							switch (num5)
							{
							case 2:
								break;
							case 6:
								goto IL_00bb;
							case 11:
								goto IL_00d5;
							case 16:
								goto IL_00e5;
							case 7:
								if (fileNames != null)
								{
									num5 = 13;
									continue;
								}
								return;
							case 1:
							case 20:
								goto IL_0107;
							case 18:
								((FileDialog)val).set_CheckPathExists(true);
								num4 = 17;
								if (0 == 0)
								{
									goto end_IL_01cb;
								}
								goto case 12;
							case 12:
								array = fileNames;
								num5 = 16;
								continue;
							case 10:
								((FileDialog)val).set_CheckFileExists(true);
								num5 = 18;
								continue;
							case 17:
								val.set_Multiselect(true);
								num4 = 2;
								if (true)
								{
									goto end_IL_01cb;
								}
								goto case 0;
							case 13:
								if (fileNames.Length != 0)
								{
									goto case 12;
								}
								return;
							default:
								num5 = 12;
								continue;
							case 3:
								goto IL_0236;
							case 5:
							case 9:
								flag = (int)((CommonDialog)val).ShowDialog() == 1;
								num3 = 11;
								goto end_IL_01c7;
							case 0:
							case 14:
								if (num6 < array.Length)
								{
									text = array[num6];
									num4 = 15;
									goto end_IL_01cb;
								}
								num5 = 22;
								continue;
							case 8:
								lstPaths.get_Items().Add((object)text);
								num5 = 1;
								continue;
							case 4:
							case 21:
								((FileDialog)val).set_InitialDirectory(Application.get_StartupPath());
								goto case 5;
							case 15:
								items = lstPaths.get_Items();
								num4 = 3;
								goto end_IL_01cb;
							case 19:
								fileNames = ((FileDialog)val).get_FileNames();
								num4 = 7;
								if (1 == 0)
								{
									return;
								}
								goto end_IL_01cb;
							case 22:
								return;
							}
							((FileDialog)val).set_SupportMultiDottedExtensions(true);
							_ = 0;
							if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
							{
								num4 = 21;
								if (0 == 0)
								{
									break;
								}
								goto IL_00bb;
							}
							num4 = 9;
							break;
							IL_0236:
							flag2 = !items.Contains((object)text);
							num3 = 6;
							goto end_IL_01c7;
							IL_0107:
							num6++;
							num3 = 0;
							goto end_IL_01c7;
							IL_00e5:
							num6 = 0;
							num4 = 14;
							break;
							IL_00bb:
							if (flag2)
							{
								num4 = 8;
								if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
								{
									break;
								}
								goto IL_00d5;
							}
							((Form)(object)this).Log(text + S7EI44sMaZQ92MiG6X.pA2PN5iOW(1996));
							num5 = 20;
							continue;
							IL_00d5:
							if (flag)
							{
								num3 = 19;
								goto end_IL_01c7;
							}
							return;
							continue;
							end_IL_01cb:
							break;
						}
						continue;
						end_IL_01c7:
						break;
					}
				}
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		num = 4;
		goto IL_0052;
		IL_0052:
		int num7 = num;
		num2 = num7;
		goto IL_005a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void btnRemovePath_Click(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0005, IL_004c
		//IL_0006: Incompatible stack heights: 0 vs 1
		int num = 0;
		if (1 == 0)
		{
			goto IL_0016;
		}
		goto IL_0055;
		IL_0055:
		int num2 = num;
		goto IL_0059;
		IL_0059:
		bool flag = default(bool);
		int selectedIndex = default(int);
		while (true)
		{
			int num3;
			switch (num2)
			{
			case 0:
				break;
			case 2:
			case 3:
				if (flag)
				{
					goto case 6;
				}
				return;
			default:
				num3 = 6;
				goto IL_0051;
			case 5:
				((ListControl)lstPaths).set_SelectedIndex((selectedIndex < lstPaths.get_Items().get_Count()) ? selectedIndex : (selectedIndex - 1));
				((Control)lstPaths).Focus();
				num2 = 7;
				continue;
			case 1:
			case 4:
				flag = selectedIndex != -1;
				goto case 2;
			case 6:
				lstPaths.get_Items().RemoveAt(selectedIndex);
				num3 = 5;
				goto IL_0051;
			case 7:
				return;
				IL_0051:
				num = num3;
				goto IL_0055;
			}
			break;
		}
		goto IL_0016;
		IL_0016:
		selectedIndex = ((ListControl)lstPaths).get_SelectedIndex();
		_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
		if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
		{
			num = 4;
			goto IL_0055;
		}
		num2 = 3;
		goto IL_0059;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void btnAddFolder_Click(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0005, IL_0056, IL_00c2
		//IL_0006: Incompatible stack heights: 0 vs 1
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fd: Invalid comparison between Unknown and I4
		_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
		int num;
		if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
		{
			num = 3;
			if (1 == 0)
			{
				goto IL_0026;
			}
		}
		else
		{
			num = 2;
		}
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 0:
			case 3:
				break;
			case 1:
				return;
			case 2:
				return;
			default:
				num2 = 4;
				continue;
			case 4:
				goto IL_0086;
			}
			break;
		}
		goto IL_0026;
		IL_0026:
		if (S7EI44sMaZQ92MiG6X.EmWT1u1C4(96))
		{
			return;
		}
		FolderBrowserDialog val = new FolderBrowserDialog();
		goto IL_0086;
		IL_0086:
		try
		{
			val.set_Description(S7EI44sMaZQ92MiG6X.pA2PN5iOW(2000));
			int num3 = 9;
			string selectedPath = default(string);
			bool flag3 = default(bool);
			bool flag2 = default(bool);
			ObjectCollection items = default(ObjectCollection);
			bool flag = default(bool);
			while (true)
			{
				int num5;
				int num4;
				switch (num3)
				{
				case 6:
					selectedPath = val.get_SelectedPath();
					num3 = 3;
					break;
				case 3:
					flag3 = !string.IsNullOrEmpty(selectedPath);
					goto case 8;
				default:
					num5 = 8;
					goto IL_00c7;
				case 9:
					val.set_ShowNewFolderButton(true);
					_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
					if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
					{
						num5 = 4;
						goto IL_00c7;
					}
					num4 = 5;
					if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
					{
						goto IL_00cb;
					}
					goto case 8;
				case 1:
				case 4:
					val.set_RootFolder(Environment.SpecialFolder.MyComputer);
					num5 = 0;
					goto IL_00c7;
				case 11:
					flag2 = !items.Contains((object)selectedPath);
					num4 = 13;
					if (0 == 0)
					{
						goto IL_00cb;
					}
					goto case 7;
				case 7:
					if (flag)
					{
						num4 = 6;
						if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
						{
							goto IL_00cb;
						}
						goto case 12;
					}
					return;
				case 12:
					items = lstPaths.get_Items();
					num4 = 11;
					if (1 == 0)
					{
						return;
					}
					goto IL_00cb;
				case 2:
					return;
				case 5:
				case 10:
					lstPaths.get_Items().Add((object)selectedPath);
					num4 = 2;
					if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
					{
						goto IL_00cb;
					}
					goto case 13;
				case 0:
					flag = (int)((CommonDialog)val).ShowDialog() == 1;
					num3 = 7;
					break;
				case 13:
					if (!flag2)
					{
						((Form)(object)this).Log(selectedPath + S7EI44sMaZQ92MiG6X.pA2PN5iOW(1996));
						num4 = 14;
						if (true)
						{
							goto IL_00cb;
						}
					}
					goto case 5;
				case 8:
					if (flag3)
					{
						num5 = 12;
						goto IL_00c7;
					}
					return;
				case 14:
					return;
					IL_00c7:
					num4 = num5;
					goto IL_00cb;
					IL_00cb:
					num3 = num4;
					break;
				}
			}
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CbtnEncrypt_Click_003Ed__6))]
	[DebuggerStepThrough]
	private void btnEncrypt_Click(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0005, IL_00ae
		//IL_0006: Incompatible stack heights: 0 vs 1
		int num = 4;
		AsyncVoidMethodBuilder _003C_003Et__builder = default(AsyncVoidMethodBuilder);
		_003CbtnEncrypt_Click_003Ed__6 stateMachine = default(_003CbtnEncrypt_Click_003Ed__6);
		while (true)
		{
			int num2;
			switch (num)
			{
			case 1:
				_003C_003Et__builder.Start(ref stateMachine);
				num2 = 10;
				goto IL_00b7;
			case 4:
				stateMachine = new _003CbtnEncrypt_Click_003Ed__6();
				num = 6;
				break;
			case 3:
				_003C_003Et__builder = stateMachine._003C_003Et__builder;
				num2 = 1;
				goto IL_00b7;
			case 0:
				stateMachine.e = e;
				num = 9;
				break;
			case 6:
				while (true)
				{
					stateMachine._003C_003E4__this = this;
					_ = 0;
					if (!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
					{
						break;
					}
					num2 = 8;
					if (!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
					{
						continue;
					}
					goto IL_00b7;
				}
				num = 7;
				break;
			case 2:
			case 8:
				stateMachine.sender = sender;
				num2 = 0;
				goto IL_00b7;
			case 9:
				stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
				goto default;
			default:
				stateMachine._003C_003E1__state = -1;
				num2 = 3;
				goto IL_00b7;
			case 10:
				return;
				IL_00b7:
				num = num2;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(_003CbtnDecrypt_Click_003Ed__7))]
	private void btnDecrypt_Click(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0005, IL_008b
		//IL_0006: Incompatible stack heights: 0 vs 1
		_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
		int num;
		if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
		{
			num = 7;
			if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
			{
				goto IL_0094;
			}
			goto IL_00e4;
		}
		int num2 = 2;
		goto IL_0090;
		IL_0118:
		_003CbtnDecrypt_Click_003Ed__7 stateMachine = default(_003CbtnDecrypt_Click_003Ed__7);
		stateMachine._003C_003E4__this = this;
		int num3 = 9;
		goto IL_0098;
		IL_00e4:
		stateMachine.sender = sender;
		num = 6;
		if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
		{
			goto IL_0094;
		}
		goto IL_0118;
		IL_0090:
		num = num2;
		goto IL_0094;
		IL_0094:
		num3 = num;
		goto IL_0098;
		IL_0098:
		AsyncVoidMethodBuilder _003C_003Et__builder = default(AsyncVoidMethodBuilder);
		while (true)
		{
			switch (num3)
			{
			case 3:
				break;
			case 0:
			case 7:
				goto IL_0050;
			case 6:
				stateMachine.e = e;
				goto case 2;
			case 2:
			case 4:
				stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
				goto case 8;
			default:
				num3 = 8;
				continue;
			case 1:
				goto IL_00d3;
			case 9:
				goto end_IL_0098;
			case 8:
				stateMachine._003C_003E1__state = -1;
				num = 1;
				goto IL_0094;
			case 5:
				goto IL_0118;
			case 10:
				return;
			}
			_003C_003Et__builder.Start(ref stateMachine);
			num = 10;
			if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
			{
				goto IL_0094;
			}
			goto IL_00d3;
			IL_0050:
			stateMachine = new _003CbtnDecrypt_Click_003Ed__7();
			num = 5;
			goto IL_0094;
			IL_00d3:
			_003C_003Et__builder = stateMachine._003C_003Et__builder;
			num2 = 3;
			goto IL_0090;
			continue;
			end_IL_0098:
			break;
		}
		goto IL_00e4;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void lblInfo_Click(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		Process.Start(S7EI44sMaZQ92MiG6X.pA2PN5iOW(2004));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void lstPaths_DragDrop(object sender, DragEventArgs e)
	{
		//Discarded unreachable code: IL_0005, IL_0058, IL_0111
		//IL_0006: Incompatible stack heights: 0 vs 1
		int num = 6;
		if (false)
		{
			goto IL_0016;
		}
		goto IL_0061;
		IL_0061:
		IEnumerable<string> enumerable = default(IEnumerable<string>);
		object data = default(object);
		bool flag = default(bool);
		IEnumerator<string> enumerator = default(IEnumerator<string>);
		while (true)
		{
			IL_0061_2:
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
				case 4:
					break;
				case 0:
					enumerable = data as IEnumerable<string>;
					_ = 1;
					if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
					{
						num = 1;
						if (0 == 0)
						{
							goto IL_0061_2;
						}
						goto case 1;
					}
					num2 = 3;
					continue;
				case 1:
				case 2:
					flag = enumerable != null;
					goto case 5;
				default:
					num = 5;
					if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
					{
						goto IL_0061_2;
					}
					break;
				case 5:
					if (flag)
					{
						break;
					}
					return;
				case 6:
					data = e.get_Data().GetData(DataFormats.FileDrop, false);
					num = 0;
					goto IL_0061_2;
				case 7:
					try
					{
						while (enumerator.MoveNext())
						{
							string current = enumerator.Current;
							_ = 1;
							switch (_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091() ? 3 : 2)
							{
							case 0:
							case 2:
								lstPaths.get_Items().Add((object)current);
								break;
							}
						}
						return;
					}
					finally
					{
						enumerator?.Dispose();
					}
				}
				break;
			}
			break;
		}
		goto IL_0016;
		IL_0016:
		enumerator = enumerable.GetEnumerator();
		num = 7;
		goto IL_0061;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void lstPaths_DragEnter(object sender, DragEventArgs e)
	{
		//Discarded unreachable code: IL_0005, IL_0062
		//IL_0006: Incompatible stack heights: 0 vs 1
		_ = 0;
		int num;
		if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
		{
			num = 4;
			goto IL_0067;
		}
		int num2 = 2;
		goto IL_006f;
		IL_00a0:
		bool dataPresent = e.get_Data().GetDataPresent(DataFormats.FileDrop);
		num = 5;
		goto IL_0067;
		IL_0067:
		int num3 = num;
		goto IL_006b;
		IL_006f:
		switch (num2)
		{
		default:
			return;
		case 2:
			return;
		case 5:
			break;
		case 1:
			e.set_Effect((DragDropEffects)1);
			return;
		case 0:
		case 4:
			goto IL_00a0;
		case 6:
			return;
		}
		if (!dataPresent)
		{
			e.set_Effect((DragDropEffects)0);
			num3 = 6;
			if (_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
			{
				return;
			}
		}
		else
		{
			num3 = 1;
		}
		goto IL_006b;
		IL_006b:
		num2 = num3;
		goto IL_006f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void lstPaths_SelectedIndexChanged(object sender, EventArgs e)
	{
	}//Discarded unreachable code: IL_0005
	//IL_0006: Incompatible stack heights: 0 vs 1


	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gbPaths_Enter(object sender, EventArgs e)
	{
	}//Discarded unreachable code: IL_0005
	//IL_0006: Incompatible stack heights: 0 vs 1


	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Dispose(bool disposing)
	{
		//Discarded unreachable code: IL_0005, IL_0068
		//IL_0006: Incompatible stack heights: 0 vs 1
		_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
		int num;
		if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
		{
			num = 1;
			goto IL_0071;
		}
		int num2 = 2;
		goto IL_0075;
		IL_0075:
		while (true)
		{
			switch (num2)
			{
			case 4:
				if (components != null)
				{
					num2 = 5;
					continue;
				}
				goto default;
			case 0:
			case 1:
				if (disposing)
				{
					num = 4;
					if (true)
					{
						break;
					}
					goto case 5;
				}
				goto default;
			case 5:
				components.Dispose();
				goto default;
			default:
				((Form)this).Dispose(disposing);
				num2 = 6;
				continue;
			case 6:
				return;
			}
			break;
		}
		goto IL_0071;
		IL_0071:
		num2 = num;
		goto IL_0075;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitializeComponent()
	{
		//Discarded unreachable code: IL_0005, IL_131e
		//IL_0006: Incompatible stack heights: 0 vs 1
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected O, but got Unknown
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Expected O, but got Unknown
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Expected O, but got Unknown
		//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f3: Expected O, but got Unknown
		//IL_0563: Unknown result type (might be due to invalid IL or missing references)
		//IL_056d: Expected O, but got Unknown
		//IL_061a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0624: Expected O, but got Unknown
		//IL_0746: Unknown result type (might be due to invalid IL or missing references)
		//IL_0750: Expected O, but got Unknown
		//IL_097b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0985: Expected O, but got Unknown
		//IL_0a01: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a0b: Expected O, but got Unknown
		//IL_0af9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b03: Expected O, but got Unknown
		//IL_0bf4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bfe: Expected O, but got Unknown
		//IL_0c9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca6: Expected O, but got Unknown
		//IL_0d01: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d0b: Expected O, but got Unknown
		//IL_0e7b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e85: Expected O, but got Unknown
		//IL_0fd1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fdb: Expected O, but got Unknown
		//IL_1125: Unknown result type (might be due to invalid IL or missing references)
		//IL_112f: Expected O, but got Unknown
		//IL_1248: Unknown result type (might be due to invalid IL or missing references)
		//IL_1252: Expected O, but got Unknown
		//IL_125d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1267: Expected O, but got Unknown
		//IL_16e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_16eb: Expected O, but got Unknown
		//IL_17ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_17f6: Expected O, but got Unknown
		//IL_18d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_18de: Expected O, but got Unknown
		//IL_1929: Unknown result type (might be due to invalid IL or missing references)
		//IL_1933: Expected O, but got Unknown
		//IL_19bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_19c5: Expected O, but got Unknown
		int num = 89;
		if (_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
		{
			goto IL_001a;
		}
		goto IL_1327;
		IL_1327:
		ComponentResourceManager componentResourceManager = default(ComponentResourceManager);
		while (true)
		{
			IL_1327_2:
			int num2 = num;
			while (true)
			{
				int num3;
				switch (num2)
				{
				case 116:
					break;
				case 107:
					((Control)btnAddFolder).set_Text(S7EI44sMaZQ92MiG6X.pA2PN5iOW(2028));
					num = 169;
					goto IL_1327_2;
				case 48:
					((ListControl)lstExts).set_FormattingEnabled(true);
					num = 64;
					if (0 == 0)
					{
						goto IL_1327_2;
					}
					goto case 3;
				case 3:
					((Control)gbLog).ResumeLayout(false);
					num = 115;
					if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
					{
						goto IL_1327_2;
					}
					goto case 144;
				case 144:
					((Control)lstExts).set_Size(new Size(121, 21));
					num = 128;
					if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
					{
						goto IL_1327_2;
					}
					goto case 54;
				case 54:
					((Control)btnAddFolder).set_TabIndex(2);
					num = 107;
					goto IL_1327_2;
				case 62:
					((Control)txtPassword).set_TabIndex(0);
					num = 76;
					if (0 == 0)
					{
						goto IL_1327_2;
					}
					goto case 142;
				case 142:
					((Control)chkSubFolders).set_Size(new Size(115, 17));
					num3 = 32;
					goto IL_1323;
				case 17:
					chkDeleteOrg = new CheckBox();
					num = 177;
					goto IL_1327_2;
				case 79:
					((Control)btnDecrypt).set_Font(new Font(S7EI44sMaZQ92MiG6X.pA2PN5iOW(2116), 8f, (FontStyle)1));
					num2 = 70;
					continue;
				case 10:
					lstPaths = new ListBox();
					num = 5;
					goto IL_1327_2;
				case 80:
					lblInfo.set_TextAlign((ContentAlignment)32);
					num3 = 111;
					goto IL_1323;
				case 122:
					((Control)gbPaths).SuspendLayout();
					num = 60;
					goto IL_1327_2;
				case 50:
					((Control)chkSubFolders).set_AutoSize(true);
					num3 = 160;
					goto IL_1323;
				case 109:
					((Control)gbOptions).set_TabIndex(1);
					num2 = 58;
					continue;
				case 64:
					lstExts.get_Items().AddRange(new object[7]
					{
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(2060),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(2064),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(2068),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(2072),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(2076),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(2080),
						S7EI44sMaZQ92MiG6X.pA2PN5iOW(2084)
					});
					num3 = 95;
					goto IL_1323;
				case 126:
					((Control)gbPaths).add_Enter((EventHandler)gbPaths_Enter);
					num = 103;
					goto IL_1327_2;
				case 150:
					((Control)btnAddFolder).add_Click((EventHandler)btnAddFolder_Click);
					num = 143;
					if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
					{
						goto IL_1327_2;
					}
					goto case 110;
				case 127:
					((Control)btnEncrypt).set_Location(new Point(12, 287));
					num2 = 55;
					continue;
				case 65:
					((Control)txtPassword).set_Dock((DockStyle)5);
					num = 15;
					if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
					{
						goto IL_1327_2;
					}
					goto case 12;
				case 14:
					btnDecrypt = new Button();
					num = 124;
					if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
					{
						goto IL_1327_2;
					}
					goto case 103;
				case 103:
					((Control)btnRemovePath).set_Location(new Point(323, 95));
					num = 165;
					goto IL_1327_2;
				case 184:
					((Control)txtPassword).set_Size(new Size(398, 27));
					num = 62;
					if (true)
					{
						goto IL_1327_2;
					}
					goto case 43;
				case 43:
					((Control)lblInfo).set_TabIndex(5);
					num = 105;
					if (true)
					{
						goto IL_1327_2;
					}
					goto case 24;
				case 24:
					((Control)lblInfo).set_Location(new Point(0, 452));
					num3 = 85;
					goto IL_1323;
				case 175:
					((Control)gbLog).set_Size(new Size(401, 115));
					num3 = 130;
					goto IL_1323;
				case 128:
					((Control)lstExts).set_TabIndex(2);
					num = 50;
					if (0 == 0)
					{
						goto IL_1327_2;
					}
					goto case 111;
				case 111:
					((Control)lblInfo).add_Click((EventHandler)lblInfo_Click);
					num2 = 25;
					continue;
				case 154:
					((Control)gbPassword).set_Text(S7EI44sMaZQ92MiG6X.pA2PN5iOW(2112));
					num2 = 65;
					continue;
				case 84:
					((Control)this).get_Controls().Add((Control)(object)btnEncrypt);
					num3 = 152;
					goto IL_1323;
				case 146:
					((Control)txtLog).set_Location(new Point(3, 16));
					num2 = 81;
					continue;
				case 160:
					((Control)chkSubFolders).set_Location(new Point(6, 42));
					num = 67;
					if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
					{
						goto IL_1327_2;
					}
					goto case 0;
				case 0:
					((Control)label1).set_TabIndex(3);
					num3 = 45;
					goto IL_1323;
				case 47:
					((Control)chkDeleteOrg).set_AutoSize(true);
					num = 104;
					if (0 == 0)
					{
						goto IL_1327_2;
					}
					goto case 157;
				case 157:
					((Control)gbPassword).set_TabIndex(2);
					num = 86;
					goto IL_1327_2;
				case 151:
					((Control)this).ResumeLayout(false);
					num3 = 186;
					goto IL_1323;
				case 37:
					((Control)gbPassword).PerformLayout();
					num2 = 3;
					continue;
				case 147:
					((Control)txtPassword).set_Location(new Point(3, 16));
					num2 = 171;
					continue;
				case 181:
					((Control)gbPaths).get_Controls().Add((Control)(object)btnAddFolder);
					num2 = 97;
					continue;
				case 88:
					((Control)lblInfo).set_Dock((DockStyle)2);
					num = 148;
					if (0 == 0)
					{
						goto IL_1327_2;
					}
					goto case 105;
				case 105:
					((Control)lblInfo).set_Text(S7EI44sMaZQ92MiG6X.pA2PN5iOW(2144));
					num3 = 80;
					goto IL_1323;
				case 39:
					txtLog = new TextBox();
					num = 122;
					if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
					{
						goto IL_1327_2;
					}
					goto case 141;
				case 55:
					((Control)btnEncrypt).set_Name(S7EI44sMaZQ92MiG6X.pA2PN5iOW(2124));
					num2 = 41;
					continue;
				case 101:
					((ButtonBase)chkDeleteOrg).set_UseVisualStyleBackColor(true);
					num = 36;
					if (0 == 0)
					{
						goto IL_1327_2;
					}
					goto case 57;
				case 57:
					((Control)this).get_Controls().Add((Control)(object)gbLog);
					num2 = 156;
					continue;
				case 155:
					((Control)lstPaths).set_AllowDrop(true);
					num = 61;
					if (true)
					{
						goto IL_1327_2;
					}
					goto case 13;
				case 13:
					gbPaths.set_TabStop(false);
					num = 56;
					if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
					{
						goto IL_1327_2;
					}
					goto case 66;
				case 66:
					lstExts = new ComboBox();
					num3 = 182;
					goto IL_1323;
				case 1:
				case 176:
					return;
				case 125:
					((Control)btnDecrypt).set_TabIndex(4);
					num = 34;
					goto IL_1327_2;
				case 12:
					((Form)this).set_MaximizeBox(false);
					num3 = 136;
					goto IL_1323;
				case 19:
					((Control)lstPaths).set_Name(S7EI44sMaZQ92MiG6X.pA2PN5iOW(2040));
					num = 134;
					goto IL_1327_2;
				case 104:
					((Control)chkDeleteOrg).set_Location(new Point(7, 19));
					num3 = 18;
					goto IL_1323;
				case 70:
					((Control)btnDecrypt).set_Location(new Point(253, 287));
					num = 114;
					if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
					{
						goto IL_1327_2;
					}
					goto case 12;
				case 138:
					((Control)gbOptions).get_Controls().Add((Control)(object)chkDeleteOrg);
					num2 = 172;
					continue;
				case 152:
					((Control)this).get_Controls().Add((Control)(object)gbPassword);
					num = 113;
					if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
					{
						goto IL_1327_2;
					}
					goto case 39;
				case 124:
					lblInfo = new Label();
					num3 = 123;
					goto IL_1323;
				case 22:
					((Control)txtLog).set_Name(S7EI44sMaZQ92MiG6X.pA2PN5iOW(2156));
					num3 = 11;
					goto IL_1323;
				case 67:
					((Control)chkSubFolders).set_Name(S7EI44sMaZQ92MiG6X.pA2PN5iOW(2092));
					num = 142;
					if (true)
					{
						goto IL_1327_2;
					}
					goto case 140;
				case 140:
					((TextBoxBase)txtLog).set_WordWrap(false);
					num = 72;
					if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
					{
						goto IL_1327_2;
					}
					goto case 88;
				case 119:
					((Control)btnRemovePath).set_Size(new Size(75, 23));
					num = 98;
					if (0 == 0)
					{
						goto IL_1327_2;
					}
					goto case 170;
				case 170:
					((Control)gbPaths).set_Location(new Point(12, 12));
					num = 183;
					goto IL_1327_2;
				case 156:
					((Control)this).get_Controls().Add((Control)(object)lblInfo);
					num3 = 180;
					goto IL_1323;
				case 26:
					((Control)btnEncrypt).set_TabIndex(3);
					num = 82;
					if (0 == 0)
					{
						goto IL_1327_2;
					}
					goto case 27;
				case 27:
					((Control)btnAddFolder).set_Size(new Size(75, 23));
					num = 54;
					if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
					{
						goto IL_1327_2;
					}
					goto case 98;
				case 98:
					((Control)btnRemovePath).set_TabIndex(3);
					num = 110;
					goto IL_1327_2;
				case 77:
					((Control)lblInfo).set_Size(new Size(428, 20));
					num = 43;
					if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
					{
						goto IL_1327_2;
					}
					goto case 41;
				case 108:
					((Control)btnDecrypt).set_Size(new Size(163, 41));
					num = 125;
					goto IL_1327_2;
				case 164:
					((Form)this).add_Load((EventHandler)MainWindow_Load);
					num3 = 21;
					goto IL_1323;
				case 169:
					((ButtonBase)btnAddFolder).set_UseVisualStyleBackColor(true);
					num2 = 150;
					continue;
				case 36:
					((Control)gbPassword).get_Controls().Add((Control)(object)txtPassword);
					num3 = 69;
					goto IL_1323;
				case 179:
					((Control)chkDeleteOrg).set_TabIndex(0);
					num = 166;
					if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
					{
						goto IL_1327_2;
					}
					goto case 61;
				case 153:
					((Control)gbPassword).set_Name(S7EI44sMaZQ92MiG6X.pA2PN5iOW(2108));
					num = 91;
					goto IL_1327_2;
				case 100:
					btnRemovePath = new Button();
					num = 99;
					goto IL_1327_2;
				case 69:
					((Control)gbPassword).set_Location(new Point(12, 223));
					num = 153;
					if (true)
					{
						goto IL_1327_2;
					}
					goto case 137;
				case 137:
					((Control)btnRemovePath).add_Click((EventHandler)btnRemovePath_Click);
					num = 30;
					goto IL_1327_2;
				case 112:
					((Control)gbLog).set_Text(S7EI44sMaZQ92MiG6X.pA2PN5iOW(2152));
					num2 = 92;
					continue;
				case 28:
					gbPaths = new GroupBox();
					num = 100;
					if (true)
					{
						goto IL_1327_2;
					}
					goto case 82;
				case 82:
					((Control)btnEncrypt).set_Text(S7EI44sMaZQ92MiG6X.pA2PN5iOW(2128));
					num = 35;
					if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
					{
						goto IL_1327_2;
					}
					goto case 114;
				case 86:
					gbPassword.set_TabStop(false);
					num2 = 154;
					continue;
				case 96:
					((Control)gbPaths).get_Controls().Add((Control)(object)lstPaths);
					num = 170;
					if (true)
					{
						goto IL_1327_2;
					}
					goto case 49;
				case 49:
					gbLog.set_TabStop(false);
					num3 = 112;
					goto IL_1323;
				case 59:
					((ButtonBase)btnAddFile).set_UseVisualStyleBackColor(true);
					num2 = 94;
					continue;
				case 174:
					((Control)gbOptions).set_Text(S7EI44sMaZQ92MiG6X.pA2PN5iOW(2048));
					num = 161;
					if (0 == 0)
					{
						goto IL_1327_2;
					}
					goto case 75;
				case 75:
					((Control)gbLog).set_Name(S7EI44sMaZQ92MiG6X.pA2PN5iOW(2148));
					num2 = 175;
					continue;
				case 5:
					gbOptions = new GroupBox();
					num = 7;
					if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
					{
						goto IL_1327_2;
					}
					goto case 6;
				case 6:
					((Control)label1).set_Size(new Size(64, 13));
					num3 = 0;
					goto IL_1323;
				case 162:
					((Control)gbOptions).ResumeLayout(false);
					num2 = 83;
					continue;
				case 185:
					((Control)gbLog).SuspendLayout();
					num2 = 20;
					continue;
				case 161:
					((Control)label1).set_AutoSize(true);
					num3 = 121;
					goto IL_1323;
				case 72:
					((Control)this).set_AllowDrop(true);
					num = 173;
					if (true)
					{
						goto IL_1327_2;
					}
					goto case 71;
				case 71:
					((ButtonBase)chkSubFolders).set_UseVisualStyleBackColor(true);
					num = 47;
					if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
					{
						goto IL_1327_2;
					}
					goto case 180;
				case 180:
					((Control)this).get_Controls().Add((Control)(object)btnDecrypt);
					num3 = 84;
					goto IL_1323;
				case 60:
					((Control)gbOptions).SuspendLayout();
					num3 = 178;
					goto IL_1323;
				case 139:
					((Form)this).set_Icon((Icon)componentResourceManager.GetObject(S7EI44sMaZQ92MiG6X.pA2PN5iOW(408)));
					num2 = 12;
					continue;
				case 130:
					((Control)gbLog).set_TabIndex(6);
					num3 = 49;
					goto IL_1323;
				case 87:
					lstPaths.add_SelectedIndexChanged((EventHandler)lstPaths_SelectedIndexChanged);
					num = 73;
					goto IL_1327_2;
				case 148:
					((Control)lblInfo).set_ForeColor(SystemColors.ControlDarkDark);
					num = 24;
					goto IL_1327_2;
				case 61:
					((ListControl)lstPaths).set_FormattingEnabled(true);
					num2 = 16;
					continue;
				case 173:
					((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
					num2 = 145;
					continue;
				case 182:
					chkSubFolders = new CheckBox();
					num2 = 17;
					continue;
				case 51:
					((Control)txtLog).set_Dock((DockStyle)5);
					num3 = 146;
					goto IL_1323;
				case 120:
					((Control)txtLog).set_Size(new Size(395, 96));
					num2 = 63;
					continue;
				case 90:
					((ButtonBase)btnDecrypt).set_UseVisualStyleBackColor(true);
					num2 = 118;
					continue;
				case 99:
					btnAddFolder = new Button();
					num2 = 135;
					continue;
				case 40:
				case 46:
					((ButtonBase)btnRemovePath).set_UseVisualStyleBackColor(true);
					num3 = 137;
					goto IL_1323;
				case 89:
					if (!S7EI44sMaZQ92MiG6X.EmWT1u1C4(100))
					{
						componentResourceManager = new ComponentResourceManager(Type.GetTypeFromHandle(cdDYJXxtRNHGdUNTh2.e53w34m968awCm9P85taUZe(33554442)));
						num = 28;
						if (0 == 0)
						{
							goto IL_1327_2;
						}
						goto case 125;
					}
					_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
					if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
					{
						num3 = 176;
						goto IL_1323;
					}
					num = 46;
					goto IL_1327_2;
				case 31:
					((Control)label1).set_Name(S7EI44sMaZQ92MiG6X.pA2PN5iOW(2052));
					num = 6;
					if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
					{
						goto IL_1327_2;
					}
					goto case 59;
				case 166:
					((Control)chkDeleteOrg).set_Text(S7EI44sMaZQ92MiG6X.pA2PN5iOW(2104));
					num = 101;
					if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
					{
						goto IL_1327_2;
					}
					goto case 43;
				case 131:
					((Control)btnAddFile).set_Text(S7EI44sMaZQ92MiG6X.pA2PN5iOW(2036));
					num2 = 59;
					continue;
				case 76:
					txtPassword.set_TextAlign((HorizontalAlignment)2);
					num = 167;
					goto IL_1327_2;
				case 178:
					((Control)gbPassword).SuspendLayout();
					num2 = 185;
					continue;
				case 42:
					((Control)gbPaths).set_TabIndex(0);
					num = 13;
					goto IL_1327_2;
				case 121:
					((Control)label1).set_Location(new Point(205, 43));
					num2 = 31;
					continue;
				case 171:
					((Control)txtPassword).set_Name(S7EI44sMaZQ92MiG6X.pA2PN5iOW(2120));
					num = 68;
					if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
					{
						goto IL_1327_2;
					}
					goto case 107;
				case 73:
					((Control)lstPaths).add_DragDrop(new DragEventHandler(lstPaths_DragDrop));
					num2 = 44;
					continue;
				case 68:
					txtPassword.set_PasswordChar('*');
					num3 = 184;
					goto IL_1323;
				case 58:
					gbOptions.set_TabStop(false);
					num = 174;
					if (true)
					{
						goto IL_1327_2;
					}
					goto case 115;
				case 115:
					((Control)gbLog).PerformLayout();
					num = 151;
					if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
					{
						goto IL_1327_2;
					}
					goto case 182;
				case 33:
					((Control)this).set_Text(S7EI44sMaZQ92MiG6X.pA2PN5iOW(2164));
					num3 = 164;
					goto IL_1323;
				case 23:
					((Control)gbOptions).get_Controls().Add((Control)(object)lstExts);
					num = 163;
					goto IL_1327_2;
				case 149:
					((Control)gbPaths).get_Controls().Add((Control)(object)btnRemovePath);
					num3 = 181;
					goto IL_1323;
				case 85:
					((Control)lblInfo).set_Name(S7EI44sMaZQ92MiG6X.pA2PN5iOW(2140));
					num = 77;
					goto IL_1327_2;
				case 29:
					((Control)gbOptions).get_Controls().Add((Control)(object)label1);
					num2 = 23;
					continue;
				case 95:
					((Control)lstExts).set_Location(new Point(277, 40));
					num2 = 38;
					continue;
				case 163:
					((Control)gbOptions).get_Controls().Add((Control)(object)chkSubFolders);
					num3 = 138;
					goto IL_1323;
				case 135:
					btnAddFile = new Button();
					num = 10;
					if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
					{
						goto IL_1327_2;
					}
					goto case 141;
				case 141:
					((Control)gbOptions).set_Size(new Size(404, 69));
					num3 = 109;
					goto IL_1323;
				case 113:
					((Control)this).get_Controls().Add((Control)(object)gbOptions);
					num = 133;
					if (0 == 0)
					{
						goto IL_1327_2;
					}
					goto case 16;
				case 16:
					lstPaths.set_HorizontalScrollbar(true);
					num = 132;
					if (true)
					{
						goto IL_1327_2;
					}
					goto case 91;
				case 91:
					((Control)gbPassword).set_Size(new Size(404, 48));
					num = 157;
					if (true)
					{
						goto IL_1327_2;
					}
					goto case 53;
				case 53:
					((Form)this).set_ClientSize(new Size(428, 472));
					num2 = 57;
					continue;
				case 18:
					((Control)chkDeleteOrg).set_Name(S7EI44sMaZQ92MiG6X.pA2PN5iOW(2100));
					num = 159;
					if (0 == 0)
					{
						goto IL_1327_2;
					}
					goto case 143;
				case 143:
					((Control)btnAddFile).set_Location(new Point(7, 95));
					num = 52;
					goto IL_1327_2;
				case 52:
					((Control)btnAddFile).set_Name(S7EI44sMaZQ92MiG6X.pA2PN5iOW(2032));
					num = 8;
					if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
					{
						goto IL_1327_2;
					}
					goto case 168;
				case 92:
					((Control)txtLog).set_BackColor(Color.White);
					num3 = 51;
					goto IL_1323;
				case 177:
					gbPassword = new GroupBox();
					num = 9;
					goto IL_1327_2;
				case 93:
					((Form)this).set_StartPosition((FormStartPosition)1);
					num3 = 33;
					goto IL_1323;
				case 34:
					((Control)btnDecrypt).set_Text(S7EI44sMaZQ92MiG6X.pA2PN5iOW(2136));
					num2 = 90;
					continue;
				case 133:
					((Control)this).get_Controls().Add((Control)(object)gbPaths);
					num = 139;
					goto IL_1327_2;
				case 110:
					((Control)btnRemovePath).set_Text(S7EI44sMaZQ92MiG6X.pA2PN5iOW(2020));
					goto case 40;
				case 106:
					((Control)gbPassword).ResumeLayout(false);
					num = 37;
					goto IL_1327_2;
				case 35:
					((ButtonBase)btnEncrypt).set_UseVisualStyleBackColor(true);
					num = 4;
					if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
					{
						goto IL_1327_2;
					}
					goto case 21;
				case 21:
					((Control)gbPaths).ResumeLayout(false);
					num = 162;
					if (0 == 0)
					{
						goto IL_1327_2;
					}
					goto case 81;
				case 81:
					((TextBoxBase)txtLog).set_Multiline(true);
					num = 22;
					if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
					{
						goto IL_1327_2;
					}
					goto case 11;
				case 11:
					((TextBoxBase)txtLog).set_ReadOnly(true);
					num2 = 116;
					continue;
				case 7:
					label1 = new Label();
					num3 = 66;
					goto IL_1323;
				case 9:
					txtPassword = new TextBox();
					num3 = 78;
					goto IL_1323;
				case 41:
					((Control)btnEncrypt).set_Size(new Size(163, 41));
					num3 = 26;
					goto IL_1323;
				case 118:
					((Control)btnDecrypt).add_Click((EventHandler)btnDecrypt_Click);
					num = 88;
					if (true)
					{
						goto IL_1327_2;
					}
					goto case 25;
				case 25:
					((Control)gbLog).get_Controls().Add((Control)(object)txtLog);
					num3 = 168;
					goto IL_1323;
				case 165:
					((Control)btnRemovePath).set_Name(S7EI44sMaZQ92MiG6X.pA2PN5iOW(2016));
					num3 = 119;
					goto IL_1323;
				case 20:
					((Control)this).SuspendLayout();
					num3 = 149;
					goto IL_1323;
				case 32:
					((Control)chkSubFolders).set_TabIndex(1);
					goto case 102;
				default:
					num = 102;
					if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
					{
						goto IL_1327_2;
					}
					goto case 143;
				case 4:
					((Control)btnEncrypt).add_Click((EventHandler)btnEncrypt_Click);
					num2 = 79;
					continue;
				case 172:
					((Control)gbOptions).set_Location(new Point(12, 148));
					num = 2;
					goto IL_1327_2;
				case 56:
					((Control)gbPaths).set_Text(S7EI44sMaZQ92MiG6X.pA2PN5iOW(2012));
					num = 126;
					if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
					{
						goto IL_1327_2;
					}
					goto case 77;
				case 114:
					((Control)btnDecrypt).set_Name(S7EI44sMaZQ92MiG6X.pA2PN5iOW(2132));
					num3 = 108;
					goto IL_1323;
				case 167:
					((Control)btnEncrypt).set_Font(new Font(S7EI44sMaZQ92MiG6X.pA2PN5iOW(2116), 8f, (FontStyle)1));
					num2 = 127;
					continue;
				case 136:
					((Control)this).set_Name(S7EI44sMaZQ92MiG6X.pA2PN5iOW(2160));
					num2 = 93;
					continue;
				case 132:
					((Control)lstPaths).set_Location(new Point(6, 19));
					num = 19;
					goto IL_1327_2;
				case 30:
					((Control)btnAddFolder).set_Location(new Point(88, 95));
					num2 = 117;
					continue;
				case 94:
					((Control)btnAddFile).add_Click((EventHandler)btnAddFile_Click);
					num = 155;
					if (0 == 0)
					{
						goto IL_1327_2;
					}
					goto case 117;
				case 117:
					((Control)btnAddFolder).set_Name(S7EI44sMaZQ92MiG6X.pA2PN5iOW(2024));
					num3 = 27;
					goto IL_1323;
				case 97:
					((Control)gbPaths).get_Controls().Add((Control)(object)btnAddFile);
					num = 96;
					if (0 == 0)
					{
						goto IL_1327_2;
					}
					goto case 129;
				case 129:
					((Control)btnAddFile).set_TabIndex(1);
					num2 = 131;
					continue;
				case 15:
					((Control)txtPassword).set_Font(new Font(S7EI44sMaZQ92MiG6X.pA2PN5iOW(2116), 12f, (FontStyle)1));
					num3 = 147;
					goto IL_1323;
				case 145:
					((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
					num2 = 53;
					continue;
				case 159:
					((Control)chkDeleteOrg).set_Size(new Size(117, 17));
					num = 179;
					goto IL_1327_2;
				case 2:
					((Control)gbOptions).set_Name(S7EI44sMaZQ92MiG6X.pA2PN5iOW(2044));
					num2 = 141;
					continue;
				case 74:
					((Control)lstPaths).set_TabIndex(0);
					num = 87;
					if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
					{
						goto IL_1327_2;
					}
					goto case 83;
				case 83:
					((Control)gbOptions).PerformLayout();
					num = 106;
					goto IL_1327_2;
				case 8:
					((Control)btnAddFile).set_Size(new Size(75, 23));
					num = 129;
					if (true)
					{
						goto IL_1327_2;
					}
					goto case 45;
				case 45:
					((Control)label1).set_Text(S7EI44sMaZQ92MiG6X.pA2PN5iOW(2056));
					num3 = 48;
					goto IL_1323;
				case 123:
					gbLog = new GroupBox();
					num = 39;
					if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
					{
						goto IL_1327_2;
					}
					goto case 8;
				case 158:
					((Control)gbPaths).set_Size(new Size(404, 130));
					num3 = 42;
					goto IL_1323;
				case 44:
					((Control)lstPaths).add_DragEnter(new DragEventHandler(lstPaths_DragEnter));
					num = 29;
					if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
					{
						goto IL_1327_2;
					}
					goto case 94;
				case 38:
					((Control)lstExts).set_Name(S7EI44sMaZQ92MiG6X.pA2PN5iOW(2088));
					num = 144;
					if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
					{
						goto IL_1327_2;
					}
					goto case 102;
				case 102:
					((Control)chkSubFolders).set_Text(S7EI44sMaZQ92MiG6X.pA2PN5iOW(2096));
					num = 71;
					goto IL_1327_2;
				case 134:
					((Control)lstPaths).set_Size(new Size(392, 69));
					num2 = 74;
					continue;
				case 78:
					btnEncrypt = new Button();
					num2 = 14;
					continue;
				case 183:
					((Control)gbPaths).set_Name(S7EI44sMaZQ92MiG6X.pA2PN5iOW(2008));
					num3 = 158;
					goto IL_1323;
				case 168:
					((Control)gbLog).set_Location(new Point(12, 334));
					num3 = 75;
					goto IL_1323;
				case 63:
					((Control)txtLog).set_TabIndex(0);
					num3 = 140;
					goto IL_1323;
				case 186:
					return;
					IL_1323:
					num = num3;
					goto IL_1327_2;
				}
				break;
			}
			break;
		}
		goto IL_001a;
		IL_001a:
		txtLog.set_ScrollBars((ScrollBars)3);
		num = 120;
		goto IL_1327;
	}

	internal static bool _0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092()
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		return true;
	}

	internal static bool _008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091()
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		return false;
	}
}
