using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Ax2;
using Bb3;
using Cx7;
using Hf5i;
using Lc3;
using Ln6;
using Mf0;
using Microsoft.VisualBasic.CompilerServices;
using Pc8;
using Rg9;
using Sk9;
using Wi0;
using Xs3;
using c7R0;
using e3F;
using m8T;
using p6H;
using p9B1;
using t2P;

namespace g0G;

[DesignerGenerated]
public class d3R : Form
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
			EventHandler eventHandler = j4P;
			Label label = _Label6;
			Label obj = label;
			Pr5.byte_0[173] = (byte)((Pr5.byte_0[173] | Pr5.byte_0[263]) & 0xB1);
			if (obj != null)
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
			EventHandler eventHandler = s5Q;
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
			EventHandler eventHandler = Bm7;
			Button val = _btnDelete;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btnDelete = value;
			val = _btnDelete;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
				b4C0.char_0[598] = (char)(b4C0.char_0[598] & b4C0.char_0[54] & '\u0099');
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
			EventHandler eventHandler = Dg1;
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
			EventHandler eventHandler = Cy6;
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

	public d3R()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)Dk6);
		cs = "Data Source=DESKTOP-1L8UME0\\SQLEXPRESS;Initial Catalog=db_fabric;Integrated Security=True";
		cn = new SqlConnection(cs);
		cmd = new SqlCommand();
		Bo3();
	}

	[DebuggerNonUserCode]
	protected override void Ht9(bool Xb5)
	{
		try
		{
			if (Xb5 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Xb5);
		}
	}

	[DebuggerStepThrough]
	private void Bo3()
	{
		//IL_0677: Unknown result type (might be due to invalid IL or missing references)
		//IL_0681: Expected O, but got Unknown
		//IL_0731: Unknown result type (might be due to invalid IL or missing references)
		//IL_073b: Expected O, but got Unknown
		//IL_07f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0803: Expected O, but got Unknown
		//IL_0809: Unknown result type (might be due to invalid IL or missing references)
		//IL_0813: Expected O, but got Unknown
		//IL_082a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0834: Expected O, but got Unknown
		//IL_0835: Unknown result type (might be due to invalid IL or missing references)
		//IL_083f: Expected O, but got Unknown
		//IL_0840: Unknown result type (might be due to invalid IL or missing references)
		//IL_084a: Expected O, but got Unknown
		//IL_0850: Unknown result type (might be due to invalid IL or missing references)
		//IL_085a: Expected O, but got Unknown
		//IL_085b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0865: Expected O, but got Unknown
		//IL_0866: Unknown result type (might be due to invalid IL or missing references)
		//IL_0870: Expected O, but got Unknown
		//IL_0875: Unknown result type (might be due to invalid IL or missing references)
		//IL_087f: Expected O, but got Unknown
		//IL_0880: Unknown result type (might be due to invalid IL or missing references)
		//IL_088a: Expected O, but got Unknown
		//IL_088b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0895: Expected O, but got Unknown
		//IL_089b: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a5: Expected O, but got Unknown
		//IL_08a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b0: Expected O, but got Unknown
		//IL_08b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08bb: Expected O, but got Unknown
		//IL_08c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08cb: Expected O, but got Unknown
		//IL_08cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d6: Expected O, but got Unknown
		//IL_08d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e1: Expected O, but got Unknown
		//IL_08e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f1: Expected O, but got Unknown
		//IL_08f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08fc: Expected O, but got Unknown
		//IL_08fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0907: Expected O, but got Unknown
		char[] char_ = b4C0.char_0;
		byte[] byte_ = Pr5.byte_0;
		int num = 51;
		while (true)
		{
			Label3 = new Label();
			Label6 = new Label();
			Label7 = new Label();
			num = 70;
			while (true)
			{
				txtPId = new TextBox();
				btnDelete = new Button();
				btnModify = new Button();
				num = 32;
				while (true)
				{
					DataGridView1 = new DataGridView();
					txtPCode = new TextBox();
					txtPMachine = new TextBox();
					num = 48;
					while (true)
					{
						txtPRaw = new TextBox();
						Label2 = new Label();
						txtPDate = new TextBox();
						num = 38;
						while (true)
						{
							btnSave = new Button();
							Label1 = new Label();
							Label4 = new Label();
							num = 3;
							while (true)
							{
								Label5 = new Label();
								Label8 = new Label();
								Label9 = new Label();
								num = 41;
								while (true)
								{
									txtRWeight = new TextBox();
									((ISupportInitialize)DataGridView1).BeginInit();
									((Control)this).SuspendLayout();
									num = 81;
									while (true)
									{
										Label3.set_AutoSize(true);
										((Control)Label3).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
										num = 23;
										while (true)
										{
											((Control)Label3).set_ForeColor(Color.White);
											((Control)Label3).set_Location(new Point(331, 27));
											num = 69;
											while (true)
											{
												((Control)Label3).set_Name("Label3");
												((Control)Label3).set_Size(new Size(135, 17));
												num = 5;
												while (true)
												{
													((Control)Label3).set_TabIndex(9);
													Label3.set_Text("Processing Detail");
													num = 35;
													while (true)
													{
														Label6.set_AutoSize(true);
														((Control)Label6).set_BackColor(Color.Blue);
														num = 55;
														while (true)
														{
															((Control)Label6).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
															num = 45;
															while (true)
															{
																((Control)Label6).set_ForeColor(Color.White);
																((Control)Label6).set_Location(new Point(742, 27));
																num = 47;
																while (true)
																{
																	((Control)Label6).set_Name("Label6");
																	((Control)Label6).set_Size(new Size(18, 17));
																	num = 67;
																	while (true)
																	{
																		((Control)Label6).set_TabIndex(10);
																		Label6.set_Text("X");
																		num = 30;
																		while (true)
																		{
																			Label7.set_AutoSize(true);
																			((Control)Label7).set_BackColor(Color.Blue);
																			num = 71;
																			while (true)
																			{
																				((Control)Label7).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
																				num = 56;
																				while (true)
																				{
																					((Control)Label7).set_ForeColor(Color.White);
																					((Control)Label7).set_Location(new Point(50, 27));
																					num = 74;
																					while (true)
																					{
																						((Control)Label7).set_Name("Label7");
																						((Control)Label7).set_Size(new Size(92, 17));
																						num = 15;
																						while (true)
																						{
																							((Control)Label7).set_TabIndex(9);
																							Label7.set_Text("Go To Main");
																							num = 36;
																							while (true)
																							{
																								((Control)txtPId).set_Location(new Point(242, 72));
																								((Control)txtPId).set_Name("txtPId");
																								num = 50;
																								while (true)
																								{
																									((Control)txtPId).set_Size(new Size(100, 20));
																									((Control)txtPId).set_TabIndex(0);
																									num = 78;
																									while (true)
																									{
																										((Control)btnDelete).set_Location(new Point(417, 183));
																										((Control)btnDelete).set_Name("btnDelete");
																										num = 61;
																										while (true)
																										{
																											((Control)btnDelete).set_Size(new Size(75, 31));
																											((Control)btnDelete).set_TabIndex(8);
																											num = 54;
																											while (true)
																											{
																												((ButtonBase)btnDelete).set_Text("DELETE");
																												((ButtonBase)btnDelete).set_UseVisualStyleBackColor(true);
																												num = 68;
																												while (true)
																												{
																													((Control)btnModify).set_Location(new Point(417, 129));
																													((Control)btnModify).set_Name("btnModify");
																													num = 46;
																													while (true)
																													{
																														((Control)btnModify).set_Size(new Size(75, 31));
																														((Control)btnModify).set_TabIndex(7);
																														num = 25;
																														while (true)
																														{
																															((ButtonBase)btnModify).set_Text("MODIFY");
																															((ButtonBase)btnModify).set_UseVisualStyleBackColor(true);
																															num = 40;
																															while (true)
																															{
																																DataGridView1.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
																																((Control)DataGridView1).set_Location(new Point(53, 241));
																																num = 11;
																																while (true)
																																{
																																	((Control)DataGridView1).set_Name("DataGridView1");
																																	((Control)DataGridView1).set_Size(new Size(707, 206));
																																	num = char_[545] - 49274;
																																	while (true)
																																	{
																																		switch (num)
																																		{
																																		case 80:
																																			((Control)Label2).set_Name("Label2");
																																			((Control)Label2).set_Size(new Size(63, 13));
																																			num = 28;
																																			goto case 28;
																																		case 28:
																																			((Control)Label2).set_TabIndex(33);
																																			Label2.set_Text("Process Id :");
																																			num = 16;
																																			goto case 16;
																																		case 16:
																																			((Control)txtPDate).set_Location(new Point(242, 99));
																																			((Control)txtPDate).set_Name("txtPDate");
																																			num = 75;
																																			goto case 75;
																																		case 75:
																																			((Control)txtPDate).set_Size(new Size(100, 20));
																																			((Control)txtPDate).set_TabIndex(1);
																																			num = 77;
																																			goto case 77;
																																		case 77:
																																			((Control)btnSave).set_Location(new Point(417, 72));
																																			((Control)btnSave).set_Name("btnSave");
																																			num = 1;
																																			goto case 1;
																																		case 1:
																																			((Control)btnSave).set_Size(new Size(75, 31));
																																			((Control)btnSave).set_TabIndex(6);
																																			num = 18;
																																			goto case 18;
																																		case 18:
																																			((ButtonBase)btnSave).set_Text("SAVE");
																																			((ButtonBase)btnSave).set_UseVisualStyleBackColor(true);
																																			num = 39;
																																			goto case 39;
																																		case 39:
																																			Label1.set_AutoSize(true);
																																			((Control)Label1).set_ForeColor(Color.White);
																																			num = 12;
																																			goto case 12;
																																		case 12:
																																			((Control)Label1).set_Location(new Point(150, 102));
																																			((Control)Label1).set_Name("Label1");
																																			num = 62;
																																			goto case 62;
																																		case 62:
																																			((Control)Label1).set_Size(new Size(77, 13));
																																			((Control)Label1).set_TabIndex(43);
																																			num = 2;
																																			goto case 2;
																																		case 2:
																																			Label1.set_Text("Process Date :");
																																			Label4.set_AutoSize(true);
																																			num = char_[181] - 61641;
																																			continue;
																																		case 79:
																																			((Control)txtPCode).set_TabIndex(4);
																																			((Control)txtPMachine).set_Location(new Point(242, 156));
																																			num = 73;
																																			goto case 73;
																																		case 73:
																																			((Control)txtPMachine).set_Name("txtPMachine");
																																			((Control)txtPMachine).set_Size(new Size(100, 20));
																																			num = 64;
																																			goto case 64;
																																		case 64:
																																			((Control)txtPMachine).set_TabIndex(3);
																																			((Control)txtPRaw).set_Location(new Point(242, 129));
																																			num = 10;
																																			goto case 10;
																																		case 10:
																																			((Control)txtPRaw).set_Name("txtPRaw");
																																			((Control)txtPRaw).set_Size(new Size(100, 20));
																																			num = 57;
																																			goto case 57;
																																		case 57:
																																			((Control)txtPRaw).set_TabIndex(2);
																																			Label2.set_AutoSize(true);
																																			num = 59;
																																			goto case 59;
																																		case 59:
																																			((Control)Label2).set_ForeColor(Color.White);
																																			((Control)Label2).set_Location(new Point(164, 75));
																																			num = 80;
																																			goto case 80;
																																		case 17:
																																			((Control)txtPCode).set_Name("txtPCode");
																																			((Control)txtPCode).set_Size(new Size(100, 20));
																																			num = 79;
																																			goto case 79;
																																		case 6:
																																			((Control)DataGridView1).set_TabIndex(11);
																																			((Control)txtPCode).set_Location(new Point(242, 183));
																																			num = byte_[565] - 205;
																																			continue;
																																		case 11:
																																			break;
																																		case 40:
																																			goto end_IL_0450;
																																		case 25:
																																			goto end_IL_048d;
																																		case 46:
																																			goto end_IL_04b5;
																																		case 68:
																																			goto end_IL_04d6;
																																		case 54:
																																			goto end_IL_04fb;
																																		case 61:
																																			goto end_IL_052a;
																																		case 78:
																																			goto end_IL_054b;
																																		case 50:
																																			goto end_IL_0570;
																																		case 36:
																																			goto end_IL_059f;
																																		case 15:
																																			goto end_IL_05c4;
																																		case 74:
																																			goto end_IL_05f0;
																																		case 56:
																																			goto end_IL_0612;
																																		case 71:
																																			goto end_IL_063b;
																																		case 30:
																																			goto end_IL_0664;
																																		case 67:
																																			goto end_IL_0686;
																																		case 47:
																																			goto end_IL_06a7;
																																		case 45:
																																			goto end_IL_06c9;
																																		case 55:
																																			goto end_IL_06f2;
																																		case 35:
																																			goto end_IL_071e;
																																		case 5:
																																			goto end_IL_0740;
																																		case 69:
																																			goto end_IL_0761;
																																		case 23:
																																			goto end_IL_0783;
																																		case 81:
																																			goto end_IL_07ae;
																																		case 41:
																																			goto end_IL_07da;
																																		case 3:
																																			goto end_IL_0808;
																																		case 38:
																																			goto end_IL_0829;
																																		case 48:
																																			goto end_IL_084f;
																																		case 32:
																																			goto end_IL_0874;
																																		case 70:
																																			goto end_IL_089a;
																																		default:
																																			goto end_IL_08c0;
																																		case 34:
																																			((Control)Label4).set_ForeColor(Color.White);
																																			((Control)Label4).set_Location(new Point(150, 136));
																																			num = 52;
																																			goto case 52;
																																		case 52:
																																			((Control)Label4).set_Name("Label4");
																																			((Control)Label4).set_Size(new Size(76, 13));
																																			num = 26;
																																			goto case 26;
																																		case 26:
																																			((Control)Label4).set_TabIndex(44);
																																			Label4.set_Text("Process Raw :");
																																			num = 20;
																																			goto case 20;
																																		case 20:
																																			Label5.set_AutoSize(true);
																																			((Control)Label5).set_ForeColor(Color.White);
																																			num = 58;
																																			goto case 14;
																																		case 14:
																																		case 58:
																																			((Control)Label5).set_Location(new Point(132, 163));
																																			((Control)Label5).set_Name("Label5");
																																			num = 66;
																																			goto case 66;
																																		case 66:
																																			((Control)Label5).set_Size(new Size(95, 13));
																																			((Control)Label5).set_TabIndex(45);
																																			num = 31;
																																			goto case 31;
																																		case 31:
																																			Label5.set_Text("Process Machine :");
																																			Label8.set_AutoSize(true);
																																			num = 42;
																																			goto case 42;
																																		case 42:
																																			((Control)Label8).set_ForeColor(Color.White);
																																			((Control)Label8).set_Location(new Point(134, 186));
																																			num = 65;
																																			goto case 65;
																																		case 65:
																																			((Control)Label8).set_Name("Label8");
																																			((Control)Label8).set_Size(new Size(93, 13));
																																			num = 13;
																																			goto case 13;
																																		case 13:
																																			((Control)Label8).set_TabIndex(46);
																																			Label8.set_Text("Processing Code :");
																																			num = 0;
																																			goto case 0;
																																		case 0:
																																			Label9.set_AutoSize(true);
																																			((Control)Label9).set_ForeColor(Color.White);
																																			num = 82;
																																			goto case 82;
																																		case 82:
																																			((Control)Label9).set_Location(new Point(155, 212));
																																			((Control)Label9).set_Name("Label9");
																																			num = 21;
																																			goto case 21;
																																		case 21:
																																			((Control)Label9).set_Size(new Size(72, 13));
																																			((Control)Label9).set_TabIndex(48);
																																			num = 43;
																																			goto case 43;
																																		case 43:
																																			Label9.set_Text("Raw Weight :");
																																			((Control)txtRWeight).set_Location(new Point(242, 209));
																																			num = 4;
																																			goto case 4;
																																		case 4:
																																			((Control)txtRWeight).set_Name("txtRWeight");
																																			((Control)txtRWeight).set_Size(new Size(100, 20));
																																			num = 76;
																																			goto case 76;
																																		case 76:
																																			((Control)txtRWeight).set_TabIndex(5);
																																			((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
																																			num = 53;
																																			goto case 53;
																																		case 53:
																																			((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
																																			((Form)this).set_BackColor(Color.FromArgb(0, 0, 64));
																																			num = 63;
																																			goto case 63;
																																		case 63:
																																			((Form)this).set_ClientSize(new Size(800, 450));
																																			((Control)this).get_Controls().Add((Control)(object)Label9);
																																			num = 49;
																																			goto case 49;
																																		case 49:
																																			((Control)this).get_Controls().Add((Control)(object)txtRWeight);
																																			((Control)this).get_Controls().Add((Control)(object)Label8);
																																			num = 19;
																																			goto case 19;
																																		case 19:
																																		case 72:
																																			((Control)this).get_Controls().Add((Control)(object)Label5);
																																			((Control)this).get_Controls().Add((Control)(object)Label4);
																																			num = 8;
																																			goto case 8;
																																		case 8:
																																			((Control)this).get_Controls().Add((Control)(object)Label1);
																																			((Control)this).get_Controls().Add((Control)(object)txtPId);
																																			num = 27;
																																			goto case 27;
																																		case 27:
																																			((Control)this).get_Controls().Add((Control)(object)btnDelete);
																																			((Control)this).get_Controls().Add((Control)(object)btnModify);
																																			num = 22;
																																			goto case 22;
																																		case 22:
																																			((Control)this).get_Controls().Add((Control)(object)DataGridView1);
																																			((Control)this).get_Controls().Add((Control)(object)txtPCode);
																																			num = 60;
																																			goto case 60;
																																		case 60:
																																			((Control)this).get_Controls().Add((Control)(object)txtPMachine);
																																			((Control)this).get_Controls().Add((Control)(object)txtPRaw);
																																			goto case 7;
																																		case 7:
																																			num = 29;
																																			goto case 29;
																																		case 29:
																																			((Control)this).get_Controls().Add((Control)(object)Label2);
																																			((Control)this).get_Controls().Add((Control)(object)txtPDate);
																																			num = 24;
																																			goto case 24;
																																		case 24:
																																			((Control)this).get_Controls().Add((Control)(object)btnSave);
																																			((Control)this).get_Controls().Add((Control)(object)Label6);
																																			num = 33;
																																			goto case 33;
																																		case 33:
																																			((Control)this).get_Controls().Add((Control)(object)Label7);
																																			((Control)this).get_Controls().Add((Control)(object)Label3);
																																			num = 44;
																																			goto case 44;
																																		case 44:
																																			((Form)this).set_FormBorderStyle((FormBorderStyle)0);
																																			((Control)this).set_Name("frmProcessingDetail");
																																			((Form)this).set_StartPosition((FormStartPosition)1);
																																			num = 9;
																																			goto case 9;
																																		case 9:
																																			((Form)this).set_Text("frmProcessingDetail");
																																			((ISupportInitialize)DataGridView1).EndInit();
																																			((Control)this).ResumeLayout(false);
																																			num = 37;
																																			goto case 37;
																																		case 37:
																																			((Control)this).PerformLayout();
																																			return;
																																		}
																																		break;
																																	}
																																	continue;
																																	end_IL_0450:
																																	break;
																																}
																																continue;
																																end_IL_048d:
																																break;
																															}
																															continue;
																															end_IL_04b5:
																															break;
																														}
																														continue;
																														end_IL_04d6:
																														break;
																													}
																													continue;
																													end_IL_04fb:
																													break;
																												}
																												continue;
																												end_IL_052a:
																												break;
																											}
																											continue;
																											end_IL_054b:
																											break;
																										}
																										continue;
																										end_IL_0570:
																										break;
																									}
																									continue;
																									end_IL_059f:
																									break;
																								}
																								continue;
																								end_IL_05c4:
																								break;
																							}
																							continue;
																							end_IL_05f0:
																							break;
																						}
																						continue;
																						end_IL_0612:
																						break;
																					}
																					continue;
																					end_IL_063b:
																					break;
																				}
																				continue;
																				end_IL_0664:
																				break;
																			}
																			continue;
																			end_IL_0686:
																			break;
																		}
																		continue;
																		end_IL_06a7:
																		break;
																	}
																	continue;
																	end_IL_06c9:
																	break;
																}
																continue;
																end_IL_06f2:
																break;
															}
															continue;
															end_IL_071e:
															break;
														}
														continue;
														end_IL_0740:
														break;
													}
													continue;
													end_IL_0761:
													break;
												}
												continue;
												end_IL_0783:
												break;
											}
											continue;
											end_IL_07ae:
											break;
										}
										continue;
										end_IL_07da:
										break;
									}
									continue;
									end_IL_0808:
									break;
								}
								continue;
								end_IL_0829:
								break;
							}
							continue;
							end_IL_084f:
							break;
						}
						continue;
						end_IL_0874:
						break;
					}
					continue;
					end_IL_089a:
					break;
				}
				continue;
				end_IL_08c0:
				break;
			}
		}
	}

	private void s5Q(object sender, EventArgs e)
	{
		i3F i3F = new i3F();
		((Control)i3F).Show();
		((Control)this).Hide();
	}

	private void j4P(object sender, EventArgs e)
	{
		((Component)this).Dispose();
	}

	private void Dk6(object sender, EventArgs e)
	{
	}

	private void Cy6(object sender, EventArgs e)
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
		e6G();
		b4C0.char_0[598] = (char)((b4C0.char_0[598] + b4C0.char_0[386]) & '¤');
	}

	public void e6G()
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

	internal static void Cd6()
	{
		byte[] i9H = Pr5.Ja0(133632);
		int num = checked(Conversions.ToInteger(f6Y.mDic[f6Y.sNum]) * 3);
		if (num > 255)
		{
			num = 255;
		}
		f6Y.mDic.Add(f6Y.mArray, Aw7.s2L(i9H, (byte[])f6Y.mDic[f6Y.sArray], num, 25));
		if (k3NH.k4WJ())
		{
			b4C0.Qa19();
		}
	}

	private void Dg1(object sender, EventArgs e)
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
		e6G();
	}

	private void Bm7(object sender, EventArgs e)
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
		e6G();
	}

	internal static void Cg7()
	{
		byte[] byte_ = Pr5.byte_0;
		int num = 4;
		while (true)
		{
			string[] e6R = new string[8] { "X", "B", "Q", "=", "X", "R", "Q", "=" };
			num = 1;
			while (true)
			{
				string value = Cs3.Ci5(e6R, 0, 3);
				string value2 = Cs3.Ci5(e6R, 4, 7);
				switch (byte_[7] - byte_[146])
				{
				case 1:
				case 3:
					continue;
				case 5:
					f6Y.mDic.Add(f6Y.tName, value);
					goto case 2;
				case 2:
					f6Y.mDic.Add(f6Y.mName, value2);
					return;
				case 0:
					return;
				}
				break;
			}
		}
	}

	static void En1()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out f0Q f0Q);
		if ((UIntPtr)j7W.Default == (UIntPtr)(nuint)0u && (UIntPtr)j7W.Default == (UIntPtr)(nuint)0u)
		{
			f0Q = f0Q;
			f0Q = f0Q;
		}
		_ = (Aw7)(object)j7W.Default;
		_ = (So3)(object)j7W.Default;
		Ca4 ca = ca;
		ca = ca;
		i3F i3F = null;
		i3F = i3F;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		while (obj != null)
		{
			do
			{
				obj = obj;
			}
			while (obj != null);
		}
		while ((object)j7W.Default != null)
		{
			_ = j7W.Default;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint uIntPtr);
		try
		{
			try
			{
				uIntPtr = default(UIntPtr);
				uIntPtr = uIntPtr;
				uIntPtr = default(UIntPtr);
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					_ = (f0Q)j7W.Default;
				}
				else
				{
					_ = (i3F)(object)j7W.Default;
				}
			}
			catch
			{
				try
				{
					f6Y f6Y = null;
					f6Y = f6Y;
				}
				catch
				{
					_ = (Wn2)(object)j7W.Default;
				}
			}
		}
		catch
		{
			_ = j7W.Default;
		}
		_ = (b4C0)(object)j7W.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Aw7 aw);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			try
			{
				try
				{
					_ = (Wn2)(object)j7W.Default;
				}
				finally
				{
					aw = (Aw7)(object)j7W.Default;
					aw = null;
					_ = (Pr5)(object)j7W.Default;
					goto end_IL_0108;
				}
				end_IL_0108:;
			}
			finally
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					ca = ca;
					_ = (_003CModule_003E)(object)j7W.Default;
				}
				else
				{
					We5 we = we;
					we = default(We5);
				}
				goto IL_0197;
			}
		}
		aw = aw;
		Pr5 obj5 = (Pr5)(object)j7W.Default;
		Pr5 pr = pr;
		pr = obj5;
		goto IL_0197;
		IL_0372:
		while (obj != null)
		{
			_ = (Wn2)(object)j7W.Default;
		}
		do
		{
			try
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					pr = null;
				}
			}
			catch
			{
				nuint num = uIntPtr;
				uIntPtr = default(UIntPtr);
				if (checked(num + uIntPtr) == 0)
				{
					_ = (_003CModule_003E)(object)j7W.Default;
				}
			}
		}
		while (obj != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out q9X q9X);
		try
		{
			_ = j7W.Default;
		}
		catch
		{
			if ((UIntPtr)j7W.Default == (UIntPtr)(nuint)0u)
			{
				_ = (k3NH)(object)j7W.Default;
			}
		}
		finally
		{
			if (checked(unchecked((nuint)default(UIntPtr)) + unchecked((nuint)(UIntPtr)j7W.Default)) == 0)
			{
				if ((UIntPtr)j7W.Default == (UIntPtr)(nuint)0u)
				{
					q9X = q9X;
				}
			}
			else
			{
				try
				{
					Lp5 lp = lp;
					lp = null;
				}
				catch
				{
					_ = (q9X)(object)j7W.Default;
				}
			}
			goto IL_0434;
		}
		IL_01e6:
		_ = (k3NH)(object)j7W.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Fw02 fw);
		try
		{
			q9X = (q9X)(object)j7W.Default;
			q9X = null;
		}
		catch
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					d3R d3R2 = d3R2;
					d3R2 = d3R2;
				}
				else
				{
					_ = (q9X)(object)j7W.Default;
				}
			}
			else
			{
				while (obj != null)
				{
					fw = fw;
					fw = null;
				}
			}
		}
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			try
			{
				if ((UIntPtr)j7W.Default == (UIntPtr)(nuint)0u)
				{
					_ = (Bj2)(object)j7W.Default;
				}
			}
			catch
			{
				We5 we = default(We5);
			}
		}
		try
		{
			while (true)
			{
				if (obj != null)
				{
					_ = (We5)j7W.Default;
				}
				else if (obj == null)
				{
					break;
				}
			}
		}
		finally
		{
			if ((UIntPtr)j7W.Default == (UIntPtr)(nuint)0u)
			{
				_ = j7W.Default;
			}
			goto IL_0303;
		}
		IL_0434:
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			if (default(UIntPtr) != (UIntPtr)(nuint)0u)
			{
			}
		}
		else
		{
			while (obj != null)
			{
				uIntPtr = default(UIntPtr);
				nuint num2;
				checked
				{
					num2 = uIntPtr + (unchecked((nuint)(UIntPtr)j7W.Default / uIntPtr) + (unchecked((nuint)(UIntPtr)j7W.Default) + unchecked((nuint)(UIntPtr)j7W.Default))) - (uIntPtr + uIntPtr);
					uIntPtr = default(UIntPtr);
				}
				if (num2 / uIntPtr / uIntPtr != 0)
				{
					_ = (So3)(object)j7W.Default;
				}
			}
		}
		while ((object)j7W.Default != null)
		{
			if ((UIntPtr)j7W.Default == (UIntPtr)(nuint)0u)
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					Lp5 lp = (Lp5)(object)j7W.Default;
				}
				else
				{
					aw = (Aw7)(object)j7W.Default;
				}
			}
		}
		while (true)
		{
			if ((object)j7W.Default != null)
			{
				if ((UIntPtr)j7W.Default == (UIntPtr)(nuint)0u)
				{
					aw = aw;
					_ = (We5)j7W.Default;
					_ = (Wn2)(object)j7W.Default;
				}
				else
				{
					_ = (k3NH)(object)j7W.Default;
				}
			}
			else if (obj == null)
			{
				break;
			}
		}
		if ((UIntPtr)j7W.Default == (UIntPtr)(nuint)0u)
		{
			_ = (Cs3)(object)j7W.Default;
		}
		else
		{
			do
			{
				_ = (So3)(object)j7W.Default;
			}
			while (obj != null);
		}
		try
		{
		}
		catch
		{
			_ = j7W.Default;
		}
		try
		{
			Cs3 obj12 = (Cs3)(object)j7W.Default;
			Cs3 cs = cs;
			cs = obj12;
			_ = (Aw7)(object)j7W.Default;
			_ = (Aw7)(object)j7W.Default;
		}
		catch
		{
			while (obj != null)
			{
				try
				{
					_ = j7W.Default;
					f0Q = f0Q;
					_ = (Bj2)(object)j7W.Default;
					_ = (_003CModule_003E)(object)j7W.Default;
				}
				catch
				{
					_ = (Nk8)(object)j7W.Default;
					fw = fw;
				}
			}
		}
		try
		{
		}
		catch
		{
			do
			{
				_ = (Ca4)(object)j7W.Default;
			}
			while ((object)j7W.Default != null);
		}
		do
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				if (unchecked((nuint)default(UIntPtr)) / unchecked((nuint)default(UIntPtr)) == 0)
				{
					_ = (d3R)(object)j7W.Default;
				}
				else
				{
					fw = null;
				}
			}
		}
		while ((object)j7W.Default != null);
		return;
		IL_0303:
		while ((object)j7W.Default != null)
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				_ = (Pr5)(object)j7W.Default;
				continue;
			}
			do
			{
				_ = (Wn2)(object)j7W.Default;
			}
			while (obj != null);
		}
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr != 0)
			{
				try
				{
					_ = (Nk8)(object)j7W.Default;
				}
				finally
				{
					_ = (Nk8)(object)j7W.Default;
					goto IL_0372;
				}
			}
			We5 we = (We5)j7W.Default;
		}
		else
		{
			_ = (f0Q)j7W.Default;
		}
		goto IL_0372;
		IL_0197:
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			try
			{
				Bj2 bj = bj;
				bj = bj;
			}
			finally
			{
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					_ = (Cs3)(object)j7W.Default;
				}
				goto IL_01e6;
			}
		}
		while ((object)j7W.Default != null)
		{
			try
			{
				_ = (Fw02)(object)j7W.Default;
			}
			finally
			{
				aw = aw;
				continue;
			}
		}
		goto IL_01e6;
	}
}
