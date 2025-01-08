
# ModuleApplication

**ModuleApplication** is an ASP.NET application designed to support the modularization of applications into smaller, independent modules. Each module represents a specific functionality and can be developed, deployed separately, or combined to form a larger system.

## Purpose

- **Decoupled Logic**: Organize and manage application functionalities into independent modules.
- **Reusability**: Modules can be reused across different projects or deployed independently.
- **Scalability**: Easily add or remove modules without affecting the entire application.
- **Optimized Application Management**: Each module can be developed and maintained by different teams.

## Project Structure
```
ModuleApplication/
│
├── ModuleApplication/          # Main project
│   └── Controllers/            # (Optional)
│       └── ...                 
│   └── Startup.cs              # Application initialization and module registration
│   └── Program.cs              # Entry point of the application
│
├── Modules/                    # Folder containing sub-modules
│   ├── OrderManagementModule/  # Sub-module managing order-related logic
│   │   └── Controllers/
│   │   └── Services/
│   │   └── Models/
│   │   └── OrderManagementModule.csproj
│   │
│   ├── UserManagementModule/   # Sub-module managing user-related logic
│       └── Controllers/
│       └── Services/
│       └── Models/
│       └── UserManagementModule.csproj
│
├── ShareModuleCore/            # Core library for module loading
│   └── ModuleLoader.cs         # Logic to load modules
│   └── Extensions/
│   └── ShareModuleCore.csproj
│
└── ModuleApplication.sln       # Solution file
```

## Key Features

1. **Automatic Module Loading**:
   - The application uses the `ShareModuleCore` library to automatically scan and load assemblies of sub-modules within the `Modules` folder.

2. **Isolated Logic**:
   - Each module functions as an independent application with its own controllers, services, and models.

3. **Flexible Integration**:
   - Modules can be combined or deployed individually depending on project requirements.

4. **Expandable Design**:
   - Adding a new module only requires placing it in the `Modules` folder and restarting the application.

## Usage Guide

### Prerequisites

- .NET 6.0 or later
- IDE: Visual Studio or Visual Studio Code

### How to Run

1. Clone the repository:
   ```bash
   git clone https://github.com/phamvietdung/ModuleApplication.git
   ```
2. Open the `ModuleApplication.sln` file in Visual Studio.
3. Set `ModuleApplication` as the startup project.
4. Build and run the application:
   ```bash
   dotnet run --project ModuleApplication
   ```
5. The application will automatically load sub-modules from the `Modules` directory.

