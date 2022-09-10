using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using TGaER2JO;
using di1mqJMz;
using iLd730DL;
using iiraiv39;
using p80hVGtz;
using wMk1FHff;

namespace CCfpfC7h;

[Serializable]
internal abstract class vilSnlZy
{
	public delegate void BNlSm4u1(string OldName);

	public delegate void GfIy5BT1(string NewName);

	public delegate void XShKt3Ao();

	public delegate void Delegate2();

	public delegate void m7w363Aw();

	protected string SfsOq6EW;

	protected string cUrlxEUV;

	protected string string_0;

	protected string string_1;

	protected string string_2;

	protected TpkjKE5s M3QpCCVK;

	protected string tXzfJ9Wv;

	protected bool ETGmzeYt;

	[CompilerGenerated]
	private BNlSm4u1 ZYewlPs1;

	[CompilerGenerated]
	private GfIy5BT1 gfIy5BT1_0;

	[CompilerGenerated]
	private XShKt3Ao xshKt3Ao_0;

	[CompilerGenerated]
	private Delegate2 delegate2_0;

	[CompilerGenerated]
	private m7w363Aw m7w363Aw_0;

	public string ehtynTEo
	{
		get
		{
			return SfsOq6EW;
		}
		set
		{
			SfsOq6EW = value;
		}
	}

	public string PYBbtbg6
	{
		get
		{
			return cUrlxEUV;
		}
		set
		{
			ZYewlPs1?.Invoke(cUrlxEUV);
			cUrlxEUV = value;
			gfIy5BT1_0?.Invoke(cUrlxEUV);
		}
	}

	public string String_0
	{
		get
		{
			return string_0;
		}
		set
		{
			string_0 = value;
		}
	}

	public string String_1
	{
		get
		{
			return string_1;
		}
		set
		{
			string_1 = value;
		}
	}

	public virtual bool ROfx4MMm
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public string String_2
	{
		get
		{
			return string_2;
		}
		set
		{
			string_2 = value;
		}
	}

	public TpkjKE5s mKYD5QOE
	{
		get
		{
			return M3QpCCVK;
		}
		set
		{
			M3QpCCVK = value;
		}
	}

	public event BNlSm4u1 e4hVAkDo
	{
		[CompilerGenerated]
		add
		{
			BNlSm4u1 bNlSm4u = ZYewlPs1;
			BNlSm4u1 bNlSm4u2;
			do
			{
				bNlSm4u2 = bNlSm4u;
				BNlSm4u1 value2 = (BNlSm4u1)FFXb5i9i.PcI4tKMj(bNlSm4u2, value, 32722);
				bNlSm4u = Interlocked.CompareExchange(ref ZYewlPs1, value2, bNlSm4u2);
			}
			while ((object)bNlSm4u != bNlSm4u2);
		}
		[CompilerGenerated]
		remove
		{
			BNlSm4u1 bNlSm4u = ZYewlPs1;
			BNlSm4u1 bNlSm4u2;
			do
			{
				bNlSm4u2 = bNlSm4u;
				BNlSm4u1 value2 = (BNlSm4u1)FFXb5i9i.PcI4tKMj(bNlSm4u2, value, 32723);
				bNlSm4u = Interlocked.CompareExchange(ref ZYewlPs1, value2, bNlSm4u2);
			}
			while ((object)bNlSm4u != bNlSm4u2);
		}
	}

	public event GfIy5BT1 Event_0
	{
		[CompilerGenerated]
		add
		{
			GfIy5BT1 gfIy5BT = gfIy5BT1_0;
			GfIy5BT1 gfIy5BT2;
			do
			{
				gfIy5BT2 = gfIy5BT;
				GfIy5BT1 value2 = (GfIy5BT1)FFXb5i9i.PcI4tKMj(gfIy5BT2, value, 32722);
				gfIy5BT = Interlocked.CompareExchange(ref gfIy5BT1_0, value2, gfIy5BT2);
			}
			while ((object)gfIy5BT != gfIy5BT2);
		}
		[CompilerGenerated]
		remove
		{
			GfIy5BT1 gfIy5BT = gfIy5BT1_0;
			GfIy5BT1 gfIy5BT2;
			do
			{
				gfIy5BT2 = gfIy5BT;
				GfIy5BT1 value2 = (GfIy5BT1)FFXb5i9i.PcI4tKMj(gfIy5BT2, value, 32723);
				gfIy5BT = Interlocked.CompareExchange(ref gfIy5BT1_0, value2, gfIy5BT2);
			}
			while ((object)gfIy5BT != gfIy5BT2);
		}
	}

	public event XShKt3Ao YOJzYC0s
	{
		[CompilerGenerated]
		add
		{
			XShKt3Ao xShKt3Ao = xshKt3Ao_0;
			XShKt3Ao xShKt3Ao2;
			do
			{
				xShKt3Ao2 = xShKt3Ao;
				XShKt3Ao value2 = (XShKt3Ao)FFXb5i9i.PcI4tKMj(xShKt3Ao2, value, 32722);
				xShKt3Ao = Interlocked.CompareExchange(ref xshKt3Ao_0, value2, xShKt3Ao2);
			}
			while ((object)xShKt3Ao != xShKt3Ao2);
		}
		[CompilerGenerated]
		remove
		{
			XShKt3Ao xShKt3Ao = xshKt3Ao_0;
			XShKt3Ao xShKt3Ao2;
			do
			{
				xShKt3Ao2 = xShKt3Ao;
				XShKt3Ao value2 = (XShKt3Ao)FFXb5i9i.PcI4tKMj(xShKt3Ao2, value, 32723);
				xShKt3Ao = Interlocked.CompareExchange(ref xshKt3Ao_0, value2, xShKt3Ao2);
			}
			while ((object)xShKt3Ao != xShKt3Ao2);
		}
	}

