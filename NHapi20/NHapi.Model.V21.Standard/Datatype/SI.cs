using System;
using NHapi.Base.Standard.Model;

namespace NHapi.Model.V21.Standard.Datatype
{
///<summary>
///Represents the HL7 SI (SET ID) datatype.  A SI contains a single String value.
///</summary>
[Serializable]
public class SI : AbstractPrimitive  {

	///<summary>
	///Constructs an uninitialized SI.
	///<param name="message">The Message to which this Type belongs</param>
	///</summary>
	public SI(IMessage message) : base(message){
	}

	///<summary>
	///Constructs an uninitialized SI.
	///<param name="message">The Message to which this Type belongs</param>
	///<param name="description">The description of this type</param>
	///</summary>
	public SI(IMessage message, string description) : base(message,description){
	}

	///<summary>
	///  @return "2.1"
	///</summary>
	public string getVersion() {
	    return "2.1";
}
}
}