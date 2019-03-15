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
/// Represents a BAR_P02 message structure (see chapter [AAA]). This structure contains the 
/// following elements:
///<ol>
///<li>0: MSH (MESSAGE HEADER) </li>
///<li>1: EVN (EVENT TYPE) </li>
///<li>2: BAR_P02_PATIENT (a Group object) repeating</li>
///</ol>
///</summary>
[Serializable]
public class BAR_P02 : AbstractMessage  {

	///<summary> 
	/// Creates a new BAR_P02 Group with custom IModelClassFactory.
	///</summary>
	public BAR_P02(IModelClassFactory factory) : base(factory){
	   init(factory);
	}

	///<summary>
	/// Creates a new BAR_P02 Group with DefaultModelClassFactory. 
	///</summary> 
	public BAR_P02() : base(new DefaultModelClassFactory()) { 
	   init(new DefaultModelClassFactory());
	}

	///<summary>
	/// initalize method for BAR_P02.  This does the segment setup for the message. 
	///</summary> 
	private void init(IModelClassFactory factory) {
	   try {
	      this.add(typeof(MSH), true, false);
	      this.add(typeof(EVN), true, false);
	      this.add(typeof(BAR_P02_PATIENT), true, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating BAR_P02 - this is probably a bug in the source code generator.", e);
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
	/// Returns EVN (EVENT TYPE) - creates it if necessary
	///</summary>
	public EVN EVN { 
get{
	   EVN ret = null;
	   try {
	      ret = (EVN)this.GetStructure("EVN");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns  first repetition of BAR_P02_PATIENT (a Group object) - creates it if necessary
	///</summary>
	public BAR_P02_PATIENT GetPATIENT() {
	   BAR_P02_PATIENT ret = null;
	   try {
	      ret = (BAR_P02_PATIENT)this.GetStructure("PATIENT");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of BAR_P02_PATIENT
	/// * (a Group object) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public BAR_P02_PATIENT GetPATIENT(int rep) { 
	   return (BAR_P02_PATIENT)this.GetStructure("PATIENT", rep);
	}

	/** 
	 * Returns the number of existing repetitions of BAR_P02_PATIENT 
	 */ 
	public int PATIENTRepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("PATIENT").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/** 
	 * Enumerate over the BAR_P02_PATIENT results 
	 */ 
	public IEnumerable<BAR_P02_PATIENT> PATIENTs 
	{ 
		get
		{
			for (int rep = 0; rep < PATIENTRepetitionsUsed; rep++)
			{
				yield return (BAR_P02_PATIENT)this.GetStructure("PATIENT", rep);
			}
		}
	}

	///<summary>
	///Adds a new BAR_P02_PATIENT
	///</summary>
	public BAR_P02_PATIENT AddPATIENT()
	{
		return this.AddStructure("PATIENT") as BAR_P02_PATIENT;
	}

	///<summary>
	///Removes the given BAR_P02_PATIENT
	///</summary>
	public void RemovePATIENT(BAR_P02_PATIENT toRemove)
	{
		this.RemoveStructure("PATIENT", toRemove);
	}

	///<summary>
	///Removes the BAR_P02_PATIENT at the given index
	///</summary>
	public void RemovePATIENTAt(int index)
	{
		this.RemoveRepetition("PATIENT", index);
	}

}
}
