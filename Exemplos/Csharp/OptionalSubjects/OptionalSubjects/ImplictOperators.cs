namespace OptionalSubjects; 

public class ImplictOperators {

    static void Main(string[] args) {
        var requestModel = new NewUserRequestModel {
            Username = "admin",
            Password = "password",
            Email = "email@gmail.com",
            Phone = "2"
        };

        User userToSaveFromForm = requestModel;
        string viewUser = (UserViewModel) userToSaveFromForm;
        Console.WriteLine( viewUser );
            
    }

}
