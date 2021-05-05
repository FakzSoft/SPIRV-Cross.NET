// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Diagnostics;

namespace SPIRVCross
{
	/// <summary>
	/// A dispatchable handle.
	/// </summary>
	[DebuggerDisplay("{DebuggerDisplay,nq}")]
	public readonly partial struct spvc_context : IEquatable<spvc_context>
	{
		public spvc_context(nint handle) { Handle = handle; }
		public nint Handle { get; }
		public bool IsNull => Handle == 0;
		public static spvc_context Null => new spvc_context(0);
		public static implicit operator spvc_context(nint handle) => new spvc_context(handle);
		public static bool operator ==(spvc_context left, spvc_context right) => left.Handle == right.Handle;
		public static bool operator !=(spvc_context left, spvc_context right) => left.Handle != right.Handle;
		public static bool operator ==(spvc_context left, nint right) => left.Handle == right;
		public static bool operator !=(spvc_context left, nint right) => left.Handle != right;
		public bool Equals(spvc_context other) => Handle == other.Handle;
		/// <inheritdoc/>
		public override bool Equals(object obj) => obj is spvc_context handle && Equals(handle);
		/// <inheritdoc/>
		public override int GetHashCode() => Handle.GetHashCode();
		private string DebuggerDisplay => string.Format("spvc_context [0x{0}]", Handle.ToString("X"));
	}

	/// <summary>
	/// A dispatchable handle.
	/// </summary>
	[DebuggerDisplay("{DebuggerDisplay,nq}")]
	public readonly partial struct spvc_parsed_ir : IEquatable<spvc_parsed_ir>
	{
		public spvc_parsed_ir(nint handle) { Handle = handle; }
		public nint Handle { get; }
		public bool IsNull => Handle == 0;
		public static spvc_parsed_ir Null => new spvc_parsed_ir(0);
		public static implicit operator spvc_parsed_ir(nint handle) => new spvc_parsed_ir(handle);
		public static bool operator ==(spvc_parsed_ir left, spvc_parsed_ir right) => left.Handle == right.Handle;
		public static bool operator !=(spvc_parsed_ir left, spvc_parsed_ir right) => left.Handle != right.Handle;
		public static bool operator ==(spvc_parsed_ir left, nint right) => left.Handle == right;
		public static bool operator !=(spvc_parsed_ir left, nint right) => left.Handle != right;
		public bool Equals(spvc_parsed_ir other) => Handle == other.Handle;
		/// <inheritdoc/>
		public override bool Equals(object obj) => obj is spvc_parsed_ir handle && Equals(handle);
		/// <inheritdoc/>
		public override int GetHashCode() => Handle.GetHashCode();
		private string DebuggerDisplay => string.Format("spvc_parsed_ir [0x{0}]", Handle.ToString("X"));
	}

	/// <summary>
	/// A dispatchable handle.
	/// </summary>
	[DebuggerDisplay("{DebuggerDisplay,nq}")]
	public readonly partial struct spvc_compiler : IEquatable<spvc_compiler>
	{
		public spvc_compiler(nint handle) { Handle = handle; }
		public nint Handle { get; }
		public bool IsNull => Handle == 0;
		public static spvc_compiler Null => new spvc_compiler(0);
		public static implicit operator spvc_compiler(nint handle) => new spvc_compiler(handle);
		public static bool operator ==(spvc_compiler left, spvc_compiler right) => left.Handle == right.Handle;
		public static bool operator !=(spvc_compiler left, spvc_compiler right) => left.Handle != right.Handle;
		public static bool operator ==(spvc_compiler left, nint right) => left.Handle == right;
		public static bool operator !=(spvc_compiler left, nint right) => left.Handle != right;
		public bool Equals(spvc_compiler other) => Handle == other.Handle;
		/// <inheritdoc/>
		public override bool Equals(object obj) => obj is spvc_compiler handle && Equals(handle);
		/// <inheritdoc/>
		public override int GetHashCode() => Handle.GetHashCode();
		private string DebuggerDisplay => string.Format("spvc_compiler [0x{0}]", Handle.ToString("X"));
	}

