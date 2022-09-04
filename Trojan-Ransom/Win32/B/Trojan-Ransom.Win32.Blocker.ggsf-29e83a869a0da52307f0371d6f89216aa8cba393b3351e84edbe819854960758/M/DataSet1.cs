using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.IO;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using Microsoft.VisualBasic.CompilerServices;

namespace M;

[Serializable]
[XmlRoot("DataSet1")]
[XmlSchemaProvider("GetTypedDataSetSchema")]
public class DataSet1 : DataSet
{
	private SchemaSerializationMode _schemaSerializationMode;

	public override SchemaSerializationMode SchemaSerializationMode
	{
		get
		{
			return _schemaSerializationMode;
		}
		set
		{
			_schemaSerializationMode = value;
		}
	}

	public new DataTableCollection Tables => (DataTableCollection)d7o0ffuhfsvMS1250F(this);

	public new DataRelationCollection Relations => (DataRelationCollection)ep9b9bje0neTL93FQM(this);

	public DataSet1()
	{
		CollectionChangeEventHandler object_ = default(CollectionChangeEventHandler);
		while (true)
		{
			Mh5ckIkmU3cDXl5OtQ(this);
			while (true)
			{
				_schemaSerializationMode = SchemaSerializationMode.IncludeSchema;
				int num = 3;
				if (!g56YbGXw5AV0OOpSWF())
				{
					return;
				}
				while (true)
				{
					switch (num)
					{
					case 4:
					case 6:
						CAyWDyIZOh8JHOTK8G(ep9b9bje0neTL93FQM(this), object_);
						goto case 2;
					case 2:
						qhHWrlZkAAOCwv2ICy(this);
						num = 10;
						if (g56YbGXw5AV0OOpSWF())
						{
							continue;
						}
						goto case 8;
					case 8:
						object_ = SchemaChanged;
						goto default;
					default:
						_ = 1;
						if (yqCmTgxo0NcdKhYSSZ())
						{
							num = 4;
							if (g56YbGXw5AV0OOpSWF())
							{
								continue;
							}
							break;
						}
						goto case 5;
					case 5:
					case 9:
						CnB386MM8VeFhVWZGR(d7o0ffuhfsvMS1250F(this), object_);
						goto case 4;
					case 3:
						mpju5DVQrLGkwIJ1YK(this);
						goto case 0;
					case 0:
						Dx5NQfEYXb7lStRKFf(this);
						goto case 8;
					case 7:
						break;
					case 1:
						goto end_IL_009b;
					case 10:
						return;
					}
					break;
				}
				continue;
				end_IL_009b:
				break;
			}
		}
	}

