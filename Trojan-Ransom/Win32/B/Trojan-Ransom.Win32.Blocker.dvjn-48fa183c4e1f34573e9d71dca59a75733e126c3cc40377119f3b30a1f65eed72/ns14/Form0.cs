using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;
using ns10;
using ns12;
using ns13;

namespace ns14;

[DesignerCategory("Code")]
internal class Form0 : Form
{
	private EventArgs1 eventArgs1_0;

	internal Thread thread_0;

	internal CheckBox checkBox_0;

	internal Label label_0;

	internal Button button_0;

	internal Button button_1;

	internal Label label_1;

	internal Class55 class55_0;

	internal Panel panel_0;

	internal Panel panel_1;

	internal Button button_2;

	internal Control3 control3_0;

	internal Control0 control0_0;

	internal Control0 control0_1;

	internal Control0 control0_2;

	internal Control0 control0_3;

	internal Button button_3;

	internal Button button_4;

	internal Button button_5;

	internal Control1 control1_0;

	internal Control1 control1_1;

	internal Control2 control2_0;

	internal Button button_6;

	private bool bool_0;

	internal void method_0(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Invalid comparison between Unknown and I4
		while (true)
		{
			SaveFileDialog val = new SaveFileDialog();
			if (kCkYd4RGfkAFcE5xx6s())
			{
				switch (0)
				{
				case 1:
					continue;
				case 0:
					((FileDialog)val).set_Title(Class32.smethod_0(742));
					((FileDialog)val).set_DefaultExt(Class32.smethod_0(7100));
					goto case 5;
				case 5:
					((FileDialog)val).set_Filter(Class32.smethod_0(7125));
					goto default;
				default:
					if ((int)((CommonDialog)val).ShowDialog() != 1)
					{
						return;
					}
					break;
				case 2:
				case 4:
					break;
				case 7:
					return;
				}
			}
			EventArgs1 eventArgs = eventArgs1_0;
			string fileName = ((FileDialog)val).get_FileName();
			Class12.smethod_53(fileName, eventArgs);
			((Form)this).Close();
			break;
		}
	}

	internal void method_1(object sender, EventArgs e)
	{
		try
		{
			((Control)panel_0).set_Visible(false);
			if (kCkYd4RGfkAFcE5xx6s())
			{
				switch (2)
				{
				case 0:
				case 2:
					((Control)panel_1).set_Visible(true);
					((Control)control2_0).set_Visible(true);
					break;
				case 4:
					goto IL_0056;
				}
			}
			if (eventArgs1_0 == null)
			{
				return;
			}
			goto IL_0056;
			IL_0056:
			Class12.smethod_160(this, (ThreadStart)method_11);
		}
		catch
		{
		}
	}

