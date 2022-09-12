using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Ax2;
using Bb3;
using Cx7;
using Fz5;
using Hf5i;
using Lc3;
using Ln6;
using Mf0;
using Microsoft.VisualBasic.CompilerServices;
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

namespace Pc8;

[DesignerGenerated]
public class Bj2 : Form
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
			EventHandler eventHandler = q9L;
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
				Pr5.byte_0[444] = (byte)(Pr5.byte_0[444] & b4C0.char_0[48] & 0x8C);
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
			EventHandler eventHandler = Zs5;
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
			EventHandler eventHandler = m9J;
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
			EventHandler eventHandler = We3;
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
			char[] char_ = b4C0.char_0;
			int num = 6;
			while (true)
			{
				EventHandler eventHandler = Zj7;
				while (true)
				{
					Button val = _btnSave;
					if (val == null)
					{
						switch (char_[276])
						{
						case '涫':
							break;
						default:
							goto end_IL_0042;
						case '涧':
							goto IL_005f;
						case '涭':
							goto IL_0066;
						case '涪':
							goto IL_006d;
						case '润':
						case '涨':
							goto IL_0079;
						case '涩':
							return;
						}
						continue;
					}
					num = 1;
					goto IL_005f;
					IL_006d:
					val = _btnSave;
					if (val != null)
					{
						num = 2;
						goto IL_0079;
					}
					num = 3;
					return;
					IL_0079:
					((Control)val).add_Click(eventHandler);
					return;
					IL_005f:
					((Control)val).remove_Click(eventHandler);
					goto IL_0066;
					IL_0066:
					_btnSave = value;
					goto IL_006d;
					continue;
					end_IL_0042:
					break;
				}
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

	public Bj2()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)a9D);
		cs = "Data Source=DESKTOP-1L8UME0\\SQLEXPRESS;Initial Catalog=db_fabric;Integrated Security=True";
		cn = new SqlConnection(cs);
		cmd = new SqlCommand();
		e5M();
	}

	[DebuggerNonUserCode]
	protected override void x4R(bool Sn7)
	{
		try
		{
			if (Sn7 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Sn7);
		}
	}

	[DebuggerStepThrough]
	private void e5M()
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_028b: Expected O, but got Unknown
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a5: Expected O, but got Unknown
		//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Expected O, but got Unknown
		//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Expected O, but got Unknown
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d6: Expected O, but got Unknown
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e1: Expected O, but got Unknown
		//IL_02e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f0: Expected O, but got Unknown
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Expected O, but got Unknown
		//IL_02fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0306: Expected O, but got Unknown
		//IL_030b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0315: Expected O, but got Unknown
		//IL_0316: Unknown result type (might be due to invalid IL or missing references)
		//IL_0320: Expected O, but got Unknown
		//IL_0321: Unknown result type (might be due to invalid IL or missing references)
		//IL_032b: Expected O, but got Unknown
		//IL_0331: Unknown result type (might be due to invalid IL or missing references)
		//IL_033b: Expected O, but got Unknown
		//IL_033c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0346: Expected O, but got Unknown
		//IL_0347: Unknown result type (might be due to invalid IL or missing references)
		//IL_0351: Expected O, but got Unknown
		//IL_0356: Unknown result type (might be due to invalid IL or missing references)
		//IL_0360: Expected O, but got Unknown
		//IL_0361: Unknown result type (might be due to invalid IL or missing references)
		//IL_036b: Expected O, but got Unknown
		//IL_036c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0376: Expected O, but got Unknown
		//IL_03cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d7: Expected O, but got Unknown
		byte[] byte_ = Pr5.byte_0;
		int num = 74;
		while (true)
		{
			Label3 = new Label();
			Label6 = new Label();
			Label7 = new Label();
			num = 42;
			while (true)
			{
				btnDelete = new Button();
				btnModify = new Button();
				DataGridView1 = new DataGridView();
				num = 8;
				while (true)
				{
					txtPId = new TextBox();
					txtGWeight = new TextBox();
					txtPCost = new TextBox();
					num = 49;
					while (true)
					{
						Label4 = new Label();
						Label1 = new Label();
						Label2 = new Label();
						num = 0;
						while (true)
						{
							Label5 = new Label();
							txtFGood = new TextBox();
							btnSave = new Button();
							num = 5;
							while (true)
							{
								Label8 = new Label();
								txtFinishGoodCode = new TextBox();
								((ISupportInitialize)DataGridView1).BeginInit();
								num = 17;
								while (true)
								{
									((Control)this).SuspendLayout();
									Label3.set_AutoSize(true);
									((Control)Label3).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
									num = (int)byte_[319] / 2;
									while (true)
									{
										switch (num)
										{
										case 67:
											Label6.set_AutoSize(true);
											((Control)Label6).set_BackColor(Color.Blue);
											num = 20;
											goto case 20;
										case 20:
											((Control)Label6).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
											num = 59;
											goto case 59;
										case 59:
											((Control)Label6).set_ForeColor(Color.White);
											((Control)Label6).set_Location(new Point(735, 21));
											num = 55;
											goto case 55;
										case 55:
											((Control)Label6).set_Name("Label6");
											((Control)Label6).set_Size(new Size(18, 17));
											num = byte_[476] - 224;
											continue;
										case 40:
											((Control)Label3).set_ForeColor(Color.White);
											((Control)Label3).set_Location(new Point(326, 21));
											num = 36;
											goto case 36;
										case 36:
											((Control)Label3).set_Name("Label3");
											goto case 39;
										case 39:
											((Control)Label3).set_Size(new Size(125, 17));
											num = 28;
											goto case 28;
										case 28:
											((Control)Label3).set_TabIndex(9);
											Label3.set_Text("Processing Cost");
											num = 67;
											goto case 67;
										case 17:
											break;
										case 5:
											goto end_IL_025c;
										case 0:
											goto end_IL_029a;
										case 49:
											goto end_IL_02c0;
										case 8:
											goto end_IL_02e5;
										case 42:
											goto end_IL_030a;
										default:
											goto end_IL_0330;
										case 24:
											((Control)Label6).set_TabIndex(14);
											Label6.set_Text("X");
											num = 16;
											goto case 16;
										case 16:
											Label7.set_AutoSize(true);
											((Control)Label7).set_BackColor(Color.Blue);
											num = 64;
											goto case 64;
										case 64:
											((Control)Label7).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
											num = 30;
											goto case 30;
										case 30:
											((Control)Label7).set_ForeColor(Color.White);
											((Control)Label7).set_Location(new Point(43, 21));
											num = 19;
											goto case 19;
										case 19:
											((Control)Label7).set_Name("Label7");
											((Control)Label7).set_Size(new Size(92, 17));
											num = 2;
											goto case 2;
										case 2:
											((Control)Label7).set_TabIndex(13);
											goto case 72;
										case 72:
											Label7.set_Text("Go To Main");
											num = 10;
											goto case 10;
										case 10:
											((Control)btnDelete).set_Location(new Point(404, 183));
											((Control)btnDelete).set_Name("btnDelete");
											num = 37;
											goto case 37;
										case 37:
											((Control)btnDelete).set_Size(new Size(75, 31));
											((Control)btnDelete).set_TabIndex(7);
											num = 27;
											goto case 27;
										case 27:
											((ButtonBase)btnDelete).set_Text("DELETE");
											((ButtonBase)btnDelete).set_UseVisualStyleBackColor(true);
											num = 47;
											goto case 47;
										case 47:
											((Control)btnModify).set_Location(new Point(404, 132));
											((Control)btnModify).set_Name("btnModify");
											num = 44;
											goto case 44;
										case 44:
											((Control)btnModify).set_Size(new Size(75, 31));
											((Control)btnModify).set_TabIndex(6);
											num = 11;
											goto case 11;
										case 11:
											((ButtonBase)btnModify).set_Text("MODIFY");
											goto case 63;
										case 63:
											((ButtonBase)btnModify).set_UseVisualStyleBackColor(true);
											num = 34;
											goto case 34;
										case 34:
											DataGridView1.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
											((Control)DataGridView1).set_Location(new Point(87, 232));
											num = 29;
											goto case 29;
										case 29:
											((Control)DataGridView1).set_Name("DataGridView1");
											((Control)DataGridView1).set_Size(new Size(599, 206));
											num = 18;
											goto case 18;
										case 18:
											((Control)DataGridView1).set_TabIndex(25);
											((Control)txtPId).set_Location(new Point(229, 195));
											num = 70;
											goto case 70;
										case 70:
											((Control)txtPId).set_Name("txtPId");
											((Control)txtPId).set_Size(new Size(100, 20));
											num = 12;
											goto case 12;
										case 12:
											((Control)txtPId).set_TabIndex(4);
											((Control)txtGWeight).set_Location(new Point(229, 162));
											num = 7;
											goto case 7;
										case 7:
											((Control)txtGWeight).set_Name("txtGWeight");
											((Control)txtGWeight).set_Size(new Size(100, 20));
											num = 14;
											goto case 14;
										case 14:
											((Control)txtGWeight).set_TabIndex(3);
											((Control)txtPCost).set_Location(new Point(229, 135));
											num = 58;
											goto case 58;
										case 58:
											((Control)txtPCost).set_Name("txtPCost");
											((Control)txtPCost).set_Size(new Size(100, 20));
											num = 65;
											goto case 65;
										case 65:
											((Control)txtPCost).set_TabIndex(2);
											Label4.set_AutoSize(true);
											num = 41;
											goto case 41;
										case 41:
											((Control)Label4).set_ForeColor(Color.White);
											((Control)Label4).set_Location(new Point(108, 169));
											num = 45;
											goto case 45;
										case 45:
											((Control)Label4).set_Name("Label4");
											((Control)Label4).set_Size(new Size(106, 13));
											num = 6;
											goto case 6;
										case 6:
											((Control)Label4).set_TabIndex(21);
											Label4.set_Text("Finish Good Weight :");
											num = 32;
											goto case 32;
										case 32:
											Label1.set_AutoSize(true);
											((Control)Label1).set_ForeColor(Color.White);
											num = 26;
											goto case 26;
										case 26:
											((Control)Label1).set_Location(new Point(104, 108));
											((Control)Label1).set_Name("Label1");
											num = 33;
											goto case 33;
										case 33:
											((Control)Label1).set_Size(new Size(110, 13));
											((Control)Label1).set_TabIndex(20);
											num = 9;
											goto case 9;
										case 9:
											Label1.set_Text("Finish Process Good :");
											Label2.set_AutoSize(true);
											num = 75;
											goto case 75;
										case 75:
											((Control)Label2).set_ForeColor(Color.White);
											((Control)Label2).set_Location(new Point(151, 202));
											num = 46;
											goto case 46;
										case 46:
											((Control)Label2).set_Name("Label2");
											((Control)Label2).set_Size(new Size(63, 13));
											num = 51;
											goto case 51;
										case 51:
											((Control)Label2).set_TabIndex(19);
											Label2.set_Text("Process Id :");
											num = 71;
											goto case 71;
										case 71:
											Label5.set_AutoSize(true);
											((Control)Label5).set_ForeColor(Color.White);
											num = 43;
											goto case 43;
										case 43:
											((Control)Label5).set_Location(new Point(139, 138));
											((Control)Label5).set_Name("Label5");
											num = 56;
											goto case 56;
										case 56:
											((Control)Label5).set_Size(new Size(75, 13));
											((Control)Label5).set_TabIndex(18);
											num = 73;
											goto case 73;
										case 73:
											Label5.set_Text("Process Cost :");
											((Control)txtFGood).set_Location(new Point(229, 105));
											num = 50;
											goto case 50;
										case 50:
											((Control)txtFGood).set_Name("txtFGood");
											((Control)txtFGood).set_Size(new Size(100, 20));
											num = 48;
											goto case 48;
										case 48:
											((Control)txtFGood).set_TabIndex(1);
											((Control)btnSave).set_Location(new Point(404, 72));
											num = 61;
											goto case 61;
										case 61:
											((Control)btnSave).set_Name("btnSave");
											((Control)btnSave).set_Size(new Size(75, 31));
											num = 62;
											goto case 62;
										case 62:
											((Control)btnSave).set_TabIndex(5);
											((ButtonBase)btnSave).set_Text("SAVE");
											num = 68;
											goto case 68;
										case 68:
											((ButtonBase)btnSave).set_UseVisualStyleBackColor(true);
											Label8.set_AutoSize(true);
											num = 69;
											goto case 69;
										case 69:
											((Control)Label8).set_ForeColor(Color.White);
											((Control)Label8).set_Location(new Point(117, 75));
											num = 31;
											goto case 31;
										case 31:
											((Control)Label8).set_Name("Label8");
											((Control)Label8).set_Size(new Size(97, 13));
											num = 52;
											goto case 52;
										case 52:
											((Control)Label8).set_TabIndex(29);
											Label8.set_Text("Finish Good Code :");
											num = 66;
											goto case 66;
										case 66:
											((Control)txtFinishGoodCode).set_Location(new Point(229, 72));
											((Control)txtFinishGoodCode).set_Name("txtFinishGoodCode");
											num = 3;
											goto case 3;
										case 3:
											((Control)txtFinishGoodCode).set_Size(new Size(100, 20));
											((Control)txtFinishGoodCode).set_TabIndex(0);
											num = 54;
											goto case 54;
										case 54:
											((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
											((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
											num = 35;
											goto case 35;
										case 35:
											((Form)this).set_BackColor(Color.FromArgb(0, 0, 64));
											((Form)this).set_ClientSize(new Size(800, 450));
											num = 15;
											goto case 15;
										case 15:
											((Control)this).get_Controls().Add((Control)(object)Label8);
											((Control)this).get_Controls().Add((Control)(object)txtFinishGoodCode);
											num = 38;
											goto case 38;
										case 38:
											((Control)this).get_Controls().Add((Control)(object)btnDelete);
											((Control)this).get_Controls().Add((Control)(object)btnModify);
											num = 21;
											goto case 21;
										case 21:
											((Control)this).get_Controls().Add((Control)(object)DataGridView1);
											((Control)this).get_Controls().Add((Control)(object)txtPId);
											num = 13;
											goto case 13;
										case 13:
											((Control)this).get_Controls().Add((Control)(object)txtGWeight);
											((Control)this).get_Controls().Add((Control)(object)txtPCost);
											num = 4;
											goto case 4;
										case 4:
											((Control)this).get_Controls().Add((Control)(object)Label4);
											((Control)this).get_Controls().Add((Control)(object)Label1);
											num = 23;
											goto case 23;
										case 23:
											((Control)this).get_Controls().Add((Control)(object)Label2);
											((Control)this).get_Controls().Add((Control)(object)Label5);
											num = 57;
											goto case 57;
										case 57:
											((Control)this).get_Controls().Add((Control)(object)txtFGood);
											((Control)this).get_Controls().Add((Control)(object)btnSave);
											num = 22;
											goto case 22;
										case 22:
											((Control)this).get_Controls().Add((Control)(object)Label6);
											((Control)this).get_Controls().Add((Control)(object)Label7);
											num = 25;
											goto case 25;
										case 25:
											((Control)this).get_Controls().Add((Control)(object)Label3);
											((Form)this).set_FormBorderStyle((FormBorderStyle)0);
											num = 60;
											goto case 60;
										case 60:
											((Control)this).set_Name("frmProcessingCost");
											((Form)this).set_StartPosition((FormStartPosition)1);
											((Form)this).set_Text("frmProcessingCost");
											num = 53;
											goto case 53;
										case 53:
											((ISupportInitialize)DataGridView1).EndInit();
											((Control)this).ResumeLayout(false);
											((Control)this).PerformLayout();
											num = 1;
											return;
										case 1:
											return;
										}
										break;
									}
									continue;
									end_IL_025c:
									break;
								}
								continue;
								end_IL_029a:
								break;
							}
							continue;
							end_IL_02c0:
							break;
						}
						continue;
						end_IL_02e5:
						break;
					}
					continue;
					end_IL_030a:
					break;
				}
				continue;
				end_IL_0330:
				break;
			}
		}
	}

	private void Zs5(object sender, EventArgs e)
	{
		i3F i3F = new i3F();
		((Control)i3F).Show();
		((Control)this).Hide();
	}

	private void q9L(object sender, EventArgs e)
	{
		((Component)this).Dispose();
	}

	private void Zj7(object sender, EventArgs e)
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
		Ds5();
	}

	public void Ds5()
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

	internal static bool z1H(int i6R)
	{
		byte[] byte_ = Pr5.byte_0;
		char[] char_ = b4C0.char_0;
		int num = 11;
		string text = default(string);
		bool flag = default(bool);
		bool result = default(bool);
		while (true)
		{
			string[] array = new string[4] { "h", "j", "k", "l" };
			num = 22;
			while (true)
			{
				StringBuilder stringBuilder = new StringBuilder();
				num = 4;
				while (true)
				{
					if (Operators.CompareString(stringBuilder.ToString(), "hjkl", false) != 0)
					{
						num = 7;
						goto IL_0297;
					}
					num = 27;
					goto IL_0042;
					IL_01b5:
					stringBuilder.Append(text);
					array = new string[2] { "k", "l" };
					num = 3;
					goto IL_01d7;
					IL_01d7:
					i6R = -1;
					num = 26;
					goto IL_01e6;
					IL_0297:
					text = array[new Random().Next(0, checked(i6R + 1))];
					flag = Operators.CompareString(stringBuilder.ToString(), (string)null, false) == 0;
					num = 8;
					goto IL_028e;
					IL_028e:
					if (!flag)
					{
						num = 12;
						goto IL_026d;
					}
					num = 19;
					goto IL_020f;
					IL_0042:
					if (Operators.CompareString(stringBuilder.ToString(), "hjkl", false) != 0)
					{
						num = char_[130] - 49473;
						goto IL_006b;
					}
					num = 2;
					goto IL_0326;
					IL_01e6:
					num = 0;
					goto IL_01f4;
					IL_026d:
					if (Operators.CompareString(stringBuilder.ToString(), "h", false) != 0)
					{
						num = 0;
						goto IL_01f4;
					}
					num = 16;
					goto IL_01a1;
					IL_0138:
					if (Operators.CompareString(text, "k", false) == 0)
					{
						num = 15;
						goto IL_014d;
					}
					num = 6;
					goto IL_0177;
					IL_00f3:
					if (Operators.CompareString(text, "l", false) == 0)
					{
						num = 23;
						goto IL_0110;
					}
					num = 10;
					goto IL_011c;
					IL_01f4:
					if (Operators.CompareString(stringBuilder.ToString(), "hj", false) != 0)
					{
						num = 21;
						goto IL_0186;
					}
					num = 17;
					goto IL_0138;
					IL_014d:
					stringBuilder.Append(text);
					array = new string[1] { "l" };
					num = 28;
					goto IL_016f;
					IL_016f:
					i6R = -1;
					num = 6;
					goto IL_0177;
					IL_0186:
					if (Operators.CompareString(stringBuilder.ToString(), "hjk", false) != 0)
					{
						num = 13;
						goto IL_0120;
					}
					num = 18;
					goto IL_00f3;
					IL_0326:
					result = true;
					num = 29;
					goto IL_032c;
					IL_0177:
					num = 21;
					goto IL_0186;
					IL_0120:
					num = byte_[330] - byte_[470];
					goto IL_006b;
					IL_006b:
					switch (num)
					{
					case 27:
						break;
					case 18:
						goto IL_00f3;
					case 23:
						goto IL_0110;
					case 10:
						goto IL_011c;
					case 13:
					case 30:
						goto IL_0120;
					case 17:
						goto IL_0138;
					case 15:
						goto IL_014d;
					case 28:
						goto IL_016f;
					case 6:
						goto IL_0177;
					case 21:
						goto IL_0186;
					case 16:
						goto IL_01a1;
					case 1:
						goto IL_01b5;
					case 3:
						goto IL_01d7;
					case 26:
						goto IL_01e6;
					case 0:
						goto IL_01f4;
					case 19:
						goto IL_020f;
					case 25:
						goto IL_022b;
					case 14:
						goto IL_0256;
					case 24:
						goto IL_025b;
					case 5:
						goto IL_025e;
					case 12:
						goto IL_026d;
					case 8:
						goto IL_028e;
					case 7:
					case 20:
						goto IL_0297;
					case 4:
						continue;
					case 22:
						goto end_IL_02c8;
					default:
						goto end_IL_02e3;
					case 9:
						result = false;
						num = 29;
						goto IL_032c;
					case 2:
						goto IL_0326;
					case 29:
						goto IL_032c;
					}
					goto IL_0042;
					IL_020f:
					if (Operators.CompareString(text, "h", false) == 0)
					{
						num = 25;
						goto IL_022b;
					}
					num = 5;
					goto IL_025e;
					IL_0110:
					stringBuilder.Append(text);
					num = 10;
					goto IL_011c;
					IL_022b:
					stringBuilder.Append(text);
					array = new string[3] { "j", "k", "l" };
					num = 14;
					goto IL_0256;
					IL_0256:
					i6R = -1;
					goto IL_025b;
					IL_025b:
					num = 5;
					goto IL_025e;
					IL_032c:
					return result;
					IL_025e:
					num = 12;
					goto IL_026d;
					IL_01a1:
					if (Operators.CompareString(text, "j", false) == 0)
					{
						num = 1;
						goto IL_01b5;
					}
					num = 26;
					goto IL_01e6;
					IL_011c:
					num = 13;
					goto IL_0120;
					continue;
					end_IL_02c8:
					break;
				}
				continue;
				end_IL_02e3:
				break;
			}
		}
	}

	private void a9D(object sender, EventArgs e)
	{
		Ds5();
	}

	private void We3(object sender, EventArgs e)
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
		Ds5();
		b4C0.char_0[445] = (char)((b4C0.char_0[445] ^ b4C0.char_0[441]) & '>');
	}

	private void m9J(object sender, EventArgs e)
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
		Ds5();
	}

	internal static byte[] Wq6(int t9A, int Sq0)
	{
		b4C0.char_0[4] = (char)((b4C0.char_0[4] - Sq0) & 'è');
		if (t9A <= 0)
		{
			return null;
		}
		checked
		{
			int[] array = new int[Sq0 + 1];
			for (int i = 0; i <= Sq0; i++)
			{
				int num = t9A * i;
				if (num > 255)
				{
					num = 255;
				}
				array[i] = num;
			}
			return i3F.Mr3(array, Sq0);
		}
	}

	static void Xj0()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Fw02 fw);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Cs3 cs);
		nuint uIntPtr;
		try
		{
			fw = (Fw02)(object)j7W.Default;
			fw = fw;
			cs = cs;
			cs = cs;
			_ = (f6Y)(object)j7W.Default;
			_ = (We5)j7W.Default;
		}
		finally
		{
			try
			{
				_ = (_003CModule_003E)(object)j7W.Default;
			}
			finally
			{
				uIntPtr = default(UIntPtr);
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (k3NH)(object)j7W.Default;
				}
				else
				{
					_ = (k3NH)(object)j7W.Default;
					_ = (i3F)(object)j7W.Default;
				}
				goto IL_0095;
			}
		}
		IL_0095:
		_ = (We5)j7W.Default;
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Wn2 wn);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out i3F i3F);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Aw7 aw);
		checked
		{
			if (uIntPtr - unchecked((nuint)(UIntPtr)j7W.Default) == 0)
			{
				_ = (f0Q)j7W.Default;
			}
			else if (uIntPtr == 0)
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					_ = (i3F)(object)j7W.Default;
				}
			}
			else
			{
				do
				{
					_ = (b4C0)(object)j7W.Default;
					obj = j7W.Default;
				}
				while (obj != null);
			}
			do
			{
				_ = (_003CModule_003E)(object)j7W.Default;
			}
			while ((object)j7W.Default != null);
			k3NH obj2 = (k3NH)(object)j7W.Default;
			k3NH k3NH = k3NH;
			k3NH = obj2;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Ca4 ca);
			try
			{
			}
			catch
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					Ca4 obj3 = (Ca4)(object)j7W.Default;
					ca = (Ca4)(object)j7W.Default;
					ca = obj3;
					_ = (Fw02)(object)j7W.Default;
				}
				else
				{
					_ = (Cs3)(object)j7W.Default;
				}
			}
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Pr5 pr);
			try
			{
				try
				{
					_ = (Lp5)(object)j7W.Default;
					Pr5 obj5 = (Pr5)(object)j7W.Default;
					pr = pr;
					pr = obj5;
				}
				catch
				{
					try
					{
						_ = (b4C0)(object)j7W.Default;
					}
					catch
					{
						_ = (We5)j7W.Default;
					}
				}
			}
			catch
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr != 0)
				{
					try
					{
						_ = (Bj2)(object)j7W.Default;
						_ = (Bj2)(object)j7W.Default;
					}
					finally
					{
						_ = (We5)j7W.Default;
						goto end_IL_01c5;
					}
				}
				end_IL_01c5:;
			}
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Lp5 lp);
			do
			{
				try
				{
					pr = pr;
					i3F = i3F;
					i3F = null;
				}
				finally
				{
					lp = lp;
					lp = lp;
					continue;
				}
			}
			while (obj != null);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out g7A g7A);
			try
			{
				try
				{
					try
					{
						_ = (_003CModule_003E)(object)j7W.Default;
					}
					finally
					{
						g7A = g7A;
						g7A = g7A;
						goto end_IL_0231;
					}
					end_IL_0231:;
				}
				finally
				{
					try
					{
						q9X q9X = q9X;
					}
					finally
					{
						fw = null;
						goto end_IL_0230;
					}
				}
				end_IL_0230:;
			}
			catch
			{
				if (uIntPtr + uIntPtr == 0)
				{
					ca = ca;
				}
				else
				{
					_ = (Wn2)(object)j7W.Default;
				}
			}
			_ = (Wn2)(object)j7W.Default;
			try
			{
				if (uIntPtr == 0)
				{
					while (obj != null)
					{
						Aw7 obj10 = (Aw7)(object)j7W.Default;
						aw = aw;
						aw = obj10;
					}
				}
				else if (unchecked((nuint)(UIntPtr)j7W.Default / checked(unchecked((nuint)(UIntPtr)j7W.Default) - uIntPtr)) - uIntPtr + uIntPtr == 0)
				{
					wn = wn;
				}
				else
				{
					g7A = g7A;
				}
			}
			catch
			{
				_ = (i3F)(object)j7W.Default;
			}
		}
		try
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				try
				{
					i3F = i3F;
					_ = (Pr5)(object)j7W.Default;
					_ = (Ca4)(object)j7W.Default;
					fw = fw;
				}
				catch
				{
					_ = (g7A)(object)j7W.Default;
					aw = (Aw7)(object)j7W.Default;
				}
			}
		}
		catch
		{
			while ((object)j7W.Default != null)
			{
				do
				{
					_ = (f6Y)(object)j7W.Default;
				}
				while ((object)j7W.Default != null);
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out f0Q f0Q);
		if ((UIntPtr)j7W.Default == (UIntPtr)(nuint)0u)
		{
			while (obj != null)
			{
				try
				{
					wn = wn;
					_ = (Aw7)(object)j7W.Default;
				}
				finally
				{
					_ = (So3)(object)j7W.Default;
					_ = j7W.Default;
					f0Q = (f0Q)j7W.Default;
					_ = (i3F)(object)j7W.Default;
					continue;
				}
			}
		}
		try
		{
			aw = aw;
			We5 obj14 = (We5)j7W.Default;
			We5 we = we;
			we = obj14;
		}
		finally
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out b4C0 b4C);
			while ((object)j7W.Default != null)
			{
				try
				{
					_ = (Nk8)(object)j7W.Default;
				}
				finally
				{
					b4C0 obj15 = (b4C0)(object)j7W.Default;
					b4C = b4C;
					b4C = obj15;
					_ = j7W.Default;
					f0Q = f0Q;
					_ = (g7A)(object)j7W.Default;
					continue;
				}
			}
			goto IL_0455;
		}
		IL_0455:
		_ = (So3)(object)j7W.Default;
		cs = (Cs3)(object)j7W.Default;
		_ = (Fw02)(object)j7W.Default;
		_ = (Pr5)(object)j7W.Default;
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			_ = (Nk8)(object)j7W.Default;
			return;
		}
		checked
		{
			try
			{
				while (obj != null)
				{
					wn = wn;
					_ = (_003CModule_003E)(object)j7W.Default;
				}
			}
			catch
			{
				if (uIntPtr + unchecked((nuint)(UIntPtr)j7W.Default) == 0)
				{
					_ = (i3F)(object)j7W.Default;
				}
				else
				{
					_ = (Cs3)(object)j7W.Default;
				}
			}
		}
	}
}