	protected DataSet1(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0)
	{
		CollectionChangeEventHandler object_ = default(CollectionChangeEventHandler);
		CollectionChangeEventHandler object_2 = default(CollectionChangeEventHandler);
		while (true)
		{
			Dm2gyfcwKbwMW2okra(this, serializationInfo_0, streamingContext_0, bool_0: false);
			while (true)
			{
				_schemaSerializationMode = SchemaSerializationMode.IncludeSchema;
				while (true)
				{
					if (!twJRNc4iXKV4sn2XKJ(this, serializationInfo_0, streamingContext_0))
					{
						string s = (string)lkhyd1gfApNSG3ckuD(mekbPvwScHCfijPuyg(serializationInfo_0, "XmlSchema", ASeejjTQm6RaE5nTDO(typeof(string).TypeHandle)));
						while (true)
						{
							if (xjijA9eliKJXM6Fv1N(this, serializationInfo_0, streamingContext_0) == SchemaSerializationMode.IncludeSchema)
							{
								while (true)
								{
									DataSet dataSet = new DataSet();
									while (true)
									{
										kIcCf1AKnxh6aUikRv(dataSet, new XmlTextReader(new StringReader(s)));
										while (true)
										{
											KUN9ceLAEgyZPXwdX4(this, w1KduoGqjSRoTqwsGi(dataSet));
											while (true)
											{
												y0nis8aY7ht8HV3jAp(this, FY9q2HpNAlifebx4Oj(dataSet));
												while (true)
												{
													IL_00b2:
													B5BYPL79ufmVV6yZeL(this, O3PtbXvNle6R6O7QlK(dataSet));
													while (true)
													{
														DkAQSCfTitCrx16YxB(this, PutJPXPbgEpvhc3AiO(dataSet));
														if (!g56YbGXw5AV0OOpSWF())
														{
															break;
														}
														switch (11)
														{
														case 23:
															break;
														default:
															goto IL_00b2;
														case 17:
															goto end_IL_0026;
														case 25:
															goto end_IL_00c4;
														case 4:
															goto end_IL_00d2;
														case 1:
															goto end_IL_00e0;
														case 10:
															goto end_IL_00f3;
														case 5:
															goto end_IL_00fb;
														case 21:
															goto end_IL_010b;
														case 16:
															goto end_IL_011a;
														case 11:
															l9ffWSUZEdyWME3yaQ(this, fTNxvQ5NjPJBqB1Z26(dataSet));
															goto case 9;
														case 9:
															PFDeY2txDZ6K2Al373(this, QCrSUM2D15v2L8Iogv(dataSet));
															goto case 8;
														case 8:
															NPp4iKH7cnWL7TqSPu(this, dataSet, bool_0: false, MissingSchemaAction.Add);
															goto IL_018d;
														case 24:
															goto IL_0151;
														case 19:
															goto IL_0158;
														case 20:
															goto IL_0166;
														case 14:
															goto IL_0172;
														case 2:
														case 7:
															return;
														case 18:
														case 22:
															goto IL_018d;
														case 0:
														case 15:
															goto IL_01a6;
														case 6:
															goto IL_01ae;
														case 13:
															goto IL_01bc;
														case 12:
															goto IL_01c8;
														case 26:
															return;
														}
														continue;
														end_IL_0026:
														break;
													}
													break;
												}
												continue;
												end_IL_00c4:
												break;
											}
											continue;
											end_IL_00d2:
											break;
										}
										continue;
										end_IL_00e0:
										break;
									}
									continue;
									end_IL_00f3:
									break;
								}
								continue;
							}
							kIcCf1AKnxh6aUikRv(this, new XmlTextReader(new StringReader(s)));
							goto IL_01a6;
							continue;
							end_IL_00fb:
							break;
						}
						continue;
					}
					goto IL_0151;
					IL_01bc:
					CnB386MM8VeFhVWZGR(d7o0ffuhfsvMS1250F(this), object_);
					goto IL_01c8;
					IL_01c8:
					CAyWDyIZOh8JHOTK8G(eck9yfdGxu3yNpaqVf(this), object_);
					return;
					IL_0151:
					UvmX2OrTQcPFYbTPx3(this, bool_0: false);
					goto IL_0158;
					IL_0158:
					object_2 = SchemaChanged;
					goto IL_0166;
					IL_0166:
					CnB386MM8VeFhVWZGR(vFDFs7hmQlrIlZxGwQ(this), object_2);
					goto IL_0172;
					IL_0172:
					CAyWDyIZOh8JHOTK8G(eck9yfdGxu3yNpaqVf(this), object_2);
					g56YbGXw5AV0OOpSWF();
					if (!yqCmTgxo0NcdKhYSSZ())
					{
						return;
					}
					goto IL_018d;
					IL_018d:
					Xv57orRsS3Eb1wDM1W(this);
					goto IL_01a6;
					IL_01a6:
					GydCY0KxVwEtQiXC8H(this, serializationInfo_0, streamingContext_0);
					goto IL_01ae;
					IL_01ae:
					object_ = SchemaChanged;
					goto IL_01bc;
					continue;
					end_IL_010b:
					break;
				}
				continue;
				end_IL_011a:
				break;
			}
		}
	}