	/// <summary>
	/// A dispatchable handle.
	/// </summary>
	[DebuggerDisplay("{DebuggerDisplay,nq}")]
	public readonly partial struct spvc_compiler_options : IEquatable<spvc_compiler_options>
	{
		public spvc_compiler_options(nint handle) { Handle = handle; }
		public nint Handle { get; }
		public bool IsNull => Handle == 0;
		public static spvc_compiler_options Null => new spvc_compiler_options(0);
		public static implicit operator spvc_compiler_options(nint handle) => new spvc_compiler_options(handle);
		public static bool operator ==(spvc_compiler_options left, spvc_compiler_options right) => left.Handle == right.Handle;
		public static bool operator !=(spvc_compiler_options left, spvc_compiler_options right) => left.Handle != right.Handle;
		public static bool operator ==(spvc_compiler_options left, nint right) => left.Handle == right;
		public static bool operator !=(spvc_compiler_options left, nint right) => left.Handle != right;
		public bool Equals(spvc_compiler_options other) => Handle == other.Handle;
		/// <inheritdoc/>
		public override bool Equals(object obj) => obj is spvc_compiler_options handle && Equals(handle);
		/// <inheritdoc/>
		public override int GetHashCode() => Handle.GetHashCode();
		private string DebuggerDisplay => string.Format("spvc_compiler_options [0x{0}]", Handle.ToString("X"));
	}

	/// <summary>
	/// A dispatchable handle.
	/// </summary>
	[DebuggerDisplay("{DebuggerDisplay,nq}")]
	public readonly partial struct spvc_resources : IEquatable<spvc_resources>
	{
		public spvc_resources(nint handle) { Handle = handle; }
		public nint Handle { get; }
		public bool IsNull => Handle == 0;
		public static spvc_resources Null => new spvc_resources(0);
		public static implicit operator spvc_resources(nint handle) => new spvc_resources(handle);
		public static bool operator ==(spvc_resources left, spvc_resources right) => left.Handle == right.Handle;
		public static bool operator !=(spvc_resources left, spvc_resources right) => left.Handle != right.Handle;
		public static bool operator ==(spvc_resources left, nint right) => left.Handle == right;
		public static bool operator !=(spvc_resources left, nint right) => left.Handle != right;
		public bool Equals(spvc_resources other) => Handle == other.Handle;
		/// <inheritdoc/>
		public override bool Equals(object obj) => obj is spvc_resources handle && Equals(handle);
		/// <inheritdoc/>
		public override int GetHashCode() => Handle.GetHashCode();
		private string DebuggerDisplay => string.Format("spvc_resources [0x{0}]", Handle.ToString("X"));
	}

	/// <summary>
	/// A dispatchable handle.
	/// </summary>
	[DebuggerDisplay("{DebuggerDisplay,nq}")]
	public readonly partial struct spvc_type : IEquatable<spvc_type>
	{
		public spvc_type(nint handle) { Handle = handle; }
		public nint Handle { get; }
		public bool IsNull => Handle == 0;
		public static spvc_type Null => new spvc_type(0);
		public static implicit operator spvc_type(nint handle) => new spvc_type(handle);
		public static bool operator ==(spvc_type left, spvc_type right) => left.Handle == right.Handle;
		public static bool operator !=(spvc_type left, spvc_type right) => left.Handle != right.Handle;
		public static bool operator ==(spvc_type left, nint right) => left.Handle == right;
		public static bool operator !=(spvc_type left, nint right) => left.Handle != right;
		public bool Equals(spvc_type other) => Handle == other.Handle;
		/// <inheritdoc/>
		public override bool Equals(object obj) => obj is spvc_type handle && Equals(handle);
		/// <inheritdoc/>
		public override int GetHashCode() => Handle.GetHashCode();
		private string DebuggerDisplay => string.Format("spvc_type [0x{0}]", Handle.ToString("X"));
	}

