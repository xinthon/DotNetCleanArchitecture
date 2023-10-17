namespace Web.API.Exceptions
{
    public class ResourceNotFundException : Exception
    {
        public ResourceNotFundException(Guid Id) : base($"The resource with the identity {Id} was not fund.")
        {
            
        }
    }
}