	protected override void InitializeDerivedDataSet()
	{
		_ = 0;
		if (g56YbGXw5AV0OOpSWF())
		{
			while (true)
			{
				mpju5DVQrLGkwIJ1YK(this);
				if (g56YbGXw5AV0OOpSWF())
				{
					switch (3)
					{
					case 0:
					case 4:
						continue;
					case 3:
						Dx5NQfEYXb7lStRKFf(this);
						break;
					case 5:
						return;
					}
				}
				break;
			}
		}
		qhHWrlZkAAOCwv2ICy(this);
	}

	public override DataSet Clone()
	{
		_ = 1;
		DataSet1 dataSet = default(DataSet1);
		if (!yqCmTgxo0NcdKhYSSZ())
		{
			while (true)
			{
				dataSet = (DataSet1)QoU2tvsiUsDfF1iGKt(this);
				if (yqCmTgxo0NcdKhYSSZ())
				{
				}
				switch (4)
				{
				case 0:
				case 1:
					break;
				case 4:
					Xv57orRsS3Eb1wDM1W(dataSet);
					goto end_IL_0009;
				default:
					goto end_IL_0009;
				case 5:
					goto IL_0055;
				}
				continue;
				end_IL_0009:
				break;
			}
		}
		j24yBLSgcDCF6lIEQJ(dataSet, CYBuV0m1rQhXbuPjim(this));
		goto IL_0055;
		IL_0055:
		return dataSet;
	}

	protected override bool ShouldSerializeTables()
	{
		return false;
	}

	protected override bool ShouldSerializeRelations()
	{
		return false;
	}

	protected override void ReadXmlSerializable(XmlReader reader)
	{
		if (yqCmTgxo0NcdKhYSSZ())
		{
		}
		DataSet dataSet = default(DataSet);
		switch (1)
		{
		case 1:
			if (yEa12RNKtFFaH2UAoA(this, reader) == SchemaSerializationMode.IncludeSchema)
			{
				goto case 6;
			}
			JaPggN91LmhojfTow9(this, reader);
			goto case 2;
		case 2:
			Xv57orRsS3Eb1wDM1W(this);
			return;
		case 6:
			POed2UOuTwYkt4OsoQ(this);
			goto case 0;
		case 0:
			dataSet = new DataSet();
			goto case 15;
		case 15:
			JaPggN91LmhojfTow9(dataSet, reader);
			goto case 3;
		case 3:
			KUN9ceLAEgyZPXwdX4(this, w1KduoGqjSRoTqwsGi(dataSet));
			goto case 11;
		case 11:
			y0nis8aY7ht8HV3jAp(this, FY9q2HpNAlifebx4Oj(dataSet));
			goto case 7;
		case 7:
			B5BYPL79ufmVV6yZeL(this, O3PtbXvNle6R6O7QlK(dataSet));
			goto case 13;
		case 13:
			DkAQSCfTitCrx16YxB(this, PutJPXPbgEpvhc3AiO(dataSet));
			goto default;
		default:
			l9ffWSUZEdyWME3yaQ(this, fTNxvQ5NjPJBqB1Z26(dataSet));
			_ = 0;
			if (g56YbGXw5AV0OOpSWF())
			{
				goto case 4;
			}
			goto case 10;
		case 4:
		case 9:
			PFDeY2txDZ6K2Al373(this, QCrSUM2D15v2L8Iogv(dataSet));
			goto case 10;
		case 10:
		case 12:
			NPp4iKH7cnWL7TqSPu(this, dataSet, bool_0: false, MissingSchemaAction.Add);
			break;
		case 14:
			break;
		case 8:
		case 16:
			return;
		}
		Xv57orRsS3Eb1wDM1W(this);
	}

	protected override XmlSchema GetSchemaSerializable()
	{
		MemoryStream memoryStream = new MemoryStream();
		_ = 0;
		if (g56YbGXw5AV0OOpSWF())
		{
			O3shaWYv1vyx2srcFT(this, new XmlTextWriter(memoryStream, null));
		}
		DQC5dxBhbOTgP50X4N(memoryStream, 0L);
		return (XmlSchema)fDgMeJbdqaphAbnlvM(new XmlTextReader(memoryStream), null);
	}

