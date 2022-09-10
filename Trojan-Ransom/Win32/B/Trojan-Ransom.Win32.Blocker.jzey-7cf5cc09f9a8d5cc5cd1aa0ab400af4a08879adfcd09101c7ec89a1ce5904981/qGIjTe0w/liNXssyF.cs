using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Y7FbhctW;
using di1mqJMz;
using iiraiv39;
using p80hVGtz;
using sReLFYF2;

namespace qGIjTe0w;

internal class liNXssyF
{
	private delegate void Delegate1(string msg);

	private const bool j8MUAGe8 = true;

	private NetworkStream oJObHAnO;

	private StreamWriter RcZdlaUS;

	private StreamReader gRhEbBaf;

	private TcpClient VSycm44d;

	private Thread rDGlliNl;

	private m7bmPddy m7bmPddy_0;

	private string dTDIozXM;

	private int yzfO2brM;

	public liNXssyF(ref m7bmPddy GvMNrrXE)
	{
		dTDIozXM = "127.0.0.1";
		yzfO2brM = 8000;
		m7bmPddy_0 = GvMNrrXE;
	}

	public bool BP4p0Noz()
	{
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			VSycm44d = new TcpClient();
			vRvDyS3Z.scoOYfGp(VSycm44d, dTDIozXM, yzfO2brM, 24216);
			if (!vRvDyS3Z.ghSn2ObZ(VSycm44d, 34697))
			{
				vRvDyS3Z.gNX0QwTV("Client not connected", 36486);
				return false;
			}
			oJObHAnO = vRvDyS3Z.LqjCQ5t0(VSycm44d, 42095);
			RcZdlaUS = new StreamWriter(oJObHAnO);
			gRhEbBaf = new StreamReader(oJObHAnO);
			vRvDyS3Z.wzXEPY8o(RcZdlaUS, 57904);
			rDGlliNl = new Thread(qUMSk8ZE);
			vRvDyS3Z.smethod_1(rDGlliNl, "RunControlIO listener", 6551);
			vRvDyS3Z.r89ztNx4(rDGlliNl, 51020);
		}
		catch (Exception ex)
		{
			m8meAX3U.L6HgMKrR(ex, 21003);
			Exception exception_ = ex;
			UFM449tu(ivlgLlId.jnXal2jf(FFXb5i9i.smethod_0("Client connect exception: \r\n", m8meAX3U.gGC2YcoR(exception_, 48704), "\r\n\r\n", 52605), m8meAX3U.gGC2YcoR(exception_, 48705), 28657));
			bool result = false;
			FFXb5i9i.LfyQ8gZ7(12759);
			return result;
		}
		return true;
	}

	public bool YqehMG5R()
	{
		bool result = default(bool);
		int num;
		if (rDGlliNl == null)
		{
			result = false;
			num = 0;
		}
		else
		{
			if (vRvDyS3Z.FkJs352v(rDGlliNl, 328))
			{
				vRvDyS3Z.r89ztNx4(rDGlliNl, 51021);
			}
			vRvDyS3Z.G1cHOzUE(VSycm44d, 35956);
			num = 1;
		}
		if (num != 0)
		{
			result = true;
		}
		return result;
	}

	public object method_0(string DVIf5ttI)
	{
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			O4s9Dog1.erhmZZbp(RcZdlaUS, DVIf5ttI, 59159);
			vRvDyS3Z.wzXEPY8o(RcZdlaUS, 57904);
			vRvDyS3Z.hOJzEwSC(50, 36780);
			return true;
		}
		catch (Exception exception_)
		{
			m8meAX3U.L6HgMKrR(exception_, 21003);
			vRvDyS3Z.WaN2uVeZ(ivlgLlId.jnXal2jf("Failed to send this message: ", DVIf5ttI, 28657), (MsgBoxStyle)0, null, 34299);
			object result = false;
			FFXb5i9i.LfyQ8gZ7(12759);
			return result;
		}
	}

	private void XQRTT7eY(string string_0)
	{
		m7bmPddy_0.F90HO5NN(string_0);
	}

	private void qUMSk8ZE()
	{
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		while (vRvDyS3Z.ghSn2ObZ(VSycm44d, 34697))
		{
			try
			{
				object[] object_ = new object[1] { O4s9Dog1.YciAeyRu(gRhEbBaf, 45302) };
				for (int num = 0; num == 0; num = 1)
				{
					vRvDyS3Z.smethod_2((Control)(object)m7bmPddy_0.form_0, new Delegate1(XQRTT7eY), object_, 51786);
				}
			}
			catch (KeyNotFoundException ex)
			{
				m8meAX3U.L6HgMKrR(ex, 21003);
				KeyNotFoundException exception_ = ex;
				vRvDyS3Z.WaN2uVeZ(FFXb5i9i.smethod_0(m8meAX3U.gGC2YcoR(exception_, 48705), "\r\n\r\n", m8meAX3U.gGC2YcoR(exception_, 48704), 52605), (MsgBoxStyle)0, null, 34299);
				if (m8meAX3U.XUdv6OGi(exception_, 55772) != null)
				{
					vRvDyS3Z.WaN2uVeZ(m8meAX3U.gGC2YcoR(m8meAX3U.XUdv6OGi(exception_, 55772), 48707), (MsgBoxStyle)0, null, 34299);
				}
				FFXb5i9i.LfyQ8gZ7(12759);
			}
			catch (IOException ex2)
			{
				m8meAX3U.L6HgMKrR(ex2, 21003);
				IOException exception_2 = ex2;
				vRvDyS3Z.gNX0QwTV(ivlgLlId.jnXal2jf("Verbindung zum Server nicht möglich!\r\n\r\n", m8meAX3U.gGC2YcoR(exception_2, 48705), 28657), 36486);
				FFXb5i9i.LfyQ8gZ7(12759);
			}
		}
	}

	private void UFM449tu(string WwjVObYT)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		vRvDyS3Z.WaN2uVeZ(WwjVObYT, (MsgBoxStyle)0, null, 34299);
	}
}
