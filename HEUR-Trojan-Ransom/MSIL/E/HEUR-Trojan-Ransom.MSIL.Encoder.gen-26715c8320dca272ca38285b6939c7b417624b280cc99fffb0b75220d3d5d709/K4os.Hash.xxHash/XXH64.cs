using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace K4os.Hash.xxHash;

public class XXH64 : XXH
{
	private struct XXH64_state
	{
		public ulong total_len;

		public ulong v1;

		public ulong v2;

		public ulong v3;

		public ulong v4;

		public unsafe fixed ulong mem64[4];

		public uint memsize;
	}

	private const ulong PRIME64_1 = 11400714785074694791uL;

	private const ulong PRIME64_2 = 14029467366897019727uL;

	private const ulong PRIME64_3 = 1609587929392839161uL;

	private const ulong PRIME64_4 = 9650029242287828579uL;

	private const ulong PRIME64_5 = 2870177450012600261uL;

	public const ulong EmptyHash = 17241709254077376921uL;

	private XXH64_state _state;

	private static ulong XXH_rotl64(ulong x, int r)
	{
		return (x << r) | (x >> 64 - r);
	}

	private static ulong XXH64_round(ulong acc, ulong input)
	{
		return XXH_rotl64(acc + (ulong)((long)input * -4417276706812531889L), 31) * 11400714785074694791uL;
	}

	private static ulong XXH64_mergeRound(ulong acc, ulong val)
	{
		return (ulong)((long)(acc ^ XXH64_round(0uL, val)) * -7046029288634856825L + -8796714831421723037L);
	}

	private unsafe static ulong XXH64_hash(void* input, int len, ulong seed)
	{
		byte* ptr = (byte*)input;
		byte* ptr2 = ptr + len;
		ulong acc;
		if (len >= 32)
		{
			byte* ptr3 = ptr2 - 32;
			ulong num = (ulong)((long)seed + -7046029288634856825L + -4417276706812531889L);
			ulong num2 = seed + 14029467366897019727uL;
			ulong num3 = seed;
			ulong num4 = seed - 11400714785074694791uL;
			do
			{
				num = XXH64_round(num, XXH.XXH_read64(ptr));
				num2 = XXH64_round(num2, XXH.XXH_read64(ptr + 8));
				num3 = XXH64_round(num3, XXH.XXH_read64(ptr + 16));
				num4 = XXH64_round(num4, XXH.XXH_read64(ptr + 24));
				ptr += 32;
			}
			while (ptr <= ptr3);
			acc = XXH_rotl64(num, 1) + XXH_rotl64(num2, 7) + XXH_rotl64(num3, 12) + XXH_rotl64(num4, 18);
			acc = XXH64_mergeRound(acc, num);
			acc = XXH64_mergeRound(acc, num2);
			acc = XXH64_mergeRound(acc, num3);
			acc = XXH64_mergeRound(acc, num4);
		}
		else
		{
			acc = seed + 2870177450012600261L;
		}
		acc += (ulong)len;
		for (; ptr + 8 <= ptr2; ptr += 8)
		{
			acc ^= XXH64_round(0uL, XXH.XXH_read64(ptr));
			acc = (ulong)((long)XXH_rotl64(acc, 27) * -7046029288634856825L + -8796714831421723037L);
		}
		if (ptr + 4 <= ptr2)
		{
			acc ^= (ulong)(XXH.XXH_read32(ptr) * -7046029288634856825L);
			acc = (ulong)((long)XXH_rotl64(acc, 23) * -4417276706812531889L + 1609587929392839161L);
			ptr += 4;
		}
		for (; ptr < ptr2; ptr++)
		{
			acc ^= (ulong)(*ptr * 2870177450012600261L);
			acc = XXH_rotl64(acc, 11) * 11400714785074694791uL;
		}
		acc ^= acc >> 33;
		acc *= 14029467366897019727uL;
		acc ^= acc >> 29;
		acc *= 1609587929392839161L;
		return acc ^ (acc >> 32);
	}

	private unsafe static void XXH64_reset(XXH64_state* state, ulong seed)
	{
		XXH.XXH_zero(state, sizeof(XXH64_state));
		state->v1 = (ulong)((long)seed + -7046029288634856825L + -4417276706812531889L);
		state->v2 = seed + 14029467366897019727uL;
		state->v3 = seed;
		state->v4 = seed - 11400714785074694791uL;
	}

