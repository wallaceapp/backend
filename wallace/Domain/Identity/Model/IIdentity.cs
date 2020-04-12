using Wallace.Domain.Identity.Enums;

namespace Wallace.Domain.Identity.Model
{
    /// <summary>
    /// Represents an identity, so far only an user or an unknown (not signed in)
    /// person.
    /// </summary>
    public interface IIdentity
    {
        int Id { get; }
        IdentityType Type { get; }
    }
}