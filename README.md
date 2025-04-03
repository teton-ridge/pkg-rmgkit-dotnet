# RMGKit .NET Library

This repository contains the RMGKit .NET library, which is published as a NuGet package to GitHub Packages.

## Using the Package

To use this package in your .NET projects, follow these steps:

### 1. Authenticate with GitHub Packages

Create a `NuGet.config` file in your project root directory:

```xml
<?xml version="1.0" encoding="utf-8"?>
<configuration>
  <packageSources>
    <clear />
    <add key="nuget.org" value="https://api.nuget.org/v3/index.json" />
    <add key="github" value="https://nuget.pkg.github.com/teton-ridge/index.json" />
  </packageSources>
  <packageSourceCredentials>
    <github>
      <add key="Username" value="YOUR_GITHUB_USERNAME" />
      <add key="ClearTextPassword" value="YOUR_GITHUB_PAT" />
    </github>
  </packageSourceCredentials>
</configuration>
```

Replace `YOUR_GITHUB_USERNAME` with your GitHub username and `YOUR_GITHUB_PAT` with a GitHub Personal Access Token that has the `read:packages` scope.

### 2. Add the package reference

Add the package reference to your project file:

```xml
<ItemGroup>
  <PackageReference Include="TCC.RMGKit" Version="1.0.0" />
</ItemGroup>
```

Or install it using the .NET CLI:

```bash
dotnet add package TCC.RMGKit --version 1.0.0
```

### 3. Use the Library

```csharp
using RMGKit;
using RMGKit.Models;

// Use the library classes and methods
```

## Development

### Git Configuration for Tag Management
This repository uses CI/CD to manage tags. Developers should **never manually push or pull tags**.

To prevent accidental tag handling, run this setup script in your local repository:

```bash
./setup-git-config.sh
```

After running this script, you can use Git normally:
- `git push` will work without needing any extra flags
- `git pull` will work without needing any extra flags

The script configures Git to:
1. Never fetch tags automatically
2. Never push tags automatically
3. Create Git aliases that make the standard `git push` and `git pull` commands always use `--no-tags`

For a permanent global solution (affects all repositories), you can run:
```bash
git config --global push.followTags false
git config --global fetch.tags false
git config --global alias.push 'push --no-tags'
git config --global alias.pull 'pull --no-tags'
```

### Building the Package Locally

```bash
dotnet build RMGKit/RMGKit.csproj
```

### Package Versioning Strategy

The package follows this versioning strategy:

1. **Pre-release packages** are published automatically when a PR is created or updated.
   - Format: `1.0.0-pr{PR_NUMBER}-{SHORT_SHA}`
   - Example: `1.0.0-pr42-a1b2c3d`
   - These packages are ideal for testing changes before merging to main.

2. **Release packages** are published automatically when changes are merged to the main branch.
   - Format: `{MAJOR}.{MINOR}.{PATCH}` (SemVer)
   - The patch version is automatically incremented based on the latest Git tag.
   - A new Git tag is created for each release.

### Manual Release

If you need to publish a new release without making changes to the codebase, you can use the "Manual Release" workflow:

1. Go to the "Actions" tab in the GitHub repository
2. Select the "Manual Release" workflow
3. Click "Run workflow" on the main branch
4. This will create a new release with an incremented patch version

This is useful for re-publishing the package or creating a new release after fixing workflow issues. 