	/// <summary>
	/// A dispatchable handle.
	/// </summary>
	[DebuggerDisplay("{DebuggerDisplay,nq}")]
	public readonly partial struct spvc_constant : IEquatable<spvc_constant>
	{
		public spvc_constant(nint handle) { Handle = handle; }
		public nint Handle { get; }
		public bool IsNull => Handle == 0;
		public static spvc_constant Null => new spvc_constant(0);
		public static implicit operator spvc_constant(nint handle) => new spvc_constant(handle);
		public static bool operator ==(spvc_constant left, spvc_constant right) => left.Handle == right.Handle;
		public static bool operator !=(spvc_constant left, spvc_constant right) => left.Handle != right.Handle;
		public static bool operator ==(spvc_constant left, nint right) => left.Handle == right;
		public static bool operator !=(spvc_constant left, nint right) => left.Handle != right;
		public bool Equals(spvc_constant other) => Handle == other.Handle;
		/// <inheritdoc/>
		public override bool Equals(object obj) => obj is spvc_constant handle && Equals(handle);
		/// <inheritdoc/>
		public override int GetHashCode() => Handle.GetHashCode();
		private string DebuggerDisplay => string.Format("spvc_constant [0x{0}]", Handle.ToString("X"));
	}

	/// <summary>
	/// A dispatchable handle.
	/// </summary>
	[DebuggerDisplay("{DebuggerDisplay,nq}")]
	public readonly partial struct spvc_set : IEquatable<spvc_set>
	{
		public spvc_set(nint handle) { Handle = handle; }
		public nint Handle { get; }
		public bool IsNull => Handle == 0;
		public static spvc_set Null => new spvc_set(0);
		public static implicit operator spvc_set(nint handle) => new spvc_set(handle);
		public static bool operator ==(spvc_set left, spvc_set right) => left.Handle == right.Handle;
		public static bool operator !=(spvc_set left, spvc_set right) => left.Handle != right.Handle;
		public static bool operator ==(spvc_set left, nint right) => left.Handle == right;
		public static bool operator !=(spvc_set left, nint right) => left.Handle != right;
		public bool Equals(spvc_set other) => Handle == other.Handle;
		/// <inheritdoc/>
		public override bool Equals(object obj) => obj is spvc_set handle && Equals(handle);
		/// <inheritdoc/>
		public override int GetHashCode() => Handle.GetHashCode();
		private string DebuggerDisplay => string.Format("spvc_set [0x{0}]", Handle.ToString("X"));
	}

	/// <summary>
	/// A dispatchable handle.
	/// </summary>
	[DebuggerDisplay("{DebuggerDisplay,nq}")]
	public readonly partial struct spvc_error_callback : IEquatable<spvc_error_callback>
	{
		public spvc_error_callback(nint handle) { Handle = handle; }
		public nint Handle { get; }
		public bool IsNull => Handle == 0;
		public static spvc_error_callback Null => new spvc_error_callback(0);
		public static implicit operator spvc_error_callback(nint handle) => new spvc_error_callback(handle);
		public static bool operator ==(spvc_error_callback left, spvc_error_callback right) => left.Handle == right.Handle;
		public static bool operator !=(spvc_error_callback left, spvc_error_callback right) => left.Handle != right.Handle;
		public static bool operator ==(spvc_error_callback left, nint right) => left.Handle == right;
		public static bool operator !=(spvc_error_callback left, nint right) => left.Handle != right;
		public bool Equals(spvc_error_callback other) => Handle == other.Handle;
		/// <inheritdoc/>
		public override bool Equals(object obj) => obj is spvc_error_callback handle && Equals(handle);
		/// <inheritdoc/>
		public override int GetHashCode() => Handle.GetHashCode();
		private string DebuggerDisplay => string.Format("spvc_error_callback [0x{0}]", Handle.ToString("X"));
	}

}
