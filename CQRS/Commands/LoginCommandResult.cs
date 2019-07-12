namespace CQRS.Commands
{
    public class LoginCommandResult
    {
        public string UserName { get; set; } = "Ravindra Saxena";
        public bool IsSuccess { get; set; } = true;

        public string Result { get; set; } = "Login was successful";
    }
}