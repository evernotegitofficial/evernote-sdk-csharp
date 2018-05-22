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

namespace Evernote.EDAM.Type
{

  /// <summary>
  /// This structure captures information about the operations that cannot be performed on a given
  /// note that has been shared with a recipient via a SharedNote. The following operations are
  /// <b>never</b> allowed based on SharedNotes, and as such are left out of the NoteRestrictions
  /// structure for brevity:
  /// 
  /// <ul>
  ///   <li>Expunging a note (NoteStore.expungeNote)</li>
  ///   <li>Moving a note to the trash (Note.active)</li>
  ///   <li>Updating a note's notebook (Note.notebookGuid)</li>
  ///   <li>Updating a note's tags (Note.tagGuids, Note.tagNames)</li>
  ///   <li>Updating a note's attributes (Note.attributes)</li>
  ///   <li>Sharing a note with the business (NoteStore.shareNoteWithBusiness</li>
  ///   <li>Getting a note's version history (NoteStore.listNoteVersions,
  ///     NoteStore.getNoteVersion)</li>
  /// </ul>
  /// 
  /// When a client has permission to update a note's title or content, it may also update the
  /// Note.updated timestamp.
  /// 
  /// <b>This structure reflects only the privileges / restrictions conveyed by the SharedNote.</b>
  /// It does not incorporate privileges conveyed by a potential SharedNotebook to the same
  /// recipient. As such, the actual permissions that the recipient has on the note may differ from
  /// the permissions expressed in this structure.
  /// 
  /// For example, consider a user with read-only access to a shared notebook, and a read-write share
  /// of a specific note in the notebook. The note restrictions would contain noUpdateTitle = false,
  /// while the notebook restrictions would contain noUpdateNotes = true. In this case, the user is
  /// allowed to update the note title based on the note restrictions.
  /// 
  /// Alternatively, consider a user with read-write access to a shared notebook, and a read-only
  /// share of a specific note in that notebook. The note restrictions would contain
  /// noUpdateTitle = true, while the notebook restrictions would contain noUpdateNotes = false. In
  /// this case, the user would have full edit permissions on the note based on the notebook
  /// restrictions.
  /// 
  /// <dl>
  ///   <dt>noUpdateTitle</dt>
  ///   <dd>The client may not update the note's title (Note.title).</dd>
  /// 
  ///   <dt>noUpdateContent<dt>
  ///   <dd>The client may not update the note's content. Content includes Note.content
  ///     and Note.resources, as well as the related fields Note.contentHash and
  ///     Note.contentLength.</dd>
  /// 
  ///   <dt>noEmail</dt>
  ///   <dd>The client may not email the note (NoteStore.emailNote).</dd>
  /// 
  ///   <dt>noShare</dt>
  ///   <dd>The client may not share the note with specific recipients
  ///     (NoteStore.createOrUpdateSharedNotes).</dd>
  /// 
  ///   <dt>noSharePublicly</dt>
  ///   <dd>The client may not make the note public (NoteStore.shareNote).</dd>
  /// </dl>
  /// </summary>
  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class NoteRestrictions : TBase
  {
    private bool _noUpdateTitle;
    private bool _noUpdateContent;
    private bool _noEmail;
    private bool _noShare;
    private bool _noSharePublicly;

    public bool NoUpdateTitle
    {
      get
      {
        return _noUpdateTitle;
      }
      set
      {
        __isset.noUpdateTitle = true;
        this._noUpdateTitle = value;
      }
    }

    public bool NoUpdateContent
    {
      get
      {
        return _noUpdateContent;
      }
      set
      {
        __isset.noUpdateContent = true;
        this._noUpdateContent = value;
      }
    }

    public bool NoEmail
    {
      get
      {
        return _noEmail;
      }
      set
      {
        __isset.noEmail = true;
        this._noEmail = value;
      }
    }

    public bool NoShare
    {
      get
      {
        return _noShare;
      }
      set
      {
        __isset.noShare = true;
        this._noShare = value;
      }
    }

    public bool NoSharePublicly
    {
      get
      {
        return _noSharePublicly;
      }
      set
      {
        __isset.noSharePublicly = true;
        this._noSharePublicly = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool noUpdateTitle;
      public bool noUpdateContent;
      public bool noEmail;
      public bool noShare;
      public bool noSharePublicly;
    }

    public NoteRestrictions() {
    }

    public void Read (TProtocol iprot)
    {
      iprot.IncrementRecursionDepth();
      try
      {
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
              if (field.Type == TType.Bool) {
                NoUpdateTitle = iprot.ReadBool();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 2:
              if (field.Type == TType.Bool) {
                NoUpdateContent = iprot.ReadBool();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 3:
              if (field.Type == TType.Bool) {
                NoEmail = iprot.ReadBool();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 4:
              if (field.Type == TType.Bool) {
                NoShare = iprot.ReadBool();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 5:
              if (field.Type == TType.Bool) {
                NoSharePublicly = iprot.ReadBool();
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
        TStruct struc = new TStruct("NoteRestrictions");
        oprot.WriteStructBegin(struc);
        TField field = new TField();
        if (__isset.noUpdateTitle) {
          field.Name = "noUpdateTitle";
          field.Type = TType.Bool;
          field.ID = 1;
          oprot.WriteFieldBegin(field);
          oprot.WriteBool(NoUpdateTitle);
          oprot.WriteFieldEnd();
        }
        if (__isset.noUpdateContent) {
          field.Name = "noUpdateContent";
          field.Type = TType.Bool;
          field.ID = 2;
          oprot.WriteFieldBegin(field);
          oprot.WriteBool(NoUpdateContent);
          oprot.WriteFieldEnd();
        }
        if (__isset.noEmail) {
          field.Name = "noEmail";
          field.Type = TType.Bool;
          field.ID = 3;
          oprot.WriteFieldBegin(field);
          oprot.WriteBool(NoEmail);
          oprot.WriteFieldEnd();
        }
        if (__isset.noShare) {
          field.Name = "noShare";
          field.Type = TType.Bool;
          field.ID = 4;
          oprot.WriteFieldBegin(field);
          oprot.WriteBool(NoShare);
          oprot.WriteFieldEnd();
        }
        if (__isset.noSharePublicly) {
          field.Name = "noSharePublicly";
          field.Type = TType.Bool;
          field.ID = 5;
          oprot.WriteFieldBegin(field);
          oprot.WriteBool(NoSharePublicly);
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
      StringBuilder __sb = new StringBuilder("NoteRestrictions(");
      bool __first = true;
      if (__isset.noUpdateTitle) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("NoUpdateTitle: ");
        __sb.Append(NoUpdateTitle);
      }
      if (__isset.noUpdateContent) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("NoUpdateContent: ");
        __sb.Append(NoUpdateContent);
      }
      if (__isset.noEmail) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("NoEmail: ");
        __sb.Append(NoEmail);
      }
      if (__isset.noShare) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("NoShare: ");
        __sb.Append(NoShare);
      }
      if (__isset.noSharePublicly) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("NoSharePublicly: ");
        __sb.Append(NoSharePublicly);
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}
