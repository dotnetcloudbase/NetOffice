//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using LateBindingApi.Core;
namespace NetOffice.ADODBApi
{

	#region Delegates

	#pragma warning disable
	public delegate void Connection_InfoMessageEventHandler(NetOffice.ADODBApi.Error pError, NetOffice.ADODBApi.Enums.EventStatusEnum adStatus, NetOffice.ADODBApi._Connection pConnection);
	public delegate void Connection_BeginTransCompleteEventHandler(Int32 TransactionLevel, NetOffice.ADODBApi.Error pError, NetOffice.ADODBApi.Enums.EventStatusEnum adStatus, NetOffice.ADODBApi._Connection pConnection);
	public delegate void Connection_CommitTransCompleteEventHandler(NetOffice.ADODBApi.Error pError, NetOffice.ADODBApi.Enums.EventStatusEnum adStatus, NetOffice.ADODBApi._Connection pConnection);
	public delegate void Connection_RollbackTransCompleteEventHandler(NetOffice.ADODBApi.Error pError, NetOffice.ADODBApi.Enums.EventStatusEnum adStatus, NetOffice.ADODBApi._Connection pConnection);
	public delegate void Connection_WillExecuteEventHandler(ref string Source, NetOffice.ADODBApi.Enums.CursorTypeEnum CursorType, NetOffice.ADODBApi.Enums.LockTypeEnum LockType, ref Int32 Options, NetOffice.ADODBApi.Enums.EventStatusEnum adStatus, NetOffice.ADODBApi._Command pCommand, NetOffice.ADODBApi._Recordset pRecordset, NetOffice.ADODBApi._Connection pConnection);
	public delegate void Connection_ExecuteCompleteEventHandler(Int32 RecordsAffected, NetOffice.ADODBApi.Error pError, NetOffice.ADODBApi.Enums.EventStatusEnum adStatus, NetOffice.ADODBApi._Command pCommand, NetOffice.ADODBApi._Recordset pRecordset, NetOffice.ADODBApi._Connection pConnection);
	public delegate void Connection_WillConnectEventHandler(ref string ConnectionString, ref string UserID, ref string Password, ref Int32 Options, NetOffice.ADODBApi.Enums.EventStatusEnum adStatus, NetOffice.ADODBApi._Connection pConnection);
	public delegate void Connection_ConnectCompleteEventHandler(NetOffice.ADODBApi.Error pError, NetOffice.ADODBApi.Enums.EventStatusEnum adStatus, NetOffice.ADODBApi._Connection pConnection);
	public delegate void Connection_DisconnectEventHandler(NetOffice.ADODBApi.Enums.EventStatusEnum adStatus, NetOffice.ADODBApi._Connection pConnection);
	#pragma warning restore

	#endregion

	///<summary>
	/// CoClass Connection SupportByLibrary ADO2.1 ADO2.5 
	///</summary>
	[SupportByLibrary("ADO2.1","ADO2.5")]
	[EntityTypeAttribute(EntityType.IsCoClass)]
	public class Connection : _Connection, IEventBinding 
	{
		#pragma warning disable
		#region Fields
		
		private NetRuntimeSystem.Runtime.InteropServices.ComTypes.IConnectionPoint _connectPoint;
		private string _activeSinkId;
		private NetRuntimeSystem.Type _thisType;
		ConnectionEvents_SinkHelper _connectionEvents_SinkHelper;
	
