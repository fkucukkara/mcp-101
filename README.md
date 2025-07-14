# Model Context Protocol (MCP) Server Example

This repository demonstrates how to effectively use the Model Context Protocol (MCP) with GitHub Copilot in a C# project. It showcases various development scenarios and how MCP enhances the development workflow.

## What is MCP?

Model Context Protocol (MCP) enables GitHub Copilot to understand and interact with your workspace context, making it more effective at:

- Understanding your project structure
- Making code changes across multiple files
- Managing GitHub issues and pull requests
- Handling build processes

## Quick Start

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
├── Calculator.cs      # Core calculator implementation
├── Program.cs        # Console application entry point
└── .vscode/
    └── mcp.json     # MCP configuration
```

## Best Practices

1. **Issue-First Development**
   - Create detailed issues before implementation
   - Use clear descriptions and acceptance criteria

2. **Error Handling**
   - Validate inputs
   - Use appropriate exception types
   - Provide clear error messages

3. **Documentation**
   - Keep README updated
   - Use XML documentation for public APIs
   - Include usage examples

4. **Version Control**
   - Use meaningful commit messages
   - Create feature branches
   - Review code before merging

## Resources

- [MCP Documentation](https://github.com/microsoft/vscode-mcp)
- [GitHub Copilot](https://github.com/features/copilot)
- [C# Coding Conventions](https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/coding-conventions)
- [C# Exception Handling Best Practices](https://docs.microsoft.com/en-us/dotnet/standard/exceptions/best-practices-for-exceptions)

## 📄 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
