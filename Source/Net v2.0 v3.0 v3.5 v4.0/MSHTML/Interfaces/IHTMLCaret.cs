//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Reflection;
using LateBindingApi.Core;
namespace LateBindingApi.MSHTMLApi
{
	///<summary>
	/// Interface IHTMLCaret SupportByLibrary MSHTML, 4
	///</summary>
	[SupportByLibrary("MSHTML", 4)]
	[EntityTypeAttribute(EntityType.IsInterface)]
	public class IHTMLCaret : COMObject
	{
		#pragma warning disable
		#region Type Information

        private static Type _type;

		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(IHTMLCaret);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IHTMLCaret(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IHTMLCaret(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IHTMLCaret(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IHTMLCaret() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IHTMLCaret(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pDispPointer">LateBindingApi.MSHTMLApi.IDisplayPointer pDispPointer</param>
		/// <param name="fScrollIntoView">Int32 fScrollIntoView</param>
		/// <param name="eDir">LateBindingApi.MSHTMLApi.Enums._CARET_DIRECTION eDir</param>
		[SupportByLibrary("MSHTML", 4)]
		public Int32 MoveCaretToPointer(LateBindingApi.MSHTMLApi.IDisplayPointer pDispPointer, Int32 fScrollIntoView, LateBindingApi.MSHTMLApi.Enums._CARET_DIRECTION eDir)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pDispPointer, fScrollIntoView, eDir);
			object returnItem = Invoker.MethodReturn(this, "MoveCaretToPointer", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pDispPointer">LateBindingApi.MSHTMLApi.IDisplayPointer pDispPointer</param>
		/// <param name="fVisible">Int32 fVisible</param>
		/// <param name="fScrollIntoView">Int32 fScrollIntoView</param>
		/// <param name="eDir">LateBindingApi.MSHTMLApi.Enums._CARET_DIRECTION eDir</param>
		[SupportByLibrary("MSHTML", 4)]
		public Int32 MoveCaretToPointerEx(LateBindingApi.MSHTMLApi.IDisplayPointer pDispPointer, Int32 fVisible, Int32 fScrollIntoView, LateBindingApi.MSHTMLApi.Enums._CARET_DIRECTION eDir)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pDispPointer, fVisible, fScrollIntoView, eDir);
			object returnItem = Invoker.MethodReturn(this, "MoveCaretToPointerEx", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pIMarkupPointer">LateBindingApi.MSHTMLApi.IMarkupPointer pIMarkupPointer</param>
		[SupportByLibrary("MSHTML", 4)]
		public Int32 MoveMarkupPointerToCaret(LateBindingApi.MSHTMLApi.IMarkupPointer pIMarkupPointer)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pIMarkupPointer);
			object returnItem = Invoker.MethodReturn(this, "MoveMarkupPointerToCaret", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pDispPointer">LateBindingApi.MSHTMLApi.IDisplayPointer pDispPointer</param>
		[SupportByLibrary("MSHTML", 4)]
		public Int32 MoveDisplayPointerToCaret(LateBindingApi.MSHTMLApi.IDisplayPointer pDispPointer)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pDispPointer);
			object returnItem = Invoker.MethodReturn(this, "MoveDisplayPointerToCaret", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pIsVisible">Int32 pIsVisible</param>
		[SupportByLibrary("MSHTML", 4)]
		public Int32 IsVisible(Int32 pIsVisible)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pIsVisible);
			object returnItem = Invoker.MethodReturn(this, "IsVisible", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="fScrollIntoView">Int32 fScrollIntoView</param>
		[SupportByLibrary("MSHTML", 4)]
		public Int32 Show(Int32 fScrollIntoView)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fScrollIntoView);
			object returnItem = Invoker.MethodReturn(this, "Show", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public Int32 Hide()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Hide", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pText">Int16 pText</param>
		/// <param name="lLen">Int32 lLen</param>
		[SupportByLibrary("MSHTML", 4)]
		public Int32 InsertText(Int16 pText, Int32 lLen)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pText, lLen);
			object returnItem = Invoker.MethodReturn(this, "InsertText", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public Int32 scrollIntoView()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "scrollIntoView", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pPoint">tagPOINT pPoint</param>
		/// <param name="fTranslate">Int32 fTranslate</param>
		[SupportByLibrary("MSHTML", 4)]
		public Int32 GetLocation(tagPOINT pPoint, Int32 fTranslate)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pPoint, fTranslate);
			object returnItem = Invoker.MethodReturn(this, "GetLocation", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="peDir">LateBindingApi.MSHTMLApi.Enums._CARET_DIRECTION peDir</param>
		[SupportByLibrary("MSHTML", 4)]
		public Int32 GetCaretDirection(LateBindingApi.MSHTMLApi.Enums._CARET_DIRECTION peDir)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(peDir);
			object returnItem = Invoker.MethodReturn(this, "GetCaretDirection", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="eDir">LateBindingApi.MSHTMLApi.Enums._CARET_DIRECTION eDir</param>
		[SupportByLibrary("MSHTML", 4)]
		public Int32 SetCaretDirection(LateBindingApi.MSHTMLApi.Enums._CARET_DIRECTION eDir)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(eDir);
			object returnItem = Invoker.MethodReturn(this, "SetCaretDirection", paramsArray);
			return (Int32)returnItem;
		}

		#endregion
		#pragma warning restore
	}
}