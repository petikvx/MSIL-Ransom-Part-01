using System.Drawing;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using iiraiv39;

namespace av2p5dFj;

[XmlRoot("color")]
internal class fJzr8BA3 : IXmlSerializable
{
	private Color eAJPDCKd;

	[XmlIgnore]
	public Color h9sk8rsy
	{
		get
		{
			return eAJPDCKd;
		}
		set
		{
			eAJPDCKd = value;
		}
	}

	public XmlSchema iqHHj9c5()
	{
		return null;
	}

	XmlSchema IXmlSerializable.GetSchema()
	{
		//ILSpy generated this explicit interface implementation from .override directive in iqHHj9c5
		return this.iqHHj9c5();
	}

	void IXmlSerializable.ReadXml(XmlReader HUhdBFb7)
	{
		bool num = ivlgLlId.ODfvzYW0(HUhdBFb7, 44748);
		ivlgLlId.ODfvzYW0(HUhdBFb7, 44749);
		if (!num)
		{
			if (ivlgLlId.nAlaEH39(HUhdBFb7, "value", 21833))
			{
				eAJPDCKd = ivlgLlId.AtDikAm1(ivlgLlId.smethod_0(HUhdBFb7, 13950), 57418);
			}
			ivlgLlId.kVKRhwPJ(HUhdBFb7, 51578);
		}
	}

	public void PL5YjGZ1(XmlWriter cL0Ctfcm)
	{
		ivlgLlId.NvtwUSYD(cL0Ctfcm, "color", 29799);
		ivlgLlId.smethod_2(cL0Ctfcm, "value", ivlgLlId.smethod_1(eAJPDCKd, 40222), 35368);
		ivlgLlId.Ylza3LOJ(cL0Ctfcm, 34997);
	}

	void IXmlSerializable.WriteXml(XmlWriter cL0Ctfcm)
	{
		//ILSpy generated this explicit interface implementation from .override directive in PL5YjGZ1
		this.PL5YjGZ1(cL0Ctfcm);
	}
}
