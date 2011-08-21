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
	/// DispatchInterface StartDriver SupportByLibrary MSProject, 12,14
	///</summary>
	[SupportByLibrary("MSProject", 12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class StartDriver : COMObject
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
                    _type = typeof(StartDriver);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public StartDriver(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public StartDriver(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public StartDriver(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public StartDriver() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public StartDriver(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary MSProject 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("MSProject", 12,14)]
		public LateBindingApi.MSProjectApi.ActualStartDrivers ActualStartDrivers
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ActualStartDrivers", paramsArray);
				LateBindingApi.MSProjectApi.ActualStartDrivers newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,LateBindingApi.MSProjectApi.ActualStartDrivers.LateBindingApiWrapperType) as LateBindingApi.MSProjectApi.ActualStartDrivers;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary MSProject 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("MSProject", 12,14)]
		public LateBindingApi.MSProjectApi.PredecessorDrivers PredecessorDrivers
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PredecessorDrivers", paramsArray);
				LateBindingApi.MSProjectApi.PredecessorDrivers newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,LateBindingApi.MSProjectApi.PredecessorDrivers.LateBindingApiWrapperType) as LateBindingApi.MSProjectApi.PredecessorDrivers;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary MSProject 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("MSProject", 12,14)]
		public LateBindingApi.MSProjectApi.ChildDrivers ChildTaskDrivers
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ChildTaskDrivers", paramsArray);
				LateBindingApi.MSProjectApi.ChildDrivers newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,LateBindingApi.MSProjectApi.ChildDrivers.LateBindingApiWrapperType) as LateBindingApi.MSProjectApi.ChildDrivers;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary MSProject 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("MSProject", 12,14)]
		public LateBindingApi.MSProjectApi.CalendarDrivers CalendarDrivers
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CalendarDrivers", paramsArray);
				LateBindingApi.MSProjectApi.CalendarDrivers newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,LateBindingApi.MSProjectApi.CalendarDrivers.LateBindingApiWrapperType) as LateBindingApi.MSProjectApi.CalendarDrivers;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary MSProject 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("MSProject", 12,14)]
		public LateBindingApi.MSProjectApi.Task Parent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Parent", paramsArray);
				LateBindingApi.MSProjectApi.Task newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,LateBindingApi.MSProjectApi.Task.LateBindingApiWrapperType) as LateBindingApi.MSProjectApi.Task;
				return newObject;
			}
		}

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
		/// SupportByLibrary MSProject 14
		/// Get
		/// </summary>
		[SupportByLibrary("MSProject", 14)]
		public Int32 Suggestions
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Suggestions", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary MSProject 14
		/// Get
		/// </summary>
		[SupportByLibrary("MSProject", 14)]
		public Int32 Warnings
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Warnings", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary MSProject 14
		/// Get
		/// </summary>
		/// <param name="overallocationType">LateBindingApi.MSProjectApi.Enums.PjOverallocationType overallocationType</param>
		[SupportByLibrary("MSProject", 14)]
		public LateBindingApi.MSProjectApi.OverAllocatedAssignments get_OverAllocatedAssignments(LateBindingApi.MSProjectApi.Enums.PjOverallocationType overallocationType)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(overallocationType);
			object returnItem = Invoker.PropertyGet(this, "OverAllocatedAssignments", paramsArray);
			LateBindingApi.MSProjectApi.OverAllocatedAssignments newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,LateBindingApi.MSProjectApi.OverAllocatedAssignments.LateBindingApiWrapperType) as LateBindingApi.MSProjectApi.OverAllocatedAssignments;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary MSProject 14
		/// Get
		/// </summary>
		/// <param name="StartDate">object StartDate</param>
		/// <param name="FinishDate">object FinishDate</param>
		[SupportByLibrary("MSProject", 14)]
		public object get_EffectiveDateDifference(object startDate, object finishDate)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(startDate, finishDate);
			object returnItem = Invoker.PropertyGet(this, "EffectiveDateDifference", paramsArray);
			if((null != returnItem) && (returnItem is MarshalByRefObject))
			{
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary MSProject 14
		/// Get
		/// </summary>
		/// <param name="Date">object Date</param>
		/// <param name="Duration">object Duration</param>
		[SupportByLibrary("MSProject", 14)]
		public object get_EffectiveDateAdd(object date, object duration)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(date, duration);
			object returnItem = Invoker.PropertyGet(this, "EffectiveDateAdd", paramsArray);
			if((null != returnItem) && (returnItem is MarshalByRefObject))
			{
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary MSProject 14
		/// Get
		/// </summary>
		/// <param name="Date">object Date</param>
		/// <param name="Duration">object Duration</param>
		[SupportByLibrary("MSProject", 14)]
		public object get_EffectiveDateSubtract(object date, object duration)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(date, duration);
			object returnItem = Invoker.PropertyGet(this, "EffectiveDateSubtract", paramsArray);
			if((null != returnItem) && (returnItem is MarshalByRefObject))
			{
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		#endregion

		#region Methods

		#endregion
		#pragma warning restore
	}
}