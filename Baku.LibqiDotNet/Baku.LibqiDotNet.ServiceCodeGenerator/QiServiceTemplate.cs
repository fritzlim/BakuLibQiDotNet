﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン: 14.0.0.0
//  
//     このファイルへの変更は、正しくない動作の原因になる可能性があり、
//     コードが再生成されると失われます。
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Baku.LibqiDotNet.ServiceCodeGenerator
{
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Users\style\Documents\GitHub\BakuLibQiDotNet\Baku.LibqiDotNet\Baku.LibqiDotNet.ServiceCodeGenerator\QiServiceTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    public partial class QiServiceTemplate : QiServiceTemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write("using System;\r\nusing System.Collections.Generic;\r\nusing System.Linq;\r\n\r\nnamespace" +
                    " Baku.LibqiDotNet.Service\r\n{\r\n    /// <summary>");
            
            #line 9 "C:\Users\style\Documents\GitHub\BakuLibQiDotNet\Baku.LibqiDotNet\Baku.LibqiDotNet.ServiceCodeGenerator\QiServiceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ServiceDescription));
            
            #line default
            #line hidden
            this.Write("</summary>\r\n    public class ");
            
            #line 10 "C:\Users\style\Documents\GitHub\BakuLibQiDotNet\Baku.LibqiDotNet\Baku.LibqiDotNet.ServiceCodeGenerator\QiServiceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ServiceName));
            
            #line default
            #line hidden
            this.Write("\r\n    {\r\n        /// <summary>サービスの取得元セッションを指定してサービスを初期化します。</summary>\r\n        /" +
                    "// <param name=\"session\">サービスの取得元となるセッション</param>\r\n        public ");
            
            #line 14 "C:\Users\style\Documents\GitHub\BakuLibQiDotNet\Baku.LibqiDotNet\Baku.LibqiDotNet.ServiceCodeGenerator\QiServiceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ServiceName));
            
            #line default
            #line hidden
            this.Write("(QiSession session)\r\n        {\r\n            SourceService = session.GetService(\"");
            
            #line 16 "C:\Users\style\Documents\GitHub\BakuLibQiDotNet\Baku.LibqiDotNet\Baku.LibqiDotNet.ServiceCodeGenerator\QiServiceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ServiceName));
            
            #line default
            #line hidden
            this.Write("\");\r\n        }\r\n\r\n        /// <summary>コード生成によってラップされる前のサービスオブジェクトを取得します。</summar" +
                    "y>\r\n        public QiObject SourceService { get; }\r\n\r\n\r\n");
            
            #line 23 "C:\Users\style\Documents\GitHub\BakuLibQiDotNet\Baku.LibqiDotNet\Baku.LibqiDotNet.ServiceCodeGenerator\QiServiceTemplate.tt"

	foreach (var mInfo in MethodInfos)
    {

            
            #line default
            #line hidden
            this.Write("        /// <summary>");
            
            #line 27 "C:\Users\style\Documents\GitHub\BakuLibQiDotNet\Baku.LibqiDotNet\Baku.LibqiDotNet.ServiceCodeGenerator\QiServiceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(mInfo.Description));
            
            #line default
            #line hidden
            this.Write("</summary>\r\n");
            
            #line 28 "C:\Users\style\Documents\GitHub\BakuLibQiDotNet\Baku.LibqiDotNet\Baku.LibqiDotNet.ServiceCodeGenerator\QiServiceTemplate.tt"
 
		for (int i = 0;i < mInfo.ArgumentCount; i++)
        {

            
            #line default
            #line hidden
            this.Write("\t\t");
            
            #line 32 "C:\Users\style\Documents\GitHub\BakuLibQiDotNet\Baku.LibqiDotNet\Baku.LibqiDotNet.ServiceCodeGenerator\QiServiceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetArgumentXmlDocumentComment(mInfo.ArgumentNames[i], mInfo.ArgumentDescriptions[i])));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 33 "C:\Users\style\Documents\GitHub\BakuLibQiDotNet\Baku.LibqiDotNet\Baku.LibqiDotNet.ServiceCodeGenerator\QiServiceTemplate.tt"

		}

            
            #line default
            #line hidden
            this.Write("\t\t/// <returns>");
            
            #line 36 "C:\Users\style\Documents\GitHub\BakuLibQiDotNet\Baku.LibqiDotNet\Baku.LibqiDotNet.ServiceCodeGenerator\QiServiceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(mInfo.ReturnDescription));
            
            #line default
            #line hidden
            this.Write("</returns>\r\n        public ");
            
            #line 37 "C:\Users\style\Documents\GitHub\BakuLibQiDotNet\Baku.LibqiDotNet\Baku.LibqiDotNet.ServiceCodeGenerator\QiServiceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(mInfo.ReturnValueSignature));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 37 "C:\Users\style\Documents\GitHub\BakuLibQiDotNet\Baku.LibqiDotNet\Baku.LibqiDotNet.ServiceCodeGenerator\QiServiceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(mInfo.MethodName));
            
            #line default
            #line hidden
            this.Write("(");
            
            #line 37 "C:\Users\style\Documents\GitHub\BakuLibQiDotNet\Baku.LibqiDotNet\Baku.LibqiDotNet.ServiceCodeGenerator\QiServiceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(mInfo.ArgumentDeclaration));
            
            #line default
            #line hidden
            this.Write(")\r\n        {\r\n            ");
            
            #line 39 "C:\Users\style\Documents\GitHub\BakuLibQiDotNet\Baku.LibqiDotNet\Baku.LibqiDotNet.ServiceCodeGenerator\QiServiceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(mInfo.ReturnExpression));
            
            #line default
            #line hidden
            this.Write("SourceService[\"");
            
            #line 39 "C:\Users\style\Documents\GitHub\BakuLibQiDotNet\Baku.LibqiDotNet\Baku.LibqiDotNet.ServiceCodeGenerator\QiServiceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(mInfo.OriginalMethodName));
            
            #line default
            #line hidden
            this.Write("\"].Call");
            
            #line 39 "C:\Users\style\Documents\GitHub\BakuLibQiDotNet\Baku.LibqiDotNet\Baku.LibqiDotNet.ServiceCodeGenerator\QiServiceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(mInfo.CallObjectSuffixOrEmpty));
            
            #line default
            #line hidden
            this.Write("(");
            
            #line 39 "C:\Users\style\Documents\GitHub\BakuLibQiDotNet\Baku.LibqiDotNet\Baku.LibqiDotNet.ServiceCodeGenerator\QiServiceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(mInfo.ArgumentUsage));
            
            #line default
            #line hidden
            this.Write(");\r\n        }\r\n\r\n");
            
            #line 42 "C:\Users\style\Documents\GitHub\BakuLibQiDotNet\Baku.LibqiDotNet\Baku.LibqiDotNet.ServiceCodeGenerator\QiServiceTemplate.tt"

    }

            
            #line default
            #line hidden
            this.Write("    }\r\n}");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    public class QiServiceTemplateBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}