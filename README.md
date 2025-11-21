# AI Agent Web API

## Prerequisites

- A GitHub Models API token (free to get started)

## Getting Started

### 1. Configure Your AI Service

#### GitHub Models Configuration

This application uses GitHub Models (model: gpt-4o-mini) for AI functionality. You'll need to configure your GitHub Models API token:

**Option A: Using aspire managed secrets (Recommended for Development)**
<img width="1551" height="555" alt="image" src="https://github.com/user-attachments/assets/efa2acdf-80b2-436b-a353-f9aa294e6577" />
<img width="907" height="520" alt="image" src="https://github.com/user-attachments/assets/7aa00f37-5c40-4d51-a1bc-59559c9d1d65" />

**Option B: Using Environment Variables**

Set the `GITHUB_TOKEN` environment variable:

- **Windows (PowerShell)**:
  ```powershell
  $env:GITHUB_TOKEN = "your-github-models-token-here"
  ```

- **Linux/macOS**:
  ```bash
  export GITHUB_TOKEN="your-github-models-token-here"
  ```

#### Get a GitHub Models Token

1. Visit [GitHub Models](https://github.com/marketplace/models)
2. Sign in with your GitHub account
3. Select a model (e.g., gpt-4o-mini)
4. Click "Get API Key" or follow the authentication instructions
5. Copy your personal access token


### 2. Run the Application

```bash
aspire run
```
