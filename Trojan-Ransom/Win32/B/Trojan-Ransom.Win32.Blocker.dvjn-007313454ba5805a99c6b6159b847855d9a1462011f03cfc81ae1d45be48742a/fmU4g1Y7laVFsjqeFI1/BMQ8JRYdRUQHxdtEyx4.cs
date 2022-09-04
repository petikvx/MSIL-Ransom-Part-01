using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using BAFtn8MT09F52hXL1NN;
using ProwxkN4F4ab5Fc8FL;

namespace fmU4g1Y7laVFsjqeFI1;

internal sealed class BMQ8JRYdRUQHxdtEyx4 : Control
{
	private readonly Label y2GK6c8QJJ;

	private Image zAPKop0Lkv;

	private bool Ot1KEvmaHP;

	private readonly Timer RgwKaZjKnF;

	private bool ltEKByUdWf;

	private string HG5K0rBg5b;

	private float LNBKZVgvvY;

	private float vp5K4tmknH;

	string Text
	{
		get
		{
			return ((Control)this).get_Text();
		}
		set
		{
			((Control)this).set_Text(value);
			((Control)this).Refresh();
		}
	}

	public void joVKO5bB7Z()
	{
		if (zR9IXX4E85axYJCsmIe())
		{
			switch (3)
			{
			case 3:
				break;
			case 1:
			case 6:
				goto IL_0046;
			case 2:
			case 5:
				goto IL_004d;
			case 0:
				goto IL_0054;
			default:
				goto IL_005f;
			case 7:
				goto IL_0065;
			case 8:
				return;
			}
		}
		RgwKaZjKnF.set_Enabled(false);
		goto IL_0046;
		IL_0065:
		((Control)this).set_Height(16);
		return;
		IL_005f:
		((Control)this).Refresh();
		goto IL_0065;
		IL_0046:
		zAPKop0Lkv = null;
		goto IL_004d;
		IL_004d:
		Ot1KEvmaHP = false;
		goto IL_0054;
		IL_0054:
		HG5K0rBg5b = string.Empty;
		goto IL_005f;
	}

	public void fULKjpKWat()
	{
		while (true)
		{
			RgwKaZjKnF.set_Enabled(true);
			int num = 0;
			if (!dUDXwp4lyyklhBUXbnZ())
			{
			}
			while (true)
			{
				switch (num)
				{
				default:
					num = 4;
					if (zR9IXX4E85axYJCsmIe())
					{
						continue;
					}
					goto case 3;
				case 5:
					break;
				case 0:
				case 1:
					zAPKop0Lkv = (Image)(object)rITYfQM9BT4MKIrlIxO.NekK7jcmTv(DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(681171));
					goto case 2;
				case 2:
					Ot1KEvmaHP = true;
					goto case 3;
				case 3:
				case 4:
					((Control)this).Refresh();
					return;
				case 6:
					return;
				}
				break;
			}
		}
	}

	public void nsAKCdJcBI()
	{
		DNqKqIwa4L(string.Empty);
	}

	public void DNqKqIwa4L(string string_0)
	{
		while (true)
		{
			HG5K0rBg5b = string_0;
			while (true)
			{
				IL_00a4:
				RgwKaZjKnF.set_Enabled(false);
				while (true)
				{
					IL_0006:
					zAPKop0Lkv = (Image)(object)rITYfQM9BT4MKIrlIxO.NekK7jcmTv((string_0.Length <= 0) ? DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(681184) : DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(681189));
					while (true)
					{
						IL_008c:
						ltEKByUdWf = true;
						while (true)
						{
							IL_0083:
							Ot1KEvmaHP = true;
							while (true)
							{
								IL_0078:
								if (string_0.Length <= 0)
								{
									goto IL_0029;
								}
								goto IL_006e;
								IL_0029:
								while (true)
								{
									((Control)this).Refresh();
									if (!zR9IXX4E85axYJCsmIe())
									{
										break;
									}
									switch (10)
									{
									case 5:
										break;
									case 2:
									case 7:
										continue;
									case 0:
										goto IL_006e;
									default:
										goto IL_0078;
									case 9:
										goto IL_0083;
									case 3:
									case 8:
										goto IL_008c;
									case 6:
										goto IL_00a4;
									case 4:
										goto end_IL_0029;
									case 10:
										return;
									}
									goto IL_0006;
									continue;
									end_IL_0029:
									break;
								}
								break;
								IL_006e:
								((Control)this).set_Height(100);
								goto IL_0029;
							}
							break;
						}
						break;
					}
					break;
				}
				break;
			}
		}
	}

	void Control.OnResize(EventArgs e)
	{
		((Control)y2GK6c8QJJ).SetBounds(Convert.ToInt32(22f * LNBKZVgvvY), Convert.ToInt32(vp5K4tmknH), ((Control)this).get_Width() - Convert.ToInt32(22f * LNBKZVgvvY), ((Control)this).get_Height() - Convert.ToInt32(vp5K4tmknH));
		((Control)this).OnResize(e);
	}