	internal void InitVars()
	{
		UvmX2OrTQcPFYbTPx3(this, bool_0: true);
	}

	internal void InitVars(bool bool_0)
	{
	}

	private void InitClass()
	{
		KUN9ceLAEgyZPXwdX4(this, "DataSet1");
		y0nis8aY7ht8HV3jAp(this, "");
		B5BYPL79ufmVV6yZeL(this, "http://tempuri.org/DataSet1.xsd");
		_ = 1;
		if (!yqCmTgxo0NcdKhYSSZ())
		{
			PFDeY2txDZ6K2Al373(this, bool_0: true);
		}
		j24yBLSgcDCF6lIEQJ(this, SchemaSerializationMode.IncludeSchema);
	}

	private void SchemaChanged(object sender, CollectionChangeEventArgs e)
	{
		if (XATZ2W6tSgLepAN7Yq(e) == CollectionChangeAction.Remove)
		{
			Xv57orRsS3Eb1wDM1W(this);
		}
	}

	public static XmlSchemaComplexType GetTypedDataSetSchema(XmlSchemaSet xmlSchemaSet_0)
	{
		DataSet1 object_ = new DataSet1();
		XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
		XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
		XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
		_ = 0;
		if (g56YbGXw5AV0OOpSWF())
		{
			NGJwyX0iJbEfbsqyaO(xmlSchemaAny, O3PtbXvNle6R6O7QlK(object_));
		}
		t1EL4ylGtrOk6CfSGs(NWeF7pyIrS7oT8tWyb(xmlSchemaSequence), xmlSchemaAny);
		z9QLB880MG6dYHs0HA(xmlSchemaComplexType, xmlSchemaSequence);
		XmlSchema xmlSchema = (XmlSchema)ITYRrADRYJHJ9240uP(object_);
		if (A5C2m3Fkl4CouaxJcM(xmlSchemaSet_0, xpSImJJyBIfNyZbpe8(xmlSchema)))
		{
			MemoryStream memoryStream = new MemoryStream();
			MemoryStream memoryStream2 = new MemoryStream();
			try
			{
				XmlSchema xmlSchema2 = null;
				CLdTyJWCPgGpI989VD(xmlSchema, memoryStream);
				XmlSchemaComplexType result = default(XmlSchemaComplexType);
				while (true)
				{
					IL_01aa:
					IEnumerator object_2 = (IEnumerator)ueIEsDqwNPduDDLGun(NfgYgRQUUjkHySDvgM(xmlSchemaSet_0, xpSImJJyBIfNyZbpe8(xmlSchema)));
					while (hqa7wkoCdnlVFwd5Qly(object_2))
					{
						xmlSchema2 = (XmlSchema)s0a0EyitF9yZLY9RO6(object_2);
						while (true)
						{
							I8v0IAzQTKH2bjMZKc(memoryStream2, 0L);
							_ = 1;
							int num;
							if (yqCmTgxo0NcdKhYSSZ())
							{
								num = 11;
								if (yqCmTgxo0NcdKhYSSZ())
								{
									break;
								}
								goto IL_0152;
							}
							goto IL_0147;
							IL_0152:
							while (true)
							{
								switch (num)
								{
								case 9:
									break;
								default:
									DQC5dxBhbOTgP50X4N(memoryStream2, 0L);
									goto case 8;
								case 12:
									if (SXuBvdo3O4gyF9esOXG(memoryStream) == SXuBvdo3O4gyF9esOXG(memoryStream2))
									{
										goto case 8;
									}
									goto case 6;
								case 8:
									if (EIVLhToocRfjEeXhy5k(memoryStream) != CeJGTionH2bPL6kTjfN(memoryStream))
									{
										goto case 12;
									}
									goto case 6;
								case 6:
									if (EIVLhToocRfjEeXhy5k(memoryStream) != CeJGTionH2bPL6kTjfN(memoryStream))
									{
										goto IL_019b;
									}
									goto case 10;
								case 10:
								case 11:
									result = xmlSchemaComplexType;
									num = 2;
									if (g56YbGXw5AV0OOpSWF())
									{
										continue;
									}
									goto end_IL_019b;
								case 7:
									DQC5dxBhbOTgP50X4N(memoryStream, 0L);
									goto default;
								case 1:
									goto IL_012a;
								case 3:
								case 4:
									goto IL_0147;
								case 5:
									goto IL_019b;
								case 0:
									goto end_IL_008b;
								case 14:
									goto end_IL_019b;
								case 2:
									return result;
								}
								break;
							}
							continue;
							IL_0147:
							CLdTyJWCPgGpI989VD(xmlSchema2, memoryStream2);
							goto IL_012a;
							IL_012a:
							if (CeJGTionH2bPL6kTjfN(memoryStream) != CeJGTionH2bPL6kTjfN(memoryStream2))
							{
								goto IL_019b;
							}
							num = 7;
							if (yqCmTgxo0NcdKhYSSZ())
							{
								goto IL_0147;
							}
							goto IL_0152;
							continue;
							end_IL_008b:
							break;
						}
						goto IL_01aa;
						continue;
						end_IL_019b:
						break;
						IL_019b:;
					}
					break;
				}
			}
			finally
			{
				if (memoryStream != null)
				{
					s92OQJo1RmouwAMRqLo(memoryStream);
				}
				if (memoryStream2 != null)
				{
					s92OQJo1RmouwAMRqLo(memoryStream2);
				}
			}
		}
		aYo9ieoX8RTmwZ8CNv8(xmlSchemaSet_0, xmlSchema);
		return xmlSchemaComplexType;
	}

