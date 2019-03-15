using NHapi.Base.Standard.Model;

namespace NHapi.Model.V21.Standard.Datatype
{
/// <summary>/// Summary description for TM.
/// </summary>
public class TM: NHapi.Base.Standard.Model.Primitive.TM
{
/// <summary>Return the version
/// <returns>2.1</returns>
///</summary>

            virtual public System.String Version
            {
			    get
			    {
				    return "2.1";
			    }
		    }
            


                ///<summary>Construct the type
                ///<param name="theMessage">message to which this Type belongs</param>
                ///</summary>
                public TM(IMessage theMessage):base(theMessage)
                {}
                


                ///<summary>Construct the type
                ///<param name="message">message to which this Type belongs</param>
                ///<param name="description">The description of this type</param>
                ///</summary>
		        public TM(IMessage message, string description) : base(message,description)
    	        {}
                }
}