	private unsafe static void XXH64_update(XXH64_state* state, void* input, int len)
	{
		byte* ptr = (byte*)input;
		byte* ptr2 = ptr + len;
		state->total_len += (ulong)len;
		if (state->memsize + len < 32L)
		{
			XXH.XXH_copy((byte*)state->mem64 + state->memsize, input, len);
			state->memsize += (uint)len;
			return;
		}
		if (state->memsize != 0)
		{
			XXH.XXH_copy((byte*)state->mem64 + state->memsize, input, (int)(32 - state->memsize));
			state->v1 = XXH64_round(state->v1, XXH.XXH_read64(state->mem64));
			state->v2 = XXH64_round(state->v2, XXH.XXH_read64(state->mem64 + 1));
			state->v3 = XXH64_round(state->v3, XXH.XXH_read64(state->mem64 + 2));
			state->v4 = XXH64_round(state->v4, XXH.XXH_read64(state->mem64 + 3));
			ptr += 32 - state->memsize;
			state->memsize = 0u;
		}
		if (ptr + 32 <= ptr2)
		{
			byte* ptr3 = ptr2 - 32;
			ulong num = state->v1;
			ulong num2 = state->v2;
			ulong num3 = state->v3;
			ulong num4 = state->v4;
			do
			{
				num = XXH64_round(num, XXH.XXH_read64(ptr));
				num2 = XXH64_round(num2, XXH.XXH_read64(ptr + 8));
				num3 = XXH64_round(num3, XXH.XXH_read64(ptr + 16));
				num4 = XXH64_round(num4, XXH.XXH_read64(ptr + 24));
				ptr += 32;
			}
			while (ptr <= ptr3);
			state->v1 = num;
			state->v2 = num2;
			state->v3 = num3;
			state->v4 = num4;
		}
		if (ptr < ptr2)
		{
			XXH.XXH_copy(state->mem64, ptr, (int)(ptr2 - ptr));
			state->memsize = (uint)(ptr2 - ptr);
		}
	}

	private unsafe static ulong XXH64_digest(XXH64_state* state)
	{
		byte* ptr = (byte*)state->mem64;
		byte* ptr2 = (byte*)state->mem64 + state->memsize;
		ulong acc;
		if (state->total_len >= 32L)
		{
			ulong v = state->v1;
			ulong v2 = state->v2;
			ulong v3 = state->v3;
			ulong v4 = state->v4;
			acc = XXH_rotl64(v, 1) + XXH_rotl64(v2, 7) + XXH_rotl64(v3, 12) + XXH_rotl64(v4, 18);
			acc = XXH64_mergeRound(acc, v);
			acc = XXH64_mergeRound(acc, v2);
			acc = XXH64_mergeRound(acc, v3);
			acc = XXH64_mergeRound(acc, v4);
		}
		else
		{
			acc = state->v3 + 2870177450012600261L;
		}
		acc += state->total_len;
		for (; ptr + 8 <= ptr2; ptr += 8)
		{
			acc ^= XXH64_round(0uL, XXH.XXH_read64(ptr));
			acc = (ulong)((long)XXH_rotl64(acc, 27) * -7046029288634856825L + -8796714831421723037L);
		}
		if (ptr + 4 <= ptr2)
		{
			acc ^= (ulong)(XXH.XXH_read32(ptr) * -7046029288634856825L);
			acc = (ulong)((long)XXH_rotl64(acc, 23) * -4417276706812531889L + 1609587929392839161L);
			ptr += 4;
		}
		for (; ptr < ptr2; ptr++)
		{
			acc ^= (ulong)(*ptr * 2870177450012600261L);
			acc = XXH_rotl64(acc, 11) * 11400714785074694791uL;
		}
		acc ^= acc >> 33;
		acc *= 14029467366897019727uL;
		acc ^= acc >> 29;
		acc *= 1609587929392839161L;
		return acc ^ (acc >> 32);
	}

	public unsafe static ulong DigestOf(void* bytes, int length)
	{
		return XXH64_hash(bytes, length, 0uL);
	}

	public unsafe static ulong DigestOf(ReadOnlySpan<byte> bytes)
	{
		fixed (byte* bytes2 = &MemoryMarshal.GetReference(bytes))
		{
			return DigestOf(bytes2, bytes.Length);
		}
	}

	public unsafe static ulong DigestOf(byte[] bytes, int offset, int length)
	{
		XXH.Validate(bytes, offset, length);
		fixed (byte* ptr = bytes)
		{
			return DigestOf(ptr + offset, length);
		}
	}

	public XXH64()
	{
		Reset();
	}

	public unsafe void Reset()
	{
		fixed (XXH64_state* state = &_state)
		{
			XXH64_reset(state, 0uL);
		}
	}

	public unsafe void Update(byte* bytes, int length)
	{
		fixed (XXH64_state* state = &_state)
		{
			XXH64_update(state, bytes, length);
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

	public unsafe ulong Digest()
	{
		fixed (XXH64_state* state = &_state)
		{
			return XXH64_digest(state);
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
