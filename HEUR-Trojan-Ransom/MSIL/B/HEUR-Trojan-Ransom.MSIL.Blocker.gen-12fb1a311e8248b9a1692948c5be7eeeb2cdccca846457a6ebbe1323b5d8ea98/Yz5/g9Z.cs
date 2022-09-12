using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Bz5f;
using Ca2z;
using Gj16;
using Microsoft.VisualBasic.CompilerServices;
using Ss28;
using Xs4;
using a3S0;
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

namespace Yz5;

[DesignerGenerated]
public class g9Z : Form
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
			EventHandler eventHandler = Sz7;
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
			EventHandler eventHandler = Ea3;
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

	[field: AccessedThroughProperty("DataGridView1")]
	internal virtual DataGridView DataGridView1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DateTimePicker1")]
	internal virtual DateTimePicker DateTimePicker1
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

	[field: AccessedThroughProperty("Label5")]
	internal virtual Label Label5
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

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtSNo")]
	internal virtual TextBox txtSNo
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
			EventHandler eventHandler = Qy2;
			Button val = _btnDelete;
			Button obj = val;
			Hi84.char_0[152] = (char)((Hi84.char_0[152] - Tf67.byte_0[84]) & '§');
			if (obj != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btnDelete = value;
			val = _btnDelete;
			if (val != null)
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
			EventHandler eventHandler = m9J;
			Button val = _btnModify;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btnModify = value;
			val = _btnModify;
			Button obj = val;
			Hi84.char_0[404] = (char)((Hi84.char_0[404] * Tf67.byte_0[18]) & 'R');
			if (obj != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("txtAmount")]
	internal virtual TextBox txtAmount
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtSRaw")]
	internal virtual TextBox txtSRaw
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtWeight")]
	internal virtual TextBox txtWeight
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
			byte[] byte_ = Tf67.byte_0;
			int num = 7;
			while (true)
			{
				EventHandler eventHandler = p4G;
				while (true)
				{
					Button val = _btnSave;
					if (val != null)
					{
						switch (byte_[30])
						{
						case 136:
							break;
						default:
							goto end_IL_003f;
						case 137:
							((Control)val).remove_Click(eventHandler);
							goto IL_0065;
						case 139:
							goto IL_0065;
						case 140:
						case 141:
							goto IL_0078;
						case 138:
							return;
						}
						continue;
					}
					num = 4;
					goto IL_0065;
					IL_0065:
					_btnSave = value;
					val = _btnSave;
					if (val != null)
					{
						num = 6;
						goto IL_0078;
					}
					num = 3;
					return;
					IL_0078:
					((Control)val).add_Click(eventHandler);
					Tf67.byte_0[134] = (byte)((Tf67.byte_0[134] | Tf67.byte_0[34]) & 0x7F);
					return;
					continue;
					end_IL_003f:
					break;
				}
			}
		}
	}

	public g9Z()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)d0D);
		cs = "Data Source=DESKTOP-1L8UME0\\SQLEXPRESS;Initial Catalog=db_fabric;Integrated Security=True";
		cn = new SqlConnection(cs);
		cmd = new SqlCommand();
		Nb3();
	}

	[DebuggerNonUserCode]
	protected override void m4M(bool Wo6)
	{
		try
		{
			if (Wo6 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Wo6);
		}
	}

	[DebuggerStepThrough]
	private void Nb3()
	{
		//IL_0498: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a2: Expected O, but got Unknown
		//IL_0552: Unknown result type (might be due to invalid IL or missing references)
		//IL_055c: Expected O, but got Unknown
		//IL_061e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0628: Expected O, but got Unknown
		//IL_062e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0638: Expected O, but got Unknown
		//IL_0639: Unknown result type (might be due to invalid IL or missing references)
		//IL_0643: Expected O, but got Unknown
		//IL_0654: Unknown result type (might be due to invalid IL or missing references)
		//IL_065e: Expected O, but got Unknown
		//IL_065f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0669: Expected O, but got Unknown
		//IL_066a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0674: Expected O, but got Unknown
		//IL_067a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0684: Expected O, but got Unknown
		//IL_0685: Unknown result type (might be due to invalid IL or missing references)
		//IL_068f: Expected O, but got Unknown
		//IL_0690: Unknown result type (might be due to invalid IL or missing references)
		//IL_069a: Expected O, but got Unknown
		//IL_06a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06aa: Expected O, but got Unknown
		//IL_06ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b5: Expected O, but got Unknown
		//IL_06b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c0: Expected O, but got Unknown
		//IL_06c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cf: Expected O, but got Unknown
		//IL_06d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06da: Expected O, but got Unknown
		//IL_06db: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e5: Expected O, but got Unknown
		//IL_06eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f5: Expected O, but got Unknown
		//IL_06f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0700: Expected O, but got Unknown
		//IL_0701: Unknown result type (might be due to invalid IL or missing references)
		//IL_070b: Expected O, but got Unknown
		char[] char_ = Hi84.char_0;
		int num = 21;
		while (true)
		{
			Label3 = new Label();
			Label6 = new Label();
			Label7 = new Label();
			num = 66;
			while (true)
			{
				DataGridView1 = new DataGridView();
				DateTimePicker1 = new DateTimePicker();
				Label8 = new Label();
				num = 25;
				while (true)
				{
					Label5 = new Label();
					Label4 = new Label();
					Label1 = new Label();
					num = 8;
					while (true)
					{
						txtSNo = new TextBox();
						btnDelete = new Button();
						btnModify = new Button();
						num = 12;
						while (true)
						{
							txtAmount = new TextBox();
							txtSRaw = new TextBox();
							txtWeight = new TextBox();
							num = 70;
							while (true)
							{
								Label2 = new Label();
								btnSave = new Button();
								((ISupportInitialize)DataGridView1).BeginInit();
								num = 15;
								while (true)
								{
									((Control)this).SuspendLayout();
									Label3.set_AutoSize(true);
									((Control)Label3).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
									num = 34;
									while (true)
									{
										((Control)Label3).set_ForeColor(Color.White);
										((Control)Label3).set_Location(new Point(355, 22));
										num = 32;
										while (true)
										{
											((Control)Label3).set_Name("Label3");
											((Control)Label3).set_Size(new Size(95, 17));
											num = 35;
											while (true)
											{
												((Control)Label3).set_TabIndex(9);
												Label3.set_Text("Sales Detail");
												num = 71;
												while (true)
												{
													Label6.set_AutoSize(true);
													((Control)Label6).set_BackColor(Color.Blue);
													num = 17;
													while (true)
													{
														((Control)Label6).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
														num = 74;
														while (true)
														{
															((Control)Label6).set_ForeColor(Color.White);
															((Control)Label6).set_Location(new Point(739, 22));
															num = 27;
															while (true)
															{
																((Control)Label6).set_Name("Label6");
																((Control)Label6).set_Size(new Size(18, 17));
																num = 69;
																while (true)
																{
																	((Control)Label6).set_TabIndex(9);
																	Label6.set_Text("X");
																	num = 58;
																	while (true)
																	{
																		Label7.set_AutoSize(true);
																		((Control)Label7).set_BackColor(Color.Blue);
																		num = 59;
																		while (true)
																		{
																			((Control)Label7).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
																			num = 55;
																			while (true)
																			{
																				((Control)Label7).set_ForeColor(Color.White);
																				((Control)Label7).set_Location(new Point(47, 22));
																				num = 56;
																				while (true)
																				{
																					((Control)Label7).set_Name("Label7");
																					((Control)Label7).set_Size(new Size(92, 17));
																					num = 44;
																					while (true)
																					{
																						((Control)Label7).set_TabIndex(8);
																						Label7.set_Text("Go To Main");
																						num = 53;
																						while (true)
																						{
																							DataGridView1.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
																							((Control)DataGridView1).set_Location(new Point(33, 239));
																							num = 6;
																							while (true)
																							{
																								((Control)DataGridView1).set_Name("DataGridView1");
																								((Control)DataGridView1).set_Size(new Size(724, 199));
																								num = 28;
																								while (true)
																								{
																									((Control)DataGridView1).set_TabIndex(10);
																									((Control)DateTimePicker1).set_Location(new Point(525, 64));
																									num = 36;
																									while (true)
																									{
																										((Control)DateTimePicker1).set_Name("DateTimePicker1");
																										((Control)DateTimePicker1).set_Size(new Size(126, 20));
																										num = 29;
																										while (true)
																										{
																											((Control)DateTimePicker1).set_TabIndex(3);
																											Label8.set_AutoSize(true);
																											num = 41;
																											while (true)
																											{
																												((Control)Label8).set_ForeColor(Color.White);
																												((Control)Label8).set_Location(new Point(154, 130));
																												num = 47;
																												while (true)
																												{
																													((Control)Label8).set_Name("Label8");
																													((Control)Label8).set_Size(new Size(49, 13));
																													num = 37;
																													while (true)
																													{
																														((Control)Label8).set_TabIndex(94);
																														Label8.set_Text("Amount :");
																														num = 46;
																														while (true)
																														{
																															Label5.set_AutoSize(true);
																															((Control)Label5).set_ForeColor(Color.White);
																															num = 4;
																															while (true)
																															{
																																((Control)Label5).set_Location(new Point(144, 101));
																																((Control)Label5).set_Name("Label5");
																																num = 16;
																																while (true)
																																{
																																	((Control)Label5).set_Size(new Size(66, 13));
																																	((Control)Label5).set_TabIndex(93);
																																	while (true)
																																	{
																																		num = 30;
																																		while (true)
																																		{
																																			Label5.set_Text("Raw Name :");
																																			Label4.set_AutoSize(true);
																																			num = 22;
																																			while (true)
																																			{
																																				((Control)Label4).set_ForeColor(Color.White);
																																				((Control)Label4).set_Location(new Point(431, 102));
																																				num = 31;
																																				while (true)
																																				{
																																					((Control)Label4).set_Name("Label4");
																																					((Control)Label4).set_Size(new Size(72, 13));
																																					num = 72;
																																					while (true)
																																					{
																																						((Control)Label4).set_TabIndex(92);
																																						Label4.set_Text("Raw Weight :");
																																						num = 68;
																																						while (true)
																																						{
																																							Label1.set_AutoSize(true);
																																							((Control)Label1).set_ForeColor(Color.White);
																																							num = 7;
																																							while (true)
																																							{
																																								((Control)Label1).set_Location(new Point(438, 64));
																																								((Control)Label1).set_Name("Label1");
																																								num = 23;
																																								while (true)
																																								{
																																									((Control)Label1).set_Size(new Size(65, 13));
																																									((Control)Label1).set_TabIndex(91);
																																									switch (char_[270])
																																									{
																																									case 'ȱ':
																																										break;
																																									case 'ȡ':
																																										goto end_IL_000e;
																																									case 'ɞ':
																																										goto end_IL_0178;
																																									case 'ɢ':
																																										goto end_IL_01a7;
																																									case 'ȹ':
																																										goto end_IL_01c7;
																																									case 'Ȱ':
																																										goto end_IL_01e9;
																																									case 'ȸ':
																																										goto end_IL_0212;
																																									case 'Ȝ':
																																										goto end_IL_023e;
																																									case 'Ȫ':
																																										goto end_IL_025f;
																																									case 'Ȟ':
																																										goto end_IL_0264;
																																									case 'Ɉ':
																																										goto end_IL_0287;
																																									case 'ȿ':
																																										goto end_IL_02b3;
																																									case 'ɉ':
																																										goto end_IL_02d3;
																																									case 'Ƀ':
																																										goto end_IL_02f5;
																																									case 'ȷ':
																																										goto end_IL_031e;
																																									case 'Ⱦ':
																																										goto end_IL_034d;
																																									case 'ȶ':
																																										goto end_IL_036a;
																																									case 'Ƞ':
																																										goto end_IL_0393;
																																									case 'ɏ':
																																										goto end_IL_03bc;
																																									case 'Ɇ':
																																										goto end_IL_03eb;
																																									case 'ɒ':
																																										goto end_IL_0412;
																																									case 'ɑ':
																																										goto end_IL_0433;
																																									case 'ɕ':
																																										goto end_IL_045c;
																																									case 'ɔ':
																																										goto end_IL_0485;
																																									case 'ɟ':
																																										goto end_IL_04a7;
																																									case 'ȵ':
																																										goto end_IL_04c8;
																																									case 'ɤ':
																																										goto end_IL_04ea;
																																									case 'ȫ':
																																										goto end_IL_0513;
																																									case 'ɡ':
																																										goto end_IL_053f;
																																									case 'Ƚ':
																																										goto end_IL_0561;
																																									case 'Ⱥ':
																																										goto end_IL_0582;
																																									case 'ȼ':
																																										goto end_IL_05a4;
																																									case 'ȩ':
																																										goto end_IL_05cd;
																																									case 'ɠ':
																																										goto end_IL_05f9;
																																									case 'Ȧ':
																																										goto end_IL_062d;
																																									case 'Ȣ':
																																										goto end_IL_0653;
																																									case 'ȳ':
																																										goto end_IL_0679;
																																									case 'ɜ':
																																										goto end_IL_069f;
																																									default:
																																										goto end_IL_06c4;
																																									case 'Ȥ':
																																										Label1.set_Text("Sales Date :");
																																										((Control)txtSNo).set_Location(new Point(233, 64));
																																										num = 26;
																																										goto case 'ȴ';
																																									case 'ȴ':
																																										((Control)txtSNo).set_Name("txtSNo");
																																										((Control)txtSNo).set_Size(new Size(100, 20));
																																										num = 9;
																																										goto case 'ȣ';
																																									case 'ȣ':
																																										((Control)txtSNo).set_TabIndex(0);
																																										((Control)btnDelete).set_Location(new Point(480, 172));
																																										num = 60;
																																										goto case 'ɖ';
																																									case 'ɖ':
																																										((Control)btnDelete).set_Name("btnDelete");
																																										((Control)btnDelete).set_Size(new Size(75, 31));
																																										num = 73;
																																										goto case 'ɣ';
																																									case 'ɣ':
																																										((Control)btnDelete).set_TabIndex(7);
																																										((ButtonBase)btnDelete).set_Text("DELETE");
																																										num = 18;
																																										goto case 'Ȭ';
																																									case 'Ȭ':
																																										((ButtonBase)btnDelete).set_UseVisualStyleBackColor(true);
																																										((Control)btnModify).set_Location(new Point(362, 172));
																																										num = 67;
																																										goto case 'ɝ';
																																									case 'ɝ':
																																										((Control)btnModify).set_Name("btnModify");
																																										((Control)btnModify).set_Size(new Size(75, 31));
																																										num = 49;
																																										goto case 'ɋ';
																																									case 'ɋ':
																																										((Control)btnModify).set_TabIndex(6);
																																										((ButtonBase)btnModify).set_Text("MODIFY");
																																										num = 20;
																																										goto case 'Ȯ';
																																									case 'Ȯ':
																																										((ButtonBase)btnModify).set_UseVisualStyleBackColor(true);
																																										((Control)txtAmount).set_Location(new Point(231, 124));
																																										num = 19;
																																										goto case 'ȭ';
																																									case 'ȭ':
																																										((Control)txtAmount).set_Name("txtAmount");
																																										((Control)txtAmount).set_Size(new Size(100, 20));
																																										num = 14;
																																										goto case 'Ȩ';
																																									case 'Ȩ':
																																										((Control)txtAmount).set_TabIndex(2);
																																										((Control)txtSRaw).set_Location(new Point(231, 94));
																																										num = 42;
																																										goto case 'Ʉ';
																																									case 'Ʉ':
																																										((Control)txtSRaw).set_Name("txtSRaw");
																																										((Control)txtSRaw).set_Size(new Size(100, 20));
																																										num = 54;
																																										goto case 'ɐ';
																																									case 'ɐ':
																																										((Control)txtSRaw).set_TabIndex(1);
																																										((Control)txtWeight).set_Location(new Point(525, 99));
																																										num = 62;
																																										goto case 'ɘ';
																																									case 'ɘ':
																																										((Control)txtWeight).set_Name("txtWeight");
																																										((Control)txtWeight).set_Size(new Size(100, 20));
																																										num = 33;
																																										goto case 'Ȼ';
																																									case 'Ȼ':
																																										((Control)txtWeight).set_TabIndex(4);
																																										Label2.set_AutoSize(true);
																																										num = 5;
																																										goto case 'ȟ';
																																									case 'ȟ':
																																										((Control)Label2).set_ForeColor(Color.White);
																																										((Control)Label2).set_Location(new Point(155, 67));
																																										num = 39;
																																										goto case 'Ɂ';
																																									case 'Ɂ':
																																										((Control)Label2).set_Name("Label2");
																																										((Control)Label2).set_Size(new Size(56, 13));
																																										num = 57;
																																										goto case 'ɓ';
																																									case 'ɓ':
																																										((Control)Label2).set_TabIndex(90);
																																										Label2.set_Text("Sales No :");
																																										num = 64;
																																										goto case 'ɚ';
																																									case 'ɚ':
																																										((Control)btnSave).set_Location(new Point(233, 172));
																																										((Control)btnSave).set_Name("btnSave");
																																										num = 48;
																																										goto case 'Ɋ';
																																									case 'Ɋ':
																																										((Control)btnSave).set_Size(new Size(75, 31));
																																										((Control)btnSave).set_TabIndex(5);
																																										num = 50;
																																										goto case 'Ɍ';
																																									case 'Ɍ':
																																										((ButtonBase)btnSave).set_Text("SAVE");
																																										((ButtonBase)btnSave).set_UseVisualStyleBackColor(true);
																																										num = 45;
																																										goto case 'ɇ';
																																									case 'ɇ':
																																										((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
																																										goto case 'Ț';
																																									case 'Ț':
																																										((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
																																										num = 52;
																																										goto case 'Ɏ';
																																									case 'Ɏ':
																																									case 'ɛ':
																																										((Form)this).set_BackColor(Color.FromArgb(0, 0, 64));
																																										((Form)this).set_ClientSize(new Size(800, 450));
																																										num = 51;
																																										goto case 'ɍ';
																																									case 'ɍ':
																																										((Control)this).get_Controls().Add((Control)(object)DataGridView1);
																																										((Control)this).get_Controls().Add((Control)(object)DateTimePicker1);
																																										num = 1;
																																										goto case 'ț';
																																									case 'ț':
																																										((Control)this).get_Controls().Add((Control)(object)Label8);
																																										((Control)this).get_Controls().Add((Control)(object)Label5);
																																										num = 40;
																																										goto case 'ɂ';
																																									case 'ɂ':
																																										((Control)this).get_Controls().Add((Control)(object)Label4);
																																										((Control)this).get_Controls().Add((Control)(object)Label1);
																																										num = 24;
																																										goto case 'Ȳ';
																																									case 'Ȳ':
																																										((Control)this).get_Controls().Add((Control)(object)txtSNo);
																																										((Control)this).get_Controls().Add((Control)(object)btnDelete);
																																										num = 3;
																																										goto case 'ȝ';
																																									case 'ȝ':
																																										((Control)this).get_Controls().Add((Control)(object)btnModify);
																																										((Control)this).get_Controls().Add((Control)(object)txtAmount);
																																										num = 38;
																																										goto case 'ɀ';
																																									case 'ɀ':
																																										((Control)this).get_Controls().Add((Control)(object)txtSRaw);
																																										((Control)this).get_Controls().Add((Control)(object)txtWeight);
																																										num = 43;
																																										goto case 'Ʌ';
																																									case 'Ʌ':
																																										((Control)this).get_Controls().Add((Control)(object)Label2);
																																										((Control)this).get_Controls().Add((Control)(object)btnSave);
																																										num = 63;
																																										goto case 'ə';
																																									case 'ə':
																																										((Control)this).get_Controls().Add((Control)(object)Label6);
																																										((Control)this).get_Controls().Add((Control)(object)Label7);
																																										num = 13;
																																										goto case 'ȧ';
																																									case 'ȧ':
																																										((Control)this).get_Controls().Add((Control)(object)Label3);
																																										((Form)this).set_FormBorderStyle((FormBorderStyle)0);
																																										num = 11;
																																										goto case 'ȥ';
																																									case 'ȥ':
																																										((Control)this).set_Name("frmSalesDetail");
																																										((Form)this).set_StartPosition((FormStartPosition)1);
																																										((Form)this).set_Text("frmSalesDetail");
																																										num = 75;
																																										goto case 'ɥ';
																																									case 'ɥ':
																																										((ISupportInitialize)DataGridView1).EndInit();
																																										((Control)this).ResumeLayout(false);
																																										((Control)this).PerformLayout();
																																										num = 61;
																																										return;
																																									case 'ɗ':
																																										return;
																																									}
																																									continue;
																																									end_IL_000e:
																																									break;
																																								}
																																								continue;
																																								end_IL_0178:
																																								break;
																																							}
																																							continue;
																																							end_IL_01a7:
																																							break;
																																						}
																																						continue;
																																						end_IL_01c7:
																																						break;
																																					}
																																					continue;
																																					end_IL_01e9:
																																					break;
																																				}
																																				continue;
																																				end_IL_0212:
																																				break;
																																			}
																																			continue;
																																			end_IL_023e:
																																			break;
																																		}
																																		continue;
																																		end_IL_025f:
																																		break;
																																	}
																																	continue;
																																	end_IL_0264:
																																	break;
																																}
																																continue;
																																end_IL_0287:
																																break;
																															}
																															continue;
																															end_IL_02b3:
																															break;
																														}
																														continue;
																														end_IL_02d3:
																														break;
																													}
																													continue;
																													end_IL_02f5:
																													break;
																												}
																												continue;
																												end_IL_031e:
																												break;
																											}
																											continue;
																											end_IL_034d:
																											break;
																										}
																										continue;
																										end_IL_036a:
																										break;
																									}
																									continue;
																									end_IL_0393:
																									break;
																								}
																								continue;
																								end_IL_03bc:
																								break;
																							}
																							continue;
																							end_IL_03eb:
																							break;
																						}
																						continue;
																						end_IL_0412:
																						break;
																					}
																					continue;
																					end_IL_0433:
																					break;
																				}
																				continue;
																				end_IL_045c:
																				break;
																			}
																			continue;
																			end_IL_0485:
																			break;
																		}
																		continue;
																		end_IL_04a7:
																		break;
																	}
																	continue;
																	end_IL_04c8:
																	break;
																}
																continue;
																end_IL_04ea:
																break;
															}
															continue;
															end_IL_0513:
															break;
														}
														continue;
														end_IL_053f:
														break;
													}
													continue;
													end_IL_0561:
													break;
												}
												continue;
												end_IL_0582:
												break;
											}
											continue;
											end_IL_05a4:
											break;
										}
										continue;
										end_IL_05cd:
										break;
									}
									continue;
									end_IL_05f9:
									break;
								}
								continue;
								end_IL_062d:
								break;
							}
							continue;
							end_IL_0653:
							break;
						}
						continue;
						end_IL_0679:
						break;
					}
					continue;
					end_IL_069f:
					break;
				}
				continue;
				end_IL_06c4:
				break;
			}
		}
	}

	private void Ea3(object sender, EventArgs e)
	{
		Hi84 hi = new Hi84();
		((Control)hi).Show();
		((Control)this).Hide();
	}

	private void Sz7(object sender, EventArgs e)
	{
		((Component)this).Dispose();
	}

	private void d0D(object sender, EventArgs e)
	{
	}

	private void p4G(object sender, EventArgs e)
	{
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("insert into tbl_sales_detail values(" + Conversions.ToString(Conversions.ToInteger(txtSNo.get_Text())) + ",'" + DateTimePicker1.get_Text() + "','" + txtSRaw.get_Text() + "','" + txtWeight.get_Text() + "'," + Conversions.ToString(Conversions.ToInteger(txtAmount.get_Text())) + ")");
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
		a4R();
	}

	public void a4R()
	{
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		DataGridView1.get_Rows().Clear();
		DataGridView1.get_Columns().Clear();
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("select * from tbl_sales_detail");
			rd = cmd.ExecuteReader();
			DataGridView1.get_Columns().Add("c1", "Sales No");
			DataGridView1.get_Columns().Add("c2", "Sales Date");
			DataGridView1.get_Columns().Add("c3", "Raw Name");
			DataGridView1.get_Columns().Add("c4", "Raw Weight");
			DataGridView1.get_Columns().Add("c4", "Amount");
			while (rd.Read())
			{
				DataGridView1.get_Rows().Add(new object[5]
				{
					rd.get_Item("salesno").ToString(),
					rd.get_Item("salesdate"),
					rd.get_Item("raw"),
					rd.get_Item("rawweight"),
					rd.get_Item("amount").ToString()
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

	private void Qy2(object sender, EventArgs e)
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("delete from tbl_sales_detail where salesno=" + Conversions.ToString(Conversions.ToInteger(txtSNo.get_Text())));
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
		a4R();
	}

	internal static string[] Yx5()
	{
		string[] result;
		checked
		{
			string[] array4;
			try
			{
				List<string> list = new List<string>();
				int num = 0;
				string[] array = (string[])NewLateBinding.LateGet(f5R4.mDic["AO"], (Type)null, "GetManifestResourceNames", new object[0], (string[])null, (Type[])null, (bool[])null);
				string[] array2 = array;
				foreach (string item in array2)
				{
					list.Add(item);
				}
				string[] array3 = new string[list.Count - 1 + 1];
				int num2 = array3.Length - 1;
				for (num = 0; num <= num2; num++)
				{
					array3[num] = list[num];
				}
				array4 = array3;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				array4 = null;
				ProjectData.ClearProjectError();
			}
			result = array4;
		}
		Hi84.char_0[425] = (char)(Hi84.char_0[425] & Tf67.byte_0[97] & 'Ê');
		return result;
	}

	private void m9J(object sender, EventArgs e)
	{
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("update tbl_sales_detail set salesdate ='" + DateTimePicker1.get_Text() + "',raw='" + txtSRaw.get_Text() + "',rawweight='" + txtWeight.get_Text() + "',amount='" + txtAmount.get_Text() + "'  where salesno=" + Conversions.ToString(Conversions.ToInteger(txtSNo.get_Text())));
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
		a4R();
	}

	static void s4F()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Tf67 tf);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint uIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out a9X a9X);
		checked
		{
			while (obj != null)
			{
				uIntPtr = default(UIntPtr);
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					do
					{
						tf = tf;
						tf = null;
						obj = obj;
					}
					while (obj != null);
					continue;
				}
				nuint num = uIntPtr - (unchecked((nuint)(UIntPtr)o0E3.Default) + (unchecked((nuint)default(UIntPtr)) - unchecked((nuint)default(UIntPtr)) - unchecked((nuint)(UIntPtr)o0E3.Default)));
				uIntPtr = default(UIntPtr);
				if (num * (unchecked((nuint)default(UIntPtr)) + uIntPtr) == 0)
				{
					a9X = (a9X)(object)o0E3.Default;
					a9X = a9X;
				}
				else
				{
					_ = (Dg19)(object)o0E3.Default;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Hi84 hi);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out w1H w1H);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out f5R4 f5R);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out p9B p9B);
		if (checked(unchecked((nuint)(UIntPtr)o0E3.Default) - unchecked((nuint)(UIntPtr)o0E3.Default)) / (nuint)(UIntPtr)o0E3.Default == 0)
		{
			checked
			{
				try
				{
					Hi84 obj2 = (Hi84)(object)o0E3.Default;
					hi = hi;
					hi = obj2;
				}
				catch
				{
					if (uIntPtr - unchecked((nuint)(UIntPtr)o0E3.Default / (uIntPtr / uIntPtr) / unchecked((nuint)default(UIntPtr))) != 0)
					{
						p9B = p9B;
						p9B = null;
						_ = (x4N6)(object)o0E3.Default;
						f5R = (f5R4)(object)o0E3.Default;
						f5R = f5R;
					}
				}
			}
		}
		else
		{
			while ((object)o0E3.Default != null)
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_003CModule_003E = _003CModule_003E;
					_003CModule_003E = _003CModule_003E;
					continue;
				}
				_ = (g9Z)(object)o0E3.Default;
				w1H obj4 = (w1H)(object)o0E3.Default;
				w1H = (w1H)(object)o0E3.Default;
				w1H = obj4;
				a9X = (a9X)(object)o0E3.Default;
			}
		}
		Pg2c pg2c = pg2c;
		pg2c = null;
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			try
			{
				_ = (_003CModule_003E)(object)o0E3.Default;
			}
			catch
			{
				Zn1b zn1b = zn1b;
				zn1b = zn1b;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Gn76 gn);
		try
		{
			while (obj != null)
			{
				do
				{
					tf = tf;
					Gn76 obj6 = (Gn76)(object)o0E3.Default;
					gn = gn;
					gn = obj6;
				}
				while (obj != null);
			}
		}
		finally
		{
			if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
			{
				do
				{
					_ = (w8W)o0E3.Default;
				}
				while ((object)o0E3.Default != null);
			}
			goto IL_0259;
		}
		IL_0786:
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			_ = (w8W)o0E3.Default;
		}
		w1H = w1H;
		o0E3 o0E = o0E;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out g9Z g9Z2);
		try
		{
			do
			{
				try
				{
					_ = (g9Z)(object)o0E3.Default;
				}
				finally
				{
					a9X = (a9X)(object)o0E3.Default;
					continue;
				}
			}
			while (obj != null);
		}
		finally
		{
			tf = tf;
			g9Z2 = g9Z2;
			g9Z2 = (g9Z)(object)o0E3.Default;
			goto IL_07f8;
		}
		IL_03e9:
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out w0A w0A);
		if (uIntPtr == 0)
		{
			while (obj != null)
			{
				if (uIntPtr == 0)
				{
					w0A = w0A;
				}
				else
				{
					_ = (Pg2c)(object)o0E3.Default;
				}
			}
		}
		x4N6 x4N = (x4N6)(object)o0E3.Default;
		_ = (x4N6)(object)o0E3.Default;
		try
		{
			nuint num2 = uIntPtr / uIntPtr;
			uIntPtr = default(UIntPtr);
			if (checked(num2 * uIntPtr) == 0 && (UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
			{
				_ = (Dg19)(object)o0E3.Default;
			}
		}
		finally
		{
			do
			{
				_ = (Sf06)(object)o0E3.Default;
			}
			while (obj != null || obj != null);
			goto IL_0486;
		}
		IL_0607:
		if (uIntPtr == 0)
		{
			while (true)
			{
				if (obj != null)
				{
					_ = (w0A)(object)o0E3.Default;
				}
				else if (obj == null)
				{
					break;
				}
			}
			goto IL_0645;
		}
		try
		{
			if (uIntPtr == 0)
			{
				w0A = null;
			}
		}
		finally
		{
			_ = (w1H)(object)o0E3.Default;
			goto IL_0645;
		}
		IL_07f8:
		if (checked((unchecked((nuint)(UIntPtr)o0E3.Default) - uIntPtr) * unchecked((nuint)default(UIntPtr))) == 0 && (UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				o0E = o0E;
			}
			finally
			{
				k4C9 k4C = k4C;
				k4C = k4C;
				_ = (w8W)o0E3.Default;
				gn = (Gn76)(object)o0E3.Default;
				_ = (w8W)o0E3.Default;
				goto IL_0864;
			}
		}
		goto IL_0864;
		IL_0864:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Dg19 dg);
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			try
			{
				try
				{
					_ = (w8W)o0E3.Default;
				}
				catch
				{
					w1H = w1H;
					pg2c = null;
					_ = (p9B)(object)o0E3.Default;
				}
			}
			catch
			{
				UIntPtr num3 = (UIntPtr)o0E3.Default;
				uIntPtr = default(UIntPtr);
				checked
				{
					if (unchecked((nuint)num3) * (uIntPtr - uIntPtr) == 0)
					{
						dg = null;
					}
				}
			}
		}
		else
		{
			_ = (Pg2c)(object)o0E3.Default;
		}
		f5R = null;
		p9B = (p9B)(object)o0E3.Default;
		g9Z2 = g9Z2;
		_ = (k0WR)(object)o0E3.Default;
		do
		{
			f5R = f5R;
		}
		while (obj != null);
		return;
		IL_0580:
		g9Z2 = g9Z2;
		g9Z2 = g9Z2;
		checked
		{
			try
			{
				while (obj != null)
				{
					_ = (Gn76)(object)o0E3.Default;
				}
			}
			catch
			{
				try
				{
					tf = null;
				}
				finally
				{
					o0E = o0E;
					goto end_IL_05a7;
				}
				end_IL_05a7:;
			}
			finally
			{
				try
				{
					_ = (k4C9)(object)o0E3.Default;
				}
				catch
				{
					uIntPtr = default(UIntPtr);
					if (unchecked((nuint)default(UIntPtr)) + uIntPtr == 0)
					{
						_ = (f5R4)(object)o0E3.Default;
					}
					else
					{
						_ = (Zn1b)(object)o0E3.Default;
					}
				}
				goto IL_0607;
			}
		}
		IL_06d7:
		checked
		{
			if (uIntPtr == 0)
			{
				if (unchecked((nuint)default(UIntPtr)) + unchecked((nuint)default(UIntPtr)) == 0)
				{
					_ = (w0A)(object)o0E3.Default;
				}
				else
				{
					Sf06 sf = sf;
					sf = null;
					tf = tf;
				}
			}
			try
			{
				hi = hi;
				_ = (w8W)o0E3.Default;
				_ = (f5R4)(object)o0E3.Default;
				_ = (w8W)o0E3.Default;
			}
			finally
			{
				do
				{
					gn = gn;
					_ = (a9X)(object)o0E3.Default;
					Sf06 sf = null;
					_ = (k0WR)(object)o0E3.Default;
				}
				while (obj != null || (object)o0E3.Default != null);
				goto IL_0786;
			}
		}
		IL_0259:
		try
		{
			_ = (p9B)(object)o0E3.Default;
		}
		finally
		{
			try
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					x4N6 obj11 = (x4N6)(object)o0E3.Default;
					x4N = x4N;
					x4N = obj11;
				}
				else
				{
					_ = (f5R4)(object)o0E3.Default;
					o0E = o0E3.Default;
					o0E = o0E;
					Et0 et = (Et0)o0E3.Default;
					et = et;
				}
			}
			catch
			{
				try
				{
					_ = (w0A)(object)o0E3.Default;
					_ = (w1H)(object)o0E3.Default;
					w0A = (w0A)(object)o0E3.Default;
					w0A = w0A;
					p9B = p9B;
				}
				catch
				{
				}
			}
			goto IL_030a;
		}
		IL_030a:
		o0E = o0E;
		do
		{
			dg = dg;
			dg = dg;
		}
		while (obj != null);
		_003CModule_003E = (_003CModule_003E)(object)o0E3.Default;
		_ = (Hi84)(object)o0E3.Default;
		w1H = w1H;
		_ = (Pg2c)(object)o0E3.Default;
		try
		{
			while (obj != null)
			{
				while (obj != null)
				{
					p9B = null;
					_ = (_003CModule_003E)(object)o0E3.Default;
				}
			}
		}
		catch
		{
			Et0 et = default(Et0);
		}
		checked
		{
			try
			{
				if (unchecked((nuint)default(UIntPtr)) - unchecked((nuint)(UIntPtr)o0E3.Default) == 0)
				{
					if (unchecked((nuint)default(UIntPtr)) - unchecked((nuint)default(UIntPtr)) == 0)
					{
						w0A = w0A;
					}
					else
					{
						_ = (k0WR)(object)o0E3.Default;
					}
				}
			}
			finally
			{
				_ = (Dg19)(object)o0E3.Default;
				goto IL_03e9;
			}
		}
		IL_0486:
		_003CModule_003E = _003CModule_003E;
		w1H = (w1H)(object)o0E3.Default;
		_ = (Dg19)(object)o0E3.Default;
		_ = (p9B)(object)o0E3.Default;
		_ = (w0A)(object)o0E3.Default;
		checked
		{
			if (unchecked((nuint)(UIntPtr)o0E3.Default) * (uIntPtr * (unchecked(uIntPtr / uIntPtr) * unchecked((nuint)(UIntPtr)o0E3.Default))) == 0)
			{
				f5R = f5R;
			}
			p9B = p9B;
			do
			{
				try
				{
					gn = gn;
				}
				finally
				{
					_ = (x4N6)(object)o0E3.Default;
					_ = (x4N6)(object)o0E3.Default;
					continue;
				}
			}
			while (obj != null || obj != null);
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				do
				{
					try
					{
						_ = (_003CModule_003E)(object)o0E3.Default;
					}
					finally
					{
						_ = (k4C9)(object)o0E3.Default;
						continue;
					}
				}
				while (obj != null);
			}
			if (uIntPtr == 0)
			{
				try
				{
					while (obj != null)
					{
						_ = (x4N6)(object)o0E3.Default;
					}
				}
				finally
				{
					_ = (w8W)o0E3.Default;
					goto IL_0580;
				}
			}
			goto IL_0580;
		}
		IL_0645:
		try
		{
			try
			{
				_ = (f5R4)(object)o0E3.Default;
				_ = (Zn1b)(object)o0E3.Default;
			}
			catch
			{
				tf = (Tf67)(object)o0E3.Default;
				_ = (i5NX)(object)o0E3.Default;
			}
		}
		catch
		{
			try
			{
				_ = (_003CModule_003E)(object)o0E3.Default;
			}
			finally
			{
				gn = null;
				goto end_IL_067e;
			}
			end_IL_067e:;
		}
		finally
		{
			try
			{
				try
				{
					a9X = a9X;
				}
				finally
				{
					_ = (Hi84)(object)o0E3.Default;
					goto end_IL_0698;
				}
				end_IL_0698:;
			}
			finally
			{
				if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
				{
					_ = (w8W)o0E3.Default;
				}
				else
				{
					pg2c = pg2c;
				}
				goto IL_06d7;
			}
		}
	}
}