		#endregion
		
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Connection(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Connection(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Connection(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		public Connection()
		{
			CreateFromProgId("ADODB.Connection");
		}
		
		/// <param name="progId">progId</param>
		public Connection(string progId)
		{
			CreateFromProgId(progId);
		}

		#endregion
		
		#region Private Methods
		
		/// <summary>
        /// creates active sink helper
        /// </summary>
		private void CreateEventBridge()
        {
			if(false == LateBindingApi.Core.Settings.EnableEvents)
				return;
	
			if (null != _connectPoint)
				return;
	
            if (null == _activeSinkId)
				_activeSinkId = SinkHelper.GetConnectionPoint(this, ref _connectPoint, ConnectionEvents_SinkHelper.Id);


			if(ConnectionEvents_SinkHelper.Id.Equals(_activeSinkId, StringComparison.InvariantCultureIgnoreCase))
			{
				_connectionEvents_SinkHelper = new ConnectionEvents_SinkHelper(this, _connectPoint);
				return;
			} 
        }
		
		#endregion

		#region Events

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5
		/// </summary>
		private event Connection_InfoMessageEventHandler _InfoMessageEvent;

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5
		/// </summary>
		[SupportByLibrary("ADO2.1","ADO2.5")]
		public event Connection_InfoMessageEventHandler InfoMessageEvent
		{
			add
			{
				CreateEventBridge();
				_InfoMessageEvent += value;
			}
			remove
			{
				_InfoMessageEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5
		/// </summary>
		private event Connection_BeginTransCompleteEventHandler _BeginTransCompleteEvent;

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5
		/// </summary>
		[SupportByLibrary("ADO2.1","ADO2.5")]
		public event Connection_BeginTransCompleteEventHandler BeginTransCompleteEvent
		{
			add
			{
				CreateEventBridge();
				_BeginTransCompleteEvent += value;
			}
			remove
			{
				_BeginTransCompleteEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5
		/// </summary>
		private event Connection_CommitTransCompleteEventHandler _CommitTransCompleteEvent;

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5
		/// </summary>
		[SupportByLibrary("ADO2.1","ADO2.5")]
		public event Connection_CommitTransCompleteEventHandler CommitTransCompleteEvent
		{
			add
			{
				CreateEventBridge();
				_CommitTransCompleteEvent += value;
			}
			remove
			{
				_CommitTransCompleteEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5
		/// </summary>
		private event Connection_RollbackTransCompleteEventHandler _RollbackTransCompleteEvent;

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5
		/// </summary>
		[SupportByLibrary("ADO2.1","ADO2.5")]
		public event Connection_RollbackTransCompleteEventHandler RollbackTransCompleteEvent
		{
			add
			{
				CreateEventBridge();
				_RollbackTransCompleteEvent += value;
			}
			remove
			{
				_RollbackTransCompleteEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5
		/// </summary>
		private event Connection_WillExecuteEventHandler _WillExecuteEvent;

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5
		/// </summary>
		[SupportByLibrary("ADO2.1","ADO2.5")]
		public event Connection_WillExecuteEventHandler WillExecuteEvent
		{
			add
			{
				CreateEventBridge();
				_WillExecuteEvent += value;
			}
			remove
			{
				_WillExecuteEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5
		/// </summary>
		private event Connection_ExecuteCompleteEventHandler _ExecuteCompleteEvent;

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5
		/// </summary>
		[SupportByLibrary("ADO2.1","ADO2.5")]
		public event Connection_ExecuteCompleteEventHandler ExecuteCompleteEvent
		{
			add
			{
				CreateEventBridge();
				_ExecuteCompleteEvent += value;
			}
			remove
			{
				_ExecuteCompleteEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5
		/// </summary>
		private event Connection_WillConnectEventHandler _WillConnectEvent;

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5
		/// </summary>
		[SupportByLibrary("ADO2.1","ADO2.5")]
		public event Connection_WillConnectEventHandler WillConnectEvent
		{
			add
			{
				CreateEventBridge();
				_WillConnectEvent += value;
			}
			remove
			{
				_WillConnectEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5
		/// </summary>
		private event Connection_ConnectCompleteEventHandler _ConnectCompleteEvent;

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5
		/// </summary>
		[SupportByLibrary("ADO2.1","ADO2.5")]
		public event Connection_ConnectCompleteEventHandler ConnectCompleteEvent
		{
			add
			{
				CreateEventBridge();
				_ConnectCompleteEvent += value;
			}
			remove
			{
				_ConnectCompleteEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5
		/// </summary>
		private event Connection_DisconnectEventHandler _DisconnectEvent;

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5
		/// </summary>
		[SupportByLibrary("ADO2.1","ADO2.5")]
		public event Connection_DisconnectEventHandler DisconnectEvent
		{
			add
			{
				CreateEventBridge();
				_DisconnectEvent += value;
			}
			remove
			{
				_DisconnectEvent -= value;
			}
		}

		#endregion

        #region IEventBinding Member
        
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public bool EventBridgeInitialized
        {
            get 
            {
                return (null != _connectPoint);
            }
        }
        
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public bool HasEventRecipients       
        {
			get
			{
				if(null == _thisType)
					_thisType = this.GetType();
					
				foreach (NetRuntimeSystem.Reflection.EventInfo item in _thisType.GetEvents())
				{
					MulticastDelegate eventDelegate = (MulticastDelegate) _thisType.GetType().GetField(item.Name, 
																			NetRuntimeSystem.Reflection.BindingFlags.NonPublic |
																			NetRuntimeSystem.Reflection.BindingFlags.Instance).GetValue(this);
					
					if( (null != eventDelegate) && (eventDelegate.GetInvocationList().Length > 0) )
						return false;
				}
				
				return false;
			}
        }
        
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public Delegate[] GetEventRecipients(string eventName)
        {
			if(null == _thisType)
				_thisType = this.GetType();
             
            MulticastDelegate eventDelegate = (MulticastDelegate)_thisType.GetField(
                                                "_" + eventName + "Event",
                                                NetRuntimeSystem.Reflection.BindingFlags.Instance |
                                                NetRuntimeSystem.Reflection.BindingFlags.NonPublic).GetValue(this);

            if (null != eventDelegate)
            {
                Delegate[] delegates = eventDelegate.GetInvocationList();
                return delegates;
            }
            else
                return new Delegate[0];
        }

        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public void DisposeSinkHelper()
        {
			if( null != _connectionEvents_SinkHelper)
			{
				_connectionEvents_SinkHelper.Dispose();
				_connectionEvents_SinkHelper = null;
			}

			_connectPoint = null;
		}
        
        #endregion
		#pragma warning restore
	}
}