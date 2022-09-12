using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Ds3;
using Kc9;
using Microsoft.VisualBasic.CompilerServices;
using Sd9;
using Yn19;
using Yn6o;
using k3R;

namespace Cr4;

[DesignerGenerated]
public class Sd5 : Form
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
			EventHandler eventHandler = g0E;
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
			EventHandler eventHandler = o4F;
			Label label = _Label7;
			Label obj = label;
			o1W.char_0[126] = (char)(o1W.char_0[126] & s5C.int_0[469] & 'ñ');
			if (obj != null)
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

	[field: AccessedThroughProperty("txtPMachine")]
	internal virtual TextBox txtPMachine
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
			EventHandler eventHandler = Lo3;
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
			char[] char_ = o1W.char_0;
			int num = 7;
			while (true)
			{
				EventHandler eventHandler = o5E;
				while (true)
				{
					IL_0064:
					Button val = _btnModify;
					if (val == null)
					{
						num = 0;
						goto IL_004d;
					}
					num = 5;
					goto IL_0046;
					IL_004d:
					while (true)
					{
						_btnModify = value;
						val = _btnModify;
						if (val == null)
						{
							switch (char_[397])
							{
							case '衿':
								break;
							case '衺':
								continue;
							case '衼':
								goto IL_0064;
							default:
								goto end_IL_0064;
							case '衽':
							case '衾':
								goto IL_0081;
							case '衻':
							case '袀':
								return;
							}
							break;
						}
						num = 3;
						goto IL_0081;
						IL_0081:
						((Control)val).add_Click(eventHandler);
						return;
					}
					goto IL_0046;
					IL_0046:
					((Control)val).remove_Click(eventHandler);
					goto IL_004d;
					continue;
					end_IL_0064:
					break;
				}
			}
		}
	}

	[field: AccessedThroughProperty("DataGridView1")]
	internal virtual DataGridView DataGridView1
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

	[field: AccessedThroughProperty("txtPStock")]
	internal virtual TextBox txtPStock
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtPCost")]
	internal virtual TextBox txtPCost
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

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
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

	[field: AccessedThroughProperty("txtPid")]
	internal virtual TextBox txtPid
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
			EventHandler eventHandler = Dk6;
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
				s5C.int_0[238] = s5C.int_0[238] & s5C.int_0[224] & 0xE7;
			}
		}
	}

	public Sd5()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)m8D);
		cs = "Data Source=DESKTOP-1L8UME0\\SQLEXPRESS;Initial Catalog=db_fabric;Integrated Security=True";
		cn = new SqlConnection(cs);
		cmd = new SqlCommand();
		Gc7();
	}

	[DebuggerNonUserCode]
	protected override void Cp2(bool Ja4)
	{
		try
		{
			if (Ja4 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Ja4);
		}
		o1W.char_0[278] = (char)((o1W.char_0[278] ^ o1W.char_0[543]) & 'r');
	}

	[DebuggerStepThrough]
	private void Gc7()
	{
		//IL_0452: Unknown result type (might be due to invalid IL or missing references)
		//IL_045c: Expected O, but got Unknown
		//IL_050c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0516: Expected O, but got Unknown
		//IL_05da: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e4: Expected O, but got Unknown
		//IL_05ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f4: Expected O, but got Unknown
		//IL_05f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ff: Expected O, but got Unknown
		//IL_0610: Unknown result type (might be due to invalid IL or missing references)
		//IL_061a: Expected O, but got Unknown
		//IL_061b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0625: Expected O, but got Unknown
		//IL_0626: Unknown result type (might be due to invalid IL or missing references)
		//IL_0630: Expected O, but got Unknown
		//IL_0636: Unknown result type (might be due to invalid IL or missing references)
		//IL_0640: Expected O, but got Unknown
		//IL_0641: Unknown result type (might be due to invalid IL or missing references)
		//IL_064b: Expected O, but got Unknown
		//IL_064c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0656: Expected O, but got Unknown
		//IL_065c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0666: Expected O, but got Unknown
		//IL_0667: Unknown result type (might be due to invalid IL or missing references)
		//IL_0671: Expected O, but got Unknown
		//IL_0672: Unknown result type (might be due to invalid IL or missing references)
		//IL_067c: Expected O, but got Unknown
		//IL_0682: Unknown result type (might be due to invalid IL or missing references)
		//IL_068c: Expected O, but got Unknown
		//IL_068d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0697: Expected O, but got Unknown
		//IL_0698: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a2: Expected O, but got Unknown
		//IL_06a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b2: Expected O, but got Unknown
		//IL_06b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bd: Expected O, but got Unknown
		//IL_06be: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c8: Expected O, but got Unknown
		int[] int_ = s5C.int_0;
		int num = 36;
		while (true)
		{
			Label3 = new Label();
			Label6 = new Label();
			Label7 = new Label();
			num = 1;
			while (true)
			{
				txtPMachine = new TextBox();
				Label9 = new Label();
				btnDelete = new Button();
				num = 49;
				while (true)
				{
					btnModify = new Button();
					DataGridView1 = new DataGridView();
					txtWeight = new TextBox();
					num = 40;
					while (true)
					{
						txtPStock = new TextBox();
						txtPCost = new TextBox();
						Label4 = new Label();
						num = 26;
						while (true)
						{
							Label1 = new Label();
							Label2 = new Label();
							Label5 = new Label();
							num = 63;
							while (true)
							{
								txtPid = new TextBox();
								btnSave = new Button();
								((ISupportInitialize)DataGridView1).BeginInit();
								num = 27;
								while (true)
								{
									((Control)this).SuspendLayout();
									Label3.set_AutoSize(true);
									((Control)Label3).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
									num = 65;
									while (true)
									{
										((Control)Label3).set_ForeColor(Color.White);
										while (true)
										{
											((Control)Label3).set_Location(new Point(332, 21));
											num = 24;
											while (true)
											{
												((Control)Label3).set_Name("Label3");
												((Control)Label3).set_Size(new Size(111, 17));
												num = 13;
												while (true)
												{
													((Control)Label3).set_TabIndex(9);
													Label3.set_Text("Product Detail");
													num = 28;
													while (true)
													{
														Label6.set_AutoSize(true);
														((Control)Label6).set_BackColor(Color.Blue);
														num = 31;
														while (true)
														{
															((Control)Label6).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
															num = 67;
															while (true)
															{
																((Control)Label6).set_ForeColor(Color.White);
																((Control)Label6).set_Location(new Point(739, 21));
																num = 21;
																while (true)
																{
																	((Control)Label6).set_Name("Label6");
																	((Control)Label6).set_Size(new Size(18, 17));
																	num = 62;
																	while (true)
																	{
																		((Control)Label6).set_TabIndex(14);
																		Label6.set_Text("X");
																		num = 68;
																		while (true)
																		{
																			Label7.set_AutoSize(true);
																			((Control)Label7).set_BackColor(Color.Blue);
																			num = 14;
																			while (true)
																			{
																				((Control)Label7).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
																				num = 48;
																				while (true)
																				{
																					((Control)Label7).set_ForeColor(Color.White);
																					((Control)Label7).set_Location(new Point(47, 21));
																					num = 56;
																					while (true)
																					{
																						((Control)Label7).set_Name("Label7");
																						((Control)Label7).set_Size(new Size(92, 17));
																						num = 58;
																						while (true)
																						{
																							((Control)Label7).set_TabIndex(13);
																							Label7.set_Text("Go To Main");
																							num = 51;
																							while (true)
																							{
																								((Control)txtPMachine).set_Location(new Point(413, 99));
																								((Control)txtPMachine).set_Name("txtPMachine");
																								num = 9;
																								while (true)
																								{
																									((Control)txtPMachine).set_Size(new Size(122, 20));
																									((Control)txtPMachine).set_TabIndex(4);
																									num = 43;
																									while (true)
																									{
																										Label9.set_AutoSize(true);
																										((Control)Label9).set_ForeColor(Color.White);
																										num = 44;
																										while (true)
																										{
																											((Control)Label9).set_Location(new Point(299, 99));
																											((Control)Label9).set_Name("Label9");
																											num = 22;
																											while (true)
																											{
																												((Control)Label9).set_Size(new Size(108, 13));
																												((Control)Label9).set_TabIndex(46);
																												num = 59;
																												while (true)
																												{
																													Label9.set_Text("Production Machine :");
																													((Control)btnDelete).set_Location(new Point(398, 218));
																													num = 17;
																													while (true)
																													{
																														((Control)btnDelete).set_Name("btnDelete");
																														((Control)btnDelete).set_Size(new Size(75, 23));
																														num = 73;
																														while (true)
																														{
																															((Control)btnDelete).set_TabIndex(7);
																															((ButtonBase)btnDelete).set_Text("DELETE");
																															num = 66;
																															while (true)
																															{
																																((ButtonBase)btnDelete).set_UseVisualStyleBackColor(true);
																																((Control)btnModify).set_Location(new Point(286, 218));
																																num = 4;
																																while (true)
																																{
																																	((Control)btnModify).set_Name("btnModify");
																																	((Control)btnModify).set_Size(new Size(75, 23));
																																	num = 5;
																																	while (true)
																																	{
																																		((Control)btnModify).set_TabIndex(6);
																																		((ButtonBase)btnModify).set_Text("MODIFY");
																																		num = 75;
																																		while (true)
																																		{
																																			((ButtonBase)btnModify).set_UseVisualStyleBackColor(true);
																																			DataGridView1.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
																																			num = 55;
																																			while (true)
																																			{
																																				((Control)DataGridView1).set_Location(new Point(50, 255));
																																				((Control)DataGridView1).set_Name("DataGridView1");
																																				num = 37;
																																				while (true)
																																				{
																																					((Control)DataGridView1).set_Size(new Size(599, 183));
																																					((Control)DataGridView1).set_TabIndex(41);
																																					num = 61;
																																					while (true)
																																					{
																																						((Control)txtWeight).set_Location(new Point(413, 53));
																																						((Control)txtWeight).set_Name("txtWeight");
																																						num = 46;
																																						while (true)
																																						{
																																							((Control)txtWeight).set_Size(new Size(122, 20));
																																							((Control)txtWeight).set_TabIndex(3);
																																							switch (int_[298])
																																							{
																																							case 21196:
																																								break;
																																							case 21211:
																																								goto end_IL_000e;
																																							case 21187:
																																								goto end_IL_0177;
																																							case 21205:
																																								goto end_IL_01a6;
																																							case 21225:
																																								goto end_IL_01d2;
																																							case 21155:
																																								goto end_IL_01fe;
																																							case 21154:
																																								goto end_IL_021b;
																																							case 21216:
																																								goto end_IL_023c;
																																							case 21223:
																																								goto end_IL_0264;
																																							case 21167:
																																								goto end_IL_028e;
																																							case 21209:
																																								goto end_IL_02af;
																																							case 21172:
																																								goto end_IL_02d8;
																																							case 21194:
																																								goto end_IL_0307;
																																							case 21193:
																																								goto end_IL_032d;
																																							case 21159:
																																								goto end_IL_0359;
																																							case 21201:
																																								goto end_IL_037a;
																																							case 21208:
																																								goto end_IL_039f;
																																							case 21206:
																																								goto end_IL_03cb;
																																							case 21198:
																																								goto end_IL_03ed;
																																							case 21164:
																																								goto end_IL_0416;
																																							case 21218:
																																								goto end_IL_043f;
																																							case 21212:
																																								goto end_IL_0461;
																																							case 21171:
																																								goto end_IL_0482;
																																							case 21217:
																																								goto end_IL_04a4;
																																							case 21181:
																																								goto end_IL_04cd;
																																							case 21178:
																																								goto end_IL_04f9;
																																							case 21163:
																																								goto end_IL_051b;
																																							case 21174:
																																								goto end_IL_053c;
																																							case 21221:
																																								goto end_IL_055e;
																																							case 21215:
																																								goto end_IL_0587;
																																							case 21177:
																																								goto end_IL_05a3;
																																							case 21213:
																																								goto end_IL_05b5;
																																							case 21176:
																																								goto end_IL_05e9;
																																							case 21190:
																																								goto end_IL_060f;
																																							case 21199:
																																								goto end_IL_0635;
																																							case 21151:
																																								goto end_IL_065b;
																																							default:
																																								goto end_IL_0681;
																																							case 21220:
																																								((Control)txtPStock).set_Location(new Point(191, 134));
																																								((Control)txtPStock).set_Name("txtPStock");
																																								num = 38;
																																								goto case 21188;
																																							case 21188:
																																								((Control)txtPStock).set_Size(new Size(100, 20));
																																								goto case 21184;
																																							case 21184:
																																								((Control)txtPStock).set_TabIndex(2);
																																								num = 64;
																																								goto case 21214;
																																							case 21214:
																																								((Control)txtPCost).set_Location(new Point(191, 95));
																																								((Control)txtPCost).set_Name("txtPCost");
																																								num = 29;
																																								goto case 21179;
																																							case 21179:
																																								((Control)txtPCost).set_Size(new Size(100, 20));
																																								((Control)txtPCost).set_TabIndex(1);
																																								num = 11;
																																								goto case 21161;
																																							case 21161:
																																								Label4.set_AutoSize(true);
																																								((Control)Label4).set_ForeColor(Color.White);
																																								num = 32;
																																								goto case 21182;
																																							case 21182:
																																								((Control)Label4).set_Location(new Point(360, 56));
																																								((Control)Label4).set_Name("Label4");
																																								num = 16;
																																								goto case 21166;
																																							case 21166:
																																								((Control)Label4).set_Size(new Size(47, 13));
																																								((Control)Label4).set_TabIndex(37);
																																								num = 72;
																																								goto case 21222;
																																							case 21222:
																																								Label4.set_Text("Weight :");
																																								Label1.set_AutoSize(true);
																																								num = 30;
																																								goto case 21180;
																																							case 21180:
																																								((Control)Label1).set_ForeColor(Color.White);
																																								((Control)Label1).set_Location(new Point(120, 141));
																																								num = 52;
																																								goto case 21202;
																																							case 21202:
																																								((Control)Label1).set_Name("Label1");
																																								((Control)Label1).set_Size(new Size(41, 13));
																																								num = 2;
																																								goto case 21152;
																																							case 21152:
																																								((Control)Label1).set_TabIndex(36);
																																								Label1.set_Text("Stock :");
																																								num = 8;
																																								goto case 21158;
																																							case 21158:
																																								Label2.set_AutoSize(true);
																																								((Control)Label2).set_ForeColor(Color.White);
																																								num = 23;
																																								goto case 21173;
																																							case 21173:
																																								((Control)Label2).set_Location(new Point(99, 59));
																																								((Control)Label2).set_Name("Label2");
																																								num = 18;
																																								goto case 21168;
																																							case 21168:
																																								((Control)Label2).set_Size(new Size(62, 13));
																																								((Control)Label2).set_TabIndex(35);
																																								num = 41;
																																								goto case 21191;
																																							case 21191:
																																								Label2.set_Text("Product Id :");
																																								Label5.set_AutoSize(true);
																																								num = 53;
																																								goto case 21203;
																																							case 21203:
																																								((Control)Label5).set_ForeColor(Color.White);
																																								((Control)Label5).set_Location(new Point(127, 102));
																																								num = 6;
																																								goto case 21156;
																																							case 21156:
																																								((Control)Label5).set_Name("Label5");
																																								((Control)Label5).set_Size(new Size(34, 13));
																																								num = 7;
																																								goto case 21157;
																																							case 21157:
																																								((Control)Label5).set_TabIndex(34);
																																								Label5.set_Text("Cost :");
																																								num = 35;
																																								goto case 21185;
																																							case 21185:
																																								((Control)txtPid).set_Location(new Point(191, 56));
																																								((Control)txtPid).set_Name("txtPid");
																																								num = 20;
																																								goto case 21170;
																																							case 21170:
																																								((Control)txtPid).set_Size(new Size(100, 20));
																																								((Control)txtPid).set_TabIndex(0);
																																								num = 74;
																																								goto case 21224;
																																							case 21224:
																																								((Control)btnSave).set_Location(new Point(178, 218));
																																								((Control)btnSave).set_Name("btnSave");
																																								num = 54;
																																								goto case 21204;
																																							case 21204:
																																								((Control)btnSave).set_Size(new Size(75, 23));
																																								((Control)btnSave).set_TabIndex(5);
																																								num = 25;
																																								goto case 21175;
																																							case 21175:
																																								((ButtonBase)btnSave).set_Text("SAVE");
																																								((ButtonBase)btnSave).set_UseVisualStyleBackColor(true);
																																								num = 45;
																																								goto case 21195;
																																							case 21195:
																																								((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
																																								((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
																																								num = 10;
																																								goto case 21160;
																																							case 21160:
																																								((Form)this).set_BackColor(Color.FromArgb(0, 0, 64));
																																								((Form)this).set_ClientSize(new Size(800, 450));
																																								num = 42;
																																								goto case 21192;
																																							case 21192:
																																								((Control)this).get_Controls().Add((Control)(object)txtPMachine);
																																								((Control)this).get_Controls().Add((Control)(object)Label9);
																																								num = 3;
																																								goto case 21153;
																																							case 21153:
																																								((Control)this).get_Controls().Add((Control)(object)btnDelete);
																																								((Control)this).get_Controls().Add((Control)(object)btnModify);
																																								num = 19;
																																								goto case 21169;
																																							case 21169:
																																								((Control)this).get_Controls().Add((Control)(object)DataGridView1);
																																								((Control)this).get_Controls().Add((Control)(object)txtWeight);
																																								num = 69;
																																								goto case 21219;
																																							case 21219:
																																								((Control)this).get_Controls().Add((Control)(object)txtPStock);
																																								((Control)this).get_Controls().Add((Control)(object)txtPCost);
																																								num = 60;
																																								goto case 21210;
																																							case 21210:
																																								((Control)this).get_Controls().Add((Control)(object)Label4);
																																								((Control)this).get_Controls().Add((Control)(object)Label1);
																																								num = 12;
																																								goto case 21150;
																																							case 21150:
																																							case 21162:
																																								((Control)this).get_Controls().Add((Control)(object)Label2);
																																								((Control)this).get_Controls().Add((Control)(object)Label5);
																																								num = 15;
																																								goto case 21165;
																																							case 21165:
																																								((Control)this).get_Controls().Add((Control)(object)txtPid);
																																								((Control)this).get_Controls().Add((Control)(object)btnSave);
																																								num = 57;
																																								goto case 21207;
																																							case 21207:
																																								((Control)this).get_Controls().Add((Control)(object)Label6);
																																								((Control)this).get_Controls().Add((Control)(object)Label7);
																																								num = 47;
																																								goto case 21197;
																																							case 21197:
																																								((Control)this).get_Controls().Add((Control)(object)Label3);
																																								((Form)this).set_FormBorderStyle((FormBorderStyle)0);
																																								num = 39;
																																								goto case 21189;
																																							case 21189:
																																								((Control)this).set_Name("frmProductDetail");
																																								((Form)this).set_StartPosition((FormStartPosition)1);
																																								((Form)this).set_Text("frmProductDetail");
																																								num = 50;
																																								goto case 21200;
																																							case 21200:
																																								((ISupportInitialize)DataGridView1).EndInit();
																																								((Control)this).ResumeLayout(false);
																																								((Control)this).PerformLayout();
																																								num = 33;
																																								return;
																																							case 21183:
																																								return;
																																							}
																																							continue;
																																							end_IL_000e:
																																							break;
																																						}
																																						continue;
																																						end_IL_0177:
																																						break;
																																					}
																																					continue;
																																					end_IL_01a6:
																																					break;
																																				}
																																				continue;
																																				end_IL_01d2:
																																				break;
																																			}
																																			continue;
																																			end_IL_01fe:
																																			break;
																																		}
																																		continue;
																																		end_IL_021b:
																																		break;
																																	}
																																	continue;
																																	end_IL_023c:
																																	break;
																																}
																																continue;
																																end_IL_0264:
																																break;
																															}
																															continue;
																															end_IL_028e:
																															break;
																														}
																														continue;
																														end_IL_02af:
																														break;
																													}
																													continue;
																													end_IL_02d8:
																													break;
																												}
																												continue;
																												end_IL_0307:
																												break;
																											}
																											continue;
																											end_IL_032d:
																											break;
																										}
																										continue;
																										end_IL_0359:
																										break;
																									}
																									continue;
																									end_IL_037a:
																									break;
																								}
																								continue;
																								end_IL_039f:
																								break;
																							}
																							continue;
																							end_IL_03cb:
																							break;
																						}
																						continue;
																						end_IL_03ed:
																						break;
																					}
																					continue;
																					end_IL_0416:
																					break;
																				}
																				continue;
																				end_IL_043f:
																				break;
																			}
																			continue;
																			end_IL_0461:
																			break;
																		}
																		continue;
																		end_IL_0482:
																		break;
																	}
																	continue;
																	end_IL_04a4:
																	break;
																}
																continue;
																end_IL_04cd:
																break;
															}
															continue;
															end_IL_04f9:
															break;
														}
														continue;
														end_IL_051b:
														break;
													}
													continue;
													end_IL_053c:
													break;
												}
												continue;
												end_IL_055e:
												break;
											}
											continue;
											end_IL_0587:
											break;
										}
										continue;
										end_IL_05a3:
										break;
									}
									continue;
									end_IL_05b5:
									break;
								}
								continue;
								end_IL_05e9:
								break;
							}
							continue;
							end_IL_060f:
							break;
						}
						continue;
						end_IL_0635:
						break;
					}
					continue;
					end_IL_065b:
					break;
				}
				continue;
				end_IL_0681:
				break;
			}
		}
	}

	private void o4F(object sender, EventArgs e)
	{
		c7G c7G = new c7G();
		((Control)c7G).Show();
		((Control)this).Hide();
	}

	private void g0E(object sender, EventArgs e)
	{
		((Component)this).Dispose();
	}

	private void Dk6(object sender, EventArgs e)
	{
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("insert into tbl_product_detail values(" + Conversions.ToString(Conversions.ToInteger(txtPid.get_Text())) + "," + Conversions.ToString(Conversions.ToInteger(txtPCost.get_Text())) + ",'" + txtPStock.get_Text() + "','" + txtWeight.get_Text() + "','" + txtPMachine.get_Text() + "')");
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
		r5A();
		o1W.char_0[434] = (char)((o1W.char_0[434] ^ o1W.char_0[20]) & 'ï');
	}

	public void r5A()
	{
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		DataGridView1.get_Rows().Clear();
		DataGridView1.get_Columns().Clear();
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("select * from tbl_product_detail");
			rd = cmd.ExecuteReader();
			DataGridView1.get_Columns().Add("c1", "Product Id");
			DataGridView1.get_Columns().Add("c2", "Product Cost");
			DataGridView1.get_Columns().Add("c3", "Product Stock");
			DataGridView1.get_Columns().Add("c4", "Product Weight");
			DataGridView1.get_Columns().Add("c5", "Production Machine");
			while (rd.Read())
			{
				DataGridView1.get_Rows().Add(new object[5]
				{
					rd.get_Item("pid").ToString(),
					rd.get_Item("pcost").ToString(),
					rd.get_Item("pstock"),
					rd.get_Item("stockweight"),
					rd.get_Item("productionmachine")
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

	internal static byte[] e5J(byte[] c6E, byte[] z1N, int Qt5, int k4W)
	{
		int num = checked(c6E.Length - 1);
		for (int i = 0; i <= num; i = checked(i + 1))
		{
			c6E[i] = (byte)(c6E[i] ^ checked((byte)(z1N[unchecked(i % z1N.Length)] ^ ((i + unchecked(Qt5 % z1N.Length)) & Qt5))));
		}
		return c6E;
	}

	private void Lo3(object sender, EventArgs e)
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("delete from tbl_product_detail where pid=" + Conversions.ToString(Conversions.ToInteger(txtPid.get_Text())));
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
		r5A();
	}

	private void o5E(object sender, EventArgs e)
	{
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("update tbl_product_detail set pcost = " + Conversions.ToString(Conversions.ToInteger(txtPCost.get_Text())) + ",pstock=" + txtPStock.get_Text() + ",stockweight='" + txtWeight.get_Text() + "',productionmachine='" + txtPMachine.get_Text() + "' where pid=" + Conversions.ToString(Conversions.ToInteger(txtPid.get_Text())));
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
		r5A();
	}

	private void m8D(object sender, EventArgs e)
	{
		r5A();
	}

	internal static string[] Wb7()
	{
		Ty3.Na6();
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		k2GS.mDic.Add("AO", executingAssembly);
		return q1J3.z0FP();
	}
}
