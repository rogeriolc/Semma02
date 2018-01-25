
namespace Semma02.Membership
{
    using Serenity.ComponentModel;
    using Serenity.Services;

    [FormScript("Membership.Login")]
    [BasedOnRow(typeof(Administration.Entities.UserRow))]
    public class LoginRequest : ServiceRequest
    {
        [Placeholder("Login")]
        public string Username { get; set; }
        [PasswordEditor, Placeholder("Senha"), Required(true)]
        public string Password { get; set; }
    }
}