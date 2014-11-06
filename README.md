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

## Licence
The MIT License (MIT)

Copyright (c) 2014 Jonatan Pedersen http://www.jonatanpedersen.com

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.
