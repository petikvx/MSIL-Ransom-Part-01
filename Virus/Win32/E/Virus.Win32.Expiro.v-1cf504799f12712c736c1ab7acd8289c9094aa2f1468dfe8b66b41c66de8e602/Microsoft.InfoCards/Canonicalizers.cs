using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal sealed class Canonicalizers
{
	private delegate byte[] CanonicalizeObjectCallback(object dataToHash);

	private abstract class CanonicalizerBase : ICanonicalizer
	{
		private bool m_hashValue;

		public CanonicalizerBase(bool hashValue)
		{
			m_hashValue = hashValue;
		}

		public byte[] Canonicalize(object obj)
		{
			if (obj == null)
			{
				throw InfoCardTrace.ThrowHelperArgumentNull("obj");
			}
			byte[] rawForm = GetRawForm(obj);
			if (!m_hashValue)
			{
				return rawForm;
			}
			byte[] array = new byte[HashUtility.HashBufferLength];
			HashUtility.SetHashValue(array, 0, rawForm);
			return array;
		}

		public abstract bool CanCanonicalize(object obj);

		protected abstract byte[] GetRawForm(object obj);
	}

	private class BinaryCanonicalizer : CanonicalizerBase
	{
		private Dictionary<Type, CanonicalizeObjectCallback> m_canonicalizers;

		public BinaryCanonicalizer(bool hashValue)
			: base(hashValue)
		{
			m_canonicalizers = new Dictionary<Type, CanonicalizeObjectCallback>();
			CreateCanonicalizers();
		}

		public override bool CanCanonicalize(object obj)
		{
			if (obj == null)
			{
				throw InfoCardTrace.ThrowHelperArgumentNull("obj");
			}
			return m_canonicalizers.ContainsKey(obj.GetType());
		}

		private void CreateCanonicalizers()
		{
			m_canonicalizers.Add(typeof(short), CanonicalizeInt16);
			m_canonicalizers.Add(typeof(ushort), CanonicalizeUInt16);
			m_canonicalizers.Add(typeof(int), CanonicalizeInt32);
			m_canonicalizers.Add(typeof(uint), CanonicalizeUInt32);
			m_canonicalizers.Add(typeof(long), CanonicalizeInt64);
			m_canonicalizers.Add(typeof(ulong), CanonicalizeUInt64);
			m_canonicalizers.Add(typeof(byte), CanonicalizeByte);
			m_canonicalizers.Add(typeof(byte[]), CanonicalizeByteArray);
			m_canonicalizers.Add(typeof(string), CanonicalizeString);
			m_canonicalizers.Add(typeof(Guid), CanonicalizeGuid);
			m_canonicalizers.Add(typeof(GlobalId), CanonicalizeGlobalId);
		}

		protected override byte[] GetRawForm(object obj)
		{
			return m_canonicalizers[obj.GetType()](obj);
		}

		private byte[] CanonicalizeGlobalId(object data)
		{
			if (data == null)
			{
				throw InfoCardTrace.ThrowHelperArgumentNull("data");
			}
			return ((Guid)(GlobalId)data).ToByteArray();
		}

		private byte[] CanonicalizeGuid(object data)
		{
			if (data == null)
			{
				throw InfoCardTrace.ThrowHelperArgumentNull("data");
			}
			return ((Guid)data).ToByteArray();
		}

		private unsafe byte[] CanonicalizeInt16(object data)
		{
			if (data == null)
			{
				throw InfoCardTrace.ThrowHelperArgumentNull("data");
			}
			short num = (short)data;
			byte[] array = new byte[2];
			fixed (byte* ptr = &array[0])
			{
				*(short*)ptr = num;
			}
			return array;
		}

		private unsafe byte[] CanonicalizeUInt16(object data)
		{
			if (data == null)
			{
				throw InfoCardTrace.ThrowHelperArgumentNull("data");
			}
			ushort num = (ushort)data;
			byte[] array = new byte[2];
			fixed (byte* ptr = &array[0])
			{
				*(ushort*)ptr = num;
			}
			return array;
		}

		private unsafe byte[] CanonicalizeInt32(object data)
		{
			if (data == null)
			{
				throw InfoCardTrace.ThrowHelperArgumentNull("data");
			}
			int num = (int)data;
			byte[] array = new byte[4];
			fixed (byte* ptr = &array[0])
			{
				*(int*)ptr = num;
			}
			return array;
		}

		private unsafe byte[] CanonicalizeUInt32(object data)
		{
			if (data == null)
			{
				throw InfoCardTrace.ThrowHelperArgumentNull("data");
			}
			uint num = (uint)data;
			byte[] array = new byte[4];
			fixed (byte* ptr = &array[0])
			{
				*(uint*)ptr = num;
			}
			return array;
		}

		private unsafe byte[] CanonicalizeInt64(object data)
		{
			if (data == null)
			{
				throw InfoCardTrace.ThrowHelperArgumentNull("data");
			}
			long num = (long)data;
			byte[] array = new byte[8];
			fixed (byte* ptr = &array[0])
			{
				*(long*)ptr = num;
			}
			return array;
		}

		private unsafe byte[] CanonicalizeUInt64(object data)
		{
			if (data == null)
			{
				throw InfoCardTrace.ThrowHelperArgumentNull("data");
			}
			ulong num = (ulong)data;
			byte[] array = new byte[8];
			fixed (byte* ptr = &array[0])
			{
				*(ulong*)ptr = num;
			}
			return array;
		}

		private byte[] CanonicalizeString(object data)
		{
			if (data == null)
			{
				throw InfoCardTrace.ThrowHelperArgumentNull("data");
			}
			string text = (string)data;
			if (string.IsNullOrEmpty(text))
			{
				throw InfoCardTrace.ThrowHelperArgumentNull("data");
			}
			return Encoding.Unicode.GetBytes(text);
		}

		private byte[] CanonicalizeByte(object data)
		{
			if (data == null)
			{
				throw InfoCardTrace.ThrowHelperArgumentNull("data");
			}
			byte b = (byte)data;
			return new byte[1] { b };
		}

		private byte[] CanonicalizeByteArray(object data)
		{
			if (data == null)
			{
				throw InfoCardTrace.ThrowHelperArgumentNull("data");
			}
			return (byte[])data;
		}
	}

	private abstract class StringCanonicalizerBase : CanonicalizerBase
	{
		private static readonly Type[] s_validTypes = new Type[2]
		{
			typeof(string),
			typeof(Uri)
		};

		private Encoding m_encoding;

		private CultureInfo m_culture;

		protected virtual Type[] SupportedTypes => s_validTypes;

		public CultureInfo Culture => m_culture;

		public Encoding Encoding => m_encoding;

		protected StringCanonicalizerBase(bool hashValue, Encoding encoding, CultureInfo culture)
			: base(hashValue)
		{
			if (encoding == null)
			{
				throw InfoCardTrace.ThrowHelperArgumentNull("encoding");
			}
			if (culture == null)
			{
				m_culture = CultureInfo.InvariantCulture;
			}
			else
			{
				m_culture = culture;
			}
			m_encoding = encoding;
		}

		public override bool CanCanonicalize(object obj)
		{
			if (obj == null)
			{
				throw InfoCardTrace.ThrowHelperArgumentNull("obj");
			}
			if (SupportedTypes == null)
			{
				return false;
			}
			return -1 != Array.IndexOf(SupportedTypes, obj.GetType());
		}

		protected override byte[] GetRawForm(object obj)
		{
			string data = obj.ToString();
			return GetBytesFromString(data);
		}

		protected abstract byte[] GetBytesFromString(string data);
	}

	private class CaseSensitiveCanonicalizer : StringCanonicalizerBase
	{
		public CaseSensitiveCanonicalizer(bool hashValue, Encoding encoding, CultureInfo culture)
			: base(hashValue, encoding, culture)
		{
		}

		protected override byte[] GetBytesFromString(string data)
		{
			return base.Encoding.GetBytes(data);
		}
	}

	private class CaseInsensitiveCanonicalizer : StringCanonicalizerBase
	{
		public CaseInsensitiveCanonicalizer(bool hashValue, Encoding encoding, CultureInfo culture)
			: base(hashValue, encoding, culture)
		{
		}

		protected override byte[] GetBytesFromString(string obj)
		{
			return base.Encoding.GetBytes(base.Culture.TextInfo.ToUpper(obj));
		}
	}

	private static ICanonicalizer s_binary;

	private static ICanonicalizer s_caseInsensitiveWithHashing;

	private static ICanonicalizer s_caseSensitiveWithHashing;

	private static ICanonicalizer s_binaryWithHashing;

	public static ICanonicalizer CaseInsensitiveWithHashing
	{
		get
		{
			if (s_caseInsensitiveWithHashing == null)
			{
				s_caseInsensitiveWithHashing = new CaseInsensitiveCanonicalizer(hashValue: true, Encoding.Unicode, CultureInfo.InvariantCulture);
			}
			return s_caseInsensitiveWithHashing;
		}
	}

	public static ICanonicalizer CaseSensitiveWithHashing
	{
		get
		{
			if (s_caseSensitiveWithHashing == null)
			{
				s_caseSensitiveWithHashing = new CaseSensitiveCanonicalizer(hashValue: true, Encoding.Unicode, CultureInfo.InvariantCulture);
			}
			return s_caseSensitiveWithHashing;
		}
	}

	public static ICanonicalizer Binary
	{
		get
		{
			if (s_binary == null)
			{
				s_binary = new BinaryCanonicalizer(hashValue: false);
			}
			return s_binary;
		}
	}

	public static ICanonicalizer BinaryWithHashing
	{
		get
		{
			if (s_binaryWithHashing == null)
			{
				s_binaryWithHashing = new BinaryCanonicalizer(hashValue: true);
			}
			return s_binaryWithHashing;
		}
	}

	private Canonicalizers()
	{
	}
}
