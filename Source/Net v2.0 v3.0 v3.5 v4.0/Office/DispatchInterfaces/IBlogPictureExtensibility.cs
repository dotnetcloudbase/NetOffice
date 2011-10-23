//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.OfficeApi
{
	///<summary>
	/// DispatchInterface IBlogPictureExtensibility SupportByLibrary Office, 12,14
	///</summary>
	[SupportByLibrary("Office", 12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class IBlogPictureExtensibility : COMObject
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
                    _type = typeof(IBlogPictureExtensibility);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IBlogPictureExtensibility(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IBlogPictureExtensibility(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IBlogPictureExtensibility(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IBlogPictureExtensibility() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IBlogPictureExtensibility(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		/// <param name="BlogPictureProvider">string BlogPictureProvider</param>
		/// <param name="FriendlyName">string FriendlyName</param>
		[SupportByLibrary("Office", 12,14)]
		public void BlogPictureProviderProperties(string blogPictureProvider, string friendlyName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(blogPictureProvider, friendlyName);
			Invoker.Method(this, "BlogPictureProviderProperties", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		/// <param name="Account">string Account</param>
		/// <param name="BlogProvider">string BlogProvider</param>
		/// <param name="ParentWindow">Int32 ParentWindow</param>
		/// <param name="Document">object Document</param>
		[SupportByLibrary("Office", 12,14)]
		public void CreatePictureAccount(string account, string blogProvider, Int32 parentWindow, object document)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(account, blogProvider, parentWindow, document);
			Invoker.Method(this, "CreatePictureAccount", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		/// <param name="Account">string Account</param>
		/// <param name="ParentWindow">Int32 ParentWindow</param>
		/// <param name="Document">object Document</param>
		/// <param name="Image">object Image</param>
		/// <param name="PictureURI">string PictureURI</param>
		/// <param name="ImageType">Int32 ImageType</param>
		[SupportByLibrary("Office", 12,14)]
		public void PublishPicture(string account, Int32 parentWindow, object document, object image, string pictureURI, Int32 imageType)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(account, parentWindow, document, image, pictureURI, imageType);
			Invoker.Method(this, "PublishPicture", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}