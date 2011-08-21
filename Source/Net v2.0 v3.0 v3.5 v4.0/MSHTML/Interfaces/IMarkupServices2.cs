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
	/// Interface IMarkupServices2 SupportByLibrary MSHTML, 4
	///</summary>
	[SupportByLibrary("MSHTML", 4)]
	[EntityTypeAttribute(EntityType.IsInterface)]
	public class IMarkupServices2 : IMarkupServices
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
                    _type = typeof(IMarkupServices2);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IMarkupServices2(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IMarkupServices2(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IMarkupServices2(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IMarkupServices2() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IMarkupServices2(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="hglobalHTML">_userHGLOBAL hglobalHTML</param>
		/// <param name="dwFlags">Int32 dwFlags</param>
		/// <param name="pContext">LateBindingApi.MSHTMLApi.IMarkupContainer pContext</param>
		/// <param name="ppContainerResult">LateBindingApi.MSHTMLApi.IMarkupContainer ppContainerResult</param>
		/// <param name="pPointerStart">LateBindingApi.MSHTMLApi.IMarkupPointer pPointerStart</param>
		/// <param name="pPointerFinish">LateBindingApi.MSHTMLApi.IMarkupPointer pPointerFinish</param>
		[SupportByLibrary("MSHTML", 4)]
		public Int32 ParseGlobalEx(_userHGLOBAL hglobalHTML, Int32 dwFlags, LateBindingApi.MSHTMLApi.IMarkupContainer pContext, LateBindingApi.MSHTMLApi.IMarkupContainer ppContainerResult, LateBindingApi.MSHTMLApi.IMarkupPointer pPointerStart, LateBindingApi.MSHTMLApi.IMarkupPointer pPointerFinish)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(hglobalHTML, dwFlags, pContext, ppContainerResult, pPointerStart, pPointerFinish);
			object returnItem = Invoker.MethodReturn(this, "ParseGlobalEx", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pPointerStart">LateBindingApi.MSHTMLApi.IMarkupPointer pPointerStart</param>
		/// <param name="pPointerFinish">LateBindingApi.MSHTMLApi.IMarkupPointer pPointerFinish</param>
		/// <param name="pPointerTarget">LateBindingApi.MSHTMLApi.IMarkupPointer pPointerTarget</param>
		/// <param name="pPointerStatus">LateBindingApi.MSHTMLApi.IMarkupPointer pPointerStatus</param>
		/// <param name="ppElemFailBottom">LateBindingApi.MSHTMLApi.IHTMLElement ppElemFailBottom</param>
		/// <param name="ppElemFailTop">LateBindingApi.MSHTMLApi.IHTMLElement ppElemFailTop</param>
		[SupportByLibrary("MSHTML", 4)]
		public Int32 ValidateElements(LateBindingApi.MSHTMLApi.IMarkupPointer pPointerStart, LateBindingApi.MSHTMLApi.IMarkupPointer pPointerFinish, LateBindingApi.MSHTMLApi.IMarkupPointer pPointerTarget, LateBindingApi.MSHTMLApi.IMarkupPointer pPointerStatus, LateBindingApi.MSHTMLApi.IHTMLElement ppElemFailBottom, LateBindingApi.MSHTMLApi.IHTMLElement ppElemFailTop)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pPointerStart, pPointerFinish, pPointerTarget, pPointerStatus, ppElemFailBottom, ppElemFailTop);
			object returnItem = Invoker.MethodReturn(this, "ValidateElements", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pSegmentList">LateBindingApi.MSHTMLApi.ISegmentList pSegmentList</param>
		/// <param name="dwFlags">Int32 dwFlags</param>
		[SupportByLibrary("MSHTML", 4)]
		public Int32 SaveSegmentsToClipboard(LateBindingApi.MSHTMLApi.ISegmentList pSegmentList, Int32 dwFlags)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pSegmentList, dwFlags);
			object returnItem = Invoker.MethodReturn(this, "SaveSegmentsToClipboard", paramsArray);
			return (Int32)returnItem;
		}

		#endregion
		#pragma warning restore
	}
}