	internal static void Mh5ckIkmU3cDXl5OtQ(object object_0)
	{
		((DataSet)object_0)._002Ector();
	}

	internal static void mpju5DVQrLGkwIJ1YK(object object_0)
	{
		((DataSet)object_0).BeginInit();
	}

	internal static void Dx5NQfEYXb7lStRKFf(object object_0)
	{
		((DataSet1)object_0).InitClass();
	}

	internal static object d7o0ffuhfsvMS1250F(object object_0)
	{
		return ((DataSet)object_0).Tables;
	}

	internal static void CnB386MM8VeFhVWZGR(object object_0, object object_1)
	{
		((DataTableCollection)object_0).CollectionChanged += (CollectionChangeEventHandler?)object_1;
	}

	internal static object ep9b9bje0neTL93FQM(object object_0)
	{
		return ((DataSet)object_0).Relations;
	}

	internal static void CAyWDyIZOh8JHOTK8G(object object_0, object object_1)
	{
		((DataRelationCollection)object_0).CollectionChanged += (CollectionChangeEventHandler?)object_1;
	}

	internal static void qhHWrlZkAAOCwv2ICy(object object_0)
	{
		((DataSet)object_0).EndInit();
	}

	internal static bool g56YbGXw5AV0OOpSWF()
	{
		return true;
	}

	internal static bool yqCmTgxo0NcdKhYSSZ()
	{
		return false;
	}

	internal static void Dm2gyfcwKbwMW2okra(object object_0, object object_1, StreamingContext streamingContext_0, bool bool_0)
	{
		((DataSet)object_0)._002Ector((SerializationInfo)object_1, streamingContext_0, bool_0);
	}

	internal static bool twJRNc4iXKV4sn2XKJ(object object_0, object object_1, StreamingContext streamingContext_0)
	{
		return ((DataSet)object_0).IsBinarySerialized((SerializationInfo)object_1, streamingContext_0);
	}

	internal static void UvmX2OrTQcPFYbTPx3(object object_0, bool bool_0)
	{
		((DataSet1)object_0).InitVars(bool_0);
	}

	internal static object vFDFs7hmQlrIlZxGwQ(object object_0)
	{
		return ((DataSet1)object_0).Tables;
	}

	internal static object eck9yfdGxu3yNpaqVf(object object_0)
	{
		return ((DataSet1)object_0).Relations;
	}

