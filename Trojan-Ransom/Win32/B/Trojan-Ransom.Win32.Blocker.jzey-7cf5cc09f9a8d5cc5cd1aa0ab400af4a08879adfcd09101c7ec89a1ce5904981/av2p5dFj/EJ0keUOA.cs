using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using E21wpg6v;
using Microsoft.VisualBasic.CompilerServices;
using di1mqJMz;
using iiraiv39;
using sReLFYF2;

namespace av2p5dFj;

[Serializable]
internal class EJ0keUOA<a, A> : Dictionary<a, A>, IXmlSerializable
{
	public EJ0keUOA()
	{
	}

	protected EJ0keUOA(SerializationInfo IJoNk141, StreamingContext GPFMy6yu)
		: base(IJoNk141, GPFMy6yu)
	{
	}

	public XmlSchema xNirdGTR()
	{
		return null;
	}

	XmlSchema IXmlSerializable.GetSchema()
	{
		//ILSpy generated this explicit interface implementation from .override directive in xNirdGTR
		return this.xNirdGTR();
	}

	void IXmlSerializable.ReadXml(XmlReader YtwzkTXf)
	{
		XmlSerializer xmlSerializer_ = new XmlSerializer(m8meAX3U.NXTa0utH(typeof(a).TypeHandle, 9099), TzGdIOOz.smethod_0());
		XmlSerializer xmlSerializer_2 = new XmlSerializer(m8meAX3U.NXTa0utH(typeof(A).TypeHandle, 9099), TzGdIOOz.smethod_0());
		bool num = ivlgLlId.ODfvzYW0(YtwzkTXf, 44748);
		ivlgLlId.ODfvzYW0(YtwzkTXf, 44749);
		if (!num)
		{
			while (ivlgLlId.smethod_4(YtwzkTXf, 23181) != XmlNodeType.EndElement)
			{
				ivlgLlId.BvT3gNhf(YtwzkTXf, "item", 32575);
				ivlgLlId.BvT3gNhf(YtwzkTXf, "key", 32575);
				a key = Conversions.ToGenericParameter<a>(ivlgLlId.smethod_5(xmlSerializer_, YtwzkTXf, 55601));
				ivlgLlId.kVKRhwPJ(YtwzkTXf, 51578);
				ivlgLlId.BvT3gNhf(YtwzkTXf, "value", 32575);
				A value = Conversions.ToGenericParameter<A>(ivlgLlId.smethod_5(xmlSerializer_2, YtwzkTXf, 55601));
				ivlgLlId.kVKRhwPJ(YtwzkTXf, 51578);
				Add(key, value);
				ivlgLlId.kVKRhwPJ(YtwzkTXf, 51578);
				ivlgLlId.smethod_4(YtwzkTXf, 23180);
			}
			ivlgLlId.kVKRhwPJ(YtwzkTXf, 51578);
		}
	}

	public void PL5YjGZ1(XmlWriter writer)
	{
		XmlSerializer xmlSerializer_ = new XmlSerializer(m8meAX3U.NXTa0utH(typeof(a).TypeHandle, 9099), TzGdIOOz.smethod_0());
		XmlSerializer xmlSerializer_2 = new XmlSerializer(m8meAX3U.NXTa0utH(typeof(A).TypeHandle, 9099), TzGdIOOz.smethod_0());
		foreach (a key in base.Keys)
		{
			ivlgLlId.NvtwUSYD(writer, "item", 29799);
			ivlgLlId.NvtwUSYD(writer, "key", 29799);
			FFXb5i9i.UoxZtdZj(xmlSerializer_, writer, key, 19934);
			ivlgLlId.Ylza3LOJ(writer, 34997);
			ivlgLlId.NvtwUSYD(writer, "value", 29799);
			object object_ = base[key];
			try
			{
				FFXb5i9i.UoxZtdZj(xmlSerializer_2, writer, m8meAX3U.bErpAbl3(object_, 6598), 19934);
			}
			catch (Exception ex)
			{
				m8meAX3U.L6HgMKrR(ex, 21003);
				Exception hz5sFQEo = ex;
				pn1IqBv9.mRZ0d05U(ref hz5sFQEo);
				FFXb5i9i.LfyQ8gZ7(12759);
			}
			ivlgLlId.Ylza3LOJ(writer, 34997);
			ivlgLlId.Ylza3LOJ(writer, 34997);
		}
	}

	void IXmlSerializable.WriteXml(XmlWriter writer)
	{
		//ILSpy generated this explicit interface implementation from .override directive in PL5YjGZ1
		this.PL5YjGZ1(writer);
	}
}