	internal void method_2(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	internal void method_3(object sender, EventArgs e)
	{
		try
		{
			if (thread_0 != null)
			{
				thread_0.Abort();
			}
		}
		catch
		{
		}
		((Form)this).Close();
	}

	internal void method_4(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	internal void method_5(object sender, EventArgs e)
	{
		eventArgs1_0.bool_3 = checkBox_0.get_Checked();
	}

	private void method_6(object sender, EventArgs3 e)
	{
		try
		{
			((Control)this).Invoke((Delegate)new Delegate20(method_8), new object[2] { sender, e });
		}
		catch (InvalidOperationException)
		{
		}
	}

	private void method_7(object sender, EventArgs e)
	{
		try
		{
			((Control)this).Invoke((Delegate)new EventHandler(method_9), new object[2] { sender, e });
		}
		catch (InvalidOperationException)
		{
		}
	}

	void Form.OnClosing(CancelEventArgs e)
	{
		while (thread_0 != null)
		{
			int num = 3;
			if (!kCkYd4RGfkAFcE5xx6s())
			{
				return;
			}
			while (true)
			{
				switch (num)
				{
				default:
					num = 0;
					if (kCkYd4RGfkAFcE5xx6s())
					{
						continue;
					}
					goto case 0;
				case 4:
					break;
				case 1:
				case 3:
					if (!thread_0.IsAlive)
					{
						goto end_IL_003c;
					}
					goto case 0;
				case 0:
				case 2:
					thread_0.Abort();
					goto end_IL_003c;
				case 5:
					return;
				}
				break;
			}
			continue;
			end_IL_003c:
			break;
		}
		((Form)this).OnClosing(e);
	}

	private void method_8(object sender, EventArgs3 e)
	{
		Button val = default(Button);
		Control0 control = default(Control0);
		string string_ = default(string);
		while (true)
		{
			int num;
			if (bool_0)
			{
				num = 11;
				if (!kCkYd4RGfkAFcE5xx6s())
				{
					return;
				}
				goto IL_002b;
			}
			goto IL_009d;
			IL_01bd:
			((Control)button_3).Focus();
			break;
			IL_009d:
			Button obj = button_4;
			goto IL_007b;
			IL_007b:
			val = obj;
			switch (e.enum4_0)
			{
			case Enum4.const_0:
				break;
			default:
				return;
			case Enum4.const_1:
				goto IL_00f1;
			case Enum4.const_2:
				goto IL_0134;
			case Enum4.const_3:
				goto IL_018f;
			}
			if (!e.bool_0)
			{
				Class12.smethod_92(control0_0);
				num = 10;
				if (!kCkYd4RGfkAFcE5xx6s())
				{
					return;
				}
				goto IL_002b;
			}
			control = control0_0;
			goto IL_00d3;
			IL_018f:
			((Control)control3_0).set_Visible(false);
			Class12.smethod_26(control0_2);
			Class12.smethod_26(control0_3);
			((Control)button_3).set_Enabled(true);
			goto IL_01bd;
			IL_0134:
			if (e.bool_0)
			{
				((Control)control3_0).set_Visible(false);
				control = control0_2;
				string_ = e.string_0;
				goto IL_0156;
			}
			Class12.smethod_26(control0_1);
			Class12.smethod_92(control0_2);
			goto IL_0182;
			IL_0156:
			Class12.smethod_1(string_, control);
			((Control)val).set_Visible(true);
			((Control)val).Focus();
			return;
			IL_00d3:
			string_ = e.string_0;
			goto IL_00da;
			IL_00f1:
			if (e.bool_0)
			{
				control = control0_1;
				string_ = e.string_0;
				Class12.smethod_1(string_, control);
				((Control)val).set_Visible(true);
				((Control)val).Focus();
			}
			else
			{
				Class12.smethod_26(control0_0);
				Class12.smethod_92(control0_1);
			}
			return;
			IL_00da:
			Class12.smethod_1(string_, control);
			((Control)val).set_Visible(true);
			((Control)val).Focus();
			return;
			IL_0182:
			((Control)control3_0).set_Visible(true);
			return;
			IL_002b:
			switch (num)
			{
			case 11:
				break;
			case 3:
				continue;
			case 2:
				goto IL_00d3;
			case 1:
				goto IL_00da;
			case 10:
				return;
			case 4:
				return;
			default:
				goto IL_0156;
			case 0:
				goto IL_0182;
			case 7:
			case 8:
				goto IL_01bd;
			case 5:
			case 9:
				goto end_IL_00b6;
			case 12:
				return;
			}
			if (Thread.CurrentThread.ApartmentState == ApartmentState.STA)
			{
				obj = button_5;
				goto IL_007b;
			}
			goto IL_009d;
			continue;
			end_IL_00b6:
			break;
		}
		((Control)button_2).set_Enabled(false);
	}

	private void method_9(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	internal void method_10(object sender, EventArgs e)
	{
		int num = 4;
		if (kCkYd4RGfkAFcE5xx6s())
		{
			while (true)
			{
				switch (num)
				{
				case 4:
					bool_0 = true;
					num = 5;
					if (kCkYd4RGfkAFcE5xx6s())
					{
						continue;
					}
					goto IL_0075;
				case 1:
				case 5:
					break;
				case 2:
					goto IL_0054;
				default:
					goto IL_0075;
				case 6:
					return;
				}
				break;
			}
		}
		((Control)button_4).set_Visible(false);
		goto IL_0054;
		IL_0054:
		Class12.smethod_27(control0_0);
		Class12.smethod_27(control0_1);
		Class12.smethod_27(control0_2);
		goto IL_0075;
		IL_0075:
		if (eventArgs1_0 != null)
		{
			Class12.smethod_160(this, (ThreadStart)method_11);
		}
	}

	private void method_11()
	{
		Class12.smethod_22(eventArgs1_0);
	}

	internal void method_12(object sender, EventArgs e)
	{
		if (eventArgs1_0 != null)
		{
			Class12.smethod_160(this, (ThreadStart)eventArgs1_0.method_0);
		}
	}

	public Form0(Class56 unhandledExceptionHandler, EventArgs1 reportExceptionEventArgs)
	{
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Expected O, but got Unknown
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Expected O, but got Unknown
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Expected O, but got Unknown
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Expected O, but got Unknown
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Expected O, but got Unknown
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Expected O, but got Unknown
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_0272: Expected O, but got Unknown
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Expected O, but got Unknown
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Expected O, but got Unknown
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0299: Expected O, but got Unknown
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Expected O, but got Unknown
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b1: Expected O, but got Unknown
		while (true)
		{
			checkBox_0 = new CheckBox();
			while (true)
			{
				label_0 = new Label();
				button_0 = new Button();
				button_1 = new Button();
				while (true)
				{
					IL_0251:
					label_1 = new Label();
					class55_0 = new Class55();
					panel_0 = new Panel();
					panel_1 = new Panel();
					while (true)
					{
						IL_01cc:
						button_2 = new Button();
						control3_0 = new Control3();
						control0_0 = new Control0(Class32.smethod_0(7206));
						control0_1 = new Control0(Class32.smethod_0(7243));
						control0_2 = new Control0(Class32.smethod_0(7272));
						control0_3 = new Control0(Class32.smethod_0(7301));
						button_3 = new Button();
						button_4 = new Button();
						while (true)
						{
							IL_016d:
							button_5 = new Button();
							control1_0 = new Control1(string.Format(Class32.smethod_0(7354), Class32.smethod_0(759)));
							control1_1 = new Control1(string.Format(Class32.smethod_0(7443), Class32.smethod_0(759), Class32.smethod_0(445)));
							while (true)
							{
								IL_0160:
								control2_0 = new Control2();
								while (true)
								{
									IL_014d:
									button_6 = new Button();
									((Form)this)._002Ector();
									while (true)
									{
										IL_0104:
										Class12.smethod_3(this);
										int height = ((Control)this).get_Height();
										eventArgs1_0 = reportExceptionEventArgs;
										((Control)class55_0).set_Text(reportExceptionEventArgs.exception_0.Message);
										height += ((Control)class55_0).get_Height() - ((Control)this).get_FontHeight();
										if (!reportExceptionEventArgs.bool_2)
										{
											goto IL_00ce;
										}
										goto IL_00f6;
										IL_00f6:
										if (height > ((Control)this).get_Height())
										{
											((Control)this).set_Height(height);
										}
										if (reportExceptionEventArgs.bool_0)
										{
											unhandledExceptionHandler.DebuggerLaunched += method_7;
											((Control)button_6).set_Visible(true);
											if (((Control)button_6).get_Left() < ((Control)control2_0).get_Right())
											{
												((Control)control2_0).set_Visible(false);
											}
										}
										while (true)
										{
											if (!reportExceptionEventArgs.bool_1)
											{
												int num = 0;
												if (zAHFCcRsuHujs5mFDht())
												{
													break;
												}
												while (true)
												{
													switch (num)
													{
													case 0:
														((Control)button_1).set_Enabled(false);
														num = 13;
														if (!zAHFCcRsuHujs5mFDht())
														{
														}
														continue;
													case 4:
													case 9:
														break;
													case 6:
														goto IL_00ce;
													default:
														goto IL_0104;
													case 11:
														goto IL_014d;
													case 5:
														goto IL_0160;
													case 12:
														goto IL_016d;
													case 1:
														goto IL_01cc;
													case 8:
														goto IL_0251;
													case 3:
														goto end_IL_00c1;
													case 2:
														goto end_IL_0283;
													case 13:
														goto IL_02b3;
													case 14:
														return;
													}
													break;
												}
												continue;
											}
											goto IL_02cc;
											IL_02b3:
											if (((Control)button_0).get_CanFocus())
											{
												((Control)button_0).Focus();
											}
											goto IL_02cc;
											IL_02cc:
											unhandledExceptionHandler.SendingReportFeedback += method_6;
											return;
											continue;
											end_IL_00c1:
											break;
										}
										break;
										IL_00ce:
										((Control)checkBox_0).set_Visible(false);
										height -= ((Control)checkBox_0).get_Height();
										goto IL_00f6;
									}
									break;
								}
								break;
							}
							break;
						}
						break;
					}
					break;
				}
				continue;
				end_IL_0283:
				break;
			}
		}
	}

	internal static bool kCkYd4RGfkAFcE5xx6s()
	{
		return true;
	}

	internal static bool zAHFCcRsuHujs5mFDht()
	{
		return false;
	}
}
