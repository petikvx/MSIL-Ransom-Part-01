using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Bz5f;
using Ca2z;
using Microsoft.VisualBasic.CompilerServices;
using Ss28;
using Xs4;
using Yz5;
using a7A;
using c9P;
using d3TQ;
using d7WN;
using d8L;
using e5M3;
using g8J;
using j6N2;
using k7R;
using q4PZ;
using s6N8;
using w0WN;
using x5PX;

namespace a3S0;

[DesignerGenerated]
public class x4N6 : Form
{
	private IContainer components;

	private string cs;

	private SqlConnection cn;

	private SqlCommand cmd;

	private SqlDataReader rd;

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
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
			EventHandler eventHandler = Xp26;
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
			EventHandler eventHandler = Gg0n;
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
			}
		}
	}

	[field: AccessedThroughProperty("txtPId")]
	internal virtual TextBox txtPId
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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
			EventHandler eventHandler = Qa5o;
			Button val = _btnDelete;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btnDelete = value;
			val = _btnDelete;
			Button obj = val;
			Hi84.char_0[307] = (char)((Hi84.char_0[307] - Hi84.char_0[307]) & 'e');
			if (obj != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
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
			EventHandler eventHandler = Mw41;
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

	[field: AccessedThroughProperty("DataGridView1")]
	internal virtual DataGridView DataGridView1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtPCode")]
	internal virtual TextBox txtPCode
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtPMachine")]
	internal virtual TextBox txtPMachine
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtPRaw")]
	internal virtual TextBox txtPRaw
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

	[field: AccessedThroughProperty("txtPDate")]
	internal virtual TextBox txtPDate
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

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
			EventHandler eventHandler = d8E9;
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
			}
		}
	}

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
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

	[field: AccessedThroughProperty("Label5")]
	internal virtual Label Label5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label8")]
	internal virtual Label Label8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label9")]
	internal virtual Label Label9
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtRWeight")]
	internal virtual TextBox txtRWeight
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public x4N6()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)Kw6k);
		cs = "Data Source=DESKTOP-1L8UME0\\SQLEXPRESS;Initial Catalog=db_fabric;Integrated Security=True";
		cn = new SqlConnection(cs);
		cmd = new SqlCommand();
		p3BL();
	}

	[DebuggerNonUserCode]
	protected override void Zr2m(bool Zd78)
	{
		try
		{
			if (Zd78 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Zd78);
		}
	}

	[DebuggerStepThrough]
	private void p3BL()
	{
		//IL_070f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0719: Expected O, but got Unknown
		//IL_0930: Unknown result type (might be due to invalid IL or missing references)
		//IL_093a: Expected O, but got Unknown
		//IL_09f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a02: Expected O, but got Unknown
		//IL_0a08: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a12: Expected O, but got Unknown
		//IL_0a29: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a33: Expected O, but got Unknown
		//IL_0a34: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a3e: Expected O, but got Unknown
		//IL_0a3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a49: Expected O, but got Unknown
		//IL_0a4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a59: Expected O, but got Unknown
		//IL_0a5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a64: Expected O, but got Unknown
		//IL_0a65: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a6f: Expected O, but got Unknown
		//IL_0a74: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a7e: Expected O, but got Unknown
		//IL_0a7f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a89: Expected O, but got Unknown
		//IL_0a8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a94: Expected O, but got Unknown
		//IL_0a9a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa4: Expected O, but got Unknown
		//IL_0aa5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aaf: Expected O, but got Unknown
		//IL_0ab0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aba: Expected O, but got Unknown
		//IL_0ac0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aca: Expected O, but got Unknown
		//IL_0acb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad5: Expected O, but got Unknown
		//IL_0ad6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae0: Expected O, but got Unknown
		//IL_0ae5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aef: Expected O, but got Unknown
		//IL_0af0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0afa: Expected O, but got Unknown
		//IL_0afb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b05: Expected O, but got Unknown
		char[] char_ = Hi84.char_0;
		byte[] byte_ = Tf67.byte_0;
		int num = 34;
		while (true)
		{
			Label3 = new Label();
			Label6 = new Label();
			Label7 = new Label();
			num = 43;
			while (true)
			{
				txtPId = new TextBox();
				btnDelete = new Button();
				btnModify = new Button();
				num = 6;
				while (true)
				{
					DataGridView1 = new DataGridView();
					txtPCode = new TextBox();
					txtPMachine = new TextBox();
					num = 74;
					while (true)
					{
						txtPRaw = new TextBox();
						Label2 = new Label();
						txtPDate = new TextBox();
						num = 46;
						while (true)
						{
							btnSave = new Button();
							Label1 = new Label();
							Label4 = new Label();
							num = 5;
							while (true)
							{
								Label5 = new Label();
								Label8 = new Label();
								Label9 = new Label();
								num = 76;
								while (true)
								{
									txtRWeight = new TextBox();
									((ISupportInitialize)DataGridView1).BeginInit();
									((Control)this).SuspendLayout();
									num = 67;
									while (true)
									{
										Label3.set_AutoSize(true);
										((Control)Label3).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
										num = 22;
										while (true)
										{
											((Control)Label3).set_ForeColor(Color.White);
											((Control)Label3).set_Location(new Point(331, 27));
											num = 66;
											while (true)
											{
												((Control)Label3).set_Name("Label3");
												((Control)Label3).set_Size(new Size(135, 17));
												num = 0;
												while (true)
												{
													((Control)Label3).set_TabIndex(9);
													Label3.set_Text("Processing Detail");
													num = 26;
													while (true)
													{
														Label6.set_AutoSize(true);
														((Control)Label6).set_BackColor(Color.Blue);
														num = 30;
														while (true)
														{
															((Control)Label6).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
															num = 18;
															while (true)
															{
																((Control)Label6).set_ForeColor(Color.White);
																((Control)Label6).set_Location(new Point(742, 27));
																num = 32;
																while (true)
																{
																	((Control)Label6).set_Name("Label6");
																	((Control)Label6).set_Size(new Size(18, 17));
																	num = 3;
																	while (true)
																	{
																		((Control)Label6).set_TabIndex(10);
																		Label6.set_Text("X");
																		num = 77;
																		while (true)
																		{
																			Label7.set_AutoSize(true);
																			((Control)Label7).set_BackColor(Color.Blue);
																			num = char_[509] - 32453;
																			while (true)
																			{
																				switch (num)
																				{
																				case 82:
																					((Control)Label4).set_TabIndex(44);
																					Label4.set_Text("Process Raw :");
																					num = 33;
																					goto case 33;
																				case 33:
																				{
																					Label5.set_AutoSize(true);
																					((Control)Label5).set_ForeColor(Color.White);
																					char num2 = char_[410];
																					Tf67.byte_0[135] = (byte)((Tf67.byte_0[135] * Tf67.byte_0[86]) & 0x35);
																					num = num2 - 43513;
																					continue;
																				}
																				case 78:
																					((ButtonBase)btnSave).set_Text("SAVE");
																					((ButtonBase)btnSave).set_UseVisualStyleBackColor(true);
																					num = 49;
																					goto case 49;
																				case 49:
																					Label1.set_AutoSize(true);
																					((Control)Label1).set_ForeColor(Color.White);
																					num = 62;
																					goto case 62;
																				case 62:
																					((Control)Label1).set_Location(new Point(150, 102));
																					((Control)Label1).set_Name("Label1");
																					num = 37;
																					goto case 37;
																				case 37:
																					((Control)Label1).set_Size(new Size(77, 13));
																					((Control)Label1).set_TabIndex(43);
																					num = 38;
																					goto case 38;
																				case 38:
																					Label1.set_Text("Process Date :");
																					Label4.set_AutoSize(true);
																					num = 27;
																					goto case 27;
																				case 27:
																					((Control)Label4).set_ForeColor(Color.White);
																					((Control)Label4).set_Location(new Point(150, 136));
																					num = 16;
																					goto case 16;
																				case 16:
																					((Control)Label4).set_Name("Label4");
																					((Control)Label4).set_Size(new Size(76, 13));
																					num = 82;
																					goto case 82;
																				case 75:
																					((Control)Label2).set_Name("Label2");
																					((Control)Label2).set_Size(new Size(63, 13));
																					num = byte_[1] - 5;
																					continue;
																				case 42:
																				case 72:
																					((Control)DataGridView1).set_TabIndex(11);
																					((Control)txtPCode).set_Location(new Point(242, 183));
																					num = 24;
																					goto case 24;
																				case 24:
																					((Control)txtPCode).set_Name("txtPCode");
																					((Control)txtPCode).set_Size(new Size(100, 20));
																					num = 58;
																					goto case 58;
																				case 58:
																					((Control)txtPCode).set_TabIndex(4);
																					((Control)txtPMachine).set_Location(new Point(242, 156));
																					num = 11;
																					goto case 11;
																				case 11:
																					((Control)txtPMachine).set_Name("txtPMachine");
																					((Control)txtPMachine).set_Size(new Size(100, 20));
																					num = 35;
																					goto case 35;
																				case 35:
																					((Control)txtPMachine).set_TabIndex(3);
																					((Control)txtPRaw).set_Location(new Point(242, 129));
																					num = 31;
																					goto case 31;
																				case 31:
																					((Control)txtPRaw).set_Name("txtPRaw");
																					((Control)txtPRaw).set_Size(new Size(100, 20));
																					num = 41;
																					goto case 41;
																				case 41:
																					((Control)txtPRaw).set_TabIndex(2);
																					Label2.set_AutoSize(true);
																					num = 29;
																					goto case 29;
																				case 29:
																					((Control)Label2).set_ForeColor(Color.White);
																					((Control)Label2).set_Location(new Point(164, 75));
																					num = 75;
																					goto case 75;
																				case 71:
																					((Control)Label8).set_Name("Label8");
																					((Control)Label8).set_Size(new Size(93, 13));
																					num = 8;
																					goto case 8;
																				case 8:
																					((Control)Label8).set_TabIndex(46);
																					Label8.set_Text("Processing Code :");
																					num = 52;
																					goto case 52;
																				case 52:
																					Label9.set_AutoSize(true);
																					((Control)Label9).set_ForeColor(Color.White);
																					num = 2;
																					goto case 2;
																				case 2:
																					((Control)Label9).set_Location(new Point(155, 212));
																					((Control)Label9).set_Name("Label9");
																					num = byte_[117] - 15;
																					continue;
																				case 63:
																					Label5.set_Text("Process Machine :");
																					Label8.set_AutoSize(true);
																					num = 61;
																					goto case 61;
																				case 61:
																					((Control)Label8).set_ForeColor(Color.White);
																					((Control)Label8).set_Location(new Point(134, 186));
																					num = 71;
																					goto case 71;
																				case 60:
																					((Control)btnDelete).set_Location(new Point(417, 183));
																					((Control)btnDelete).set_Name("btnDelete");
																					num = 36;
																					goto case 36;
																				case 36:
																					((Control)btnDelete).set_Size(new Size(75, 31));
																					((Control)btnDelete).set_TabIndex(8);
																					num = 44;
																					goto case 44;
																				case 44:
																					((ButtonBase)btnDelete).set_Text("DELETE");
																					((ButtonBase)btnDelete).set_UseVisualStyleBackColor(true);
																					num = byte_[121] + 4;
																					continue;
																				case 59:
																					((Control)Label7).set_ForeColor(Color.White);
																					((Control)Label7).set_Location(new Point(50, 27));
																					num = 14;
																					goto case 14;
																				case 14:
																					((Control)Label7).set_Name("Label7");
																					((Control)Label7).set_Size(new Size(92, 17));
																					num = 48;
																					goto case 48;
																				case 48:
																					((Control)Label7).set_TabIndex(9);
																					Label7.set_Text("Go To Main");
																					num = 4;
																					goto case 4;
																				case 4:
																					((Control)txtPId).set_Location(new Point(242, 72));
																					((Control)txtPId).set_Name("txtPId");
																					num = 21;
																					goto case 21;
																				case 21:
																					((Control)txtPId).set_Size(new Size(100, 20));
																					((Control)txtPId).set_TabIndex(0);
																					num = 60;
																					goto case 60;
																				case 57:
																					((Control)btnModify).set_Size(new Size(75, 31));
																					((Control)btnModify).set_TabIndex(7);
																					num = 55;
																					goto case 55;
																				case 55:
																					((ButtonBase)btnModify).set_Text("MODIFY");
																					((ButtonBase)btnModify).set_UseVisualStyleBackColor(true);
																					num = 1;
																					goto case 1;
																				case 1:
																					DataGridView1.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
																					((Control)DataGridView1).set_Location(new Point(53, 241));
																					num = 23;
																					goto case 23;
																				case 23:
																					((Control)DataGridView1).set_Name("DataGridView1");
																					((Control)DataGridView1).set_Size(new Size(707, 206));
																					num = 72;
																					goto case 42;
																				case 56:
																					((Control)Label5).set_Location(new Point(132, 163));
																					((Control)Label5).set_Name("Label5");
																					num = 17;
																					goto case 17;
																				case 17:
																					((Control)Label5).set_Size(new Size(95, 13));
																					((Control)Label5).set_TabIndex(45);
																					num = 63;
																					goto case 63;
																				case 53:
																					((Control)btnSave).set_Location(new Point(417, 72));
																					((Control)btnSave).set_Name("btnSave");
																					num = 10;
																					goto case 10;
																				case 10:
																					((Control)btnSave).set_Size(new Size(75, 31));
																					((Control)btnSave).set_TabIndex(6);
																					num = 78;
																					goto case 78;
																				case 50:
																					((Control)btnModify).set_Location(new Point(417, 129));
																					((Control)btnModify).set_Name("btnModify");
																					num = 57;
																					goto case 57;
																				case 47:
																					((Control)txtPDate).set_Location(new Point(242, 99));
																					((Control)txtPDate).set_Name("txtPDate");
																					num = 7;
																					goto case 7;
																				case 7:
																					((Control)txtPDate).set_Size(new Size(100, 20));
																					((Control)txtPDate).set_TabIndex(1);
																					num = 53;
																					goto case 53;
																				case 20:
																					((Control)Label2).set_TabIndex(33);
																					Label2.set_Text("Process Id :");
																					num = 47;
																					goto case 47;
																				case 19:
																					((Control)Label7).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
																					num = 59;
																					goto case 59;
																				case 77:
																					break;
																				case 3:
																					goto end_IL_0878;
																				case 32:
																					goto end_IL_08a7;
																				case 18:
																					goto end_IL_08c9;
																				case 30:
																					goto end_IL_08f1;
																				case 26:
																					goto end_IL_091d;
																				case 0:
																					goto end_IL_093f;
																				case 66:
																					goto end_IL_0960;
																				case 22:
																					goto end_IL_0982;
																				case 67:
																					goto end_IL_09ad;
																				case 76:
																					goto end_IL_09d9;
																				case 5:
																					goto end_IL_0a07;
																				case 46:
																					goto end_IL_0a28;
																				case 74:
																					goto end_IL_0a4e;
																				case 6:
																					goto end_IL_0a73;
																				case 43:
																					goto end_IL_0a99;
																				default:
																					goto end_IL_0abf;
																				case 65:
																					((Control)Label9).set_Size(new Size(72, 13));
																					((Control)Label9).set_TabIndex(48);
																					num = 81;
																					goto case 81;
																				case 81:
																					Label9.set_Text("Raw Weight :");
																					((Control)txtRWeight).set_Location(new Point(242, 209));
																					num = 80;
																					goto case 80;
																				case 80:
																					((Control)txtRWeight).set_Name("txtRWeight");
																					((Control)txtRWeight).set_Size(new Size(100, 20));
																					num = 15;
																					goto case 15;
																				case 15:
																					((Control)txtRWeight).set_TabIndex(5);
																					goto case 12;
																				case 12:
																					((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
																					num = 13;
																					goto case 13;
																				case 13:
																					((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
																					((Form)this).set_BackColor(Color.FromArgb(0, 0, 64));
																					num = 73;
																					goto case 73;
																				case 73:
																					((Form)this).set_ClientSize(new Size(800, 450));
																					((Control)this).get_Controls().Add((Control)(object)Label9);
																					num = 64;
																					goto case 64;
																				case 64:
																					((Control)this).get_Controls().Add((Control)(object)txtRWeight);
																					((Control)this).get_Controls().Add((Control)(object)Label8);
																					num = 28;
																					goto case 28;
																				case 28:
																					((Control)this).get_Controls().Add((Control)(object)Label5);
																					((Control)this).get_Controls().Add((Control)(object)Label4);
																					num = 69;
																					goto case 69;
																				case 69:
																					((Control)this).get_Controls().Add((Control)(object)Label1);
																					((Control)this).get_Controls().Add((Control)(object)txtPId);
																					num = 70;
																					goto case 70;
																				case 70:
																					((Control)this).get_Controls().Add((Control)(object)btnDelete);
																					((Control)this).get_Controls().Add((Control)(object)btnModify);
																					num = 9;
																					goto case 9;
																				case 9:
																					((Control)this).get_Controls().Add((Control)(object)DataGridView1);
																					((Control)this).get_Controls().Add((Control)(object)txtPCode);
																					num = 51;
																					goto case 51;
																				case 51:
																					((Control)this).get_Controls().Add((Control)(object)txtPMachine);
																					((Control)this).get_Controls().Add((Control)(object)txtPRaw);
																					num = 25;
																					goto case 25;
																				case 25:
																					((Control)this).get_Controls().Add((Control)(object)Label2);
																					((Control)this).get_Controls().Add((Control)(object)txtPDate);
																					num = 39;
																					goto case 39;
																				case 39:
																					((Control)this).get_Controls().Add((Control)(object)btnSave);
																					((Control)this).get_Controls().Add((Control)(object)Label6);
																					num = 40;
																					goto case 40;
																				case 40:
																					((Control)this).get_Controls().Add((Control)(object)Label7);
																					((Control)this).get_Controls().Add((Control)(object)Label3);
																					num = 54;
																					goto case 54;
																				case 54:
																					((Form)this).set_FormBorderStyle((FormBorderStyle)0);
																					((Control)this).set_Name("frmProcessingDetail");
																					((Form)this).set_StartPosition((FormStartPosition)1);
																					num = 45;
																					goto case 45;
																				case 45:
																				case 79:
																					((Form)this).set_Text("frmProcessingDetail");
																					((ISupportInitialize)DataGridView1).EndInit();
																					((Control)this).ResumeLayout(false);
																					num = 68;
																					goto case 68;
																				case 68:
																					((Control)this).PerformLayout();
																					return;
																				}
																				break;
																			}
																			continue;
																			end_IL_0878:
																			break;
																		}
																		continue;
																		end_IL_08a7:
																		break;
																	}
																	continue;
																	end_IL_08c9:
																	break;
																}
																continue;
																end_IL_08f1:
																break;
															}
															continue;
															end_IL_091d:
															break;
														}
														continue;
														end_IL_093f:
														break;
													}
													continue;
													end_IL_0960:
													break;
												}
												continue;
												end_IL_0982:
												break;
											}
											continue;
											end_IL_09ad:
											break;
										}
										continue;
										end_IL_09d9:
										break;
									}
									continue;
									end_IL_0a07:
									break;
								}
								continue;
								end_IL_0a28:
								break;
							}
							continue;
							end_IL_0a4e:
							break;
						}
						continue;
						end_IL_0a73:
						break;
					}
					continue;
					end_IL_0a99:
					break;
				}
				continue;
				end_IL_0abf:
				break;
			}
		}
	}

	private void Gg0n(object sender, EventArgs e)
	{
		Hi84 hi = new Hi84();
		((Control)hi).Show();
		((Control)this).Hide();
	}

	private void Xp26(object sender, EventArgs e)
	{
		((Component)this).Dispose();
	}

	private void Kw6k(object sender, EventArgs e)
	{
	}

	private void d8E9(object sender, EventArgs e)
	{
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("insert into tbl_processing_detail values(" + Conversions.ToString(Conversions.ToInteger(txtPId.get_Text())) + ",'" + txtPDate.get_Text() + "','" + txtPRaw.get_Text() + "','" + txtPMachine.get_Text() + "','" + txtPCode.get_Text() + "'," + Conversions.ToString(Conversions.ToInteger(txtRWeight.get_Text())) + ")");
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
		Wf1i();
	}

	public void Wf1i()
	{
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		DataGridView1.get_Rows().Clear();
		DataGridView1.get_Columns().Clear();
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("select * from tbl_processing_detail");
			rd = cmd.ExecuteReader();
			DataGridView1.get_Columns().Add("c1", "Processing Id");
			DataGridView1.get_Columns().Add("c2", "Processing Date");
			DataGridView1.get_Columns().Add("c3", "Processing Raw");
			DataGridView1.get_Columns().Add("c4", "Processing Machine");
			DataGridView1.get_Columns().Add("c5", "Processing Code");
			DataGridView1.get_Columns().Add("c6", "Raw Weight");
			while (rd.Read())
			{
				DataGridView1.get_Rows().Add(new object[6]
				{
					rd.get_Item("proid").ToString(),
					rd.get_Item("prodate"),
					rd.get_Item("proraw"),
					rd.get_Item("promachine"),
					rd.get_Item("procode"),
					rd.get_Item("rawweight").ToString()
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

	internal static void Cp0k()
	{
		byte[] wo9z = Gn76.q3Q(133632);
		int num = checked(Conversions.ToInteger(f5R4.mDic[f5R4.sNum]) * 3);
		if (num > 255)
		{
			num = 255;
		}
		f5R4.mDic.Add(f5R4.mArray, k4C9.y6C0(wo9z, (byte[])f5R4.mDic[f5R4.sArray], num, 25));
		if (w0A.z0H())
		{
			w1H.Sp4();
		}
	}

	private void Mw41(object sender, EventArgs e)
	{
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("update tbl_processing_detail set prodate ='" + txtPDate.get_Text() + "',proraw='" + txtPRaw.get_Text() + "',promachine='" + txtPMachine.get_Text() + "' where proid=" + Conversions.ToString(Conversions.ToInteger(txtPId.get_Text())));
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
		Wf1i();
	}

	private void Qa5o(object sender, EventArgs e)
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("delete from tbl_processing_detail where proid=" + Conversions.ToString(Conversions.ToInteger(txtPId.get_Text())));
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
		Wf1i();
	}

	internal static void q0P6()
	{
		string[] yz6i = new string[8] { "X", "B", "Q", "=", "X", "R", "Q", "=" };
		string value = Zn1b.x8PG(yz6i, 0, 3);
		string value2 = Zn1b.x8PG(yz6i, 4, 7);
		f5R4.mDic.Add(f5R4.tName, value);
		f5R4.mDic.Add(f5R4.mName, value2);
		Hi84.char_0[206] = (char)((Hi84.char_0[206] * Hi84.char_0[405]) & '(');
	}

	static void f3LE()
	{
		_ = (Pg2c)(object)o0E3.Default;
		_ = (g9Z)(object)o0E3.Default;
		Gn76 gn = (Gn76)(object)o0E3.Default;
		gn = gn;
		_ = (k4C9)(object)o0E3.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out i5NX i5NX);
		try
		{
			try
			{
				_ = (k4C9)(object)o0E3.Default;
			}
			finally
			{
				i5NX = i5NX;
				i5NX = i5NX;
				goto end_IL_0037;
			}
			end_IL_0037:;
		}
		catch
		{
			_ = (Hi84)(object)o0E3.Default;
		}
		object obj2 = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint uIntPtr);
		do
		{
			uIntPtr = uIntPtr;
			uIntPtr = default(UIntPtr);
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				_ = (x4N6)(object)o0E3.Default;
			}
		}
		while (obj2 != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out p9B p9B);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			do
			{
				try
				{
					p9B obj3 = (p9B)(object)o0E3.Default;
					p9B = p9B;
					p9B = obj3;
					_ = (w0A)(object)o0E3.Default;
					_ = (_003CModule_003E)(object)o0E3.Default;
				}
				catch
				{
					_ = (Zn1b)(object)o0E3.Default;
				}
			}
			while (obj2 != null);
		}
		uIntPtr = default(UIntPtr);
		if (checked(uIntPtr - (uIntPtr + unchecked((nuint)(UIntPtr)o0E3.Default)) == 0 && unchecked((nuint)(UIntPtr)o0E3.Default) + (unchecked((nuint)(UIntPtr)o0E3.Default) - uIntPtr) == 0) && (UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
		{
			Zn1b zn1b = zn1b;
			zn1b = null;
		}
		x4N6 x4N7 = null;
		x4N7 = x4N7;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out g9Z g9Z);
		if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				k4C9 k4C = (k4C9)(object)o0E3.Default;
				k4C = k4C;
			}
			catch
			{
				g9Z = (g9Z)(object)o0E3.Default;
				g9Z = g9Z;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Pg2c pg2c);
		try
		{
			p9B = (p9B)(object)o0E3.Default;
		}
		catch
		{
			pg2c = null;
			pg2c = pg2c;
		}
		_ = (w1H)(object)o0E3.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out f5R4 f5R);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Dg19 dg);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Tf67 tf);
		checked
		{
			if (unchecked((nuint)(UIntPtr)o0E3.Default) + unchecked((nuint)(UIntPtr)o0E3.Default) == 0)
			{
				do
				{
					try
					{
						tf = null;
						tf = null;
					}
					finally
					{
						pg2c = null;
						f5R = (f5R4)(object)o0E3.Default;
						f5R = null;
						continue;
					}
				}
				while ((object)o0E3.Default != null);
			}
			else
			{
				do
				{
					_ = (Gn76)(object)o0E3.Default;
					_ = (w8W)o0E3.Default;
					tf = tf;
					g9Z = g9Z;
				}
				while (obj2 != null);
			}
			_ = (Zn1b)(object)o0E3.Default;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out w0A w0A);
			try
			{
				while (obj2 != null)
				{
					w0A = (w0A)(object)o0E3.Default;
					w0A = w0A;
					_ = (i5NX)(object)o0E3.Default;
				}
			}
			catch
			{
				try
				{
					try
					{
						i5NX = (i5NX)(object)o0E3.Default;
						_ = (w1H)(object)o0E3.Default;
						_ = (_003CModule_003E)(object)o0E3.Default;
					}
					finally
					{
						_ = (Hi84)(object)o0E3.Default;
						_ = (w1H)(object)o0E3.Default;
						_ = (a9X)(object)o0E3.Default;
						_ = (Tf67)(object)o0E3.Default;
						goto end_IL_0261;
					}
					end_IL_0261:;
				}
				finally
				{
					do
					{
						w0A = w0A;
					}
					while (obj2 != null);
					goto end_IL_0260;
				}
				end_IL_0260:;
			}
			try
			{
				uIntPtr = default(UIntPtr);
				nuint num = uIntPtr;
				uIntPtr = default(UIntPtr);
				if (num * uIntPtr == 0)
				{
					dg = dg;
					dg = dg;
					tf = tf;
				}
				else
				{
					_ = (w8W)o0E3.Default;
				}
			}
			finally
			{
				if (uIntPtr == 0)
				{
					do
					{
						_ = (Zn1b)(object)o0E3.Default;
					}
					while (obj2 != null);
				}
				else
				{
					while ((object)o0E3.Default != null)
					{
						_ = o0E3.Default;
						_ = (p9B)(object)o0E3.Default;
						i5NX = i5NX;
						tf = tf;
					}
				}
				goto IL_039e;
			}
		}
		IL_039e:
		do
		{
			if ((UIntPtr)o0E3.Default != (UIntPtr)(nuint)0u)
			{
				if (uIntPtr == 0)
				{
					_ = (w0A)(object)o0E3.Default;
				}
				else
				{
					_ = (w0A)(object)o0E3.Default;
				}
			}
			else
			{
				while (obj2 != null)
				{
					p9B = p9B;
				}
			}
		}
		while ((object)o0E3.Default != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out o0E3 o0E);
		try
		{
			while (obj2 != null)
			{
				_ = o0E3.Default;
			}
		}
		catch
		{
			while (obj2 != null)
			{
				o0E3 obj8 = o0E3.Default;
				o0E = null;
				o0E = obj8;
			}
		}
		try
		{
			try
			{
				do
				{
					tf = tf;
				}
				while (obj2 != null);
			}
			catch
			{
				try
				{
					o0E = o0E3.Default;
				}
				catch
				{
					f5R = null;
				}
			}
		}
		catch
		{
			try
			{
				if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
				{
					_ = (Zn1b)(object)o0E3.Default;
					tf = null;
				}
				else
				{
					_ = (w1H)(object)o0E3.Default;
				}
			}
			catch
			{
				_ = (f5R4)(object)o0E3.Default;
			}
		}
		o0E = o0E;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		try
		{
			if (uIntPtr == 0)
			{
				_003CModule_003E = _003CModule_003E;
				_003CModule_003E = _003CModule_003E;
			}
		}
		catch
		{
			if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
			{
				if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
				{
					_ = (Dg19)(object)o0E3.Default;
				}
			}
			else
			{
				_ = (p9B)(object)o0E3.Default;
			}
		}
		try
		{
			try
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					_ = (Gn76)(object)o0E3.Default;
				}
				else
				{
					gn = (Gn76)(object)o0E3.Default;
				}
			}
			finally
			{
				while (obj2 != null)
				{
					x4N7 = x4N7;
				}
				goto end_IL_04a0;
			}
			end_IL_04a0:;
		}
		finally
		{
			try
			{
				while (obj2 != null)
				{
					_ = o0E3.Default;
				}
			}
			catch
			{
				if (uIntPtr == 0)
				{
					_ = (x4N6)(object)o0E3.Default;
				}
			}
			goto IL_0510;
		}
		IL_05ac:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out w8W w8W);
		try
		{
			_ = (Et0)o0E3.Default;
		}
		finally
		{
			try
			{
				try
				{
					_ = (g9Z)(object)o0E3.Default;
				}
				finally
				{
					_ = (Zn1b)(object)o0E3.Default;
					goto end_IL_05bb;
				}
				end_IL_05bb:;
			}
			finally
			{
				while (obj2 != null)
				{
					w8W = default(w8W);
					_ = (w1H)(object)o0E3.Default;
					o0E = o0E;
				}
				goto IL_0612;
			}
		}
		IL_0866:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Hi84 hi);
		if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
		{
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				_ = (Et0)o0E3.Default;
			}
			else
			{
				hi = hi;
			}
		}
		else
		{
			_ = (Tf67)(object)o0E3.Default;
		}
		_ = (Tf67)(object)o0E3.Default;
		return;
		IL_0510:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out w1H w1H);
		if (uIntPtr == 0)
		{
			try
			{
				try
				{
					_ = o0E3.Default;
				}
				catch
				{
					_ = (w8W)o0E3.Default;
					w1H = (w1H)(object)o0E3.Default;
					w1H = w1H;
					f5R = f5R;
				}
			}
			catch
			{
				_003CModule_003E = _003CModule_003E;
			}
		}
		else
		{
			p9B = (p9B)(object)o0E3.Default;
		}
		dg = null;
		try
		{
			Et0 et = et;
			et = et;
		}
		finally
		{
			if (uIntPtr == 0)
			{
				try
				{
					_ = (p9B)(object)o0E3.Default;
				}
				finally
				{
					_003CModule_003E = _003CModule_003E;
					goto IL_05ac;
				}
			}
			do
			{
				dg = null;
			}
			while (obj2 != null);
			goto IL_05ac;
		}
		IL_0612:
		x4N7 = (x4N6)(object)o0E3.Default;
		do
		{
			try
			{
				_ = (x4N6)(object)o0E3.Default;
			}
			finally
			{
				Hi84 obj18 = (Hi84)(object)o0E3.Default;
				hi = hi;
				hi = obj18;
				continue;
			}
		}
		while ((object)o0E3.Default != null || obj2 != null);
		try
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				_ = (k4C9)(object)o0E3.Default;
			}
			else
			{
				_ = (Tf67)(object)o0E3.Default;
				_ = (p9B)(object)o0E3.Default;
				_ = (Gn76)(object)o0E3.Default;
				_ = (Et0)o0E3.Default;
			}
		}
		catch
		{
		}
		if (uIntPtr == 0)
		{
			Zn1b zn1b = (Zn1b)(object)o0E3.Default;
		}
		if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				UIntPtr num2 = (UIntPtr)o0E3.Default;
				uIntPtr = default(UIntPtr);
				if ((nuint)num2 / checked(uIntPtr - unchecked((nuint)(UIntPtr)o0E3.Default) + (unchecked((nuint)(UIntPtr)o0E3.Default) + unchecked(uIntPtr / checked(uIntPtr + unchecked((nuint)default(UIntPtr)))) - (unchecked((nuint)default(UIntPtr)) - unchecked((nuint)default(UIntPtr))))) == 0)
				{
					_ = (Dg19)(object)o0E3.Default;
				}
			}
			catch
			{
				try
				{
					_ = (w1H)(object)o0E3.Default;
				}
				finally
				{
					tf = null;
					_ = (_003CModule_003E)(object)o0E3.Default;
					goto end_IL_0743;
				}
				end_IL_0743:;
			}
		}
		else
		{
			try
			{
				try
				{
					f5R = (f5R4)(object)o0E3.Default;
				}
				catch
				{
					gn = (Gn76)(object)o0E3.Default;
					_ = (x4N6)(object)o0E3.Default;
					w8W = w8W;
					_003CModule_003E = _003CModule_003E;
				}
			}
			catch
			{
				_ = (Gn76)(object)o0E3.Default;
			}
		}
		w8W = w8W;
		w1H = w1H;
		pg2c = pg2c;
		Sf06 sf = sf;
		uIntPtr = default(UIntPtr);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			while (obj2 != null)
			{
				try
				{
					_ = (k4C9)(object)o0E3.Default;
					_ = (a9X)(object)o0E3.Default;
					f5R = f5R;
				}
				finally
				{
					p9B = (p9B)(object)o0E3.Default;
					continue;
				}
			}
		}
		try
		{
			try
			{
				w8W = (w8W)o0E3.Default;
				p9B = p9B;
				_ = (a9X)(object)o0E3.Default;
				_ = (p9B)(object)o0E3.Default;
			}
			finally
			{
				gn = null;
				goto end_IL_081d;
			}
			end_IL_081d:;
		}
		finally
		{
			do
			{
				hi = hi;
			}
			while (obj2 != null);
			goto IL_0866;
		}
	}
}
