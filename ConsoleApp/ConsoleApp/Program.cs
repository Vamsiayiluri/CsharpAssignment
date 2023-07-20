using BusinessModels;

namespace ConsoleApp
{
    /// <summary>
    /// This class will call the signup,login,forgot password methods on their approprite call infinite times unless user breaks the loop.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// The enum stores what are the inputs to be given
        /// </summary>
        public enum Input
        {
            Signup = 1,
            Login = 2,
            ForgotPassword = 3,
            Exit = 4
        }
        /// <summary>
        /// The main method will create objects and validate the input and call the appropriate login,signup,forgot password methods
        /// </summary>
        public static void Main()
        {
            while (true)
            {
                InputOutput inputOutput = new InputOutput();
                inputOutput.Display(Literals.selectInput);

                string input = inputOutput.ReadInput();

                Authentication authObj = new Authentication();
                authObj = new Authentication();
                if (Enum.TryParse<Input>(input, out var inputValue))
                {
                    switch (inputValue)
                    {
                        case Input.Signup:
                            authObj.Signup();
                            break;
                        case Input.Login:
                            authObj.Login();
                            break;
                        case Input.ForgotPassword:
                            authObj.ForgotPassword();
                            break;
                        case Input.Exit:
                            authObj.Exit();
                            break;
                        default:
                            inputOutput.Display(Literals.validOption);
                            break;
                    }
                }
            }
        }
    }
}
