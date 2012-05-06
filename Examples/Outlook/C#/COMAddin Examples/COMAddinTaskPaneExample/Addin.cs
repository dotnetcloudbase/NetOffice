﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using Microsoft.Win32;
using System.Windows.Forms;
using Extensibility;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

using Outlook = NetOffice.OutlookApi;
using Office = NetOffice.OfficeApi;
using NetOffice.OutlookApi.Enums;
using NetOffice.OfficeApi.Enums;

namespace COMAddinTaskPaneExampleCS4
{
    [GuidAttribute("14EE5266-A384-49BD-81AD-26FD72E8B4E0"), ProgId("OutlookAddinCS4.TaskPaneAddin"), ComVisible(true)]
    public class Addin : IDTExtensibility2 , Office.ICustomTaskPaneConsumer
    {
        private static readonly string _addinOfficeRegistryKey  = "Software\\Microsoft\\Office\\Outlook\\AddIns\\";
        private static readonly string _prodId                  = "OutlookAddinCS4.TaskPaneAddin";
        private static readonly string _addinFriendlyName       = "NetOffice Sample Addin in C#";
        private static readonly string _addinDescription        = "NetOffice Sample Addin with custom Task Pane";
        
        private static SampleControl _sampleControl;
        private static Outlook.Application _outlookApplication;

        internal static Outlook.Application Application { get { return _outlookApplication; } }

        #region ICustomTaskPaneConsumer Member

        public void CTPFactoryAvailable(object CTPFactoryInst)
        {
            try
            {
                Office.ICTPFactory ctpFactory = new NetOffice.OfficeApi.ICTPFactory(_outlookApplication, CTPFactoryInst);
                Office._CustomTaskPane taskPane = ctpFactory.CreateCTP(typeof(Addin).Assembly.GetName().Name + ".SampleControl", "NetOffice Sample Pane(CS4)", Type.Missing);
                taskPane.DockPosition = MsoCTPDockPosition.msoCTPDockPositionRight;
                taskPane.Width = 300;
                taskPane.Visible = true;
                _sampleControl = taskPane.ContentControl as SampleControl;
                ctpFactory.Dispose();
            }
            catch (Exception exception)
            {
                string message = string.Format("An error occured.{0}{0}{1}", Environment.NewLine, exception.Message);
                MessageBox.Show(message, _prodId, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region IDTExtensibility2 Members

        void IDTExtensibility2.OnConnection(object Application, ext_ConnectMode ConnectMode, object AddInInst, ref Array custom)
        {
            try
            {
                _outlookApplication = new Outlook.Application(null, Application);
            }
            catch (Exception exception)
            {
                string message = string.Format("An error occured.{0}{0}{1}", Environment.NewLine, exception.Message);
                MessageBox.Show(message, _prodId, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void IDTExtensibility2.OnDisconnection(ext_DisconnectMode RemoveMode, ref Array custom)
        {
            try
            {
                if (null != _outlookApplication)
                    _outlookApplication.Dispose();
            }
            catch (Exception exception)
            {
                string message = string.Format("An error occured.{0}{0}{1}", Environment.NewLine, exception.Message);
                MessageBox.Show(message, _prodId, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void IDTExtensibility2.OnStartupComplete(ref Array custom)
        {

        }

        void IDTExtensibility2.OnAddInsUpdate(ref Array custom)
        {

        }

        void IDTExtensibility2.OnBeginShutdown(ref Array custom)
        {

        }

        #endregion

        #region COM Register Functions

        [ComRegisterFunctionAttribute]
        public static void RegisterFunction(Type type)
        {
            try
            {
                // add codebase value
                Assembly thisAssembly = Assembly.GetAssembly(typeof(Addin));
                RegistryKey key = Registry.ClassesRoot.CreateSubKey("CLSID\\{" + type.GUID.ToString().ToUpper() + "}\\InprocServer32\\1.0.0.0");
                key.SetValue("CodeBase", thisAssembly.CodeBase);
                key.Close();

                key = Registry.ClassesRoot.CreateSubKey("CLSID\\{" + type.GUID.ToString().ToUpper() + "}\\InprocServer32");
                key.SetValue("CodeBase", thisAssembly.CodeBase);
                key.Close();

                // add bypass key
                // http://support.microsoft.com/kb/948461
                key = Registry.ClassesRoot.CreateSubKey("Interface\\{000C0601-0000-0000-C000-000000000046}");
                string defaultValue = key.GetValue("") as string;
                if (null == defaultValue)
                    key.SetValue("", "Office .NET Framework Lockback Bypass Key");
                key.Close();

                // add outlook addin key
                Registry.CurrentUser.CreateSubKey(_addinOfficeRegistryKey + _prodId);
                RegistryKey regKeyExcel = Registry.CurrentUser.OpenSubKey(_addinOfficeRegistryKey + _prodId, true);
                regKeyExcel.SetValue("LoadBehavior", Convert.ToInt32(3));
                regKeyExcel.SetValue("FriendlyName", _addinFriendlyName);
                regKeyExcel.SetValue("Description", _addinDescription);
                regKeyExcel.Close();
            }
            catch (Exception ex)
            {
                string details = string.Format("{1}{1}Details:{1}{1}{0}", ex.Message, Environment.NewLine);
                MessageBox.Show("An error occured." + details, "Register " + _prodId, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        [ComUnregisterFunctionAttribute]
        public static void UnregisterFunction(Type type)
        {
            try
            {
                // unregister addin
                Registry.ClassesRoot.DeleteSubKey(@"CLSID\{" + type.GUID.ToString().ToUpper() + @"}\Programmable", false);

                // unregister addin in office
                Registry.CurrentUser.DeleteSubKey(_addinOfficeRegistryKey + _prodId, false);

            }
            catch (Exception throwedException)
            {
                string details = string.Format("{1}{1}Details:{1}{1}{0}", throwedException.Message, Environment.NewLine);
                MessageBox.Show("An error occured." + details, "Unregister " + _prodId, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion
    }
}