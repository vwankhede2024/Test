#region Using directives
using UAManagedCore;
using FTOptix.HMIProject;
using FTOptix.NetLogic;
using FTOptix.UI;
using FTOptix.SerialPort;
using FTOptix.RAEtherNetIP;
using FTOptix.CommunicationDriver;
using FTOptix.SQLiteStore;
using FTOptix.Store;
using FTOptix.DataLogger;
using FTOptix.Recipe;
using FTOptix.EventLogger;
using FTOptix.Alarm;
using FTOptix.ODBCStore;
using FTOptix.WebUI;
using FTOptix.OPCUAServer;
using FTOptix.OPCUAClient;
#endregion

public class DeviceSettingsWidgetLogic : BaseNetLogic
{
    private const string LOGGING_CATEGORY = nameof(DeviceSettingsWidgetLogic);

    public override void Start()
    {
        IUAVariable systemNodePointer = Owner.GetVariable("SystemNode");
        if (systemNodePointer == null)
        {
            Log.Error(LOGGING_CATEGORY, "SystemNode NodePointer not found.");
            return;
        }

        NodeId systemNodeId = (NodeId)systemNodePointer.Value;
        if (systemNodeId == null || systemNodeId == NodeId.Empty)
        {
            Log.Error(LOGGING_CATEGORY, "SystemNode is not defined.");
            return;
        }

        if (InformationModel.Get(systemNodeId) is not FTOptix.System.System)
            Log.Error(LOGGING_CATEGORY, "SystemNode not found.");
    }

    public override void Stop()
    {
    }
}
