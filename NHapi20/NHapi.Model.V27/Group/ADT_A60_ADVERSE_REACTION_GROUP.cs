using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using System.Collections.Generic;
using NHapi.Model.V27.Segment;
using NHapi.Model.V27.Datatype;
using NHapi.Base.Model;

namespace NHapi.Model.V27.Group
{
///<summary>
///Represents the ADT_A60_ADVERSE_REACTION_GROUP Group.  A Group is an ordered collection of message 
/// segments that can repeat together or be optionally in/excluded together.
/// This Group contains the following elements: 
///<ol>
///<li>0: IAM (Patient Adverse Reaction Information) </li>
///<li>1: NTE (Notes and Comments) optional repeating</li>
///<li>2: IAR (allergy reaction) optional repeating</li>
///</ol>
///</summary>
[Serializable]
public class ADT_A60_ADVERSE_REACTION_GROUP : AbstractGroup {

	///<summary> 
	/// Creates a new ADT_A60_ADVERSE_REACTION_GROUP Group.
	///</summary>
	public ADT_A60_ADVERSE_REACTION_GROUP(IGroup parent, IModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(IAM), true, false);
	      this.add(typeof(NTE), false, true);
	      this.add(typeof(IAR), false, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating ADT_A60_ADVERSE_REACTION_GROUP - this is probably a bug in the source code generator.", e);
	   }
	}

	///<summary>
	/// Returns IAM (Patient Adverse Reaction Information) - creates it if necessary
	///</summary>
	public IAM IAM { 
get{
	   IAM ret = null;
	   try {
	      ret = (IAM)this.GetStructure("IAM");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns  first repetition of NTE (Notes and Comments) - creates it if necessary
	///</summary>
	public NTE GetNTE() {
	   NTE ret = null;
	   try {
	      ret = (NTE)this.GetStructure("NTE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of NTE
	/// * (Notes and Comments) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public NTE GetNTE(int rep) { 
	   return (NTE)this.GetStructure("NTE", rep);
	}

	/** 
	 * Returns the number of existing repetitions of NTE 
	 */ 
	public int NTERepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("NTE").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/** 
	 * Enumerate over the NTE results 
	 */ 
	public IEnumerable<NTE> NTEs 
	{ 
		get
		{
			for (int rep = 0; rep < NTERepetitionsUsed; rep++)
			{
				yield return (NTE)this.GetStructure("NTE", rep);
			}
		}
	}

	///<summary>
	///Adds a new NTE
	///</summary>
	public NTE AddNTE()
	{
		return this.AddStructure("NTE") as NTE;
	}

	///<summary>
	///Removes the given NTE
	///</summary>
	public void RemoveNTE(NTE toRemove)
	{
		this.RemoveStructure("NTE", toRemove);
	}

	///<summary>
	///Removes the NTE at the given index
	///</summary>
	public void RemoveNTEAt(int index)
	{
		this.RemoveRepetition("NTE", index);
	}

	///<summary>
	/// Returns  first repetition of IAR (allergy reaction) - creates it if necessary
	///</summary>
	public IAR GetIAR() {
	   IAR ret = null;
	   try {
	      ret = (IAR)this.GetStructure("IAR");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of IAR
	/// * (allergy reaction) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public IAR GetIAR(int rep) { 
	   return (IAR)this.GetStructure("IAR", rep);
	}

	/** 
	 * Returns the number of existing repetitions of IAR 
	 */ 
	public int IARRepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("IAR").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/** 
	 * Enumerate over the IAR results 
	 */ 
	public IEnumerable<IAR> IARs 
	{ 
		get
		{
			for (int rep = 0; rep < IARRepetitionsUsed; rep++)
			{
				yield return (IAR)this.GetStructure("IAR", rep);
			}
		}
	}

	///<summary>
	///Adds a new IAR
	///</summary>
	public IAR AddIAR()
	{
		return this.AddStructure("IAR") as IAR;
	}

	///<summary>
	///Removes the given IAR
	///</summary>
	public void RemoveIAR(IAR toRemove)
	{
		this.RemoveStructure("IAR", toRemove);
	}

	///<summary>
	///Removes the IAR at the given index
	///</summary>
	public void RemoveIARAt(int index)
	{
		this.RemoveRepetition("IAR", index);
	}

}
}
