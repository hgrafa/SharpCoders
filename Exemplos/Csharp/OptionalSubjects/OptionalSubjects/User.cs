namespace OptionalSubjects; 

public class User {
    public string Username { get; set; }
    public string Password { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public bool IsActive { get; set; }
    public bool IsAuthorized { get; set; }

    public static implicit operator UserViewModel(User user) {
        return new UserViewModel {
            Username = user.Username,
            Email = user.Email,
            Phone = user.Phone
        };
    }
}

// view models em c# ou DTO's em c# ou DTO's pattern

public class UserViewModel {
    public string Username { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }

    public static implicit operator string(UserViewModel viewModel) {
        return $"Username: {viewModel.Username}, Phone: {viewModel.Phone}, Email: {viewModel.Email}";
    }
}

public class NewUserRequestModel {
    public string Username { get; set; }
    public string Password { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }

    public static implicit operator User(NewUserRequestModel requestModel) {
        return new User {
            Username = requestModel.Username,
            Password = requestModel.Password,
            Email = requestModel.Email,
            Phone = requestModel.Phone,
            IsActive = true,
            IsAuthorized = true
        };
    }
}

public class UserService {
    
    // ... 

    public void RegisterUser(NewUserRequestModel requestModel) {
        User toRegister = ToUser(requestModel);
    }

    public User ToUser(NewUserRequestModel requestModel) {
        return new User {
            Username = requestModel.Username,
            Password = requestModel.Password,
            Email = requestModel.Email,
            Phone = requestModel.Phone,
            IsActive = true,
            IsAuthorized = true
        };
    }
}