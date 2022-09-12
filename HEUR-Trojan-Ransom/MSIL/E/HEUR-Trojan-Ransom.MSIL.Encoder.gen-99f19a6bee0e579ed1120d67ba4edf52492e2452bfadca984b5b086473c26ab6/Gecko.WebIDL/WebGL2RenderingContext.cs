using System;

namespace Gecko.WebIDL;

public class WebGL2RenderingContext : WebIDLBase
{
	public WebGL2RenderingContext(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void CopyBufferSubData(uint readTarget, uint writeTarget, long readOffset, long writeOffset, long size)
	{
		CallVoidMethod("copyBufferSubData", readTarget, writeTarget, readOffset, writeOffset, size);
	}

	public void GetBufferSubData(uint target, long offset, IntPtr returnedData)
	{
		CallVoidMethod("getBufferSubData", target, offset, returnedData);
	}

	public void GetBufferSubData(uint target, long offset, SharedArrayBuffer returnedData)
	{
		CallVoidMethod("getBufferSubData", target, offset, returnedData);
	}

	public void BlitFramebuffer(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, uint filter)
	{
		CallVoidMethod("blitFramebuffer", srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
	}

	public void FramebufferTextureLayer(uint target, uint attachment, nsISupports texture, int level, int layer)
	{
		CallVoidMethod("framebufferTextureLayer", target, attachment, texture, level, layer);
	}

	public void InvalidateFramebuffer(uint target, uint[] attachments)
	{
		CallVoidMethod("invalidateFramebuffer", target, attachments);
	}

	public void InvalidateSubFramebuffer(uint target, uint[] attachments, int x, int y, int width, int height)
	{
		CallVoidMethod("invalidateSubFramebuffer", target, attachments, x, y, width, height);
	}

	public void ReadBuffer(uint src)
	{
		CallVoidMethod("readBuffer", src);
	}

	public object GetInternalformatParameter(uint target, uint internalformat, uint pname)
	{
		return CallMethod<object>("getInternalformatParameter", new object[3] { target, internalformat, pname });
	}

	public void RenderbufferStorageMultisample(uint target, int samples, uint internalformat, int width, int height)
	{
		CallVoidMethod("renderbufferStorageMultisample", target, samples, internalformat, width, height);
	}

	public void TexStorage2D(uint target, int levels, uint internalformat, int width, int height)
	{
		CallVoidMethod("texStorage2D", target, levels, internalformat, width, height);
	}

	public void TexStorage3D(uint target, int levels, uint internalformat, int width, int height, int depth)
	{
		CallVoidMethod("texStorage3D", target, levels, internalformat, width, height, depth);
	}

	public void TexImage3D(uint target, int level, uint internalformat, int width, int height, int depth, int border, uint format, uint type, IntPtr pixels)
	{
		CallVoidMethod("texImage3D", target, level, internalformat, width, height, depth, border, format, type, pixels);
	}

	public void TexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, IntPtr pixels)
	{
		CallVoidMethod("texSubImage3D", target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
	}

	public void TexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, uint format, uint type, nsISupports data)
	{
		CallVoidMethod("texSubImage3D", target, level, xoffset, yoffset, zoffset, format, type, data);
	}

	public void TexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, uint format, uint type, nsIDOMHTMLImageElement image)
	{
		CallVoidMethod("texSubImage3D", target, level, xoffset, yoffset, zoffset, format, type, image);
	}

