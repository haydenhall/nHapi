using System;
using NHapi.Base.Standard;
using NHapi.Base.Standard.Log;
using NHapi.Base.Standard.Model;
using NHapi.Base.Standard.Parser;
using NHapi.Model.V21.Standard.Segment;

namespace NHapi.Model.V21.Standard.Message

{
///<summary>
/// Represents a MCF_Q02 message structure (see chapter [AAA]). This structure contains the 
/// following elements:
///<ol>
///<li>0: MSH (MESSAGE HEADER) </li>
///<li>1: MSA (MESSAGE ACKNOWLEDGMENT) </li>
///</ol>
///</summary>
[Serializable]
public class MCF_Q02 : AbstractMessage  {

	///<summary> 
	/// Creates a new MCF_Q02 Group with custom IModelClassFactory.
	///</summary>
	public MCF_Q02(IModelClassFactory factory) : base(factory){
	   init(factory);
	}

	///<summary>
	/// Creates a new MCF_Q02 Group with DefaultModelClassFactory. 
	///</summary> 
	public MCF_Q02() : base(new DefaultModelClassFactory()) { 
	   init(new DefaultModelClassFactory());
	}

	///<summary>
	/// initalize method for MCF_Q02.  This does the segment setup for the message. 
	///</summary> 
	private void init(IModelClassFactory factory) {
	   try {
	      this.add(typeof(MSH), true, false);
	      this.add(typeof(MSA), true, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating MCF_Q02 - this is probably a bug in the source code generator.", e);
	   }
	}


	public override string Version
		{
			get{
			return Constants.VERSION;
			}
		}
	///<summary>
	/// Returns MSH (MESSAGE HEADER) - creates it if necessary
	///</summary>
	public MSH MSH { 
get{
	   MSH ret = null;
	   try {
	      ret = (MSH)this.GetStructure("MSH");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns MSA (MESSAGE ACKNOWLEDGMENT) - creates it if necessary
	///</summary>
	public MSA MSA { 
get{
	   MSA ret = null;
	   try {
	      ret = (MSA)this.GetStructure("MSA");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

}
}
