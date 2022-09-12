using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Wi0;
using Xs3;

namespace Sk9;

[DesignerGenerated]
public class Cs3 : Form
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
			EventHandler eventHandler = e6J;
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
			EventHandler eventHandler = y7L;
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

	[field: AccessedThroughProperty("PictureBox1")]
	internal virtual PictureBox PictureBox1
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

	public Cs3()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)n5C);
		cs = "Data Source=DESKTOP-1L8UME0\\SQLEXPRESS;Initial Catalog=db_fabric;Integrated Security=True";
		cn = new SqlConnection(cs);
		cmd = new SqlCommand();
		i9Y();
	}

	[DebuggerNonUserCode]
	protected override void Ei7(bool Qz6)
	{
		try
		{
			if (Qz6 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Qz6);
		}
	}

	[DebuggerStepThrough]
	private void i9Y()
	{
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Expected O, but got Unknown
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Expected O, but got Unknown
		//IL_0290: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Expected O, but got Unknown
		//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Expected O, but got Unknown
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d6: Expected O, but got Unknown
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e1: Expected O, but got Unknown
		//IL_02f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0301: Expected O, but got Unknown
		//IL_0302: Unknown result type (might be due to invalid IL or missing references)
		//IL_030c: Expected O, but got Unknown
		//IL_0342: Unknown result type (might be due to invalid IL or missing references)
		//IL_034c: Expected O, but got Unknown
		//IL_03dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e6: Expected O, but got Unknown
		byte[] byte_ = Pr5.byte_0;
		int num = 26;
		while (true)
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Cs3));
			Label3 = new Label();
			Label6 = new Label();
			num = 18;
			while (true)
			{
				Label7 = new Label();
				PictureBox1 = new PictureBox();
				Label1 = new Label();
				num = 35;
				while (true)
				{
					((ISupportInitialize)PictureBox1).BeginInit();
					((Control)this).SuspendLayout();
					Label3.set_AutoSize(true);
					num = 24;
					while (true)
					{
						((Control)Label3).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
						num = 2;
						while (true)
						{
							((Control)Label3).set_ForeColor(Color.White);
							((Control)Label3).set_Location(new Point(364, 27));
							num = 21;
							while (true)
							{
								((Control)Label3).set_Name("Label3");
								((Control)Label3).set_Size(new Size(107, 17));
								num = 12;
								while (true)
								{
									((Control)Label3).set_TabIndex(8);
									Label3.set_Text("About System");
									num = 32;
									while (true)
									{
										Label6.set_AutoSize(true);
										((Control)Label6).set_BackColor(Color.Blue);
										num = 19;
										while (true)
										{
											((Control)Label6).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
											num = 29;
											while (true)
											{
												((Control)Label6).set_ForeColor(Color.White);
												while (true)
												{
													((Control)Label6).set_Location(new Point(727, 27));
													num = 3;
													while (true)
													{
														((Control)Label6).set_Name("Label6");
														((Control)Label6).set_Size(new Size(18, 17));
														num = 15;
														while (true)
														{
															((Control)Label6).set_TabIndex(14);
															Label6.set_Text("X");
															num = 20;
															while (true)
															{
																Label7.set_AutoSize(true);
																((Control)Label7).set_BackColor(Color.Blue);
																num = 16;
																while (true)
																{
																	((Control)Label7).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
																	num = 27;
																	while (true)
																	{
																		((Control)Label7).set_ForeColor(Color.White);
																		((Control)Label7).set_Location(new Point(35, 27));
																		num = 14;
																		while (true)
																		{
																			((Control)Label7).set_Name("Label7");
																			((Control)Label7).set_Size(new Size(92, 17));
																			switch (byte_[203] - byte_[312])
																			{
																			case 14:
																				break;
																			case 27:
																				goto end_IL_000e;
																			case 16:
																				goto end_IL_00dd;
																			case 20:
																				goto end_IL_0109;
																			case 15:
																				goto end_IL_012b;
																			case 3:
																				goto end_IL_014c;
																			case 33:
																				goto end_IL_016e;
																			case 29:
																				goto end_IL_0197;
																			case 19:
																				goto end_IL_01b2;
																			case 32:
																				goto end_IL_01c4;
																			case 12:
																				goto end_IL_01e6;
																			case 21:
																				goto end_IL_0207;
																			case 2:
																				goto end_IL_0228;
																			case 24:
																				goto end_IL_0251;
																			case 35:
																				goto end_IL_027d;
																			case 18:
																				goto end_IL_029e;
																			default:
																				goto end_IL_02c0;
																			case 6:
																				((Control)Label7).set_TabIndex(13);
																				Label7.set_Text("Go To Main");
																				num = 31;
																				goto case 31;
																			case 31:
																				PictureBox1.set_Image((Image)componentResourceManager.GetObject("PictureBox1.Image"));
																				((Control)PictureBox1).set_Location(new Point(189, 104));
																				num = 34;
																				goto case 34;
																			case 34:
																				((Control)PictureBox1).set_Name("PictureBox1");
																				((Control)PictureBox1).set_Size(new Size(469, 346));
																				num = 11;
																				goto case 11;
																			case 11:
																				PictureBox1.set_SizeMode((PictureBoxSizeMode)1);
																				PictureBox1.set_TabIndex(15);
																				num = 5;
																				goto case 5;
																			case 5:
																			case 17:
																				PictureBox1.set_TabStop(false);
																				Label1.set_AutoSize(true);
																				num = 13;
																				goto case 13;
																			case 13:
																				((Control)Label1).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
																				num = 7;
																				goto case 7;
																			case 7:
																				((Control)Label1).set_ForeColor(Color.White);
																				((Control)Label1).set_Location(new Point(170, 65));
																				num = 4;
																				goto case 4;
																			case 4:
																				((Control)Label1).set_Name("Label1");
																				((Control)Label1).set_Size(new Size(446, 17));
																				num = 1;
																				goto case 1;
																			case 1:
																				((Control)Label1).set_TabIndex(16);
																				Label1.set_Text("One fully-integrated software solution to manage your entire business");
																				num = 9;
																				goto case 9;
																			case 9:
																				((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
																				((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
																				num = 22;
																				goto case 22;
																			case 22:
																				((Form)this).set_BackColor(Color.FromArgb(0, 0, 64));
																				((Form)this).set_ClientSize(new Size(800, 450));
																				num = 8;
																				goto case 8;
																			case 8:
																				((Control)this).get_Controls().Add((Control)(object)Label1);
																				((Control)this).get_Controls().Add((Control)(object)PictureBox1);
																				num = 10;
																				goto case 10;
																			case 10:
																				((Control)this).get_Controls().Add((Control)(object)Label6);
																				goto case 30;
																			case 30:
																				((Control)this).get_Controls().Add((Control)(object)Label7);
																				num = 25;
																				goto case 25;
																			case 25:
																				((Control)this).get_Controls().Add((Control)(object)Label3);
																				((Form)this).set_FormBorderStyle((FormBorderStyle)0);
																				num = 23;
																				goto case 23;
																			case 23:
																				((Control)this).set_Name("frmBillingDetail");
																				((Form)this).set_StartPosition((FormStartPosition)1);
																				((Form)this).set_Text("frmBillingDetail");
																				num = 0;
																				goto case 0;
																			case 0:
																				((ISupportInitialize)PictureBox1).EndInit();
																				((Control)this).ResumeLayout(false);
																				((Control)this).PerformLayout();
																				num = 28;
																				return;
																			case 28:
																				return;
																			}
																			continue;
																			end_IL_000e:
																			break;
																		}
																		continue;
																		end_IL_00dd:
																		break;
																	}
																	continue;
																	end_IL_0109:
																	break;
																}
																continue;
																end_IL_012b:
																break;
															}
															continue;
															end_IL_014c:
															break;
														}
														continue;
														end_IL_016e:
														break;
													}
													continue;
													end_IL_0197:
													break;
												}
												continue;
												end_IL_01b2:
												break;
											}
											continue;
											end_IL_01c4:
											break;
										}
										continue;
										end_IL_01e6:
										break;
									}
									continue;
									end_IL_0207:
									break;
								}
								continue;
								end_IL_0228:
								break;
							}
							continue;
							end_IL_0251:
							break;
						}
						continue;
						end_IL_027d:
						break;
					}
					continue;
					end_IL_029e:
					break;
				}
				continue;
				end_IL_02c0:
				break;
			}
		}
	}

	private void y7L(object sender, EventArgs e)
	{
		i3F i3F = new i3F();
		((Control)i3F).Show();
		((Control)this).Hide();
	}

	private void e6J(object sender, EventArgs e)
	{
		((Component)this).Dispose();
	}

	private void n5C(object sender, EventArgs e)
	{
	}

	internal static string Ci5(string[] e6R, int Mz3, int j9K)
	{
		string text = "";
		for (int i = Mz3; i <= j9K; i = checked(i + 1))
		{
			text += e6R[i];
		}
		return text.ToString();
	}

	internal static bool o9T(string s0E)
	{
		try
		{
			WebRequest webRequest = WebRequest.Create(s0E);
			webRequest.GetResponse();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
		return true;
	}
}
