using System;
using NHapi.Base.Standard.Model;
using NHapi.Base.Standard.Parser;

namespace NHapi.Model.V21.Standard.Segment{

///<summary>
/// Represents an HL7 IN3 message segment. 
/// This segment has the following fields:<ol>
///</ol>
/// The get...() methods return data from individual fields.  These methods 
/// do not throw exceptions and may therefore have to handle exceptions internally.  
/// If an exception is handled internally, it is logged and null is returned.  
/// This is not expected to happen - if it does happen this indicates not so much 
/// an exceptional circumstance as a bug in the code for this class.
///</summary>
[Serializable]
public class IN3 : AbstractSegment  {

  /**
   * Creates a IN3 () segment object that belongs to the given 
   * message.  
   */
	public IN3(IGroup parent, IModelClassFactory factory) : base(parent,factory) {
	IMessage message = Message;
  }


}}