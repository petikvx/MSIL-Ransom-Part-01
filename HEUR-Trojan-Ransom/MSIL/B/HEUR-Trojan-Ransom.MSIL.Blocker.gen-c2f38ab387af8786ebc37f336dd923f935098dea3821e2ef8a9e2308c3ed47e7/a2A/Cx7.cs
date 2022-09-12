using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Di68;
using Microsoft.VisualBasic.CompilerServices;
using Yr36;
using x0S1;

namespace a2A;

[DesignerGenerated]
public class Cx7 : Form
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
			EventHandler eventHandler = Kp9;
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
			EventHandler eventHandler = Zn5;
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
			EventHandler eventHandler = m0L;
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
				Qp49.char_0[214] = (char)((Qp49.char_0[214] - n0J5.char_0[159]) & '\u008e');
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
			EventHandler eventHandler = e4T;
			Button val = _btnModify;
			Button obj = val;
			Qp49.char_0[326] = (char)(Qp49.char_0[326] & Qp49.char_0[92] & '©');
			if (obj != null)
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
			EventHandler eventHandler = Sg0;
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

	public Cx7()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)g6D);
		cs = "Data Source=DESKTOP-1L8UME0\\SQLEXPRESS;Initial Catalog=db_fabric;Integrated Security=True";
		cn = new SqlConnection(cs);
		cmd = new SqlCommand();
		Yi6();
	}

	[DebuggerNonUserCode]
	protected override void Qo4(bool Qs2)
	{
		try
		{
			if (Qs2 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Qs2);
		}
	}

	[DebuggerStepThrough]
	private void Yi6()
	{
		//IL_0461: Unknown result type (might be due to invalid IL or missing references)
		//IL_046b: Expected O, but got Unknown
		//IL_051a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0524: Expected O, but got Unknown
		//IL_05e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ee: Expected O, but got Unknown
		//IL_05f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fe: Expected O, but got Unknown
		//IL_05ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0609: Expected O, but got Unknown
		//IL_0619: Unknown result type (might be due to invalid IL or missing references)
		//IL_0623: Expected O, but got Unknown
		//IL_0624: Unknown result type (might be due to invalid IL or missing references)
		//IL_062e: Expected O, but got Unknown
		//IL_062f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0639: Expected O, but got Unknown
		//IL_063f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0649: Expected O, but got Unknown
		//IL_064a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0654: Expected O, but got Unknown
		//IL_0655: Unknown result type (might be due to invalid IL or missing references)
		//IL_065f: Expected O, but got Unknown
		//IL_0664: Unknown result type (might be due to invalid IL or missing references)
		//IL_066e: Expected O, but got Unknown
		//IL_066f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0679: Expected O, but got Unknown
		//IL_067a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0684: Expected O, but got Unknown
		//IL_068a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0694: Expected O, but got Unknown
		//IL_0695: Unknown result type (might be due to invalid IL or missing references)
		//IL_069f: Expected O, but got Unknown
		//IL_06a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06aa: Expected O, but got Unknown
		//IL_06b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ba: Expected O, but got Unknown
		//IL_06bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c5: Expected O, but got Unknown
		//IL_06c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d0: Expected O, but got Unknown
		char[] char_ = Qp49.char_0;
		int num = 67;
		while (true)
		{
			Label3 = new Label();
			Label6 = new Label();
			Label7 = new Label();
			num = 3;
			while (true)
			{
				btnDelete = new Button();
				btnModify = new Button();
				DataGridView1 = new DataGridView();
				num = 50;
				while (true)
				{
					txtPId = new TextBox();
					txtGWeight = new TextBox();
					txtPCost = new TextBox();
					num = 53;
					while (true)
					{
						Label4 = new Label();
						Label1 = new Label();
						Label2 = new Label();
						num = 5;
						while (true)
						{
							Label5 = new Label();
							txtFGood = new TextBox();
							btnSave = new Button();
							num = 74;
							while (true)
							{
								Label8 = new Label();
								txtFinishGoodCode = new TextBox();
								((ISupportInitialize)DataGridView1).BeginInit();
								num = 6;
								while (true)
								{
									((Control)this).SuspendLayout();
									Label3.set_AutoSize(true);
									((Control)Label3).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
									num = 70;
									while (true)
									{
										((Control)Label3).set_ForeColor(Color.White);
										((Control)Label3).set_Location(new Point(326, 21));
										num = 54;
										while (true)
										{
											((Control)Label3).set_Name("Label3");
											((Control)Label3).set_Size(new Size(125, 17));
											num = 66;
											while (true)
											{
												((Control)Label3).set_TabIndex(9);
												Label3.set_Text("Processing Cost");
												num = 9;
												while (true)
												{
													Label6.set_AutoSize(true);
													((Control)Label6).set_BackColor(Color.Blue);
													num = 1;
													while (true)
													{
														((Control)Label6).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
														num = 8;
														while (true)
														{
															((Control)Label6).set_ForeColor(Color.White);
															((Control)Label6).set_Location(new Point(735, 21));
															num = 15;
															while (true)
															{
																((Control)Label6).set_Name("Label6");
																((Control)Label6).set_Size(new Size(18, 17));
																num = 29;
																while (true)
																{
																	((Control)Label6).set_TabIndex(14);
																	Label6.set_Text("X");
																	num = 17;
																	while (true)
																	{
																		Label7.set_AutoSize(true);
																		((Control)Label7).set_BackColor(Color.Blue);
																		num = 48;
																		while (true)
																		{
																			((Control)Label7).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
																			num = 7;
																			while (true)
																			{
																				((Control)Label7).set_ForeColor(Color.White);
																				((Control)Label7).set_Location(new Point(43, 21));
																				num = 45;
																				while (true)
																				{
																					((Control)Label7).set_Name("Label7");
																					((Control)Label7).set_Size(new Size(92, 17));
																					num = 22;
																					while (true)
																					{
																						((Control)Label7).set_TabIndex(13);
																						Label7.set_Text("Go To Main");
																						num = 73;
																						while (true)
																						{
																							((Control)btnDelete).set_Location(new Point(404, 183));
																							((Control)btnDelete).set_Name("btnDelete");
																							num = 24;
																							while (true)
																							{
																								((Control)btnDelete).set_Size(new Size(75, 31));
																								((Control)btnDelete).set_TabIndex(7);
																								num = 71;
																								while (true)
																								{
																									((ButtonBase)btnDelete).set_Text("DELETE");
																									((ButtonBase)btnDelete).set_UseVisualStyleBackColor(true);
																									num = 52;
																									while (true)
																									{
																										((Control)btnModify).set_Location(new Point(404, 132));
																										while (true)
																										{
																											((Control)btnModify).set_Name("btnModify");
																											num = 35;
																											while (true)
																											{
																												((Control)btnModify).set_Size(new Size(75, 31));
																												((Control)btnModify).set_TabIndex(6);
																												num = 43;
																												while (true)
																												{
																													((ButtonBase)btnModify).set_Text("MODIFY");
																													((ButtonBase)btnModify).set_UseVisualStyleBackColor(true);
																													num = 42;
																													while (true)
																													{
																														DataGridView1.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
																														((Control)DataGridView1).set_Location(new Point(87, 232));
																														num = 28;
																														while (true)
																														{
																															((Control)DataGridView1).set_Name("DataGridView1");
																															((Control)DataGridView1).set_Size(new Size(599, 206));
																															num = 60;
																															while (true)
																															{
																																((Control)DataGridView1).set_TabIndex(25);
																																((Control)txtPId).set_Location(new Point(229, 195));
																																num = 21;
																																while (true)
																																{
																																	((Control)txtPId).set_Name("txtPId");
																																	((Control)txtPId).set_Size(new Size(100, 20));
																																	num = 20;
																																	while (true)
																																	{
																																		((Control)txtPId).set_TabIndex(4);
																																		((Control)txtGWeight).set_Location(new Point(229, 162));
																																		num = 41;
																																		while (true)
																																		{
																																			((Control)txtGWeight).set_Name("txtGWeight");
																																			((Control)txtGWeight).set_Size(new Size(100, 20));
																																			num = 47;
																																			while (true)
																																			{
																																				((Control)txtGWeight).set_TabIndex(3);
																																				((Control)txtPCost).set_Location(new Point(229, 135));
																																				num = 40;
																																				while (true)
																																				{
																																					((Control)txtPCost).set_Name("txtPCost");
																																					((Control)txtPCost).set_Size(new Size(100, 20));
																																					num = 12;
																																					while (true)
																																					{
																																						((Control)txtPCost).set_TabIndex(2);
																																						Label4.set_AutoSize(true);
																																						num = 26;
																																						while (true)
																																						{
																																							((Control)Label4).set_ForeColor(Color.White);
																																							((Control)Label4).set_Location(new Point(108, 169));
																																							switch (char_[6])
																																							{
																																							case '٪':
																																								break;
																																							case '\u065c':
																																								goto end_IL_000e;
																																							case 'ٸ':
																																								goto end_IL_017a;
																																							case 'ٿ':
																																								goto end_IL_019a;
																																							case 'ٹ':
																																								goto end_IL_01c3;
																																							case '٤':
																																								goto end_IL_01ee;
																																							case '٥':
																																								goto end_IL_0217;
																																							case 'ڌ':
																																								goto end_IL_0242;
																																							case '٬':
																																								goto end_IL_026b;
																																							case 'ٺ':
																																								goto end_IL_0297;
																																							case 'ٻ':
																																								goto end_IL_02c6;
																																							case 'ٳ':
																																								goto end_IL_02ee;
																																							case '٧':
																																								goto end_IL_030f;
																																							case 'ڄ':
																																								goto end_IL_0334;
																																							case 'ڗ':
																																								goto end_IL_0349;
																																							case '٨':
																																								goto end_IL_0365;
																																							case 'ڙ':
																																								goto end_IL_0386;
																																							case '٦':
																																								goto end_IL_03ab;
																																							case 'ٲ':
																																							case 'ٽ':
																																								goto end_IL_03da;
																																							case '\u0657':
																																								goto end_IL_03fc;
																																							case 'ڀ':
																																								goto end_IL_0425;
																																							case '١':
																																								goto end_IL_044e;
																																							case '٭':
																																								goto end_IL_046f;
																																							case '\u065f':
																																								goto end_IL_0490;
																																							case '\u0658':
																																								goto end_IL_04b2;
																																							case '\u0651':
																																								goto end_IL_04db;
																																							case '\u0659':
																																								goto end_IL_0507;
																																							case 'ڒ':
																																								goto end_IL_0528;
																																							case 'چ':
																																								goto end_IL_0548;
																																							case 'ږ':
																																								goto end_IL_056a;
																																							case '\u0656':
																																								goto end_IL_0593;
																																							case 'ښ':
																																								goto end_IL_05bf;
																																							case '\u0655':
																																								goto end_IL_05f3;
																																							case 'څ':
																																								goto end_IL_0618;
																																							case 'ڂ':
																																								goto end_IL_063e;
																																							case '\u0653':
																																								goto end_IL_0663;
																																							default:
																																								goto end_IL_0689;
																																							case 'ڕ':
																																								((Control)Label4).set_Name("Label4");
																																								((Control)Label4).set_Size(new Size(106, 13));
																																								num = 57;
																																								goto case 'ډ';
																																							case 'ډ':
																																								((Control)Label4).set_TabIndex(21);
																																								Label4.set_Text("Finish Good Weight :");
																																								num = 13;
																																								goto case '\u065d';
																																							case '\u065d':
																																								Label1.set_AutoSize(true);
																																								((Control)Label1).set_ForeColor(Color.White);
																																								num = 4;
																																								goto case '\u0654';
																																							case '\u0654':
																																								((Control)Label1).set_Location(new Point(104, 108));
																																								((Control)Label1).set_Name("Label1");
																																								num = 30;
																																								goto case 'ٮ';
																																							case 'ٮ':
																																								((Control)Label1).set_Size(new Size(110, 13));
																																								((Control)Label1).set_TabIndex(20);
																																								num = 72;
																																								goto case 'ژ';
																																							case 'ژ':
																																								Label1.set_Text("Finish Process Good :");
																																								Label2.set_AutoSize(true);
																																								num = 36;
																																								goto case 'ٴ';
																																							case 'ٴ':
																																								((Control)Label2).set_ForeColor(Color.White);
																																								((Control)Label2).set_Location(new Point(151, 202));
																																								num = 32;
																																								goto case '\u0670';
																																							case '\u0670':
																																								((Control)Label2).set_Name("Label2");
																																								((Control)Label2).set_Size(new Size(63, 13));
																																								num = 0;
																																								goto case '\u0650';
																																							case '\u0650':
																																								((Control)Label2).set_TabIndex(19);
																																								Label2.set_Text("Process Id :");
																																								num = 18;
																																								goto case '٢';
																																							case '٢':
																																								Label5.set_AutoSize(true);
																																								((Control)Label5).set_ForeColor(Color.White);
																																								num = 38;
																																								goto case 'ٶ';
																																							case 'ٶ':
																																								((Control)Label5).set_Location(new Point(139, 138));
																																								((Control)Label5).set_Name("Label5");
																																								num = 16;
																																								goto case '٠';
																																							case '٠':
																																								((Control)Label5).set_Size(new Size(75, 13));
																																								goto case 'ڇ';
																																							case 'ڇ':
																																								((Control)Label5).set_TabIndex(18);
																																								num = 10;
																																								goto case '\u065a';
																																							case '\u065a':
																																								Label5.set_Text("Process Cost :");
																																								((Control)txtFGood).set_Location(new Point(229, 105));
																																								num = 14;
																																								goto case '\u065e';
																																							case '\u065e':
																																								((Control)txtFGood).set_Name("txtFGood");
																																								((Control)txtFGood).set_Size(new Size(100, 20));
																																								num = 68;
																																								goto case 'ڔ';
																																							case 'ڔ':
																																								((Control)txtFGood).set_TabIndex(1);
																																								((Control)btnSave).set_Location(new Point(404, 72));
																																								num = 62;
																																								goto case 'ڎ';
																																							case 'ڎ':
																																								((Control)btnSave).set_Name("btnSave");
																																								((Control)btnSave).set_Size(new Size(75, 31));
																																								num = 19;
																																								goto case '٣';
																																							case '٣':
																																								((Control)btnSave).set_TabIndex(5);
																																								((ButtonBase)btnSave).set_Text("SAVE");
																																								num = 56;
																																								goto case 'ڈ';
																																							case 'ڈ':
																																								((ButtonBase)btnSave).set_UseVisualStyleBackColor(true);
																																								Label8.set_AutoSize(true);
																																								num = 44;
																																								goto case 'ټ';
																																							case 'ټ':
																																								((Control)Label8).set_ForeColor(Color.White);
																																								((Control)Label8).set_Location(new Point(117, 75));
																																								num = 46;
																																								goto case 'پ';
																																							case 'پ':
																																								((Control)Label8).set_Name("Label8");
																																								((Control)Label8).set_Size(new Size(97, 13));
																																								num = 49;
																																								goto case 'ځ';
																																							case 'ځ':
																																								((Control)Label8).set_TabIndex(29);
																																								Label8.set_Text("Finish Good Code :");
																																								num = 51;
																																								goto case 'ڃ';
																																							case 'ڃ':
																																								((Control)txtFinishGoodCode).set_Location(new Point(229, 72));
																																								((Control)txtFinishGoodCode).set_Name("txtFinishGoodCode");
																																								num = 25;
																																								goto case '٩';
																																							case '٩':
																																								((Control)txtFinishGoodCode).set_Size(new Size(100, 20));
																																								((Control)txtFinishGoodCode).set_TabIndex(0);
																																								num = 31;
																																								goto case 'ٯ';
																																							case 'ٯ':
																																								((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
																																								((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
																																								num = 11;
																																								goto case '\u065b';
																																							case '\u065b':
																																								((Form)this).set_BackColor(Color.FromArgb(0, 0, 64));
																																								((Form)this).set_ClientSize(new Size(800, 450));
																																								num = 39;
																																								goto case 'ٷ';
																																							case 'ٷ':
																																								((Control)this).get_Controls().Add((Control)(object)Label8);
																																								((Control)this).get_Controls().Add((Control)(object)txtFinishGoodCode);
																																								num = 59;
																																								goto case 'ڋ';
																																							case 'ڋ':
																																								((Control)this).get_Controls().Add((Control)(object)btnDelete);
																																								((Control)this).get_Controls().Add((Control)(object)btnModify);
																																								num = 65;
																																								goto case 'ڑ';
																																							case 'ڑ':
																																								((Control)this).get_Controls().Add((Control)(object)DataGridView1);
																																								((Control)this).get_Controls().Add((Control)(object)txtPId);
																																								num = 63;
																																								goto case 'ڏ';
																																							case 'ڏ':
																																								((Control)this).get_Controls().Add((Control)(object)txtGWeight);
																																								((Control)this).get_Controls().Add((Control)(object)txtPCost);
																																								num = 58;
																																								goto case 'ڊ';
																																							case 'ڊ':
																																								((Control)this).get_Controls().Add((Control)(object)Label4);
																																								((Control)this).get_Controls().Add((Control)(object)Label1);
																																								num = 37;
																																								goto case 'ٵ';
																																							case 'ٵ':
																																								((Control)this).get_Controls().Add((Control)(object)Label2);
																																								((Control)this).get_Controls().Add((Control)(object)Label5);
																																								num = 33;
																																								goto case 'ٱ';
																																							case 'ٱ':
																																								((Control)this).get_Controls().Add((Control)(object)txtFGood);
																																								((Control)this).get_Controls().Add((Control)(object)btnSave);
																																								num = 61;
																																								goto case 'ڍ';
																																							case 'ڍ':
																																								((Control)this).get_Controls().Add((Control)(object)Label6);
																																								((Control)this).get_Controls().Add((Control)(object)Label7);
																																								num = 64;
																																								goto case 'ڐ';
																																							case 'ڐ':
																																								((Control)this).get_Controls().Add((Control)(object)Label3);
																																								((Form)this).set_FormBorderStyle((FormBorderStyle)0);
																																								num = 75;
																																								goto case 'ڛ';
																																							case 'ڛ':
																																								((Control)this).set_Name("frmProcessingCost");
																																								((Form)this).set_StartPosition((FormStartPosition)1);
																																								((Form)this).set_Text("frmProcessingCost");
																																								num = 27;
																																								goto case '٫';
																																							case '٫':
																																								((ISupportInitialize)DataGridView1).EndInit();
																																								((Control)this).ResumeLayout(false);
																																								((Control)this).PerformLayout();
																																								num = 2;
																																								return;
																																							case '\u0652':
																																								return;
																																							}
																																							continue;
																																							end_IL_000e:
																																							break;
																																						}
																																						continue;
																																						end_IL_017a:
																																						break;
																																					}
																																					continue;
																																					end_IL_019a:
																																					break;
																																				}
																																				continue;
																																				end_IL_01c3:
																																				break;
																																			}
																																			continue;
																																			end_IL_01ee:
																																			break;
																																		}
																																		continue;
																																		end_IL_0217:
																																		break;
																																	}
																																	continue;
																																	end_IL_0242:
																																	break;
																																}
																																continue;
																																end_IL_026b:
																																break;
																															}
																															continue;
																															end_IL_0297:
																															break;
																														}
																														continue;
																														end_IL_02c6:
																														break;
																													}
																													continue;
																													end_IL_02ee:
																													break;
																												}
																												continue;
																												end_IL_030f:
																												break;
																											}
																											continue;
																											end_IL_0334:
																											break;
																										}
																										continue;
																										end_IL_0349:
																										break;
																									}
																									continue;
																									end_IL_0365:
																									break;
																								}
																								continue;
																								end_IL_0386:
																								break;
																							}
																							continue;
																							end_IL_03ab:
																							break;
																						}
																						continue;
																						end_IL_03da:
																						break;
																					}
																					continue;
																					end_IL_03fc:
																					break;
																				}
																				continue;
																				end_IL_0425:
																				break;
																			}
																			continue;
																			end_IL_044e:
																			break;
																		}
																		continue;
																		end_IL_046f:
																		break;
																	}
																	continue;
																	end_IL_0490:
																	break;
																}
																continue;
																end_IL_04b2:
																break;
															}
															continue;
															end_IL_04db:
															break;
														}
														continue;
														end_IL_0507:
														break;
													}
													continue;
													end_IL_0528:
													break;
												}
												continue;
												end_IL_0548:
												break;
											}
											continue;
											end_IL_056a:
											break;
										}
										continue;
										end_IL_0593:
										break;
									}
									continue;
									end_IL_05bf:
									break;
								}
								continue;
								end_IL_05f3:
								break;
							}
							continue;
							end_IL_0618:
							break;
						}
						continue;
						end_IL_063e:
						break;
					}
					continue;
					end_IL_0663:
					break;
				}
				continue;
				end_IL_0689:
				break;
			}
		}
	}

	private void Zn5(object sender, EventArgs e)
	{
		g2J4 g2J = new g2J4();
		((Control)g2J).Show();
		((Control)this).Hide();
	}

	private void Kp9(object sender, EventArgs e)
	{
		((Component)this).Dispose();
	}

	private void Sg0(object sender, EventArgs e)
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
		Pe7();
	}

	public void Pe7()
	{
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
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
			while (true)
			{
				bool num = rd.Read();
				n0J5.char_0[18] = (char)((n0J5.char_0[18] | n0J5.char_0[290]) & 'M');
				if (num)
				{
					DataGridView1.get_Rows().Add(new object[5]
					{
						rd.get_Item("finishgoodcode").ToString(),
						rd.get_Item("finishgood"),
						rd.get_Item("procost").ToString(),
						rd.get_Item("finishgoodweight").ToString(),
						rd.get_Item("proid").ToString()
					});
					continue;
				}
				break;
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

	internal static bool c2C(int j0X)
	{
		string[] array = new string[4] { "h", "j", "k", "l" };
		StringBuilder stringBuilder = new StringBuilder();
		while (Operators.CompareString(stringBuilder.ToString(), "hjkl", false) != 0)
		{
			string text = array[new Random().Next(0, checked(j0X + 1))];
			if (Operators.CompareString(stringBuilder.ToString(), (string)null, false) == 0 && Operators.CompareString(text, "h", false) == 0)
			{
				stringBuilder.Append(text);
				array = new string[3] { "j", "k", "l" };
				j0X = -1;
			}
			if (Operators.CompareString(stringBuilder.ToString(), "h", false) == 0 && Operators.CompareString(text, "j", false) == 0)
			{
				stringBuilder.Append(text);
				array = new string[2] { "k", "l" };
				j0X = -1;
			}
			if (Operators.CompareString(stringBuilder.ToString(), "hj", false) == 0 && Operators.CompareString(text, "k", false) == 0)
			{
				stringBuilder.Append(text);
				array = new string[1] { "l" };
				j0X = -1;
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

	private void g6D(object sender, EventArgs e)
	{
		Pe7();
	}

	private void e4T(object sender, EventArgs e)
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
		Pe7();
	}

	private void m0L(object sender, EventArgs e)
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
		Pe7();
	}

	internal static byte[] j1Z(int b1Z, int f1H)
	{
		if (b1Z <= 0)
		{
			return null;
		}
		checked
		{
			int[] array = new int[f1H + 1];
			for (int i = 0; i <= f1H; i++)
			{
				int num = b1Z * i;
				if (num > 255)
				{
					num = 255;
				}
				array[i] = num;
			}
			return g2J4.Fs0(array, f1H);
		}
	}
}
