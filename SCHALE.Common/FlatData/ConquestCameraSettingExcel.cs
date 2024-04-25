// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace SCHALE.Common.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct ConquestCameraSettingExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static ConquestCameraSettingExcel GetRootAsConquestCameraSettingExcel(ByteBuffer _bb) { return GetRootAsConquestCameraSettingExcel(_bb, new ConquestCameraSettingExcel()); }
  public static ConquestCameraSettingExcel GetRootAsConquestCameraSettingExcel(ByteBuffer _bb, ConquestCameraSettingExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ConquestCameraSettingExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public float ConquestMapBoundaryOffsetLeft { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float ConquestMapBoundaryOffsetRight { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float ConquestMapBoundaryOffsetTop { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float ConquestMapBoundaryOffsetBottom { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float ConquestMapCenterOffsetX { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float ConquestMapCenterOffsetY { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float CameraAngle { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float CameraZoomMax { get { int o = __p.__offset(20); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float CameraZoomMin { get { int o = __p.__offset(22); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float CameraZoomDefault { get { int o = __p.__offset(24); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }

  public static Offset<SCHALE.Common.FlatData.ConquestCameraSettingExcel> CreateConquestCameraSettingExcel(FlatBufferBuilder builder,
      long Id = 0,
      float ConquestMapBoundaryOffsetLeft = 0.0f,
      float ConquestMapBoundaryOffsetRight = 0.0f,
      float ConquestMapBoundaryOffsetTop = 0.0f,
      float ConquestMapBoundaryOffsetBottom = 0.0f,
      float ConquestMapCenterOffsetX = 0.0f,
      float ConquestMapCenterOffsetY = 0.0f,
      float CameraAngle = 0.0f,
      float CameraZoomMax = 0.0f,
      float CameraZoomMin = 0.0f,
      float CameraZoomDefault = 0.0f) {
    builder.StartTable(11);
    ConquestCameraSettingExcel.AddId(builder, Id);
    ConquestCameraSettingExcel.AddCameraZoomDefault(builder, CameraZoomDefault);
    ConquestCameraSettingExcel.AddCameraZoomMin(builder, CameraZoomMin);
    ConquestCameraSettingExcel.AddCameraZoomMax(builder, CameraZoomMax);
    ConquestCameraSettingExcel.AddCameraAngle(builder, CameraAngle);
    ConquestCameraSettingExcel.AddConquestMapCenterOffsetY(builder, ConquestMapCenterOffsetY);
    ConquestCameraSettingExcel.AddConquestMapCenterOffsetX(builder, ConquestMapCenterOffsetX);
    ConquestCameraSettingExcel.AddConquestMapBoundaryOffsetBottom(builder, ConquestMapBoundaryOffsetBottom);
    ConquestCameraSettingExcel.AddConquestMapBoundaryOffsetTop(builder, ConquestMapBoundaryOffsetTop);
    ConquestCameraSettingExcel.AddConquestMapBoundaryOffsetRight(builder, ConquestMapBoundaryOffsetRight);
    ConquestCameraSettingExcel.AddConquestMapBoundaryOffsetLeft(builder, ConquestMapBoundaryOffsetLeft);
    return ConquestCameraSettingExcel.EndConquestCameraSettingExcel(builder);
  }

  public static void StartConquestCameraSettingExcel(FlatBufferBuilder builder) { builder.StartTable(11); }
  public static void AddId(FlatBufferBuilder builder, long id) { builder.AddLong(0, id, 0); }
  public static void AddConquestMapBoundaryOffsetLeft(FlatBufferBuilder builder, float conquestMapBoundaryOffsetLeft) { builder.AddFloat(1, conquestMapBoundaryOffsetLeft, 0.0f); }
  public static void AddConquestMapBoundaryOffsetRight(FlatBufferBuilder builder, float conquestMapBoundaryOffsetRight) { builder.AddFloat(2, conquestMapBoundaryOffsetRight, 0.0f); }
  public static void AddConquestMapBoundaryOffsetTop(FlatBufferBuilder builder, float conquestMapBoundaryOffsetTop) { builder.AddFloat(3, conquestMapBoundaryOffsetTop, 0.0f); }
  public static void AddConquestMapBoundaryOffsetBottom(FlatBufferBuilder builder, float conquestMapBoundaryOffsetBottom) { builder.AddFloat(4, conquestMapBoundaryOffsetBottom, 0.0f); }
  public static void AddConquestMapCenterOffsetX(FlatBufferBuilder builder, float conquestMapCenterOffsetX) { builder.AddFloat(5, conquestMapCenterOffsetX, 0.0f); }
  public static void AddConquestMapCenterOffsetY(FlatBufferBuilder builder, float conquestMapCenterOffsetY) { builder.AddFloat(6, conquestMapCenterOffsetY, 0.0f); }
  public static void AddCameraAngle(FlatBufferBuilder builder, float cameraAngle) { builder.AddFloat(7, cameraAngle, 0.0f); }
  public static void AddCameraZoomMax(FlatBufferBuilder builder, float cameraZoomMax) { builder.AddFloat(8, cameraZoomMax, 0.0f); }
  public static void AddCameraZoomMin(FlatBufferBuilder builder, float cameraZoomMin) { builder.AddFloat(9, cameraZoomMin, 0.0f); }
  public static void AddCameraZoomDefault(FlatBufferBuilder builder, float cameraZoomDefault) { builder.AddFloat(10, cameraZoomDefault, 0.0f); }
  public static Offset<SCHALE.Common.FlatData.ConquestCameraSettingExcel> EndConquestCameraSettingExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<SCHALE.Common.FlatData.ConquestCameraSettingExcel>(o);
  }
}


static public class ConquestCameraSettingExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*ConquestMapBoundaryOffsetLeft*/, 4 /*float*/, 4, false)
      && verifier.VerifyField(tablePos, 8 /*ConquestMapBoundaryOffsetRight*/, 4 /*float*/, 4, false)
      && verifier.VerifyField(tablePos, 10 /*ConquestMapBoundaryOffsetTop*/, 4 /*float*/, 4, false)
      && verifier.VerifyField(tablePos, 12 /*ConquestMapBoundaryOffsetBottom*/, 4 /*float*/, 4, false)
      && verifier.VerifyField(tablePos, 14 /*ConquestMapCenterOffsetX*/, 4 /*float*/, 4, false)
      && verifier.VerifyField(tablePos, 16 /*ConquestMapCenterOffsetY*/, 4 /*float*/, 4, false)
      && verifier.VerifyField(tablePos, 18 /*CameraAngle*/, 4 /*float*/, 4, false)
      && verifier.VerifyField(tablePos, 20 /*CameraZoomMax*/, 4 /*float*/, 4, false)
      && verifier.VerifyField(tablePos, 22 /*CameraZoomMin*/, 4 /*float*/, 4, false)
      && verifier.VerifyField(tablePos, 24 /*CameraZoomDefault*/, 4 /*float*/, 4, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}