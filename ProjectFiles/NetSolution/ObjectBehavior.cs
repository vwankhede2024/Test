#region Using directives
using System;
using UAManagedCore;
using OpcUa = UAManagedCore.OpcUa;
using FTOptix.Recipe;
using FTOptix.HMIProject;
using FTOptix.NativeUI;
using FTOptix.UI;
using FTOptix.WebUI;
using FTOptix.Alarm;
using FTOptix.DataLogger;
using FTOptix.EventLogger;
using FTOptix.SQLiteStore;
using FTOptix.Store;
using FTOptix.ODBCStore;
using FTOptix.OPCUAServer;
using FTOptix.RAEtherNetIP;
using FTOptix.System;
using FTOptix.Retentivity;
using FTOptix.NetLogic;
using FTOptix.CoreBase;
using FTOptix.CommunicationDriver;
using FTOptix.SerialPort;
using FTOptix.UI;
using FTOptix.Core;
using FTOptix.OPCUAClient;
#endregion

[CustomBehavior]
public class ObjectBehavior : BaseNetBehavior
{
    public override void Start()
    {
        // Insert code to be executed when the user-defined behavior is started
    }

    public override void Stop()
    {
        // Insert code to be executed when the user-defined behavior is stopped
    }
    [ExportMethod]
 public void StartMotor() {
 Node.Running = true;
 Node.CurSpeed = Node.SetSpeed;
 }
 [ExportMethod]
 public void StopMotor() {
 Node.Running = false;
 Node.CurSpeed = (Int32)0;
 }


#region Auto-generated code, do not edit!
    protected new Object Node => (Object)base.Node;
#endregion
}
