using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Xs5;
using e6H;
using q8B;

namespace Wa6;

[DesignerGenerated]
public class Ws0 : Form
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
			EventHandler eventHandler = Wj2;
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
			EventHandler eventHandler = g1B;
			Label label = _Label7;
			Label obj = label;
			c0B.int_0[106] = (c0B.int_0[106] ^ c0B.int_0[605]) & 0x36;
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
			EventHandler eventHandler = Sr9;
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
			EventHandler eventHandler = k2P;
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

	[field: AccessedThroughProperty("txtPId")]
	internal virtual TextBox txtPId
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtGWeight")]
	internal virtual TextBox txtGWeight
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

	[field: AccessedThroughProperty("txtFGood")]
	internal virtual TextBox txtFGood
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
			EventHandler eventHandler = Sb0;
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

	[field: AccessedThroughProperty("Label8")]
	internal virtual Label Label8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtFinishGoodCode")]
	internal virtual TextBox txtFinishGoodCode
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public Ws0()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)n8B);
		cs = "Data Source=DESKTOP-1L8UME0\\SQLEXPRESS;Initial Catalog=db_fabric;Integrated Security=True";
		cn = new SqlConnection(cs);
		cmd = new SqlCommand();
		r9C();
	}

	[DebuggerNonUserCode]
	protected override void o3J(bool Rg7)
	{
		try
		{
			if (Rg7 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Rg7);
		}
	}

	[DebuggerStepThrough]
	private void r9C()
	{
		//IL_07ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b7: Expected O, but got Unknown
		//IL_0867: Unknown result type (might be due to invalid IL or missing references)
		//IL_0871: Expected O, but got Unknown
		//IL_0933: Unknown result type (might be due to invalid IL or missing references)
		//IL_093d: Expected O, but got Unknown
		//IL_0942: Unknown result type (might be due to invalid IL or missing references)
		//IL_094c: Expected O, but got Unknown
		//IL_094d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0957: Expected O, but got Unknown
		//IL_0968: Unknown result type (might be due to invalid IL or missing references)
		//IL_0972: Expected O, but got Unknown
		//IL_0973: Unknown result type (might be due to invalid IL or missing references)
		//IL_097d: Expected O, but got Unknown
		//IL_097e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0988: Expected O, but got Unknown
		//IL_098e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0998: Expected O, but got Unknown
		//IL_0999: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a3: Expected O, but got Unknown
		//IL_09a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ae: Expected O, but got Unknown
		//IL_09b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_09be: Expected O, but got Unknown
		//IL_09bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c9: Expected O, but got Unknown
		//IL_09ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d4: Expected O, but got Unknown
		//IL_09da: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e4: Expected O, but got Unknown
		//IL_09e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ef: Expected O, but got Unknown
		//IL_09f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_09fa: Expected O, but got Unknown
		//IL_0a00: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a0a: Expected O, but got Unknown
		//IL_0a0b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a15: Expected O, but got Unknown
		//IL_0a16: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a20: Expected O, but got Unknown
		int[] int_ = c0B.int_0;
		int num = 12;
		while (true)
		{
			Label3 = new Label();
			Label6 = new Label();
			Label7 = new Label();
			num = 55;
			while (true)
			{
				btnDelete = new Button();
				btnModify = new Button();
				DataGridView1 = new DataGridView();
				num = 51;
				while (true)
				{
					txtPId = new TextBox();
					txtGWeight = new TextBox();
					txtPCost = new TextBox();
					num = 40;
					while (true)
					{
						Label4 = new Label();
						Label1 = new Label();
						Label2 = new Label();
						num = 62;
						while (true)
						{
							Label5 = new Label();
							txtFGood = new TextBox();
							btnSave = new Button();
							num = 75;
							while (true)
							{
								Label8 = new Label();
								txtFinishGoodCode = new TextBox();
								((ISupportInitialize)DataGridView1).BeginInit();
								num = 47;
								while (true)
								{
									((Control)this).SuspendLayout();
									Label3.set_AutoSize(true);
									((Control)Label3).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
									num = 8;
									while (true)
									{
										((Control)Label3).set_ForeColor(Color.White);
										((Control)Label3).set_Location(new Point(326, 21));
										num = 27;
										while (true)
										{
											((Control)Label3).set_Name("Label3");
											((Control)Label3).set_Size(new Size(125, 17));
											num = 36;
											while (true)
											{
												((Control)Label3).set_TabIndex(9);
												Label3.set_Text("Processing Cost");
												num = 30;
												while (true)
												{
													Label6.set_AutoSize(true);
													((Control)Label6).set_BackColor(Color.Blue);
													num = 34;
													while (true)
													{
														((Control)Label6).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
														num = 11;
														while (true)
														{
															((Control)Label6).set_ForeColor(Color.White);
															((Control)Label6).set_Location(new Point(735, 21));
															num = 53;
															while (true)
															{
																((Control)Label6).set_Name("Label6");
																((Control)Label6).set_Size(new Size(18, 17));
																num = 65;
																while (true)
																{
																	((Control)Label6).set_TabIndex(14);
																	Label6.set_Text("X");
																	num = 49;
																	while (true)
																	{
																		Label7.set_AutoSize(true);
																		((Control)Label7).set_BackColor(Color.Blue);
																		num = 56;
																		while (true)
																		{
																			((Control)Label7).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
																			num = 16;
																			while (true)
																			{
																				((Control)Label7).set_ForeColor(Color.White);
																				((Control)Label7).set_Location(new Point(43, 21));
																				num = 52;
																				while (true)
																				{
																					((Control)Label7).set_Name("Label7");
																					((Control)Label7).set_Size(new Size(92, 17));
																					num = 67;
																					while (true)
																					{
																						((Control)Label7).set_TabIndex(13);
																						Label7.set_Text("Go To Main");
																						num = 26;
																						while (true)
																						{
																							((Control)btnDelete).set_Location(new Point(404, 183));
																							((Control)btnDelete).set_Name("btnDelete");
																							num = 72;
																							while (true)
																							{
																								((Control)btnDelete).set_Size(new Size(75, 31));
																								((Control)btnDelete).set_TabIndex(7);
																								num = 17;
																								while (true)
																								{
																									((ButtonBase)btnDelete).set_Text("DELETE");
																									((ButtonBase)btnDelete).set_UseVisualStyleBackColor(true);
																									num = 45;
																									while (true)
																									{
																										((Control)btnModify).set_Location(new Point(404, 132));
																										((Control)btnModify).set_Name("btnModify");
																										num = 66;
																										while (true)
																										{
																											((Control)btnModify).set_Size(new Size(75, 31));
																											((Control)btnModify).set_TabIndex(6);
																											num = 10;
																											while (true)
																											{
																												((ButtonBase)btnModify).set_Text("MODIFY");
																												((ButtonBase)btnModify).set_UseVisualStyleBackColor(true);
																												num = 46;
																												while (true)
																												{
																													DataGridView1.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
																													((Control)DataGridView1).set_Location(new Point(87, 232));
																													num = 2;
																													while (true)
																													{
																														((Control)DataGridView1).set_Name("DataGridView1");
																														while (true)
																														{
																															((Control)DataGridView1).set_Size(new Size(599, 206));
																															num = 69;
																															while (true)
																															{
																																((Control)DataGridView1).set_TabIndex(25);
																																((Control)txtPId).set_Location(new Point(229, 195));
																																num = 0;
																																while (true)
																																{
																																	((Control)txtPId).set_Name("txtPId");
																																	((Control)txtPId).set_Size(new Size(100, 20));
																																	num = 35;
																																	while (true)
																																	{
																																		((Control)txtPId).set_TabIndex(4);
																																		((Control)txtGWeight).set_Location(new Point(229, 162));
																																		num = 14;
																																		while (true)
																																		{
																																			((Control)txtGWeight).set_Name("txtGWeight");
																																			((Control)txtGWeight).set_Size(new Size(100, 20));
																																			num = 19;
																																			while (true)
																																			{
																																				((Control)txtGWeight).set_TabIndex(3);
																																				((Control)txtPCost).set_Location(new Point(229, 135));
																																				num = 32;
																																				while (true)
																																				{
																																					((Control)txtPCost).set_Name("txtPCost");
																																					((Control)txtPCost).set_Size(new Size(100, 20));
																																					num = 39;
																																					while (true)
																																					{
																																						((Control)txtPCost).set_TabIndex(2);
																																						Label4.set_AutoSize(true);
																																						num = 57;
																																						while (true)
																																						{
																																							((Control)Label4).set_ForeColor(Color.White);
																																							((Control)Label4).set_Location(new Point(108, 169));
																																							num = 18;
																																							while (true)
																																							{
																																								((Control)Label4).set_Name("Label4");
																																								((Control)Label4).set_Size(new Size(106, 13));
																																								num = 4;
																																								while (true)
																																								{
																																									((Control)Label4).set_TabIndex(21);
																																									Label4.set_Text("Finish Good Weight :");
																																									num = 3;
																																									while (true)
																																									{
																																										Label1.set_AutoSize(true);
																																										((Control)Label1).set_ForeColor(Color.White);
																																										num = 50;
																																										while (true)
																																										{
																																											((Control)Label1).set_Location(new Point(104, 108));
																																											((Control)Label1).set_Name("Label1");
																																											num = 59;
																																											while (true)
																																											{
																																												((Control)Label1).set_Size(new Size(110, 13));
																																												((Control)Label1).set_TabIndex(20);
																																												num = 70;
																																												while (true)
																																												{
																																													Label1.set_Text("Finish Process Good :");
																																													Label2.set_AutoSize(true);
																																													num = 41;
																																													while (true)
																																													{
																																														((Control)Label2).set_ForeColor(Color.White);
																																														((Control)Label2).set_Location(new Point(151, 202));
																																														num = 48;
																																														while (true)
																																														{
																																															((Control)Label2).set_Name("Label2");
																																															((Control)Label2).set_Size(new Size(63, 13));
																																															num = 1;
																																															while (true)
																																															{
																																																((Control)Label2).set_TabIndex(19);
																																																Label2.set_Text("Process Id :");
																																																num = 23;
																																																while (true)
																																																{
																																																	Label5.set_AutoSize(true);
																																																	((Control)Label5).set_ForeColor(Color.White);
																																																	num = 61;
																																																	while (true)
																																																	{
																																																		((Control)Label5).set_Location(new Point(139, 138));
																																																		((Control)Label5).set_Name("Label5");
																																																		num = 58;
																																																		while (true)
																																																		{
																																																			((Control)Label5).set_Size(new Size(75, 13));
																																																			((Control)Label5).set_TabIndex(18);
																																																			num = 73;
																																																			while (true)
																																																			{
																																																				Label5.set_Text("Process Cost :");
																																																				((Control)txtFGood).set_Location(new Point(229, 105));
																																																				num = 21;
																																																				while (true)
																																																				{
																																																					((Control)txtFGood).set_Name("txtFGood");
																																																					((Control)txtFGood).set_Size(new Size(100, 20));
																																																					num = 28;
																																																					while (true)
																																																					{
																																																						((Control)txtFGood).set_TabIndex(1);
																																																						((Control)btnSave).set_Location(new Point(404, 72));
																																																						num = 22;
																																																						while (true)
																																																						{
																																																							((Control)btnSave).set_Name("btnSave");
																																																							((Control)btnSave).set_Size(new Size(75, 31));
																																																							num = 68;
																																																							while (true)
																																																							{
																																																								((Control)btnSave).set_TabIndex(5);
																																																								((ButtonBase)btnSave).set_Text("SAVE");
																																																								num = 63;
																																																								while (true)
																																																								{
																																																									((ButtonBase)btnSave).set_UseVisualStyleBackColor(true);
																																																									Label8.set_AutoSize(true);
																																																									num = 74;
																																																									while (true)
																																																									{
																																																										((Control)Label8).set_ForeColor(Color.White);
																																																										((Control)Label8).set_Location(new Point(117, 75));
																																																										num = 9;
																																																										while (true)
																																																										{
																																																											((Control)Label8).set_Name("Label8");
																																																											((Control)Label8).set_Size(new Size(97, 13));
																																																											num = 42;
																																																											while (true)
																																																											{
																																																												((Control)Label8).set_TabIndex(29);
																																																												Label8.set_Text("Finish Good Code :");
																																																												num = 60;
																																																												while (true)
																																																												{
																																																													((Control)txtFinishGoodCode).set_Location(new Point(229, 72));
																																																													((Control)txtFinishGoodCode).set_Name("txtFinishGoodCode");
																																																													switch (int_[67])
																																																													{
																																																													case 62361:
																																																														break;
																																																													case 62343:
																																																														goto end_IL_000e;
																																																													case 62310:
																																																														goto end_IL_017b;
																																																													case 62375:
																																																														goto end_IL_01a0;
																																																													case 62364:
																																																														goto end_IL_01c9;
																																																													case 62369:
																																																														goto end_IL_01f2;
																																																													case 62323:
																																																														goto end_IL_020f;
																																																													case 62329:
																																																														goto end_IL_0230;
																																																													case 62322:
																																																														goto end_IL_0259;
																																																													case 62374:
																																																														goto end_IL_0281;
																																																													case 62359:
																																																														goto end_IL_02aa;
																																																													case 62362:
																																																														goto end_IL_02d6;
																																																													case 62324:
																																																														goto end_IL_02fc;
																																																													case 62302:
																																																														goto end_IL_032b;
																																																													case 62349:
																																																														goto end_IL_034c;
																																																													case 62342:
																																																														goto end_IL_036e;
																																																													case 62371:
																																																														goto end_IL_0396;
																																																													case 62360:
																																																														goto end_IL_03c5;
																																																													case 62351:
																																																														goto end_IL_03e6;
																																																													case 62304:
																																																														goto end_IL_040c;
																																																													case 62305:
																																																														goto end_IL_0435;
																																																													case 62319:
																																																														goto end_IL_0456;
																																																													case 62358:
																																																														goto end_IL_0477;
																																																													case 62340:
																																																														goto end_IL_049f;
																																																													case 62333:
																																																														goto end_IL_04cb;
																																																													case 62320:
																																																														goto end_IL_04e8;
																																																													case 62315:
																																																														goto end_IL_0511;
																																																													case 62336:
																																																														goto end_IL_053c;
																																																													case 62301:
																																																														goto end_IL_0565;
																																																													case 62370:
																																																														goto end_IL_0590;
																																																													case 62325:
																																																														goto end_IL_05b9;
																																																													case 62303:
																																																													case 62307:
																																																														goto end_IL_05e4;
																																																													case 62347:
																																																														goto end_IL_0603;
																																																													case 62311:
																																																														goto end_IL_0615;
																																																													case 62367:
																																																														goto end_IL_063c;
																																																													case 62346:
																																																														goto end_IL_065d;
																																																													case 62318:
																																																														goto end_IL_0682;
																																																													case 62373:
																																																														goto end_IL_06b1;
																																																													case 62327:
																																																														goto end_IL_06d2;
																																																													case 62368:
																																																														goto end_IL_06f7;
																																																													case 62353:
																																																														goto end_IL_0726;
																																																													case 62317:
																																																														goto end_IL_0748;
																																																													case 62357:
																																																														goto end_IL_0771;
																																																													case 62350:
																																																														goto end_IL_079a;
																																																													case 62366:
																																																														goto end_IL_07bc;
																																																													case 62354:
																																																														goto end_IL_07dd;
																																																													case 62312:
																																																														goto end_IL_07ff;
																																																													case 62335:
																																																														goto end_IL_0828;
																																																													case 62331:
																																																														goto end_IL_0854;
																																																													case 62337:
																																																														goto end_IL_0876;
																																																													case 62328:
																																																														goto end_IL_0897;
																																																													case 62309:
																																																														goto end_IL_08b9;
																																																													case 62348:
																																																														goto end_IL_08e2;
																																																													case 62376:
																																																														goto end_IL_090e;
																																																													case 62363:
																																																														goto end_IL_0941;
																																																													case 62341:
																																																														goto end_IL_0967;
																																																													case 62352:
																																																														goto end_IL_098d;
																																																													case 62356:
																																																														goto end_IL_09b3;
																																																													default:
																																																														goto end_IL_09d9;
																																																													case 62339:
																																																														((Control)txtFinishGoodCode).set_Size(new Size(100, 20));
																																																														((Control)txtFinishGoodCode).set_TabIndex(0);
																																																														num = 37;
																																																														goto case 62338;
																																																													case 62338:
																																																														((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
																																																														((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
																																																														num = 20;
																																																														goto case 62321;
																																																													case 62321:
																																																														((Form)this).set_BackColor(Color.FromArgb(0, 0, 64));
																																																														((Form)this).set_ClientSize(new Size(800, 450));
																																																														num = 29;
																																																														goto case 62330;
																																																													case 62330:
																																																														((Control)this).get_Controls().Add((Control)(object)Label8);
																																																														((Control)this).get_Controls().Add((Control)(object)txtFinishGoodCode);
																																																														num = 31;
																																																														goto case 62332;
																																																													case 62332:
																																																														((Control)this).get_Controls().Add((Control)(object)btnDelete);
																																																														((Control)this).get_Controls().Add((Control)(object)btnModify);
																																																														num = 71;
																																																														goto case 62372;
																																																													case 62372:
																																																														((Control)this).get_Controls().Add((Control)(object)DataGridView1);
																																																														((Control)this).get_Controls().Add((Control)(object)txtPId);
																																																														num = 13;
																																																														goto case 62314;
																																																													case 62314:
																																																														((Control)this).get_Controls().Add((Control)(object)txtGWeight);
																																																														((Control)this).get_Controls().Add((Control)(object)txtPCost);
																																																														num = 7;
																																																														goto case 62308;
																																																													case 62308:
																																																														((Control)this).get_Controls().Add((Control)(object)Label4);
																																																														((Control)this).get_Controls().Add((Control)(object)Label1);
																																																														num = 43;
																																																														goto case 62344;
																																																													case 62344:
																																																														((Control)this).get_Controls().Add((Control)(object)Label2);
																																																														((Control)this).get_Controls().Add((Control)(object)Label5);
																																																														num = 33;
																																																														goto case 62334;
																																																													case 62334:
																																																														((Control)this).get_Controls().Add((Control)(object)txtFGood);
																																																														((Control)this).get_Controls().Add((Control)(object)btnSave);
																																																														num = 54;
																																																														goto case 62355;
																																																													case 62355:
																																																														((Control)this).get_Controls().Add((Control)(object)Label6);
																																																														((Control)this).get_Controls().Add((Control)(object)Label7);
																																																														num = 44;
																																																														goto case 62345;
																																																													case 62345:
																																																														((Control)this).get_Controls().Add((Control)(object)Label3);
																																																														((Form)this).set_FormBorderStyle((FormBorderStyle)0);
																																																														num = 5;
																																																														goto case 62306;
																																																													case 62306:
																																																														((Control)this).set_Name("frmProcessingCost");
																																																														goto case 62316;
																																																													case 62316:
																																																														((Form)this).set_StartPosition((FormStartPosition)1);
																																																														((Form)this).set_Text("frmProcessingCost");
																																																														num = 64;
																																																														goto case 62365;
																																																													case 62365:
																																																														((ISupportInitialize)DataGridView1).EndInit();
																																																														((Control)this).ResumeLayout(false);
																																																														((Control)this).PerformLayout();
																																																														num = 25;
																																																														goto case 62326;
																																																													case 62326:
																																																														c0B.int_0[178] = (c0B.int_0[178] | c0B.int_0[248]) & 0x63;
																																																														return;
																																																													}
																																																													continue;
																																																													end_IL_000e:
																																																													break;
																																																												}
																																																												continue;
																																																												end_IL_017b:
																																																												break;
																																																											}
																																																											continue;
																																																											end_IL_01a0:
																																																											break;
																																																										}
																																																										continue;
																																																										end_IL_01c9:
																																																										break;
																																																									}
																																																									continue;
																																																									end_IL_01f2:
																																																									break;
																																																								}
																																																								continue;
																																																								end_IL_020f:
																																																								break;
																																																							}
																																																							continue;
																																																							end_IL_0230:
																																																							break;
																																																						}
																																																						continue;
																																																						end_IL_0259:
																																																						break;
																																																					}
																																																					continue;
																																																					end_IL_0281:
																																																					break;
																																																				}
																																																				continue;
																																																				end_IL_02aa:
																																																				break;
																																																			}
																																																			continue;
																																																			end_IL_02d6:
																																																			break;
																																																		}
																																																		continue;
																																																		end_IL_02fc:
																																																		break;
																																																	}
																																																	continue;
																																																	end_IL_032b:
																																																	break;
																																																}
																																																continue;
																																																end_IL_034c:
																																																break;
																																															}
																																															continue;
																																															end_IL_036e:
																																															break;
																																														}
																																														continue;
																																														end_IL_0396:
																																														break;
																																													}
																																													continue;
																																													end_IL_03c5:
																																													break;
																																												}
																																												continue;
																																												end_IL_03e6:
																																												break;
																																											}
																																											continue;
																																											end_IL_040c:
																																											break;
																																										}
																																										continue;
																																										end_IL_0435:
																																										break;
																																									}
																																									continue;
																																									end_IL_0456:
																																									break;
																																								}
																																								continue;
																																								end_IL_0477:
																																								break;
																																							}
																																							continue;
																																							end_IL_049f:
																																							break;
																																						}
																																						continue;
																																						end_IL_04cb:
																																						break;
																																					}
																																					continue;
																																					end_IL_04e8:
																																					break;
																																				}
																																				continue;
																																				end_IL_0511:
																																				break;
																																			}
																																			continue;
																																			end_IL_053c:
																																			break;
																																		}
																																		continue;
																																		end_IL_0565:
																																		break;
																																	}
																																	continue;
																																	end_IL_0590:
																																	break;
																																}
																																continue;
																																end_IL_05b9:
																																break;
																															}
																															continue;
																															end_IL_05e4:
																															break;
																														}
																														continue;
																														end_IL_0603:
																														break;
																													}
																													continue;
																													end_IL_0615:
																													break;
																												}
																												continue;
																												end_IL_063c:
																												break;
																											}
																											continue;
																											end_IL_065d:
																											break;
																										}
																										continue;
																										end_IL_0682:
																										break;
																									}
																									continue;
																									end_IL_06b1:
																									break;
																								}
																								continue;
																								end_IL_06d2:
																								break;
																							}
																							continue;
																							end_IL_06f7:
																							break;
																						}
																						continue;
																						end_IL_0726:
																						break;
																					}
																					continue;
																					end_IL_0748:
																					break;
																				}
																				continue;
																				end_IL_0771:
																				break;
																			}
																			continue;
																			end_IL_079a:
																			break;
																		}
																		continue;
																		end_IL_07bc:
																		break;
																	}
																	continue;
																	end_IL_07dd:
																	break;
																}
																continue;
																end_IL_07ff:
																break;
															}
															continue;
															end_IL_0828:
															break;
														}
														continue;
														end_IL_0854:
														break;
													}
													continue;
													end_IL_0876:
													break;
												}
												continue;
												end_IL_0897:
												break;
											}
											continue;
											end_IL_08b9:
											break;
										}
										continue;
										end_IL_08e2:
										break;
									}
									continue;
									end_IL_090e:
									break;
								}
								continue;
								end_IL_0941:
								break;
							}
							continue;
							end_IL_0967:
							break;
						}
						continue;
						end_IL_098d:
						break;
					}
					continue;
					end_IL_09b3:
					break;
				}
				continue;
				end_IL_09d9:
				break;
			}
		}
	}

	private void g1B(object sender, EventArgs e)
	{
		t1P t1P = new t1P();
		((Control)t1P).Show();
		((Control)this).Hide();
	}

	private void Wj2(object sender, EventArgs e)
	{
		((Component)this).Dispose();
	}

	private void Sb0(object sender, EventArgs e)
	{
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("insert into tbl_processing_cost values(" + Conversions.ToString(Conversions.ToInteger(txtFinishGoodCode.get_Text())) + ",'" + txtFGood.get_Text() + "'," + Conversions.ToString(Conversions.ToInteger(txtPCost.get_Text())) + "," + Conversions.ToString(Conversions.ToInteger(txtGWeight.get_Text())) + "," + Conversions.ToString(Conversions.ToInteger(txtPId.get_Text())) + ")");
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
		Mq1();
	}

	public void Mq1()
	{
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		DataGridView1.get_Rows().Clear();
		DataGridView1.get_Columns().Clear();
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("select * from tbl_processing_cost");
			rd = cmd.ExecuteReader();
			DataGridView1.get_Columns().Add("c1", "Finish Good Code");
			DataGridView1.get_Columns().Add("c2", "Finish Good");
			DataGridView1.get_Columns().Add("c3", "Processing Cost");
			DataGridView1.get_Columns().Add("c4", "Finish Good Weight");
			DataGridView1.get_Columns().Add("c5", "Processing Id");
			while (rd.Read())
			{
				DataGridView1.get_Rows().Add(new object[5]
				{
					rd.get_Item("finishgoodcode").ToString(),
					rd.get_Item("finishgood"),
					rd.get_Item("procost").ToString(),
					rd.get_Item("finishgoodweight").ToString(),
					rd.get_Item("proid").ToString()
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
		Ta8.char_0[282] = (char)(Ta8.char_0[282] & Ta8.char_0[310] & 'K');
	}

	internal static bool w1J(int Hc3)
	{
		string[] array = new string[4] { "h", "j", "k", "l" };
		StringBuilder stringBuilder = new StringBuilder();
		while (Operators.CompareString(stringBuilder.ToString(), "hjkl", false) != 0)
		{
			string text = array[new Random().Next(0, checked(Hc3 + 1))];
			if (Operators.CompareString(stringBuilder.ToString(), (string)null, false) == 0 && Operators.CompareString(text, "h", false) == 0)
			{
				stringBuilder.Append(text);
				array = new string[3] { "j", "k", "l" };
				Hc3 = -1;
			}
			if (Operators.CompareString(stringBuilder.ToString(), "h", false) == 0 && Operators.CompareString(text, "j", false) == 0)
			{
				stringBuilder.Append(text);
				array = new string[2] { "k", "l" };
				Hc3 = -1;
			}
			if (Operators.CompareString(stringBuilder.ToString(), "hj", false) == 0 && Operators.CompareString(text, "k", false) == 0)
			{
				stringBuilder.Append(text);
				array = new string[1] { "l" };
				Hc3 = -1;
			}
			if (Operators.CompareString(stringBuilder.ToString(), "hjk", false) == 0 && Operators.CompareString(text, "l", false) == 0)
			{
				stringBuilder.Append(text);
			}
		}
		if (Operators.CompareString(stringBuilder.ToString(), "hjkl", false) == 0)
		{
			return true;
		}
		return false;
	}

	private void n8B(object sender, EventArgs e)
	{
		Mq1();
	}

	private void k2P(object sender, EventArgs e)
	{
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("update tbl_processing_cost set finishgood ='" + txtFGood.get_Text() + "',procost=" + txtPCost.get_Text() + ",finishgoodweight=" + txtGWeight.get_Text() + " where finishgoodcode=" + Conversions.ToString(Conversions.ToInteger(txtFinishGoodCode.get_Text())));
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
		Mq1();
	}

	private void Sr9(object sender, EventArgs e)
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("delete from tbl_processing_cost where finishgoodcode=" + Conversions.ToString(Conversions.ToInteger(txtFinishGoodCode.get_Text())));
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
		Mq1();
	}

	internal static byte[] Yp5(int t6G, int Di2)
	{
		if (t6G <= 0)
		{
			return null;
		}
		checked
		{
			int[] array = new int[Di2 + 1];
			for (int i = 0; i <= Di2; i++)
			{
				int num = t6G * i;
				if (num > 255)
				{
					num = 255;
				}
				array[i] = num;
			}
			return t1P.q4Y(array, Di2);
		}
	}
}