	internal static Type ASeejjTQm6RaE5nTDO(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static object mekbPvwScHCfijPuyg(object object_0, object object_1, Type type_0)
	{
		return ((SerializationInfo)object_0).GetValue((string)object_1, type_0);
	}

	internal static object lkhyd1gfApNSG3ckuD(object object_0)
	{
		return Conversions.ToString(object_0);
	}

	internal static SchemaSerializationMode xjijA9eliKJXM6Fv1N(object object_0, object object_1, StreamingContext streamingContext_0)
	{
		return ((DataSet)object_0).DetermineSchemaSerializationMode((SerializationInfo)object_1, streamingContext_0);
	}

	internal static void kIcCf1AKnxh6aUikRv(object object_0, object object_1)
	{
		((DataSet)object_0).ReadXmlSchema((XmlReader?)object_1);
	}

	internal static object w1KduoGqjSRoTqwsGi(object object_0)
	{
		return ((DataSet)object_0).DataSetName;
	}

	internal static void KUN9ceLAEgyZPXwdX4(object object_0, object object_1)
	{
		((DataSet)object_0).DataSetName = (string)object_1;
	}

	internal static object FY9q2HpNAlifebx4Oj(object object_0)
	{
		return ((DataSet)object_0).Prefix;
	}

	internal static void y0nis8aY7ht8HV3jAp(object object_0, object object_1)
	{
		((DataSet)object_0).Prefix = (string)object_1;
	}

	internal static object O3PtbXvNle6R6O7QlK(object object_0)
	{
		return ((DataSet)object_0).Namespace;
	}

	internal static void B5BYPL79ufmVV6yZeL(object object_0, object object_1)
	{
		((DataSet)object_0).Namespace = (string)object_1;
	}

	internal static object PutJPXPbgEpvhc3AiO(object object_0)
	{
		return ((DataSet)object_0).Locale;
	}

	internal static void DkAQSCfTitCrx16YxB(object object_0, object object_1)
	{
		((DataSet)object_0).Locale = (CultureInfo)object_1;
	}

	internal static bool fTNxvQ5NjPJBqB1Z26(object object_0)
	{
		return ((DataSet)object_0).CaseSensitive;
	}

	internal static void l9ffWSUZEdyWME3yaQ(object object_0, bool bool_0)
	{
		((DataSet)object_0).CaseSensitive = bool_0;
	}

	internal static bool QCrSUM2D15v2L8Iogv(object object_0)
	{
		return ((DataSet)object_0).EnforceConstraints;
	}

	internal static void PFDeY2txDZ6K2Al373(object object_0, bool bool_0)
	{
		((DataSet)object_0).EnforceConstraints = bool_0;
	}

	internal static void NPp4iKH7cnWL7TqSPu(object object_0, object object_1, bool bool_0, MissingSchemaAction missingSchemaAction_0)
	{
		((DataSet)object_0).Merge((DataSet)object_1, bool_0, missingSchemaAction_0);
	}

	internal static void Xv57orRsS3Eb1wDM1W(object object_0)
	{
		((DataSet1)object_0).InitVars();
	}

	internal static void GydCY0KxVwEtQiXC8H(object object_0, object object_1, StreamingContext streamingContext_0)
	{
		((DataSet)object_0).GetSerializationData((SerializationInfo)object_1, streamingContext_0);
	}

	internal static object QoU2tvsiUsDfF1iGKt(object object_0)
	{
		return ((DataSet)object_0).Clone();
	}

	internal static SchemaSerializationMode CYBuV0m1rQhXbuPjim(object object_0)
	{
		return ((DataSet1)object_0).SchemaSerializationMode;
	}

	internal static void j24yBLSgcDCF6lIEQJ(object object_0, SchemaSerializationMode schemaSerializationMode_0)
	{
		((DataSet1)object_0).SchemaSerializationMode = schemaSerializationMode_0;
	}

	internal static SchemaSerializationMode yEa12RNKtFFaH2UAoA(object object_0, object object_1)
	{
		return ((DataSet)object_0).DetermineSchemaSerializationMode((XmlReader)object_1);
	}

	internal static void POed2UOuTwYkt4OsoQ(object object_0)
	{
		((DataSet)object_0).Reset();
	}

	internal static XmlReadMode JaPggN91LmhojfTow9(object object_0, object object_1)
	{
		return ((DataSet)object_0).ReadXml((XmlReader?)object_1);
	}

	internal static void O3shaWYv1vyx2srcFT(object object_0, object object_1)
	{
		((DataSet)object_0).WriteXmlSchema((XmlWriter?)object_1);
	}

	internal static void DQC5dxBhbOTgP50X4N(object object_0, long long_0)
	{
		((MemoryStream)object_0).Position = long_0;
	}

	internal static object fDgMeJbdqaphAbnlvM(object object_0, object object_1)
	{
		return XmlSchema.Read((XmlReader)object_0, (ValidationEventHandler?)object_1);
	}

	internal static CollectionChangeAction XATZ2W6tSgLepAN7Yq(object object_0)
	{
		return ((CollectionChangeEventArgs)object_0).Action;
	}

	internal static void NGJwyX0iJbEfbsqyaO(object object_0, object object_1)
	{
		((XmlSchemaAny)object_0).Namespace = (string?)object_1;
	}

	internal static object NWeF7pyIrS7oT8tWyb(object object_0)
	{
		return ((XmlSchemaSequence)object_0).Items;
	}

	internal static int t1EL4ylGtrOk6CfSGs(object object_0, object object_1)
	{
		return ((XmlSchemaObjectCollection)object_0).Add((XmlSchemaObject)object_1);
	}

	internal static void z9QLB880MG6dYHs0HA(object object_0, object object_1)
	{
		((XmlSchemaComplexType)object_0).Particle = (XmlSchemaParticle?)object_1;
	}

	internal static object ITYRrADRYJHJ9240uP(object object_0)
	{
		return ((DataSet1)object_0).GetSchemaSerializable();
	}

	internal static object xpSImJJyBIfNyZbpe8(object object_0)
	{
		return ((XmlSchema)object_0).TargetNamespace;
	}

	internal static bool A5C2m3Fkl4CouaxJcM(object object_0, object object_1)
	{
		return ((XmlSchemaSet)object_0).Contains((string?)object_1);
	}

	internal static void CLdTyJWCPgGpI989VD(object object_0, object object_1)
	{
		((XmlSchema)object_0).Write((Stream)object_1);
	}

	internal static object NfgYgRQUUjkHySDvgM(object object_0, object object_1)
	{
		return ((XmlSchemaSet)object_0).Schemas((string?)object_1);
	}

	internal static object ueIEsDqwNPduDDLGun(object object_0)
	{
		return ((IEnumerable)object_0).GetEnumerator();
	}

	internal static object s0a0EyitF9yZLY9RO6(object object_0)
	{
		return ((IEnumerator)object_0).Current;
	}

	internal static void I8v0IAzQTKH2bjMZKc(object object_0, long long_0)
	{
		((MemoryStream)object_0).SetLength(long_0);
	}

	internal static long CeJGTionH2bPL6kTjfN(object object_0)
	{
		return ((MemoryStream)object_0).Length;
	}

	internal static long EIVLhToocRfjEeXhy5k(object object_0)
	{
		return ((MemoryStream)object_0).Position;
	}

	internal static int SXuBvdo3O4gyF9esOXG(object object_0)
	{
		return ((MemoryStream)object_0).ReadByte();
	}

	internal static bool hqa7wkoCdnlVFwd5Qly(object object_0)
	{
		return ((IEnumerator)object_0).MoveNext();
	}

	internal static void s92OQJo1RmouwAMRqLo(object object_0)
	{
		((Stream)object_0).Close();
	}

	internal static object aYo9ieoX8RTmwZ8CNv8(object object_0, object object_1)
	{
		return ((XmlSchemaSet)object_0).Add((XmlSchema)object_1);
	}
}
