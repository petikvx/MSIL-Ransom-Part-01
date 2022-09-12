using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Bz5f;
using Ca2z;
using Gj16;
using Microsoft.VisualBasic.CompilerServices;
using Ss28;
using Xs4;
using Yz5;
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

namespace x5PX;

[DesignerGenerated]
public class Sf06 : Form
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
			char[] char_ = Hi84.char_0;
			int num = 2;
			while (true)
			{
				EventHandler eventHandler = m5KZ;
				Label label = _Label6;
				while (true)
				{
					if (label == null)
					{
						switch (char_[517])
						{
						case 'ᴨ':
							break;
						default:
							goto end_IL_0042;
						case 'ᴫ':
						case 'ᴬ':
							goto IL_005f;
						case 'ᴩ':
							goto IL_0066;
						case 'ᴥ':
							goto IL_006d;
						case 'ᴪ':
							goto IL_0079;
						case 'ᴦ':
							return;
						}
						continue;
					}
					num = 6;
					goto IL_005f;
					IL_006d:
					label = _Label6;
					if (label != null)
					{
						num = 5;
						goto IL_0079;
					}
					num = 1;
					return;
					IL_0079:
					((Control)label).add_Click(eventHandler);
					return;
					IL_005f:
					((Control)label).remove_Click(eventHandler);
					goto IL_0066;
					IL_0066:
					_Label6 = value;
					goto IL_006d;
					continue;
					end_IL_0042:
					break;
				}
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
			EventHandler eventHandler = Bs3n;
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
			EventHandler eventHandler = b5RH;
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
			char[] char_ = Hi84.char_0;
			int num = 5;
			EventHandler eventHandler;
			Button val;
			while (true)
			{
				eventHandler = Ak81;
				val = _btnModify;
				if (val == null)
				{
					switch (char_[34])
					{
					case '쇳':
						goto IL_0056;
					case '쇲':
					case '쇵':
						goto IL_005d;
					case '쇴':
						goto IL_006b;
					case '쇸':
						goto end_IL_003d;
					case '쇶':
						return;
					}
					continue;
				}
				num = 1;
				goto IL_0056;
				IL_005d:
				_btnModify = value;
				val = _btnModify;
				goto IL_006b;
				IL_006b:
				if (val != null)
				{
					num = 6;
					break;
				}
				num = 4;
				return;
				IL_0056:
				((Control)val).remove_Click(eventHandler);
				goto IL_005d;
				continue;
				end_IL_003d:
				break;
			}
			((Control)val).add_Click(eventHandler);
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
			EventHandler eventHandler = Xo49;
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

	public Sf06()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)Wp05);
		cs = "Data Source=DESKTOP-1L8UME0\\SQLEXPRESS;Initial Catalog=db_fabric;Integrated Security=True";
		cn = new SqlConnection(cs);
		cmd = new SqlCommand();
		Nm6w();
	}

	[DebuggerNonUserCode]
	protected override void Bm46(bool Fx1z)
	{
		try
		{
			if (Fx1z && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Fx1z);
		}
	}

	[DebuggerStepThrough]
	private void Nm6w()
	{
		//IL_0402: Unknown result type (might be due to invalid IL or missing references)
		//IL_040c: Expected O, but got Unknown
		//IL_0703: Unknown result type (might be due to invalid IL or missing references)
		//IL_070d: Expected O, but got Unknown
		//IL_0938: Unknown result type (might be due to invalid IL or missing references)
		//IL_0942: Expected O, but got Unknown
		//IL_0948: Unknown result type (might be due to invalid IL or missing references)
		//IL_0952: Expected O, but got Unknown
		//IL_0953: Unknown result type (might be due to invalid IL or missing references)
		//IL_095d: Expected O, but got Unknown
		//IL_096e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0978: Expected O, but got Unknown
		//IL_0979: Unknown result type (might be due to invalid IL or missing references)
		//IL_0983: Expected O, but got Unknown
		//IL_0984: Unknown result type (might be due to invalid IL or missing references)
		//IL_098e: Expected O, but got Unknown
		//IL_0994: Unknown result type (might be due to invalid IL or missing references)
		//IL_099e: Expected O, but got Unknown
		//IL_099f: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a9: Expected O, but got Unknown
		//IL_09aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b4: Expected O, but got Unknown
		//IL_09ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c4: Expected O, but got Unknown
		//IL_09c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_09cf: Expected O, but got Unknown
		//IL_09d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_09da: Expected O, but got Unknown
		//IL_09e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ea: Expected O, but got Unknown
		//IL_09eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f5: Expected O, but got Unknown
		//IL_09f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a00: Expected O, but got Unknown
		//IL_0a05: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a0f: Expected O, but got Unknown
		//IL_0a10: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a1a: Expected O, but got Unknown
		//IL_0a1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a25: Expected O, but got Unknown
		byte[] byte_ = Tf67.byte_0;
		int num = 73;
		while (true)
		{
			Label3 = new Label();
			Label6 = new Label();
			Label7 = new Label();
			num = 13;
			while (true)
			{
				btnDelete = new Button();
				btnModify = new Button();
				DataGridView1 = new DataGridView();
				num = 7;
				while (true)
				{
					txtPId = new TextBox();
					txtGWeight = new TextBox();
					txtPCost = new TextBox();
					num = 16;
					while (true)
					{
						Label4 = new Label();
						Label1 = new Label();
						Label2 = new Label();
						num = 70;
						while (true)
						{
							Label5 = new Label();
							txtFGood = new TextBox();
							btnSave = new Button();
							num = 14;
							while (true)
							{
								Label8 = new Label();
								txtFinishGoodCode = new TextBox();
								((ISupportInitialize)DataGridView1).BeginInit();
								num = 43;
								while (true)
								{
									((Control)this).SuspendLayout();
									Label3.set_AutoSize(true);
									((Control)Label3).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
									num = 55;
									while (true)
									{
										((Control)Label3).set_ForeColor(Color.White);
										((Control)Label3).set_Location(new Point(326, 21));
										num = 41;
										while (true)
										{
											((Control)Label3).set_Name("Label3");
											((Control)Label3).set_Size(new Size(125, 17));
											num = 37;
											while (true)
											{
												((Control)Label3).set_TabIndex(9);
												Label3.set_Text("Processing Cost");
												num = 3;
												while (true)
												{
													Label6.set_AutoSize(true);
													((Control)Label6).set_BackColor(Color.Blue);
													num = byte_[120] - 18;
													while (true)
													{
														switch (num)
														{
														case 74:
															((Control)Label8).set_TabIndex(29);
															Label8.set_Text("Finish Good Code :");
															num = 68;
															goto case 68;
														case 68:
															((Control)txtFinishGoodCode).set_Location(new Point(229, 72));
															((Control)txtFinishGoodCode).set_Name("txtFinishGoodCode");
															num = 47;
															goto case 47;
														case 47:
															((Control)txtFinishGoodCode).set_Size(new Size(100, 20));
															((Control)txtFinishGoodCode).set_TabIndex(0);
															num = byte_[40] - byte_[65];
															continue;
														case 71:
															((Control)DataGridView1).set_Name("DataGridView1");
															((Control)DataGridView1).set_Size(new Size(599, 206));
															num = 38;
															goto case 38;
														case 38:
															((Control)DataGridView1).set_TabIndex(25);
															((Control)txtPId).set_Location(new Point(229, 195));
															num = 29;
															goto case 29;
														case 29:
															((Control)txtPId).set_Name("txtPId");
															((Control)txtPId).set_Size(new Size(100, 20));
															num = 30;
															goto case 30;
														case 30:
															((Control)txtPId).set_TabIndex(4);
															((Control)txtGWeight).set_Location(new Point(229, 162));
															num = 4;
															goto case 4;
														case 4:
															((Control)txtGWeight).set_Name("txtGWeight");
															((Control)txtGWeight).set_Size(new Size(100, 20));
															num = 22;
															goto case 22;
														case 22:
															((Control)txtGWeight).set_TabIndex(3);
															((Control)txtPCost).set_Location(new Point(229, 135));
															num = 11;
															goto case 11;
														case 11:
															((Control)txtPCost).set_Name("txtPCost");
															((Control)txtPCost).set_Size(new Size(100, 20));
															num = 64;
															goto case 64;
														case 64:
															((Control)txtPCost).set_TabIndex(2);
															Label4.set_AutoSize(true);
															num = 52;
															goto case 52;
														case 52:
															((Control)Label4).set_ForeColor(Color.White);
															goto case 1;
														case 1:
															((Control)Label4).set_Location(new Point(108, 169));
															num = 25;
															goto case 25;
														case 25:
															((Control)Label4).set_Name("Label4");
															((Control)Label4).set_Size(new Size(106, 13));
															num = 56;
															goto case 56;
														case 56:
															((Control)Label4).set_TabIndex(21);
															Label4.set_Text("Finish Good Weight :");
															num = 33;
															goto case 33;
														case 33:
															Label1.set_AutoSize(true);
															((Control)Label1).set_ForeColor(Color.White);
															num = 21;
															goto case 21;
														case 21:
															((Control)Label1).set_Location(new Point(104, 108));
															((Control)Label1).set_Name("Label1");
															num = 63;
															goto case 63;
														case 63:
															((Control)Label1).set_Size(new Size(110, 13));
															((Control)Label1).set_TabIndex(20);
															num = 6;
															goto case 6;
														case 6:
															Label1.set_Text("Finish Process Good :");
															Label2.set_AutoSize(true);
															goto case 67;
														case 67:
															num = 53;
															goto case 53;
														case 53:
															((Control)Label2).set_ForeColor(Color.White);
															((Control)Label2).set_Location(new Point(151, 202));
															num = 32;
															goto case 32;
														case 32:
															((Control)Label2).set_Name("Label2");
															((Control)Label2).set_Size(new Size(63, 13));
															num = 61;
															goto case 61;
														case 61:
															((Control)Label2).set_TabIndex(19);
															Label2.set_Text("Process Id :");
															num = byte_[121] - 22;
															continue;
														case 65:
															((Control)Label8).set_Name("Label8");
															((Control)Label8).set_Size(new Size(97, 13));
															num = 74;
															goto case 74;
														case 60:
															DataGridView1.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
															((Control)DataGridView1).set_Location(new Point(87, 232));
															num = 71;
															goto case 71;
														case 59:
															((Control)btnModify).set_Size(new Size(75, 31));
															((Control)btnModify).set_TabIndex(6);
															num = 5;
															goto case 5;
														case 5:
															((ButtonBase)btnModify).set_Text("MODIFY");
															((ButtonBase)btnModify).set_UseVisualStyleBackColor(true);
															num = 60;
															goto case 60;
														case 58:
															Label7.set_AutoSize(true);
															((Control)Label7).set_BackColor(Color.Blue);
															num = 27;
															goto case 27;
														case 27:
															((Control)Label7).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
															num = 8;
															goto case 8;
														case 8:
															((Control)Label7).set_ForeColor(Color.White);
															((Control)Label7).set_Location(new Point(43, 21));
															num = 2;
															goto case 2;
														case 2:
															((Control)Label7).set_Name("Label7");
															((Control)Label7).set_Size(new Size(92, 17));
															num = 34;
															goto case 34;
														case 34:
															((Control)Label7).set_TabIndex(13);
															Label7.set_Text("Go To Main");
															num = 0;
															goto case 0;
														case 0:
															((Control)btnDelete).set_Location(new Point(404, 183));
															((Control)btnDelete).set_Name("btnDelete");
															num = 45;
															goto case 45;
														case 45:
															((Control)btnDelete).set_Size(new Size(75, 31));
															((Control)btnDelete).set_TabIndex(7);
															num = 23;
															goto case 23;
														case 23:
															((ButtonBase)btnDelete).set_Text("DELETE");
															((ButtonBase)btnDelete).set_UseVisualStyleBackColor(true);
															num = 15;
															goto case 15;
														case 15:
															((Control)btnModify).set_Location(new Point(404, 132));
															((Control)btnModify).set_Name("btnModify");
															num = 59;
															goto case 59;
														case 54:
															((Control)btnSave).set_TabIndex(5);
															((ButtonBase)btnSave).set_Text("SAVE");
															num = 36;
															goto case 36;
														case 36:
															((ButtonBase)btnSave).set_UseVisualStyleBackColor(true);
															Label8.set_AutoSize(true);
															num = 46;
															goto case 40;
														case 40:
														case 46:
															((Control)Label8).set_ForeColor(Color.White);
															((Control)Label8).set_Location(new Point(117, 75));
															num = 65;
															goto case 65;
														case 51:
															((Control)txtFGood).set_Name("txtFGood");
															((Control)txtFGood).set_Size(new Size(100, 20));
															num = 42;
															goto case 42;
														case 42:
															((Control)txtFGood).set_TabIndex(1);
															((Control)btnSave).set_Location(new Point(404, 72));
															num = 19;
															goto case 19;
														case 19:
															((Control)btnSave).set_Name("btnSave");
															((Control)btnSave).set_Size(new Size(75, 31));
															num = 54;
															goto case 54;
														case 49:
															((Control)Label6).set_ForeColor(Color.White);
															((Control)Label6).set_Location(new Point(735, 21));
															num = 10;
															goto case 10;
														case 10:
															((Control)Label6).set_Name("Label6");
															((Control)Label6).set_Size(new Size(18, 17));
															num = 31;
															goto case 31;
														case 31:
															((Control)Label6).set_TabIndex(14);
															Label6.set_Text("X");
															num = 58;
															goto case 58;
														case 44:
															((Control)Label5).set_Location(new Point(139, 138));
															((Control)Label5).set_Name("Label5");
															num = 28;
															goto case 28;
														case 28:
															((Control)Label5).set_Size(new Size(75, 13));
															((Control)Label5).set_TabIndex(18);
															num = 12;
															goto case 12;
														case 12:
															Label5.set_Text("Process Cost :");
															((Control)txtFGood).set_Location(new Point(229, 105));
															num = 51;
															goto case 51;
														case 35:
															((Control)Label6).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
															num = 49;
															goto case 49;
														case 24:
															Label5.set_AutoSize(true);
															((Control)Label5).set_ForeColor(Color.White);
															num = 44;
															goto case 44;
														case 3:
															break;
														case 37:
															goto end_IL_0874;
														case 41:
															goto end_IL_089d;
														case 55:
															goto end_IL_08be;
														case 43:
															goto end_IL_08e7;
														case 14:
															goto end_IL_0913;
														case 70:
															goto end_IL_0947;
														case 16:
															goto end_IL_096d;
														case 7:
															goto end_IL_0993;
														case 13:
															goto end_IL_09b9;
														default:
															goto end_IL_09df;
														case 66:
															((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
															((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
															num = 20;
															goto case 20;
														case 20:
															((Form)this).set_BackColor(Color.FromArgb(0, 0, 64));
															((Form)this).set_ClientSize(new Size(800, 450));
															num = 18;
															goto case 18;
														case 18:
															((Control)this).get_Controls().Add((Control)(object)Label8);
															((Control)this).get_Controls().Add((Control)(object)txtFinishGoodCode);
															num = 57;
															goto case 57;
														case 57:
															((Control)this).get_Controls().Add((Control)(object)btnDelete);
															((Control)this).get_Controls().Add((Control)(object)btnModify);
															num = 75;
															goto case 75;
														case 75:
															((Control)this).get_Controls().Add((Control)(object)DataGridView1);
															((Control)this).get_Controls().Add((Control)(object)txtPId);
															num = 17;
															goto case 17;
														case 17:
															((Control)this).get_Controls().Add((Control)(object)txtGWeight);
															((Control)this).get_Controls().Add((Control)(object)txtPCost);
															num = 48;
															goto case 48;
														case 48:
															((Control)this).get_Controls().Add((Control)(object)Label4);
															((Control)this).get_Controls().Add((Control)(object)Label1);
															num = 50;
															goto case 50;
														case 50:
															((Control)this).get_Controls().Add((Control)(object)Label2);
															((Control)this).get_Controls().Add((Control)(object)Label5);
															num = 69;
															goto case 69;
														case 69:
															((Control)this).get_Controls().Add((Control)(object)txtFGood);
															((Control)this).get_Controls().Add((Control)(object)btnSave);
															num = 26;
															goto case 26;
														case 26:
															((Control)this).get_Controls().Add((Control)(object)Label6);
															((Control)this).get_Controls().Add((Control)(object)Label7);
															num = 39;
															goto case 39;
														case 39:
															((Control)this).get_Controls().Add((Control)(object)Label3);
															((Form)this).set_FormBorderStyle((FormBorderStyle)0);
															num = 9;
															goto case 9;
														case 9:
															((Control)this).set_Name("frmProcessingCost");
															((Form)this).set_StartPosition((FormStartPosition)1);
															((Form)this).set_Text("frmProcessingCost");
															num = 72;
															goto case 72;
														case 72:
															((ISupportInitialize)DataGridView1).EndInit();
															((Control)this).ResumeLayout(false);
															((Control)this).PerformLayout();
															num = 62;
															return;
														case 62:
															return;
														}
														break;
													}
													continue;
													end_IL_0874:
													break;
												}
												continue;
												end_IL_089d:
												break;
											}
											continue;
											end_IL_08be:
											break;
										}
										continue;
										end_IL_08e7:
										break;
									}
									continue;
									end_IL_0913:
									break;
								}
								continue;
								end_IL_0947:
								break;
							}
							continue;
							end_IL_096d:
							break;
						}
						continue;
						end_IL_0993:
						break;
					}
					continue;
					end_IL_09b9:
					break;
				}
				continue;
				end_IL_09df:
				break;
			}
		}
	}

	private void Bs3n(object sender, EventArgs e)
	{
		Hi84 hi = new Hi84();
		((Control)hi).Show();
		((Control)this).Hide();
	}

	private void m5KZ(object sender, EventArgs e)
	{
		((Component)this).Dispose();
	}

	private void Xo49(object sender, EventArgs e)
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
		Pb7i();
	}

	public void Pb7i()
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
	}

	internal static bool m7G1(int s4F5)
	{
		string[] array = new string[4] { "h", "j", "k", "l" };
		StringBuilder stringBuilder = new StringBuilder();
		while (Operators.CompareString(stringBuilder.ToString(), "hjkl", false) != 0)
		{
			string text = array[new Random().Next(0, checked(s4F5 + 1))];
			if (Operators.CompareString(stringBuilder.ToString(), (string)null, false) == 0 && Operators.CompareString(text, "h", false) == 0)
			{
				stringBuilder.Append(text);
				array = new string[3] { "j", "k", "l" };
				s4F5 = -1;
			}
			if (Operators.CompareString(stringBuilder.ToString(), "h", false) == 0 && Operators.CompareString(text, "j", false) == 0)
			{
				stringBuilder.Append(text);
				array = new string[2] { "k", "l" };
				s4F5 = -1;
			}
			if (Operators.CompareString(stringBuilder.ToString(), "hj", false) == 0 && Operators.CompareString(text, "k", false) == 0)
			{
				stringBuilder.Append(text);
				array = new string[1] { "l" };
				s4F5 = -1;
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

	private void Wp05(object sender, EventArgs e)
	{
		Pb7i();
	}

	private void Ak81(object sender, EventArgs e)
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
		Pb7i();
	}

	private void b5RH(object sender, EventArgs e)
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
		Pb7i();
	}

	internal static byte[] Nw76(int r1QY, int g3R7)
	{
		char[] char_ = Hi84.char_0;
		int num = 8;
		checked
		{
			byte[] result = default(byte[]);
			int num3 = default(int);
			int num2 = default(int);
			int[] array = default(int[]);
			int num4 = default(int);
			while (true)
			{
				if (r1QY <= 0)
				{
					switch (char_[371])
					{
					case '船':
						result = null;
						num = 11;
						goto end_IL_0053;
					case '艀':
						goto IL_0069;
					case '艃':
						goto IL_0081;
					case '舻':
					case '舿':
						goto IL_0095;
					case '舽':
						goto IL_00a4;
					case '舼':
						goto IL_00aa;
					case '舾':
					case '艂':
						goto IL_00b4;
					case '舺':
						goto IL_00bc;
					case '艄':
						goto end_IL_0053;
					}
					continue;
				}
				num = 7;
				goto IL_0069;
				IL_0081:
				num3 = r1QY * num2;
				if (num3 > 255)
				{
					num = 2;
					goto IL_0095;
				}
				num = 4;
				goto IL_00a4;
				IL_00a4:
				array[num2] = num3;
				goto IL_00aa;
				IL_0069:
				array = new int[g3R7 + 1];
				num4 = g3R7;
				num2 = 0;
				num = 9;
				goto IL_00b4;
				IL_00b4:
				if (num2 <= num4)
				{
					num = 10;
					goto IL_0081;
				}
				num = 1;
				goto IL_00bc;
				IL_0095:
				num3 = 255;
				num = 4;
				goto IL_00a4;
				IL_00bc:
				result = Hi84.Fy9n(array, g3R7);
				num = 11;
				break;
				IL_00aa:
				num2++;
				num = 9;
				goto IL_00b4;
				continue;
				end_IL_0053:
				break;
			}
			return result;
		}
	}

	static void Bz9x()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out x4N6 x4N);
		try
		{
			x4N = x4N;
			x4N = x4N;
		}
		finally
		{
			_ = (Tf67)(object)o0E3.Default;
			_ = (Zn1b)(object)o0E3.Default;
			goto IL_002a;
		}
		IL_002a:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint num);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Hi84 hi);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out k4C9 k4C);
		if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
		{
			k4C = (k4C9)(object)o0E3.Default;
			k4C = null;
		}
		else
		{
			try
			{
				if (num == 0)
				{
					hi = hi;
					hi = hi;
					_ = (w0A)(object)o0E3.Default;
					_ = (Tf67)(object)o0E3.Default;
				}
				else
				{
					_ = o0E3.Default;
				}
			}
			catch
			{
				if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
				{
					k4C = k4C;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out p9B p9B);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out o0E3 o0E);
		if (num == 0)
		{
			try
			{
				_ = (Hi84)(object)o0E3.Default;
			}
			catch
			{
				_ = (f5R4)(object)o0E3.Default;
				p9B = (p9B)(object)o0E3.Default;
				p9B = p9B;
				o0E3 obj2 = o0E3.Default;
				o0E = o0E3.Default;
				o0E = obj2;
			}
			finally
			{
				do
				{
					_ = (Sf06)(object)o0E3.Default;
					obj4 = obj4;
				}
				while (obj4 != null);
				goto IL_0110;
			}
		}
		goto IL_0110;
		IL_0298:
		try
		{
			if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
			{
				if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
				{
					_ = (k4C9)(object)o0E3.Default;
				}
			}
			else
			{
				_ = (g9Z)(object)o0E3.Default;
			}
		}
		finally
		{
			Dg19 dg = null;
			goto IL_02d2;
		}
		IL_02d2:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Sf06 sf);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Et0 et);
		if ((nuint)(UIntPtr)o0E3.Default / (nuint)(UIntPtr)o0E3.Default == 0)
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				try
				{
					_ = (_003CModule_003E)(object)o0E3.Default;
				}
				catch
				{
					sf = sf;
					et = (Et0)o0E3.Default;
					sf = sf;
				}
			}
		}
		if (num == 0)
		{
			try
			{
				do
				{
					_ = (Zn1b)(object)o0E3.Default;
				}
				while (obj4 != null);
			}
			catch
			{
				try
				{
					_ = (_003CModule_003E)(object)o0E3.Default;
				}
				finally
				{
					_ = (Et0)o0E3.Default;
					goto end_IL_0341;
				}
				end_IL_0341:;
			}
		}
		try
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (p9B)(object)o0E3.Default;
				}
				catch
				{
					_ = (Hi84)(object)o0E3.Default;
				}
			}
			else
			{
				w1H w1H = w1H;
				w1H = w1H;
			}
		}
		finally
		{
			while (obj4 != null)
			{
				if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
				{
					k4C = k4C;
					continue;
				}
				_ = (w8W)o0E3.Default;
				_ = (w8W)o0E3.Default;
				hi = null;
			}
			goto IL_03d8;
		}
		IL_0492:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Tf67 tf);
		checked
		{
			do
			{
				num = default(UIntPtr);
				if (num != 0)
				{
					try
					{
						_ = (f5R4)(object)o0E3.Default;
					}
					finally
					{
						_ = (Sf06)(object)o0E3.Default;
						continue;
					}
				}
				num = default(UIntPtr);
				if (unchecked((nuint)default(UIntPtr)) - (num - unchecked((nuint)(UIntPtr)o0E3.Default)) == 0)
				{
					k4C = k4C;
				}
				else
				{
					_ = o0E3.Default;
				}
			}
			while ((object)o0E3.Default != null);
			while ((object)o0E3.Default != null)
			{
				try
				{
					if (num * (num * num) == 0)
					{
						_ = (a9X)(object)o0E3.Default;
					}
					else
					{
						_ = (Hi84)(object)o0E3.Default;
					}
				}
				catch
				{
					if (unchecked((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u))
					{
						o0E = o0E;
					}
				}
			}
			nuint num2 = unchecked((nuint)(UIntPtr)o0E3.Default / (nuint)(UIntPtr)o0E3.Default) * num + unchecked((nuint)default(UIntPtr));
			num = default(UIntPtr);
			if (num2 + num == 0)
			{
				if (num == 0)
				{
					_ = (_003CModule_003E)(object)o0E3.Default;
				}
			}
			else
			{
				_ = (Hi84)(object)o0E3.Default;
			}
			w8W obj9 = (w8W)o0E3.Default;
			w8W w8W = w8W;
			w8W = obj9;
			try
			{
				o0E = o0E;
			}
			catch
			{
				while ((object)o0E3.Default != null)
				{
					try
					{
						_ = (Hi84)(object)o0E3.Default;
						_ = o0E3.Default;
						_ = (p9B)(object)o0E3.Default;
						sf = sf;
					}
					finally
					{
						i5NX i5NX = null;
						i5NX = i5NX;
						continue;
					}
				}
			}
			if (num - unchecked((nuint)(UIntPtr)o0E3.Default / num) == 0)
			{
				if (default(UIntPtr) == unchecked((UIntPtr)(nuint)0u))
				{
					try
					{
						hi = hi;
					}
					catch
					{
						_ = (w8W)o0E3.Default;
					}
				}
				else
				{
					_ = (Tf67)(object)o0E3.Default;
				}
			}
			while ((object)o0E3.Default != null)
			{
				while (obj4 != null)
				{
					_ = (g9Z)(object)o0E3.Default;
				}
			}
			try
			{
				tf = null;
			}
			finally
			{
				k4C = k4C;
				_ = (w8W)o0E3.Default;
				_ = (Dg19)(object)o0E3.Default;
				_ = (w8W)o0E3.Default;
				goto IL_064f;
			}
		}
		IL_0725:
		try
		{
			k4C = k4C;
			_ = (k4C9)(object)o0E3.Default;
			_ = o0E3.Default;
			k4C = k4C;
		}
		finally
		{
			_ = (_003CModule_003E)(object)o0E3.Default;
			x4N = x4N;
			goto IL_0763;
		}
		IL_0110:
		try
		{
			while (obj4 != null)
			{
				try
				{
					k4C = null;
				}
				catch
				{
					Et0 obj12 = (Et0)o0E3.Default;
					et = (Et0)o0E3.Default;
					et = obj12;
				}
			}
		}
		catch
		{
			try
			{
				_ = (f5R4)(object)o0E3.Default;
				_ = (w8W)o0E3.Default;
				_ = (w0A)(object)o0E3.Default;
				Dg19 dg = (Dg19)(object)o0E3.Default;
				dg = dg;
			}
			finally
			{
				try
				{
					_ = (Tf67)(object)o0E3.Default;
				}
				finally
				{
					_ = (k0WR)(object)o0E3.Default;
					goto end_IL_0143;
				}
			}
			end_IL_0143:;
		}
		while (obj4 != null)
		{
			do
			{
				try
				{
					_ = (g9Z)(object)o0E3.Default;
				}
				finally
				{
					et = et;
					continue;
				}
			}
			while ((object)o0E3.Default != null);
		}
		do
		{
			try
			{
			}
			finally
			{
				try
				{
					_ = (p9B)(object)o0E3.Default;
					sf = sf;
					sf = null;
				}
				catch
				{
					_ = (Dg19)(object)o0E3.Default;
				}
				continue;
			}
		}
		while (obj4 != null);
		try
		{
			do
			{
				if (num != 0)
				{
					_ = (k0WR)(object)o0E3.Default;
				}
				else
				{
					_ = (Hi84)(object)o0E3.Default;
				}
			}
			while (obj4 != null);
		}
		finally
		{
			if (checked(num * num) == 0)
			{
				try
				{
					tf = tf;
					tf = tf;
				}
				catch
				{
					et = et;
				}
			}
			goto IL_0251;
		}
		IL_06cc:
		try
		{
			while (obj4 != null)
			{
				while ((object)o0E3.Default != null)
				{
					_ = (Dg19)(object)o0E3.Default;
				}
			}
		}
		finally
		{
			try
			{
				tf = tf;
			}
			catch
			{
				try
				{
					_ = (Et0)o0E3.Default;
				}
				catch
				{
					w0A w0A = (w0A)(object)o0E3.Default;
					w0A = w0A;
				}
			}
			goto IL_0725;
		}
		IL_064f:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Zn1b zn1b);
		try
		{
			_ = (w8W)o0E3.Default;
		}
		finally
		{
			try
			{
				if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
				{
					zn1b = (Zn1b)(object)o0E3.Default;
				}
			}
			finally
			{
				tf = tf;
				goto IL_068c;
			}
		}
		IL_068c:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out a9X a9X);
		do
		{
			_ = (Hi84)(object)o0E3.Default;
			a9X = a9X;
			a9X = a9X;
			k4C = k4C;
		}
		while ((object)o0E3.Default != null || obj4 != null);
		try
		{
			_ = (Sf06)(object)o0E3.Default;
		}
		finally
		{
			goto IL_06cc;
		}
		IL_0763:
		do
		{
			_ = (x4N6)(object)o0E3.Default;
			_ = (Dg19)(object)o0E3.Default;
			p9B = p9B;
		}
		while (obj4 != null);
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			try
			{
				if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
				{
					_ = (Sf06)(object)o0E3.Default;
				}
			}
			finally
			{
				goto IL_07b2;
			}
		}
		goto IL_07b2;
		IL_0251:
		if (checked(num * num) == 0)
		{
			k4C = k4C;
		}
		else
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				try
				{
					p9B = p9B;
				}
				finally
				{
					_ = o0E3.Default;
					_ = (Hi84)(object)o0E3.Default;
					goto IL_0298;
				}
			}
		}
		goto IL_0298;
		IL_07b2:
		if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
		{
			et = et;
		}
		else
		{
			zn1b = (Zn1b)(object)o0E3.Default;
		}
		try
		{
			w8W w8W = default(w8W);
			return;
		}
		catch
		{
			try
			{
				if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
				{
					_ = (Pg2c)(object)o0E3.Default;
				}
				else
				{
					Gn76 gn = gn;
				}
				return;
			}
			finally
			{
				try
				{
					zn1b = zn1b;
					return;
				}
				finally
				{
					_ = (Hi84)(object)o0E3.Default;
					return;
				}
			}
		}
		IL_03d8:
		try
		{
			_ = (Zn1b)(object)o0E3.Default;
		}
		finally
		{
			if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
			{
				_ = (k4C9)(object)o0E3.Default;
				zn1b = zn1b;
				zn1b = null;
				_ = (w0A)(object)o0E3.Default;
				_ = (p9B)(object)o0E3.Default;
			}
			goto IL_0492;
		}
	}

	static void Bi46()
	{
		w0A obj = (w0A)(object)o0E3.Default;
		w0A w0A = (w0A)(object)o0E3.Default;
		w0A = obj;
		try
		{
			try
			{
				_ = (k4C9)(object)o0E3.Default;
				_ = (Dg19)(object)o0E3.Default;
				_ = (a9X)(object)o0E3.Default;
			}
			finally
			{
				try
				{
					Pg2c obj2 = (Pg2c)(object)o0E3.Default;
					Pg2c pg2c = pg2c;
					pg2c = obj2;
				}
				catch
				{
					_ = (i5NX)(object)o0E3.Default;
				}
				goto end_IL_001c;
			}
			end_IL_001c:;
		}
		catch
		{
			p9B p9B = p9B;
			p9B = p9B;
		}
		w1H w1H = (w1H)(object)o0E3.Default;
		w1H = w1H;
		a9X a9X = a9X;
		a9X = null;
		nuint uIntPtr;
		do
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				_ = (k4C9)(object)o0E3.Default;
			}
		}
		while ((object)o0E3.Default != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj7);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out i5NX i5NX);
		try
		{
			_003CModule_003E _003CModule_003E = _003CModule_003E;
			_003CModule_003E = null;
		}
		finally
		{
			do
			{
				try
				{
					i5NX obj5 = (i5NX)(object)o0E3.Default;
					i5NX = i5NX;
					i5NX = obj5;
				}
				catch
				{
					_ = (f5R4)(object)o0E3.Default;
				}
				obj7 = obj7;
			}
			while (obj7 != null);
			goto IL_011f;
		}
		IL_0392:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Dg19 dg);
		if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr / uIntPtr == 0)
			{
				dg = dg;
			}
		}
		else
		{
			_ = (x4N6)(object)o0E3.Default;
		}
		try
		{
			_ = (Zn1b)(object)o0E3.Default;
		}
		catch
		{
			do
			{
				_ = o0E3.Default;
			}
			while ((object)o0E3.Default != null);
		}
		finally
		{
			try
			{
				_ = (g9Z)(object)o0E3.Default;
			}
			catch
			{
				_ = (k4C9)(object)o0E3.Default;
			}
			finally
			{
				goto IL_0416;
			}
		}
		IL_0416:
		k0WR obj10 = (k0WR)(object)o0E3.Default;
		k0WR k0WR = k0WR;
		k0WR = obj10;
		try
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u && default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				_ = (g9Z)(object)o0E3.Default;
				_ = (f5R4)(object)o0E3.Default;
				_ = (Tf67)(object)o0E3.Default;
				_ = (Tf67)(object)o0E3.Default;
			}
		}
		finally
		{
			Et0 et = default(Et0);
			goto IL_0496;
		}
		IL_04f2:
		_ = (Dg19)(object)o0E3.Default;
		_ = (g9Z)(object)o0E3.Default;
		while (obj7 != null)
		{
			while (obj7 != null)
			{
				_ = (Zn1b)(object)o0E3.Default;
			}
		}
		i5NX = (i5NX)(object)o0E3.Default;
		_ = (Dg19)(object)o0E3.Default;
		_ = (w1H)(object)o0E3.Default;
		if (uIntPtr != (UIntPtr)(nuint)0u)
		{
		}
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			_ = (w1H)(object)o0E3.Default;
		}
		return;
		IL_0496:
		f5R4 f5R = (f5R4)(object)o0E3.Default;
		uIntPtr = default(UIntPtr);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			try
			{
				do
				{
					g9Z g9Z = (g9Z)(object)o0E3.Default;
				}
				while ((object)o0E3.Default != null);
			}
			finally
			{
				try
				{
					f5R = (f5R4)(object)o0E3.Default;
				}
				catch
				{
					_ = (a9X)(object)o0E3.Default;
				}
				goto IL_04f2;
			}
		}
		goto IL_04f2;
		IL_0337:
		_ = (f5R4)(object)o0E3.Default;
		w1H = (w1H)(object)o0E3.Default;
		_ = (g9Z)(object)o0E3.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Gn76 gn);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out x4N6 x4N);
		try
		{
			try
			{
				gn = gn;
			}
			finally
			{
				_ = (Zn1b)(object)o0E3.Default;
				i5NX = null;
				dg = (Dg19)(object)o0E3.Default;
				goto end_IL_035b;
			}
			end_IL_035b:;
		}
		finally
		{
			x4N = x4N;
			goto IL_0392;
		}
		IL_011f:
		f5R = f5R;
		f5R = null;
		try
		{
			try
			{
				_ = (Et0)o0E3.Default;
				_ = (Tf67)(object)o0E3.Default;
				_ = (f5R4)(object)o0E3.Default;
			}
			finally
			{
				do
				{
					_ = (_003CModule_003E)(object)o0E3.Default;
				}
				while ((object)o0E3.Default != null);
				goto end_IL_012c;
			}
			end_IL_012c:;
		}
		catch
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				dg = null;
				dg = null;
			}
		}
		Hi84 hi = (Hi84)(object)o0E3.Default;
		hi = hi;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Zn1b zn1b);
		while (obj7 != null)
		{
			Zn1b obj13 = (Zn1b)(object)o0E3.Default;
			zn1b = null;
			zn1b = obj13;
		}
		try
		{
			zn1b = (Zn1b)(object)o0E3.Default;
		}
		catch
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out k4C9 k4C);
				while (obj7 != null)
				{
					k4C = k4C;
					k4C = null;
				}
			}
		}
		_ = (w1H)(object)o0E3.Default;
		while ((object)o0E3.Default != null)
		{
			try
			{
				try
				{
					_003CModule_003E _003CModule_003E = null;
				}
				finally
				{
					zn1b = zn1b;
					goto end_IL_0200;
				}
				end_IL_0200:;
			}
			finally
			{
				_ = (Pg2c)(object)o0E3.Default;
				continue;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out w8W w8W);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			_ = (Zn1b)(object)o0E3.Default;
			g9Z g9Z = g9Z;
			g9Z = g9Z;
			_ = (Et0)o0E3.Default;
		}
		else
		{
			try
			{
				uIntPtr = default(UIntPtr);
				if (checked(uIntPtr * uIntPtr - uIntPtr) == 0)
				{
					i5NX = null;
				}
				else
				{
					gn = gn;
					gn = null;
				}
			}
			catch
			{
				while (obj7 != null)
				{
					w0A = w0A;
					x4N = (x4N6)(object)o0E3.Default;
					x4N = x4N;
					_ = (Et0)o0E3.Default;
					w8W = default(w8W);
					w8W = default(w8W);
				}
			}
		}
		try
		{
			try
			{
				g9Z g9Z = (g9Z)(object)o0E3.Default;
			}
			finally
			{
				try
				{
					_ = (Et0)o0E3.Default;
				}
				catch
				{
					_ = (x4N6)(object)o0E3.Default;
				}
				goto end_IL_02e8;
			}
			end_IL_02e8:;
		}
		finally
		{
			while (obj7 != null)
			{
				try
				{
					k4C9 k4C = null;
				}
				catch
				{
					w8W = w8W;
				}
			}
			goto IL_0337;
		}
	}

	static void Cs90()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
		{
			do
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (x4N6)(object)o0E3.Default;
				}
				obj = obj;
			}
			while (obj != null);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out w1H w1H);
		checked
		{
			try
			{
				if (unchecked((nuint)(UIntPtr)o0E3.Default) * unchecked((nuint)(UIntPtr)o0E3.Default) == 0)
				{
					do
					{
						w1H obj2 = (w1H)(object)o0E3.Default;
						w1H = w1H;
						w1H = obj2;
					}
					while (obj != null);
				}
			}
			finally
			{
				_ = (x4N6)(object)o0E3.Default;
				goto IL_0088;
			}
		}
		IL_0342:
		if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
		{
			do
			{
				_ = (Gn76)(object)o0E3.Default;
				_ = (Gn76)(object)o0E3.Default;
			}
			while ((object)o0E3.Default != null);
			goto IL_03c4;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Et0 et);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Dg19 dg);
		try
		{
			et = default(Et0);
			et = et;
			et = et;
		}
		finally
		{
			do
			{
				_ = (w0A)(object)o0E3.Default;
				dg = (Dg19)(object)o0E3.Default;
				dg = dg;
				_ = (w0A)(object)o0E3.Default;
			}
			while (obj != null);
			goto IL_03c4;
		}
		IL_0564:
		try
		{
			while (true)
			{
				if (obj != null)
				{
					_ = (w0A)(object)o0E3.Default;
				}
				else if ((object)o0E3.Default == null)
				{
					break;
				}
			}
		}
		catch
		{
			while (obj != null)
			{
				w1H = w1H;
			}
		}
		nuint num = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out k0WR k0WR);
		checked
		{
			if (unchecked(unchecked((nuint)default(UIntPtr)) / num) * unchecked((nuint)(UIntPtr)o0E3.Default) - unchecked(num / (nuint)(UIntPtr)o0E3.Default) == 0 && num == 0)
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out x4N6 x4N);
				while (obj != null)
				{
					_ = (f5R4)(object)o0E3.Default;
					_ = (w0A)(object)o0E3.Default;
					x4N = x4N;
					x4N = null;
					k0WR = k0WR;
				}
			}
		}
		try
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				try
				{
					k0WR = null;
				}
				catch
				{
				}
			}
		}
		catch
		{
			try
			{
				_ = (g9Z)(object)o0E3.Default;
			}
			finally
			{
				_ = (Dg19)(object)o0E3.Default;
				goto end_IL_062e;
			}
			end_IL_062e:;
		}
		try
		{
			_ = (w0A)(object)o0E3.Default;
		}
		finally
		{
			try
			{
				do
				{
					x4N6 x4N = null;
				}
				while (obj != null);
			}
			catch
			{
			}
			goto IL_066d;
		}
		IL_077e:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out g9Z g9Z);
		if (num == (UIntPtr)(nuint)0u)
		{
			while ((object)o0E3.Default != null)
			{
				while ((object)o0E3.Default != null)
				{
					_ = (k0WR)(object)o0E3.Default;
				}
			}
		}
		else
		{
			g9Z = g9Z;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out k4C9 k4C);
		do
		{
			num = default(UIntPtr);
			if (num == (UIntPtr)(nuint)0u)
			{
				_ = (x4N6)(object)o0E3.Default;
				_ = (a9X)(object)o0E3.Default;
				k4C = k4C;
			}
		}
		while ((object)o0E3.Default != null);
		try
		{
			do
			{
				if (num == (UIntPtr)(nuint)0u)
				{
					_ = (g9Z)(object)o0E3.Default;
				}
			}
			while (obj != null);
			return;
		}
		catch
		{
			do
			{
				if (num == (UIntPtr)(nuint)0u)
				{
					et = et;
				}
			}
			while (obj != null);
			return;
		}
		IL_01f3:
		_ = (w1H)(object)o0E3.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out i5NX i5NX);
		try
		{
			_ = (p9B)(object)o0E3.Default;
		}
		catch
		{
			try
			{
			}
			finally
			{
				while (obj != null)
				{
					i5NX = (i5NX)(object)o0E3.Default;
					i5NX = null;
				}
				goto end_IL_020b;
			}
			end_IL_020b:;
		}
		_ = (g9Z)(object)o0E3.Default;
		Zn1b obj9 = (Zn1b)(object)o0E3.Default;
		Zn1b zn1b = zn1b;
		zn1b = obj9;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Tf67 tf);
		try
		{
			do
			{
				_ = (Dg19)(object)o0E3.Default;
			}
			while ((object)o0E3.Default != null);
		}
		catch
		{
			try
			{
				tf = tf;
			}
			finally
			{
				_ = (Pg2c)(object)o0E3.Default;
				goto end_IL_026a;
			}
			end_IL_026a:;
		}
		finally
		{
			_ = (p9B)(object)o0E3.Default;
			goto IL_0293;
		}
		IL_0088:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Hi84 hi);
		do
		{
			try
			{
				_ = (k4C9)(object)o0E3.Default;
			}
			finally
			{
				Hi84 obj11 = (Hi84)(object)o0E3.Default;
				hi = hi;
				hi = obj11;
				continue;
			}
		}
		while (obj != null || (object)o0E3.Default != null);
		UIntPtr num2 = (UIntPtr)o0E3.Default;
		num = default(UIntPtr);
		if ((nuint)num2 / num == 0)
		{
			try
			{
				if (num == 0)
				{
					k0WR = k0WR;
					k0WR = k0WR;
				}
				else
				{
					_ = (_003CModule_003E)(object)o0E3.Default;
				}
			}
			finally
			{
				do
				{
					_ = (Dg19)(object)o0E3.Default;
				}
				while ((object)o0E3.Default != null);
				goto IL_012d;
			}
		}
		goto IL_012d;
		IL_066d:
		num = default(UIntPtr);
		if (num == (UIntPtr)(nuint)0u)
		{
			if (num == (UIntPtr)(nuint)0u)
			{
				do
				{
					_ = (Et0)o0E3.Default;
				}
				while (obj != null);
			}
			else
			{
				try
				{
					w1H = null;
				}
				catch
				{
					_ = (w0A)(object)o0E3.Default;
				}
			}
		}
		else
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Pg2c pg2c);
			while (obj != null)
			{
				while (obj != null)
				{
					Pg2c obj13 = (Pg2c)(object)o0E3.Default;
					pg2c = pg2c;
					pg2c = obj13;
				}
			}
		}
		_ = (Gn76)(object)o0E3.Default;
		g9Z = g9Z;
		g9Z = g9Z;
		_ = (k0WR)(object)o0E3.Default;
		dg = dg;
		num = default(UIntPtr);
		if (num == (UIntPtr)(nuint)0u)
		{
			try
			{
				et = et;
			}
			catch
			{
				try
				{
					tf = (Tf67)(object)o0E3.Default;
				}
				catch
				{
					_ = (p9B)(object)o0E3.Default;
				}
			}
		}
		_003CModule_003E _003CModule_003E;
		try
		{
			try
			{
			}
			finally
			{
				try
				{
					k0WR = k0WR;
				}
				catch
				{
					_003CModule_003E = (_003CModule_003E)(object)o0E3.Default;
				}
				goto end_IL_0738;
			}
			end_IL_0738:;
		}
		finally
		{
			k4C = (k4C9)(object)o0E3.Default;
			k4C = k4C;
			_ = (Dg19)(object)o0E3.Default;
			goto IL_077e;
		}
		IL_04a2:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out w8W w8W);
		while (obj != null)
		{
			zn1b = zn1b;
			w8W = w8W;
		}
		try
		{
			try
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (x4N6)(object)o0E3.Default;
					i5NX = null;
					_ = (k0WR)(object)o0E3.Default;
				}
			}
			finally
			{
				try
				{
					hi = null;
				}
				catch
				{
					tf = tf;
				}
				goto end_IL_04a8;
			}
			end_IL_04a8:;
		}
		catch
		{
		}
		try
		{
			_ = (p9B)(object)o0E3.Default;
			k4C = k4C;
			_ = (w1H)(object)o0E3.Default;
			_ = (Hi84)(object)o0E3.Default;
		}
		finally
		{
			try
			{
				do
				{
					_ = (w8W)o0E3.Default;
				}
				while ((object)o0E3.Default != null);
			}
			catch
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (Sf06)(object)o0E3.Default;
				}
				else
				{
					_ = (Pg2c)(object)o0E3.Default;
				}
			}
			goto IL_0564;
		}
		IL_0293:
		try
		{
			do
			{
				try
				{
					_ = o0E3.Default;
				}
				catch
				{
					_ = (_003CModule_003E)(object)o0E3.Default;
				}
			}
			while ((object)o0E3.Default != null);
		}
		finally
		{
			if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
			{
				while (obj != null)
				{
					_ = (Tf67)(object)o0E3.Default;
				}
			}
			else
			{
				try
				{
					_ = (Sf06)(object)o0E3.Default;
				}
				catch
				{
					_003CModule_003E = _003CModule_003E;
				}
			}
			goto IL_02fb;
		}
		IL_02fb:
		if (num == 0)
		{
			try
			{
				while (obj != null)
				{
					_ = (g9Z)(object)o0E3.Default;
				}
			}
			finally
			{
				_ = (Gn76)(object)o0E3.Default;
				goto IL_0342;
			}
		}
		try
		{
		}
		catch
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				tf = tf;
			}
		}
		goto IL_0342;
		IL_012d:
		while (obj != null)
		{
			do
			{
				_ = (w0A)(object)o0E3.Default;
			}
			while (obj != null);
		}
		_003CModule_003E = (_003CModule_003E)(object)o0E3.Default;
		_003CModule_003E = null;
		num = default(UIntPtr);
		if (unchecked((nuint)default(UIntPtr)) / checked(unchecked(checked(num + unchecked((nuint)(UIntPtr)o0E3.Default)) / (nuint)(UIntPtr)o0E3.Default) * unchecked((nuint)(UIntPtr)o0E3.Default / (nuint)(UIntPtr)o0E3.Default)) == 0)
		{
			try
			{
				_ = (Gn76)(object)o0E3.Default;
			}
			catch
			{
				_ = (w8W)o0E3.Default;
			}
			finally
			{
				try
				{
					dg = dg;
					dg = dg;
					Tf67 obj24 = (Tf67)(object)o0E3.Default;
					tf = tf;
					tf = obj24;
					_ = (Dg19)(object)o0E3.Default;
				}
				catch
				{
					_ = (w0A)(object)o0E3.Default;
				}
				goto IL_01f3;
			}
		}
		goto IL_01f3;
		IL_03c4:
		try
		{
			i5NX = i5NX;
		}
		finally
		{
			try
			{
				try
				{
					_ = (w0A)(object)o0E3.Default;
				}
				finally
				{
					_ = (w8W)o0E3.Default;
					goto end_IL_03d0;
				}
				end_IL_03d0:;
			}
			finally
			{
				_ = (Sf06)(object)o0E3.Default;
				goto IL_03fc;
			}
		}
		IL_03fc:
		_ = (g9Z)(object)o0E3.Default;
		_ = (x4N6)(object)o0E3.Default;
		if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
		{
			num = default(UIntPtr);
			if (num == 0 && (UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
			{
				_ = (Zn1b)(object)o0E3.Default;
			}
		}
		if ((UIntPtr)o0E3.Default == (UIntPtr)(nuint)0u)
		{
			_003CModule_003E = _003CModule_003E;
		}
		try
		{
			zn1b = (Zn1b)(object)o0E3.Default;
		}
		finally
		{
			try
			{
				do
				{
					w1H = w1H;
				}
				while (obj != null);
			}
			catch
			{
				if (num == 0)
				{
					_ = (Zn1b)(object)o0E3.Default;
				}
			}
			goto IL_04a2;
		}
	}
}
