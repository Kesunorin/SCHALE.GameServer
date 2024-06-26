// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace SCHALE.Common.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::SCHALE.Common.Crypto;
using global::Google.FlatBuffers;

public struct ScenarioCharacterNameExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static ScenarioCharacterNameExcel GetRootAsScenarioCharacterNameExcel(ByteBuffer _bb) { return GetRootAsScenarioCharacterNameExcel(_bb, new ScenarioCharacterNameExcel()); }
  public static ScenarioCharacterNameExcel GetRootAsScenarioCharacterNameExcel(ByteBuffer _bb, ScenarioCharacterNameExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ScenarioCharacterNameExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public uint CharacterName { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public SCHALE.Common.FlatData.ProductionStep ProductionStep { get { int o = __p.__offset(6); return o != 0 ? (SCHALE.Common.FlatData.ProductionStep)__p.bb.GetInt(o + __p.bb_pos) : SCHALE.Common.FlatData.ProductionStep.ToDo; } }
  public string NameKR { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetNameKRBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetNameKRBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetNameKRArray() { return __p.__vector_as_array<byte>(8); }
  public string NicknameKR { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetNicknameKRBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetNicknameKRBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetNicknameKRArray() { return __p.__vector_as_array<byte>(10); }
  public string NameJP { get { int o = __p.__offset(12); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetNameJPBytes() { return __p.__vector_as_span<byte>(12, 1); }
#else
  public ArraySegment<byte>? GetNameJPBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public byte[] GetNameJPArray() { return __p.__vector_as_array<byte>(12); }
  public string NicknameJP { get { int o = __p.__offset(14); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetNicknameJPBytes() { return __p.__vector_as_span<byte>(14, 1); }
#else
  public ArraySegment<byte>? GetNicknameJPBytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public byte[] GetNicknameJPArray() { return __p.__vector_as_array<byte>(14); }
  public SCHALE.Common.FlatData.ScenarioCharacterShapes Shape { get { int o = __p.__offset(16); return o != 0 ? (SCHALE.Common.FlatData.ScenarioCharacterShapes)__p.bb.GetInt(o + __p.bb_pos) : SCHALE.Common.FlatData.ScenarioCharacterShapes.None; } }
  public string SpinePrefabName { get { int o = __p.__offset(18); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetSpinePrefabNameBytes() { return __p.__vector_as_span<byte>(18, 1); }
#else
  public ArraySegment<byte>? GetSpinePrefabNameBytes() { return __p.__vector_as_arraysegment(18); }
#endif
  public byte[] GetSpinePrefabNameArray() { return __p.__vector_as_array<byte>(18); }
  public string SmallPortrait { get { int o = __p.__offset(20); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetSmallPortraitBytes() { return __p.__vector_as_span<byte>(20, 1); }
#else
  public ArraySegment<byte>? GetSmallPortraitBytes() { return __p.__vector_as_arraysegment(20); }
#endif
  public byte[] GetSmallPortraitArray() { return __p.__vector_as_array<byte>(20); }

  public static Offset<SCHALE.Common.FlatData.ScenarioCharacterNameExcel> CreateScenarioCharacterNameExcel(FlatBufferBuilder builder,
      uint CharacterName = 0,
      SCHALE.Common.FlatData.ProductionStep ProductionStep = SCHALE.Common.FlatData.ProductionStep.ToDo,
      StringOffset NameKROffset = default(StringOffset),
      StringOffset NicknameKROffset = default(StringOffset),
      StringOffset NameJPOffset = default(StringOffset),
      StringOffset NicknameJPOffset = default(StringOffset),
      SCHALE.Common.FlatData.ScenarioCharacterShapes Shape = SCHALE.Common.FlatData.ScenarioCharacterShapes.None,
      StringOffset SpinePrefabNameOffset = default(StringOffset),
      StringOffset SmallPortraitOffset = default(StringOffset)) {
    builder.StartTable(9);
    ScenarioCharacterNameExcel.AddSmallPortrait(builder, SmallPortraitOffset);
    ScenarioCharacterNameExcel.AddSpinePrefabName(builder, SpinePrefabNameOffset);
    ScenarioCharacterNameExcel.AddShape(builder, Shape);
    ScenarioCharacterNameExcel.AddNicknameJP(builder, NicknameJPOffset);
    ScenarioCharacterNameExcel.AddNameJP(builder, NameJPOffset);
    ScenarioCharacterNameExcel.AddNicknameKR(builder, NicknameKROffset);
    ScenarioCharacterNameExcel.AddNameKR(builder, NameKROffset);
    ScenarioCharacterNameExcel.AddProductionStep(builder, ProductionStep);
    ScenarioCharacterNameExcel.AddCharacterName(builder, CharacterName);
    return ScenarioCharacterNameExcel.EndScenarioCharacterNameExcel(builder);
  }

  public static void StartScenarioCharacterNameExcel(FlatBufferBuilder builder) { builder.StartTable(9); }
  public static void AddCharacterName(FlatBufferBuilder builder, uint characterName) { builder.AddUint(0, characterName, 0); }
  public static void AddProductionStep(FlatBufferBuilder builder, SCHALE.Common.FlatData.ProductionStep productionStep) { builder.AddInt(1, (int)productionStep, 0); }
  public static void AddNameKR(FlatBufferBuilder builder, StringOffset nameKROffset) { builder.AddOffset(2, nameKROffset.Value, 0); }
  public static void AddNicknameKR(FlatBufferBuilder builder, StringOffset nicknameKROffset) { builder.AddOffset(3, nicknameKROffset.Value, 0); }
  public static void AddNameJP(FlatBufferBuilder builder, StringOffset nameJPOffset) { builder.AddOffset(4, nameJPOffset.Value, 0); }
  public static void AddNicknameJP(FlatBufferBuilder builder, StringOffset nicknameJPOffset) { builder.AddOffset(5, nicknameJPOffset.Value, 0); }
  public static void AddShape(FlatBufferBuilder builder, SCHALE.Common.FlatData.ScenarioCharacterShapes shape) { builder.AddInt(6, (int)shape, 0); }
  public static void AddSpinePrefabName(FlatBufferBuilder builder, StringOffset spinePrefabNameOffset) { builder.AddOffset(7, spinePrefabNameOffset.Value, 0); }
  public static void AddSmallPortrait(FlatBufferBuilder builder, StringOffset smallPortraitOffset) { builder.AddOffset(8, smallPortraitOffset.Value, 0); }
  public static Offset<SCHALE.Common.FlatData.ScenarioCharacterNameExcel> EndScenarioCharacterNameExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<SCHALE.Common.FlatData.ScenarioCharacterNameExcel>(o);
  }
  public ScenarioCharacterNameExcelT UnPack() {
    var _o = new ScenarioCharacterNameExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(ScenarioCharacterNameExcelT _o) {
		byte[] key = TableEncryptionService.CreateKey("ScenarioCharacterName");
    _o.CharacterName = TableEncryptionService.Convert(this.CharacterName, key);
    _o.ProductionStep = TableEncryptionService.Convert(this.ProductionStep, key);
    _o.NameKR = TableEncryptionService.Convert(this.NameKR, key);
    _o.NicknameKR = TableEncryptionService.Convert(this.NicknameKR, key);
    _o.NameJP = TableEncryptionService.Convert(this.NameJP, key);
    _o.NicknameJP = TableEncryptionService.Convert(this.NicknameJP, key);
    _o.Shape = TableEncryptionService.Convert(this.Shape, key);
    _o.SpinePrefabName = TableEncryptionService.Convert(this.SpinePrefabName, key);
    _o.SmallPortrait = TableEncryptionService.Convert(this.SmallPortrait, key);
  }
  public static Offset<SCHALE.Common.FlatData.ScenarioCharacterNameExcel> Pack(FlatBufferBuilder builder, ScenarioCharacterNameExcelT _o) {
    if (_o == null) return default(Offset<SCHALE.Common.FlatData.ScenarioCharacterNameExcel>);
    var _NameKR = _o.NameKR == null ? default(StringOffset) : builder.CreateString(_o.NameKR);
    var _NicknameKR = _o.NicknameKR == null ? default(StringOffset) : builder.CreateString(_o.NicknameKR);
    var _NameJP = _o.NameJP == null ? default(StringOffset) : builder.CreateString(_o.NameJP);
    var _NicknameJP = _o.NicknameJP == null ? default(StringOffset) : builder.CreateString(_o.NicknameJP);
    var _SpinePrefabName = _o.SpinePrefabName == null ? default(StringOffset) : builder.CreateString(_o.SpinePrefabName);
    var _SmallPortrait = _o.SmallPortrait == null ? default(StringOffset) : builder.CreateString(_o.SmallPortrait);
    return CreateScenarioCharacterNameExcel(
      builder,
      _o.CharacterName,
      _o.ProductionStep,
      _NameKR,
      _NicknameKR,
      _NameJP,
      _NicknameJP,
      _o.Shape,
      _SpinePrefabName,
      _SmallPortrait);
  }
}

public class ScenarioCharacterNameExcelT
{
  public uint CharacterName { get; set; }
  public SCHALE.Common.FlatData.ProductionStep ProductionStep { get; set; }
  public string NameKR { get; set; }
  public string NicknameKR { get; set; }
  public string NameJP { get; set; }
  public string NicknameJP { get; set; }
  public SCHALE.Common.FlatData.ScenarioCharacterShapes Shape { get; set; }
  public string SpinePrefabName { get; set; }
  public string SmallPortrait { get; set; }

  public ScenarioCharacterNameExcelT() {
    this.CharacterName = 0;
    this.ProductionStep = SCHALE.Common.FlatData.ProductionStep.ToDo;
    this.NameKR = null;
    this.NicknameKR = null;
    this.NameJP = null;
    this.NicknameJP = null;
    this.Shape = SCHALE.Common.FlatData.ScenarioCharacterShapes.None;
    this.SpinePrefabName = null;
    this.SmallPortrait = null;
  }
}


static public class ScenarioCharacterNameExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*CharacterName*/, 4 /*uint*/, 4, false)
      && verifier.VerifyField(tablePos, 6 /*ProductionStep*/, 4 /*SCHALE.Common.FlatData.ProductionStep*/, 4, false)
      && verifier.VerifyString(tablePos, 8 /*NameKR*/, false)
      && verifier.VerifyString(tablePos, 10 /*NicknameKR*/, false)
      && verifier.VerifyString(tablePos, 12 /*NameJP*/, false)
      && verifier.VerifyString(tablePos, 14 /*NicknameJP*/, false)
      && verifier.VerifyField(tablePos, 16 /*Shape*/, 4 /*SCHALE.Common.FlatData.ScenarioCharacterShapes*/, 4, false)
      && verifier.VerifyString(tablePos, 18 /*SpinePrefabName*/, false)
      && verifier.VerifyString(tablePos, 20 /*SmallPortrait*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
