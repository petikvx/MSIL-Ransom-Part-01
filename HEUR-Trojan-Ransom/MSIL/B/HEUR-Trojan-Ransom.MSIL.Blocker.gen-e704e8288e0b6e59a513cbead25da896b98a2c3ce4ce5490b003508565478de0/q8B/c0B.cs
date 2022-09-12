using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Ba50;
using Cd1t;
using Ci75;
using Es0;
using Microsoft.VisualBasic.CompilerServices;
using Mn1k;
using Ri5n;
using Wa6;
using Wj6t;
using Wt27;
using Wz7;
using Xo8;
using Xs5;
using a9D;
using c4ZK;
using e6H;
using j3B;
using s1Y;
using t5D;
using x9E1;

namespace q8B;

[DesignerGenerated]
public class c0B : Form
{
	private IContainer components;

	private string cs;

	private SqlConnection cn;

	private SqlCommand cmd;

	private SqlDataReader rd;

	internal static k8NS k8NS_0/* Not supported: data(59 53 00 00 50 2D 00 00 8E EA 00 00 2B 12 00 00 43 DF 00 00 89 9F 00 00 E7 58 00 00 CA 6D 00 00 03 86 00 00 DB 79 00 00 BD 33 00 00 96 6D 00 00 07 8A 00 00 67 F8 00 00 E2 C1 00 00 66 C1 00 00 7C 48 00 00 E6 3A 00 00 B0 BA 00 00 AF EE 00 00 76 82 00 00 50 6C 00 00 BE A7 00 00 6A 11 00 00 15 7F 00 00 6D DB 00 00 62 FD 00 00 29 CD 00 00 25 43 00 00 52 94 00 00 D4 47 00 00 18 4F 00 00 0A C5 00 00 82 96 00 00 8F 1A 00 00 E2 2E 00 00 6D E9 00 00 79 71 00 00 F2 9A 00 00 8E B1 00 00 2E 7D 00 00 FE D4 00 00 93 CB 00 00 8E 11 00 00 42 3F 00 00 AD 68 00 00 9E 36 00 00 EC BC 00 00 15 BA 00 00 00 EA 00 00 1C B6 00 00 B7 70 00 00 3E B5 00 00 45 A3 00 00 9A B8 00 00 08 E7 00 00 91 85 00 00 24 D9 00 00 15 93 00 00 D5 03 00 00 25 A2 00 00 BD 8B 00 00 A4 2A 00 00 AF F1 00 00 07 32 00 00 A3 E4 00 00 8A A8 00 00 83 F3 00 00 D7 DD 00 00 FF 92 00 00 F8 D7 00 00 02 D7 00 00 F2 9F 00 00 22 09 00 00 80 71 00 00 77 AD 00 00 BC A0 00 00 2F 96 00 00 26 D2 00 00 68 16 00 00 CE A4 00 00 76 40 00 00 13 13 00 00 24 59 00 00 34 DE 00 00 1B D7 00 00 D9 99 00 00 C5 21 00 00 E6 DD 00 00 86 33 00 00 4F A9 00 00 49 10 00 00 62 DE 00 00 1D 97 00 00 68 0F 00 00 70 F1 00 00 59 AA 00 00 E2 D9 00 00 86 DF 00 00 9E 5A 00 00 21 C0 00 00 1A 43 00 00 14 DF 00 00 15 27 00 00 07 12 00 00 18 DF 00 00 C4 D0 00 00 1C AC 00 00 C5 31 00 00 23 0B 00 00 4B 46 00 00 61 EF 00 00 FD 06 00 00 AC 7C 00 00 06 5F 00 00 AF 61 00 00 A9 78 00 00 7F D1 00 00 7B 13 00 00 EA 5A 00 00 CA 4A 00 00 C4 86 00 00 9C 15 00 00 50 AA 00 00 AF E9 00 00 AE C7 00 00 9E F8 00 00 D5 08 00 00 B8 F9 00 00 0F 80 00 00 1D 03 00 00 D8 C6 00 00 A7 B6 00 00 88 77 00 00 45 56 00 00 B4 61 00 00 60 61 00 00 FD EB 00 00 1C 47 00 00 1A FF 00 00 57 06 00 00 BB ED 00 00 FF EF 00 00 C3 D2 00 00 3A ED 00 00 ED B9 00 00 4C 09 00 00 B6 61 00 00 17 38 00 00 B7 AD 00 00 C7 78 00 00 D8 D8 00 00 67 C6 00 00 9B 84 00 00 D3 0F 00 00 5D 39 00 00 7D 2D 00 00 C3 34 00 00 65 3D 00 00 57 4A 00 00 79 E6 00 00 EE C7 00 00 63 B2 00 00 B4 B1 00 00 05 08 00 00 71 7F 00 00 B9 38 00 00 73 8F 00 00 66 26 00 00 50 FD 00 00 4F 00 00 00 AA 8C 00 00 63 8A 00 00 5F 14 00 00 93 54 00 00 0D 5D 00 00 C4 96 00 00 D8 42 00 00 15 BD 00 00 C1 2F 00 00 62 BE 00 00 E7 96 00 00 BD D0 00 00 00 4C 00 00 48 07 00 00 43 2A 00 00 71 00 00 00 0B 32 00 00 B4 67 00 00 E8 1C 00 00 36 34 00 00 9D 2C 00 00 98 AE 00 00 C3 FC 00 00 A1 18 00 00 67 3E 00 00 58 3B 00 00 4A 3E 00 00 BD CA 00 00 C8 6D 00 00 34 81 00 00 D7 79 00 00 50 3B 00 00 C5 3A 00 00 68 AD 00 00 1B EC 00 00 75 4E 00 00 07 B2 00 00 08 30 00 00 C5 B2 00 00 97 A2 00 00 A4 EA 00 00 AD 77 00 00 A4 0D 00 00 F3 8B 00 00 91 4F 00 00 30 F7 00 00 62 66 00 00 6C AA 00 00 C1 DD 00 00 FF 7E 00 00 AD 06 00 00 BE 27 00 00 7D 09 00 00 1A C9 00 00 B0 D3 00 00 11 DE 00 00 9E 8D 00 00 BC FB 00 00 2B 16 00 00 B4 21 00 00 7A 58 00 00 19 78 00 00 4D 4F 00 00 8C AE 00 00 8B 44 00 00 97 5B 00 00 F7 95 00 00 96 9E 00 00 2B 1B 00 00 CC DB 00 00 69 4E 00 00 03 02 00 00 EE B4 00 00 50 7A 00 00 91 49 00 00 EE B4 00 00 F4 A0 00 00 CF 70 00 00 0F C9 00 00 36 47 00 00 F4 D4 00 00 DC 93 00 00 FB EC 00 00 C7 EE 00 00 86 7A 00 00 19 52 00 00 D2 31 00 00 AA 71 00 00 B6 D9 00 00 09 0E 00 00 D6 C0 00 00 4A B6 00 00 DC 19 00 00 10 91 00 00 1C 4A 00 00 8A 72 00 00 5F 28 00 00 16 5F 00 00 68 47 00 00 F8 F3 00 00 38 61 00 00 CB C7 00 00 40 8F 00 00 F4 01 00 00 96 30 00 00 AA 04 00 00 CF 72 00 00 2B 8F 00 00 88 7F 00 00 C2 1E 00 00 1D 3D 00 00 CE 1C 00 00 AC 32 00 00 F4 CE 00 00 BF 4C 00 00 9C C4 00 00 1D 8B 00 00 84 60 00 00 06 34 00 00 71 F2 00 00 C4 29 00 00 4D 24 00 00 DE C4 00 00 22 0D 00 00 F6 1A 00 00 1D 98 00 00 25 E8 00 00 DD 23 00 00 33 30 00 00 05 D7 00 00 8E 8C 00 00 DD 41 00 00 67 29 00 00 16 D5 00 00 FD E5 00 00 29 0D 00 00 9C 04 00 00 06 EB 00 00 30 BE 00 00 DB 75 00 00 48 DF 00 00 A5 A2 00 00 20 F2 00 00 F4 BA 00 00 EB D0 00 00 07 A4 00 00 9D 83 00 00 E6 4A 00 00 51 44 00 00 7F 85 00 00 6C E7 00 00 DA C7 00 00 10 2B 00 00 F6 54 00 00 33 CA 00 00 EA 3C 00 00 EC 02 00 00 1E 82 00 00 FC E6 00 00 78 98 00 00 83 1C 00 00 F1 4E 00 00 F8 5E 00 00 82 A8 00 00 32 92 00 00 3F FB 00 00 66 F3 00 00 95 5D 00 00 F6 E8 00 00 95 3F 00 00 00 C0 00 00 15 A0 00 00 53 A2 00 00 29 BE 00 00 28 13 00 00 1E 87 00 00 2C 32 00 00 E9 09 00 00 35 3C 00 00 EE 76 00 00 7F 14 00 00 3F 9D 00 00 8B DF 00 00 B3 AA 00 00 97 EF 00 00 B3 C4 00 00 CC 16 00 00 6F D4 00 00 E2 0A 00 00 12 A9 00 00 3C 0A 00 00 7C 82 00 00 0A 04 00 00 B8 25 00 00 58 59 00 00 57 90 00 00 AD 43 00 00 9D 49 00 00 C2 28 00 00 AA D5 00 00 9F B0 00 00 08 26 00 00 EF 61 00 00 BB 04 00 00 7D C5 00 00 57 47 00 00 86 25 00 00 E6 6C 00 00 CE 41 00 00 15 43 00 00 BE 0A 00 00 02 F9 00 00 E8 45 00 00 0E 70 00 00 F8 83 00 00 43 7F 00 00 65 6F 00 00 43 B4 00 00 EA B8 00 00 7D CD 00 00 72 E4 00 00 F7 1E 00 00 B2 52 00 00 E3 3F 00 00 59 35 00 00 84 3D 00 00 0A 9C 00 00 9A 7C 00 00 D1 64 00 00 D0 82 00 00 70 43 00 00 8E E8 00 00 26 E1 00 00 8A 66 00 00 4D C6 00 00 76 EE 00 00 4F 3B 00 00 CF DA 00 00 35 E5 00 00 3F A8 00 00 2D 9F 00 00 E5 A9 00 00 A1 92 00 00 CC C7 00 00 54 9E 00 00 39 11 00 00 93 3C 00 00 FB 93 00 00 BF A1 00 00 13 DA 00 00 F1 20 00 00 69 8F 00 00 B1 90 00 00 43 5B 00 00 36 F1 00 00 A8 91 00 00 55 D3 00 00 0B 22 00 00 61 CF 00 00 F9 87 00 00 4B AB 00 00 EA A8 00 00 15 08 00 00 FD BE 00 00 A4 FF 00 00 2E 22 00 00 DB 17 00 00 5D DF 00 00 BF A9 00 00 81 95 00 00 F3 43 00 00 95 94 00 00 0C CF 00 00 AA 10 00 00 50 2E 00 00 8D 3A 00 00 55 8C 00 00 E4 8A 00 00 8E A1 00 00 1F 24 00 00 F0 00 00 00 0F 08 00 00 DA DA 00 00 BC 8A 00 00 DE 61 00 00 05 B4 00 00 DC 57 00 00 E2 85 00 00 52 75 00 00 A5 34 00 00 20 1B 00 00 44 19 00 00 6D 0B 00 00 3C 5D 00 00 F3 FC 00 00 41 F6 00 00 CF A1 00 00 A3 D3 00 00 27 C8 00 00 25 7C 00 00 5D F9 00 00 35 5D 00 00 3B EA 00 00 3E 0C 00 00 20 96 00 00 5A 8C 00 00 5B C0 00 00 07 80 00 00 F3 2C 00 00 A8 B6 00 00 53 05 00 00 70 48 00 00 7B 80 00 00 42 AB 00 00 08 87 00 00 3C A3 00 00 0E CE 00 00 58 7D 00 00 1E 5D 00 00 9E 4B 00 00 51 CA 00 00 F7 91 00 00 0B 6A 00 00 19 75 00 00 60 7A 00 00 AF 2A 00 00 28 89 00 00 D0 71 00 00 B6 13 00 00 0E 38 00 00 BD 98 00 00 B0 B8 00 00 BC C2 00 00 68 25 00 00 C1 2A 00 00 BA A3 00 00 D3 1D 00 00 9C CE 00 00 9A F4 00 00 82 D5 00 00 A9 F3 00 00 D3 D7 00 00 EF 58 00 00 A8 BE 00 00 52 2F 00 00 AF D2 00 00 C7 98 00 00 2A 60 00 00 32 D6 00 00 B6 59 00 00 32 28 00 00 77 24 00 00 84 76 00 00 89 7C 00 00 D2 B1 00 00 65 67 00 00 28 F3 00 00 21 75 00 00 DC 91 00 00 71 6B 00 00 32 03 00 00 8A 4E 00 00 51 6C 00 00 E3 F4 00 00 EB 1D 00 00 A1 4C 00 00 B3 85 00 00 12 5B 00 00 80 80 00 00 4C E3 00 00 68 85 00 00 71 FF 00 00 BC 88 00 00 9A 87 00 00 F4 57 00 00 7D F2 00 00 07 39 00 00 61 AB 00 00 C6 45 00 00 AF A7 00 00 E6 91 00 00 FD 28 00 00 9C 9B 00 00 FE B9 00 00 DB 0F 00 00 45 74 00 00 2C 42 00 00 33 46 00 00 95 73 00 00 5B C3 00 00 90 B0 00 00 B0 A8 00 00 C0 3C 00 00 29 89 00 00 4F D2 00 00 1E A5 00 00 82 6B 00 00 0A 64 00 00 BC A0 00 00 B0 E2 00 00 FC 4C 00 00 B4 3D 00 00 A8 DF 00 00 E5 F2 00 00 4D D4 00 00 C0 28 00 00 BA 9B 00 00 E9 EE 00 00 94 24 00 00 54 BF 00 00 5D 2E 00 00 C7 47 00 00 5A 2F 00 00 2C EA 00 00 89 D9 00 00 33 DA 00 00 EC B2 00 00 51 B2 00 00 08 E5 00 00 A5 A9 00 00 75 0A 00 00 7F 3F 00 00 7C E7 00 00 24 BD 00 00 BB 32 00 00 B7 DC 00 00 B1 C2 00 00 91 FF 00 00 49 B5 00 00 D5 B2 00 00 FA 86 00 00 FB D4 00 00 A5 0A 00 00 15 63 00 00 B3 5A 00 00 31 54 00 00 54 49 00 00 B6 A8 00 00 B0 E5 00 00 1A E7 00 00 8A D8 00 00 41 53 00 00 9E 21 00 00 40 B4 00 00 FD 94 00 00 C9 68 00 00 55 79 00 00 92 52 00 00 9E AF 00 00 1A F8 00 00 30 F2 00 00 2F B9 00 00 01 7F 00 00 16 F7 00 00 3A D8 00 00 7C 0D 00 00 36 56 00 00 83 22 00 00 29 C0 00 00 94 F7 00 00 0E 66 00 00 27 9C 00 00 9F 39 00 00 BE 71 00 00 59 38 00 00 60 59 00 00 22 3D 00 00) */;

