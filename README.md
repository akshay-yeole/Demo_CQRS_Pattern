# Demo_CQRS_Pattern

## Configure MediatR

1. Add the MediatR package to your project:

    ```sh
    Install-Package MediatR
    ```

2. Next, open the `Program.cs` file and add the MediatR service. Use the following code:

    ```csharp
    builder.Services.AddMediatR(config => config.RegisterServicesFromAssemblies(typeof(Program).Assembly));
    ```

## Enable Behavior in application
```builder.Services.AddSingleton(typeof(IPipelineBehavior<,>), typeof(LoggingBehaviour<,>));
```