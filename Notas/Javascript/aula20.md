# Camadas backend

> `www.csharks.imapay.com.gov.us.br/users?active=true`

```cs
// [ApiController]
// [Route("users")]
public class UserController {

  // [HttpGet]
  public async Task<ActionResult<Lista<User>>> GetAllUsers(bool? active = null) {
    return  await _userService.GetAllUsers();
  }

}

public class UserService {

  public async Task<ActionResult<Lista<User>>> GetAllUsers(bool? active) {
    var users = await _userRepository.FindAll();

    if(active != null) {
      users = users.Where(u => u.active == active)
    }

    return users;
  }

}
```
