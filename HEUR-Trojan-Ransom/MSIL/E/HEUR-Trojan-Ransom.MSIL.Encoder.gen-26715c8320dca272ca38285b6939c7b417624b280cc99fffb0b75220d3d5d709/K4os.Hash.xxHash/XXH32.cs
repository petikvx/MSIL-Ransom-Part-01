using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace K4os.Hash.xxHash;

public class XXH32 : XXH
{
	private struct XXH32_state
	{
		public uint total_len_32;

		public bool large_len;

		public uint v1;

		public uint v2;

		public uint v3;

		public uint v4;

		public unsafe fixed uint mem32[4];

		public uint memsize;
	}

	private const uint PRIME32_1 = 2654435761u;

	private const uint PRIME32_2 = 2246822519u;

	private const uint PRIME32_3 = 3266489917u;

	private const uint PRIME32_4 = 668265263u;

	private const uint PRIME32_5 = 374761393u;

	public const uint EmptyHash = 46947589u;

	private XXH32_state _state;

	private static uint XXH32_rotl(uint x, int r)
	{
		return (x << r) | (x >> 32 - r);
	}

	private static uint XXH32_round(uint seed, uint input)
	{
		return XXH32_rotl(seed + (uint)((int)input * -2048144777), 13) * 2654435761u;
	}

	private unsafe static uint XXH32_hash(void* input, int len, uint seed)
	{
		byte* ptr = (byte*)input;
		byte* ptr2 = ptr + len;
		uint num5;
		if (len >= 16)
		{
			byte* ptr3 = ptr2 - 16;
			uint num = (uint)((int)seed + -1640531535 + -2048144777);
			uint num2 = seed + 2246822519u;
			uint num3 = seed;
			uint num4 = seed - 2654435761u;
			do
			{
				num = XXH32_round(num, XXH.XXH_read32(ptr));
				num2 = XXH32_round(num2, XXH.XXH_read32(ptr + 4));
				num3 = XXH32_round(num3, XXH.XXH_read32(ptr + 8));
				num4 = XXH32_round(num4, XXH.XXH_read32(ptr + 12));
				ptr += 16;
			}
			while (ptr <= ptr3);
			num5 = XXH32_rotl(num, 1) + XXH32_rotl(num2, 7) + XXH32_rotl(num3, 12) + XXH32_rotl(num4, 18);
		}
		else
		{
			num5 = seed + 374761393;
		}
		num5 += (uint)len;
		for (; ptr + 4 <= ptr2; ptr += 4)
		{
			num5 = XXH32_rotl(num5 + (uint)((int)XXH.XXH_read32(ptr) * -1028477379), 17) * 668265263;
		}
		for (; ptr < ptr2; ptr++)
		{
			num5 = XXH32_rotl(num5 + (uint)(*ptr * 374761393), 11) * 2654435761u;
		}
		num5 ^= num5 >> 15;
		num5 *= 2246822519u;
		num5 ^= num5 >> 13;
		num5 *= 3266489917u;
		return num5 ^ (num5 >> 16);
	}

	private unsafe static void XXH32_reset(XXH32_state* state, uint seed)
	{
		XXH.XXH_zero(state, sizeof(XXH32_state));
		state->v1 = (uint)((int)seed + -1640531535 + -2048144777);
		state->v2 = seed + 2246822519u;
		state->v3 = seed;
		state->v4 = seed - 2654435761u;
	}

