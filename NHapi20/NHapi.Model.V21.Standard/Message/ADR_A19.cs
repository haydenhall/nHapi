using System;
using System.Collections.Generic;
using NHapi.Base.Standard;
using NHapi.Base.Standard.Log;
using NHapi.Base.Standard.Model;
using NHapi.Base.Standard.Parser;
using NHapi.Model.V21.Standard.Group;
using NHapi.Model.V21.Standard.Segment;

namespace NHapi.Model.V21.Standard.Message

{
///<summary>
/// Represents a ADR_A19 message structure (see chapter [AAA]). This structure contains the 
/// following elements:
///<ol>
///<li>0: MSH (MESSAGE HEADER) </li>
///<li>1: MSA (MESSAGE ACKNOWLEDGMENT) </li>
///<li>2: QRD (QUERY DEFINITION) </li>
///<li>3: ADR_A19_QUERY_RESPONSE (a Group object) repeating</li>
///<li>4: DSC (CONTINUATION POINTER) optional </li>
///</ol>
///</summary>
[Serializable]
public class ADR_A19 : AbstractMessage  {

	///<summary> 
	/// Creates a new ADR_A19 Group with custom IModelClassFactory.
	///</summary>
	public ADR_A19(IModelClassFactory factory) : base(factory){
	   init(factory);
	}

	///<summary>
	/// Creates a new ADR_A19 Group with DefaultModelClassFactory. 
	///</summary> 
	public ADR_A19() : base(new DefaultModelClassFactory()) { 
	   init(new DefaultModelClassFactory());
	}

	///<summary>
	/// initalize method for ADR_A19.  This does the segment setup for the message. 
	///</summary> 
	private void init(IModelClassFactory factory) {
	   try {
	      this.add(typeof(MSH), true, false);
	      this.add(typeof(MSA), true, false);
	      this.add(typeof(QRD), true, false);
	      this.add(typeof(ADR_A19_QUERY_RESPONSE), true, true);
	      this.add(typeof(DSC), false, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating ADR_A19 - this is probably a bug in the source code generator.", e);
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

	///<summary>
	/// Returns QRD (QUERY DEFINITION) - creates it if necessary
	///</summary>
	public QRD QRD { 
get{
	   QRD ret = null;
	   try {
	      ret = (QRD)this.GetStructure("QRD");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns  first repetition of ADR_A19_QUERY_RESPONSE (a Group object) - creates it if necessary
	///</summary>
	public ADR_A19_QUERY_RESPONSE GetQUERY_RESPONSE() {
	   ADR_A19_QUERY_RESPONSE ret = null;
	   try {
	      ret = (ADR_A19_QUERY_RESPONSE)this.GetStructure("QUERY_RESPONSE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of ADR_A19_QUERY_RESPONSE
	/// * (a Group object) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public ADR_A19_QUERY_RESPONSE GetQUERY_RESPONSE(int rep) { 
	   return (ADR_A19_QUERY_RESPONSE)this.GetStructure("QUERY_RESPONSE", rep);
	}

	/** 
	 * Returns the number of existing repetitions of ADR_A19_QUERY_RESPONSE 
	 */ 
	public int QUERY_RESPONSERepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("QUERY_RESPONSE").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/** 
	 * Enumerate over the ADR_A19_QUERY_RESPONSE results 
	 */ 
	public IEnumerable<ADR_A19_QUERY_RESPONSE> QUERY_RESPONSEs 
	{ 
		get
		{
			for (int rep = 0; rep < QUERY_RESPONSERepetitionsUsed; rep++)
			{
				yield return (ADR_A19_QUERY_RESPONSE)this.GetStructure("QUERY_RESPONSE", rep);
			}
		}
	}

	///<summary>
	///Adds a new ADR_A19_QUERY_RESPONSE
	///</summary>
	public ADR_A19_QUERY_RESPONSE AddQUERY_RESPONSE()
	{
		return this.AddStructure("QUERY_RESPONSE") as ADR_A19_QUERY_RESPONSE;
	}

	///<summary>
	///Removes the given ADR_A19_QUERY_RESPONSE
	///</summary>
	public void RemoveQUERY_RESPONSE(ADR_A19_QUERY_RESPONSE toRemove)
	{
		this.RemoveStructure("QUERY_RESPONSE", toRemove);
	}

	///<summary>
	///Removes the ADR_A19_QUERY_RESPONSE at the given index
	///</summary>
	public void RemoveQUERY_RESPONSEAt(int index)
	{
		this.RemoveRepetition("QUERY_RESPONSE", index);
	}

	///<summary>
	/// Returns DSC (CONTINUATION POINTER) - creates it if necessary
	///</summary>
	public DSC DSC { 
get{
	   DSC ret = null;
	   try {
	      ret = (DSC)this.GetStructure("DSC");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

}
}
