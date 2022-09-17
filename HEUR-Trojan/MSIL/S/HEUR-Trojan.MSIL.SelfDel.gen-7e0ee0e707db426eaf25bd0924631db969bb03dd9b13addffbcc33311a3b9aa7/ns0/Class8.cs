using System;
using System.Security.Cryptography;
using System.Text;

namespace ns0;

internal sealed class Class8
{
	public sealed class Class9 : SymmetricAlgorithm
	{
		internal sealed class Class10 : IDisposable, ICryptoTransform
		{
			internal static readonly byte[] byte_0 = Encoding.ASCII.GetBytes("expand 32-byte k");

			internal static readonly byte[] byte_1 = Encoding.ASCII.GetBytes("expand 16-byte k");

			internal uint[] uint_0;

			internal readonly int int_0;

			bool ICryptoTransform.CanReuseTransform => false;

			bool ICryptoTransform.CanTransformMultipleBlocks => true;

			int ICryptoTransform.InputBlockSize => 64;

			int ICryptoTransform.OutputBlockSize => 64;

			public Class10(byte[] byte_2, byte[] byte_3, int int_1)
			{
				Class21.smethod_3(byte_3, byte_2, this);
				int_0 = int_1;
			}

			int ICryptoTransform.TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset)
			{
				if (inputBuffer == null)
				{
					throw new ArgumentNullException("inputBuffer");
				}
				if (inputOffset >= 0 && inputOffset < inputBuffer.Length)
				{
					if (inputCount >= 0 && inputOffset + inputCount <= inputBuffer.Length)
					{
						if (outputBuffer == null)
						{
							throw new ArgumentNullException("outputBuffer");
						}
						if (outputOffset >= 0 && outputOffset + inputCount <= outputBuffer.Length)
						{
							if (uint_0 == null)
							{
								throw new ObjectDisposedException(GetType().Name);
							}
							byte[] array = new byte[64];
							int num = 0;
							while (inputCount > 0)
							{
								Class21.smethod_101(this, array, uint_0);
								uint_0[8] = uint_0[8] + 1;
								if (uint_0[8] == 0)
								{
									uint_0[9] = uint_0[9] + 1;
								}
								int num2 = Math.Min(64, inputCount);
								for (int i = 0; i < num2; i++)
								{
									outputBuffer[outputOffset + i] = (byte)(inputBuffer[inputOffset + i] ^ array[i]);
								}
								num += num2;
								inputCount -= 64;
								outputOffset += 64;
								inputOffset += 64;
							}
							return num;
						}
						throw new ArgumentOutOfRangeException("outputOffset");
					}
					throw new ArgumentOutOfRangeException("inputCount");
				}
				throw new ArgumentOutOfRangeException("inputOffset");
			}

			byte[] ICryptoTransform.TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount)
			{
				if (inputCount < 0)
				{
					throw new ArgumentOutOfRangeException("inputCount");
				}
				byte[] array = new byte[inputCount];
				((ICryptoTransform)this).TransformBlock(inputBuffer, inputOffset, inputCount, array, 0);
				return array;
			}

			void IDisposable.Dispose()
			{
				if (uint_0 != null)
				{
					Array.Clear(uint_0, 0, uint_0.Length);
				}
				uint_0 = null;
			}
		}

		private int int_0;

		byte[] SymmetricAlgorithm.IV
		{
			get
			{
				return base.IV;
			}
			set
			{
				Class21.smethod_33(value, "value");
				IVValue = (byte[])value.Clone();
			}
		}

		public Class9()
		{
			LegalBlockSizesValue = new KeySizes[1]
			{
				new KeySizes(512, 512, 0)
			};
			LegalKeySizesValue = new KeySizes[1]
			{
				new KeySizes(128, 256, 128)
			};
			BlockSizeValue = 512;
			KeySizeValue = 256;
			int_0 = 20;
		}

		ICryptoTransform SymmetricAlgorithm.CreateDecryptor(byte[] rgbKey, byte[] rgbIV)
		{
			return CreateEncryptor(rgbKey, rgbIV);
		}

		ICryptoTransform SymmetricAlgorithm.CreateEncryptor(byte[] rgbKey, byte[] rgbIV)
		{
			if (rgbKey == null)
			{
				throw new ArgumentNullException("rgbKey");
			}
			if (!ValidKeySize(rgbKey.Length * 8))
			{
				throw new CryptographicException("Invalid key size; it must be 128 or 256 bits.");
			}
			Class21.smethod_33(rgbIV, "rgbIV");
			return new Class10(rgbKey, rgbIV, int_0);
		}

		void SymmetricAlgorithm.GenerateIV()
		{
			IVValue = Class21.smethod_5(8);
		}

		void SymmetricAlgorithm.GenerateKey()
		{
			KeyValue = Class21.smethod_5(KeySize / 8);
		}
	}
}
