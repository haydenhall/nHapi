using NHapi.Base.Standard.Model;

namespace NHapi.Model.V21.Standard.Datatype
{
    /// <summary>
    /// Composite message
    /// </summary>
    public class CM : GenericComposite
    {

        /// <summary>
        /// Composite message
        /// </summary>
        /// <param name="message"></param>
        public CM(IMessage message)
            : base(message)
        {
        }
    }
}