	public void TexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, uint format, uint type, nsIDOMHTMLCanvasElement canvas)
	{
		CallVoidMethod("texSubImage3D", target, level, xoffset, yoffset, zoffset, format, type, canvas);
	}

	public void CopyTexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height)
	{
		CallVoidMethod("copyTexSubImage3D", target, level, xoffset, yoffset, zoffset, x, y, width, height);
	}

	public void CompressedTexImage3D(uint target, int level, uint internalformat, int width, int height, int depth, int border, IntPtr data)
	{
		CallVoidMethod("compressedTexImage3D", target, level, internalformat, width, height, depth, border, data);
	}

	public void CompressedTexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, IntPtr data)
	{
		CallVoidMethod("compressedTexSubImage3D", target, level, xoffset, yoffset, zoffset, width, height, depth, format, data);
	}

	public int GetFragDataLocation(nsISupports program, string name)
	{
		return CallMethod<int>("getFragDataLocation", new object[2] { program, name });
	}

	public void Uniform1ui(nsISupports location, uint v0)
	{
		CallVoidMethod("uniform1ui", location, v0);
	}

	public void Uniform2ui(nsISupports location, uint v0, uint v1)
	{
		CallVoidMethod("uniform2ui", location, v0, v1);
	}

	public void Uniform3ui(nsISupports location, uint v0, uint v1, uint v2)
	{
		CallVoidMethod("uniform3ui", location, v0, v1, v2);
	}

	public void Uniform4ui(nsISupports location, uint v0, uint v1, uint v2, uint v3)
	{
		CallVoidMethod("uniform4ui", location, v0, v1, v2, v3);
	}

	public void Uniform1uiv(nsISupports location, IntPtr value)
	{
		CallVoidMethod("uniform1uiv", location, value);
	}

	public void Uniform1uiv(nsISupports location, uint[] value)
	{
		CallVoidMethod("uniform1uiv", location, value);
	}

	public void Uniform2uiv(nsISupports location, IntPtr value)
	{
		CallVoidMethod("uniform2uiv", location, value);
	}

	public void Uniform2uiv(nsISupports location, uint[] value)
	{
		CallVoidMethod("uniform2uiv", location, value);
	}

	public void Uniform3uiv(nsISupports location, IntPtr value)
	{
		CallVoidMethod("uniform3uiv", location, value);
	}

	public void Uniform3uiv(nsISupports location, uint[] value)
	{
		CallVoidMethod("uniform3uiv", location, value);
	}

	public void Uniform4uiv(nsISupports location, IntPtr value)
	{
		CallVoidMethod("uniform4uiv", location, value);
	}

	public void Uniform4uiv(nsISupports location, uint[] value)
	{
		CallVoidMethod("uniform4uiv", location, value);
	}

	public void UniformMatrix2x3fv(nsISupports location, bool transpose, IntPtr value)
	{
		CallVoidMethod("uniformMatrix2x3fv", location, transpose, value);
	}

	public void UniformMatrix2x3fv(nsISupports location, bool transpose, float[] value)
	{
		CallVoidMethod("uniformMatrix2x3fv", location, transpose, value);
	}

	public void UniformMatrix3x2fv(nsISupports location, bool transpose, IntPtr value)
	{
		CallVoidMethod("uniformMatrix3x2fv", location, transpose, value);
	}

	public void UniformMatrix3x2fv(nsISupports location, bool transpose, float[] value)
	{
		CallVoidMethod("uniformMatrix3x2fv", location, transpose, value);
	}

	public void UniformMatrix2x4fv(nsISupports location, bool transpose, IntPtr value)
	{
		CallVoidMethod("uniformMatrix2x4fv", location, transpose, value);
	}

	public void UniformMatrix2x4fv(nsISupports location, bool transpose, float[] value)
	{
		CallVoidMethod("uniformMatrix2x4fv", location, transpose, value);
	}

	public void UniformMatrix4x2fv(nsISupports location, bool transpose, IntPtr value)
	{
		CallVoidMethod("uniformMatrix4x2fv", location, transpose, value);
	}

	public void UniformMatrix4x2fv(nsISupports location, bool transpose, float[] value)
	{
		CallVoidMethod("uniformMatrix4x2fv", location, transpose, value);
	}

	public void UniformMatrix3x4fv(nsISupports location, bool transpose, IntPtr value)
	{
		CallVoidMethod("uniformMatrix3x4fv", location, transpose, value);
	}

	public void UniformMatrix3x4fv(nsISupports location, bool transpose, float[] value)
	{
		CallVoidMethod("uniformMatrix3x4fv", location, transpose, value);
	}

	public void UniformMatrix4x3fv(nsISupports location, bool transpose, IntPtr value)
	{
		CallVoidMethod("uniformMatrix4x3fv", location, transpose, value);
	}

	public void UniformMatrix4x3fv(nsISupports location, bool transpose, float[] value)
	{
		CallVoidMethod("uniformMatrix4x3fv", location, transpose, value);
	}

	public void VertexAttribI4i(uint index, int x, int y, int z, int w)
	{
		CallVoidMethod("vertexAttribI4i", index, x, y, z, w);
	}

	public void VertexAttribI4iv(uint index, int[] v)
	{
		CallVoidMethod("vertexAttribI4iv", index, v);
	}

	public void VertexAttribI4ui(uint index, uint x, uint y, uint z, uint w)
	{
		CallVoidMethod("vertexAttribI4ui", index, x, y, z, w);
	}

	public void VertexAttribI4uiv(uint index, uint[] v)
	{
		CallVoidMethod("vertexAttribI4uiv", index, v);
	}

	public void VertexAttribIPointer(uint index, int size, uint type, int stride, long offset)
	{
		CallVoidMethod("vertexAttribIPointer", index, size, type, stride, offset);
	}

	public void VertexAttribDivisor(uint index, uint divisor)
	{
		CallVoidMethod("vertexAttribDivisor", index, divisor);
	}

	public void DrawArraysInstanced(uint mode, int first, int count, int instanceCount)
	{
		CallVoidMethod("drawArraysInstanced", mode, first, count, instanceCount);
	}

	public void DrawElementsInstanced(uint mode, int count, uint type, long offset, int instanceCount)
	{
		CallVoidMethod("drawElementsInstanced", mode, count, type, offset, instanceCount);
	}

	public void DrawRangeElements(uint mode, uint start, uint end, int count, uint type, long offset)
	{
		CallVoidMethod("drawRangeElements", mode, start, end, count, type, offset);
	}

	public void DrawBuffers(uint[] buffers)
	{
		CallVoidMethod("drawBuffers", buffers);
	}

	public void ClearBufferiv(uint buffer, int drawbuffer, IntPtr value)
	{
		CallVoidMethod("clearBufferiv", buffer, drawbuffer, value);
	}

	public void ClearBufferiv(uint buffer, int drawbuffer, int[] value)
	{
		CallVoidMethod("clearBufferiv", buffer, drawbuffer, value);
	}

	public void ClearBufferuiv(uint buffer, int drawbuffer, IntPtr value)
	{
		CallVoidMethod("clearBufferuiv", buffer, drawbuffer, value);
	}

	public void ClearBufferuiv(uint buffer, int drawbuffer, uint[] value)
	{
		CallVoidMethod("clearBufferuiv", buffer, drawbuffer, value);
	}

	public void ClearBufferfv(uint buffer, int drawbuffer, IntPtr value)
	{
		CallVoidMethod("clearBufferfv", buffer, drawbuffer, value);
	}

	public void ClearBufferfv(uint buffer, int drawbuffer, float[] value)
	{
		CallVoidMethod("clearBufferfv", buffer, drawbuffer, value);
	}

	public void ClearBufferfi(uint buffer, int drawbuffer, float depth, int stencil)
	{
		CallVoidMethod("clearBufferfi", buffer, drawbuffer, depth, stencil);
	}

	public nsISupports CreateQuery()
	{
		return CallMethod<nsISupports>("createQuery", new object[0]);
	}

	public void DeleteQuery(nsISupports query)
	{
		CallVoidMethod("deleteQuery", query);
	}

	public bool IsQuery(nsISupports query)
	{
		return CallMethod<bool>("isQuery", new object[1] { query });
	}

	public void BeginQuery(uint target, nsISupports query)
	{
		CallVoidMethod("beginQuery", target, query);
	}

	public void EndQuery(uint target)
	{
		CallVoidMethod("endQuery", target);
	}

	public nsISupports GetQuery(uint target, uint pname)
	{
		return CallMethod<nsISupports>("getQuery", new object[2] { target, pname });
	}

	public object GetQueryParameter(nsISupports query, uint pname)
	{
		return CallMethod<object>("getQueryParameter", new object[2] { query, pname });
	}

	public nsISupports CreateSampler()
	{
		return CallMethod<nsISupports>("createSampler", new object[0]);
	}

	public void DeleteSampler(nsISupports sampler)
	{
		CallVoidMethod("deleteSampler", sampler);
	}

	public bool IsSampler(nsISupports sampler)
	{
		return CallMethod<bool>("isSampler", new object[1] { sampler });
	}

	public void BindSampler(uint unit, nsISupports sampler)
	{
		CallVoidMethod("bindSampler", unit, sampler);
	}

	public void SamplerParameteri(nsISupports sampler, uint pname, int param)
	{
		CallVoidMethod("samplerParameteri", sampler, pname, param);
	}

	public void SamplerParameterf(nsISupports sampler, uint pname, float param)
	{
		CallVoidMethod("samplerParameterf", sampler, pname, param);
	}

	public object GetSamplerParameter(nsISupports sampler, uint pname)
	{
		return CallMethod<object>("getSamplerParameter", new object[2] { sampler, pname });
	}

	public nsISupports FenceSync(uint condition, uint flags)
	{
		return CallMethod<nsISupports>("fenceSync", new object[2] { condition, flags });
	}

	public bool IsSync(nsISupports sync)
	{
		return CallMethod<bool>("isSync", new object[1] { sync });
	}

	public void DeleteSync(nsISupports sync)
	{
		CallVoidMethod("deleteSync", sync);
	}

	public uint ClientWaitSync(nsISupports sync, uint flags, long timeout)
	{
		return CallMethod<uint>("clientWaitSync", new object[3] { sync, flags, timeout });
	}

	public void WaitSync(nsISupports sync, uint flags, long timeout)
	{
		CallVoidMethod("waitSync", sync, flags, timeout);
	}

	public object GetSyncParameter(nsISupports sync, uint pname)
	{
		return CallMethod<object>("getSyncParameter", new object[2] { sync, pname });
	}

	public nsISupports CreateTransformFeedback()
	{
		return CallMethod<nsISupports>("createTransformFeedback", new object[0]);
	}

	public void DeleteTransformFeedback(nsISupports tf)
	{
		CallVoidMethod("deleteTransformFeedback", tf);
	}

	public bool IsTransformFeedback(nsISupports tf)
	{
		return CallMethod<bool>("isTransformFeedback", new object[1] { tf });
	}

	public void BindTransformFeedback(uint target, nsISupports tf)
	{
		CallVoidMethod("bindTransformFeedback", target, tf);
	}

	public void BeginTransformFeedback(uint primitiveMode)
	{
		CallVoidMethod("beginTransformFeedback", primitiveMode);
	}

	public void EndTransformFeedback()
	{
		CallVoidMethod("endTransformFeedback");
	}

	public void TransformFeedbackVaryings(nsISupports program, string[] varyings, uint bufferMode)
	{
		CallVoidMethod("transformFeedbackVaryings", program, varyings, bufferMode);
	}

	public nsISupports GetTransformFeedbackVarying(nsISupports program, uint index)
	{
		return CallMethod<nsISupports>("getTransformFeedbackVarying", new object[2] { program, index });
	}

	public void PauseTransformFeedback()
	{
		CallVoidMethod("pauseTransformFeedback");
	}

	public void ResumeTransformFeedback()
	{
		CallVoidMethod("resumeTransformFeedback");
	}

	public void BindBufferBase(uint target, uint index, nsISupports buffer)
	{
		CallVoidMethod("bindBufferBase", target, index, buffer);
	}

	public void BindBufferRange(uint target, uint index, nsISupports buffer, long offset, long size)
	{
		CallVoidMethod("bindBufferRange", target, index, buffer, offset, size);
	}

	public WebIDLUnion<nsISupports, long> GetIndexedParameter(uint target, uint index)
	{
		return CallMethod<WebIDLUnion<nsISupports, long>>("getIndexedParameter", new object[2] { target, index });
	}

	public uint[] GetUniformIndices(nsISupports program, string[] uniformNames)
	{
		return CallMethod<uint[]>("getUniformIndices", new object[2] { program, uniformNames });
	}

	public int[] GetActiveUniforms(nsISupports program, uint[] uniformIndices, uint pname)
	{
		return CallMethod<int[]>("getActiveUniforms", new object[3] { program, uniformIndices, pname });
	}

	public uint GetUniformBlockIndex(nsISupports program, string uniformBlockName)
	{
		return CallMethod<uint>("getUniformBlockIndex", new object[2] { program, uniformBlockName });
	}

	public WebIDLUnion<uint, IntPtr, bool> GetActiveUniformBlockParameter(nsISupports program, uint uniformBlockIndex, uint pname)
	{
		return CallMethod<WebIDLUnion<uint, IntPtr, bool>>("getActiveUniformBlockParameter", new object[3] { program, uniformBlockIndex, pname });
	}

	public string GetActiveUniformBlockName(nsISupports program, uint uniformBlockIndex)
	{
		return CallMethod<string>("getActiveUniformBlockName", new object[2] { program, uniformBlockIndex });
	}

	public void UniformBlockBinding(nsISupports program, uint uniformBlockIndex, uint uniformBlockBinding)
	{
		CallVoidMethod("uniformBlockBinding", program, uniformBlockIndex, uniformBlockBinding);
	}

	public nsISupports CreateVertexArray()
	{
		return CallMethod<nsISupports>("createVertexArray", new object[0]);
	}

	public void DeleteVertexArray(nsISupports vertexArray)
	{
		CallVoidMethod("deleteVertexArray", vertexArray);
	}

	public bool IsVertexArray(nsISupports vertexArray)
	{
		return CallMethod<bool>("isVertexArray", new object[1] { vertexArray });
	}

	public void BindVertexArray(nsISupports array)
	{
		CallVoidMethod("bindVertexArray", array);
	}
}
