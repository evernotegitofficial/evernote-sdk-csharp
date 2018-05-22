/**
 * Autogenerated by Thrift Compiler (1.0.0-dev)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */

namespace Evernote.EDAM.Type
{
  /// <summary>
  /// An enumeration describing restrictions on the domain of shared notebook
  /// instances that are valid for a given operation, as used, for example, in
  /// NotebookRestrictions.
  /// 
  /// ASSIGNED: The domain consists of shared notebooks that belong, or are assigned,
  /// to the recipient.
  /// 
  /// NO_SHARED_NOTEBOOKS: No shared notebooks are applicable to the operation.
  /// </summary>
  public enum SharedNotebookInstanceRestrictions
  {
    ASSIGNED = 1,
    NO_SHARED_NOTEBOOKS = 2,
  }
}