	void Control.ScaleCore(float dx, float dy)
	{
		LNBKZVgvvY = dx;
		vp5K4tmknH = dy;
		((Control)this).ScaleCore(dx, dy);
		((Control)this).OnResize(EventArgs.Empty);
	}

	void Control.OnPaint(PaintEventArgs e)
	{
		if (dUDXwp4lyyklhBUXbnZ())
		{
		}
		switch (0)
		{
		case 0:
			((Control)this).OnPaint(e);
			goto case 9;
		case 9:
			if (((Component)this).DesignMode)
			{
				goto case 8;
			}
			goto case 4;
		case 8:
			zAPKop0Lkv = (Image)(object)rITYfQM9BT4MKIrlIxO.NekK7jcmTv(DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(681171));
			goto case 1;
		case 1:
			Ot1KEvmaHP = true;
			goto case 4;
		case 4:
			if (zAPKop0Lkv != null)
			{
				goto default;
			}
			goto case 2;
		default:
			if (ltEKByUdWf)
			{
				goto case 10;
			}
			goto case 2;
		case 10:
			e.get_Graphics().DrawImage(zAPKop0Lkv, new Rectangle(0, 0, Convert.ToInt32(16f * LNBKZVgvvY), Convert.ToInt32(16f * vp5K4tmknH)), new Rectangle(0, 0, 16, 16), (GraphicsUnit)2);
			goto case 2;
		case 2:
		case 7:
			if (!Ot1KEvmaHP)
			{
				((Control)y2GK6c8QJJ).set_Text(string.Empty);
				break;
			}
			goto case 6;
		case 6:
			((Control)y2GK6c8QJJ).set_Text((HG5K0rBg5b.Length > 0) ? (((Control)this).get_Text() + DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(681198) + HG5K0rBg5b + DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(681203)) : ((Control)this).get_Text());
			break;
		case 11:
			break;
		}
	}

	public BMQ8JRYdRUQHxdtEyx4()
	{
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected O, but got Unknown
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected O, but got Unknown
		while (true)
		{
			y2GK6c8QJJ = new Label();
			while (true)
			{
				RgwKaZjKnF = new Timer();
				while (true)
				{
					ltEKByUdWf = true;
					HG5K0rBg5b = string.Empty;
					while (true)
					{
						LNBKZVgvvY = 1f;
						while (true)
						{
							IL_00c6:
							vp5K4tmknH = 1f;
							while (true)
							{
								IL_00be:
								((Control)this)._002Ector();
								while (true)
								{
									IL_0095:
									RgwKaZjKnF.set_Interval(250);
									RgwKaZjKnF.add_Tick((EventHandler)aJkKS5tQk1);
									while (true)
									{
										IL_0087:
										y2GK6c8QJJ.set_FlatStyle((FlatStyle)3);
										while (true)
										{
											IL_0074:
											((Control)this).get_Controls().Add((Control)(object)y2GK6c8QJJ);
											while (true)
											{
												IL_0066:
												((Control)this).SetStyle((ControlStyles)75794, true);
												while (true)
												{
													((Control)this).set_TabStop(false);
													int num = 13;
													if (!zR9IXX4E85axYJCsmIe())
													{
														break;
													}
													while (true)
													{
														switch (num)
														{
														default:
															num = 11;
															if (!dUDXwp4lyyklhBUXbnZ())
															{
															}
															continue;
														case 9:
															break;
														case 7:
															goto IL_0066;
														case 10:
															goto IL_0074;
														case 3:
															goto IL_0087;
														case 11:
															goto IL_0095;
														case 6:
															goto IL_00be;
														case 4:
														case 8:
															goto IL_00c6;
														case 0:
															goto end_IL_0051;
														case 2:
														case 12:
															goto end_IL_00d4;
														case 1:
															goto end_IL_00e1;
														case 5:
															goto end_IL_00f5;
														case 13:
															return;
														}
														break;
													}
													continue;
													end_IL_0051:
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
								break;
							}
							break;
						}
						continue;
						end_IL_00d4:
						break;
					}
					continue;
					end_IL_00e1:
					break;
				}
				continue;
				end_IL_00f5:
				break;
			}
		}
	}

	public BMQ8JRYdRUQHxdtEyx4(string string_0)
		: this()
	{
		((Control)this).set_Text(DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(678582) + string_0);
	}

	void Control.Dispose(bool disposing)
	{
		if (disposing)
		{
			if (zAPKop0Lkv != null)
			{
				zAPKop0Lkv.Dispose();
			}
			((Component)(object)RgwKaZjKnF).Dispose();
		}
		((Control)this).Dispose(disposing);
	}

	private void aJkKS5tQk1(object sender, EventArgs e)
	{
		ltEKByUdWf = !ltEKByUdWf;
		((Control)this).Refresh();
	}

	internal static bool zR9IXX4E85axYJCsmIe()
	{
		return true;
	}

	internal static bool dUDXwp4lyyklhBUXbnZ()
	{
		return false;
	}
}
