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
/// Represents a BAR_P01 message structure (see chapter [AAA]). This structure contains the 
/// following elements:
///<ol>
///<li>0: MSH (MESSAGE HEADER) </li>
///<li>1: EVN (EVENT TYPE) </li>
///<li>2: PID (PATIENT IDENTIFICATION) </li>
///<li>3: BAR_P01_VISIT (a Group object) repeating</li>
///</ol>
///</summary>
[Serializable]
public class BAR_P01 : AbstractMessage  {

	///<summary> 
	/// Creates a new BAR_P01 Group with custom IModelClassFactory.
	///</summary>
	public BAR_P01(IModelClassFactory factory) : base(factory){
	   init(factory);
	}

	///<summary>
	/// Creates a new BAR_P01 Group with DefaultModelClassFactory. 
	///</summary> 
	public BAR_P01() : base(new DefaultModelClassFactory()) { 
	   init(new DefaultModelClassFactory());
	}

	///<summary>
	/// initalize method for BAR_P01.  This does the segment setup for the message. 
	///</summary> 
	private void init(IModelClassFactory factory) {
	   try {
	      this.add(typeof(MSH), true, false);
	      this.add(typeof(EVN), true, false);
	      this.add(typeof(PID), true, false);
	      this.add(typeof(BAR_P01_VISIT), true, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating BAR_P01 - this is probably a bug in the source code generator.", e);
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
	/// Returns PID (PATIENT IDENTIFICATION) - creates it if necessary
	///</summary>
	public PID PID { 
get{
	   PID ret = null;
	   try {
	      ret = (PID)this.GetStructure("PID");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns  first repetition of BAR_P01_VISIT (a Group object) - creates it if necessary
	///</summary>
	public BAR_P01_VISIT GetVISIT() {
	   BAR_P01_VISIT ret = null;
	   try {
	      ret = (BAR_P01_VISIT)this.GetStructure("VISIT");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of BAR_P01_VISIT
	/// * (a Group object) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public BAR_P01_VISIT GetVISIT(int rep) { 
	   return (BAR_P01_VISIT)this.GetStructure("VISIT", rep);
	}

	/** 
	 * Returns the number of existing repetitions of BAR_P01_VISIT 
	 */ 
	public int VISITRepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("VISIT").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/** 
	 * Enumerate over the BAR_P01_VISIT results 
	 */ 
	public IEnumerable<BAR_P01_VISIT> VISITs 
	{ 
		get
		{
			for (int rep = 0; rep < VISITRepetitionsUsed; rep++)
			{
				yield return (BAR_P01_VISIT)this.GetStructure("VISIT", rep);
			}
		}
	}

	///<summary>
	///Adds a new BAR_P01_VISIT
	///</summary>
	public BAR_P01_VISIT AddVISIT()
	{
		return this.AddStructure("VISIT") as BAR_P01_VISIT;
	}

	///<summary>
	///Removes the given BAR_P01_VISIT
	///</summary>
	public void RemoveVISIT(BAR_P01_VISIT toRemove)
	{
		this.RemoveStructure("VISIT", toRemove);
	}

	///<summary>
	///Removes the BAR_P01_VISIT at the given index
	///</summary>
	public void RemoveVISITAt(int index)
	{
		this.RemoveRepetition("VISIT", index);
	}

}
}
