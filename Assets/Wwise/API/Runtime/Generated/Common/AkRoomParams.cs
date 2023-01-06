#if ! (UNITY_DASHBOARD_WIDGET || UNITY_WEBPLAYER || UNITY_WII || UNITY_WIIU || UNITY_NACL || UNITY_FLASH || UNITY_BLACKBERRY) // Disable under unsupported platforms.
//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class AkRoomParams : global::System.IDisposable {
  private global::System.IntPtr swigCPtr;
  protected bool swigCMemOwn;

  internal AkRoomParams(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = cPtr;
  }

  internal static global::System.IntPtr getCPtr(AkRoomParams obj) {
    return (obj == null) ? global::System.IntPtr.Zero : obj.swigCPtr;
  }

  internal virtual void setCPtr(global::System.IntPtr cPtr) {
    Dispose();
    swigCPtr = cPtr;
  }

  ~AkRoomParams() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          AkSoundEnginePINVOKE.CSharp_delete_AkRoomParams(swigCPtr);
        }
        swigCPtr = global::System.IntPtr.Zero;
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public AkRoomParams() : this(AkSoundEnginePINVOKE.CSharp_new_AkRoomParams(), true) {
  }

  public UnityEngine.Vector3 Front { set { AkSoundEnginePINVOKE.CSharp_AkRoomParams_Front_set(swigCPtr, value); }  get { return AkSoundEnginePINVOKE.CSharp_AkRoomParams_Front_get(swigCPtr); } 
  }

  public UnityEngine.Vector3 Up { set { AkSoundEnginePINVOKE.CSharp_AkRoomParams_Up_set(swigCPtr, value); }  get { return AkSoundEnginePINVOKE.CSharp_AkRoomParams_Up_get(swigCPtr); } 
  }

  public uint ReverbAuxBus { set { AkSoundEnginePINVOKE.CSharp_AkRoomParams_ReverbAuxBus_set(swigCPtr, value); }  get { return AkSoundEnginePINVOKE.CSharp_AkRoomParams_ReverbAuxBus_get(swigCPtr); } 
  }

  public float ReverbLevel { set { AkSoundEnginePINVOKE.CSharp_AkRoomParams_ReverbLevel_set(swigCPtr, value); }  get { return AkSoundEnginePINVOKE.CSharp_AkRoomParams_ReverbLevel_get(swigCPtr); } 
  }

  public float TransmissionLoss { set { AkSoundEnginePINVOKE.CSharp_AkRoomParams_TransmissionLoss_set(swigCPtr, value); }  get { return AkSoundEnginePINVOKE.CSharp_AkRoomParams_TransmissionLoss_get(swigCPtr); } 
  }

  public float RoomGameObj_AuxSendLevelToSelf { set { AkSoundEnginePINVOKE.CSharp_AkRoomParams_RoomGameObj_AuxSendLevelToSelf_set(swigCPtr, value); }  get { return AkSoundEnginePINVOKE.CSharp_AkRoomParams_RoomGameObj_AuxSendLevelToSelf_get(swigCPtr); } 
  }

  public bool RoomGameObj_KeepRegistered { set { AkSoundEnginePINVOKE.CSharp_AkRoomParams_RoomGameObj_KeepRegistered_set(swigCPtr, value); }  get { return AkSoundEnginePINVOKE.CSharp_AkRoomParams_RoomGameObj_KeepRegistered_get(swigCPtr); } 
  }

}
#endif // #if ! (UNITY_DASHBOARD_WIDGET || UNITY_WEBPLAYER || UNITY_WII || UNITY_WIIU || UNITY_NACL || UNITY_FLASH || UNITY_BLACKBERRY) // Disable under unsupported platforms.