// THIS FILE AUTOMATICALLY GENERATED BY xpidl2cs.pl
// EDITING IS PROBABLY UNWISE
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//
// Copyright (c) 2007, 2008 Novell, Inc.
//
// Authors:
//	Andreia Gaita (avidigal@novell.com)
//

using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace Mono.Mozilla {

	[Guid ("f85c5a20-258d-11db-a98b-0800200c9a66")]
	[InterfaceType (ComInterfaceType.InterfaceIsIUnknown)]
	[ComImport ()]
	internal interface nsIDocumentEncoder {

#region nsIDocumentEncoder
		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void init ([MarshalAs (UnmanagedType.Interface)]  nsIDOMDocument aDocument,
				 /*AString*/ HandleRef aMimeType,
				 uint aFlags);

		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void setSelection ([MarshalAs (UnmanagedType.Interface)]  nsISelection aSelection);

		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void setRange ([MarshalAs (UnmanagedType.Interface)]  nsIDOMRange aRange);

		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void setNode ([MarshalAs (UnmanagedType.Interface)]  nsIDOMNode aNode);

		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void setContainerNode ([MarshalAs (UnmanagedType.Interface)]  nsIDOMNode aContainer);

		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void setCharset ( /*ACString*/ HandleRef aCharset);

		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void setWrapColumn ( uint aWrapColumn);

		[PreserveSigAttribute]
		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		int getMimeType (/*AString*/ HandleRef ret);

		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void encodeToStream ([MarshalAs (UnmanagedType.Interface)]  nsIOutputStream aStream);

		[PreserveSigAttribute]
		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		int encodeToString (/*AString*/ HandleRef ret);

		[PreserveSigAttribute]
		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		int encodeToStringWithContext (/*AString*/ HandleRef aContextString,
				/*AString*/ HandleRef aInfoString, /*AString*/ HandleRef ret);

		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void setNodeFixup ([MarshalAs (UnmanagedType.Interface)]  nsIDocumentEncoderNodeFixup aFixup);

#endregion
	}


	internal class nsDocumentEncoder {
		public static nsIDocumentEncoder GetProxy (Mono.WebBrowser.IWebBrowser control, nsIDocumentEncoder obj)
		{
			object o = Base.GetProxyForObject (control, typeof(nsIDocumentEncoder).GUID, obj);
			return o as nsIDocumentEncoder;
		}
	}
}
#if example

using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

	internal class DocumentEncoder : nsIDocumentEncoder {

#region nsIDocumentEncoder
		void nsIDocumentEncoder.init ([MarshalAs (UnmanagedType.Interface)]  nsIDOMDocument aDocument,
				 /*AString*/ HandleRef aMimeType,
				 uint aFlags)
		{
			return ;
		}



		void nsIDocumentEncoder.setSelection ([MarshalAs (UnmanagedType.Interface)]  nsISelection aSelection)
		{
			return ;
		}



		void nsIDocumentEncoder.setRange ([MarshalAs (UnmanagedType.Interface)]  nsIDOMRange aRange)
		{
			return ;
		}



		void nsIDocumentEncoder.setNode ([MarshalAs (UnmanagedType.Interface)]  nsIDOMNode aNode)
		{
			return ;
		}



		void nsIDocumentEncoder.setContainerNode ([MarshalAs (UnmanagedType.Interface)]  nsIDOMNode aContainer)
		{
			return ;
		}



		void nsIDocumentEncoder.setCharset ( /*ACString*/ HandleRef aCharset)
		{
			return ;
		}



		void nsIDocumentEncoder.setWrapColumn ( uint aWrapColumn)
		{
			return ;
		}



		/*AString*/ HandleRef nsIDocumentEncoder.getMimeType ()

		{
			return null;
		}

		void nsIDocumentEncoder.encodeToStream ([MarshalAs (UnmanagedType.Interface)]  nsIOutputStream aStream)
		{
			return ;
		}



		/*AString*/ HandleRef nsIDocumentEncoder.encodeToString ()
		{
			return ;
		}



		/*AString*/ HandleRef nsIDocumentEncoder.encodeToStringWithContext (out /*AString*/ HandleRef aContextString,
				out /*AString*/ HandleRef aInfoString)
		{
			return ;
		}



		void nsIDocumentEncoder.setNodeFixup ([MarshalAs (UnmanagedType.Interface)]  nsIDocumentEncoderNodeFixup aFixup)
		{
			return ;
		}



#endregion
	}
#endif
