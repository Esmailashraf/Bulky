var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.BulkyWeb>("bulkyweb");

builder.Build().Run();