	private unsafe static void XXH32_update(XXH32_state* state, void* input, int len)
	{
		byte* ptr = (byte*)input;
		byte* ptr2 = ptr + len;
		state->total_len_32 += (uint)len;
		state->large_len |= len >= 16 || state->total_len_32 >= 16;
		if (state->memsize + len < 16L)
		{
			XXH.XXH_copy((byte*)state->mem32 + state->memsize, input, len);
			state->memsize += (uint)len;
			return;
		}
		if (state->memsize != 0)
		{
			XXH.XXH_copy((byte*)state->mem32 + state->memsize, input, (int)(16 - state->memsize));
			uint* ptr3 = state->mem32;
			state->v1 = XXH32_round(state->v1, XXH.XXH_read32(ptr3));
			state->v2 = XXH32_round(state->v2, XXH.XXH_read32(ptr3 + 1));
			state->v3 = XXH32_round(state->v3, XXH.XXH_read32(ptr3 + 2));
			state->v4 = XXH32_round(state->v4, XXH.XXH_read32(ptr3 + 3));
			ptr += 16 - state->memsize;
			state->memsize = 0u;
		}
		if (ptr <= ptr2 - 16)
		{
			byte* ptr4 = ptr2 - 16;
			uint num = state->v1;
			uint num2 = state->v2;
			uint num3 = state->v3;
			uint num4 = state->v4;
			do
			{
				num = XXH32_round(num, XXH.XXH_read32(ptr));
				num2 = XXH32_round(num2, XXH.XXH_read32(ptr + 4));
				num3 = XXH32_round(num3, XXH.XXH_read32(ptr + 8));
				num4 = XXH32_round(num4, XXH.XXH_read32(ptr + 12));
				ptr += 16;
			}
			while (ptr <= ptr4);
			state->v1 = num;
			state->v2 = num2;
			state->v3 = num3;
			state->v4 = num4;
		}
		if (ptr < ptr2)
		{
			XXH.XXH_copy(state->mem32, ptr, (int)(ptr2 - ptr));
			state->memsize = (uint)(ptr2 - ptr);
		}
	}

	private unsafe static uint XXH32_digest(XXH32_state* state)
	{
		byte* ptr = (byte*)state->mem32;
		byte* ptr2 = (byte*)state->mem32 + state->memsize;
		uint num = ((!state->large_len) ? (state->v3 + 374761393) : (XXH32_rotl(state->v1, 1) + XXH32_rotl(state->v2, 7) + XXH32_rotl(state->v3, 12) + XXH32_rotl(state->v4, 18)));
		num += state->total_len_32;
		for (; ptr + 4 <= ptr2; ptr += 4)
		{
			num += (uint)((int)XXH.XXH_read32(ptr) * -1028477379);
			num = XXH32_rotl(num, 17) * 668265263;
		}
		for (; ptr < ptr2; ptr++)
		{
			num += (uint)(*ptr * 374761393);
			num = XXH32_rotl(num, 11) * 2654435761u;
		}
		num ^= num >> 15;
		num *= 2246822519u;
		num ^= num >> 13;
		num *= 3266489917u;
		return num ^ (num >> 16);
	}

	public unsafe static uint DigestOf(void* bytes, int length)
	{
		return XXH32_hash(bytes, length, 0u);
	}

	public unsafe static uint DigestOf(ReadOnlySpan<byte> bytes)
	{
		fixed (byte* bytes2 = &MemoryMarshal.GetReference(bytes))
		{
			return DigestOf(bytes2, bytes.Length);
		}
	}

	public unsafe static uint DigestOf(byte[] bytes, int offset, int length)
	{
		XXH.Validate(bytes, offset, length);
		fixed (byte* ptr = bytes)
		{
			return DigestOf(ptr + offset, length);
		}
	}

	public XXH32()
	{
		Reset();
	}

	public unsafe void Reset()
	{
		fixed (XXH32_state* state = &_state)
		{
			XXH32_reset(state, 0u);
		}
	}

	public unsafe void Update(byte* bytes, int length)
	{
		fixed (XXH32_state* state = &_state)
		{
			XXH32_update(state, bytes, length);
		}
	}

	public unsafe void Update(ReadOnlySpan<byte> bytes)
	{
		fixed (byte* bytes2 = &MemoryMarshal.GetReference(bytes))
		{
			Update(bytes2, bytes.Length);
		}
	}

	public unsafe void Update(byte[] bytes, int offset, int length)
	{
		XXH.Validate(bytes, offset, length);
		fixed (byte* ptr = bytes)
		{
			Update(ptr + offset, length);
		}
	}

	public unsafe uint Digest()
	{
		fixed (XXH32_state* state = &_state)
		{
			return XXH32_digest(state);
		}
	}

	public byte[] DigestBytes()
	{
		return BitConverter.GetBytes(Digest());
	}

	public HashAlgorithm AsHashAlgorithm()
	{
		return new HashAlgorithmAdapter(4, Reset, Update, DigestBytes);
	}
}