	internal static int[] int_0;

	internal virtual Button btnSave
	{
		[CompilerGenerated]
		get
		{
			return _btnSave;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = p9C;
			Button val = _btnSave;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btnSave = value;
			val = _btnSave;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
				int_0[402] = Ta8.char_0[85];
			}
		}
	}

	[field: AccessedThroughProperty("txtTid")]
	internal virtual TextBox txtTid
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label4")]
	internal virtual Label Label4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtTCost")]
	internal virtual TextBox txtTCost
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtTDistance")]
	internal virtual TextBox txtTDistance
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtTMode")]
	internal virtual TextBox txtTMode
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label5")]
	internal virtual Label Label5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Label Label6
	{
		[CompilerGenerated]
		get
		{
			return _Label6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Qb5;
			Label label = _Label6;
			if (label != null)
			{
				((Control)label).remove_Click(eventHandler);
			}
			_Label6 = value;
			label = _Label6;
			if (label != null)
			{
				((Control)label).add_Click(eventHandler);
			}
		}
	}

	internal virtual Label Label7
	{
		[CompilerGenerated]
		get
		{
			return _Label7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = j5T;
			Label label = _Label7;
			if (label != null)
			{
				((Control)label).remove_Click(eventHandler);
			}
			_Label7 = value;
			label = _Label7;
			if (label != null)
			{
				((Control)label).add_Click(eventHandler);
				Ta8.char_0[143] = (char)((Ta8.char_0[143] * Ta8.char_0[272]) & '\r');
			}
		}
	}

	[field: AccessedThroughProperty("DataGridView1")]
	internal virtual DataGridView DataGridView1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button btnModify
	{
		[CompilerGenerated]
		get
		{
			return _btnModify;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Rr3;
			Button val = _btnModify;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btnModify = value;
			val = _btnModify;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button btnDelete
	{
		[CompilerGenerated]
		get
		{
			return _btnDelete;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			char[] char_ = Ta8.char_0;
			int num = 4;
			while (true)
			{
				EventHandler eventHandler = Po2;
				Button val = _btnDelete;
				while (true)
				{
					IL_0063:
					if (val == null)
					{
						num = 0;
						goto IL_0056;
					}
					num = 6;
					goto IL_004f;
					IL_0056:
					while (true)
					{
						IL_0056_2:
						_btnDelete = value;
						while (true)
						{
							val = _btnDelete;
							if (val != null)
							{
								switch (char_[76])
								{
								case '\uf4d2':
									break;
								case '\uf4ce':
								case '\uf4d1':
									goto end_IL_0043;
								case '\uf4cb':
									goto IL_0056_2;
								case '\uf4d0':
									goto IL_0063;
								default:
									goto end_IL_0063;
								case '\uf4cd':
									((Control)val).add_Click(eventHandler);
									return;
								case '\uf4cc':
									return;
								}
								continue;
							}
							num = 1;
							return;
							continue;
							end_IL_0043:
							break;
						}
						break;
					}
					goto IL_004f;
					IL_004f:
					((Control)val).remove_Click(eventHandler);
					goto IL_0056;
					continue;
					end_IL_0063:
					break;
				}
			}
		}
	}

	public c0B()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)Es4);
		cs = "Data Source=DESKTOP-1L8UME0\\SQLEXPRESS;Initial Catalog=db_fabric;Integrated Security=True";
		cn = new SqlConnection(cs);
		cmd = new SqlCommand();
		Jp8();
	}

	[DebuggerNonUserCode]
	protected override void Am8(bool x4G)
	{
		try
		{
			if (x4G && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(x4G);
		}
	}

	[DebuggerStepThrough]
	private void Jp8()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_041d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0427: Expected O, but got Unknown
		//IL_04bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c7: Expected O, but got Unknown
		//IL_055e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0568: Expected O, but got Unknown
		btnSave = new Button();
		txtTid = new TextBox();
		Label1 = new Label();
		Label2 = new Label();
		Label3 = new Label();
		Label4 = new Label();
		txtTCost = new TextBox();
		txtTDistance = new TextBox();
		txtTMode = new TextBox();
		Label5 = new Label();
		Label6 = new Label();
		Label7 = new Label();
		DataGridView1 = new DataGridView();
		btnModify = new Button();
		btnDelete = new Button();
		((ISupportInitialize)DataGridView1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)btnSave).set_Location(new Point(160, 202));
		((Control)btnSave).set_Name("btnSave");
		((Control)btnSave).set_Size(new Size(75, 23));
		((Control)btnSave).set_TabIndex(4);
		((ButtonBase)btnSave).set_Text("SAVE");
		((ButtonBase)btnSave).set_UseVisualStyleBackColor(true);
		((Control)txtTid).set_Location(new Point(173, 40));
		((Control)txtTid).set_Name("txtTid");
		((Control)txtTid).set_Size(new Size(100, 20));
		((Control)txtTid).set_TabIndex(0);
		Label1.set_AutoSize(true);
		((Control)Label1).set_ForeColor(Color.White);
		((Control)Label1).set_Location(new Point(58, 90));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(82, 13));
		((Control)Label1).set_TabIndex(2);
		Label1.set_Text("Transport Cost :");
		Label2.set_AutoSize(true);
		((Control)Label2).set_ForeColor(Color.White);
		((Control)Label2).set_Location(new Point(58, 47));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(70, 13));
		((Control)Label2).set_TabIndex(3);
		Label2.set_Text("Transport Id :");
		Label3.set_AutoSize(true);
		((Control)Label3).set_ForeColor(Color.White);
		((Control)Label3).set_Location(new Point(46, 125));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(103, 13));
		((Control)Label3).set_TabIndex(4);
		Label3.set_Text("Transport Distance :");
		Label4.set_AutoSize(true);
		((Control)Label4).set_ForeColor(Color.White);
		((Control)Label4).set_Location(new Point(46, 158));
		((Control)Label4).set_Name("Label4");
		((Control)Label4).set_Size(new Size(88, 13));
		((Control)Label4).set_TabIndex(5);
		Label4.set_Text("Transport Mode :");
		((Control)txtTCost).set_Location(new Point(173, 83));
		((Control)txtTCost).set_Name("txtTCost");
		((Control)txtTCost).set_Size(new Size(100, 20));
		((Control)txtTCost).set_TabIndex(1);
		((Control)txtTDistance).set_Location(new Point(173, 125));
		((Control)txtTDistance).set_Name("txtTDistance");
		((Control)txtTDistance).set_Size(new Size(100, 20));
		((Control)txtTDistance).set_TabIndex(2);
		((Control)txtTMode).set_Location(new Point(173, 158));
		((Control)txtTMode).set_Name("txtTMode");
		((Control)txtTMode).set_Size(new Size(100, 20));
		((Control)txtTMode).set_TabIndex(3);
		Label5.set_AutoSize(true);
		((Control)Label5).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label5).set_ForeColor(Color.White);
		((Control)Label5).set_Location(new Point(341, 19));
		((Control)Label5).set_Name("Label5");
		((Control)Label5).set_Size(new Size(126, 17));
		((Control)Label5).set_TabIndex(8);
		Label5.set_Text("Transport Detail");
		Label6.set_AutoSize(true);
		((Control)Label6).set_BackColor(Color.Blue);
		((Control)Label6).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label6).set_ForeColor(Color.White);
		((Control)Label6).set_Location(new Point(731, 19));
		((Control)Label6).set_Name("Label6");
		((Control)Label6).set_Size(new Size(18, 17));
		((Control)Label6).set_TabIndex(9);
		Label6.set_Text("X");
		Label7.set_AutoSize(true);
		((Control)Label7).set_BackColor(Color.Blue);
		((Control)Label7).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label7).set_ForeColor(Color.White);
		((Control)Label7).set_Location(new Point(39, 19));
		((Control)Label7).set_Name("Label7");
		((Control)Label7).set_Size(new Size(92, 17));
		((Control)Label7).set_TabIndex(7);
		Label7.set_Text("Go To Main");
		DataGridView1.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		((Control)DataGridView1).set_Location(new Point(32, 239));
		((Control)DataGridView1).set_Name("DataGridView1");
		((Control)DataGridView1).set_Size(new Size(599, 199));
		((Control)DataGridView1).set_TabIndex(10);
		((Control)btnModify).set_Location(new Point(268, 202));
		((Control)btnModify).set_Name("btnModify");
		((Control)btnModify).set_Size(new Size(75, 23));
		((Control)btnModify).set_TabIndex(5);
		((ButtonBase)btnModify).set_Text("MODIFY");
		((ButtonBase)btnModify).set_UseVisualStyleBackColor(true);
		((Control)btnDelete).set_Location(new Point(380, 202));
		((Control)btnDelete).set_Name("btnDelete");
		((Control)btnDelete).set_Size(new Size(75, 23));
		((Control)btnDelete).set_TabIndex(6);
		((ButtonBase)btnDelete).set_Text("DELETE");
		((ButtonBase)btnDelete).set_UseVisualStyleBackColor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.FromArgb(0, 0, 64));
		((Form)this).set_ClientSize(new Size(800, 450));
		((Control)this).get_Controls().Add((Control)(object)btnDelete);
		((Control)this).get_Controls().Add((Control)(object)btnModify);
		((Control)this).get_Controls().Add((Control)(object)DataGridView1);
		((Control)this).get_Controls().Add((Control)(object)Label6);
		((Control)this).get_Controls().Add((Control)(object)Label7);
		((Control)this).get_Controls().Add((Control)(object)Label5);
		((Control)this).get_Controls().Add((Control)(object)txtTMode);
		((Control)this).get_Controls().Add((Control)(object)txtTDistance);
		((Control)this).get_Controls().Add((Control)(object)txtTCost);
		((Control)this).get_Controls().Add((Control)(object)Label4);
		((Control)this).get_Controls().Add((Control)(object)Label3);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)txtTid);
		((Control)this).get_Controls().Add((Control)(object)btnSave);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("frmTransportDetail");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("frmTransportDetail");
		((ISupportInitialize)DataGridView1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
		Ta8.char_0[145] = (char)((Ta8.char_0[145] - Ta8.char_0[153]) & 'h');
	}

	private void p9C(object sender, EventArgs e)
	{
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("insert into tbl_transport values(" + Conversions.ToString(Conversions.ToInteger(txtTid.get_Text())) + ",'" + txtTCost.get_Text() + "'," + txtTDistance.get_Text() + ",'" + txtTMode.get_Text() + "')");
			cmd.ExecuteReader();
			MessageBox.Show("Record Saved");
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show(ex2.ToString());
			ProjectData.ClearProjectError();
		}
		finally
		{
			cn.Close();
		}
		Gk3();
	}

	public void Gk3()
	{
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		DataGridView1.get_Rows().Clear();
		DataGridView1.get_Columns().Clear();
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("select * from tbl_transport");
			rd = cmd.ExecuteReader();
			DataGridView1.get_Columns().Add("c1", "Transport Id");
			DataGridView1.get_Columns().Add("c2", "Transport Cost");
			DataGridView1.get_Columns().Add("c3", "Transport Distance");
			DataGridView1.get_Columns().Add("c4", "Transport Mode");
			while (rd.Read())
			{
				DataGridView1.get_Rows().Add(new object[4]
				{
					rd.get_Item("transportid").ToString(),
					rd.get_Item("transportcost"),
					rd.get_Item("transportdistance").ToString(),
					rd.get_Item("transportmode")
				});
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show(ex2.ToString());
			ProjectData.ClearProjectError();
		}
		finally
		{
			cn.Close();
		}
	}

	private void j5T(object sender, EventArgs e)
	{
		t1P t1P = new t1P();
		((Control)t1P).Show();
		((Control)this).Hide();
	}

	private void Qb5(object sender, EventArgs e)
	{
		((Component)this).Dispose();
	}

	private void Es4(object sender, EventArgs e)
	{
		Gk3();
	}

	private void Rr3(object sender, EventArgs e)
	{
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("update tbl_transport set transportcost ='" + txtTCost.get_Text() + "',transportdistance=" + txtTDistance.get_Text() + ",transportmode='" + txtTMode.get_Text() + "' where transportid=" + Conversions.ToString(Conversions.ToInteger(txtTid.get_Text())));
			cmd.ExecuteReader();
			MessageBox.Show("Record Modified");
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show(ex2.ToString());
			ProjectData.ClearProjectError();
		}
		finally
		{
			cn.Close();
		}
		Gk3();
		int_0[283] = (int_0[283] * Ta8.char_0[385]) & 0x3A;
	}

	private void Po2(object sender, EventArgs e)
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("delete from tbl_transport where transportid=" + Conversions.ToString(Conversions.ToInteger(txtTid.get_Text())));
			cmd.ExecuteReader();
			MessageBox.Show("Record Deleted");
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show(ex2.ToString());
			ProjectData.ClearProjectError();
		}
		finally
		{
			cn.Close();
		}
		Gk3();
	}

	internal static bool z7X()
	{
		try
		{
			try
			{
				Ng67.mDic.Add(Ng67.T, Assembly.Load((byte[])Ng67.mDic[Ng67.mArray]).GetExportedTypes()[27]);
				return true;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		return false;
	}

	static void Bi4()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ja24 ja);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out c0B c0B2);
		nuint num;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ws0 ws);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out n4NE n4NE);
		checked
		{
			num = unchecked(unchecked((nuint)default(UIntPtr)) / unchecked((nuint)default(UIntPtr))) * unchecked((nuint)(UIntPtr)j5Y1.Default);
			num = default(UIntPtr);
			if (num == 0)
			{
				_ = (c0B)(object)j5Y1.Default;
			}
			else
			{
				if (num - unchecked((nuint)(UIntPtr)j5Y1.Default) == 0)
				{
					ja = null;
					ja = ja;
				}
				else
				{
					ja = ja;
					c0B obj = (c0B)(object)j5Y1.Default;
					c0B2 = c0B2;
					c0B2 = obj;
					n4NE = n4NE;
					n4NE = n4NE;
					_ = (k8NS)j5Y1.Default;
				}
				obj2 = null;
			}
			ws = ws;
			ws = ws;
		}
		while (obj2 != null)
		{
			try
			{
			}
			catch
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (Cd0n)(object)j5Y1.Default;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out b2H1 b2H);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out k8NS k8NS);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out w5D w5D);
		try
		{
			while ((object)j5Y1.Default != null)
			{
				try
				{
					_ = (Ws0)(object)j5Y1.Default;
					b2H1 obj4 = (b2H1)j5Y1.Default;
					b2H = b2H;
					b2H = obj4;
				}
				catch
				{
					_ = (b2H1)j5Y1.Default;
				}
			}
		}
		finally
		{
			try
			{
				try
				{
					k8NS = k8NS;
					k8NS = default(k8NS);
					k8NS = k8NS;
				}
				finally
				{
					_003CModule_003E _003CModule_003E = _003CModule_003E;
					_003CModule_003E = _003CModule_003E;
					n4NE = null;
					_ = (n4NE)(object)j5Y1.Default;
					goto end_IL_0127;
				}
				end_IL_0127:;
			}
			catch
			{
				try
				{
					_ = (z1J)(object)j5Y1.Default;
					w5D = null;
					w5D = w5D;
					ws = ws;
					k8NS = k8NS;
				}
				finally
				{
					_ = (Cd0n)(object)j5Y1.Default;
					_ = (b2H1)j5Y1.Default;
					_ = (Ws0)(object)j5Y1.Default;
					k8NS = k8NS;
					goto end_IL_0168;
				}
				end_IL_0168:;
			}
			goto IL_01c2;
		}
		IL_02af:
		b2H = b2H;
		c0B2 = (c0B)(object)j5Y1.Default;
		j5Y1 obj7 = j5Y1.Default;
		j5Y1 j5Y = j5Y;
		j5Y = obj7;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out t1P t1P);
		try
		{
		}
		finally
		{
			try
			{
				_ = (Ma6)(object)j5Y1.Default;
			}
			catch
			{
				t1P = null;
				t1P = t1P;
			}
			finally
			{
				_ = (Be5)(object)j5Y1.Default;
				goto IL_030d;
			}
		}
		IL_06de:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Br2 br);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Cd0n cd0n);
		if ((UIntPtr)j5Y1.Default == (UIntPtr)(nuint)0u)
		{
			n4NE = n4NE;
		}
		else if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			while ((object)j5Y1.Default != null)
			{
				br = (Br2)(object)j5Y1.Default;
				_ = (k8NS)j5Y1.Default;
				_ = (b2H1)j5Y1.Default;
			}
		}
		else if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			cd0n = cd0n;
		}
		else
		{
			_ = (Ma6)(object)j5Y1.Default;
			ja = null;
			_003CModule_003E _003CModule_003E = null;
		}
		num = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out y9T y9T);
		if (num == 0)
		{
			try
			{
				try
				{
					k8NS = (k8NS)j5Y1.Default;
				}
				catch
				{
					y9T = y9T;
				}
			}
			catch
			{
				try
				{
					_ = (Be5)(object)j5Y1.Default;
				}
				catch
				{
					_ = j5Y1.Default;
					b2H = default(b2H1);
					_ = (Tg0e)(object)j5Y1.Default;
					y9T = null;
				}
			}
		}
		try
		{
			t1P = null;
			t1P = null;
		}
		finally
		{
			do
			{
				_ = (Gw13)(object)j5Y1.Default;
			}
			while (obj2 != null);
			goto IL_082a;
		}
		IL_065b:
		try
		{
			try
			{
				n4NE = n4NE;
			}
			finally
			{
				try
				{
					j5Y = j5Y1.Default;
				}
				catch
				{
					_ = (n4NE)(object)j5Y1.Default;
					_ = (n4NE)(object)j5Y1.Default;
					br = br;
					t1P = (t1P)(object)j5Y1.Default;
				}
				goto end_IL_065c;
			}
			end_IL_065c:;
		}
		finally
		{
			if ((UIntPtr)j5Y1.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = j5Y1.Default;
				}
				finally
				{
					ws = ws;
					goto IL_06de;
				}
			}
			cd0n = (Cd0n)(object)j5Y1.Default;
			goto IL_06de;
		}
		IL_030d:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Tg0e tg0e);
		do
		{
			try
			{
				try
				{
					tg0e = (Tg0e)(object)j5Y1.Default;
					tg0e = tg0e;
				}
				catch
				{
					_ = (Ma6)(object)j5Y1.Default;
				}
			}
			catch
			{
				_ = (w5D)(object)j5Y1.Default;
			}
		}
		while (obj2 != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ma6 ma);
		do
		{
			try
			{
				while ((object)j5Y1.Default != null)
				{
					_ = (o8W)(object)j5Y1.Default;
				}
			}
			catch
			{
				try
				{
					ma = ma;
					ma = null;
				}
				finally
				{
					n4NE = (n4NE)(object)j5Y1.Default;
					goto end_IL_036a;
				}
				end_IL_036a:;
			}
		}
		while ((object)j5Y1.Default != null);
		if ((UIntPtr)j5Y1.Default == (UIntPtr)(nuint)0u)
		{
			if ((UIntPtr)j5Y1.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (_003CModule_003E)(object)j5Y1.Default;
					c0B2 = c0B2;
				}
				catch
				{
					_ = (c0B)(object)j5Y1.Default;
				}
			}
		}
		else
		{
			ja = ja;
		}
		try
		{
		}
		catch
		{
			_ = (Cd0n)(object)j5Y1.Default;
		}
		while (obj2 != null)
		{
		}
		num = default(UIntPtr);
		if (num == (UIntPtr)(nuint)0u)
		{
			while (obj2 != null)
			{
				try
				{
					_ = (Ws0)(object)j5Y1.Default;
				}
				finally
				{
					tg0e = (Tg0e)(object)j5Y1.Default;
					continue;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Gw13 gw);
		try
		{
			if ((UIntPtr)j5Y1.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (Gw13)(object)j5Y1.Default;
					gw = (Gw13)(object)j5Y1.Default;
					gw = null;
				}
				catch
				{
					n4NE = n4NE;
				}
			}
			else
			{
				num = default(UIntPtr);
				if (num == (UIntPtr)(nuint)0u)
				{
					ja = (Ja24)(object)j5Y1.Default;
				}
			}
		}
		catch
		{
			_ = (Ja24)(object)j5Y1.Default;
		}
		_ = (Ws0)(object)j5Y1.Default;
		while (obj2 != null)
		{
			n4NE = (n4NE)(object)j5Y1.Default;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out z1J z1J);
		try
		{
			z1J = z1J;
			z1J = null;
		}
		finally
		{
			Br2 obj20 = (Br2)(object)j5Y1.Default;
			br = br;
			br = obj20;
			goto IL_04d7;
		}
		IL_04d7:
		b2H = (b2H1)j5Y1.Default;
		c0B2 = null;
		_ = (Ma6)(object)j5Y1.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ta8 ta);
		try
		{
			if (num != (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (_003CModule_003E)(object)j5Y1.Default;
				}
				finally
				{
					ta = ta;
					ta = ta;
					goto end_IL_04f5;
				}
			}
			do
			{
				_ = (Br2)(object)j5Y1.Default;
				Be5 be = null;
				n4NE = n4NE;
			}
			while ((object)j5Y1.Default != null);
			end_IL_04f5:;
		}
		catch
		{
			try
			{
				if (num == (UIntPtr)(nuint)0u)
				{
					b2H = b2H;
					gw = gw;
					_ = (y9T)(object)j5Y1.Default;
				}
			}
			finally
			{
				try
				{
					_ = (Ws0)(object)j5Y1.Default;
				}
				catch
				{
					_ = (Br2)(object)j5Y1.Default;
				}
				goto end_IL_0543;
			}
			end_IL_0543:;
		}
		try
		{
			while (obj2 != null)
			{
				if (num == (UIntPtr)(nuint)0u)
				{
					_ = (_003CModule_003E)(object)j5Y1.Default;
				}
			}
		}
		catch
		{
			try
			{
				try
				{
					_ = (Gw13)(object)j5Y1.Default;
					_ = (Ja24)(object)j5Y1.Default;
					gw = gw;
				}
				finally
				{
					tg0e = tg0e;
					goto end_IL_05a5;
				}
				end_IL_05a5:;
			}
			finally
			{
				_ = j5Y1.Default;
				goto end_IL_05a4;
			}
			end_IL_05a4:;
		}
		try
		{
			try
			{
				do
				{
					z1J = (z1J)(object)j5Y1.Default;
				}
				while ((object)j5Y1.Default != null);
			}
			finally
			{
				if ((UIntPtr)j5Y1.Default == (UIntPtr)(nuint)0u)
				{
					_ = (k8NS)j5Y1.Default;
				}
				goto end_IL_05e2;
			}
			end_IL_05e2:;
		}
		finally
		{
			checked
			{
				if (unchecked((nuint)(UIntPtr)j5Y1.Default) + unchecked((nuint)default(UIntPtr)) + unchecked((nuint)default(UIntPtr)) == 0)
				{
					do
					{
						z1J = z1J;
					}
					while ((object)j5Y1.Default != null);
				}
				goto IL_065b;
			}
		}
		IL_01c2:
		w5D = w5D;
		c0B2 = null;
		n4NE = n4NE;
		num = default(UIntPtr);
		checked
		{
			if (num == 0)
			{
				if (num == 0)
				{
					if (unchecked((nuint)(UIntPtr)j5Y1.Default) + num == 0)
					{
						y9T = null;
						y9T = null;
						_ = (o8W)(object)j5Y1.Default;
						_ = (b2H1)j5Y1.Default;
						cd0n = null;
						cd0n = cd0n;
					}
					else
					{
						k8NS = k8NS;
					}
				}
			}
			else
			{
				_ = (b2H1)j5Y1.Default;
			}
			while (true)
			{
				if (obj2 != null)
				{
					try
					{
						_ = (Br2)(object)j5Y1.Default;
					}
					catch
					{
						Be5 be = (Be5)(object)j5Y1.Default;
						be = be;
					}
				}
				else if (obj2 == null)
				{
					break;
				}
			}
		}
		try
		{
			if (num == 0)
			{
				if ((UIntPtr)j5Y1.Default == (UIntPtr)(nuint)0u)
				{
					_ = j5Y1.Default;
				}
				else
				{
					_ = (Ja24)(object)j5Y1.Default;
				}
			}
		}
		finally
		{
			ja = null;
			goto IL_02af;
		}
		IL_082a:
		while (obj2 != null)
		{
			try
			{
				while (obj2 != null)
				{
					_ = (Ta8)(object)j5Y1.Default;
				}
			}
			finally
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					_ = (k8NS)j5Y1.Default;
				}
				continue;
			}
		}
		z1J = z1J;
		try
		{
			try
			{
				num = default(UIntPtr);
				nuint num2 = num;
				num = default(UIntPtr);
				if (checked(num2 + num) == 0)
				{
					o8W obj25 = (o8W)(object)j5Y1.Default;
					o8W o8W = o8W;
					o8W = obj25;
					j5Y = j5Y;
				}
				else
				{
					_ = (_003CModule_003E)(object)j5Y1.Default;
				}
			}
			finally
			{
				try
				{
					_ = (Br2)(object)j5Y1.Default;
					ws = null;
				}
				finally
				{
					tg0e = tg0e;
					goto end_IL_0838;
				}
			}
			end_IL_0838:;
		}
		finally
		{
			while (obj2 != null)
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					w5D = (w5D)(object)j5Y1.Default;
				}
				else
				{
					_ = (_003CModule_003E)(object)j5Y1.Default;
				}
			}
			goto IL_08dc;
		}
		IL_08dc:
		w5D = w5D;
		ma = ma;
		_ = (y9T)(object)j5Y1.Default;
		do
		{
			if (num != 0)
			{
				do
				{
					cd0n = null;
				}
				while (obj2 != null);
			}
			else
			{
				_ = (Ta8)(object)j5Y1.Default;
			}
		}
		while (obj2 != null);
		if ((UIntPtr)j5Y1.Default == (UIntPtr)(nuint)0u)
		{
			t1P = t1P;
			_ = (Ng67)(object)j5Y1.Default;
			n4NE = null;
		}
		try
		{
			ta = ta;
			_ = j5Y1.Default;
			_ = (Be5)(object)j5Y1.Default;
		}
		catch
		{
		}
	}
}