	public event Delegate2 rZDMRlVb
	{
		[CompilerGenerated]
		add
		{
			Delegate2 @delegate = delegate2_0;
			Delegate2 delegate2;
			do
			{
				delegate2 = @delegate;
				Delegate2 value2 = (Delegate2)FFXb5i9i.PcI4tKMj(delegate2, value, 32722);
				@delegate = Interlocked.CompareExchange(ref delegate2_0, value2, delegate2);
			}
			while ((object)@delegate != delegate2);
		}
		[CompilerGenerated]
		remove
		{
			Delegate2 @delegate = delegate2_0;
			Delegate2 delegate2;
			do
			{
				delegate2 = @delegate;
				Delegate2 value2 = (Delegate2)FFXb5i9i.PcI4tKMj(delegate2, value, 32723);
				@delegate = Interlocked.CompareExchange(ref delegate2_0, value2, delegate2);
			}
			while ((object)@delegate != delegate2);
		}
	}

	public event m7w363Aw a2mJBd6O
	{
		[CompilerGenerated]
		add
		{
			m7w363Aw m7w363Aw = m7w363Aw_0;
			m7w363Aw m7w363Aw2;
			do
			{
				m7w363Aw2 = m7w363Aw;
				m7w363Aw value2 = (m7w363Aw)FFXb5i9i.PcI4tKMj(m7w363Aw2, value, 32722);
				m7w363Aw = Interlocked.CompareExchange(ref m7w363Aw_0, value2, m7w363Aw2);
			}
			while ((object)m7w363Aw != m7w363Aw2);
		}
		[CompilerGenerated]
		remove
		{
			m7w363Aw m7w363Aw = m7w363Aw_0;
			m7w363Aw m7w363Aw2;
			do
			{
				m7w363Aw2 = m7w363Aw;
				m7w363Aw value2 = (m7w363Aw)FFXb5i9i.PcI4tKMj(m7w363Aw2, value, 32723);
				m7w363Aw = Interlocked.CompareExchange(ref m7w363Aw_0, value2, m7w363Aw2);
			}
			while ((object)m7w363Aw != m7w363Aw2);
		}
	}

	public abstract void Ht1EgdTf(object OVA2H7Zb);

	public abstract object WCmKoO66();

	public abstract object BwqVaWK0();

	public abstract void dC0uarco(object bHp2vcIu);

	public abstract object qYCIFlIf();

	public abstract bool vmethod_0(string CbPdBGoh);

	public abstract void vmethod_1(object zkMvM1iw);

	public abstract void W0MxvDxd(object iY6aDAKI);

	public abstract void XKGcyo5e(object eWp01lT2);

	public abstract void YszpDrhZ();

	protected void gNoFword()
	{
		xshKt3Ao_0?.Invoke();
	}

	public void TqGMzBtk()
	{
		delegate2_0?.Invoke();
	}

	public void LSN8q6O5()
	{
		m7w363Aw_0?.Invoke();
	}

	public vilSnlZy(string vqtuarC4, string vQdXuv1O, string rGSNFANm, string YeDKE8ya, string Zja5VW2r)
	{
		SfsOq6EW = vqtuarC4;
		cUrlxEUV = vQdXuv1O;
		string_0 = rGSNFANm;
		string_1 = YeDKE8ya;
		tXzfJ9Wv = Zja5VW2r;
	}

	public vilSnlZy()
	{
	}

	public void NCgIovQg(ref XmlTextWriter RYHJd0qU)
	{
		ivlgLlId.NvtwUSYD(RYHJd0qU, "variable", 29799);
		if (ivlgLlId.smethod_3(cUrlxEUV, "", bool_0: false, 3221) != 0)
		{
			ivlgLlId.smethod_2(RYHJd0qU, "name", cUrlxEUV, 35368);
		}
		if (ivlgLlId.smethod_3(string_1, "", bool_0: false, 3221) != 0)
		{
			ivlgLlId.smethod_2(RYHJd0qU, "address", string_1, 35368);
		}
		ivlgLlId.NvtwUSYD(RYHJd0qU, "type", 29799);
		ivlgLlId.NvtwUSYD(RYHJd0qU, string_2, 29799);
		sSR2WoR5.QgTGUBli(RYHJd0qU, 36767);
		sSR2WoR5.QgTGUBli(RYHJd0qU, 36767);
		ivlgLlId.NvtwUSYD(RYHJd0qU, "initialValue", 29799);
		ivlgLlId.NvtwUSYD(RYHJd0qU, "simpleValue", 29799);
		ivlgLlId.smethod_2(RYHJd0qU, "value", EqZ3j4Ys(), 35368);
		sSR2WoR5.QgTGUBli(RYHJd0qU, 36767);
		sSR2WoR5.QgTGUBli(RYHJd0qU, 36767);
		sSR2WoR5.QgTGUBli(RYHJd0qU, 36767);
	}

	public void D6wVNRpm()
	{
		sSR2WoR5.IbTYXQVQ(this, 2531);
	}

	public string h2YblVSv()
	{
		return sSR2WoR5.wjVH1wdN(vRvDyS3Z.smethod_0(Class15.kJu0kMKf(45123), 40301), "{0}", new object[1] { BwqVaWK0() }, 26741);
	}

	public string EqZ3j4Ys()
	{
		return sSR2WoR5.wjVH1wdN(vRvDyS3Z.smethod_0(Class15.kJu0kMKf(45123), 40301), "{0}", new object[1] { qYCIFlIf() }, 26741);
	}

	public abstract MenuItem onTFrOWY();
}
