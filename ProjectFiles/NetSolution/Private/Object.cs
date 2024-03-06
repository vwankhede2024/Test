using System;
using UAManagedCore;

//-------------------------------------------
// WARNING: AUTO-GENERATED CODE, DO NOT EDIT!
//-------------------------------------------

[MapType(NamespaceUri = "Demo_RA", Guid = "2c87c7d60e7eba872c25c5c57be6d0eb")]
public class Object : UAObject
{
#region Children properties
    //-------------------------------------------
    // WARNING: AUTO-GENERATED CODE, DO NOT EDIT!
    //-------------------------------------------
    public int SetSpeed
    {
        get
        {
            return (int)Refs.GetVariable("SetSpeed").Value.Value;
        }
        set
        {
            Refs.GetVariable("SetSpeed").SetValue(value);
        }
    }
    public IUAVariable SetSpeedVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("SetSpeed");
        }
    }
    public int CurSpeed
    {
        get
        {
            return (int)Refs.GetVariable("CurSpeed").Value.Value;
        }
        set
        {
            Refs.GetVariable("CurSpeed").SetValue(value);
        }
    }
    public IUAVariable CurSpeedVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("CurSpeed");
        }
    }
    public int Running
    {
        get
        {
            return (int)Refs.GetVariable("Running").Value.Value;
        }
        set
        {
            Refs.GetVariable("Running").SetValue(value);
        }
    }
    public IUAVariable RunningVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("Running");
        }
    }
#endregion
}
