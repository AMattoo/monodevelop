// 
// ITextTemplatingEngineHost.cs
//  
// Author:
//       Michael Hutchinson <mhutchinson@novell.com>
// 
// Copyright (c) 2009 Novell, Inc. (http://www.novell.com)
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
using System.Text;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace MonoDevelop.AspNet.Mvc.T4
{
	
	
	public interface ITextTemplatingEngineHost
	{
		object GetHostOption (string optionName);
		bool LoadIncludeText (string requestFileName, out string content, out string location);
		void LogErrors (CompilerErrorCollection errors);
		AppDomain ProvideTemplatingAppDomain (string content);
		string ResolveAssemblyReference (string assemblyReference);
		Type ResolveDirectiveProcessor (string processorName);
		string ResolveParameterValue (string directiveId, string processorName, string parameterName);
		string ResolvePath (string path);
		void SetFileExtension (string extension);
		void SetOutputEncoding (Encoding encoding, bool fromOutputDirective);
		IList<string> StandardAssemblyReferences { get; }
		IList<string> StandardImports { get; }
		string TemplateFile { get; }	
	}
}
