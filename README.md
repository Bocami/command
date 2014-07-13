Command
=======
Commands are used to change the state of the domain.

```csharp
public class RegisterUserCommand : ICommand
{
  public Guid UserId { get; set;}
  public string UserName { get; set;}
}

```

```csharp
public class RegisterUserCommandHandler : ICommandHandler<RegisterUserCommand>
{
  private readonly IUserRepository userRepository;
  
  public RegisterUserCommandHandler(IUserNameRepository userRepository)
  {
    if(userRepository == null)
      throw new ArgumentNullException("userRepository");
      
    this.userRepository = userRepository;
  }
  
  public void Handle(RegisterUserCommand command) 
  {
    var user = userRepository.Find(command.UserId);
    
    user.Register(command.UserName);
  }
}

```
