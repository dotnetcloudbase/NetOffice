using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using NetOffice;
namespace NetOffice.VisioApi
{
	///<summary>
	/// DispatchInterface IVMovedSelectionEvent 
	/// SupportByVersion Visio, 14,15
	///</summary>
	[SupportByVersionAttribute("Visio", 14,15)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class IVMovedSelectionEvent : COMObject
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
                    _type = typeof(IVMovedSelectionEvent);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
		public IVMovedSelectionEvent(Core factory, COMObject parentObject, object comProxy) : base(factory, parentObject, comProxy)
		{
			
		}

        ///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IVMovedSelectionEvent(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IVMovedSelectionEvent(Core factory, COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(factory, parentObject, comProxy, comProxyType)
		{

		}

		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IVMovedSelectionEvent(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		///<param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IVMovedSelectionEvent(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IVMovedSelectionEvent() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IVMovedSelectionEvent(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Visio 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Visio", 14,15)]
		public NetOffice.VisioApi.IVApplication Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.VisioApi.IVApplication newObject = Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.VisioApi.IVApplication;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Visio 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Visio", 14,15)]
		public Int16 ObjectType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ObjectType", paramsArray);
				return NetRuntimeSystem.Convert.ToInt16(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Visio 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Visio", 14,15)]
		public NetOffice.VisioApi.IVShape ReplacementShape
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ReplacementShape", paramsArray);
				NetOffice.VisioApi.IVShape newObject = Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.VisioApi.IVShape;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Visio 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Visio", 14,15)]
		public NetOffice.VisioApi.IVSelection SelectionSource
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SelectionSource", paramsArray);
				NetOffice.VisioApi.IVSelection newObject = Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.VisioApi.IVSelection;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Visio 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Visio", 14,15)]
		public NetOffice.VisioApi.IVSelection SelectionTarget
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SelectionTarget", paramsArray);
				NetOffice.VisioApi.IVSelection newObject = Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.VisioApi.IVSelection;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Visio 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Visio", 14,15)]
		public Int16 Stat
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Stat", paramsArray);
				return NetRuntimeSystem.Convert.ToInt16(returnItem);
			}
		}

		#endregion

		#region Methods

		#endregion
		#pragma warning restore
	}
}