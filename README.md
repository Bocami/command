Command
=======

Commands can be used to change the state of the Domain Model. Commands are marked with ICommand and are handled by implementations of ICommandHandler.

## Install

```
Install-Package Bocami.Practices.Command -Source https://www.myget.org/F/bocami/
```

## Usage

Register User Command

```csharp
public class RegisterUserCommand : ICommand
{
  public Guid UserId { get; set;}
  public string UserName { get; set;}
}
```

Register User Command Handler
```csharp
public class RegisterUserCommandHandler : ICommandHandler<RegisterUserCommand>
{
  private readonly IUserRepository userRepository;
  
  public RegisterUserCommandHandler(IUserRepository userRepository)
  {
    if (userRepository == null)
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
