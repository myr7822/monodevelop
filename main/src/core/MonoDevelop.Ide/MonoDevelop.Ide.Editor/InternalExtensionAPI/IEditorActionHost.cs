//
// ITextEditor.cs
//
// Author:
//       Mike Krüger <mkrueger@xamarin.com>
//
// Copyright (c) 2014 Xamarin Inc. (http://xamarin.com)
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
using System;
using MonoDevelop.Core.Text;

namespace MonoDevelop.Ide.Editor
{
	interface IEditorActionHost
	{
		void SwitchCaretMode ();

		void InsertTab ();

		void RemoveTab ();

		void InsertNewLine ();

		void InsertNewLineAtEnd ();

		void InsertNewLinePreserveCaretPosition ();

		void DeletePreviousWord ();

		void DeleteNextWord ();

		void DeletePreviousSubword ();

		void DeleteNextSubword ();

		void StartCaretPulseAnimation ();

		void RecenterEditor ();

		void JoinLines ();

		void MoveNextSubWord ();

		void MovePrevSubWord ();

		void MoveNextWord ();

		void MovePrevWord ();

		void PageUp ();

		void PageDown ();

		void MoveCaretDown ();

		void MoveCaretUp ();

		void MoveCaretRight ();

		void MoveCaretLeft ();

		void MoveCaretToLineEnd ();

		void MoveCaretToLineStart ();

		void MoveCaretToDocumentStart ();

		void MoveCaretToDocumentEnd ();

		void Backspace ();

		void Delete ();

		void ClipboardCopy ();

		void ClipboardCut ();

		void ClipboardPaste ();

		void SelectAll ();

		void NewLine ();

		void Undo ();

		void Redo ();

		void DeleteCurrentLine ();

		void DeleteCurrentLineToEnd ();

		void ScrollLineUp ();

		void ScrollLineDown ();

		void ScrollPageUp ();

		void ScrollPageDown ();

		void GotoMatchingBrace ();
	}
}