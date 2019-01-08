//
// EventSource.cs
//
// Authors:
//	Marek Safar  <marek.safar@gmail.com>
//
// Copyright (C) 2014 Xamarin Inc (http://www.xamarin.com)
//
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

#if NET_4_5

namespace System.Diagnostics.Tracing
{
	public class EventSource : IDisposable
	{
		protected EventSource ()
		{
		}

		protected EventSource (bool throwOnEventWriteErrors)
		{
		}

		public bool IsEnabled ()
		{
			return false;
		}

		public bool IsEnabled (EventLevel level, EventKeywords keywords)
		{
			return false;
		}

		public void Dispose ()
		{
			Dispose (true);
		}

		protected virtual void Dispose (bool disposing)
		{			
		}

		protected virtual void OnEventCommand (EventCommandEventArgs command)
		{
		}

		protected void WriteEvent (int eventId, string arg1)
		{
		}

		protected void WriteEvent (int eventId, string arg1, int arg2)
		{
		}

		protected void WriteEvent (int eventId, int arg1, int arg2, int arg3)
		{
		}

		protected void WriteEvent (int eventId, string arg1, int arg2, int arg3)
		{
		}
	}
}

#endif
