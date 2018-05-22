/**
 * Autogenerated by Thrift Compiler (1.0.0-dev)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Thrift;
using Thrift.Collections;
using System.Runtime.Serialization;
using Thrift.Protocol;
using Thrift.Transport;

namespace Evernote.EDAM.Error
{

  /// <summary>
  /// This exception is thrown by EDAM procedures when a call fails as a result of
  /// a problem in the service that could not be changed through caller action.
  /// 
  /// errorCode:  The numeric code indicating the type of error that occurred.
  ///   must be one of the values of EDAMErrorCode.
  /// 
  /// message:  This may contain additional information about the error
  /// 
  /// rateLimitDuration:  Indicates the minimum number of seconds that an application should
  ///   expect subsequent API calls for this user to fail. The application should not retry
  ///   API requests for the user until at least this many seconds have passed. Present only
  ///   when errorCode is RATE_LIMIT_REACHED,
  /// </summary>
  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class EDAMSystemException : TException, TBase
  {
    private string _message;
    private int _rateLimitDuration;

    /// <summary>
    /// 
    /// <seealso cref="EDAMErrorCode"/>
    /// </summary>
    public EDAMErrorCode ErrorCode { get; set; }

    public string Message
    {
      get
      {
        return _message;
      }
      set
      {
        __isset.message = true;
        this._message = value;
      }
    }

    public int RateLimitDuration
    {
      get
      {
        return _rateLimitDuration;
      }
      set
      {
        __isset.rateLimitDuration = true;
        this._rateLimitDuration = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool message;
      public bool rateLimitDuration;
    }

    public EDAMSystemException() {
    }

    public EDAMSystemException(EDAMErrorCode errorCode) : this() {
      this.ErrorCode = errorCode;
    }

    public void Read (TProtocol iprot)
    {
      iprot.IncrementRecursionDepth();
      try
      {
        bool isset_errorCode = false;
        TField field;
        iprot.ReadStructBegin();
        while (true)
        {
          field = iprot.ReadFieldBegin();
          if (field.Type == TType.Stop) { 
            break;
          }
          switch (field.ID)
          {
            case 1:
              if (field.Type == TType.I32) {
                ErrorCode = (EDAMErrorCode)iprot.ReadI32();
                isset_errorCode = true;
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 2:
              if (field.Type == TType.String) {
                Message = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 3:
              if (field.Type == TType.I32) {
                RateLimitDuration = iprot.ReadI32();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            default: 
              TProtocolUtil.Skip(iprot, field.Type);
              break;
          }
          iprot.ReadFieldEnd();
        }
        iprot.ReadStructEnd();
        if (!isset_errorCode)
          throw new TProtocolException(TProtocolException.INVALID_DATA, "required field ErrorCode not set");
      }
      finally
      {
        iprot.DecrementRecursionDepth();
      }
    }

    public void Write(TProtocol oprot) {
      oprot.IncrementRecursionDepth();
      try
      {
        TStruct struc = new TStruct("EDAMSystemException");
        oprot.WriteStructBegin(struc);
        TField field = new TField();
        field.Name = "errorCode";
        field.Type = TType.I32;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32((int)ErrorCode);
        oprot.WriteFieldEnd();
        if (Message != null && __isset.message) {
          field.Name = "message";
          field.Type = TType.String;
          field.ID = 2;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(Message);
          oprot.WriteFieldEnd();
        }
        if (__isset.rateLimitDuration) {
          field.Name = "rateLimitDuration";
          field.Type = TType.I32;
          field.ID = 3;
          oprot.WriteFieldBegin(field);
          oprot.WriteI32(RateLimitDuration);
          oprot.WriteFieldEnd();
        }
        oprot.WriteFieldStop();
        oprot.WriteStructEnd();
      }
      finally
      {
        oprot.DecrementRecursionDepth();
      }
    }

    public override string ToString() {
      StringBuilder __sb = new StringBuilder("EDAMSystemException(");
      __sb.Append(", ErrorCode: ");
      __sb.Append(ErrorCode);
      if (Message != null && __isset.message) {
        __sb.Append(", Message: ");
        __sb.Append(Message);
      }
      if (__isset.rateLimitDuration) {
        __sb.Append(", RateLimitDuration: ");
        __sb.Append(RateLimitDuration);
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}
