# Model Context Protocol (MCP) Server Example

This repository demonstrates how to effectively use the Model Context Protocol (MCP) with GitHub Copilot in a C# .NET 10 project. It showcases various development scenarios and how MCP enhances the development workflow.

## What is MCP?

Model Context Protocol (MCP) enables GitHub Copilot to understand and interact with your workspace context, making it more effective at:

- Understanding your project structure
- Making code changes across multiple files
- Managing GitHub issues and pull requests
- Handling build processes

## Project Details

- **Framework**: .NET 10
- **Language**: C# 14
- **Features**: 
  - Simple calculator with four basic operations
  - Comprehensive XML documentation
  - Modern C# patterns (expression-bodied members, file-scoped types, sealed classes)
  - Proper error handling and validation

## Quick Start

1. Ensure you have .NET 10 SDK installed
2. Clone the repository
3. Run the application:

```bash
dotnet run
```

## MCP Integration

1. Install the VS Code MCP extension
2. Create `.vscode/mcp.json` in your project:

```json
{
    "inputs": [],
    "servers": {
        "github": {
            "type": "http",
            "url": "https://api.githubcopilot.com/mcp"
        }
    }
}
```

## Development Scenarios

Here are practical examples of using MCP with GitHub Copilot:

### 1. Feature Implementation

```plaintext
User: "Could you help implement a calculator feature that can add two numbers?"

Copilot: "I'll help you implement the calculator feature. I'll:
1. Create a Calculator class
2. Update the Program.cs to use the calculator
3. Add proper error handling
4. Add XML documentation"
```

### 2. Code Review and Improvements

```plaintext
User: "Can you review my Calculator class implementation?"

Copilot: "I'll review your code for:
- Best practices
- Potential bugs
- Performance improvements
- Better error handling
- Documentation completeness"
```

### 3. Error Handling

```plaintext
User: "Could you improve error handling in the Calculator class?"

Copilot: "I'll:
1. Add input validation
2. Implement proper exception handling
3. Add meaningful error messages
4. Document error scenarios"
```

### 4. Documentation Updates

```plaintext
User: "Please update the XML documentation for the Calculator class"

Copilot: "I'll add comprehensive XML documentation including:
- Class description
- Method documentation
- Parameter descriptions
- Example usage
- Exception documentation"
```

### 5. Issue Management

```plaintext
User: "Create an issue for implementing multiplication feature"

Copilot: "I'll create a detailed issue with:
- Clear title
- Feature description
- Acceptance criteria
- Implementation suggestions"
```

### 6. Pull Request Workflow

```plaintext
User: "Create a PR for the calculator feature"

Copilot: "I'll:
1. Create a new branch
2. Commit the changes
3. Create a pull request with:
   - Description of changes
   - Related issue reference
   - Test results"
```

## Project Structure

```plaintext
├── Calculator.cs         # Core calculator implementation with four operations
├── Program.cs            # Console application entry point
├── MCP101.csproj         # Project file targeting .NET 10
├── global.json           # SDK version specification
├── .editorconfig         # Code style and formatting rules
├── .gitignore            # Git ignore patterns
└── .vscode/
    └── mcp.json          # MCP configuration
```

## Modern C# Features Used

This project demonstrates modern C# 14 and .NET 10 best practices:

- **File-scoped types**: Using `file sealed class` for Program
- **Expression-bodied members**: Concise method implementations
- **Target-typed new expressions**: `Calculator calculator = new();`
- **Sealed classes**: Preventing unnecessary inheritance
- **Nullable reference types**: Enabled for better null safety
- **Comprehensive XML documentation**: Including `<example>` and `<code>` blocks
- **Modern error handling**: DivideByZeroException with clear messages

## Best Practices

1. **Issue-First Development**
   - Create detailed issues before implementation
   - Use clear descriptions and acceptance criteria

2. **Error Handling**
   - Validate inputs before processing
   - Use appropriate exception types
   - Provide clear, actionable error messages
   - Handle division by zero explicitly

3. **Documentation**
   - Keep README updated with current framework version
   - Use XML documentation for all public APIs
   - Include usage examples in documentation
   - Add `<example>` blocks with sample code

4. **Code Quality**
   - Enable `TreatWarningsAsErrors` for strict compilation
   - Use `.editorconfig` for consistent code style
   - Seal classes when inheritance isn't needed
   - Use expression-bodied members for simple methods

5. **Version Control**
   - Use meaningful commit messages
   - Create feature branches
   - Review code before merging
   - Keep `.gitignore` up to date

## Resources

- [.NET 10 Documentation](https://learn.microsoft.com/en-us/dotnet/)
- [C# 14 What's New](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-14)
- [MCP Documentation](https://github.com/microsoft/vscode-mcp)
- [GitHub Copilot](https://github.com/features/copilot)
- [C# Coding Conventions](https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/coding-conventions)
- [C# Exception Handling Best Practices](https://docs.microsoft.com/en-us/dotnet/standard/exceptions/best-practices-for-exceptions)
- [EditorConfig Documentation](https://editorconfig.org/)

## 📄 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
