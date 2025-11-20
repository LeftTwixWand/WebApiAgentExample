using Aspire.Hosting.GitHub;

var builder = DistributedApplication.CreateBuilder(args);

var llm = builder.AddGitHubModel("agent-chat", GitHubModel.OpenAI.OpenAIGpt4oMini);

builder.AddProject<Projects.MyWebApiAgent>("web-agent")
    .WithReference(llm);

builder.Build().Run();