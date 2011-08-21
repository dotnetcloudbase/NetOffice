//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.VBIDEApi
{
	///<summary>
	/// DispatchInterface Window SupportByLibrary VBIDE, 5.3,12
	///</summary>
	[SupportByLibrary("VBIDE", 5.3,12)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class Window : COMObject
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
                    _type = typeof(Window);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Window(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Window(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Window(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Window() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Window(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary VBIDE 5.3, 12
		/// Get
		/// </summary>
		[SupportByLibrary("VBIDE", 5.3,12)]
		public NetOffice.VBIDEApi.VBE VBE
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "VBE", paramsArray);
				NetOffice.VBIDEApi.VBE newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.VBIDEApi.VBE.LateBindingApiWrapperType) as NetOffice.VBIDEApi.VBE;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary VBIDE 5.3, 12
		/// Get
		/// </summary>
		[SupportByLibrary("VBIDE", 5.3,12)]
		public NetOffice.VBIDEApi.Windows Collection
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Collection", paramsArray);
				NetOffice.VBIDEApi.Windows newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.VBIDEApi.Windows.LateBindingApiWrapperType) as NetOffice.VBIDEApi.Windows;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary VBIDE 5.3, 12
		/// Get
		/// </summary>
		[SupportByLibrary("VBIDE", 5.3,12)]
		public string Caption
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Caption", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary VBIDE 5.3, 12
		/// Get/Set
		/// </summary>
		[SupportByLibrary("VBIDE", 5.3,12)]
		public bool Visible
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Visible", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Visible", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary VBIDE 5.3, 12
		/// Get/Set
		/// </summary>
		[SupportByLibrary("VBIDE", 5.3,12)]
		public Int32 Left
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Left", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Left", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary VBIDE 5.3, 12
		/// Get/Set
		/// </summary>
		[SupportByLibrary("VBIDE", 5.3,12)]
		public Int32 Top
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Top", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Top", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary VBIDE 5.3, 12
		/// Get/Set
		/// </summary>
		[SupportByLibrary("VBIDE", 5.3,12)]
		public Int32 Width
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Width", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Width", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary VBIDE 5.3, 12
		/// Get/Set
		/// </summary>
		[SupportByLibrary("VBIDE", 5.3,12)]
		public Int32 Height
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Height", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Height", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary VBIDE 5.3, 12
		/// Get/Set
		/// </summary>
		[SupportByLibrary("VBIDE", 5.3,12)]
		public NetOffice.VBIDEApi.Enums.vbext_WindowState WindowState
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "WindowState", paramsArray);
				return (NetOffice.VBIDEApi.Enums.vbext_WindowState)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "WindowState", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary VBIDE 5.3, 12
		/// Get
		/// </summary>
		[SupportByLibrary("VBIDE", 5.3,12)]
		public NetOffice.VBIDEApi.Enums.vbext_WindowType Type
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Type", paramsArray);
				return (NetOffice.VBIDEApi.Enums.vbext_WindowType)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary VBIDE 5.3, 12
		/// Get
		/// </summary>
		[SupportByLibrary("VBIDE", 5.3,12)]
		public NetOffice.VBIDEApi.LinkedWindows LinkedWindows
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "LinkedWindows", paramsArray);
				NetOffice.VBIDEApi.LinkedWindows newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.VBIDEApi.LinkedWindows.LateBindingApiWrapperType) as NetOffice.VBIDEApi.LinkedWindows;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary VBIDE 5.3, 12
		/// Get
		/// </summary>
		[SupportByLibrary("VBIDE", 5.3,12)]
		public NetOffice.VBIDEApi.Window LinkedWindowFrame
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "LinkedWindowFrame", paramsArray);
				NetOffice.VBIDEApi.Window newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.VBIDEApi.Window.LateBindingApiWrapperType) as NetOffice.VBIDEApi.Window;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary VBIDE 5.3, 12
		/// Get
		/// </summary>
		[SupportByLibrary("VBIDE", 5.3,12)]
		public Int32 HWnd
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "HWnd", paramsArray);
				return (Int32)returnItem;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary VBIDE 5.3, 12
		/// </summary>
		[SupportByLibrary("VBIDE", 5.3,12)]
		public void Close()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Close", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary VBIDE 5.3, 12
		/// </summary>
		[SupportByLibrary("VBIDE", 5.3,12)]
		public void SetFocus()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "SetFocus", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary VBIDE 5.3, 12
		/// </summary>
		/// <param name="eKind">NetOffice.VBIDEApi.Enums.vbext_WindowType eKind</param>
		[SupportByLibrary("VBIDE", 5.3,12)]
		public void SetKind(NetOffice.VBIDEApi.Enums.vbext_WindowType eKind)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(eKind);
			Invoker.Method(this, "SetKind", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary VBIDE 5.3, 12
		/// </summary>
		[SupportByLibrary("VBIDE", 5.3,12)]
		public void Detach()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Detach", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary VBIDE 5.3, 12
		/// </summary>
		/// <param name="lWindowHandle">Int32 lWindowHandle</param>
		[SupportByLibrary("VBIDE", 5.3,12)]
		public void Attach(Int32 lWindowHandle)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(lWindowHandle);
			Invoker.Method(this, "Attach", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}