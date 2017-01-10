// -- FILE ------------------------------------------------------------------
// name       : RtfFontTableFormatException.cs
// project    : RTF Framelet
// created    : Jani Giannoudis - 2009.02.19
// language   : c#
// environment: .NET 2.0
// copyright  : (c) 2004-2013 by Jani Giannoudis, Switzerland
// --------------------------------------------------------------------------
using System;
using System.Runtime.Serialization;

namespace RtfPipe
{

  // ------------------------------------------------------------------------
  /// <summary>Thrown upon RTF specific error conditions.</summary>
#if SERIALIZATION
	[Serializable]
#endif
	public class RtfFontTableFormatException : RtfInterpreterException
	{

		// ----------------------------------------------------------------------
		/// <summary>Creates a new instance.</summary>
		public RtfFontTableFormatException()
		{
		} // RtfFontTableFormatException

		// ----------------------------------------------------------------------
		/// <summary>Creates a new instance with the given message.</summary>
		/// <param name="message">the message to display</param>
		public RtfFontTableFormatException( string message ) :
			base( message )
		{
		} // RtfFontTableFormatException

		// ----------------------------------------------------------------------
		/// <summary>Creates a new instance with the given message, based on the given cause.</summary>
		/// <param name="message">the message to display</param>
		/// <param name="cause">the original cause for this exception</param>
		public RtfFontTableFormatException( string message, Exception cause ) :
			base( message, cause )
		{
		} // RtfFontTableFormatException

#if SERIALIZATION
		// ----------------------------------------------------------------------
		/// <summary>Serialization support.</summary>
		/// <param name="info">the info to use for serialization</param>
		/// <param name="context">the context to use for serialization</param>
		protected RtfFontTableFormatException( SerializationInfo info, StreamingContext context ) :
			base( info, context )
		{
		} // RtfFontTableFormatException
#endif

	} // class RtfFontTableFormatException

} // namespace RtfPipe
// -- EOF -------------------------------------------------------------------
