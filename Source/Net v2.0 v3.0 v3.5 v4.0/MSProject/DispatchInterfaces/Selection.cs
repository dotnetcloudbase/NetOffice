//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace LateBindingApi.MSProjectApi
{
	///<summary>
	/// DispatchInterface Selection SupportByLibrary MSProject, 12,14
	///</summary>
	[SupportByLibrary("MSProject", 12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class Selection : COMObject
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
                    _type = typeof(Selection);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Selection(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Selection(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Selection(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Selection() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Selection(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary MSProject 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("MSProject", 12,14)]
		public LateBindingApi.MSProjectApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				LateBindingApi.MSProjectApi.Application newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,LateBindingApi.MSProjectApi.Application.LateBindingApiWrapperType) as LateBindingApi.MSProjectApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary MSProject 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("MSProject", 12,14)]
		public COMObject Parent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Parent", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary MSProject 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("MSProject", 12,14)]
		public LateBindingApi.MSProjectApi.Tasks Tasks
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Tasks", paramsArray);
				LateBindingApi.MSProjectApi.Tasks newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,LateBindingApi.MSProjectApi.Tasks.LateBindingApiWrapperType) as LateBindingApi.MSProjectApi.Tasks;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary MSProject 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("MSProject", 12,14)]
		public LateBindingApi.MSProjectApi.Resources Resources
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Resources", paramsArray);
				LateBindingApi.MSProjectApi.Resources newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,LateBindingApi.MSProjectApi.Resources.LateBindingApiWrapperType) as LateBindingApi.MSProjectApi.Resources;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary MSProject 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("MSProject", 12,14)]
		public LateBindingApi.MSProjectApi.List FieldNameList
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "FieldNameList", paramsArray);
				LateBindingApi.MSProjectApi.List newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,LateBindingApi.MSProjectApi.List.LateBindingApiWrapperType) as LateBindingApi.MSProjectApi.List;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary MSProject 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("MSProject", 12,14)]
		public LateBindingApi.MSProjectApi.List FieldIDList
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "FieldIDList", paramsArray);
				LateBindingApi.MSProjectApi.List newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,LateBindingApi.MSProjectApi.List.LateBindingApiWrapperType) as LateBindingApi.MSProjectApi.List;
				return newObject;
			}
		}

		#endregion

		#region Methods

		#endregion
		#pragma warning restore
	}
}